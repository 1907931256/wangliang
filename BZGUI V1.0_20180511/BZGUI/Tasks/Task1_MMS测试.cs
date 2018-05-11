using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;         //for File dir
using System.Diagnostics;//process
using XCore;
using BZGUI.Data;
using BZappdll;
using SocketHelper;

namespace BZGUI
{
    class Task1_MMS测试 : XTask
    {
        #region Definition

        private static int tempi = 0;
        private List<string[]> ls = new List<string[]>();
        public static event Action<EnumShowResult> EventShowResult;
        public static event Action<CheckData> OnCurrentInf;
        public static event Action OnFlashDataPage;//to cpk data
        string[] PDCA_data = new string[8];

        #endregion

        #region Override

        public Task1_MMS测试(string path)
            : base(path)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
            Flag_TaskdisEnable = false;//本站是否启用，强制打开
            AELimitsRead();//读AElimits
        }

        protected override void Homing()
        {
            AutoRunstep = 0;
            InitHomingStep = 10;
            while (InitHoming() == FunctionStatus.Working || InitHomingStep != 0)
            {
                Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        public override void Exit()
        {
            base.Exit();
        }
        
        protected override void Running(object runMode)
        {
            while (true) 
            {
                if (runMode == null) runMode = StationRunMode.自动运行;
                if (!PVar.MacHold)    //暂停状态时不扫描
                {
                    switch ((StationRunMode)runMode)
                    {
                        case StationRunMode.空跑:
                            DryRun();
                            break;
                        case StationRunMode.自动运行:
                            AutoRun();
                            break;
                        case StationRunMode.标定Laser:
                            if (LaserCali() != FunctionStatus.Working)
                            { runMode = StationRunMode.自动运行; }
                            break;
                        case StationRunMode.手动上传PDCA://区分机种
                            string[] testdata = new string[] { "1", "2", "3", "4", "0", "0", "0", "0", "SV1.0.0" };
                            if (PDCA_Bali(testdata) != FunctionStatus.Working)
                            { runMode = StationRunMode.自动运行; }
                            break;
                    }
                }
                Thread.Sleep(10);
                Application.DoEvents();
            } 
        }

        #endregion

        #region StaionWork

        private static Delay InitHomingDelay = new Delay();
        private  FunctionStatus InitHoming()
        {
            switch (InitHomingStep)
            {
                case 10:
                        AutoRunstep = 0;
                        Gg.Set_Servo(0, BVar.MMSY, true);//open servo on
                        Thread.Sleep(200);
                        SetStep("开始回零.......", Mycolor.None);
                        InitHomingStep = 15;
                        break;
                case 15:
                        Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 0);
                        SetStep("定位气缸复位......", Mycolor.None);
                        InitHomingDelay.InitialTime();
                        InitHomingStep = 20;
                        break;
                case 20:
                        if (Gg.GetDi(0, Gg.InPutMMS0.气缸缩回位置感应器) == 1)
                        {
                            SetStep("定位气缸在缩回位置", Mycolor.None);
                            InitHomingStep = 30;
                        }
                        else if(InitHomingDelay.TimeIsUp(2000))
                        {
                            SetStep("定位气缸缩回位置信号异常！", Mycolor.ErrorRed);
                            PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.载具进出气缸缩回信号异常, AlarmCategory.MOTION.ToString(), "载具进出气缸缩回信号异常");
                            InitHomingStep = 8000;
                        }
                        break;
                case 30:
                        SetStep("测试y轴开始回原点…", Mycolor.None);
                        GoHome.Instance.AxisHome[0, 1].Result = false;
                        GoHome.Instance.AxisHome[0, 1].Enable = true;
                        GoHome.Instance.AxisHome[0, 1].Step = 10;
                        TimeOut = API.GetTickCount();
                        InitHomingStep = 40; 
                        break;
                case 40:
                        GoHome.GotoHome(0, 1, 30, -1000, 5, 1, 10);
                        if (GoHome.Instance.AxisHome[0, 1].Step == 0 && GoHome.Instance.AxisHome[0, 1].Enable)
                        {
                            GoHome.Instance.AxisHome[0, 1].Enable = false;
                            if (GoHome.Instance.AxisHome[0, 1].Result)
                            {
                                SetStep("测试y轴回原点成功…", Mycolor.None);
                                InitHomingStep = 50;
                            }
                            else
                            {
                                SetStep("测试y轴回原点失败…", Mycolor.ErrorRed);
                                InitHomingStep = 8000;
                            }
                        }
                        break;
                case 50://等待位置
                        Gg.AbsMotion(0, BVar.MMSY, mFunction.Pos.TeachAxis1[0, 0], PVar.ParAxis.Speed[BVar.MMSY ]);
                        TimeOut = API.GetTickCount();
                        InitHomingStep = 60;
                        break;
                case 60:
                        if (Gg.ZSPD(0, BVar.MMSY))
                        {
                            SetStep("测试y轴运动到初始位置成功…", Mycolor.None);
                            InitHomingStep = 2000;
                        }
                        break;
                case 2000:
                        InitHomingStep = 0;
                        SetStep("MMS测试工站复位OK!", Mycolor.None);
                        SetState(XTaskState.WAITRUN);
                        SetStepNum(InitHomingStep);
                        HomeOK = true;
                        PVar.LampStatus = 20;
                        PostTaskAlarm(XAlarmLevel.RST, (int)AlarmCode.复位, AlarmCategory.RESET.ToString(), "RST");//for errorcode
                        return FunctionStatus.Finish;

                case 8000:
                        InitHomingStep = 0;
                        PVar.LampStatus = 10;
                        return FunctionStatus.Error;
            }
            SetStepNum(InitHomingStep);
            return FunctionStatus.Working;
        }
        /// <summary>
        /// 空跑
        /// </summary>
        private void DryRun()
        {
            #region Switch
            switch (AutoRunstep)
            {
                case 10:
                    SetStep("CLEAR", Mycolor.None);
                    TaskIsWorking = true;
                    EventShowResult(EnumShowResult.Empty);
                    SetStep("AutoRun Setp10", Mycolor.None);
                    AutoRunstep = 20;
                    break;
                case 20:
                    SetStep("AutoRun Setp20", Mycolor.None);
                    AutoRunstep = 30;
                    break;
                case 30:
                    Thread.Sleep(1);
                    SetStep("AutoRun Setp30", Mycolor.None);
                    AutoRunstep = 40;
                    break;
                case 40:
                    Thread.Sleep(10);
                    SetStep("AutoRun Setp40", Mycolor.None);
                    AutoRunstep = 50;
                    break;
                case 50://等待位置
                    Gg.AbsMotion(0, BVar.MMSY, mFunction.Pos.TeachAxis1[0, 0], PVar.ParAxis.Speed[BVar.MMSY]);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 60;
                    break;
                case 60:
                    if (Gg.ZSPD(0, BVar.MMSY))
                    {
                        SetStep("测试y轴运动到初始位置成功…", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 70;
                    }
                    break;
                case 70:
                    if (API.GetTickCount() - TimeOut > 300)
                    { AutoRunstep = 80; }
                    break;
                case 80://测试位置
                    Gg.AbsMotion(0, BVar.MMSY, mFunction.Pos.TeachAxis1[0, 2], PVar.ParAxis.Speed[BVar.MMSY]);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 90;
                    break;
                case 90:
                    if (Gg.ZSPD(0, BVar.MMSY) )
                    {
                        SetStep("测试y轴运动到测试位置成功…", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 100;
                    }
                    break;
                case 100:
                    if (API.GetTickCount() - TimeOut > 300)
                    { AutoRunstep =110; }
                    break;
                case 110:
                    Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 1);
                    SetStep("定位气缸打开......", Mycolor.None);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 120;
                    break;
                case 120:
                    if (Gg.GetDi(0, Gg.InPutMMS0.气缸到位感应器) == 1)
                    {
                        SetStep("定位气缸到定位位置", Mycolor.None);
                        AutoRunstep = 150;
                    }
                    else if (API.GetTickCount()-TimeOut>2000)
                    {
                        SetStep("定位气缸缩到定位位置信号异常！", Mycolor.ErrorRed);
                        PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.载具进出气缸伸出信号异常, AlarmCategory.MOTION.ToString(), "载具进出气缸伸出信号异常");
                        AutoRunstep = 8000;
                    }
                    break;
                case 150:
                    SetStep("测试开始.....", Mycolor.None);
                    Thread.Sleep(2000);
                    AutoRunstep = 180;
                    break;
                case 180:
                    Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 0);
                    SetStep("定位气缸复位......", Mycolor.None);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 190;
                    break;
                case 190:
                    if (Gg.GetDi(0, Gg.InPutMMS0.气缸缩回位置感应器) == 1)
                    {
                        SetStep("定位气缸在缩回位置", Mycolor.None);
                        AutoRunstep = 200;
                    }
                    else if (API.GetTickCount() - TimeOut > 2000)
                    {
                        SetStep("定位气缸缩回位置信号异常！", Mycolor.ErrorRed);
                        PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.载具进出气缸缩回信号异常, AlarmCategory.MOTION.ToString(), "载具进出气缸缩回信号异常");
                        AutoRunstep = 8000;
                    }
                    break;
                case 200:
                    uint pck;
                    uint pck2;
                    gts.GT_GetClockHighPrecision(0, out pck);
                    Thread.Sleep(5);
                    gts.GT_GetClockHighPrecision(0, out pck2);
                    uint ctt = pck2 - pck;
                    SetStep("AutoRun Setp60", Mycolor.None);
                    AutoRunstep = 210;
                    break;
                case 210:
                    Thread.Sleep(1000);
                    SetStep("AutoRun Setp70", Mycolor.None);
                    #region 产生数据 1tray
                    //  "装配时间", "产品条码", "Result", "X", "Y", "A", "Dis" 
                    DataManager.Instance.CurrentCheckData.SN = "SNXXXXXXX";
                    DataManager.Instance.CurrentCheckData.StartDate = DateTime.Now.ToString("yyyy-MM-dd");
                    DataManager.Instance.CurrentCheckData.StartTime = DateTime.Now.ToString("HH:mm:ss");
                    Random rd = new Random();
                    if (Globals.settingMachineInfo.什么机器 == WhichMachine.IPDM)
                    {
                        double left1 = DataManager.Instance.CurrentCheckData.IPD_Left1 = rd.Next(-1, 1) / 10.0 + rd.Next(-1, 1) / 100.00;
                        double left2 = DataManager.Instance.CurrentCheckData.IPD_Right1 = 22 + rd.Next(-1, 1) / 100.0 + rd.Next(0, 1) / 1000.00;
                        double Right1 = DataManager.Instance.CurrentCheckData.Mod_Brc_X = rd.Next(-1, 1) / 100.0 + rd.Next(-1, 1) / 1000.00;
                        double Right2 = DataManager.Instance.CurrentCheckData.Mod_Brc_Y = rd.Next(-1, 1) / 100.0 + rd.Next(-1, 1) / 1000.00;
                        DataManager.Instance.chartData.Adddata(left1.ToString() + "," + Right1.ToString() + "," + left2.ToString() + "," + Right2.ToString()); //AddData为更新生产的CPK数据 AddNewData为UPH数据，包括很多东西
                    }
                    else
                    {
                        double m_A = DataManager.Instance.CurrentCheckData.Mod_Brc_A = rd.Next(-1, 1) / 10.0 + rd.Next(-1, 1) / 100.00;
                        double m_cc = DataManager.Instance.CurrentCheckData.Mod_Brc_CC = 22 + rd.Next(-1, 1) / 100.0 + rd.Next(0, 1) / 1000.00;
                        double m_x = DataManager.Instance.CurrentCheckData.Mod_Brc_X = rd.Next(-1, 1) / 100.0 + rd.Next(-1, 1) / 1000.00;
                        double m_y = DataManager.Instance.CurrentCheckData.Mod_Brc_Y = rd.Next(-1, 1) / 100.0 + rd.Next(-1, 1) / 1000.00;
                        DataManager.Instance.chartData.Adddata(m_A.ToString() + "," + m_x.ToString() + "," + m_y.ToString() + "," + m_cc.ToString()); //AddData为更新生产的CPK数据 AddNewData为UPH数据，包括很多东西
                    }
                    if (tempi % 2 == 1)
                    {
                        DataManager.Instance.CurrentCheckData.PASS = true;
                        DataManager.Instance.CurrentCheckData.PDCAPASS = true;
                        SetStep("the result is Passed", Color.LimeGreen);
                        EventShowResult(EnumShowResult.OK);
                        DataManager.Instance.currentyield.AddOneResult(true);//update the current yield and month yield
                    }
                    else
                    {
                        DataManager.Instance.CurrentCheckData.PASS = false;
                        DataManager.Instance.CurrentCheckData.PDCAPASS = false;
                        SetStep("the result is Failed", Color.Red);
                        EventShowResult(EnumShowResult.NG);
                        DataManager.Instance.currentyield.AddOneResult(false);//update the current yield and month yield
                    }
             

