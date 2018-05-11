using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DAB
    {
    //流水线1
    sealed class Line1Run
        {
        private static Tool.Delay Line1Time = new Tool.Delay();
        private static int TriggerCount = 0; 
        public static bool CT_Start;
        private static string[] tempTestData = new string[11];
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
                            StaWork.IsHaveBezel = false;
                            StaWork.IsHaveSN = false;
                            StaWork.Result = false;
                            StaWork.State = false;
                            TriggerCount = 0;
                            Line1Time.InitialTime();
                            StaWork.Step = 20;
                            }
                        break;
                        //if (PVar.空跑)
                        //{

                        //}
                        //else
                        //{

                        //}
                    case 20:
                        if (PVar.空跑)
                        {
                            if (StaWork.State == false && StaWork.IsHaveFix)
                            {
                                AddList("流水线1开始工作！");
                                StaWork.State = true;
                                BVar.ProData[1, 1] = "";//Bezel条码
                                BVar.ProData[1, 2] = "";//PDCA返回条码
                                BVar.ProData[1, 3] = "";//载具条码
                                Line1Time.InitialTime();
                                StaWork.Step = 200;
                            }
                            else
                            {
                                if (Line1Time.TimeIsUp(20))
                                {
                                    Line1Time.InitialTime();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        else
                        {
                            if (StaWork.State == false && StaWork.IsHaveFix && Gg.GetExDi(1, Gg.InPut2.流水线对射感应2) == 1 && Gg.GetExDi(1, Gg.InPut2.流水线对射感应3) == 1)
                            {
                                AddList("流水线1开始工作！");
                                StaWork.State = true;
                                BVar.ProData[1, 1] = "";//Bezel条码
                                BVar.ProData[1, 2] = "";//PDCA返回条码
                                BVar.ProData[1, 3] = "";//载具条码
                                Line1Time.InitialTime();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                if (Line1Time.TimeIsUp(20))
                                {
                                    Line1Time.InitialTime();
                                    StaWork.Step = 10;
                                }                              
                            }
                        }
                        break;

                    case 30:
                        
                        if (PVar.ParList.CheckSts[3]) //左右机切换
                            {
                            Frm_Engineering.fEngineering.Lab_Station1.Text = "";
                            }
                        else
                            {
                            Frm_Engineering.fEngineering.Lab_Station3.Text = "";
                            }
                        if (PVar.ParList.CheckSts[8])
                            {
                            StaWork.IsHaveSN = true;
                            StaWork.IsHaveBezel = true;
                            BVar.ProData[1, 1] = Frm_Engineering.fEngineering.Txt_BarCode.Text;
                            if (PVar.ParList.CheckSts[3]) //左右机切换
                                {
                                Frm_Engineering.fEngineering.Lab_Station1.Text = BVar.ProData[1, 1];
                                }
                            else
                                {
                                Frm_Engineering.fEngineering.Lab_Station3.Text = BVar.ProData[1, 1];
                                }
                            Line1Time.InitialTime();
                            StaWork.Step = 200;
                            }
                        else
                            {
                            AddList("触发条码枪，获取Bezel条码");
                            TriggerCount += 1;
                            if (Command.TCP_Barcode_Send("||>trigger on") == 1)
                                {
                                Line1Time.InitialTime();
                                StaWork.Step = 50;
                                }
                            else
                                {
                                AddList("条码枪网络异常！");
                                ShowList("条码枪网络异常！");
                                Line1Time.InitialTime();
                                StaWork.Step = 900;//跳到异常处理
                                }
                            }

                        break;

                    case 50:
                        if (BVar.BarCodeData.GetCodeOK)
                            {
                            BVar.BarCodeData.GetCodeOK = false;
                            StaWork.IsHaveSN = true;
                            StaWork.IsHaveBezel = true;
                            BVar.ProData[1, 1] = BVar.BarCodeData.sData.Trim();
                            if (PVar.ParList.CheckSts[3]) //左右机切换
                                {
                                Frm_Engineering.fEngineering.Lab_Station1.Text = BVar.ProData[1, 1];
                                }
                            else
                                {
                                Frm_Engineering.fEngineering.Lab_Station3.Text = BVar.ProData[1, 1];
                                }
                            AddList("Bezel条码:" + BVar.ProData[1, 1]);
                            if (PVar.ParList.CheckSts[20])//PDCA开启
                                {
                                AddList("等待上传PDCA，检测是否过SFC!");
                                }
                             Line1Time.InitialTime();
                            StaWork.Step = 100;
                            }
                        else if (Line1Time.TimeIsUp(200))
                            {
                            if (TriggerCount < 3)
                                {
                                AddList("重新触发条码枪！");
                                Line1Time.InitialTime();
                                StaWork.Step = 30;//返回重新触发条码
                                }
                            else
                                {
                                AddList("条码枪获取SN失败！");
                                BVar.RecordErrInfo("HsgSnErr");
                                StaWork.IsHaveSN = false;
                                StaWork.Result = false;
                                Line1Time.InitialTime();
                                StaWork.Step = 900;//跳到异常处理
                                }
                            }
                        break;


                       //*********************************传PDCA数据,检测是否过路径***********************************
                    case 100:
                        if (PVar.ParList.CheckSts[20])//PDCA开启
                            {
                            if (PDCA.PDCAIsWorking==false)
                                {
                                AddList("开始上传PDCA");
                                PDCA.PDCAIsWorking = true;
                                PDCA.UpLoadStep = 10;
                                Line1Time.InitialTime();
                                StaWork.Step = 110;
                                }                       
                            }
                        else
                            {
                            AddList("PDCA关闭，直接跳过SFC！");
                            Line1Time.InitialTime();
                            StaWork.Step = 110;
                            }
                        break;

                    case 110:
                        Line1Time.InitialTime();
                        StaWork.Step = 200;
                        break;

                    case 200:
                        if (PVar.空跑)
                        {
                            if (PVar.Stop_Flag == false && Gg.GetExDi(1, Gg.InPut2.流水线对射感应4) == 0 &&
                                Gg.GetExDi(1, Gg.InPut2.流水线对射感应5) == 0 && PVar.Sta_Work[(int)BVar.工位.流水线2].State == false)
                            {

                                PVar.Sta_Work[(int)BVar.工位.流水线2].Enable =  true;
                                AddList("载具开始放行，等待流水线2接收!");
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸2, 0);
                                Frm_Engineering.fEngineering.Txt_BarCode.Text = "";
                                Linechange.SetMotor1(true, PVar.ParList.Data[43]);
                                Linechange.SetMotor2(true, PVar.ParList.Data[43]);
                                Line1Time.InitialTime();
                                StaWork.Step = 210;
                            }
                            else
                            {
                                if (PVar.Stop_Flag)
                                {
                                    StaWork.State = false;
                                    Line1Time.InitialTime();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        else
                        {
                        //等待放行*****************************
                        if (PVar.Stop_Flag == false && Gg.GetExDi(1, Gg.InPut2.流水线对射感应4) == 0 &&
                            Gg.GetExDi(1, Gg.InPut2.流水线对射感应5) == 0 && PVar.Sta_Work[(int)BVar.工位.流水线2].State == false)
                            {
                            
                            PVar.Sta_Work[(int)BVar.工位.流水线2].Enable = StaWork.IsHaveSN ? true : false; 
                            AddList("载具开始放行，等待流水线2接收!");
                            Gg.SetDo(0, Gg.OutPut0.阻挡气缸2, 0);
                            Frm_Engineering.fEngineering.Txt_BarCode.Text = "";
                            Linechange.SetMotor1(true, PVar.ParList.Data[43]);
                            Linechange.SetMotor2(true, PVar.ParList.Data[43]);
                            Line1Time.InitialTime();
                            StaWork.Step = 210;
                            }
                        }
                        break;

                    case 210:
                        if (PVar.空跑)
                        {
                            if (Line1Time.TimeIsUp(1000))
                            {                               
                                AddList("载具放行完成！");
                                PVar.Sta_Work[(int)BVar.工位.流水线1].IsHaveFix = false;
                                Linechange.SetMotor1(false, PVar.ParList.Data[43]);
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸2, 1);
                                Line1Time.InitialTime();
                                StaWork.Step = 220;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应3) == 0)
                            {
                                AddList("载具放行完成！");
                                PVar.Sta_Work[(int)BVar.工位.流水线1].IsHaveFix = false;
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸2, 1);
                                Line1Time.InitialTime();
                                StaWork.Step = 220;
                            }
                            else if (Line1Time.TimeIsUp(5000))
                            {
                                AddList("流水线1放行载具超时！");
                                ShowList("流水线1放行载具超时！");
                                Line1Time.InitialTime();
                                StaWork.Step = 220;
                            }
                        }
                        break;

                    case 220:
                        if (PVar.空跑)
                        {
                            if (Line1Time.TimeIsUp(1500))
                            {
                                AddList("载具到达流水线2！");
                                AddList("流水线2开始减速！");
                                Linechange.SetMotor2(true, 10);
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 1);
                                Line1Time.InitialTime();
                                StaWork.Step = 240;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应4) == 1)
                            {
                                AddList("载具到达流水线2！");
                                Line1Time.InitialTime();
                                StaWork.Step = 230;
                            }
                            else if (Line1Time.TimeIsUp(5000))
                            {
                                AddList("流水线2接收载具超时！");
                                ShowList("流水线2接收载具超时！");
                                Line1Time.InitialTime();
                                StaWork.Step = 230;
                            }
                        }
                        break;

                    case 230:
                        if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应5) == 1)
                            {
                            AddList("流水线2收到产品完成！");                          
                            Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 1);
                            StaWork.IsHaveFix = false;//本站载具标志复位
                            
                            Linechange.SetMotor1(false, PVar.ParList.Data[43]);
                            if (PVar.ParList.CheckSts[3]) //左右机切换
                                {
                                Frm_Engineering.fEngineering.Lab_Station1.Text = "";
                                }
                            else
                                {
                                Frm_Engineering.fEngineering.Lab_Station3.Text = "";
                                }
                            Line1Time.InitialTime();
                            StaWork.Step = 240;
                            }
                        else if (Line1Time.TimeIsUp(5000))
                            {
                            AddList("流水线2载具到位超时！");
                            ShowList("流水线2载具到位超时！");
                            Line1Time.InitialTime();
                            StaWork.Step = 240;
                            }
                        break;

                    case 240:
                        if (Line1Time.TimeIsUp(500))
                            {
                            PVar.Sta_Work[(int)BVar.工位.流水线2].IsHaveFix = true;
                            Linechange.SetMotor2(false, PVar.ParList.Data[43]);
                            Line1Time.InitialTime();
                            StaWork.Step = 250;
                            }
                            break;

                    case 250:
                        if (Gg.GetDi(0, Gg.InPut0.阻挡气缸1伸出) == 1)
                            {
                            AddList("阻挡气缸1伸出到位！");
                            Line1Time.InitialTime();
                            StaWork.Step = 800;
                            }
                        else if (Line1Time.TimeIsUp(500))
                            {
                            AddList("阻挡气缸1伸出异常！");
                            ShowList("阻挡气缸1伸出异常！");
                            Line1Time.InitialTime();
                            StaWork.Step = 800;
                            }
                        break;

                    case 800:
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.IsHaveFix = false;
                        StaWork.IsHaveBezel = false;
                        StaWork.IsHaveSN = false;
                        StaWork.Step = 10;
                        break;

                    case 900:
                        //跳转到等待放行
                        StaWork.Result = false;
                        StaWork.IsHaveFix = true;
                        StaWork.IsHaveSN = false;
                        Linechange.SetMotor1(false, PVar.ParList.Data[43]);
                        StaWork.Step = 200;
                        break;

                    case 1000:
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
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





        #region 功能：转盘每转动1次各个工站处理
        public static void StationR_State()
            {
            //产品有无和使能
            BVar.ProData[1, 4] = "0";
            BVar.ProData[1, 5] = "0";
            BVar.ProData[1, 6] = "0";
            BVar.ProData[1, 7] = "B" + DateAndTime.TimeOfDay.TimeOfDay.ToString("hhmmss");
            for (int i = 5; i > 1; i--)
                {
                BVar.ProData[i, 4] = BVar.ProData[i - 1, 4];
                BVar.ProData[i, 5] = BVar.ProData[i - 1, 5];
                BVar.ProData[i, 6] = BVar.ProData[i - 1, 6];
                BVar.ProData[i, 7] = BVar.ProData[i - 1, 7];
                PVar.Sta_Work[i].IsHaveHSG = PVar.Sta_Work[i - 1].IsHaveHSG;
                PVar.Sta_Work[i].Enable = true;
                }
            PVar.Sta_Work[1].IsHaveHSG = false;


            //当前站运行结果
            for (int i = 5; i > 1; i--)
                {
                PVar.Sta_Work[i].Result = PVar.Sta_Work[i - 1].Result;
                }
            PVar.Sta_Work[1].Result = false;

            if (PVar.Sta_Work[5].IsHaveHSG)
                {
                if (PVar.Sta_Work[5].Result)
                    {
                    Frm_Engineering.fEngineering.Label_NG_OK.Text = "OK";
                    Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultText = "OK";
                    Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultBackColor = Color.FromArgb(111, 192, 64);
                    Gg.SetExDo(0, 1, Gg.OutPut2.OK指示灯, 1);
                    Gg.SetExDo(0, 1, Gg.OutPut2.NG指示灯, 0);
                    }
                else
                    {
                    Frm_Engineering.fEngineering.Label_NG_OK.Text = "NG";
                    Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultText = "NG";
                    Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultBackColor = Color.FromArgb(200, 37, 6);
                    Gg.SetExDo(0, 1, Gg.OutPut2.OK指示灯, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.NG指示灯, 1);
                    PVar.Ring_EN = true;
                    }
                }
            }
        #endregion


        /// <summary>
        /// 第一段数据界面增加数据
        /// </summary>
        /// <remarks></remarks>
        static string Frm_L1Adddata_tempBarcode = "";

        public void Frm_L1Adddata()
            {
            int tempRow = 0;
            string Error_Str = "";
            string Error_Str1 = "";
            try
                {
                //查找条码
                //if (BarCodeData != "")
                //    {
                //    Frm_L1Adddata_tempBarcode = BarCodeData.Trim();
                //    BarCodeData = "";
                //    }
                //else
                //    {
                //    Frm_L1Adddata_tempBarcode = DateTime.Now.ToString("HH:mm:ss");
                //    }
                tempRow = FunctionSub.FindRowfromSN(Frm_L1Adddata_tempBarcode);

                if (tempRow == 100) //新的条码
                    {
                    PVar.DataCount = PVar.DataCount % 100; //加到100则为0
                    while (true)
                        {
                        if (PVar.BarcodeArrayList[PVar.DataCount] != "")
                            {
                            if (PVar.BarcodeArrayList[PVar.DataCount] == BVar.ProData[2, 1] || PVar.BarcodeArrayList[PVar.DataCount] == BVar.ProData[3, 1])
                                {
                                PVar.DataCount++; //数据计数，便于datagrid数据显示
                                PVar.DataCount = PVar.DataCount % 100;
                                }
                            else
                                {
                                break;
                                }
                            Application.DoEvents();
                            }
                        else
                            {
                            break;
                            }
                        }
                    BVar.FileRorW.WriteINI("Data100Count", "Count", System.Convert.ToString(PVar.DataCount), PVar.ListDataIniPath);
                    tempRow = PVar.DataCount;
                    tempTestData[0] = DateTime.Now.ToString("yyyy-MM-dd");
                    tempTestData[1] = DateTime.Now.ToString("HH:mm:ss");
                    tempTestData[2] = DateTime.Now.ToString(Frm_L1Adddata_tempBarcode);
                    PVar.BarcodeArrayList[tempRow] = Frm_L1Adddata_tempBarcode; //将条码存到数组缓存区
                    //---------------------
                    //记录：日期，时间，条码
                    //---------------------
                    for (int i = 0; i <= 2; i++)
                        {
                        BVar.FileRorW.WriteINI(tempRow.ToString(), PVar.DataGrid_CheckDataHeadName[i], tempTestData[i], PVar.ListDataIniPath); //写入本地
                        FunctionSub.Grid_TestData_Show(Frm_Engineering.fEngineering.DataGrid_CheckData, tempRow, i, tempTestData[i]); //显示在工程界面上
                        }

                    try
                        {
                        Frm_Engineering.fEngineering.DataGrid_CheckData.CurrentCell = Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[tempRow].Cells[0];
                        Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[tempRow].Selected = true;
                        }
                    catch (Exception)
                        {

                        }
                    PVar.DataCount++; //数据计数，便于datagrid数据显示
                    }
                else
                    {
                    tempTestData[0] = DateTime.Now.ToString("yyyy-MM-dd");
                    tempTestData[1] = DateTime.Now.ToString("HH:mm:ss");
                    tempTestData[2] = DateTime.Now.ToString(Frm_L1Adddata_tempBarcode);
                    PVar.BarcodeArrayList[tempRow] = Frm_L1Adddata_tempBarcode; //将条码存到数组缓存区
                    //---------------------
                    //记录：日期，时间，条码
                    //---------------------
                    for (int i = 0; i <= 2; i++)
                        {
                        BVar.FileRorW.WriteINI(tempRow.ToString(), PVar.DataGrid_CheckDataHeadName[i], tempTestData[i], PVar.ListDataIniPath); //写入本地
                        FunctionSub.Grid_TestData_Show(Frm_Engineering.fEngineering.DataGrid_CheckData, tempRow, i, tempTestData[i]); //显示在工程界面上
                        }

                    try
                        {
                        Frm_Engineering.fEngineering.DataGrid_CheckData.CurrentCell = Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[tempRow].Cells[0];
                        Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[tempRow].Selected = true;
                        }
                    catch (Exception)
                        {

                        }

                    }

                }
            catch (Exception exc)
                {
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
