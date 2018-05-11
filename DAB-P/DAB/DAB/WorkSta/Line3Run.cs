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
    sealed class Line3Run
    {
        private static Tool.Delay Line3Time = new Tool.Delay();
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
                            StaWork.State = false;
                            Line3Time.InitialTime();
                            StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        if (StaWork.State == false  && StaWork.IsHaveFix)
                            {
                            AddList("组装开始！");
                            StaWork.State = true;

                            BVar.ProData[3, 1] = BVar.ProData[2, 1];//Bezel条码
                            BVar.ProData[3, 3] = BVar.ProData[2, 3];//载具条码
                            Line3Time.InitialTime();
                            StaWork.Step = 30;
                            }
                        else if (Line3Time.TimeIsUp(50))
                            {
                            StaWork.Step = 10;
                            }
                        break;

                    case 30:
                        if (PVar.空跑)
                        {
                            if (Line3Time.TimeIsUp(2000))
                            {
                                AddList("载具流出感应到！");
                                Linechange.SetMotor3(true, 10);
                                Line3Time.InitialTime();
                                StaWork.Step = 40;
                                
                            }
                        }
                        else
                        {
                        if (Linechange.LineOut() == 1)
                            {
                            AddList("载具流出感应到！");
                            Line3Time.InitialTime();
                            StaWork.Step = 40;
                            Linechange.SetMotor3(false, PVar.ParList.Data[43]);
                            }
                        else if (Line3Time.TimeIsUp(5000))
                            {
                            Line3Time.InitialTime();
                            StaWork.Step = 40;
                            }
                        }

                        break;

                    case 40:
                        if (Line3Time.TimeIsUp(1000))
                            {
                            AddList("流水线3马达停止！");
                            Linechange.SetMotor3(false, PVar.ParList.Data[43]);
                            Line3Time.InitialTime();
                            StaWork.Step = 50;
                            }
                        break;

                    case 50:
                        if (Linechange.LineOut() == 0)
                            {
                            AddList("载具已经取走！");
                            StaWork.IsHaveFix = false;
                            Line3Time.InitialTime();
                            StaWork.Step = 800;
                            }
                        break;

                    case 800:
                        StaWork.Enable = false;
                        StaWork.Result = true;
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
                        if (Manual.AutoMotionFlag[3])
                        {
                            if (Manual.HoldFlag[3])
                            {
                                Manual.HoldFlag[3] = false;
                                Frm_Engineering.fEngineering.CmdHoldPress.Text = "暂停";
                                Frm_Engineering.fEngineering.CmdHoldPress.BackColor = Color.BurlyWood;
                                ShowList("运动已继续");
                            }
                            else
                            {
                                Manual.HoldFlag[3] = true;
                                Frm_Engineering.fEngineering.CmdHoldPress.Text = "继续";
                                Frm_Engineering.fEngineering.CmdHoldPress.BackColor = Color.Red;
                                ShowList("运动已暂停");
                            }
                        }
                        else
                        {
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
                        }

                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
                        break;

                    //严重错误，急停处理
                    case 10000:
                        Frm_Engineering.fEngineering.MacStop();
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