                    DataManager.Instance.uph.UPHupdate();                        //UPH update by hour

                    if (OnCurrentInf != null) OnCurrentInf(DataManager.Instance.CurrentCheckData);//给工程界面的数据显示
                    if (OnFlashDataPage != null) OnFlashDataPage();

                    tempi++;

                    #endregion
                    AutoRunstep = 220;
                    break;
                case 220://等待位置
                    Gg.AbsMotion(0, BVar.MMSY, mFunction.Pos.TeachAxis1[0, 0], PVar.ParAxis.Speed[BVar.MMSY]);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 230;
                    break;
                case 230:
                    if (Gg.ZSPD(0, BVar.MMSY))
                    {
                        SetStep("测试y轴运动到初始位置成功…", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 2000;
                    }
                    break;
                case 2000:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp80", Mycolor.None);
                    StaStop = false;
                    StopWatch_Stop();//stop the CT count
                    AutoRunstep = 0;
                    TaskIsWorking = false;
                    SetStep("SAVE", Mycolor.None);
                    PostTaskAlarm(XAlarmLevel.RST, (int)AlarmCode.复位, AlarmCategory.RESET.ToString(), "RST");//for errorcode
                    break;
                case 8000:
                    Thread.Sleep(1);
                    SetStep("AutoRun Setp8000", Mycolor.None);
                    AutoRunstep = 0;
                    StopWatch_Stop();//stop the CT count
                    TaskIsWorking = false;
                    return;
            }
            SetStepNum(AutoRunstep);
            Task_StopWatchElapsedMilliseconds();//获取CT
            #endregion
        }
        /// <summary>
        /// 自动运行
        /// </summary>

        private void AutoRun()
        {
            #region Switch
            switch (AutoRunstep)
            {
                case 10:
                    SetStep("CLEAR", Mycolor.None);
                    TaskIsWorking = true;
                    EventShowResult(EnumShowResult.Empty);
                    SetStep("测试工站开始...", Mycolor.None);
                    AutoRunstep = 20;
                    break;
                #region run to test postion
                case 20://运动到测试位置
                    Gg.AbsMotion(0, BVar.MMSY, mFunction.Pos.TeachAxis1[0, 2], PVar.ParAxis.Speed[BVar.MMSY]);
                    TimeOut = API.GetTickCount();
                    SetStep("测试Y轴运动到测试点开始", Mycolor.None);
                    AutoRunstep = 30;
                    break;
                case 30:
                    if (Gg.ZSPD(0, BVar.MMSY))
                    {
                        SetStep("测试Y轴运动到达测试位置", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = (Globals.settingMachineInfo.什么机器 == WhichMachine.IPDM) ? 70 : 40;
                    }
                    break;
                case 40:
                    Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 1);
                    SetStep("定位气缸打开", Mycolor.None);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 50;
                    break;
                case 50:
                    if (Gg.GetDi(0, Gg.InPutMMS0.气缸到位感应器) == 1)
                    {
                        SetStep("定位气缸到定位位置", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 60;
                    }
                    else if (API.GetTickCount() - TimeOut > 2000)
                    {
                        SetStep("定位气缸缩到定位位置信号异常！", Mycolor.ErrorRed);
                        PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.载具进出气缸伸出信号异常, AlarmCategory.MOTION.ToString(), "载具进出气缸伸出信号异常");
                        AutoRunstep = 8000;
                    }
                    break;
                case 60:
                    if (API.GetTickCount() - TimeOut > 300)
                    {
                        SetStep("延时300ms", Mycolor.None);
                        AutoRunstep = 70;
                    }
                    break;
                #endregion
                #region start test & collect data
                case 70:
                    //if (Globals.settingFunc.打开SSH通信 && Globals.SSHconnSt)//SSH打开，且SSH连接成功！
                    {
                        //SSH.Instance.ExecuteCommand("/Users/gdlocal/Desktop/MMS/" + Globals.settingPara.SSH脚本名字);//运行mini脚本
                        SetStep("Send SSH command-start to move Motor!", Mycolor.None);
                        DAQ.Instance.PCI9222StartCollect();//开始收集高度数据
                        SetStep("测试开始,开始收集数据", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 80;
                    }
                    //else
                    //{
                    //    SetStep("SSH功能没打开，或SSH连接失败！", Mycolor.ErrorRed);
                    //    SetStep("请确定SSH，退出测试！", Mycolor.ErrorRed);
                    //    TimeOut = API.GetTickCount();
                    //    AutoRunstep = 290;
                    //}
                    break;
                case 80:
                    //if (API.GetTickCount() - TimeOut > Globals.settingPara.测试超时)
                    if (API.GetTickCount() - TimeOut > 2000)
                    {
                        SetStep("测试超时，退出测试！", Mycolor.ErrorRed);
                        TimeOut = API.GetTickCount();
                        DAQ.Instance.PCI9222StopCollect();
                        AutoRunstep = 90;
                    }
                    //if (Globals.SSHstring.Contains("Motor Run Complete"))//SSH feedback string
                    //{
                    //    SetStep("收到SSH的Motor Run Complete，测试结束！", Mycolor.None);
                    //    DAQ.Instance.PCI9222Clear();//stop collect the 9222 data
                    //    TimeOut = API.GetTickCount();
                    //    AutoRunstep = 90;
                    //}
                    break;
                case 90://save the raw data
                    ls.Clear();
                    string[] stringheader = new string[] { "Time", "laer_p0", "laer_p1", "laer_p2", "laer_p3", "laer_p4" };
                    ls.Add(stringheader);
                    for (int i = 0; i < DAQ.Instance.listArray[0].Count - 2; i++)        //最后两组数据不要
                    {
                        string[] strarr = new string[6];
                        strarr[0] = DAQ.Instance.listArray[0][i].X.ToString();//time
                        strarr[1] = DAQ.Instance.listArray[0][i].Y.ToString();//laser_p0
                        strarr[2] = DAQ.Instance.listArray[1][i].Y.ToString();//laser_p1
                        strarr[3] = DAQ.Instance.listArray[2][i].Y.ToString();//laser_p2
                        strarr[4] = DAQ.Instance.listArray[3][i].Y.ToString();//laser_p3
                        strarr[5] = DAQ.Instance.listArray[4][i].Y.ToString();//laser_p4
                        ls.Add(strarr);
                    }
                    string path = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data\\"
                                    + DateTime.Now.ToString("yyyyMMdd") + "\\";
                    if (System.IO.Directory.Exists(path) == false)
                        System.IO.Directory.CreateDirectory(path);
                    Globals.csv.WriteCSV(path + DataManager.Instance.CurrentCheckData.SN + "_" + DateTime.Now.ToString("HH_mm_ss_fff") + "_raw.csv", ls);
                    ls.Clear();
                    AutoRunstep = 100;
                    break;
                case 100:
                    AutoRunstep = 110;
                    break;
                case 110:
                    AutoRunstep = 120;
                    break;
                case 120:
                    AutoRunstep = 200;
                    break;
                case 200:
                    AutoRunstep = 210;
                    break;
                case 210:
                    SetStep("显示测试数据", Mycolor.None);
                    #region 产生数据 1tray
                    //  "装配时间", "产品条码", "Result", "X", "Y", "A", "Dis" 
                    DataManager.Instance.CurrentCheckData.StartDate = DateTime.Now.ToString("yyyy-MM-dd");
                    DataManager.Instance.CurrentCheckData.StartTime = DateTime.Now.ToString("HH:mm:ss");
                    Random rd = new Random();
                    double m_A = DataManager.Instance.CurrentCheckData.Mod_Brc_A = rd.Next(-1, 1) / 10.0 + rd.Next(-1, 1) / 100.00;
                    double m_cc = DataManager.Instance.CurrentCheckData.Mod_Brc_CC = 22 + rd.Next(-1, 1) / 100.0 + rd.Next(0, 1) / 1000.00;
                    double m_x = DataManager.Instance.CurrentCheckData.Mod_Brc_X = rd.Next(-1, 1) / 100.0 + rd.Next(-1, 1) / 1000.00;
                    double m_y = DataManager.Instance.CurrentCheckData.Mod_Brc_Y = rd.Next(-1, 1) / 100.0 + rd.Next(-1, 1) / 1000.00;

                    if (tempi % 2 == 1)
                    {
                        DataManager.Instance.CurrentCheckData.PASS = true;
                        DataManager.Instance.CurrentCheckData.PDCAPASS = true;
                        SetStep("the result is Passed", Color.LimeGreen);
                        EventShowResult(EnumShowResult.OK);
                        DataManager.Instance.currentyield.AddOneResult(true);//update the current yield and month yield
                    }
                    else
                    {
                        DataManager.Instance.CurrentCheckData.PASS = false;
                        DataManager.Instance.CurrentCheckData.PDCAPASS = false;
                        SetStep("the result is Failed", Color.Red);
                        EventShowResult(EnumShowResult.NG);
                        DataManager.Instance.currentyield.AddOneResult(false);//update the current yield and month yield
                    }
                    DataManager.Instance.chartData.Adddata(m_A.ToString() + "," + m_x.ToString() + "," + m_y.ToString() + "," + m_cc.ToString()); //AddData为更新生产的CPK数据 AddNewData为UPH数据，包括很多东西
                    DataManager.Instance.uph.UPHupdate();                        //UPH update by hour

                    if (OnCurrentInf != null) OnCurrentInf(DataManager.Instance.CurrentCheckData);//给工程界面的数据显示
                    if (OnFlashDataPage != null) OnFlashDataPage();
                    tempi++;

                    #endregion
                    AutoRunstep = 220;
                    break;
                case 220://PDCA  
                    DataManager.Instance.CurrentCheckData.Operator_ID = "0";
                    DataManager.Instance.CurrentCheckData.Mode = "0";
                    DataManager.Instance.CurrentCheckData.TestSeriesID = "'201805070859";
                    DataManager.Instance.CurrentCheckData.Prioriyt = "0";
                    PDCA_data[0] = DataManager.Instance.CurrentCheckData.Mod_Brc_X.ToString();
                    PDCA_data[1] = DataManager.Instance.CurrentCheckData.Mod_Brc_Y.ToString();
                    PDCA_data[2] = DataManager.Instance.CurrentCheckData.Mod_Brc_A.ToString();
                    PDCA_data[3] = DataManager.Instance.CurrentCheckData.Mod_Brc_CC.ToString();
                    PDCA_data[4] = DataManager.Instance.CurrentCheckData.Operator_ID.ToString();
                    PDCA_data[5] = DataManager.Instance.CurrentCheckData.Mode.ToString();
                    PDCA_data[6] = DataManager.Instance.CurrentCheckData.TestSeriesID.ToString();
                    PDCA_data[7] = DataManager.Instance.CurrentCheckData.Prioriyt.ToString();
                    PDCA_Step = 10;
                    AutoRunstep = 240;
                    break;
                case 230://PDCA
                    if (PDCA_Bali(PDCA_data) == FunctionStatus.Finish)
                    {
                        DataManager.Instance.CurrentCheckData.PDCAPASS = true;
                        AutoRunstep = 240;
                    }
                    else if (PDCA_Bali(PDCA_data) == FunctionStatus.Error)
                    {
                        DataManager.Instance.CurrentCheckData.PDCAPASS = false;
                        AutoRunstep = 240;
                    }
                    break;
                case 240:
                    #region 从测试数据中取值,保留生产数据
                    path = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\PDCA Data\\"
                           + DateTime.Now.ToString("yyyyMM") + "\\";
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Clear();
                    stringBuilder.Append("" + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.StartDate + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.StartTime + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.SN + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.PASS + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.PDCAPASS + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Mod_Brc_X + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Mod_Brc_Y + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Mod_Brc_A + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Mod_Brc_CC + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Operator_ID + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Mode + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.TestSeriesID + ",");
                    stringBuilder.Append(DataManager.Instance.CurrentCheckData.Prioriyt + ",");
                    string pathtemp = path + DateTime.Now.ToString("yyyyMMdd") + "_PDCA_Data.csv";
                    #region save the csv header
                    if (File.Exists(pathtemp) == false)
                    {
                        StringBuilder stringBuilderHeader = new StringBuilder();
                        stringBuilderHeader.Clear();
                        stringBuilderHeader.Append(" ,StartDate,StartTime,SN,Result,PDCA_Result,X,Y,A,CC,Operator_ID,Mode,TestSeriesID,Prioriyt,\t\n");
                        stringBuilderHeader.Append("Upper Limit,NA,NA,NA,NA,NA,1,2,3,4,\t\n");
                        stringBuilderHeader.Append("Lower Limit,NA,NA,NA,NA,NA,-1,-2,-3,-4,\t\n");
                        stringBuilderHeader.Append("Units,NA,NA,NA,NA,NA,mm,mm,mm,mm,");
                        CsvServer.Instance.WriteLine(pathtemp, stringBuilderHeader.ToString());
                        stringBuilderHeader.Clear();
                    }
                    #endregion
                    CsvServer.Instance.WriteLine(pathtemp, stringBuilder.ToString());
                    stringBuilder.Clear();
                    #endregion
                    AutoRunstep = 290;
                    break;
                case 290:
                    DAQ.Instance.PCI9222StopCollect();
                    AutoRunstep = 300;
                    break;
                #endregion
                #region back to wait postion
                case 300:
                    Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 0);
                    SetStep("定位气缸复位......", Mycolor.None);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = (Globals.settingMachineInfo.什么机器 == WhichMachine.IPDM) ? 320 : 310;
                    break;
                case 310:
                    if (Gg.GetDi(0, Gg.InPutMMS0.气缸缩回位置感应器) == 1)
                    {
                        SetStep("定位气缸在缩回位置", Mycolor.None);
                        AutoRunstep = 320;
                    }
                    else if (API.GetTickCount() - TimeOut > 2000)
                    {
                        SetStep("定位气缸缩回位置信号异常！", Mycolor.ErrorRed);
                        PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.载具进出气缸缩回信号异常, AlarmCategory.MOTION.ToString(), "载具进出气缸缩回信号异常");
                        AutoRunstep = 8000;
                    }
                    break;
                case 320://等待位置
                    Gg.AbsMotion(0, BVar.MMSY, mFunction.Pos.TeachAxis1[0, 0], PVar.ParAxis.Speed[BVar.MMSY]);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 330;
                    break;
                case 330:
                    if (Gg.ZSPD(0, BVar.MMSY))
                    {
                        SetStep("测试y轴运动到初始位置成功…", Mycolor.None);
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 2000;
                    }
                    break;
                #endregion
                case 2000:
                    StaStop = false;
                    StopWatch_Stop();//stop the CT count
                    AutoRunstep = 0;
                    TaskIsWorking = false;
                    SetStep("SAVE", Mycolor.None);
                    PostTaskAlarm(XAlarmLevel.RST, (int)AlarmCode.复位, AlarmCategory.RESET.ToString(), "RST");//for errorcode
                    break;
                case 8000:
                    DAQ.Instance.PCI9222Clear();
                    SetStep("此步为异常，退出循环", Mycolor.None);
                    AutoRunstep = 0;
                    StopWatch_Stop();           //stop the CT count
                    TaskIsWorking = false;
                    SetStep("SAVE", Mycolor.None);
                    return;
            }
            SetStepNum(AutoRunstep);
            Task_StopWatchElapsedMilliseconds();//获取CT
            #endregion
        }

        #endregion

        #region private surport
        private FunctionStatus LaserCali()//取一次采样率的数据，每通道100个，需要保存Log
        {
            try
            {
                double laser_temp0 = DAQ.Instance.MeanAvg[0];
                double laser_temp1 = DAQ.Instance.MeanAvg[1];
                double laser_temp2 = DAQ.Instance.MeanAvg[2];
                double laser_temp3 = DAQ.Instance.MeanAvg[3];
                double laser_temp4 = DAQ.Instance.MeanAvg[4];
                Thread.Sleep(500);
                double laser_temp00 = DAQ.Instance.MeanAvg[0];
                double laser_temp01 = DAQ.Instance.MeanAvg[1];
                double laser_temp02 = DAQ.Instance.MeanAvg[2];
                double laser_temp03 = DAQ.Instance.MeanAvg[3];
                double laser_temp04 = DAQ.Instance.MeanAvg[4];
                Globals.settingLaser.Laser_p0 = (laser_temp0 + laser_temp00) / 2.0000;
                Globals.settingLaser.Laser_p1 = (laser_temp1 + laser_temp01) / 2.0000;
                Globals.settingLaser.Laser_p2 = (laser_temp2 + laser_temp02) / 2.0000;
                Globals.settingLaser.Laser_p3 = (laser_temp3 + laser_temp03) / 2.0000;
                Globals.settingLaser.Laser_p4 = (laser_temp4 + laser_temp04) / 2.0000;
                Globals.settingLaser.SaveSetting();//保存数据
                Globals.WriteLog("Calibrrtion log,标定的高度值为laser_p0:" + Globals.settingLaser.Laser_p0.ToString()
                    + " laser_p1:" + Globals.settingLaser.Laser_p1.ToString()
                    + " laser_p2:" + Globals.settingLaser.Laser_p2.ToString()
                    + " laser_p3:" + Globals.settingLaser.Laser_p3.ToString()
                    + " laser_p4:" + Globals.settingLaser.Laser_p4.ToString(), PVar.BZ_CaliLogPath);
                SetStep("laser 校正成功！！", Mycolor.ErrorRed);
                return FunctionStatus.Finish;
            }
            catch { return FunctionStatus.Error; }
        }

        #region PDCA部分
        private string PDCA_RtnSN;
        private FunctionStatus PDCA_Bali(string[] Test_data)//1D数组，和AE limit的count和项一样,调用的时候把OPID 版本等都包括在数组中
        {
            #region switch
            string tempLogStr = "";
            try
            {
                switch (PDCA_Step)
                {
                    case 10://连接
                        tempLogStr = "-----------------------" + "\r\n" + "-->> Start Test: ";
                        PDCA_RtnSN = "";
                        PDCA_Step = 11;
                        break;
                    case 11:
                        if (Globals.TCPIP_PDCA.IsOn == false)
                        {
                            Globals.TCPIP_PDCA.IP = "127.0.0.1";
                            Globals.TCPIP_PDCA.Port = 8500;
                            Globals.TCPIP_PDCA.IsReconnection = false;
                            Globals.TCPIP_PDCA.Start();
                            tempLogStr = "与服务端建立握手协议连接...";
                            TimeOut = API.GetTickCount();
                            PDCA_Step = 12;
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            PDCA_Step = 20;
                        }
                        break;
                    case 12:
                        if (Globals.TCPIP_PDCA.IsOn)
                        {
                            TimeOut = API.GetTickCount();
                            PDCA_Step = 20;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                tempLogStr = "与服务端握手协议连接超时！";
                                PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.PDCA通讯异常, AlarmCategory.SYSTEM.ToString(), "PDCA通讯异常");
                                PDCA_Step = 250;
                            }
                        }
                        break;
                    case 20:
                        string sendtemp = "sfc_post@c=QUERY_RECORD&sn=" + DataManager.Instance.CurrentCheckData.SN + "&p=fgsn";
                        Globals.TCPIP_PDCA.Sendmsg(sendtemp);
                        tempLogStr = "To Mac Mini ====> " + sendtemp;
                        TimeOut = API.GetTickCount();
                        PDCA_Step = 30;
                        break;
                    case 30:
                        string result = "";
                        if (Globals.TCPIP_PDCA.GetReply(out result, 10000))
                        {
                            if (result.IndexOf("ok@{") >= 0)
                            {
                                tempLogStr = "From Mac Mini <====" + result;
                                string[] strarr = SplitString(result, "fgsn=");
                                PDCA_RtnSN = SplitString(strarr[1], "}@")[0];
                                PDCA_Step = 40;
                            }
                            else
                            {
                                tempLogStr = "反馈ok@失败！go to failed";
                                PDCA_Step = 80;
                            }
                        }
                        else
                        {
                            tempLogStr = "与服务端握手协议连接超时！";
                            PostTaskAlarm(XAlarmLevel.ONLYLOG, (int)AlarmCode.PDCA通讯异常, AlarmCategory.SYSTEM.ToString(), "PDCA通讯异常");
                            PDCA_Step = 250;
                        }
                        break;
                    case 40:
                        #region PDCAsendmsg
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Clear();
                        stringBuilder.Append("_{\r\n");
                        string AuditMode = (Globals.MachineMode == MachineModeType.CPKGRR) ? "@start@audit" : "@start";
                        stringBuilder.Append(DataManager.Instance.CurrentCheckData.SN + AuditMode + "\r\n");
                        for (int i = 0; i < AElimitsCount; i++)
                        {
                            string stringout = "";
                            string tempstr = (MMSPDCA[i].TestName == "SW Version") ? "submit" : "pdata";
                            bool IsNA = (MMSPDCA[i].Upper_Limit == "NA") && (MMSPDCA[i].Lower_Limit == "NA");
                            if (tempstr == "submit")
                            {
                                stringout = DataManager.Instance.CurrentCheckData.SN + "@"
                                           + tempstr + "@"
                                           + "SV1.0.0\r\n";
                            }
                            else
                            {
                                if (MMSPDCA[i].TestName == "Operator_ID" || MMSPDCA[i].TestName == "Priority" || MMSPDCA[i].TestName == "TestSeriesID" || MMSPDCA[i].TestName == "Mode")
                                {
                                    stringout = DataManager.Instance.CurrentCheckData.SN + "@"
                                                + tempstr + "@"
                                                + MMSPDCA[i].TestName + "@"
                                                + Test_data[i] + "@\r\n";
                                }
                                else
                                {
                                    if (IsNA)
                                    {
                                        stringout = DataManager.Instance.CurrentCheckData.SN + "@"
                                                    + tempstr + "@"
                                                    + MMSPDCA[i].TestName + "@"
                                                    + Test_data[i] + "@@@"
                                                    + MMSPDCA[i].Unit + "\r\n";
                                    }
                                    else
                                    {
                                        stringout = DataManager.Instance.CurrentCheckData.SN + "@"
                                                    + tempstr + "@"
                                                    + MMSPDCA[i].TestName + "@"
                                                    + Test_data[i] + "@"
                                                    + MMSPDCA[i].Upper_Limit + "@"
                                                    + MMSPDCA[i].Lower_Limit + "@"
                                                    + MMSPDCA[i].Unit + "\r\n";
                                    }
                                }
                            }
                            stringBuilder.Append(stringout);
                        }
                        stringBuilder.Append("}\r\n");
                        Globals.TCPIP_PDCA.Sendmsg(stringBuilder.ToString());
                        tempLogStr = "To Mac Mini ====> " + stringBuilder.ToString();
                        stringBuilder.Clear();
                        #endregion
                        PDCA_Step = 50;
                        break;
                    case 50:
                        result = "";
                        if (Globals.TCPIP_PDCA.GetReply(out result, 10000))
                        {
                            if (result.IndexOf("ok@{") >= 0)
                            {
                                tempLogStr = "From Mac Mini <====" + result;
                                PDCA_Step = 60;
                            }
                            else
                            {
                                tempLogStr = "反馈ok@失败！go to failed";
                                PDCA_Step = 80;
                            }
                        }
                        else
                        {
                            tempLogStr = "与服务端握手协议连接超时！";
                            PostTaskAlarm(XAlarmLevel.ONLYLOG, (int)AlarmCode.PDCA通讯异常, AlarmCategory.SYSTEM.ToString(), "PDCA通讯异常");
                            PDCA_Step = 250;
                        }
                        break;
                    case 60:
                        PDCA_Step = 70;
                        break;
                    case 70:
                        PDCA_Step = 80;
                        break;
                    case 80://Failed
                        string cancelstring = DataManager.Instance.CurrentCheckData.SN + "@cancel@" + "SV1.0.0\r\n";
                        Globals.TCPIP_PDCA.Sendmsg(cancelstring);
                        tempLogStr = "To Mac Mini ====> " + cancelstring;
                        PDCA_Step = 85;
                        break;
                    case 85:
                        result = "";
                        if (Globals.TCPIP_PDCA.GetReply(out result, 10000))
                        {
                            if (result.IndexOf("ok@{") >= 0)
                            {
                                tempLogStr = "From Mac Mini <====" + result;
                                PDCA_Step = 90;
                            }
                            else
                            {
                                tempLogStr = "反馈ok@失败！go to failed";
                                PDCA_Step = 90;
                            }
                        }
                        else
                        {
                            tempLogStr = "与服务端握手协议连接超时！";
                            PostTaskAlarm(XAlarmLevel.ONLYLOG, (int)AlarmCode.PDCA通讯异常, AlarmCategory.SYSTEM.ToString(), "PDCA通讯异常");
                            PDCA_Step = 250;
                        }
                        break;
                    case 90://Closed
                        tempLogStr = "Close PDCA";
                        Globals.TCPIP_PDCA.Close();
                        PDCA_Step = 0;
                        return FunctionStatus.Finish;
                    case 100:
                        break;
                    case 250:
                        Globals.TCPIP_PDCA.Close();
                        tempLogStr = "";
                        PDCA_Step = 0;
                        return FunctionStatus.Error;
                }
                if (!string.IsNullOrEmpty(tempLogStr))
                {
                    WritePDCALog(PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\logs\\PDCA\\" + DateTime.Now.ToString("yyyyMMdd"), tempLogStr, DataManager.Instance.CurrentCheckData.SN);
                    SetStep(PDCA_Step + ":" + tempLogStr, Mycolor.None);
                    tempLogStr = "";
                }
                return FunctionStatus.Working;
            }
            catch (Exception)
            {
                PDCA_Step = 0;
                return FunctionStatus.Error;
            }

            #endregion
        }

        private void WritePDCALog(string PDCALogPath, string message, string SN = "")
        {
            string path;
            if (System.IO.Directory.Exists(PDCALogPath) == false)
                System.IO.Directory.CreateDirectory(PDCALogPath);
            if (SN.Length<5)
                path = PDCALogPath + "\\" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            else
                path = PDCALogPath + "\\" +SN + ".txt";
             
            string str = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff") + " ---" + message;
            CsvServer.Instance.WriteLine(path, str);
        }

        private string[] SplitString(string needSplitstring, string searchstring)
        {
            string temp = needSplitstring.Replace(searchstring, ",");
            return temp.Split(',');
        }

        struct PDCAstruct
        {
            public string TestName;
            public string Upper_Limit;
            public string Nominal;
            public string Lower_Limit;
            public string Unit;
        }
        PDCAstruct[] MMSPDCA;
        private DataTable dtAElimits = new DataTable();
        private int AElimitsCount=0;
        private bool AELimitsRead()
        {
            try
            {
                string AElimitsPath = PVar.BZ_ParameterPath + "AELimitsMMS.csv";
                dtAElimits = Globals.csv.OpenCSVNoColumnHeader(AElimitsPath);
                MMSPDCA = new PDCAstruct[dtAElimits.Columns.Count];
                AElimitsCount = dtAElimits.Columns.Count-1;
                for (int i = 0; i < AElimitsCount; i++)//the first column ignore
                {
                    MMSPDCA[i].TestName = dtAElimits.Rows[0][i + 1].ToString();
                    MMSPDCA[i].Upper_Limit = dtAElimits.Rows[1][i + 1].ToString();
                    MMSPDCA[i].Nominal = dtAElimits.Rows[2][i + 1].ToString();
                    MMSPDCA[i].Lower_Limit = dtAElimits.Rows[3][i + 1].ToString();
                    MMSPDCA[i].Unit = dtAElimits.Rows[4][i + 1].ToString();//null的时候会出错   
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        #endregion

    }
}
