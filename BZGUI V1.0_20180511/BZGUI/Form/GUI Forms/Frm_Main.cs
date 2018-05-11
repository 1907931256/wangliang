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

namespace BZGUI
{
    public partial class Frm_Main
    {
        #region 变量定义

        public static event Action<string> ShowList;   // this.Dialog_OnAdd(s)
        public static event Action<string> AddList;    // this.Dialog_OnAdd(s) 
        public static Frm_Main fMain = new Frm_Main();
        public static Color MainColor;
        public Color Main_Color
        {
            set { MainColor = value; }
            get { return MainColor = this.BackColor; }
        }

        #endregion

        #region 窗体操作

        public Frm_Main()
        {
            InitializeComponent();
            Frm_load = new System.Timers.Timer() { AutoReset = true, Interval = 100, Enabled = false };
            fMain = this;
        }

        private string ActiveFrmNme;
        bool Temp;
        internal System.Timers.Timer Frm_load;

        #region 功能：窗体加载和卸载

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(1024, 730);
            this.BackColor = Color.White;
            Main_Color = Color.White;

            //检查执行参数文件夹
            System.IO.DirectoryInfo SFile = new System.IO.DirectoryInfo(PVar.BZ_ParameterPath);
            CheckForIllegalCrossThreadCalls = false;
            if (!SFile.Exists)
            {
                if (Interaction.MsgBox("参数文件不存在，程序拒绝加载，请查看路径：" + "\r\n" + PVar.BZ_ParameterPath + "\r\n" + "执行函数Main_Load()", Constants.vbExclamation, "重要参数文件") == Constants.vbOK)
                {
                    //ProjectData.EndApp();
                }
            }
            PVar.ChildFrmOffsetPoint = new Point(2, 68); //定义其他窗口的位置
            Frm_load.Elapsed += new System.Timers.ElapsedEventHandler(Frm_load_Elapsed);
            Frm_load.Enabled = true;
        }

        #endregion

        private void Frm_load_Elapsed(object sender, EventArgs e)
        {
            Frm_load.Enabled = false;
            try
            { this.BeginInvoke(new Action(() => { Frm_load_Tick(); })); }
            catch (Exception)
            { }
        }

        private void Frm_Main_Disposed()
        {
            Close_TCP();
            FunctionSub.Close_Serial1();
            FunctionSub.Close_Serial2();
            FunctionSub.Close_Serial3();
        }

