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
    //供料工站
    sealed class Line0Run
        {
        private static Tool.Delay Line0Time = new Tool.Delay();
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
                            StaWork.IsHaveFix = false;
                            StaWork.Result = false;
                            StaWork.State = false;
                            Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 1);
                            Line0Time.InitialTime();
                            StaWork.Step = 20;
                            }
                        break;

                    case 20:
                        if (PVar.空跑)
                        {
                            if (StaWork.State == false && Gg.GetExDi(1, Gg.InPut2.流水线对射感应1) == 0 && Linechange.LineIN() == 0)
                            {
                                //启动触发，载具感应触发，防呆无触发，说明有载具
                                AddList("启动开始！");
                                StaWork.State = true;
                                StaWork.IsHaveFix = true;//入口有载具
                                Line0Time.InitialTime();
                                StaWork.Step = 30;
                            }
                        }
                        else//******************************************************
                        {
                            if (StaWork.State == false && Gg.GetDi(0, Gg.InPut0.启动按钮) == 1 && Gg.GetExDi(1, Gg.InPut2.流水线对射感应1) == 1 && Linechange.LineIN() == 0)
                            {
                                //启动触发，载具感应触发，防呆无触发，说明有载具
                                AddList("启动开始！");
                                StaWork.State = true;
                                StaWork.IsHaveFix = true;//入口有载具
                                Line0Time.InitialTime();
                                StaWork.Step = 30;
                            }
                        }
                        break;

                    case 30:
                        if (PVar.空跑)
                        {
                            if (PVar.Sta_Work[(int)BVar.工位.流水线1].IsHaveFix == false && PVar.Stop_Flag == false && Gg.GetExDi(1, Gg.InPut2.流水线对射感应2) == 0 &&
                                Gg.GetExDi(1, Gg.InPut2.流水线对射感应3) == 0 && PVar.Sta_Work[(int)BVar.工位.流水线1].State == false)
                            {
                                StaWork.IsHaveFix = false;//本站载具标志复位
                                AddList("载具开始放行，等待流水线1接收!");
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 0);
                                Linechange.SetMotor1(true, PVar.ParList.Data[43]);
                                Line0Time.InitialTime();
                                StaWork.Step = 40;
                            }
                            else
                            {
                                if (PVar.Stop_Flag)
                                {
                                    StaWork.State = false;
                                    Line0Time.InitialTime();
                                    StaWork.Step = 10;
                                }
                            }

                        }
                        else//*******************************************
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应1) == 0 || Linechange.LineIN() == 1)
                            {
                                AddList("载具感性信号异常，重新启动");
                                PVar.Sta_Work[0].IsHaveFix = false;
                                Line0Time.InitialTime();
                                StaWork.Step = 10;
                                return;
                            }
                            //等待放行*****************************
                            if (PVar.Stop_Flag == false && Gg.GetExDi(1, Gg.InPut2.流水线对射感应2) == 0 &&
                                Gg.GetExDi(1, Gg.InPut2.流水线对射感应3) == 0 && PVar.Sta_Work[(int)BVar.工位.流水线1].State == false)
                            {
                                StaWork.IsHaveFix = false;//本站载具标志复位
                                AddList("载具开始放行，等待流水线1接收!");
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 0);
                                Linechange.SetMotor1(true, PVar.ParList.Data[43]);
                                Line0Time.InitialTime();
                                StaWork.Step = 40;
                            }
                        }
                        break;

                    case 40:
                        if (PVar.空跑)
                        {
                            if (Line0Time.TimeIsUp(1000))
                            {
                                AddList("载具开始放行完成！");
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 1);
                                Line0Time.InitialTime();
                                StaWork.Step = 50;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应1) == 0)
                            {
                                AddList("载具开始放行完成！");
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 1);
                                Line0Time.InitialTime();
                                StaWork.Step = 50;
                            }
                        }
                        break;

                    case 50:
                        if (PVar.空跑)
                        {
                            if (Line0Time.TimeIsUp(1000))
                            {
                                AddList("流水线对射感应2触发！");
                                AddList("流水线1开始减速！");
                                Linechange.SetMotor1(true, 10);
                                Line0Time.InitialTime();
                                StaWork.Step = 60;
                            }
                        }
                        else//********************************************
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应2) == 1)
                            {
                                AddList("流水线对射感应2触发！");
                                Linechange.SetMotor1(true, 10);
                                Line0Time.InitialTime();
                                StaWork.Step = 60;
                            }
                        }
                        break;

                    case 60:
                        if (PVar.空跑)
                        {
                            if (Line0Time.TimeIsUp(1000))
                            {
                                AddList("载具到达流水线1！");
                                Linechange.SetMotor1(true, 5);
                                Line0Time.InitialTime();
                                StaWork.Step = 70;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应3) == 1)
                            {
                                AddList("载具到达流水线1！");
                                Line0Time.InitialTime();
                                StaWork.Step = 70;
                            }
                        }
                        break;

                    case 70:
                        if (Line0Time.TimeIsUp(200))
                            {
                            PVar.Sta_Work[(int)BVar.工位.流水线1].IsHaveFix = true;
                            AddList("流水线1电机关闭！");
                            Linechange.SetMotor1(false, 0);
                            Line0Time.InitialTime();
                            StaWork.Step = 80;
                            }
                        break;

                    case 80:
                        AddList("确认按钮是否松开？");
                        Line0Time.InitialTime();
                        StaWork.Step = 100;
                        break;

                    case 100:
                        if (Gg.GetDi(0, Gg.InPut0.启动按钮) == 0)
                            {
                            AddList("按钮松开！");
                            Line0Time.InitialTime();
                            StaWork.Step = 800;
                            }
                        break;

                    case 800:
                        Manual.AutoMotionFlag[0] = false;
                        StaWork.Enable = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        Manual.AutoMotionFlag[0] = false;
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    //遇到异常，设备先暂停，确定后处理************************
                    case 8000:
                        if (Manual.AutoMotionFlag[0])
                            {
                            if (Manual.HoldFlag[0])
                                {
                                Manual.HoldFlag[0] = false;
                                Frm_Engineering.fEngineering.CmdHoldS0.Text = "暂停";
                                Frm_Engineering.fEngineering.CmdHoldS0.BackColor = Color.BurlyWood;
                                ShowList("运动已继续");
                                }
                            else
                                {
                                Manual.HoldFlag[0] = true;
                                Frm_Engineering.fEngineering.CmdHoldS0.Text = "继续";
                                Frm_Engineering.fEngineering.CmdHoldS0.BackColor = Color.Red;
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
