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
using BZappdll;

namespace BZGUI
{
    /// <summary>
    /// 只有用来处理双手启动，类似于总循环
    /// </summary>
    class Task0_Machine:XTask
    {
        #region 变量定义
        public static event Action<string> OnShowSth_OnSSH_Output;
        public static event Action<string> OnEngineerSN;//操作工程界面的条码操作
        private bool Double_Hands_start = false;//双手启动状态
        #endregion

        #region Override

        public Task0_Machine(string path)
            : base(path)
        {

        }

        public override void Initialize()
        {
            base.Initialize();
            HomeOK = true;//main cycle no need to home
            SetState(XTaskState.WAITRUN);
            Flag_TaskdisEnable = false;//本站是否启用，强制打开
            TaskIsWorking = false; 
        }

        protected override void Homing()
        {
            HomeOK = true;
            SetState(XTaskState.WAITRUN);
        }

        public override void Exit()
        {
            base.Exit();
        }

        protected override void Running(object runMode)
        {
            while (GoHome.Instance.Reset.Result)
            {
                if (runMode == null) runMode = StationRunMode.自动运行;
                switch ((StationRunMode)runMode)
                {
                    case StationRunMode.自动准备:
                        Auto_Ready();
                        runMode = StationRunMode.自动运行;//运动完Auto_Ready()后，需要切换到自动运行，这样就不会一直调用Auto_Ready()
                        break;
                    case StationRunMode.自动运行:
                        AutoRun();
                        break;
                }
                Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        #endregion

        #region StaionWork

        private void AutoRun()
        {
            #region Swithch
            switch (AutoRunstep)
            {
                case 10:
                    if (PVar.AutoRunFlag)
                    {
                        StopWatch_Stop();
                        StopWatch_Reset();
                        AutoRunstep = 20;
                    }
                    break;
                case 20://double start
                    if (Globals.Flag_ManualStart || Double_Hands_Start(1000,false))
                    {
                        Globals.Flag_ManualStart = false;
                        Double_Hands_Start(1000, true);
                        SetStep("CLEAR", Mycolor.None);
                        SetStep("手动启动或双手启动开始", Mycolor.None);
                        TaskIsWorking = true;
                        StopWatch_Start();
                        AutoRunstep = 25;
                    }
                    break;
                case 25:
                    if (Globals.settingFunc.启用空跑模式)  //空跑不需要条码
                    { AutoRunstep = 40;}
                    else
                    {AutoRunstep = 30; }
                    break;
                case 30://check the product sensor and check the fixtrue closed sensor
                    if(Gg.GetDi(0,Gg.InPutMMS0.夹具到位金属感应器)==0)
                    {
                        SetStep("夹具到位金属感应器感应异常", Mycolor.ErrorRed);
                        PVar.Ring_EN = true;//buzzer
                        AutoRunstep = 8000;
                        break;
                    }
                    if (Gg.GetDi(0, Gg.InPutMMS0.产品到位光纤感应器) == 0)
                    {
                        SetStep("产品到位光纤感应器感应异常", Mycolor.ErrorRed);
                        PVar.Ring_EN = true;//buzzer
                        AutoRunstep = 8000;
                        break;
                    }
                    AutoRunstep = 40;
                    break;
                case 40://check postion 
                    if((Gg.GetEncPosmm(0,BVar.MMSY)-mFunction.Pos.TeachAxis1[0, 0])>0.05)
                    {
                        SetStep("载具不在初始位置！请回零！", Mycolor.ErrorRed);
                        PVar.Ring_EN = true;//buzzer
                        AutoRunstep = 8000;
                        break;
                    }
                    AutoRunstep = 50;
                    break;
                case 45:
                    if (Gg.GetDi(0, Gg.InPutMMS0.安全光幕) == 1)
                    {
                        SetStep("安全光幕异常", Mycolor.ErrorRed);
                        PVar.Ring_EN = true;//buzzer
                        AutoRunstep = 8000;
                        break;
                    }
                    AutoRunstep = 50;
                    break;
                case 50://check barcode
                    if (Globals.settingFunc.启用空跑模式)//空跑不需要条码
                    { AutoRunstep = 80; break; }
                    if (PageLogin.loginTp != loginType.Op)
                    {
                        if ((Globals.BarcodeSN.Length >= Globals.settingPara.学习条码长度.Length - 2 || Globals.BarcodeSN.Length >= Globals.settingPara.学习条码长度.Length + 2))
                        {
                            SetStep("条码长度OK！", Mycolor.None);
                            DataManager.Instance.CurrentCheckData.SN = Globals.BarcodeSN;
                        }
                        else
                        {
                            SetStep("生成时间条码！", Mycolor.None);
                            DataManager.Instance.CurrentCheckData.SN = DateTime.Now.ToString("yyyMMdd_HHmmss");
                        }
                        TimeOut = API.GetTickCount();
                        AutoRunstep = 80;                    
                    }
                    else//op
                    {
                        if ((Globals.BarcodeSN.Length >= Globals.settingPara.学习条码长度.Length - 5
                        || Globals.BarcodeSN.Length >= Globals.settingPara.学习条码长度.Length + 5))//OP mode ,need check the length of barcode
                        {
                            SetStep("条码长度OK！", Mycolor.None);
                            PVar.Ring_EN = true;//buzzer
                            DataManager.Instance.CurrentCheckData.SN = Globals.BarcodeSN;
                            TimeOut = API.GetTickCount();
                            AutoRunstep = 80;
                        }
                        else
                        {
                            SetStep("条码长度异常！", Mycolor.ErrorRed);
                            DataManager.Instance.CurrentCheckData.SN = "";
                            if (OnEngineerSN != null) OnEngineerSN("");//让工程界面的clear SN, foucs on
                            AutoRunstep = 8000;
                        }
                    }
                    break;
                case 80:
                    if (OnShowSth_OnSSH_Output != null) OnShowSth_OnSSH_Output("");//clear SSHinfo
                    if (OnEngineerSN != null) OnEngineerSN("");//让工程界面的clear SN, foucs on
                    Globals.BarcodeSN = "";

                    if (Globals.settingFunc.启用空跑模式)
                    { 
                        StopWatch_Reset();
                        StopWatch_Start();  
                        SetStep("CLEAR", Mycolor.None); 
                    }
                    StationRunMode _runmode = Globals.settingFunc.启用空跑模式 ? StationRunMode.空跑 : StationRunMode.自动运行;
                    if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
                    { XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskGo(); }
                    else
                    { XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskGo(); }
                    SetStep("每站自动开始", Mycolor.None);
                    TimeOut = API.GetTickCount();
                    AutoRunstep = 90;
                    break;
                case 90:
                    if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
                    {
                        if (XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskIsWorking == false)
                        {
                            SetStep("自动单循环完成", Mycolor.None);
                            AutoRunstep = 100;
                        }                    
                    }
                    else
                    {
                        if (XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskIsWorking == false)
                        {
                            SetStep("自动单循环完成", Mycolor.None);
                            AutoRunstep = 100;
                        }
                    }

                    if (API.GetTickCount() - TimeOut > 60000)
                    {
                        SetStep("自动超时60S,退出主循环！！", Mycolor.ErrorRed);
                        AutoRunstep = 8000;
                    }
                    break;
                case 100:
                    StopWatch_Stop();
                    TaskIsWorking = false;
                    AutoRunstep = 10;//正常结束
                    if (Globals.settingFunc.启用空跑模式)
                    {
                        SetStep("空跑模式，继续", Mycolor.ErrorRed);
                        Thread.Sleep(1000);
                        AutoRunstep = 80;
                        if (StaStop)//如果点了停止按钮，把当前的Cycle完成
                        {
                            SetStep("停止中......", Mycolor.ErrorRed);
                            Globals.Flag_ManualStart = false;
                            StaStop = false;
                            AutoRunstep = 10;
                        }
                    }
                    break;
                case 8000:
                    StopWatch_Stop();
                    TaskIsWorking = false;
                    AutoRunstep = 10;
                    break;
            }
            SetStepNum(AutoRunstep);
            Task_StopWatchElapsedMilliseconds();//获取CT
            #endregion
        }

        public void Auto_Ready()
        {
            PVar.AutoRunFlag = true;
            PVar.MacHold = false;
            PVar.Stop_Flag = false;
            PVar.LampStatus = 30;
            #region 打开包括除Task0的线程
            StationRunMode _runmode = Globals.settingFunc.启用空跑模式 ? StationRunMode.空跑 : StationRunMode.自动运行;
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            {
                if (XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).Flag_TaskdisEnable == false)
                    XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskStart(_runmode);
            }
            else
            {
                if (XTaskManager.Instance.FindTaskById((int)TasksId.测试).Flag_TaskdisEnable == false)
                    XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskStart(_runmode);
            }
            #endregion
            AutoRunstep = 10;
            SetStep("设备进入自动运行中…", Mycolor.None);
            Globals.isAdmin = false;
            if (OnEngineerSN != null) OnEngineerSN("");//让工程界面的SN foucs on
        }

        #endregion

        #region Private Surpport

        #region 双手启动
        LDPF LeftStart = new LDPF();
        LDPF RightStart = new LDPF();
        private Stopwatch m_LeftTimer = new Stopwatch();
        private Stopwatch m_RightTimer = new Stopwatch();
        private bool M_leftstart;//中间变量
        private bool M_Rightstart;//中间变量
        private bool Double_Hands_Start(int timeinterval_ms = 500,bool RST_Start=false)
        {
            if (RST_Start)
            {
                M_leftstart = false;
                m_LeftTimer.Stop();
                m_LeftTimer.Reset();
                M_Rightstart = false;
                m_RightTimer.Stop();
                m_RightTimer.Reset();
                return false;
            }
            else
            {
                //left
                //if (LeftStart.Bool_LDP(Gg.GetDi(0, Gg.InPutMMS0.左手启动) == 1) && PVar.AutoRunFlag && PVar.IsSysEmcStop == false && Gg.GetDi(0, Gg.InPutMMS0.安全光幕) == 0)//这里需要加很多条件
                if (LeftStart.Bool_LDP(Gg.GetDi(0, Gg.InPutMMS0.左手启动) == 1) && PVar.AutoRunFlag && PVar.IsSysEmcStop == false)//这里需要加很多条件
                {
                    m_LeftTimer.Reset();
                    m_LeftTimer.Start();
                }
                if (m_LeftTimer.ElapsedMilliseconds < timeinterval_ms && m_LeftTimer.ElapsedMilliseconds > 0 && AutoRunstep <= 20)
                { M_leftstart = true; }
                else if (m_LeftTimer.ElapsedMilliseconds > timeinterval_ms)
                {
                    M_leftstart = false;
                    m_LeftTimer.Stop();
                    m_LeftTimer.Reset();
                }
                //right
                //if (RightStart.Bool_LDP(Gg.GetDi(0, Gg.InPutMMS0.右手启动) == 1) && PVar.AutoRunFlag && PVar.IsSysEmcStop == false && Gg.GetDi(0, Gg.InPutMMS0.安全光幕) == 0)//这里需要加很多条件
                if (RightStart.Bool_LDP(Gg.GetDi(0, Gg.InPutMMS0.右手启动) == 1) && PVar.AutoRunFlag && PVar.IsSysEmcStop == false && AutoRunstep <= 20)//这里需要加很多条件
                {
                    m_RightTimer.Reset();
                    m_RightTimer.Start();
                }
                if (m_RightTimer.ElapsedMilliseconds < timeinterval_ms && m_RightTimer.ElapsedMilliseconds > 0)
                { M_Rightstart = true; }
                else if (m_RightTimer.ElapsedMilliseconds > timeinterval_ms)
                {
                    M_Rightstart = false;
                    m_RightTimer.Stop();
                    m_RightTimer.Reset();
                }
                return M_leftstart && M_Rightstart;
            }
        }
        #endregion

        #endregion

    }
}
