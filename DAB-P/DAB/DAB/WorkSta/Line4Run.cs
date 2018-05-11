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
    //复检工站
    sealed class Sta4Run
    {
        private static int ERR_Count = 0;
        private static int BufferStep = 0;
        private static string CheckData;
        public static string[] ShowData;
        private static bool Iswritedata = false;  //是否记录数据 
        private static PVar.CCDDataType[] CCD_Vale = new PVar.CCDDataType[10];
        private static int TimeOut = 0;
        private static int sRtn;
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        public static void AutoRun(ref PVar.WorkType StaWork)
        {
            try
            {
                switch (StaWork.Step)
                {
                    case 10:
                        if (PVar.Stop_Flag == false || Manual.AutoMotionFlag[4])
                        {
                            StaWork.State = false;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        //本站工作状态，工站使能，转盘工作状态，本站是否有产品
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (StaWork.State == false && PVar.Sta_Work[1].State == false && ((StaWork.Enable && StaWork.Result && PVar.Sta_Work[4].IsHaveHSG) || Manual.AutoMotionFlag[4]))
                            {
                                StaWork.State = true;
                                StaWork.Result = false;
 
                                AddList("复检开始开始！");
                                Command.Com3_Send("LMD,SSW,00,3," + "000,");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                StaWork.Step = 10;
                            }
                        }
                        else
                        {
                            if (StaWork.State == false && PVar.Sta_Work[1].State == false && ((StaWork.Enable && StaWork.Result && PVar.Sta_Work[4].IsHaveHSG) || Manual.AutoMotionFlag[4]))
                            {
                                StaWork.State = true;
                                StaWork.Result = false;
                                Gg.SetExDo(0, 0, Gg.OutPut2.机械手排线真空吸, 0);
                                AddList("复检开始开始！");
                                Command.Com3_Send("LMD,SSW,00,3," + "000,");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                StaWork.Step = 10;
                            }
                        }

                        break;

                    case 30:
                        if (Gg.GetExDi(0, Gg.InPut2.流水线对射感应4) == 1 && Gg.GetExDi(0, Gg.InPut2.流水线对射感应5) == 0)
                        {
                            //AddList("复检气缸复位OK！");
                            Iswritedata = true; 
                            Command.Com3_Send("LMD,SPLN,00,4," + "255" + ",");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 40;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 6000)
                            {
                                AddList("复检气缸缩回信号异常！");
                                ShowList("复检气缸缩回信号异常！");
                                BufferStep = 30;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 40:
                        if (API.GetTickCount() - TimeOut > 500)
                        {
                            ERR_Count = 0;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                        }
                        break;

                    case 45:
                        if (ERR_Count >= 2)
                        {

                        
                            BVar.ProData[4, 2] = BVar.FileRorW.ReadINI("CCD程序 ", "颜色", "白色", PVar.PublicParPath);//Frm_Engineering.fEngineering.comboBox_Unitcolor.Text;//产品颜色

                            BVar.ProData[4, 26] = "999";
                            BVar.ProData[4, 27] = "999";
                            BVar.ProData[4, 28] = "999";
                            BVar.ProData[4, 29] = "999";
                            BVar.ProData[4, 30] = "NG";
                            Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                            AddList("4站异常退出工作!");
                            ShowList("4站异常退出工作!");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 150;
                        }
                        else
                        {
                            ERR_Count += 1;
                            if (ERR_Count == 2)
                            {
                                AddList("本站工作即将结束!");
                                ShowList("本站工作即将结束!");
                            }
                            else
                            {
                                AddList("还剩" + (2 - ERR_Count) + "次尝试，超出则本站工作结束!");
                                ShowList("还剩" + (2 - ERR_Count) + "次尝试，超出则本站工作结束!");
                            }
                            Command.Com3_Send("LMD,SPLN,00,4," + "255" + ",");
                            System.Threading.Thread.Sleep(150);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                        }
                        break;

                    case 50:
                        sRtn = Command.TCP_CCD_Send(Command.上相机复检);
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 60;
                            }
                            else if (sRtn == 2) //网络链接异常
                            {
                                AddList("网络链接异常！");
                                ShowList("网络链接异常！");
                                TimeOut = API.GetTickCount();
                                Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                                if (PVar.ParList.CheckSts[24])
                                {
                                    BufferStep = 45;
                                    StaWork.Step = 8000;
                                }
                                else
                                {
                                    Iswritedata = false;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 150;
                                }

                            }
                            else
                            {
                                AddList("网络命令发送失败！");
                                ShowList("网络命令发送失败！");
                                TimeOut = API.GetTickCount();
                                Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                                if (PVar.ParList.CheckSts[24])
                                {
                                    BufferStep = 45;
                                    StaWork.Step = 8000;
                                }
                                else
                                {
                                    Iswritedata = false;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 150;
                                }
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 60;
                        }
                        break;

                    case 60:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Command.CCD2_Resule && PVar.CCD2_Data[0] == Command.上相机复检)
                            {
                                AddList("复检角度数据收到！");
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].CC = Convert.ToDouble(PVar.CCD2_Data[4]);
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[5]);

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 70;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 3000)
                                {
                                    AddList("等待复检角度数据超时！");
                                    TimeOut = API.GetTickCount();
                                    Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                                    if (PVar.ParList.CheckSts[24])
                                    {
                                        BufferStep = 45;
                                        StaWork.Step = 8000;
                                    }
                                    else
                                    {
                                        Iswritedata = false;
                                        TimeOut = API.GetTickCount();
                                        StaWork.Step = 150;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 200)
                            {
                                AddList("复检角度数据收到！");
                                CCD_Vale[1].X = 0;
                                CCD_Vale[1].Y = 0;
                                CCD_Vale[1].T = 0;
                                CCD_Vale[1].CC = 0;
                                CCD_Vale[1].Judge = 0;

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 70;
                            }
                        }

                        break;

                    case 70:
                        if (CCD_Vale[1].Judge == 0)
                        {
                            Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 80;
                        }
                        else if (CCD_Vale[1].Judge == 1)
                        {
                            AddList("复检角度模型搜索错误！");
                            ShowList("复检角度模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                            if (PVar.ParList.CheckSts[24])
                            {
                                BufferStep = 45;
                                StaWork.Step = 8000;
                            }
                            else
                            {
                                Iswritedata = false;
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 150;
                            }
                        }
                        else
                        {
                            AddList("CCD复检角度其他异常！");
                            ShowList("CCD复检角度其他异常！");
                            TimeOut = API.GetTickCount();
                            Command.Com3_Send("LMD,SPLN,00,4," + "000" + ",");
                            if (PVar.ParList.CheckSts[24])
                            {
                                BufferStep = 45;
                                StaWork.Step = 8000;
                            }
                            else
                            {
                                Iswritedata = false;
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 150;
                            }
                        }
                        break;

                    case 80:
                        Gg.SetExDo(0, 0, Gg.OutPut2.机械手排线真空吸, 1);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 90;
                        break;

                    case 90:
                        if (Gg.GetExDi(0, Gg.InPut2.流水线对射感应4) == 0 && Gg.GetExDi(0, Gg.InPut2.流水线对射感应5) == 1)
                        {
                            AddList("复检气缸伸出OK！");

                            TimeOut = API.GetTickCount();
                            StaWork.Step = 100;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 8000)
                            {
                                AddList("复检气缸伸出信号异常！");
                                ShowList("复检气缸伸出信号异常！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 90;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 100:
                        if (API.GetTickCount() - TimeOut > 900)
                        {
                            Command.Com3_Send("LMD,SPLN,00,3," + "255" + ",");
                        }

                        if (API.GetTickCount() - TimeOut > 1000)
                        {
                            ERR_Count = 0;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 110;
                        }
                        break;

                    case 105:
                        if (ERR_Count >= 3)
                        {
                            
                            BVar.ProData[4, 2] = BVar.FileRorW.ReadINI("CCD程序 ", "颜色", "白色", PVar.PublicParPath);// Frm_Engineering.fEngineering.comboBox_Unitcolor.Text;//产品颜色

                            BVar.ProData[4, 26] = "999";
                            BVar.ProData[4, 27] = "999";
                            BVar.ProData[4, 28] = "999";
                            BVar.ProData[4, 29] = "999";
                            BVar.ProData[4, 30] = "NG";
                            Command.Com3_Send("LMD,SPLN,00,3," + "000" + ",");
                            AddList("4站异常退出工作!");
                            ShowList("4站异常退出工作!");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 150;
                        }
                        else
                        {
                            ERR_Count += 1;
                            if (ERR_Count == 3)
                            {
                                AddList("本站工作即将结束!");
                                ShowList("本站工作即将结束!");
                            }
                            else
                            {
                                AddList("还剩" + (3 - ERR_Count) + "次尝试，超出则本站工作结束!");
                                ShowList("还剩" + (3 - ERR_Count) + "次尝试，超出则本站工作结束!");
                            }
                            Command.Com3_Send("LMD,SPLN,00,3," + "255" + ",");
                            System.Threading.Thread.Sleep(150);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 110;
                        }
                        break;

                    case 110:
                        sRtn = Command.TCP_CCD_Send(Command.上相机复检);
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 120;
                            }
                            else if (sRtn == 2) //网络链接异常
                            {
                                AddList("网络链接异常！");
                                ShowList("网络链接异常！");
                                TimeOut = API.GetTickCount();
                                if (PVar.ParList.CheckSts[24])
                                {
                                    BufferStep = 105;
                                    StaWork.Step = 8000;
                                }
                                else
                                {
                                    Iswritedata = false;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 150;
                                }
                            }
                            else
                            {
                                AddList("网络命令发送失败！");
                                ShowList("网络命令发送失败！");
                                TimeOut = API.GetTickCount();
                                Command.Com3_Send("LMD,SPLN,00,3," + "000" + ",");
                                if (PVar.ParList.CheckSts[24])
                                {
                                    BufferStep = 105;
                                    StaWork.Step = 8000;
                                }
                                else
                                {
                                    Iswritedata = false;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 150;
                                }
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 120;
                        }
                        break;

                    case 120:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Command.CCD2_Resule && PVar.CCD2_Data[0] == Command.上相机复检)
                            {
                                AddList("复检同心度数据收到！");
                                CCD_Vale[2].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[2].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[2].T = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[2].CC = Convert.ToDouble(PVar.CCD2_Data[4]);
                                CCD_Vale[2].Judge = Convert.ToDouble(PVar.CCD2_Data[5]);

                                CCD_Vale[2].Up = Convert.ToDouble(PVar.CCD2_Data[6]);
                                CCD_Vale[2].Down = Convert.ToDouble(PVar.CCD2_Data[7]);
                                CCD_Vale[2].Left = Convert.ToDouble(PVar.CCD2_Data[8]);
                                CCD_Vale[2].Right = Convert.ToDouble(PVar.CCD2_Data[9]);

                               
                                BVar.ProData[4, 2] = BVar.FileRorW.ReadINI("CCD程序 ", "颜色", "白色", PVar.PublicParPath);// Frm_Engineering.fEngineering.comboBox_Unitcolor.Text;//产品颜色

                                BVar.ProData[4, 26] = CCD_Vale[2].X.ToString("0.000");
                                BVar.ProData[4, 27] = CCD_Vale[2].Y.ToString("0.000");
                                BVar.ProData[4, 28] = CCD_Vale[2].T.ToString("0.000");
                                BVar.ProData[4, 29] = CCD_Vale[2].CC.ToString("0.000");
                                if (CCD_Vale[2].CC <= 0.05 && Math.Abs(CCD_Vale[2].T) <= 1)
                                {
                                    BVar.ProData[4, 30] = "OK";
                                }
                                else
                                {
                                    BVar.ProData[4, 30] = "NG";
                                }
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 130;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 5000)
                                {
                                    AddList("等待复检同心度数据超时！");
                                    TimeOut = API.GetTickCount();
                                    Command.Com3_Send("LMD,SPLN,00,3," + "000" + ",");
                                    if (PVar.ParList.CheckSts[24])
                                    {
                                        BufferStep = 105;
                                        StaWork.Step = 8000;
                                    }
                                    else
                                    {
                                        Iswritedata = false;
                                        TimeOut = API.GetTickCount();
                                        StaWork.Step = 150;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 200)
                            {
                                AddList("复检同心度数据收到！");
                                CCD_Vale[2].X = 0;
                                CCD_Vale[2].Y = 0;
                                CCD_Vale[2].T = 0;
                                CCD_Vale[2].CC = 0;
                                CCD_Vale[2].Judge = 0;

                          
                                BVar.ProData[4, 2] = BVar.FileRorW.ReadINI("CCD程序 ", "颜色", "白色", PVar.PublicParPath);// Frm_Engineering.fEngineering.comboBox_Unitcolor.Text;//产品颜色


                                BVar.ProData[4, 26] = CCD_Vale[2].X.ToString("0.000");
                                BVar.ProData[4, 27] = CCD_Vale[2].Y.ToString("0.000");
                                BVar.ProData[4, 28] = CCD_Vale[2].T.ToString("0.000");
                                BVar.ProData[4, 29] = CCD_Vale[2].CC.ToString("0.000");

                                if (CCD_Vale[2].CC <= 0.05 && CCD_Vale[2].T <= 1 && CCD_Vale[2].Up >= 0.1 && CCD_Vale[2].Up <= 0.3 && CCD_Vale[2].Down >= 0.1 && CCD_Vale[2].Down <= 0.3 && CCD_Vale[2].Left >= 0.1 && CCD_Vale[2].Left <= 0.3 && CCD_Vale[2].Right >= 0.1 && CCD_Vale[2].Right <= 0.3)
                                {
                                    BVar.ProData[4, 30] = "OK";
                                }
                                else
                                {
                                    BVar.ProData[4, 30] = "NG";
                                }
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 130;
                            }
                        }
                        break;

                    case 130:
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 140;
                        break;

                    case 140:
                        if (CCD_Vale[2].Judge == 0)
                        {
                            Command.Com3_Send("LMD,SPLN,00,3," + "000" + ",");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 150;
                        }
                        else if (CCD_Vale[2].Judge == 1)
                        {
                            AddList("复检同心度模型搜索错误！");
                            ShowList("复检同心度模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            Command.Com3_Send("LMD,SPLN,00,3," + "000" + ",");
                            if (PVar.ParList.CheckSts[24])
                            {
                                BufferStep = 105;
                                StaWork.Step = 8000;
                            }
                            else
                            {
                                Iswritedata = false;
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 150;
                            }
                        }
                        else
                        {
                            AddList("CCD复同心度度其他异常！");
                            ShowList("CCD复同心度度其他异常！");
                            TimeOut = API.GetTickCount();
                            Command.Com3_Send("LMD,SPLN,00,3," + "000" + ",");
                            if (PVar.ParList.CheckSts[24])
                            {
                                BufferStep = 105;
                                StaWork.Step = 8000;
                            }
                            else
                            {
                                Iswritedata = false;
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 150;
                            }
                        }
                        break;

                    case 150:
                        Gg.SetExDo(0, 0, Gg.OutPut2.机械手排线真空吸, 0);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 300;
                        break;

                    ////复检数据处理
                    case 300:
                        if (PVar.ParList.CheckSts[17]) { BVar.ProData[4, 30] = "OK"; }
                        if (BVar.ProData[4, 30] == "OK")
                        {
                            StaWork.Result = true;
                        }
                        //写入数据
                        if (Iswritedata) { Write_FinalData(); }
                        if (PVar.ParList.CheckSts[48] == false)
                            {
                     
                            }                    
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 800;
                        break;

                    case 800:
                        StaWork.Enable = false;
                        ////StaWork.Result = true; 做为最总结过判断
                        StaWork.State = false;
                        Manual.AutoMotionFlag[4] = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        Manual.AutoMotionFlag[4] = false;
                        StaWork.Step = 10;
                        break;

                    //遇到异常，设备先暂停，确定后处理************************
                    case 8000:
                        if (Manual.AutoMotionFlag[4])
                        {
                            if (Manual.HoldFlag[4])
                            {
                                Manual.HoldFlag[4] = false;
                                Frm_Engineering.fEngineering.CmdHold.Text = "暂停";
                                Frm_Engineering.fEngineering.CmdHold.BackColor = Color.BurlyWood;
                                ShowList("运动已继续");
                            }
                            else
                            {
                                Manual.HoldFlag[4] = true;
                                Frm_Engineering.fEngineering.CmdHold.Text = "继续";
                                Frm_Engineering.fEngineering.CmdHold.BackColor = Color.Red;
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
                            //Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;
                        }

                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
                        break;
                }

            }
            catch (Exception ex)
            {
                string Error_Str = "";
                string Error_Str1 = "";
                Frm_Engineering.fEngineering.MacStop();
                MessageBox.Show(ex.Message);
                Error_Str = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_代码异常记录" + ".txt";
                Error_Str1 = "\r\n" + "※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※" + "\r\n" +
                    "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "\r\n" + ex.ToString();
                FileRw.WriteDattxt(Error_Str, Error_Str1);
            }
        }

        public static void Write_FinalData()
        {
            TimeOut = API.GetTickCount();
            System.EventArgs Write_FinalData_e = default(System.EventArgs);
            string fileFinalData = "E:\\BZ-Data\\DAB\\CheckData\\" + DateTime.Now.ToString("yyyyMM") + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            if (BVar.ProData[4, 30] == "OK")
            {
                PVar.OKCounts++;
            }
            else
            {
                PVar.NGCounts++;
            }
            PVar.ProductCounts++;
            Frm_Engineering.fEngineering.Product_Num.Text = System.Convert.ToString(PVar.ProductCounts);
            BVar.FileRorW.WriteINI("Product", "Counts", Convert.ToString(PVar.ProductCounts), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("Product", "OKCounts", Convert.ToString(PVar.OKCounts), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("Product", "NGCounts", Convert.ToString(PVar.NGCounts), PVar.BZ_YieldDataFileName);

            Frm_Production.ExchangeCpkData();
            PVar.tmpCpkData.X[0] = Convert.ToDouble(BVar.ProData[4, 26]);
            PVar.tmpCpkData.Y[0] = Convert.ToDouble(BVar.ProData[4, 27]);
            PVar.tmpCpkData.CC[0] = Convert.ToDouble(BVar.ProData[4, 29]);
            PVar.tmpCpkData.A[0] = Convert.ToDouble(BVar.ProData[4, 28]);
            PVar.tmpCpkData.ProTime[0] = DateTime.Now;

            Frm_Production.fProduction.Cpk_X_Click(Frm_Production.fProduction.Cpk_X, Write_FinalData_e);
            Frm_Production.fProduction.BTN_X_Click(Frm_Production.fProduction.BTN_X, Write_FinalData_e);
            BVar.FileRorW.WriteDAT(PVar.tmpCpkData, PVar.BZ_CPKDataFilePath);

            PVar.TotalLifeCycles++;
            Frm_MachineInfo.fMachineInfo.Label_TotalLifeCycle.Text = Convert.ToString(PVar.TotalLifeCycles);
            BVar.FileRorW.WriteINI("Product", "TotalLifeCycles", Convert.ToString(PVar.TotalLifeCycles), PVar.BZ_YieldDataFileName);

            if (BVar.ProData[4, 30] == "NG")
            {
                PVar.TotalLifeRejects++;
            }
            Frm_MachineInfo.fMachineInfo.Label_TotalLifeRejects.Text = Convert.ToString(PVar.TotalLifeRejects);

            BVar.FileRorW.WriteINI("Product", "TotalLifeRejects", Convert.ToString(PVar.TotalLifeRejects), PVar.BZ_YieldDataFileName);

            Frm_Production.fProduction.UPH.BZ_BigText = Convert.ToString(Frm_Production.fProduction.CalculateUPH());

            Frm_Production.fProduction.CalculateYield();

            CheckData = DateTime.Now.ToString("yyyy/MM/dd") + "," + Convert.ToString(DateAndTime.TimeOfDay.TimeOfDay) + "," + BVar.ProData[4, 1] + "," + BVar.ProData[4, 2] + "," + BVar.ProData[4, 3] + "," + BVar.ProData[4, 7] + "," + BVar.ProData[4, 30] + "," + BVar.ProData[4, 26] + "," + BVar.ProData[4, 27] + "," + BVar.ProData[4, 29] + "," + BVar.ProData[4, 28] + "," + BVar.ProData[4, 4] + "," + BVar.ProData[4, 5] + "," + BVar.ProData[4, 6] + "," + CCD_Vale[2].Up + "," + CCD_Vale[2].Down + "," + CCD_Vale[2].Left + "," + CCD_Vale[2].Right;
            BVar.FileRorW.WriteCheckDataCsv(CheckData, fileFinalData); 

            PVar.DataCount++; //数据计数
            PVar.DataCount = PVar.DataCount % 100;
            BVar.FileRorW.WriteINI("Data100Count", "Count", System.Convert.ToString(PVar.DataCount), PVar.ListDataIniPath);



            //向工程界面数据表格添加数据
            //1：日期  2：时间  3：载具号  4：产品颜色  5：周期时间 6：结果  7：X值  8：Y值  9：角度  10：同心度
            ShowData = new[] { DateTime.Now.ToString("yyyy/MM/dd"), Convert.ToString(DateAndTime.TimeOfDay.TimeOfDay), BVar.ProData[4, 1], BVar.ProData[4, 2], BVar.ProData[4, 3], BVar.ProData[4, 30], BVar.ProData[4, 26], BVar.ProData[4, 27], BVar.ProData[4, 29], BVar.ProData[4, 28] };


            for (int col = 1; col <= PVar.DataGrid_CheckDataHeadName.Length; col++)
            {
                BVar.FileRorW.WriteINI(PVar.DataCount.ToString(), PVar.DataGrid_CheckDataHeadName[col - 1], ShowData[col - 1], PVar.ListDataIniPath);
                //:FunctionSub.Grid_TestData_Show(Frm_Engineering.fEngineering.DataGrid_CheckData, Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1, col - 1, BVar.ProData[4, 30]);
            }

            try
            {
                Frm_Engineering.fEngineering.DataGrid_CheckData.Rows.Add(ShowData);
                Frm_Engineering.fEngineering.DataGrid_CheckData.FirstDisplayedScrollingRowIndex = Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1;
                Frm_Engineering.fEngineering.DataGrid_CheckData.CurrentCell = Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[0];
                Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Selected = true;
                
                //:更新数据界面背景颜色
                if (Convert.ToString(Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[5].Value) == "NG")
                {
                    Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[5].Style.ForeColor = Color.Red;
                    Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[5].Style.BackColor = Color.FromArgb(175, 218, 150);
                }
                else
                {
                    Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[5].Style.ForeColor = Color.Black;
                    Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[5].Style.BackColor = Color.White;
                }
                
                //:判断界面数据是否增加新的一行
                if (Frm_Engineering.fEngineering.DataGrid_CheckData.Rows.Count >= 100)
                {
                    Frm_Engineering.fEngineering.DataGrid_CheckData.Rows.RemoveAt(0);
                }
                int TimeOut1 = 0;
                TimeOut1 = API.GetTickCount() - TimeOut;
            }

            catch (Exception)
            {
                ShowList("工程界面添加数据异常！");
            }
        }
    }
}