        private void Frm_load_Tick()
        {
            Frm_LoadProcess.Ex = "正在加载参数配置文件...    10%";
            Application.DoEvents();
            PVar.ReDimSpassWord(); //定义用户
            Frm_Engineering.fEngineering.DataGridView_par.RowCount = 12;
            ArrayInit(); //数组重新定义
            for (short i = 0; i <= 99; i++)
            {
                PVar.BarcodeArrayList[i] = BVar.FileRorW.ReadINI((i).ToString(), "SN", "", PVar.ListDataIniPath);
            }
            Frm_Engineering.ReadParAxis(PVar.ParAxisPath, PVar.ParAxis);//读取机械参数
            Frm_Par FrmPar = new BZGUI.Frm_Par();
            Frm_Parameter FrmParameter = new Frm_Parameter();
            FrmPar.Par_Normal("Read"); //加载参数界面参数
            if (!PVar.IsReadParData)
            {
                if (Interaction.MsgBox("ReadParData()函数读取数据失败，程序拒绝加载！", Constants.vbExclamation, "重要参数文件") == Constants.vbOK)
                {
                    ProjectData.EndApp();
                }
            }

            mFunction.ReDimData();
            mFunction.ReadPosData(PVar.BZ_ParameterPath + "\\PosData.dat", mFunction.Pos);
            if (!PVar.IsReadPosData)
            {
                if (Interaction.MsgBox("ReadPosData()函数读取数据失败，程序拒绝加载！", Constants.vbExclamation, "重要参数文件") == Constants.vbOK)
                {
                    ProjectData.EndApp();
                }
            }

            Frm_LoadProcess.Ex = "正在初始化工程界面...    70%";
            Application.DoEvents();
            MainUserNameDisplay(); //新用户添加到主界面
            if (MainUserName.Items.Count <= 0)
            {
                PVar.Login.NewGroup[1] = "Engineering";
                PVar.Login.NewUser[0] = "Engineering";
                PVar.Login.NewPassword[0] = "BZ";
                PVar.Login.NewUserAuthority[0] = 2;
                MainUserName.Items.Add(PVar.Login.NewUser[0]);
                Frm_Login.fLogin.MainUserName.Items.Add(PVar.Login.NewUser[0]);
                FileRw.WriteDatFilePassWord(PVar.BZ_ParameterPath + "PassWord.dat", PVar.Login);
            }
            PVar.LampStatus = 10;
            Btn_Stop.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
            Frm_Engineering.fEngineering.Show(this);
            Frm_Engineering.fEngineering.Visible = false;
            Frm_Production FrmProduction = new Frm_Production();
            FrmProduction.Show(this);
            Frm_Production.fProduction.Visible = false;
            Btn_Pause.Enabled = false;
            Btn_Stop.Enabled = false;
            PVar.IsOpenFrmEngineering = false;
            PVar.IsOpenFrmProduction = false;
            Frm_Engineering.fEngineering.TestDataGridInit(); //加载表格数据
            Frm_LoadProcess.Ex = "正在初始化运动控制卡...    95%";
            Application.DoEvents();
            Gg.GTS_MotionInit(0, 8, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\GTS_Config\\GTS800-00.cfg");

            Gg.GTS_MotionInit(1, 4, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\GTS_Config\\GTS400-01.cfg");

            Gg.GTS_ExtmdlInit(2, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\GTS_Config\\ExtModule.cfg");
            Command.Com3_Send("LMD,4SPLN,00" + ",000,000,000,000,"); //关闭所有光源
            if (PVar.IsCOM3_Working == false)
            {
                AddList("光源控制器通信异常！");
                ShowList("光源控制器通信异常！");
            }
            else
            {
                AddList("光源控制器通信OK！");
            }
            Frm_LoadProcess.Ex = "加载完成...    100%";
            Application.DoEvents();
            PVar.WorkMode = 0;
            //WriteCsvErrorCodePRE();
            this.Show();
        }

        private void WriteCsvErrorCodePRE()
        {
            Thread WriteCsvErrorCodePREThread;
            WriteCsvErrorCodePREThread = new Thread(Mod_ErrorCode.WriteCsvErrorCodePRE_Thread);
            WriteCsvErrorCodePREThread.IsBackground = true;
            WriteCsvErrorCodePREThread.Start();
            WriteCsvErrorCodePREThread.Priority = ThreadPriority.Lowest;
        }
        #endregion

        #region 功能：新用户添加到主界面
        private void MainUserNameDisplay()
        {
            FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "PassWord.dat", PVar.Login);
            for (var i = 0; i <= 20; i++)
            {
                if (PVar.Login.NewUser[i] != "" && PVar.Login.NewUser[i] != null)
                {
                    MainUserName.Items.Add(PVar.Login.NewUser[(int)i]);

                    if (Frm_Login.fLogin == null || Frm_Login.fLogin.IsDisposed)
                    {
                        Frm_Login.fLogin = new Frm_Login();
                    }
                    Frm_Login.fLogin.MainUserName.Items.Add(PVar.Login.NewUser[(int)i]);
                }
            }
            if (MainUserName.Items.Count > 0)
            {
                MainUserName.SelectedIndex = 0;
            }
        }
        #endregion

        #region 功能：UI界面操作
        private void InitLoginDialog()
        {
            Btn_Login.Enabled = true;
            MainUserName.Enabled = true;
            MainPassword.Enabled = true;
            MainUserName.BackColor = Color.White;
            if (MainUserName.Items.Count > 0)
            { MainUserName.SelectedIndex = 0; }
            MainPassword.BackColor = Color.White;
            MainPassword.Focus();
            Btn_Login.BackColor = Color.FromArgb(253, 253, 191);
        }

        private void RestoreLoginDialog()
        {
            MainPassword.BackColor = Color.White;
            Btn_Login.Enabled = false;
            MainPassword.BackColor = PVar.BZColor_UnselectedBtn;
            Btn_Login.BackColor = PVar.BZColor_UnselectedBtn;
            MainUserName.BackColor = PVar.BZColor_UnselectedBtn;
            MainPassword.Text = "";
        }

        private dynamic IsNotShow(string frmName)
        {
            dynamic returnValue = default(dynamic);
            if (Application.OpenForms[frmName] == null)
            { returnValue = true; }
            else
            { returnValue = false; }
            ActiveFrmNme = frmName;
            foreach (Form Fr in Application.OpenForms)
            {
                if (Fr.Name != ActiveFrmNme && Fr.Name != "Frm_Main" && Fr.Name != "Frm_Login" && Fr.Name != "Frm_Dialog")
                {
                    if (Fr.Name == "Frm_Engineering")
                    { PVar.IsSysOnEngineerMode = false; }
                    if (Fr.Name == "Frm_RunInfo" || Fr.Name == "Frm_AlarmInfo" || Fr.Name == "Frm_MachineInfo" || Fr.Name == "Frm_Par" || Fr.Name == "Frm_Par_CCD" || Fr.Name == "Frm_Parameter" || Fr.Name == "Frm_Laser")
                    {
                        Fr.Close();
                        break;
                    }
                    else if (Fr.Name == "Frm_Engineering")
                    {
                        PVar.IsOpenFrmEngineering = false;
                        Frm_Engineering.fEngineering.Visible = false;
                    }
                    else if (Fr.Name == "Frm_Production")
                    {
                        Frm_Production.fProduction.Visible = false;
                        PVar.IsOpenFrmProduction = false;
                    }
                }
            }
            return returnValue;
        }

        private void LoadFormAndSetBtBkColor(BoTech.Button bt)
        {
            this.BackColor = Color.White;
            Btn_Production.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Btn_ParSetting.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Btn_CCDSetting.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Btn_RunInfo.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Btn_AlarmHistory.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Btn_MachineInfo.BZ_BackColor = PVar.BZColor_UnselectedBtn;

            Btn_OpenDataFile.BZ_BackColor = Color.White;
            Btn_OpenCCDFile.BZ_BackColor = Color.White;
            Btn_Home.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            bt.BZ_BackColor = PVar.BZColor_SelectedBtn;

            switch (bt.Name)
            {
                case "Btn_Production":
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (PVar.IsOpenFrmProduction == false)
                    {
                        PVar.IsOpenFrmProduction = true;
                        Frm_Production.fProduction.Show(this);
                        Frm_Production.fProduction.Visible = true;
                    }

                    if (bt.Name == "Btn_ProductionMode")
                    {
                        Btn_ProductionMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
                        Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                    }
                    break;
                case "Btn_ProductionMode":

                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (PVar.IsOpenFrmProduction == false)
                    {
                        PVar.IsOpenFrmProduction = true;
                        Frm_Production.fProduction.Show(this);
                        Frm_Production.fProduction.Visible = true;
                    }

                    if (bt.Name == "Btn_ProductionMode")
                    {
                        Btn_ProductionMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
                        Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                    }
                    break;
                case "Btn_RunInfo":
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (IsNotShow("Frm_RunInfo"))
                    {
                        if (Frm_RunInfo.fRunInfo == null || Frm_RunInfo.fRunInfo.IsDisposed)
                        {
                            Frm_RunInfo.fRunInfo = new Frm_RunInfo();
                        }
                        Frm_RunInfo.fRunInfo.Show(this);
                    }
                    break;
                case "Btn_AlarmHistory":
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (IsNotShow("Frm_AlarmInfo"))
                    {
                        if (Frm_AlarmInfo.fAlarmInfo == null || Frm_AlarmInfo.fAlarmInfo.IsDisposed)
                        {
                            Frm_AlarmInfo.fAlarmInfo = new Frm_AlarmInfo();
                        }
                        Frm_AlarmInfo.fAlarmInfo.Show(this);
                    }
                    break;
                case "Btn_MachineInfo":
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (IsNotShow("Frm_MachineInfo"))
                    {
                        if (Frm_MachineInfo.fMachineInfo == null || Frm_MachineInfo.fMachineInfo.IsDisposed)
                        {
                            Frm_MachineInfo.fMachineInfo = new Frm_MachineInfo();
                        }
                        Frm_MachineInfo.fMachineInfo.Show(this);
                    }
                    break;

                case "Btn_EngneeringMode":
                    InitLoginDialog();
                    PVar.sOpenTargetForm = "Frm_Engineering";
                    if (bt.Name == "Btn_EngneeringMode")
                    {
                        Btn_ProductionMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
                        Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        this.BackColor = Color.FromArgb(252, 223, 222);
                        Btn_OpenDataFile.BZ_BackColor = Color.FromArgb(252, 223, 222);
                        Btn_OpenCCDFile.BZ_BackColor = Color.FromArgb(252, 223, 222);
                        Btn_Home.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    }
                    break;

                case "Btn_CPKMode":
                    InitLoginDialog();
                    PVar.sOpenTargetForm = "Frm_Engineering";

                    if (bt.Name == "Btn_EngneeringMode" || bt.Name == "Btn_Engineering")
                    {
                        Btn_ProductionMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
                        Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        this.BackColor = Color.FromArgb(252, 223, 222);
                        Btn_OpenDataFile.BZ_BackColor = Color.FromArgb(252, 223, 222);
                        Btn_OpenCCDFile.BZ_BackColor = Color.FromArgb(252, 223, 222);
                        Btn_Home.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    }
                    if (bt.Name == "Btn_CPKMode")
                    {
                        Btn_ProductionMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                        Btn_CPKMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (PVar.WorkMode == 0)
                            {
                                if (Interaction.MsgBox("请确认是否进入CPK模式？", (int)Constants.vbInformation + Constants.vbYesNo, "CPK信息") == Constants.vbYes)
                                {
                                    Frm_Par.fPar.Par_Clear();
                                    Panel_CPK.Visible = true;
                                    PVar.WorkMode = 1;
                                    FileLog.OperateLog("进入CPK模式");
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                    }
                    break;
                case "Btn_ParSetting":
                    Frm_Login.fLogin.ShowDialog();
                    if (Temp)
                    {
                        Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                        Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                        Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                        Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                        Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                        if (PVar.MacHold || PVar.Stop_Flag)
                        {
                            if (IsNotShow("Frm_Parameter"))
                            {
                                if (Frm_Parameter.fPar == null || Frm_Parameter.fPar.IsDisposed)
                                {
                                    Frm_Parameter.fPar = new Frm_Parameter();
                                }
                                Frm_Parameter.fPar.Show(this);
                            }
                        }
                        else
                        {
                            ShowList("设备运行中,请先暂停设备！");
                            Btn_OpenDataFile.BZ_BackColor = Color.White;
                            return;
                        }
                    }
                    break;
                case "Btn_CCDSetting":
                    //Frm_Login.fLogin.ShowDialog();
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (PVar.MacHold == true || PVar.Stop_Flag)
                    {
                        if (Temp)
                        {
                            if (IsNotShow("Frm_Par_CCD"))
                            {
                                //if (Frm_Par_CCD.fPar_CCD == null || Frm_Par_CCD.fPar_CCD.IsDisposed)
                                //{
                                //    Frm_Par_CCD.fPar_CCD = new Frm_Par_CCD();
                                //}
                                //Frm_Par_CCD.fPar_CCD.Show(this);
                                if (Frm_Laser.fPar_Laser == null || Frm_Laser.fPar_Laser.IsDisposed)
                                {
                                    Frm_Laser.fPar_Laser = new Frm_Laser();
                                }
                                Frm_Laser.fPar_Laser.Show(this);
                            }
                        }
                        else
                            return;
                    }
                    else
                    {
                        ShowList("设备运行中,请先暂停设备！");
                        Btn_OpenDataFile.BZ_BackColor = Color.White;
                        return;
                    }
                    break;
                case "Btn_Home":
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl2.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl3.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl4.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.TabControl5.SelectedIndex = 0;
                    if (IsNotShow("Frm_Main"))
                    { }
                    Btn_ProductionMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                    Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                    Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
                    break;
                case "Btn_OpenCCDFile":
                    if (System.IO.File.Exists(PVar.BZ_CCD_ImagePath) == false)
                    {
                        System.IO.Directory.CreateDirectory(PVar.BZ_CCD_ImagePath);
                    }
                    System.IO.DirectoryInfo SFile = new System.IO.DirectoryInfo(PVar.BZ_CCD_ImagePath);
                    if (SFile.Exists)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("explorer.exe", PVar.BZ_CCD_ImagePath);
                        }
                        catch { }
                    }
                    else
                    {
                    }
                    break;

                case "Btn_OpenDataFile":
                    System.IO.DirectoryInfo SFinal_D = new System.IO.DirectoryInfo("E:\\BZ-Data\\BAM\\CheckData\\" + DateTime.Now.ToString("yyyyMM"));
                    if (System.IO.File.Exists("E:\\BZ-Data\\BAM\\CheckData\\" + DateTime.Now.ToString("yyyyMM")) == false)
                    {
                        System.IO.Directory.CreateDirectory("E:\\BZ-Data\\BAM\\CheckData\\" + DateTime.Now.ToString("yyyyMM"));
                    }

                    if (SFinal_D.Exists)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("explorer.exe", "E:\\BZ-Data\\BAM\\CheckData\\" + DateTime.Now.ToString("yyyyMM"));
                        }
                        catch { }
                    }
                    else
                    {

                    }
                    break;
            }
        }

