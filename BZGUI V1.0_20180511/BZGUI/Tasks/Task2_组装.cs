using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;         //for File dir
using System.Diagnostics;//process
using XCore;
using BZGUI.Data;

namespace BZGUI
{
    class Task2_组装 : XTask
    {
        #region Private
        private static int tempi = 0;
        #endregion

        #region Public

        public static event Action<EnumShowResult> EventShowResult;
        public static event Action<CheckData> OnCurrentInf;
        public static event Action OnFlashDataPage;//to cpk data

        #endregion

        #region Override

        public Task2_组装(string path)
            : base(path)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
            HomeOK = true;//just for test
            Flag_TaskdisEnable = false;//本站是否启用，强制打开
        }

        protected override void Homing()
        {
            AutoRunstep = 0;
            InitHomingStep = 10;
            while (InitHomingStep != 0)
            {
                InitHoming();
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
                if (HomeOK == false)
                {
                    SetState(XTaskState.WAITRESET);
                    return;
                }
                if (xState != XTaskState.PAUSE)    //暂停状态时不扫描
                {
                    switch ((StationRunMode)runMode)
                    {
                        case StationRunMode.空跑:
                            DryRun();
                            break;
                        case StationRunMode.自动运行:
                            AutoRun();
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
        private void InitHoming()
        {
            switch (InitHomingStep)
            {
                case 10:
                    {
                        AutoRunstep = 0;
                        SetStep("Motor start Homing!", Mycolor.None);
                        InitHomingStep = 20;
                        Thread.Sleep(100);
                        InitHomingDelay.InitialTime();
                        break;
                    }
                case 20:
                    {
                        if (InitHomingDelay.TimeIsUp(1000))
                        {
                            SetStep("Motor2 start Homing!", Mycolor.None);
                            InitHomingStep = 2000;
                        }
                        break;
                    }

                case 50:
                    InitHomingStep = 2000;
                    break;

                case 2000:
                    InitHomingStep = 0;
                    SetStep("Home is OK!", Mycolor.None);
                    Thread.Sleep(100);
                    SetState(XTaskState.WAITRUN);
                    SetStepNum(InitHomingStep);
                    HomeOK = true;
                    break;

                case 8000:
                    {
                        InitHomingStep = 0;
                        break;
                    }
            }
            SetStepNum(InitHomingStep);
        }

        private void DryRun()
        {
            switch (AutoRunstep)
            {
                case 10:
                    TaskIsWorking = true;
                    SetStep("CLEAR", Mycolor.None);
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp10", Mycolor.None);
                    EventShowResult(EnumShowResult.Empty);
                    AutoRunstep = 20;
                    break;
                case 20:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp20", Mycolor.None);
                    AutoRunstep = 30;
                    break;
                case 30:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp30", Mycolor.None);
                    AutoRunstep = 40;
                    break;
                case 40:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp40", Mycolor.None);
                    AutoRunstep = 50;
                    break;
                case 50:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp50", Mycolor.Red);
                    AutoRunstep = 60;
                    break;
                case 60:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp60", Mycolor.None);
                    AutoRunstep = 70;
                    break;
                case 70:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp70", Mycolor.None);
                    #region 产生数据 1tray
                    //  "装配时间", "产品条码", "Result", "X", "Y", "A", "Dis" 
                    DataManager.Instance.CurrentCheckData.SN = "SNXXXXXXX";
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
                    DataManager.Instance.chartData.Adddata(m_A.ToString()+","+m_x.ToString()+","+m_y.ToString()+","+m_cc.ToString()); //AddData为更新生产的CPK数据 AddNewData为UPH数据，包括很多东西
                    DataManager.Instance.uph.UPHupdate();                        //UPH update by hour

                    if (OnCurrentInf != null)OnCurrentInf(DataManager.Instance.CurrentCheckData);//给工程界面的数据显示
                    if (OnFlashDataPage != null) OnFlashDataPage();

                    tempi++;

                    #endregion
                    AutoRunstep = 80;
                    break;
                case 80:
                    uint pck;
                    uint pck2;
                    gts.GT_GetClockHighPrecision(0, out pck);//用固高的紧密计数器计时
                    Thread.Sleep(5);
                    gts.GT_GetClockHighPrecision(0, out pck2);
                    uint ctt = pck2 - pck;
                    SetStep("AutoRun Setp60", Mycolor.None);
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp80", Mycolor.None);
                    StopWatch_Stop();//stop the CT count
                    StaStop = false;
                    AutoRunstep = 0;
                    SetStep("Save", Mycolor.None);
                    TaskIsWorking = false;
                    break;
                case 8000:
                    Thread.Sleep(100);
                    SetStep("AutoRun Setp8000", Mycolor.None);
                    AutoRunstep = 0;
                    StopWatch_Stop();//stop the CT count
                    TaskIsWorking = false;
                    return;
            }
            SetStepNum(AutoRunstep);
            Task_StopWatchElapsedMilliseconds();//获取CT
        }

        private void AutoRun()
        {
            switch (AutoRunstep)
            {
                case 10:
                    TaskIsWorking = true;
                    AutoRunstep = 20;
                    break;
                case 20:
                    break;
                case 30:
                    break;
                case 40:
                    break;
                case 50:
                    break;
                case 60:
                    break;
                case 70:
                    break;
                case 80:
                    break;
                case 90:
                    break;
                case 100:
                    break;
                case 1000:
                    TaskIsWorking = false;
                    AutoRunstep = 0;
                    break;
                case 8000:
                    AutoRunstep = 0;
                    TaskIsWorking = false;
                    break;

            }
        }
        #endregion

        #region Private Surpport


        #endregion

    }
}
