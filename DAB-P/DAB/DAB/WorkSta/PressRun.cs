using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DAB
    {
    //保压工站
    sealed class PressRun 
        {
        private static Tool.Delay PressTime = new Tool.Delay();
        private static int BufferStep = 0;
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        public static void AutoRun(ref PVar.WorkType StaWork)
            {
            try
                {
                switch (StaWork.Step)
                    {
                    case 10:
                        if (PVar.Stop_Flag == false)
                            {
                            StaWork.Result = false;
                            StaWork.State = false;
                            PressTime.InitialTime();
                            StaWork.Step = 20;
                            }
                        break;

                    case 20:
                        if (StaWork.State == false && StaWork.Enable )
                            {
                            AddList("保压开始！");
                            StaWork.Enable = false;
                            StaWork.State = true;
                            PressTime.InitialTime();
                            StaWork.Step = 30;
                            }
                        break;

                    case 30:
                        if (EpsonRobot.RobotLivePos.Y > -200)//判断机械手是否在流水线外
                            {
                            AddList("保压无杆气缸向左移动！");
                            Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸左, 1);
                            Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸右, 0);
                            Command.Com1_Send(Command.压力控制打开);
                            PressTime.InitialTime();
                            StaWork.Step = 40;
                            }
                        break;

                    case 40:
                        if (Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 1 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 0)
                            {
                            PressTime.InitialTime();
                            StaWork.Step = 50;
                            }
                        else if (PressTime.TimeIsUp(8000))
                            {
                            AddList("保压无杆气缸左信号感应异常！");
                            ShowList("保压无杆气缸左信号感应异常！");
                            PressTime.InitialTime();
                            BufferStep = 40;
                            StaWork.Step = 8000;
                            }
                        break;

                    case 50:
                        if (PressTime.TimeIsUp(200))
                            {
                            BVar.ProData[2, 6] = Frm_Engineering.fEngineering.Press1_Text.Text;//获取自重的压力值
                            Gg.AbsMotion(0, Axis.保压Z轴, mFunction.Pos.TeachAxis1[Axis.tTag.保压, Axis.Point保压.保压位置], PVar.ParAxis.Speed[Axis.保压Z轴]);
                            PressTime.InitialTime();
                            StaWork.Step = 60;
                            }
                        break;

                    case 60:
                        if (Gg.ZSPD(0, Axis.保压Z轴))
                            {
                            PressTime.InitialTime();
                            StaWork.Step = 70;
                            }
                        break;

                    case 70:
                        if (PressTime.TimeIsUp((int)PVar.ParList.Data[44] * 1000))//配重块保压时间
                            {
                            AddList("保压时间为："+ PVar.ParList.Data[44] * 1000 + "S");
                            Gg.AbsMotion(0, Axis.保压Z轴, mFunction.Pos.TeachAxis1[Axis.tTag.保压, Axis.Point保压.初始位置], PVar.ParAxis.Speed[Axis.保压Z轴]);
                            PressTime.InitialTime();
                            StaWork.Step = 80;
                            }
                        break;

                    case 80:
                        //保压轴和气缸复位
                        if (Gg.ZSPD(0, Axis.保压Z轴) && Gg.GetHomeDi(0, Axis.保压Z轴) == 1)
                            {
                            //保压站无杆气缸双头电磁阀向右
                            AddList("保压无杆气缸向右移动！");
                            Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸左, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸右, 1);
                            PressTime.InitialTime();
                            StaWork.Step = 90;
                            }
                        break;

                    case 90:
                        if (Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 0 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 1)
                            {                           
                            AddList("保压工作完成！");
                            PressTime.InitialTime();
                            StaWork.Step = 100;
                            }
                        else if (PressTime.TimeIsUp(5000))
                            {
                            AddList("保压无杆气缸右信号感应异常！");
                            ShowList("保压无杆气缸右信号感应异常！");
                            BufferStep = 90;
                            StaWork.Step = 8000;
                            }
                        break;

                    case 100:
                        //复位流水线2等待状态
                        PVar.Sta_Work[(int)BVar.工位.流水线2].IsReady = false;
                        PressTime.InitialTime();
                        StaWork.Step = 800;
                        break;

                    case 800:
                        StaWork.Enable = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    //遇到异常，设备先暂停，确定后处理************************
                    case 8000:
                        PVar.IsSystemOnPauseMode = true;
                        PVar.MacHold = true;
                        StaWork.StaHold = true;
                        PVar.Stop_Flag = false;
                        Frm_Main.fMain.Btn_Start.Enabled = false;
                        Frm_Main.fMain.Btn_Pause.Enabled = true;
                        Frm_Main.fMain.Btn_Stop.Enabled = false;
                        Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                        Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;

                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
                        break;
                    }
                }
            catch (Exception exc)
                {
                string Error_Str = "";
                string Error_Str1 = "";
                Frm_Engineering.fEngineering.MacStop();
                MessageBox.Show(exc.Message);
                Error_Str = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_代码异常记录" + ".txt";
                Error_Str1 = "\r\n" + "※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※" + "\r\n" +
                    "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "\r\n" + exc.ToString();
                FileRw.WriteDattxt(Error_Str, Error_Str1);
                }
            }





        }
    }