        //总入口
        private void Btn_Production_Click(object sender, EventArgs e)
        {
            BoTech.Button btn = sender as BoTech.Button;
            FunctionSub.Close_Key_Process();
            LoadFormAndSetBtBkColor(btn);
        }

        private void Btn_OpenDataFile_Click(object sender, EventArgs e)
        {
            Btn_Production_Click(sender, null);
        }

        private void Btn_OpenCCDFile_Click(object sender, EventArgs e)
        {
            Btn_Production_Click(sender, null);
        }

        private void btn_ExitCPK_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("请确认是否【退出】CPK模式？", (int)Constants.vbInformation + Constants.vbYesNo, "CPK信息") == Constants.vbYes)
            {
                PVar.CPKDoneCounts = 0;
                PVar.WorkMode = 0;
                Panel_CPK.Visible = false;
                FileLog.OperateLog("退出CPK模式");
            }
        }

        private void Btn_ProductionMode_Click(object sender, EventArgs e)
        {
            sender = Btn_Production;
            Btn_Production_Click(sender, null);
            Btn_ProductionMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
            Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
            Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
        }

        private void Btn_EngneeringMode_Click(object sender, EventArgs e)
        {
            Btn_Production_Click(sender, null);
            Btn_ProductionMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
            Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
            Btn_CPKMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
        }

        private void Btn_CPKMode_Click(object sender, EventArgs e)
        {
            Btn_Production_Click(sender, null);
            Btn_ProductionMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
            Btn_EngneeringMode.BZ_BackColor = Color.FromArgb(200, 200, 200);
            Btn_CPKMode.BZ_BackColor = Color.FromArgb(179, 202, 255);
        }

        #endregion

        #region 功能：主界面退出按钮

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真的要退出本系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                return;

            for (short i = 1; i <= 9; i++)
            {
                PVar.Rtn = gts.GT_ClrSts(Convert.ToInt16((i - 1) / 8), Convert.ToInt16(i % 9 + (i - 1) / 8), (short)1); //清除轴的报警标志
                PVar.Rtn = gts.GT_AxisOff(Convert.ToInt16((i - 1) / 8), Convert.ToInt16(i % 9 + (i - 1) / 8)); //关闭轴的伺服使能
            }

            for (short j = 0; j <= 15; j++)
            {
                PVar.Rtn = gts.GT_SetExtIoBitGts(0, 0, j, 1);
            }
            Frm_Main_Disposed();
            gts.GT_ResetExtMdlGts(0);
            gts.GT_CloseExtMdlGts(0);
            gts.GT_Reset(0);
            gts.GT_Reset(1);
            gts.GT_Close(0);
            gts.GT_Close(1);
            Application.Exit();
            ProjectData.EndApp();
        }
        #endregion

        #region 功能：主界面密码登陆

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Temp = false;
            UserLogin();
            if (Temp == true)
            {
                switch (PVar.sOpenTargetForm)
                {
                    case "Frm_Engineering":
                        if (PVar.IsOpenFrmEngineering == false && PVar.LoginFrmEngineeringEnable)
                        {
                            FunctionSub.Close_NumberKey_Process();
                            Frm_Engineering.fEngineering.Show(this);
                            PVar.IsOpenFrmEngineering = true;
                            this.BackColor = Color.White;
                            Btn_Home.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                            Btn_OpenDataFile.BZ_BackColor = Color.White;
                            Btn_OpenCCDFile.BZ_BackColor = Color.White;
                            PVar.LoginFrmEngineeringEnable = false;
                            PVar.LoginFrmParEnable = false;
                            PVar.LoginFrmParCCDEnable = false;
                            PVar.LoginOutputEnable = false;
                            PVar.LoginManualEnable = false;
                            PVar.LoginMachineParEnable = false;
                            RestoreLoginDialog();
                        }
                        break;
                }
            }
            Temp = false;
        }

        public void UserLogin()
        {
            int i = 0;
            FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "PassWord.dat", PVar.Login);
            for (i = 0; i <= MainUserName.Items.Count - 1; i++)
            {
                #region IsOpenFrmLogin true
                if (PVar.IsOpenFrmLogin)
                {
                    if (PVar.sOpenTargetForm == "Frm_Engineering" && MainUserName.Text == PVar.Login.NewUser[i] && PVar.Login.NewUserAuthority[i] == 3)
                    {
                        Interaction.MsgBox("该用户无权限，请重新选择用户！", Constants.vbOKOnly, "提示");
                        return;
                    }
                    if ((Frm_Login.fLogin.MainUserName.Text == PVar.Login.NewUser[i] && Frm_Login.fLogin.MainPassword.Text == PVar.Login.NewPassword[i] && Convert.ToString(Frm_Login.fLogin.MainUserName.Items[i]) != "") && (PVar.Login.NewUserAuthority[i] == 1 || PVar.Login.NewUserAuthority[i] == 2 || PVar.Login.NewUserAuthority[i] == 3))
                    {
                        if (PVar.Login.NewGroup[0] == "Post Safe" && PVar.Login.NewUserAuthority[i] == 1)
                        {
                            Temp = true;
                            PVar.isShowAxisPara = false;
                            break;
                        }
                        if (PVar.Login.NewGroup[1] == "Engineering" && PVar.Login.NewUserAuthority[i] == 2)
                        {
                            Temp = true;
                            PVar.isShowAxisPara = true;
                            break;
                        }
                        if (PVar.Login.NewGroup[2] == "FE2" && PVar.Login.NewUserAuthority[i] == 3)
                        {
                            Temp = true;
                            PVar.isShowAxisPara = false;
                            break;
                        }
                    }
                    else
                    {
                        Temp = false;
                    }
                }
                #endregion
                #region isOpenFrmlogion false
                else
                {
                    if (PVar.sOpenTargetForm == "Frm_Engineering" && MainUserName.Text == PVar.Login.NewUser[i] && PVar.Login.NewUserAuthority[i] == 3)
                    {
                        Interaction.MsgBox("该用户无权限，请重新选择用户！", Constants.vbOKOnly, "提示");
                        return;
                    }
                    if ((MainUserName.Text == PVar.Login.NewUser[i] && MainPassword.Text == PVar.Login.NewPassword[i] && Convert.ToString(MainUserName.Items[i]) != "") && (PVar.Login.NewUserAuthority[i] == 0 || PVar.Login.NewUserAuthority[i] == 1 || PVar.Login.NewUserAuthority[i] == 2 || PVar.Login.NewUserAuthority[i] == 3))
                    {
                        if (PVar.Login.NewGroup[0] == "Post Safe" && PVar.Login.NewUserAuthority[i] == 1)
                        {
                            Temp = true;
                            break;
                        }
                        if (PVar.Login.NewGroup[1] == "Engineering" && PVar.Login.NewUserAuthority[i] == 2)
                        {
                            Temp = true;
                            break;
                        }
                        if (PVar.Login.NewGroup[2] == "FE2" && PVar.Login.NewUserAuthority[i] == 3)
                        {
                            Temp = true;
                            break;
                        }
                        else
                        {
                            Temp = true;
                            break;
                        }
                    }
                    else
                    {
                        Temp = false;
                    }
                }
                #endregion
            }
            #region password OK
            if (Temp == true)
            {
                if (PVar.Login.NewUserAuthority[i] == 1) //Post Safe
                {
                    PVar.LoginFrmEngineeringEnable = true;
                    PVar.LoginFrmParEnable = true;
                    PVar.LoginFrmParCCDEnable = true;
                    PVar.LoginMachineParEnable = true;
                    PVar.LoginOutputEnable = true;
                    PVar.LoginManualEnable = true;
                }
                if (PVar.Login.NewUserAuthority[i] == 2) //Engineering
                {
                    PVar.LoginFrmEngineeringEnable = true;
                    PVar.LoginFrmParEnable = true;
                    PVar.LoginFrmParCCDEnable = true;
                    PVar.LoginOutputEnable = true;
                    PVar.LoginMachineParEnable = true;
                    PVar.LoginManualEnable = true;
                }
                if (PVar.Login.NewUserAuthority[i] == 3) //FE2
                {
                    PVar.LoginFrmEngineeringEnable = false;
                    PVar.LoginFrmParEnable = false;
                    PVar.LoginOutputEnable = true;
                }
                FunctionSub.Close_NumberKey_Process();
                //Temp = False
            }
            #endregion
            #region password err
            else
            {
                PVar.LoginFrmEngineeringEnable = false;
                PVar.LoginFrmParEnable = false;
                PVar.LoginFrmParCCDEnable = false;
                PVar.LoginOutputEnable = false;
                PVar.LoginManualEnable = false;
                PVar.LoginMachineParEnable = false;
                if (Interaction.MsgBox("密码输入错误，请重新输入！", Constants.vbOKOnly, "提示") == Constants.vbOK)
                {
                    if (PVar.IsOpenFrmLogin)
                    {
                        Frm_Login.fLogin.MainPassword.Text = "";
                        Frm_Login.fLogin.MainPassword.Focus();
                    }
                    else
                    {
                        this.MainPassword.Text = "";
                        this.MainPassword.Focus();
                    }
                    return;
                }
            }
            #endregion
        }

        private void MainUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            MainUserName.Text = PVar.Login.NewUser[1];
            MainPassword.Text = PVar.Login.NewPassword[1];
        }

        private void MainPassword_DoubleClick(object sender, EventArgs e)
        {
            FunctionSub.Start_NumberKey_Process();
        }

        private void MainPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Constants.vbCr))
            {
                Btn_Login_Click(sender, e);
            }
        }

        #endregion

        #region 功能：整机开始

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (GoHome.Instance.Reset.Result == false && PVar.IsLoadFrmEngineering == true)
            {
                if (Interaction.MsgBox("确定【是否初始化】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【初始化】") == Constants.vbCancel)
                    return;
                FileLog.OperateLog("初始化");
                Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                Frm_Engineering.fEngineering.MacReset();
            }
            else if (GoHome.Instance.Reset.Result == true && PVar.IsLoadFrmEngineering == true)
            {
                if (PVar.AutoRunFlag == false)
                {
                    if (Interaction.MsgBox("确定【是否自动运行】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【自动运行】") == Constants.vbCancel)
                        return;
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
                    Frm_Engineering.fEngineering.Auto_Assemble();
                    FileLog.OperateLog("自动运行");
                }
                else
                { }
            }
        }

        #endregion

        #region 功能：整机暂停

        public void Btn_Pause_Click(object sender, EventArgs e)
        {
            if (GoHome.Instance.Reset.Result == true)
            {
                if (PVar.AutoRunFlag)
                {
                    if (PVar.MacHold == true)
                    {
                        if (Interaction.MsgBox("确定【继续运行】吗？", (int)Constants.vbInformation + Constants.vbOKCancel, "【继续运行】") == Constants.vbCancel)
                            return;
                        PVar.IsSystemOnPauseMode = false;
                        AddList("暂停运行已解除");
                        ContinuRun(); //继续运行
                        FileLog.OperateLog("继续运行");
                    }
                    else
                    {
                        AddList("设备已暂停");
                        PVar.IsSystemOnPauseMode = true;
                        StopRun(); //暂停运行
                        FileLog.OperateLog("暂停运行");
                    }
                }
                else
                {
                    Btn_Pause.Enabled = false;
                }
            }
        }

        public void ContinuRun() //继续运行
        {
            PVar.MacHold = false;
            Btn_Stop.Enabled = true;
            for (var i = 1; i <= 5; i++)
            {
                PVar.TimeStart[(int)i] = System.Convert.ToInt64(API.GetTickCount());
            }
            Frm_Engineering.fEngineering.TabPage3.Parent = null; //隐藏IO输出
            Frm_Engineering.fEngineering.TabPage4.Parent = null; //隐藏手动界面
            //按钮
            //Btn_Start.Enabled = False
            Btn_Pause.Enabled = true;
            //Btn_Stop.Enabled = True
            Btn_Start.BZ_BackColor = PVar.BZColor_SelectedBtn; //主页面初始化和自动运行按钮
            Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            //Btn_Stop.BZ_BackColor = BZColor_UnselectedBtn
            Frm_Engineering.fEngineering.Auto_Timer.Enabled = true;
            PVar.LampStatus = 30;
        }

        public void StopRun() //暂停运行
        {
            PVar.MacHold = true;
            PVar.Stop_Flag = false;
            //按钮
            Btn_Start.Enabled = false;
            Btn_Pause.Enabled = true;
            Btn_Stop.Enabled = false;
            Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn; //主页面初始化和自动运行按钮
            Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
            Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;
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
                AddList("设备处于暂停中...");
                return;
            }
            if (PVar.AutoRunFlag)
            {
                PVar.AutoRunFlag = false;
                PVar.Stop_Flag = true;
                Frm_Engineering.fEngineering.TabPage3.Parent = Frm_Engineering.fEngineering.TabControl1;
                Frm_Engineering.fEngineering.TabPage4.Parent = Frm_Engineering.fEngineering.TabControl1;
                //按钮
                Btn_Start.Enabled = true;
                //Btn_Pause.Enabled = True
                Btn_Stop.Enabled = true;
                Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn; //主页面初始化和自动运行按钮
                //Btn_Pause.BZ_BackColor = BZColor_UnselectedBtn
                Btn_Stop.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                PVar.LampStatus = 20;
            }
            else
            {
                AddList("设备没有自动运行");
            }
        }

        #endregion

        #region 重新定义数组的长度
        private void ArrayInit()
        {
            //ReDim BarcodeArrayList(99)
        }
        #endregion

        #region 关闭网络
        private void Close_TCP()
        {
            try
            {
                Frm_Engineering.fEngineering.Tcp_CCD1.StopConnect();
                Frm_Engineering.fEngineering.Tcp_CCD2.StopConnect();
                Frm_Engineering.fEngineering.Tcp_HeatBt.StopConnect();
                Frm_Engineering.fEngineering.Tcp_PDCA.StopConnect();
                Frm_Engineering.fEngineering.Tcp_Robot.StopConnect();
            }
            catch (Exception)
            { }
        }
        #endregion

    }
}
