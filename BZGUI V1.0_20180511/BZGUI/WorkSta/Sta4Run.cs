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

namespace BZGUI
    {
    //复检工站
    sealed class Sta4Run
        {
        private static string CheckData;
        public static string[] ShowData;
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
                        if (PVar.Stop_Flag == false)
                            {
                            StaWork.State = false;
                            TimeOut = API.GetTickCount();
                            //StaWork.Step = 20;
                            }
                        break;

                    case 20:
                        //本站工作状态，工站使能，转盘工作状态，本站是否有产品
                        if (StaWork.State == false && StaWork.Enable && StaWork.Result && PVar.Sta_Work[1].State == false && PVar.Sta_Work[4].IsHaveHSG)
                            {
                            StaWork.State = true;
                            StaWork.Result = false;
                            Gg.SetExDo(0, 0, Gg.OutPut2.复检气缸, 0);
                            AddList("复检开始开始！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 30;
                            }
                        else
                            {
                            StaWork.Step = 10;
                            }
                        break;

                    case 30:
                        if (Gg.GetExDi(0, Gg.InPut2.复检气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.复检气缸伸出) == 0)
                            {
                            //AddList("复检气缸复位OK！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 40;
                            }
                        else
                            {
                            if (API.GetTickCount() - TimeOut > 2000)
                                {
                                AddList("复检气缸缩回信号异常！");
                                ShowList("复检气缸缩回信号异常！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 40:
                        if (API.GetTickCount() - TimeOut > 1000)
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                            }
                        break;

                    case 50:
                        sRtn = Command.TCP_CCD2_Send(Command.复检角度);
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
                            StaWork.Step = 1000;
                            }
                        else
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                            }
                        break;


                    case 60:
                        if (Command.CCD2_Resule && PVar.CCD2_Data[0] == Command.复检角度)
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
                            if (API.GetTickCount() - TimeOut > 2000)
                                {
                                AddList("等待复检角度数据超时！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 70:
                        if (CCD_Vale[1].Judge == 0)
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 80;
                            }
                        else if (CCD_Vale[1].Judge == 1)
                            {
                            AddList("复检角度模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                            }
                        else
                            {
                            AddList("CCD复检角度其他异常！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 80:
                        Gg.SetExDo(0, 0, Gg.OutPut2.复检气缸, 1);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 90;
                        break;

                    case 90:
                        if (Gg.GetExDi(0, Gg.InPut2.复检气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut2.复检气缸伸出) == 1)
                            {
                            AddList("复检气缸伸出OK！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 100;
                            }
                        else
                            {
                            if (API.GetTickCount() - TimeOut > 4000)
                                {
                                AddList("复检气缸伸出信号异常！");
                                ShowList("复检气缸伸出信号异常！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 100:
                        if (API.GetTickCount() - TimeOut > 1000)
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 110;
                            }
                        break;

                    case 110:
                        sRtn = Command.TCP_CCD2_Send(Command.复检同心度);
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
                            StaWork.Step = 1000;
                            }
                        else
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                            }
                        break;


                    case 120:
                        if (Command.CCD2_Resule && PVar.CCD2_Data[0] == Command.复检同心度)
                            {
                            AddList("复检同心度数据收到！");
                            CCD_Vale[2].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                            CCD_Vale[2].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                            CCD_Vale[2].T = Convert.ToDouble(PVar.CCD2_Data[3]);
                            CCD_Vale[2].CC = Convert.ToDouble(PVar.CCD2_Data[4]);
                            CCD_Vale[2].Judge = Convert.ToDouble(PVar.CCD2_Data[5]);

                            if (CCD_Vale[2].CC <= 0.05 && CCD_Vale[2].T <= 1)
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
                            if (API.GetTickCount() - TimeOut > 2000)
                                {
                                AddList("等待复检同心度数据超时！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 140:
                        if (CCD_Vale[2].Judge == 0)
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 150;
                            }
                        else if (CCD_Vale[2].Judge == 1)
                            {
                            AddList("复检角度模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                            }
                        else
                            {
                            AddList("CCD复检角度其他异常！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 150:
                        Gg.SetExDo(0, 0, Gg.OutPut2.复检气缸, 0);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 300;
                        break;

                    ////复检数据处理
                    case 300:
                        if (BVar.ProData[4, 30] == "OK")
                            {
                            StaWork.Result = true;
                            Frm_Engineering.fEngineering.Label_NG_OK.Text = "OK";
                            Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultText = "OK";
                            Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultBackColor = Color.FromArgb(111, 192, 64);
                            Gg.SetExDo(0, 0, Gg.OutPut2.OK指示灯, 1);
                            Gg.SetExDo(0, 0, Gg.OutPut2.NG指示灯, 0);
                            //Gg.SetExDo(0, 0, Gg.OutPut2.NG蜂鸣器, 0);
                            }
                        else
                            {
                            Frm_Engineering.fEngineering.Label_NG_OK.Text = "NG";
                            Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultText = "NG";
                            Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultBackColor = Color.FromArgb(200, 37, 6);
                            Gg.SetExDo(0, 0, Gg.OutPut2.OK指示灯, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut2.NG指示灯, 1);
                            //Gg.SetExDo(0, 0, Gg.OutPut2.NG蜂鸣器, 0);
                            PVar.Ring_EN = true;
                            }
                        Write_FinalData();
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 800;
                        break;

                    case 800:
                        StaWork.Enable = false;
                        ////StaWork.Result = true; 做为最总结过判断
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
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
            string fileFinalData = "E:\\BZ-Data\\BAM\\CheckData\\" + DateTime.Now.ToString("yyyyMM") + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
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
            PVar.tmpCpkData.X[0] = 0;
            PVar.tmpCpkData.Y[0] = 0;
            PVar.tmpCpkData.CC[0] = 0;
            PVar.tmpCpkData.A[0] = 0;//double.Parse(BVar.ProData[4, 10]);
            PVar.tmpCpkData.ProTime[0] = DateTime.Now;

            Frm_Production.fProduction.Cpk_X_Click(Frm_Production.fProduction.Cpk_X, Write_FinalData_e);
            Frm_Production.fProduction.BTN_X_Click(Frm_Production.fProduction.BTN_X, Write_FinalData_e);
            BVar.FileRorW.WriteDAT(PVar.tmpCpkData, PVar.BZ_CPKDataFilePath);

            PVar.TotalLifeCycles++;
            Frm_MachineInfo.fMachineInfo.Label_TotalLifeCycle.Text = Convert.ToString(PVar.TotalLifeCycles);
            BVar.FileRorW.WriteINI("Product", "TotalLifeCycles", Convert.ToString(PVar.TotalLifeCycles), PVar.BZ_YieldDataFileName);

            if (BVar.ProData[4, 28] == "NG")
                {
                PVar.TotalLifeRejects++;
                }
            Frm_MachineInfo.fMachineInfo.Label_TotalLifeRejects.Text = Convert.ToString(PVar.TotalLifeRejects);

            BVar.FileRorW.WriteINI("Product", "TotalLifeRejects", Convert.ToString(PVar.TotalLifeRejects), PVar.BZ_YieldDataFileName);

            Frm_Production.fProduction.UPH.BZ_BigText = Convert.ToString(Frm_Production.fProduction.CalculateUPH());

            Frm_Production.fProduction.CalculateYield();

            CheckData = DateTime.Now.ToString("yyyy/MM/dd") + "," + Convert.ToString(DateAndTime.TimeOfDay.TimeOfDay) + "," + BVar.ProData[4, 1] + "," + BVar.ProData[4, 2] + "," + BVar.ProData[4, 28] + "," + BVar.ProData[4, 14] + "," + BVar.ProData[4, 7] + "," + BVar.ProData[4, 8] + "," + BVar.ProData[4, 9] + "," + BVar.ProData[4, 10] + "," + System.Convert.ToString(Conversion.Val(BVar.ProData[4, 11])) + "," + System.Convert.ToString(Conversion.Val(BVar.ProData[4, 12])) + "," + System.Convert.ToString(Conversion.Val(BVar.ProData[4, 13])) + "," + System.Convert.ToString(Conversion.Val(BVar.ProData[4, 14])) + "," + BVar.ProData[4, 15] + "," + BVar.ProData[4, 16] + "," + BVar.ProData[4, 17] + "," + BVar.ProData[4, 18] + "," + BVar.ProData[4, 19] + "," + BVar.ProData[4, 20] + "," + System.Convert.ToString(Conversion.Val(BVar.ProData[4, 21]));
            BVar.FileRorW.WriteCheckDataCsv(CheckData, fileFinalData);

            //向工程界面数据表格添加数据
            //1：日期  2：时间  3：HSG条码  4：返回条码  5：判断结果  6：CT  7：X值  8：Y值  9：同心度  10：角度
            ShowData = new[] { DateTime.Now.ToString("yyyy/MM/dd"), Convert.ToString(DateAndTime.TimeOfDay.TimeOfDay), BVar.ProData[4, 1], BVar.ProData[4, 1], BVar.ProData[4, 1], BVar.ProData[4, 1], BVar.ProData[4, 1], BVar.ProData[4, 1], BVar.ProData[4, 1], BVar.ProData[4, 1] };

            try
                {
                Frm_Engineering.fEngineering.DataGrid_CheckData.Rows.Add(ShowData);
                Frm_Engineering.fEngineering.DataGrid_CheckData.FirstDisplayedScrollingRowIndex = Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1;
                Frm_Engineering.fEngineering.DataGrid_CheckData.CurrentCell = Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Cells[0];
                Frm_Engineering.fEngineering.DataGrid_CheckData.Rows[Frm_Engineering.fEngineering.DataGrid_CheckData.RowCount - 1].Selected = true;
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
