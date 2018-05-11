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
    //转盘工站
    sealed class Sta1Run
    {
        private static int TimeOut = 0;
        public static bool CT_Start;
        public static string BarCodeData;
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
                            PVar.Sta_Work[1].IsHaveHSG = false;
                            StaWork.Result = false;
                            StaWork.State = false;
                            StaWork.Step = 20;
                            //PVar.Sta_Work[1].Step = 20;
                        }
                        break;

                    case 20:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (StaWork.State == false && Gg.GetDi(0, Gg.InPut0.放料光纤感应) == 1 && Gg.GetDi(0, Gg.InPut0.安全光幕) == 0)
                            {
                                AddList("光幕启动开始！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 1000)
                                {
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        else
                        {
                            if (StaWork.State == false)
                            {
                                AddList("光幕启动开始！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 1000)
                                {
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        break;


                    case 30:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Gg.GetDi(0, Gg.InPut0.放料光纤感应) == 1 && Gg.GetDi(0, Gg.InPut0.安全光幕) == 1)
                            {
                                if (BVar.ProductTakeOut)
                                {
                                    AddList("启动OK！");

                                    //根据载具编号打开相对应的真空吸
                                    BVar.OpenedVacumeNo = OpenFixtureVocume();
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 40;
                                }
                                else
                                {
                                    AddList("请先取出产品！");
                                    ShowList("请先取出产品！");
                                    //蜂鸣器
                                    PVar.Ring_EN = true;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 1000;
                                }
                            }
                            else
                            {
                                if (Gg.GetDi(0, Gg.InPut0.放料光纤感应) == 0 && Gg.GetDi(0, Gg.InPut0.安全光幕) == 1)
                                {
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        else
                        {
                            AddList("启动OK！");
                            //根据载具编号打开相对应的真空吸
                            //BVar.OpenedVacumeNo = OpenFixtureVocume();
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                        }
                        break;

                    case 40:
                        if (API.GetTickCount() - TimeOut > 1000)//延时1秒，等待真空吸信号
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                        }
                        break;

                    case 50:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Gg.GetDi(0, BVar.OpenedVacumeNo + 5) == 1)//判断真空吸信号
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 60;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 2000)
                                {
                                    AddList("HSG真空吸没达到检测值，请检查产品是否放好！");
                                    ShowList("HSG真空吸没达到检测值，请检查产品是否放好！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 1000;
                                }
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 60;
                        }
                        break;

                    case 60://等待所有工位结束工作
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (PVar.Stop_Flag == false)
                            {
                                if (Gg.GetDi(0, Gg.InPut0.安全光幕) == 1 && Gg.GetDi(0, BVar.OpenedVacumeNo + 5) == 1 && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false && PVar.Sta_Work[4].State == false)
                                {
                                    StaWork.State = true;
                                    CT_Start = true;
                                    PVar.Sta_Work[1].IsHaveHSG = true;
                                    Frm_Engineering.fEngineering.OvalShape_Sta0.BackColor = Color.DarkOrange;
                                    Frm_Engineering.fEngineering.Chk_StaRound.BackColor = Color.DarkOrange;
                                    if (Gg.GetPrfPos(1, 1) > 300)//int类型最大值为2^31-1=2147483647
                                    {
                                        gts.GT_SetPrfPos(1, 1, 0); //规划器置零
                                        gts.GT_SetEncPos(1, 1, 0); //编码器置零                     
                                        gts.GT_SynchAxisPos(1, 1 << 0); //将当前轴进行位置同步
                                    }

                                    AddList("转盘开始转动！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 70;
                                }
                                else
                                {
                                    if (Gg.GetDi(0, BVar.OpenedVacumeNo + 5) == 0)//判断真空吸信号
                                    {
                                        AddList("HSG真空吸力异常，启动失败，请重新启动！");
                                        ShowList("HSG真空吸力异常，启动失败，请重新启动！");
                                        TimeOut = API.GetTickCount();
                                        StaWork.Step = 1000;
                                    }
                                }
                            }
                            else
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                            }

                        }
                        else
                        {
                            if (PVar.Stop_Flag == false)
                            {
                                if (Gg.GetDi(0, Gg.InPut0.安全光幕) == 1 && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false && PVar.Sta_Work[4].State == false)
                                {
                                    StaWork.State = true;
                                    CT_Start = true;
                                    PVar.Sta_Work[1].IsHaveHSG = true;
                                    Frm_Engineering.fEngineering.OvalShape_Sta0.BackColor = Color.DarkOrange;
                                    Frm_Engineering.fEngineering.Chk_StaRound.BackColor = Color.DarkOrange;
                                    if (Gg.GetPrfPosmm(1, 1) > 300)//int类型最大值为2^31-1=2147483647
                                    {
                                        gts.GT_SetPrfPos(1, 1, 0); //规划器置零
                                        gts.GT_SetEncPos(1, 1, 0); //编码器置零                     
                                        gts.GT_SynchAxisPos(1, 1 << 0); //将当前轴进行位置同步
                                    }

                                    AddList("转盘开始转动！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 70;
                                }
                            }
                            else
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                            }

                        }
                        break;

                    case 70:
                        StationR_State();
                        Gg.StepMotion(1, 1, PVar.ParAxis.Speed[9], 90, "+");
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 80;
                        break;

                    case 80:
                        if (Gg.ZSPD(1, 1))
                        {
                            Frm_Engineering.fEngineering.OvalShape_Sta0.BackColor = Color.FromArgb(192, 255, 192);
                            Frm_Engineering.fEngineering.Chk_StaRound.BackColor = Color.FromArgb(192, 255, 192);
                            AddList("转盘转动到位！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 90;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 10000)
                            {
                                AddList("转盘转动超时！");
                                ShowList("转盘转动超时！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 10000;
                            }
                        }
                        break;

                    case 90:
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 800;
                        break;

                    case 800:
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 10;
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

        private static int OpenFixtureVocume()
        {
            int n = -1;
            for (int i = 1; i <= 4; i++)
            {
                if (Convert.ToInt32(Frm_Engineering.fEngineering.Label_Sta1.Text) == i)
                {
                    Gg.SetDo(0, 4 + i * 2, 1);//打开真空吸
                    Gg.SetDo(0, 5 + i * 2, 0);//关闭破真空
                    n = i;
                }
            }
            return n;
        }

        #region 功能：转盘每转动1次各个工站处理
        public static void StationR_State()
        {
            //每个工站载具序号
            String Buffer_Label = Frm_Engineering.fEngineering.Label_Sta4.Text;
            Frm_Engineering.fEngineering.Label_Sta4.Text = Frm_Engineering.fEngineering.Label_Sta3.Text;
            Frm_Engineering.fEngineering.Label_Sta3.Text = Frm_Engineering.fEngineering.Label_Sta2.Text;
            Frm_Engineering.fEngineering.Label_Sta2.Text = Frm_Engineering.fEngineering.Label_Sta1.Text;
            Frm_Engineering.fEngineering.Label_Sta1.Text = Buffer_Label;

            if (PVar.Sta_Work[1].IsHaveHSG)
            {
                PVar.Sta_Work[1].Enable = true;
            }
            else
            {
                PVar.Sta_Work[1].Enable = false;
            }

            //产品有无和使能
            for (int i = 4; i > 1; i--)
            {
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

            if (PVar.Sta_Work[5].Result)
            {
                Frm_Engineering.fEngineering.Label_NG_OK.Text = "OK";
                Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultText = "OK";
                Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultBackColor = Color.FromArgb(111, 192, 64);
                Gg.SetExDo(0, 0, Gg.OutPut2.OK指示灯, 1);
                Gg.SetExDo(0, 0, Gg.OutPut2.NG指示灯, 0);
            }
            else
            {
                Frm_Engineering.fEngineering.Label_NG_OK.Text = "NG";
                Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultText = "NG";
                Frm_Production.fProduction.DRB_YieldRetest.BZ_ResultBackColor = Color.FromArgb(200, 37, 6);
                Gg.SetExDo(0, 0, Gg.OutPut2.OK指示灯, 0);
                Gg.SetExDo(0, 0, Gg.OutPut2.NG指示灯, 1);
                PVar.Ring_EN = true;
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
                if (BarCodeData != "")
                {
                    Frm_L1Adddata_tempBarcode = BarCodeData.Trim();
                    BarCodeData = "";
                }
                else
                {
                    Frm_L1Adddata_tempBarcode = DateTime.Now.ToString("HH:mm:ss");
                }
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
