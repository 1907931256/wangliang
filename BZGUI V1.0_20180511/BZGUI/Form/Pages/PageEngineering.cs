using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using XCore;
using BZappdll;
using LabSSH;

namespace BZGUI
{
    public partial class PageEngineering : UserControl
    {
        #region 变量定义
        //1.声明自适应类实例  
        private AutoSizeFormClass asc = new AutoSizeFormClass(); 
        LDPF Emg = new LDPF();//急停上升下降沿
        LDPF startbtn = new LDPF();
        public static event Action<bool> PauseClick;
        public static event Action<string> ShowList;

        #endregion

        #region 窗体操作

        public PageEngineering()
        {
            InitializeComponent();
            Instance_ShowDemoMode();
            PageLogin.OnChangeLanguage += Instance_LanguageChange;
            FrmMain._thread_Status_Quit += _threadStop;
            _threadStart();
        }
        private void PageEngineering_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);  
            #region Event Load
            SSH_Thread.Instance.OnSSHInf += Instance_SSHInfoShow;
            Task0_Machine.OnEngineerSN += Instance_SN_Show;
            Task0_Machine.OnShowSth_OnSSH_Output += Instance_SSHInfoShow;
            #endregion
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.IPDM)
            {
                laserHights1.Visible = false;
                CCD_Status.Visible = true;
                Scanner_Status.Visible = true;
                this.xtaskStateRichList2.Visible = true;
                this.xtaskStateRichList3.Visible = false;//for MMS
            }
            else
            {
                this.xtaskStateRichList2.Visible = false;
                this.xtaskStateRichList3.Visible = true;//for MMS
            }
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageEngineering));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageEngineering));
        }
        private void PageEngineering_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        /// <summary>
        /// SSH show info
        /// </summary>
        /// <param name="SSHinfo"></param>
        private void Instance_SSHInfoShow(string SSHinfo)
        {
            if (SSHinfo==""||SSHinfo.ToUpper() == "CLEAR")
            { 
                SSHOutput.Text = "";
                Globals.SSHstring = "";
                return;
            }
            SSHOutput.AppendText(SSHinfo);
            SSHOutput.ScrollToCaret();
            Globals.SSHstring = SSHOutput.Text;
        }
        /// <summary>
        /// 条码操作
        /// </summary>
        private void Instance_SN_Show(string SN)
        {
            this.txt_SN.Text = SN;
            if (SN == "" || SN.ToUpper()=="CLEAR")
            {
                Globals.Invoker.SetCtlFocus(this.txt_SN);
            }
        }

        private void txt_SN_TextChanged(object sender, EventArgs e)
        {
            Globals.BarcodeSN = this.txt_SN.Text;
        }

        private void PageEngineering_VisibleChanged(object sender, EventArgs e)
        {
            //this.Enabled = (PageLogin.loginTp == loginType.Op) ? false : true;
            Instance_ShowDemoMode();
            if(Visible) Invoker.SetCtl_Enable(this.Btn_Manual, (PVar.AutoRunFlag || PageLogin.loginTp == loginType.Op) ? false : true);
        }

        private void PageEngineering_Paint(object sender, PaintEventArgs e)
        {
            //this.Enabled = (PageLogin.loginTp == loginType.Op) ? false : true;
            Instance_ShowDemoMode();
            this.bool_Routine1.Checked = Globals.settingPara.Routine1状态;
            this.bool_Routine2.Checked = Globals.settingPara.Routine2状态;
            this.bool_Routine3.Checked = Globals.settingPara.Routine3状态;
            this.bool_Routine1.Visible = (PageLogin.loginTp == loginType.Op) ? false : true;
            this.bool_Routine2.Visible = (PageLogin.loginTp == loginType.Op) ? false : true;
            this.bool_Routine3.Visible = (PageLogin.loginTp == loginType.Op) ? false : true;
            this.label2.Visible = (PageLogin.loginTp == loginType.Op) ? false : true;
        }

        #endregion

        #region 按钮操作
        /// <summary>
        /// 手动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Manual_Click(object sender, EventArgs e)
        {
            if (PVar.AutoRunFlag) return;
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
            if (PageLogin.loginTp == loginType.Op || PageLogin.loginTp == loginType.None)
                return;
            FrmManual manual = new FrmManual();
            manual.ShowDialog();
        }
        /// <summary>
        /// 手动开始按钮
        /// </summary>
        private bool temptest = false;
        private void btn_MStart_Click(object sender, EventArgs e)
        {
            if (GoHome.Instance.Reset.Result&&PVar.AutoRunFlag) Globals.Flag_ManualStart = true;
            temptest = !temptest;
        }

        /// <summary>
        /// reconnect ssh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SSHsts_Click(object sender, EventArgs e)
        {
            if (Globals.settingFunc.打开SSH通信)
            {
                SSH_Thread.Instance.Start();
                SSH.Instance.Connect(Globals.settingPara.SSH远程IP地址, 22, Globals.settingPara.SSH用户名, out Globals.SSHconnSt);
            }
        }
        
        //上升和下降沿的急停的处理，参考BAM
        private bool btn_EMG_Sta;
        LDPF EmgSt = new LDPF();
        private void Btn_EMG_Click(object sender, EventArgs e)
        {
            btn_EMG_Sta = !btn_EMG_Sta;
            if (btn_EMG_Sta)
            {EMG();}
            else { PVar.IsSysEmcStop = false; }
        }
        /// <summary>
        /// 紧急停止处理
        /// </summary>
        private void EMG()
        {
            XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).TaskEStop();
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            {XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskEStop();}
            else { XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskEStop(); }
            //XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).PostTaskAlarm(XAlarmLevel.STOP, (int)AlarmCode.急停, AlarmCategory.SYSTEM.ToString(), "紧急停止");
            Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.急停, AlarmCategory.SYSTEM.ToString(), "紧急停止");
            //add sth like aixs
            Gg.Set_Servo(0, 1, false);//close seveo on
            PVar.IsSysEmcStop = true;
            Globals.Flag_ManualStart = false;
            PVar.AutoRunFlag = false;
            GoHome.Instance.Reset.Result = false;
        }

        private void bool_Routine3_Trigger(Bool obj)
        {
            Globals.settingPara.Routine1状态 = this.bool_Routine1.Checked;
            Globals.settingPara.Routine2状态 = this.bool_Routine2.Checked;
            Globals.settingPara.Routine3状态 = this.bool_Routine3.Checked;
            if (!this.bool_Routine1.Checked && !this.bool_Routine2.Checked && !this.bool_Routine3.Checked)
            {
                this.bool_Routine1.Checked = true;
                Globals.settingPara.Routine1状态 = this.bool_Routine1.Checked;
            }
            Globals.settingPara.SaveSetting();
        }

        #endregion

        #region Timer
        private BZappdll.InvokerClass Invoker = new BZappdll.InvokerClass();
        private void StatusFresh()
        {
            while (true)
            {
                try
                {
                    if (Globals.MachineMode == MachineModeType.CPKGRR)
                    {
                        Label_CPK.Visible = true;
                        Invoker.SetCtltxt(Label_CPK, "CPK：" + System.Convert.ToString(PVar.CPKDoneCounts) + "/32");
                    }
                    if (Globals.settingMachineInfo.什么机器 == WhichMachine.IPDM)
                    {
                        Invoker.SetCtl_BckColor(this.CCD_Status, Globals.TCPIP_CCD1.IsOn ? Color.LimeGreen : Mycolor.Red);
                        Invoker.SetCtl_BckColor(this.Scanner_Status, Globals.TCPIP_Scanner.IsOn ? Color.LimeGreen : Mycolor.Red);      
                    }
                    Invoker.SetCtl_BckColor(this.btn_SSHsts, Globals.SSHconnSt ? Color.LimeGreen : Color.Red);
                    Invoker.SetCtl_BckColor(this.Btn_EMG, btn_EMG_Sta ? Mycolor.Red : Color.LimeGreen);
                    //CT
                    Invoker.SetCtltxt(this.Cycle, ((XTaskManager.Instance.FindTaskById((int)TasksId.Manchine).ElapsedMilliseconds) / 1000).ToString("f1") + "S");
                    Invoker.SetCtltxt(this.Product_Num, DataManager.Instance.currentyield.CurrentTotal.ToString());
                    FunctionSub.LightStatus(); //指示灯刷新
                    //Alarm
                    AlarmReport();//

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                Application.DoEvents();
                Thread.Sleep(200);
            }

        }
        #endregion

        #region private surpport

        /// <summary>
        /// wordmode show
        /// </summary>
        private void Instance_ShowDemoMode()
        {
            if (Globals.settingFunc.启用空跑模式)
            {
                this.Label_CPK.Visible = false;
                this.Label_WorkMode.Visible = true;
                this.Label_WorkMode.Text = "空跑模式";
            }
            else
            {
                if (Globals.settingFunc.启用CPK模式)
                {
                    this.Label_CPK.Visible = true;
                    this.Label_WorkMode.Visible = true;
                    this.Label_WorkMode.Text = "CPK/GRR模式";
                }
                else
                {
                    this.Label_CPK.Visible = false;
                    this.Label_WorkMode.Visible = false;
                }
            }     
        }
        LDPF CurtionLDPF = new LDPF();
        /// <summary>
        /// safe door /axis alarm
        /// </summary>
        private void AlarmReport()
        {
            #region 急停
            Globals.Invoker.SetCtl_BckColor(this.Btn_EMG, Gg.GetDi(0, Gg.InPutMMS0.紧急停止) == 1 ? Mycolor.Red : Color.LimeGreen);
            if (EmgSt.Bool_LDP(Gg.GetDi(0, Gg.InPutMMS0.紧急停止) == 1))
            {
                EMG();
                if (ShowList != null) ShowList("紧急停止按下！");
            }
            EmgSt.Update(Gg.GetDi(0, Gg.InPutMMS0.紧急停止) == 1);
            if (EmgSt.PLF)
            {
                //PVar.LampStatus = 50;
                Globals.addList("紧急停止松开！", Mycolor.Red);
            }
            #endregion

            #region 实时扫描 安全门 等
            Globals.Invoker.SetCtl_BckColor(this.CurtionSts, Gg.GetDi(0, Gg.InPutMMS0.安全光幕) == 1 ? Mycolor.Red : Color.LimeGreen);
            Globals.Invoker.SetCtl_BckColor(this.AirSts, Gg.GetDi(0, Gg.InPutMMS0.正气源感应表) == 1 ? Color.LimeGreen : Mycolor.Red);
            if (Globals.settingFunc.打开安全门 && PVar.Stop_Flag == false && PVar.MacHold == false && PVar.AutoRunFlag)
            {
                string tempStr = "";
                string tempStr1 = "";
                if (Gg.GetDi(0, Gg.InPutMMS0.后安全门感应器) == 0)
                {
                    tempStr = "后安全门";
                }
                if (Gg.GetDi(0, Gg.InPutMMS0.左安全门感应器) == 0)
                {
                    tempStr = "左安全门";
                }
                if (Gg.GetDi(0, Gg.InPutMMS0.右安全门感应器) == 0)
                {
                    tempStr = "右安全门";
                }
                if (!string.IsNullOrEmpty(tempStr))
                {
                    PVar.MacHold = true;
                    PVar.Stop_Flag = false;
                    if (ShowList != null) ShowList("请关闭" + tempStr);
                    if (PauseClick != null) PauseClick(true);
                    PVar.LampStatus = 20;
                }
                if (CurtionLDPF.Bool_LDP( Gg.GetDi(0, Gg.InPutMMS0.安全光幕) == 1))
                {
                    tempStr1 = "光栅触发！";
                }
                if (!string.IsNullOrEmpty(tempStr1))
                {
                    PVar.MacHold = true;
                    PVar.Stop_Flag = false;
                    Globals.addList(tempStr1, Mycolor.ErrorRed);
                    if (ShowList != null) ShowList(tempStr1);
                    if (PauseClick != null) PauseClick(true);
                    PVar.LampStatus = 20;
                }
                //this.SafeDoorSts.Checked = string.IsNullOrEmpty(tempStr);
                this.CurtionSts.BackColor=string.IsNullOrEmpty(tempStr1) ? Mycolor.LimeGreen : Color.Red;
                this.AirSts.BackColor = (Gg.GetDi(0, Gg.InPutMMS0.正气源感应表) == 1) ? Mycolor.LimeGreen : Color.Red;
            }

            #endregion

            #region 轴报警

            if(Gg.Get_AlarmDi(0,Gg.InAlarmMMS0.测试Y轴)==1)
                Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.Y伺服电机驱动器报警, AlarmCategory.SYSTEM.ToString(), "Y伺服电机驱动器报警");
            if (Gg.GetLimitDi_F(0, (short)Gg.InAlarmMMS0.测试Y轴) == 1 && GoHome.Instance.Reset.Result)
                Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.Y伺服电机驱动器报警, AlarmCategory.SYSTEM.ToString(), "Y伺服电机负极限报警");
            if (Gg.GetLimitDi_Z(0, (short)Gg.InAlarmMMS0.测试Y轴) == 1 && GoHome.Instance.Reset.Result)
                Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.Y伺服电机驱动器报警, AlarmCategory.SYSTEM.ToString(), "Y伺服电机正极限报警");
            #endregion
        }

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageEngineering)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageEngineering)); }
        }

        #region status线程
        private Thread _thread_Status;
        private void _threadStart()
        {
            _threadStop();
            _thread_Status = new Thread(new ThreadStart(StatusFresh));
            _thread_Status.IsBackground = true;
            _thread_Status.Start();
        }

        private void _threadStop()
        {
            if (_thread_Status != null)
            {
                _thread_Status.Abort();
            }
        }
        #endregion


        #endregion

    }
}

