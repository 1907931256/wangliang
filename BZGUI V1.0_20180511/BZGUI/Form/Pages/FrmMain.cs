using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using BZ.UI;
using System.IO;
using System.Threading;
using System.Data.OleDb;
using VB = Microsoft.VisualBasic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using SocketHelper.TCP;
using BZappdll;
using XCore;

namespace BZGUI
{
    public partial class FrmMain : Form
    {
        #region 变量定义
        private int i;
        private Dictionary<BoTech.Button, Control> pageMap = new Dictionary<BoTech.Button, Control>();
        private PageEngineering PageEngineering;
        private Frm_Dialog fdg=new Frm_Dialog();
        public static event Action _thread_Status_Quit;

        #endregion

        #region 窗体操作

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.MinimumSize = this.Size;
            #region 检查执行参数文件夹
            System.IO.DirectoryInfo SFile = new System.IO.DirectoryInfo(PVar.BZ_ParameterPath);
            CheckForIllegalCrossThreadCalls = false;
            if (!SFile.Exists)
            {
                if (Interaction.MsgBox("参数文件不存在，程序拒绝加载，请查看路径：" + "\r\n" + PVar.BZ_ParameterPath + "\r\n" + "执行函数Main_Load()", Constants.vbExclamation, "重要参数文件") == Constants.vbOK)
                {
                    //ProjectData.EndApp();
                }
            }
            #endregion
            this.Text = Globals.settingMachineInfo.什么机器.ToString();
            PageLogin.loginTp = loginType.Op;
            PageEngineering.PauseClick += On_Pause;
            //PageEngineering.On_EMG += On_ErrorBtn;
            PageProduction.On_Errorbtn += On_ErrorBtn;
            FunctionSub.Close_Excel_Process();//加载参数前，判断有没有打开Excel，打开的话关掉
            Globals.BindDevice();
            #region 加载Data
            DataManager.Instance.toosing = DataManager.Instance.toosing.Load();//本机不存在抛料问题
            DataManager.Instance.yield = DataManager.Instance.yield.Load();
            DataManager.Instance.uph = DataManager.Instance.uph.Load();
            DataManager.Instance.currentyield = DataManager.Instance.currentyield.LoadCurrentYield();
            DataManager.Instance.alarmRecord = DataManager.Instance.alarmRecord.Load();
            #endregion
            InitPages();
            InitTask();
            CsvServer.Instance.Start();
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS) DAQ.Instance.Start();//for pci9222 analog
            PVar.LampStatus = 50;
            Globals.InitDevice();
            if (Globals.settingFunc.打开SSH通信)
            {
                SSH_Thread.Instance.Start();
                SSH.Instance.Connect(Globals.settingPara.SSH远程IP地址, 22, Globals.settingPara.SSH用户名, out Globals.SSHconnSt);
            }
            this.Btn_Start.BackColor = Mycolor.Red;
            this.Btn_Pause.BackColor = Mycolor.None;
            this.Btn_Stop.BackColor = Mycolor.None;
            this.Btn_Start.Enabled = true;
            this.Btn_Stop.Enabled = false;
            this.Btn_Pause.Enabled = true;
            this.timer1.Enabled = true;
        }

        private void InstanceCloseWindow()
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出程序？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (_thread_Status_Quit != null) _thread_Status_Quit();
                if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS) DAQ.Instance.Stop();
                Globals.settingFunc.SaveSetting();//保存TimeMode，为了重启的时候用
                CsvServer.Instance.Stop();
                ExitTask();
                this.timer1.Enabled = false;
                Globals.CloseDevice();
                //最后关掉
                if (Globals.settingFunc.打开SSH通信)
                {
                    SSH_Thread.Instance.Stop();
                    if (Globals.SSHconnSt) SSH.Instance.disConnect(out Globals.SSHconnSt);
                }
                Environment.Exit(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region 按钮操作

        #region 功能：整机开始
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            this.Btn_Start.BackColor = Mycolor.UnselectedBtn; ;
            this.Btn_Pause.BackColor = Mycolor.None;
            this.Btn_Stop.BackColor = Mycolor.None;

            if (GoHome.Instance.Reset.Result)
            {
                if (MessageBox.Show("确定开始自动运行？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    FileLog.OperateLog("自动运行");
                    XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).TaskStart(StationRunMode.自动准备);//first run the thread
                    this.Btn_Start.Enabled = false;
                    this.Btn_Stop.Enabled = true;
                    this.Btn_Pause.Enabled = true;
                }
            }
            else
            {
                if (PVar.AutoRunFlag == false)
                {
                    if (MessageBox.Show("确定开始复位？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (Gg.GetDi(0, Gg.InPutMMS0.紧急停止) == 1)
                        {
                            Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.急停, AlarmCategory.SYSTEM.ToString(), "急停中，复位异常结束！！");
                            Globals.addList("急停中，复位异常结束！！", Mycolor.ErrorRed);
                            return;
                        }
                        XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).TaskReset();
                        if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
                        { XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskReset(); }
                        else
                        { XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskReset(); }
                        FileLog.OperateLog("初始化");
                        this.Btn_Start.Enabled = true;
                        this.Btn_Stop.Enabled = false;
                        this.Btn_Pause.Enabled = false;
                    }
                }
            }
            PVar.IsSysEmcStop = false;
        }
        #endregion

        #region 功能：整机暂停
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            On_Pause();
        }
        /// <summary>
        /// pause
        /// </summary>
        private void On_Pause()
        {
            if (GoHome.Instance.Reset.Result&&PVar.AutoRunFlag)
            {
                if (PVar.MacHold)
                {
                    if (Interaction.MsgBox("确定【继续运行】吗？", (int)Constants.vbInformation + Constants.vbOKCancel, "【继续运行】") == Constants.vbCancel)
                        return;
                    PVar.IsSystemOnPauseMode = false;
                    this.Btn_Pause.BackColor = Mycolor.None;
                    Globals.addList("暂停运行已解除", Mycolor.None);
                    ContinuRun(); //继续运行
                    FileLog.OperateLog("继续运行");
                    this.Btn_Start.Enabled = false;
                    this.Btn_Stop.Enabled = true;
                    this.Btn_Pause.Enabled = true;
                }
                else
                {
                    Globals.addList("设备已暂停", Mycolor.ErrorRed);
                    PVar.IsSystemOnPauseMode = true;
                    this.Btn_Pause.BackColor = Mycolor.SelectedBtn;
                    StopRun(); //暂停运行
                    FileLog.OperateLog("暂停运行");
                    this.Btn_Start.Enabled = false;
                    this.Btn_Stop.Enabled = false;
                    this.Btn_Pause.Enabled = true;
                }
            }
        }
        /// <summary>
        /// only pause;
        /// </summary>
        private void On_Pause(bool onlyPause)
        {
            if (onlyPause)
            {
                PVar.Ring_EN = true;//buzzer
                Globals.addList("设备已暂停", Mycolor.ErrorRed);
                PVar.IsSystemOnPauseMode = true;
                this.Btn_Pause.BackColor = Mycolor.SelectedBtn;
                StopRun(); //暂停运行
                this.Btn_Start.Enabled = false;
                this.Btn_Stop.Enabled = false;
                this.Btn_Pause.Enabled = true;
            }
        }

        public void ContinuRun() //继续运行
        {
            PVar.MacHold = false;
            Btn_Stop.Enabled = true;
            StationRunMode moderuntemp = Globals.settingFunc.启用空跑模式 ? StationRunMode.空跑 : StationRunMode.自动运行;
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            { XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskStart(moderuntemp); }
            else
            { XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskStart(moderuntemp); }

            PVar.LampStatus = 30;
        }

        public void StopRun() //暂停运行
        {
            PVar.MacHold = true;
            PVar.Stop_Flag = false;
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            { XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskPause(); }
            else
            { XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskPause(); }
            PVar.LampStatus = 20;
        }

        #endregion

        #region 功能：整机停止
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Btn_StopFun();
            FileLog.OperateLog("停止按钮");
        }
        public void Btn_StopFun()
        {
            if (PVar.MacHold == true)
            {
                Globals.addList("设备处于暂停中...", Mycolor.None);
                return;
            }
            if (PVar.AutoRunFlag)
            {
                XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).TaskStop();
                PVar.AutoRunFlag = false;
                PVar.Stop_Flag = true;
                PVar.LampStatus = 20;
            }
            else
            {
                Globals.addList("设备没有自动运行", Mycolor.ErrorRed);
            }
            this.Btn_Start.Enabled = true;
            this.Btn_Stop.Enabled = true;
            this.Btn_Pause.Enabled = true;
        }

        #endregion

        //急停按下事件
        private void On_ErrorBtn()
        {
            this.Btn_Start.BackColor = Mycolor.Red;
            this.Btn_Pause.BackColor = Mycolor.None;
            this.Btn_Stop.BackColor = Mycolor.None;
            this.Btn_Start.Enabled = true;
            this.Btn_Stop.Enabled = true;
            this.Btn_Pause.Enabled = true;
            PVar.MacHold = false;
            PVar.LampStatus = 10;
        }

        private void Btn_OpenDataFile_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = Globals.Dir_Record_Report;
                if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
                { filePath = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\PDCA Data"; }
                else
                { filePath = PVar.BZ_DataPath + "IPDM Data-" + Globals.settingMachineInfo.机器编号 + "\\PDCA Data"; }

                if (Directory.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception)
            {
            }
        }

        private void Btn_OpenCCDFile_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = Globals.Dir_Record_Image;
                if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
                { filePath = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data"; }
                else
                { filePath = PVar.BZ_DataPath + "IPDM Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data"; }

                if (Directory.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion

        #region 其他操作

        private void InitTask()
        {
            XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).Initialize();
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            { XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).Initialize(); }
            else
            { XTaskManager.Instance.FindTaskById((int)TasksId.测试).Initialize(); }
        }

        private void ExitTask()
        {
            XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).Exit();
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            { XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).Exit(); }
            else
            { XTaskManager.Instance.FindTaskById((int)TasksId.测试).Exit(); }

        }

        private void BZ_Btn_Click(object sender, EventArgs e)
        {
            BoTech.Button BtnClicked = sender as BoTech.Button;
            if (BtnClicked.Name == "Btn_Home")
            {
                PageLogin.loginTp = loginType.Op;
            }
            if (BtnClicked.Name == "Btn_ParSetting")
            {
                //do sth
                if (PageLogin.loginTp == loginType.Op || PageLogin.loginTp == loginType.None) return;
            }

            foreach (KeyValuePair<BoTech.Button, Control> kvp in pageMap)
            {
                if (kvp.Key.Name == BtnClicked.Name)
                {
                    this.pageContainer.Controls.Clear();
                    this.pageContainer.Controls.Add(pageMap[kvp.Key]);
                    pageMap[kvp.Key].Dock = DockStyle.Fill;//wl
                }
            }
        }

        private void InitPages()
        {
            this.Btn_MachineInfo.Text = Globals.settingMachineInfo.什么机器.ToString();//Use a para
            pageMap.Add(Btn_Home, new PageLogin());
            pageMap.Add(Btn_Production, new PageProduction());
            pageMap.Add(Btn_AlarmHistory, new PageAlarm());
            pageMap.Add(Btn_RunInfo, new PageChart());
            pageMap.Add(Btn_CCDSetting, new PageVision());
            pageMap.Add(Btn_ParSetting, new PageSetting());
            pageMap.Add(Btn_MachineInfo, new PageMachineInfo());
            PageEngineering = new PageEngineering();
            PageEngineering.Dock = DockStyle.Fill;//wl
            this.pageContainer.Controls.Add(PageEngineering);


            foreach (KeyValuePair<BoTech.Button, Control> kvp in pageMap)
            {
                kvp.Value.Location = new Point(0, 0);
                kvp.Key.Click += BZ_Btn_Click;
            }
            this.pageContainer.Controls.Clear();
            this.pageContainer.Controls.Add(pageMap[Btn_Home]);
            pageMap[Btn_Home].Dock = DockStyle.Fill;//wl
            var page = (PageLogin)pageMap[Btn_Home];
            page.ONShowPage += ShowModePage;
            page.ONColseWindow += InstanceCloseWindow;
            /////////////////让Product也先加载,一直运行，Alarm就能清掉////////////
            this.pageContainer.Controls.Add(pageMap[Btn_Production]);
            pageMap[Btn_Production].Dock = DockStyle.Fill;//wl
            this.pageContainer.Controls.Add(pageMap[Btn_AlarmHistory]);
            pageMap[Btn_AlarmHistory].Dock = DockStyle.Fill;//wl
            //////////////////////////////////////////////////////////////////////
        }

        private void ShowModePage(MachineModeType mode)
        {
            switch (mode)
            {
                case MachineModeType.Engineering:
                    this.pageContainer.Controls.Clear();
                    this.pageContainer.Controls.Add(PageEngineering);

                    break;
                case MachineModeType.Production:
                    this.pageContainer.Controls.Clear();
                    this.pageContainer.Controls.Add(pageMap[Btn_Production]);
                    break;
                case MachineModeType.CPKGRR:
                    this.pageContainer.Controls.Clear();
                    this.pageContainer.Controls.Add(PageEngineering);
                    break;
            }
            Globals.MachineMode = (MachineModeType)mode;
        }

        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool InitOKtemp = true;
            foreach (XTask task in XTaskManager.Instance.Tasks.Values)
            { InitOKtemp = InitOKtemp && task.HomeOK; }
            GoHome.Instance.Reset.Result = InitOKtemp;//整机回零标志
            this.Btn_Start.BackColor = PVar.AutoRunFlag ? Mycolor.Green : Mycolor.Red;
            if (InitOKtemp)
            { this.BackColor = (PageLogin.loginTp == loginType.Op) ? Color.White : Color.Orange; }
            else
            {
                this.BackColor = InitOKtemp ? Mycolor.White : Mycolor.ErrorRed;//the frmmian backcolor.}
                PVar.AutoRunFlag = false;
            }
        }
        #endregion

    }
}