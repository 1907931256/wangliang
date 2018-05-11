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
using System.Threading;
using Microsoft.VisualBasic.PowerPacks;
using System.IO;
using System.IO.Ports;
using System.Text;
using SocketHelper.TCP;
using System.Windows.Forms.DataVisualization.Charting;

namespace BZGUI
{
    public partial class Frm_Engineering
    {
        #region 功能：定义
        public static Frm_Engineering fEngineering = new Frm_Engineering();
        public static event Action<string> ShowList;
        public static event Action<string> AddList;
        private object LockConect = new object();
        public int CCD_Product_Flag;
        private double[] Dis_deviate = new double[6];

        //串口定义。
        internal System.IO.Ports.SerialPort SerialPort1 = new System.IO.Ports.SerialPort();
        internal System.IO.Ports.SerialPort SerialPort2 = new System.IO.Ports.SerialPort();
        internal System.IO.Ports.SerialPort SerialPort3 = new System.IO.Ports.SerialPort();

        //定时器定义。 

        internal System.Timers.Timer Conect_Time = new System.Timers.Timer() { AutoReset = true, Interval = 3000, Enabled = false };
        internal System.Timers.Timer CT_Time = new System.Timers.Timer() { AutoReset = false, Interval = 10, Enabled = false };
        internal System.Timers.Timer HeatBt_Time = new System.Timers.Timer() { AutoReset = false, Interval = 10, Enabled = false };
        internal System.Timers.Timer Status_Time = new System.Timers.Timer() { AutoReset = true, Interval = 100, Enabled = false };
        internal System.Windows.Forms.Timer PDCA_Time = new System.Windows.Forms.Timer() { Interval = 100, Enabled = false };
        internal System.Windows.Forms.Timer Alarm_Timer = new System.Windows.Forms.Timer() { Interval = 10, Enabled = false };
        internal System.Windows.Forms.Timer Home_Timer = new System.Windows.Forms.Timer() { Interval = 10, Enabled = false };
        internal System.Windows.Forms.Timer Auto_Timer = new System.Windows.Forms.Timer() { Interval = 1, Enabled = false };
        internal System.Windows.Forms.Timer Timer_Calibration = new System.Windows.Forms.Timer() { Interval = 100, Enabled = false };
        internal System.Windows.Forms.Timer AutoLoadCell_Timer = new System.Windows.Forms.Timer() { Interval = 100, Enabled = false };

        private void Init()
        {
            AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            PDCA.Instance.AddList += ((s) => { this.infoList2.List_OnAdd(s); });
            Gg.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Frm_Main.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            GoHome.Instance.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Sta0Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Sta1Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Sta2Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Sta3Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Sta4Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
        }

        #endregion

        #region 功能：窗体加载

        public Frm_Engineering()
        {
            InitializeComponent();
            fEngineering = this;
            Init();
        }

        private void Frm_Engineering_FormClosed(object sender, FormClosedEventArgs e)
        {
            PVar.IsOpenFrmEngineering = false;
            PVar.IsLoadFrmEngineering = false;
        }

        private void Frm_Engineering_Load(object sender, EventArgs e)
        {
            BVar.AxisAlarm = new UMA_dll.LDPF[17] { BVar.AxisAlarm00, BVar.AxisAlarm01, BVar.AxisAlarm02, BVar.AxisAlarm03, BVar.AxisAlarm04, BVar.AxisAlarm05, BVar.AxisAlarm06, BVar.AxisAlarm07, BVar.AxisAlarm08, BVar.AxisAlarm09, BVar.AxisAlarm10, BVar.AxisAlarm11, BVar.AxisAlarm12, BVar.AxisAlarm13, BVar.AxisAlarm14, BVar.AxisAlarm15, BVar.AxisAlarm16 };
            BVar.EMC_Stop = new UMA_dll.LDPF[2] { BVar.EMC_Stop01, BVar.EMC_Stop02 };
            Label[] tempLab = new Label[4] { this.Label_Sta1, this.Label_Sta4, this.Label_Sta3, this.Label_Sta2 };
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Color.White;
            //TabPage_LightControl.Parent = null; //隐藏光源控制界面
            for (int i = 0; i <= 3; i++)
            {
                tempLab[i].Text = Convert.ToString(BVar.FixtureNum[i + 1]);
            }

            //初始化串口
            FunctionSub.Init_Serial1();
            FunctionSub.Init_Serial2();
            FunctionSub.Init_Serial3();
            LoadParAxis();
            FresshMachinePar();

            Winsock_Init();

            GoHome.Instance.AxisGoHome.State = true;//need home flag?

            PVar.PalletSelectNum = 1;

            Product_Num.Text = System.Convert.ToString(PVar.ProductCounts);

            PVar.Stop_Flag = true;
            PVar.IsOpenFrmEngineering = true;
            PVar.IsLoadFrmEngineering = true;

            Txt_CamDistX.Text = BVar.FileRorW.ReadINI("CamDist", "CamDistX", System.Convert.ToString(17), PVar.BZ_LightSettingPath);
            Txt_CamDistY.Text = BVar.FileRorW.ReadINI("CamDist", "CamDistY", System.Convert.ToString(-142), PVar.BZ_LightSettingPath);
            Text_CaliX.Text = BVar.FileRorW.ReadINI("Center", "CenterX", System.Convert.ToString(0), PVar.BZ_LightSettingPath);
            Text_CaliY.Text = BVar.FileRorW.ReadINI("Center", "CenterY", System.Convert.ToString(0), PVar.BZ_LightSettingPath);
            Frm_Production.ReadCPKFile(PVar.BZ_CPKDataFilePath, PVar.tmpCpkData);
            this.DataGrid_CheckData.Rows.Clear(); //清除工程界面表格数据
            this.Status_Time.Enabled = true;
            this.Conect_Time.Enabled = true;

            //加载定时器时间
            //this.CalibCameraDistance.Click += new System.EventHandler(this.CalibCameraDistance_Click);

            this.Tcp_CCD1.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_CCD1_StateInfo);
            this.Tcp_CCD2.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_CCD2_StateInfo);
            this.Tcp_Robot.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_Robot_StateInfo);
            this.Tcp_HeatBt.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_HeatBt_StateInfo);
            this.Tcp_PDCA.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_PDCA_StateInfo);
            this.Tcp_Barcode.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_Barcode_StateInfo);

            this.Tcp_CCD1.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockCCD1_DataArrival);
            this.Tcp_CCD2.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockCCD2_DataArrival);

            this.Status_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.Status_Time_Elapsed);
            this.Conect_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.Conect_Time_Elapsed);
            this.HeatBt_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.HeatBt_Time_Elapsed);
            this.CT_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.CT_Time_Elapsed);

            this.PDCA_Time.Tick += new System.EventHandler(this.PDCA_Time_Tick);
            this.Alarm_Timer.Tick += new System.EventHandler(this.Alarm_Timer_Tick);
            this.Home_Timer.Tick += new System.EventHandler(this.Home_Timer_Tick);
            this.Auto_Timer.Tick += new System.EventHandler(this.Auto_Timer_Tick);
            this.Timer_Calibration.Tick += new System.EventHandler(this.Timer_Calibration_Tick);
            this.SerialPort1.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            this.SerialPort2.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort2_DataReceived);
            this.SerialPort3.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort3_DataReceived);

            Alarm_Timer.Enabled = true;
        }

        /// <summary>
        /// 界面isShowAxisPara显示否
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Engineering_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && PVar.isShowAxisPara)
            {
                this.TabControl4.TabPages[4].Parent = null;
            }
        }

        #endregion

        #region 功能：网口加载
        private void Winsock_Init()
        {
            try
            {
                //机械手网络
                this.Tcp_Robot.ServerIp = "192.168.2.64"; //设置远程IP
                this.Tcp_Robot.ServerPort = Int16.Parse("10009"); //设置远程port
                this.Tcp_Robot.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //CCD1网络
                this.Tcp_CCD1.ServerIp = "127.0.0.1"; //设置远程IP
                this.Tcp_CCD1.ServerPort = Int16.Parse("5001"); //设置远程port
                this.Tcp_CCD1.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //CCD2网络
                this.Tcp_CCD2.ServerIp = "127.0.0.1"; //设置远程IP
                this.Tcp_CCD2.ServerPort = Int16.Parse("5002"); //设置远程port
                this.Tcp_CCD2.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //Barcode网络
                this.Tcp_Barcode.ServerIp = "192.168.10.55"; //设置远程IP
                this.Tcp_Barcode.ServerPort = Int16.Parse("10000"); //设置远程port
                this.Tcp_Barcode.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //PDCA网络
                Tcp_PDCA.ServerIp = "169.254.0.10"; //设置远程IP
                Tcp_PDCA.ServerPort = Int16.Parse("2941"); //设置远程port
                Tcp_PDCA.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //PDCA网络
                this.Tcp_HeatBt.ServerIp = "169.254.0.10"; //设置远程IP
                this.Tcp_HeatBt.ServerPort = Int16.Parse("2942"); //设置远程port
                this.Tcp_HeatBt.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //网络链接状态
                ///// <summary>
                ///// 正在连接服务端
                ///// </summary>
                //Connecting = 0,

                ///// <summary>
                ///// 已连接服务端
                ///// </summary>
                //Connected = 1,

                ///// <summary>
                ///// 重新连接服务端
                ///// </summary>
                //Reconnection = 2,

                ///// <summary>
                ///// 断开服务端连接
                ///// </summary>
                //Disconnect = 3,

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, (int)MsgBoxStyle.Exclamation + Constants.vbOKOnly, "Error");
            }
        }

        private void TcpClient_Robot_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_Robot.IsStart = true;
            }
            else
            {
                Tcp_Robot.IsStart = false;
            }
        }

        private void TcpClient_CCD1_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_CCD1.IsStart = true;
                this.Lab_CCD1_Sts.BackColor = PVar.BZColor_SelectedBtn;
            }
            else
            {
                Tcp_CCD1.IsStart = false;
                this.Lab_CCD1_Sts.BackColor = PVar.BZColor_ErrorRed;
            }
        }

        private void TcpClient_CCD2_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_CCD2.IsStart = true;
                this.Lab_CCD2_Sts.BackColor = PVar.BZColor_SelectedBtn;
            }
            else
            {
                Tcp_CCD2.IsStart = false;
                this.Lab_CCD2_Sts.BackColor = PVar.BZColor_ErrorRed;
            }
        }

        private void TcpClient_HeatBt_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_HeatBt.IsStart = true;
            }
            else
            {
                Tcp_HeatBt.IsStart = false;
            }
        }

        private void TcpClient_PDCA_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_PDCA.IsStart = true;
            }
            else
            {
                Tcp_PDCA.IsStart = false;
            }
        }

        private void TcpClient_Barcode_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_Barcode.IsStart = true;
            }
            else
            {
                Tcp_Barcode.IsStart = false;
            }
        }

        #endregion

        #region 功能：工程界面数据表格加载
        private int TestDataGridInit_ProductCPKCount;

        public void TestDataGridInit()
        {
            int[] colWidth = new int[] {95, 70, 60, 190, 110, 58, 40, 50, 80, 80, 80, 80, 90, 80, 80, 65, 65, 65,
                80, 80, 80, 80, 80, 90, 60, 130, 130, 130, 110, 110, 110, 130, 130, 130, 130, 120, 130, 120, 110, 100, 100, 120, 110, 100, 100, 100};
            string tempValue = "";
            int Work_Mode;
            PVar.DataCount = int.Parse(BVar.FileRorW.ReadINI("Data100Count", "Count", "", PVar.ListDataIniPath));
            Work_Mode = 0;
            TestDataGridInit_ProductCPKCount = 0;
            DataGrid_CheckData.RowCount = 100;
            //'代码生成数据表格的宽度
            //For i As Integer = 0 To colWidth.Length - 1
            //    DataGrid_CheckData.Columns(i).Width = colWidth(i)
            //Next

            this.Text_BlogoNo.Text = BVar.FileRorW.ReadINI("Material_index ", "Blogo", "1", PVar.PublicParPath);
            PVar.Blogo.MaterialCnt = int.Parse(this.Text_BlogoNo.Text);
            this.TextM_BlogoNo.Text = this.Text_BlogoNo.Text;

            if (System.IO.File.Exists(PVar.ListDataIniPath) == false)
            {
                return;
            }

            if (PVar.DataCount < 1)
            {
                PVar.DataCount = 1;
            }
            if (Work_Mode == 1 & TestDataGridInit_ProductCPKCount == 0)
            {
                for (int row = 1; row <= DataGrid_CheckData.RowCount; row++)
                {
                    for (int col = 1; col <= PVar.DataGrid_CheckDataHeadName.Length; col++)
                    {
                        tempValue = "";
                        FunctionSub.Grid_TestData_Show(this.DataGrid_CheckData, row, col - 1, tempValue);
                    }
                }
            }
            else
            {
                for (int row = 0; row <= 99; row++)
                {
                    for (int col = 1; col <= PVar.DataGrid_CheckDataHeadName.Length; col++)
                    {
                        tempValue = BVar.FileRorW.ReadINI((row).ToString(), PVar.DataGrid_CheckDataHeadName[col - 1], "", PVar.ListDataIniPath);
                        FunctionSub.Grid_TestData_Show(this.DataGrid_CheckData, row, col - 1, tempValue);
                    }
                }
            }
            this.DataGrid_CheckData.CurrentCell = this.DataGrid_CheckData.Rows[0].Cells[0];
            this.DataGrid_CheckData.Rows[0].Selected = true;
        }
        #endregion

        #region 功能：UI界面操作

        private void Fressh_ManualBtn()
        {
            this.Button_S2_1.BackColor = (Gg.GetDo(0, 4)) == 1 ? Color.Gold : Color.WhiteSmoke;
            this.Button_S2_2.BackColor = (Gg.GetDo(1, 0)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S2_3.BackColor = (Gg.GetDo(1, 1)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;

            this.Button_S3_1.BackColor = (Gg.GetDo(0, 5)) == 1 ? Color.Gold : Color.WhiteSmoke;
            this.Button_S3_2.BackColor = (Gg.GetExDo(0, 0, 5)) == 1 ? Color.LightGreen : Color.WhiteSmoke;

            this.Button_S4_1.BackColor = (Gg.GetDo(0, 6)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S4_2.BackColor = (Gg.GetDo(0, 7)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_S4_3.BackColor = (Gg.GetDo(0, 8)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S4_4.BackColor = (Gg.GetDo(0, 9)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_S4_5.BackColor = (Gg.GetDo(0, 10)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S4_6.BackColor = (Gg.GetDo(0, 11)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_S4_7.BackColor = (Gg.GetDo(0, 12)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S4_8.BackColor = (Gg.GetDo(0, 13)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_S4_9.BackColor = (Gg.GetExDo(0, 0, 6)) == 1 ? Color.LightGreen : Color.WhiteSmoke;

            this.Button_S2g_1.BackColor = (Gg.GetExDo(0, 0, 9)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S2g_2.BackColor = (Gg.GetExDo(0, 0, 10)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_S2g_3.BackColor = (Gg.GetExDo(0, 0, 11)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_S2g_4.BackColor = (Gg.GetExDo(0, 0, 12)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_S2g_5.BackColor = (Gg.GetExDo(0, 0, 0)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_S2g_6.BackColor = (Gg.GetExDo(0, 0, 1)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_S2g_7.BackColor = (Gg.GetExDo(0, 0, 4)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_S2g_8.BackColor = (Gg.GetExDo(0, 0, 2)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_S2g_9.BackColor = (Gg.GetExDo(0, 0, 7)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_S2g_10.BackColor = (Gg.GetExDo(0, 0, 3)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_S2g_11.BackColor = (Gg.GetExDo(0, 0, 8)) == 1 ? Color.LightGreen : Color.WhiteSmoke;

        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (TabControl1.SelectedIndex)
            {
                case 3: //手动界面
                    TabControl2.SelectedIndex = 0;
                    TabControl3.SelectedIndex = 0;
                    TabControl4.SelectedIndex = 0;
                    TabControl5.SelectedIndex = 0;


                    //--------------------------------------------
                    this.Text_BlogoNo.Text = BVar.FileRorW.ReadINI("Material_index ", "Blogo", "1", PVar.PublicParPath);
                    PVar.Blogo.MaterialCnt = Int32.Parse(this.Text_BlogoNo.Text);
                    this.TextM_BlogoNo.Text = this.Text_BlogoNo.Text;
                    break;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e) //I/O输出界面 和 手动调试界面 进入跳转管理
        {
            TabControl3.Enabled = false; //输出界面
            TabControl4.Enabled = false; //手动调试界面
            PVar.IsOpenFrmManual = false;
            switch (TabControl1.SelectedIndex)
            {
                case 0:
                    Teach1.Timer.Enabled = false;
                    Teach2.Timer.Enabled = false;
                    Teach3.Timer.Enabled = false;
                    Teach4.Timer.Enabled = false;
                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    MotorStatus3.Timer.Enabled = false;
                    Frm_Login.fLogin.Close();
                    FunctionSub.Close_NumberKey_Process();
                    //--------------------------------------------
                    this.Text_BlogoNo.Text = BVar.FileRorW.ReadINI("Material_index ", "Blogo", "1", PVar.PublicParPath);
                    PVar.Blogo.MaterialCnt = Int32.Parse(this.Text_BlogoNo.Text);
                    this.TextM_BlogoNo.Text = this.Text_BlogoNo.Text;
                    break;
                case 1:
                    TabControl2.SelectedIndex = 0;
                    Teach1.Timer.Enabled = false;
                    Teach2.Timer.Enabled = false;
                    Teach3.Timer.Enabled = false;
                    Teach4.Timer.Enabled = false;
                    InputClass1.Timer.Enabled = true;
                    InputClass2.Timer.Enabled = true;
                    InputClass3.Timer.Enabled = true;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    MotorStatus3.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
                    Frm_Login.fLogin.Close();
                    FunctionSub.Close_NumberKey_Process();
                    break;

                case 2:
                    if (PVar.Stop_Flag && PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false)
                    {
                        if (Frm_Login.fLogin == null || Frm_Login.fLogin.IsDisposed)
                        {
                            Frm_Login.fLogin = new Frm_Login();
                        }
                        Frm_Login.fLogin.Show();
                        Frm_Login.fLogin.MainPassword.Focus();
                    }
                    else
                    {
                        TabControl1.SelectedIndex = 0;
                        if (MessageBox.Show("设备处于运行中,请先停止！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) != DialogResult.OK) //设备初始化判定
                        {
                            return;
                        }
                    }
                    Teach1.Timer.Enabled = false;
                    Teach2.Timer.Enabled = false;
                    Teach3.Timer.Enabled = false;
                    Teach4.Timer.Enabled = false;
                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    MotorStatus3.Timer.Enabled = false;
                    //OutputClass1.Timer.Enabled = true;
                    //OutputClass2.Timer.Enabled = true;
                    //OutputClass3.Timer.Enabled = true;
                    break;

                case 3:
                    if (PVar.Stop_Flag && PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false)
                    {
                        if (Frm_Login.fLogin == null || Frm_Login.fLogin.IsDisposed)
                        {
                            Frm_Login.fLogin = new Frm_Login();
                        }
                        Frm_Login.fLogin.Show();
                        Frm_Login.fLogin.MainPassword.Focus();
                    }
                    else
                    {
                        TabControl1.SelectedIndex = 0;
                        if (MessageBox.Show("设备处于运行中,请先停止！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    //--------------------------------------------
                    this.Text_BlogoNo.Text = BVar.FileRorW.ReadINI("Material_index ", "Blogo", "1", PVar.PublicParPath);
                    PVar.Blogo.MaterialCnt = Int32.Parse(this.Text_BlogoNo.Text);
                    this.TextM_BlogoNo.Text = this.Text_BlogoNo.Text;

                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    MotorStatus3.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
                    //Teach1.Timer.Enabled = true;
                    //Teach2.Timer.Enabled = true;
                    //Teach3.Timer.Enabled = true;
                    //Teach4.Timer.Enabled = true;
                    break;
            }
        }

        private void TabControl2_SelectedIndexChanged(object sender, EventArgs e) //I/O输出界面 和 手动调试界面 进入跳转管理
        {
            switch (TabControl2.SelectedIndex)
            {
                case 0:
                    InputClass1.Timer.Enabled = true;
                    InputClass2.Timer.Enabled = true;
                    InputClass3.Timer.Enabled = true;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    MotorStatus3.Timer.Enabled = false;
                    break;
                case 1:
                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = true;
                    MotorStatus2.Timer.Enabled = true;
                    MotorStatus3.Timer.Enabled = true;
                    break;
            }
        }

        private void TabControl3_SelectedIndexChanged(object sender, EventArgs e) //I/O输出界面 和 手动调试界面 进入跳转管理
        {
            switch (TabControl3.SelectedIndex)
            {
                case 0:
                    OutputClass1.Timer.Enabled = true;
                    OutputClass2.Timer.Enabled = true;
                    OutputClass3.Timer.Enabled = true;
                    break;
                case 1:
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
                    break;
            }
        }

        #endregion

        #region 功能：系统周期时间

        private void CT_Time_Elapsed(object sender, EventArgs e)
        {
            if (Sta1Run.CT_Start == true)
            {
                this.BeginInvoke(new Action(() => { CT_Count(); }));
            }
        }
        private void CT_Count()
        {
            PVar.StorCycleTimer = System.Convert.ToDouble((System.Convert.ToInt32(API.GetTickCount()) - PVar.StaTime[0]) / 1000); //系统周期时间
            Cycle.Text = Strings.Format(PVar.StorCycleTimer, "0.00");
        }
        #endregion

        #region 功能：用户登录
        private void Btn_ParLogin_MouseDown(object sender, EventArgs e)
        {
            if (Frm_Login.fLogin == null || Frm_Login.fLogin.IsDisposed)
            {
                Frm_Login.fLogin = new Frm_Login();
            }
            Frm_Login.fLogin.Show();
        }
        private void UserManagement_Click(object sender, EventArgs e)
        {
            if (Frm_UserManagement.fUserManagement == null || Frm_UserManagement.fUserManagement.IsDisposed)
            {
                Frm_UserManagement.fUserManagement = new Frm_UserManagement();
            }
            Frm_UserManagement.fUserManagement.ShowDialog();
        }

        #endregion

        #region 功能：手动界面IO输出按钮
        private void Btn_All_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int mCardType = 0;
            int mCardNum = 0;
            int mMdl = 0;
            int mIndex = 0;
            string[] tmpArray = null;

            mCardType = btn.TabIndex;
            tmpArray = Strings.Split(Strings.Mid(System.Convert.ToString(btn.Tag), 2, btn.Tag.ToString().Length - 2), ",", -1);
            mCardNum = System.Convert.ToInt32(tmpArray[0]);
            mMdl = System.Convert.ToInt32(tmpArray[1]);
            mIndex = System.Convert.ToInt32(tmpArray[2]);

            mFunction.NSetDO(mCardType, mCardNum, mMdl, mIndex);

            Fressh_ManualBtn();
        }
        #endregion

        #region 功能：手动界面CCD按钮
        private void CCD_Trigger_S2_Click(object sender, EventArgs e)
        {
            int watchTime = 0;
            if (Tcp_CCD1.IsStart == false)
            {
                ShowList("CCD通信连接异常，请确认！");
                return;
            }
            switch (this.ComboBox_Cam1.SelectedIndex)
            {
                case 0:
                    Command.TCP_CCD1_Send(Command.取料拍照 + "," + PVar.ParList.Data[7]);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD1.Text = PVar.CCD1_StrData;
                    break;

                case 1:
                    Command.TCP_CCD1_Send(Command.装配角度拍照 + "," + PVar.ParList.Data[7]);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD1.Text = PVar.CCD1_StrData;
                    break;

                case 2:
                    Command.TCP_CCD1_Send(Command.装配HSG圆拍照 + "," + PVar.ParList.Data[7]);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD1.Text = PVar.CCD1_StrData;
                    break;

                case 3:
                    Command.TCP_CCD1_Send(Command.装配Blogo拍照 + "," + PVar.ParList.Data[7]);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD1.Text = PVar.CCD1_StrData;
                    break;

                case 4:
                    Command.TCP_CCD1_Send(Command.装配拍照 + "," + PVar.ParList.Data[7]);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD1.Text = PVar.CCD1_StrData;
                    break;
            }
        }

        private void CCD_Trigger_S4_Click(object sender, EventArgs e)
        {
            int watchTime = 0;
            if (Tcp_CCD2.IsStart == false)
            {
                ShowList("CCD通信连接异常，请确认！");
                return;
            }
            switch (this.ComboBox_Cam2.SelectedIndex)
            {
                case 0:
                    Command.TCP_CCD2_Send(Command.复检角度);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD2.Text = PVar.CCD2_StrData;
                    break;

                case 1:
                    Command.TCP_CCD2_Send(Command.复检同心度);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                    {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                        {
                            return;
                        }
                        Application.DoEvents();
                    } while (!(PVar.CCD1_StrData != ""));
                    TextBox_CCD2.Text = PVar.CCD2_StrData;
                    break;
            }
        }
        #endregion

        #region 功能：设备开始初始化
        public void MacReset()
        {
            for (int i = 1; i <= 8; i++) //所有轴回原点步序号清0
            {
                GoHome.Instance.AxisHome[0, i].Step = 0;
                GoHome.Instance.AxisHome[1, i].Step = 0;
                GoHome.Instance.AxisHome[0, i].Result = false;
                GoHome.Instance.AxisHome[1, i].Result = false;
            }

            if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1 || Gg.GetDi(1, Gg.InPut1.急停按钮) == 1)
            {
                AddList("急停按钮被按下,请检查!");
                ShowList("急停按钮被按下,请检查!");
                return;
            }
            if (Gg.GetDi(0, Gg.InPut0.安全光幕) == 0)
            {
                AddList("安全光幕异常，请检查！");
                ShowList("安全光幕异常，请检查！");
                return;
            }

            if (Gg.GetDi(0, Gg.InPut0.正压检测) == 0)
            {
                AddList("正压检测异常，请检查！");
                ShowList("正压检测异常，请检查！");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.组装X轴) == 1)
            {
                AddList("组装X轴伺服报警!");
                ShowList("组装X轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.组装Y轴) == 1)
            {
                AddList("组装Y轴伺服报警!");
                ShowList("组装Y轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.组装Z轴) == 1)
            {
                AddList("组装Z轴伺服报警!");
                ShowList("组装Z轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.组装R轴) == 1)
            {
                AddList("组装R轴伺服报警!");
                ShowList("组装R轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.上料Z轴) == 1)
            {
                AddList("上料Z轴伺服报警!");
                ShowList("上料Z轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.平移Y轴) == 1)
            {
                AddList("平移Y轴伺服报警!");
                ShowList("平移Y轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.拉料Z轴) == 1)
            {
                AddList("拉料Z轴伺服报警!");
                ShowList("拉料Z轴伺服报警!");
                return;
            }
            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.保压Z轴) == 1)
            {
                AddList("保压Z轴伺服报警!");
                ShowList("保压Z轴伺服报警!");
                return;
            }

            if (Gg.Get_AlarmDi(1, Gg.InAlarm1.转盘R轴) == 1)
            {
                AddList("转盘R轴伺服报警!");
                ShowList("转盘R轴伺服报警!");
                return;
            }


            //检查安全门
            if (PVar.ParList.CheckSts[1])
            {
                string tempStr = "";
                if (Gg.GetDi(1, Gg.InPut1.后门安全门1) == 0)
                {
                    tempStr = "后门安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.后门安全门2) == 0)
                {
                    tempStr = "后门安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.右安全门1) == 0)
                {
                    tempStr = "右安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.右安全门2) == 0)
                {
                    tempStr = "右安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.左安全门1) == 0)
                {
                    tempStr = "左安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.左安全门2) == 0)
                {
                    tempStr = "左安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.前门安全门) == 0)
                {
                    tempStr = "前门安全门";
                }
                if (!string.IsNullOrEmpty(tempStr))
                {
                    AddList("请先关闭" + tempStr + "后再初始化!!");
                    ShowList("请先关闭" + tempStr + "后再初始化!!");
                    return;
                }
            }
            Teach1.Timer.Enabled = false;
            Teach2.Timer.Enabled = false;
            Teach3.Timer.Enabled = false;
            Teach4.Timer.Enabled = false;
            InputClass1.Timer.Enabled = false;
            InputClass2.Timer.Enabled = false;
            InputClass3.Timer.Enabled = false;
            OutputClass1.Timer.Enabled = false;
            OutputClass2.Timer.Enabled = false;
            OutputClass3.Timer.Enabled = false;
            MotorStatus1.Timer.Enabled = false;
            MotorStatus2.Timer.Enabled = false;
            MotorStatus3.Timer.Enabled = false;

            //打开所轴有使能
            if (Gg.Set_AllServoON(0, 1, 8) == false || Gg.Set_AllServoON(1, 1, 1) == false)
            {
                return;
            }

            for (int i = 0; i <= 10; i++)
            {
                PVar.Sta_Work[i].State = false;
                PVar.Sta_Work[i].IsHaveHSG = false;
                PVar.Sta_Work[i].Step = 0;
            }

            Frm_Engineering.fEngineering.Label_Sta4.Text = "2";
            Frm_Engineering.fEngineering.Label_Sta3.Text = "3";
            Frm_Engineering.fEngineering.Label_Sta2.Text = "4";
            Frm_Engineering.fEngineering.Label_Sta1.Text = "1";
            //清空缓存里面数据
            BVar.InitProData();
            PVar.Autorun.Enable = false;

            PVar.IsSysEmcStop = false;
            Frm_Main.fMain.Btn_Start.Enabled = false;
            Frm_Main.fMain.Btn_Stop.Enabled = false;
            PVar.Stop_Flag = false;
            this.Home_Timer.Enabled = true;
            this.Btn_SelectMaterial.Enabled = false;
            GoHome.Instance.StepHome = 10;

        }

        private void Home_Timer_Tick(object sender, EventArgs e)
        {
            Home_Timer.Enabled = false;

            if (Gg.GetDi(0, Gg.InPut0.正压检测) == 0)
            {
                AddList("正压检测异常，请检查！");
                ShowList("正压检测异常，请检查！");
                Frm_Engineering.fEngineering.MacStop();
                return;
            }

            GoHome.Instance.HomeSub();
            Lab_Home.Text = System.Convert.ToString(GoHome.Instance.StepHome); //界面右上角

            Home_Timer.Enabled = GoHome.Instance.Reset.State? true:false;

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            GoHome.Instance.AxisGoHome.State = true;
        }
        #endregion

        #region 功能：自动运行
        public void Auto_Assemble()
        {
            Frm_Main.fMain.Btn_Start.Enabled = false;
            if (PVar.ParList.CheckSts[1] && PVar.Stop_Flag == false)
            {
                string tempStr = "";
                if (Gg.GetDi(1, Gg.InPut1.后门安全门1) == 0)
                {
                    tempStr = "后门安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.后门安全门2) == 0)
                {
                    tempStr = "后门安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.右安全门1) == 0)
                {
                    tempStr = "右安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.右安全门2) == 0)
                {
                    tempStr = "右安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.左安全门1) == 0)
                {
                    tempStr = "左安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.左安全门2) == 0)
                {
                    tempStr = "左安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.前门安全门) == 0)
                {
                    tempStr = "前门安全门";
                }

                if (!string.IsNullOrEmpty(tempStr))
                {
                    AddList("请关闭" + tempStr);
                    ShowList("请关闭" + tempStr);
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    return;
                }
            }

            //if (BVar.FileRorW.ReadINI("CCD", "CCD九点标定-吸嘴1", "NG", PVar.BZ_CalibrationFileName) != "OK")
            //    {
            //    AddList("CCD九点标定-吸嘴1没有标定！");
            //    ShowList("CCD九点标定-吸嘴1没有标定！");
            //    Frm_Main.fMain.Btn_Start.Enabled = true;
            //    return;
            //    }


            if (Gg.Set_AllServoON(0, 1, 8) == false || Gg.Set_AllServoON(1, 1, 1) == false)
            {
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
            }

            if (PVar.MacHold == true)
            {
                AddList("暂停中…");
                ShowList("设备处于暂停中…");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
            }

            for (short j = 1; j <= 8; j++)
            {
                if (Gg.ZSPD(0, j) == false)
                {
                    ShowList(BVar.Axisname[j - 1] + "轴伺服正在运动中…");
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    return;
                }
            }

            for (short j = 1; j <= 4; j++)
            {
                if (Gg.ZSPD(1, j) == false)
                {
                    ShowList(BVar.Axisname[j + 8 - 1] + "轴伺服正在运动中…");
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    return;
                }
            }

            if (!(Gg.GetExDo(0, 1, 14) == 0 && Gg.GetExDo(0, 1, 15) == 0))
            {
                ShowList("Feeder物料夹爪没有夹紧！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
            }

            if ((Tcp_CCD1.IsStart == false || Tcp_CCD2.IsStart == false) && PVar.ParList.CheckSts[17] == false)
            {
                AddList("CCD网络通讯异常！");
                ShowList("CCD网络通讯异常！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
            }

            Teach1.Timer.Enabled = false;
            Teach2.Timer.Enabled = false;
            Teach3.Timer.Enabled = false;
            Teach4.Timer.Enabled = false;
            InputClass1.Timer.Enabled = false;
            InputClass2.Timer.Enabled = false;
            InputClass3.Timer.Enabled = false;
            OutputClass1.Timer.Enabled = false;
            OutputClass2.Timer.Enabled = false;
            OutputClass3.Timer.Enabled = false;
            MotorStatus1.Timer.Enabled = false;
            MotorStatus2.Timer.Enabled = false;
            MotorStatus3.Timer.Enabled = false;

            TabPage3.Parent = null;
            TabPage4.Parent = null;

            PVar.AutoRunFlag = true;
            this.Btn_SelectMaterial.Enabled = false;
            PVar.Autorun.Enable = true;

            //按钮
            Frm_Main.fMain.Btn_Start.Enabled = false;
            Frm_Main.fMain.Btn_Pause.Enabled = true;
            Frm_Main.fMain.Btn_Stop.Enabled = true;
            Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_SelectedBtn; ////运行按钮
            Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;

            for (int i = 0; i <= 5; i++)
            {
                PVar.TimeStart[i] = System.Convert.ToInt64(API.GetTickCount());
                if (PVar.Sta_Work[i].Step == 0)
                {
                    PVar.Sta_Work[i].Step = 10;
                }
            }


            PVar.MacHold = false;
            PVar.Stop_Flag = false;
            PVar.LampStatus = 30;
            Auto_Timer.Enabled = true; //自动运行开始
            AddList("设备进入自动运行中…");
        }
        #endregion

        #region 功能：设备状态更新定时器
        private void StatusTimer_Tick()
        {
            if (PVar.Stop_Flag && PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false)
            {
                this.Btn_SelectMaterial.Enabled = true;
            }

            if (PVar.ParList.CheckSts[1] && PVar.Stop_Flag == false && PVar.MacHold == false)
            {
                string tempStr = "";
                if (Gg.GetDi(1, Gg.InPut1.后门安全门1) == 0)
                {
                    tempStr = "后门安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.后门安全门2) == 0)
                {
                    tempStr = "后门安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.右安全门1) == 0)
                {
                    tempStr = "右安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.右安全门2) == 0)
                {
                    tempStr = "右安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.左安全门1) == 0)
                {
                    tempStr = "左安全门1";
                }
                if (Gg.GetDi(1, Gg.InPut1.左安全门2) == 0)
                {
                    tempStr = "左安全门2";
                }
                if (Gg.GetDi(1, Gg.InPut1.前门安全门) == 0)
                {
                    tempStr = "前门安全门";
                }
                if (!string.IsNullOrEmpty(tempStr))
                {
                    PVar.MacHold = true;
                    PVar.Stop_Flag = false;
                    AddList("请关闭" + tempStr);
                    ShowList("请关闭" + tempStr);
                    Frm_Main.fMain.Btn_Start.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    this.Auto_Timer.Enabled = false; //安全门打开自动运行定时器关闭
                    Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedPauseBtn;
                    PVar.LampStatus = 20;
                }
            }

            FunctionSub.LightStatus(); //指示灯刷新

            if (PVar.IsOpenFrmManual)
            {
                Fressh_ManualBtn();
            }

            //工程界面状态信号灯刷新
            this.Label_Sta1.BackColor = (Gg.GetDi(0, 4) == 1) ? Color.Lime : Color.White; //人工站产品感应
            this.OvalShape_Sta1.BackColor = (Gg.GetDi(0, 4) == 1) ? Color.Lime : Color.White; //人工站产品感应


            this.Lab_EMG_Sts.BackColor = PVar.IsSysEmcStop == false ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //急停按钮指示信号
            this.Lab_Safe_Sts.BackColor = (Gg.GetDi(1, 0) == 1 && Gg.GetDi(1, 1) == 1 && Gg.GetDi(1, 2) == 1 && Gg.GetDi(1, 3) == 1 && Gg.GetDi(1, 4) == 1 && Gg.GetDi(1, 5) == 1 && Gg.GetDi(1, 6) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //安全门信号
            this.Lab_SafeLight_Sts.BackColor = (Gg.GetDi(0, 0) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //安全门信号

            this.Lab_LightContor_Sts.BackColor = PVar.IsCOM3_Working == true ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //光源通信
            this.Lab_LC1_Sts.BackColor = this.SerialPort1.IsOpen == true ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //压力传感器串口是否打开
            this.Lab_LC2_Sts.BackColor = this.SerialPort2.IsOpen == true ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //压力传感器串口是否打开
            this.Lab_Air_Sts.BackColor = (Gg.GetExDi(0, 5) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //正气压信号


            if (PVar.WorkMode == 1)
            {
                Label_CPK.Text = "CPK：" + System.Convert.ToString(PVar.CPKDoneCounts) + "/32";
                Frm_Main.fMain.Lab_CpkCount.Text = PVar.CPKDoneCounts + "/32";
            }

            this.Label_PDCA_Step.Text = PDCA.Instance.UpLoadStep.ToString();
        }
        #endregion

        #region 功能：报警处理
        private void Alarm_Timer_Tick(object sender, EventArgs e)
        {
            int emg = 1;
            Alarm_Timer.Enabled = false;

            if (Gg.GetDi(0, 15) == 0 && Gg.GetDi(0, 15) == 0)
            {
                emg = 0;
            }
            else
            {
                emg = 1;
            }
            if (BVar.EMC_Stop[0].LDP(emg))
            {
                MacStop();
                AddList("急停按钮被触发！");
                ShowList("急停按钮被触发！");
                PVar.IsSysEmcStop = true;
            }

            if (BVar.EMC_Stop[0].LDF(emg))
            {
                AddList("急停按钮已解除！");
                ShowList("急停按钮已解除！");
                PVar.IsSysEmcStop = false;
            }

            if ((PVar.Autorun.Enable && PVar.Stop_Flag == false))
            {
                WatchAxisAlarm(); //监控报警伺服
            }

            if (GoHome.Instance.Reset.Result && PVar.Autorun.Enable)//回零完成和自动开始
            {
                WatchLimitAlarm(); //监控正负极限
            }

            if ((GoHome.Instance.Reset.State || PVar.Autorun.Enable) && BVar.InPutAir.LDF(Gg.GetDi(0, Gg.InPut0.正压检测)))
            {
                MacStop();
                AddList("正压检测异常！");
                ShowList("正压检测异常！");
            }

            ////当伺服报警刹车打开
            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.组装Z轴) == 1)
            {
                Gg.SetDo(0, Gg.OutPut0.装配站刹车继电器, 0);
            }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.保压Z轴) == 1)
            {
                Gg.SetDo(0, Gg.OutPut0.保压站刹车继电器, 0);
            }

            Alarm_Timer.Enabled = true;
        }

        private void WatchAxisAlarm()
        {
            for (short i = 1; i <= 9; i++)
            {
                if (BVar.AxisAlarm[i].LDP(Gg.Get_AlarmDi((i - 1) / 8, i % 9 + (i - 1) / 8)))
                {
                    ShowList(BVar.Axisname[i - 1] + "伺服报警!");
                    MacStop();
                    return;
                }
            }
        }

        private void WatchLimitAlarm()
        {
            if (GoHome.Instance.Reset.Result)
            {
                if (PVar.IsSysEmcStop == false)
                {
                    for (short i = 1; i <= 9; i++)
                    {
                        if (GoHome.Instance.AxisHome[(i - 1) / 8, i % 9 + (i - 1) / 8].Result)
                        {
                            if (Gg.GetLimitDi_Z(System.Convert.ToInt16((i - 1) / 8), (short)(i % 9 + (i - 1) / 8)) == 1)
                            {
                                MacStop();
                                for (short j = 1; j <= 9; i++)
                                {
                                    gts.GT_Stop(Convert.ToInt16((j - 1) / 8), 1 << ((short)(j % 9 + (j - 1) / 8) - 1), 0);
                                }
                                ShowList(BVar.Axisname[i - 1] + "触发正极限报警!");
                                break;
                            }
                            if (Gg.GetLimitDi_F(System.Convert.ToInt16((i - 1) / 8), (short)(i % 9 + (i - 1) / 8)) == 1)
                            {
                                MacStop();
                                for (short j = 1; j <= 9; j++)
                                {
                                    gts.GT_Stop(Convert.ToInt16((j - 1) / 8), 1 << ((short)(j % 9 + (j - 1) / 8) - 1), 0);
                                }
                                ShowList(BVar.Axisname[i - 1] + "触发负极限报警!");
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 机器停止
        /// </summary>
        public void MacStop()
        {
            PVar.Autorun.Enable = false;
            PVar.Stop_Flag = true;
            GoHome.Instance.Reset.Result = false;
            if (PVar.IsSysEmcStop)
                return;

            PVar.Rtn = gts.GT_Stop(0, 255, 255); //紧急停止0号卡所有轴
            PVar.Rtn = gts.GT_Stop(1, 15, 15); //紧急停止1号卡所有轴

            Auto_Timer.Enabled = false;
            for (int i = 0; i <= 4; i++)
            {
                PVar.Sta_Work[i].State = false;
                PVar.Sta_Work[i].IsHaveHSG = false;
                PVar.Sta_Work[i].Step = 0;
            }

            for (int i = 1; i <= 8; i++) //所有轴回原点步序号清0
            {
                GoHome.Instance.AxisHome[0, i].Step = 0;
                GoHome.Instance.AxisHome[1, i].Step = 0;
                GoHome.Instance.AxisHome[0, i].Result = false;
                GoHome.Instance.AxisHome[1, i].Result = false;
            }

            PVar.LampStatus = 10;
            GoHome.Instance.StepHome = 0;
            Home_Timer.Enabled = false;

            this.CT_Time.Enabled = false;

            TabPage3.Parent = TabControl1;
            TabPage4.Parent = TabControl1;

            Frm_ProgressBar FrmProgressBar = new Frm_ProgressBar();
            FrmProgressBar.Hide();

            Frm_Main.fMain.Btn_Start.Enabled = true;
            Frm_Main.fMain.Btn_Pause.Enabled = false;
            Frm_Main.fMain.Btn_Stop.Enabled = false;
            Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn; //主页面初始化和自动运行按钮
            Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
            PVar.IsSysEmcStop = true;
        }
        #endregion

        #region Time_Elapsed

        private void Status_Time_Elapsed(object sender, EventArgs e)
        {
            Status_Time.Enabled = false;
            try
            {
                this.BeginInvoke(new Action(() => { StatusTimer_Tick(); }));
            }
            catch (Exception)
            { }
            finally
            {
                Status_Time.Enabled = true;
            }
        }

        private void Conect_Time_Elapsed(object sender, EventArgs e)
        {
            lock (LockConect)
                try
                {
                    if (Tcp_Robot.IsStart == false)
                    {
                        Tcp_Robot.StartConnect();
                    }

                    if (Tcp_CCD1.IsStart == false)
                    {
                        Tcp_CCD1.StartConnect();
                    }

                    if (Tcp_CCD2.IsStart == false)
                    {
                        Tcp_CCD2.StartConnect();
                    }

                }
                catch (Exception)
                {

                }
        }

        #endregion

        #region 功能：自动运行定时器
        private void Auto_Timer_Tick(object sender, EventArgs e)
        {
            Auto_Timer.Enabled = false;
            if (PVar.MacHold == false)
            {
                if (PVar.ParList.CheckSts[1])
                {
                    string tempStr = "";
                    if (Gg.GetDi((short)0, (short)13) == 0)
                    {
                        tempStr = "安全门左";
                    }
                    if (Gg.GetDi((short)0, (short)14) == 0)
                    {
                        tempStr = "安全门右";
                    }
                    if (!string.IsNullOrEmpty(tempStr))
                    {
                        PVar.MacHold = true;
                        PVar.Stop_Flag = false;
                        Frm_Main.fMain.Btn_Start.Enabled = false;
                        Frm_Main.fMain.Btn_Stop.Enabled = false;
                        Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        this.Auto_Timer.Enabled = false;
                        Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedPauseBtn;
                        //Btn_Start.BackColor = BZColor_UnselectedBtn
                        PVar.LampStatus = 20;
                        AddList("请关闭" + tempStr);
                        ShowList(tempStr + "被打开，设备暂停！");
                        return;
                    }
                }

                if (BVar.TmpStep[1] != PVar.Sta_Work[1].Step || BVar.TmpStep[1] != PVar.Sta_Work[2].Step || BVar.TmpStep[3] != PVar.Sta_Work[3].Step)
                {
                    BVar.FileRorW.WriteCsv(PVar.Sta_Work[1].Step + "," + System.Convert.ToString(PVar.Sta_Work[2].Step) + "," + System.Convert.ToString(PVar.Sta_Work[3].Step) + "," + System.Convert.ToString(API.GetTickCount()), "E:\\Log\\" + BVar.ProData[2, 1] + ".csv");
                }
                BVar.TmpStep[1] = PVar.Sta_Work[1].Step;
                BVar.TmpStep[2] = PVar.Sta_Work[2].Step;
                BVar.TmpStep[3] = PVar.Sta_Work[3].Step;

                Sta0Run.AutoRun(ref PVar.Sta_Work[0]);
                Sta1Run.AutoRun(ref PVar.Sta_Work[1]);
                Sta2Run.AutoRun(ref PVar.Sta_Work[2]);
                Sta3Run.AutoRun(ref PVar.Sta_Work[3]);
                Sta4Run.AutoRun(ref PVar.Sta_Work[4]);

            }
            Auto_Timer.Enabled = true;
        }
        #endregion

        #region 功能：条码枪手动触发

        private void Barcode_Trigge_Click(object sender, EventArgs e)
        {
            Sta1Run.CT_Start = true;
            PVar.StaTime[0] = System.Convert.ToInt64(API.GetTickCount());
            //return;

            if (Gg.GetDi(1, Gg.InPut1.右安全门1) == 0)
            {
                MessageBox.Show("异常！");
            }

            if (Tcp_Barcode.IsStart == false)
            {
                MessageBox.Show("条码枪连接异常！");
            }
            else
            {

                Tcp_Barcode.SendData(Encoding.UTF8.GetBytes("||>trigger on" + Constants.vbCrLf)); //触发条码枪
                WinAPI.Wait(5);
            }
            FileLog.OperateLog("条码枪触发");
        }
        #endregion

        #region 功能：网口接收数据

        //CCD1接收数据
        private string CCD1BufferStr = ""; //以太网数据读取缓存字符
        private void WinsockCCD1_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            string CCD_DataStr = "";
            CCD_DataStr = "";
            try
            {
                CCD_DataStr = Encoding.UTF8.GetString(e.Data);
                if (CCD_DataStr.Substring(CCD_DataStr.Length - 1, 1) != Constants.vbCr)
                {
                    CCD1BufferStr = CCD1BufferStr + CCD_DataStr;
                }
                else
                {
                    CCD1BufferStr = CCD1BufferStr + CCD_DataStr;
                    CCD1BufferStr = CCD1BufferStr.Trim(); //删除前后空格
                    CCD1BufferStr = CCD1BufferStr.Replace(Constants.vbCr, ""); //删除结束符号
                    PVar.CCD1_StrData = CCD1BufferStr;
                    PVar.CCD1_Data = CCD1BufferStr.Split(',');
                    CCD1BufferStr = "";
                    Command.CCD1_Resule = true;
                }
            }
            catch (Exception)
            {
                AddList("CCD1网络接收解析出错！");
                ShowList("CCD1网络接收解析出错！");
                CCD1BufferStr = "";
            }
        }

        //CCD2接收数据
        private string CCD2BufferStr = ""; //以太网数据读取缓存字符
        private void WinsockCCD2_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            string CCD_DataStr = "";
            CCD_DataStr = "";
            try
            {
                CCD_DataStr = Encoding.UTF8.GetString(e.Data);
                if (CCD_DataStr.Substring(CCD_DataStr.Length - 1, 1) != Constants.vbCr)
                {
                    CCD2BufferStr = CCD2BufferStr + CCD_DataStr;
                }
                else
                {
                    CCD2BufferStr = CCD2BufferStr + CCD_DataStr;
                    CCD2BufferStr = CCD2BufferStr.Trim(); //删除前后空格
                    CCD2BufferStr = CCD2BufferStr.Replace(Constants.vbCr, ""); //删除结束符号
                    PVar.CCD2_Data = CCD2BufferStr.Split(',');
                    PVar.CCD2_StrData = CCD2BufferStr;
                    CCD2BufferStr = "";
                    Command.CCD2_Resule = true;
                }
            }
            catch (Exception)
            {
                AddList("CCD2网络接收解析出错！");
                ShowList("CCD2网络接收解析出错！");
                CCD2BufferStr = "";
            }
        }

        //条码抢网口接收数据
        private void WinsockBarcode_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            ////try
            ////    {
            ////    if (Encoding.UTF8.GetString(e.Data) != "")
            ////        {
            ////        if ((Encoding.UTF8.GetString(e.Data).Length) > 5)
            ////            {

            ////            }
            ////        }

            ////    Sta0Run.BarCodeData = Strings.Replace(Sta0Run.BarCodeData, Constants.vbCrLf, ""); //删除结束符号

            ////    }
            ////catch (Exception)
            ////    {

            ////    }
        }

        //PDCA网口接收数据
        private string WinsockPDCA_DataArrival_EthernetBufferStr = "";

        private void WinsockPDCA_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            // static string EthernetBufferStr = "";  //以太网数据读取缓存字符
            string EthernetData = "";
            string[] TempStr = null;
            PDCA.Instance.PDCA_Data = "";
            EthernetData = "";
            EthernetData = Encoding.UTF8.GetString(e.Data); //获取PDCA字符串数据
            WinsockPDCA_DataArrival_EthernetBufferStr = WinsockPDCA_DataArrival_EthernetBufferStr + EthernetData;
            TempStr = WinsockPDCA_DataArrival_EthernetBufferStr.Split(",@".ToCharArray()[0]);
            PDCA.Instance.PDCA_Data = TempStr[0];
            EthernetData = "";
            WinsockPDCA_DataArrival_EthernetBufferStr = "";
        }


        private void WinsockHeatBt_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            try
            {
                PVar.HeatBtReceiveStr = Encoding.UTF8.GetString(e.Data);
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region 功能：相机自动标定

        private void Btn_CalibrationList_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否开始相机自动标定?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //判断初始条件
            if (GoHome.Instance.Reset.Result == false)
            {
                FunctionSub.AddListCalib("整机未初始化！");
                ShowList("整机未初始化！");
                return;
            }

            string strin = "";
            strin = Interaction.InputBox("\r\n" + "\r\n" + "\r\n" + "警告：标定失败会导致无法继续生产！" + "\r\n" + "\r\n" + "-->请输入CCD标定密码：", "◆权限◆");

            if (strin.Length > 0)
            {
                if (strin == "789000")
                {
                    FileLog.OperateLog("CCD标定" + ComboBox_CCD.Text);
                    switch (ComboBox_CCD.SelectedIndex)
                    {
                        case 0:
                            Calibration.Instance.CalibStep[0] = 10;
                            PanelCalibration.Enabled = false;
                            Timer_Calibration.Enabled = true;
                            break;
                    }
                }
                else
                {
                    Interaction.MsgBox("密码错误！", Constants.vbOKOnly, "密码提示");
                }
            }
            else
            {

            }
        }

        private void Timer_Calibration_Tick(object sender, EventArgs e)
        {
            Timer_Calibration.Enabled = false;
            Calibration.Instance.AutoCalibration0();
            Timer_Calibration.Enabled = true;
        }

        #endregion

        #region 功能：PDCA验证模块
        private void Btn_PDCATest_Click(object sender, EventArgs e)
        {
            if (PDCA.Instance.PDCAIsWorking == false) //要等待上次PDCA数据传送结束才可开始上传
            {
                this.List_Info.Items.Clear();
                PDCA.Instance.UpLoadStep = (short)10;
                PDCA.Instance.PDCAIsWorking = true;
                PDCA_Time.Enabled = true;
                string[] tempTestData = new string[] { this.Txt_MLBBarcode.Text.Trim(), "0", "0.03", "-0.04", "0.05", "0.16", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                PVar.sPDCAData = tempTestData;
                FileLog.OperateLog("PDCA测试按钮");
            }
        }

        private void PDCA_Time_Tick(object sender, EventArgs e)
        {
            PDCA_Time.Enabled = false;
            PDCA.Instance.UpLoad_PDCA(PVar.sPDCAData);
            PDCA_Time.Enabled = PDCA.Instance.PDCAIsWorking?true:false;

        }
        #endregion

        #region 功能：机修手校正模块
        private void Btn_CaliSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("旋转中心校正结果" + Constants.vbCr + "是否保存，请确认？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }
            BVar.FileRorW.WriteINI("Center", "CenterX", Text_CaliX.Text, PVar.BZ_LightSettingPath);
            BVar.FileRorW.WriteINI("Center", "CenterY", Text_CaliY.Text, PVar.BZ_LightSettingPath);
        }

        private void Btn_SaveCamDist_Click(object sender, EventArgs e)
        {
            BVar.FileRorW.WriteINI("CamDist", "CamDistX", Txt_CamDistX.Text, PVar.BZ_LightSettingPath);
            BVar.FileRorW.WriteINI("CamDist", "CamDistY", Txt_CamDistY.Text, PVar.BZ_LightSettingPath);
        }
        #endregion

        #region 功能：手动界面功能按钮

        //串口操作
        private void Btn_OpenSerialS2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_OpenSerialS2.Text == "Open")
                {
                    if (this.SerialPort1.IsOpen == false)
                    {
                        this.SerialPort1.Open();
                        WinAPI.Wait(100);
                    }
                    this.SerialPort1.Write(":O000000o" + Constants.vbCrLf);
                    Btn_OpenSerialS2.Text = "Close";
                }
                else
                {
                    if (this.SerialPort1.IsOpen == true)
                    {
                        this.SerialPort1.Write(":O000000o" + Constants.vbCrLf);
                    }
                    Application.DoEvents();
                    this.SerialPort1.Close();
                    Btn_OpenSerialS2.Text = "Open";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM:【" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[46]))) + "】端口不成在，打开失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void Btn_OpenSerialS3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_OpenSerialS3.Text == "Open")
                {
                    if (this.SerialPort2.IsOpen == false)
                    {
                        this.SerialPort2.Open();
                        WinAPI.Wait(100);
                    }
                    this.SerialPort2.Write(":O000000o" + Constants.vbCrLf);
                    Btn_OpenSerialS2.Text = "Close";
                }
                else
                {
                    if (this.SerialPort2.IsOpen == true)
                    {
                        this.SerialPort2.Write(":O000000o" + Constants.vbCrLf);
                    }
                    Application.DoEvents();
                    this.SerialPort2.Close();
                    Btn_OpenSerialS3.Text = "Open";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM:【" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[46]))) + "】端口不成在，打开失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void Btn_SelectMaterial_Click(object sender, EventArgs e)
        {
            Frm_Materiel.fMateriel.ShowDialog();
        }

        #endregion

        #region 功能：同步和Mini系统时间
        private string HeatBt_Time_Elapsed_LocalSystemTime = "";
        private double HeatBt_Time_Elapsed_HeatBtTime = 0;
        private double HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = 0;

        private void HeatBt_Time_Elapsed(object sender, EventArgs e)
        {
            string ErrorCodePath = "";
            ErrorCodePath = "\\\\169.254.0.10\\Workspace\\AlarmFiles";
            if (PVar.ParList.CheckSts[21] == false) //没开启热点功能，直接退出
            {
                return;
            }

            HeatBt_Time.Enabled = false;

            try
            {
                switch (Mod_ErrorCode.CheckSystemTimeStep)
                {
                    case 0:
                        if (System.Convert.ToDouble(API.GetTickCount()) - HeatBt_Time_Elapsed_CheckErrorCodeFolderTime > 10000)
                        {
                            Tcp_HeatBt.StartConnect();
                            HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                            Mod_ErrorCode.CheckSystemTimeStep = 1;
                        }
                        break;

                    case 1:
                        if (System.Convert.ToDouble(API.GetTickCount()) - HeatBt_Time_Elapsed_CheckErrorCodeFolderTime > 1000)
                        {
                            if (Tcp_HeatBt.IsStart == false)
                            {
                                Tcp_HeatBt.StartConnect();
                                HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                                Mod_ErrorCode.CheckSystemTimeStep = 2;
                            }
                            else
                            {
                                HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                                Mod_ErrorCode.CheckSystemTimeStep = 3;
                            }
                        }
                        break;

                    case 2:
                        if (Tcp_HeatBt.IsStart == false)
                        {
                            HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                            Mod_ErrorCode.CheckSystemTimeStep = 5;
                        }
                        else
                        {
                            HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                            Mod_ErrorCode.CheckSystemTimeStep = 3;
                        }
                        break;

                    case 3:
                        System.IO.DirectoryInfo SFile = new System.IO.DirectoryInfo(ErrorCodePath);
                        PVar.HeatBtReceiveStr = "";
                        if (!SFile.Exists)
                        {
                            Tcp_HeatBt.SendData(Encoding.UTF8.GetBytes("Send_HB, BAM," + DateTime.Now.ToString("yyyyMMddHHmmss") + ",0,@"));
                        }
                        else
                        {
                            Tcp_HeatBt.SendData(Encoding.UTF8.GetBytes("Send_HB, BAM," + DateTime.Now.ToString("yyyyMMddHHmmss") + ",1,@"));
                        }
                        HeatBt_Time_Elapsed_LocalSystemTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                        HeatBt_Time_Elapsed_HeatBtTime = System.Convert.ToDouble(API.GetTickCount());
                        Mod_ErrorCode.CheckSystemTimeStep = 4;
                        break;

                    case 4:
                        if (PVar.HeatBtReceiveStr.IndexOf("Ack,@") + 1 != 0)
                        {
                            HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                            Mod_ErrorCode.CheckSystemTimeStep = 0;
                        }
                        else if (PVar.HeatBtReceiveStr.IndexOf(",@") + 1 != 0)
                        {
                            HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                            if (PVar.HeatBtReceiveStr.Length > 15)
                            {
                                PVar.HeatBtReceiveStr = PVar.HeatBtReceiveStr.Substring(4, PVar.HeatBtReceiveStr.Length);
                                Mod_ErrorCode.SystimeSet(HeatBt_Time_Elapsed_LocalSystemTime, Strings.Trim(PVar.HeatBtReceiveStr).Substring(0, 14));
                            }
                            Mod_ErrorCode.CheckSystemTimeStep = 0;
                        }
                        else
                        {
                            if (System.Convert.ToDouble(API.GetTickCount()) - HeatBt_Time_Elapsed_HeatBtTime > 3000)
                            {
                                HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                                Mod_ErrorCode.CheckSystemTimeStep = 5;
                            }
                        }
                        break;

                    case 5:
                        if (System.Convert.ToDouble(API.GetTickCount()) - HeatBt_Time_Elapsed_CheckErrorCodeFolderTime > 30000) //如果网络没有连接则半分钟后继续侦测
                        {
                            HeatBt_Time_Elapsed_CheckErrorCodeFolderTime = System.Convert.ToDouble(API.GetTickCount());
                            Mod_ErrorCode.CheckSystemTimeStep = 0;
                        }
                        break;

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                HeatBt_Time.Enabled = true;
            }

        }

        #endregion

        #region 工程界面机械参数表格处理

        private void Button62_Click(object sender, EventArgs e)
        {
            if (Button62.BackColor == Color.Red)
            {
                DataGridView_par.ReadOnly = true;
                Button62.BackColor = Color.SpringGreen;
            }
            else
            {
                DataGridView_par.ReadOnly = false;
                Button62.BackColor = Color.Red;
            }

        }

        private void DataGridView1_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            // 第1列不能被编辑
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }

        }

        private void DataGridView1_RowHeadersWidthChanged(object sender, EventArgs e)
        {
            DataGridView_par.RowHeadersWidth = 4;
        }
        #endregion

        #region 功能：参数保存
        private void Button61_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("确认保存吗？", (int)Constants.vbInformation + Constants.vbOKCancel, "提示") == Constants.vbOK)
            {
                for (var i = 0; i <= DataGridView_par.RowCount - 1; i++)
                {
                    PVar.ParAxis.Lead[i + 1] = System.Convert.ToDouble(DataGridView_par[1, i].Value);     //丝杠导程
                    PVar.ParAxis.Ratio[i + 1] = System.Convert.ToDouble(DataGridView_par[2, i].Value);    //减速比
                    PVar.ParAxis.pulse[i + 1] = System.Convert.ToDouble(DataGridView_par[3, i].Value);    //每转脉冲
                    PVar.ParAxis.Speed[i + 1] = System.Convert.ToDouble(DataGridView_par[4, i].Value);    //轴速度
                    if (PVar.ParAxis.Speed[i + 1] > 400)
                    {
                        MessageBox.Show(DataGridView_par[0, i].Value + "[" + System.Convert.ToString(PVar.ParAxis.Speed[i + 1]) + "]" + "轴速度设置大于[400]！");
                        ReadParAxis(PVar.ParAxisPath, PVar.ParAxis);
                        for (var j = 0; j <= DataGridView_par.RowCount - 1; j++)
                        {
                            DataGridView_par[4, i].Value = PVar.ParAxis.Speed[i + 1];
                        }

                        return;
                    }
                }
                WriteParAxis(PVar.ParAxisPath, PVar.ParAxis);
                FresshMachinePar();
                DataGridView_par.ReadOnly = true;
                Button62.BackColor = Color.SpringGreen;
                MessageBox.Show("    保存OK！");
            }
        }

        /// <summary>
        /// 把1维参数转换成2维的机械参数
        /// </summary>
        /// <remarks></remarks>
        public void FresshMachinePar()
        {
            for (int i = 1; i <= Tools.Card1OfAxis; i++)
            {
                Tools.LeadLength[0, i] = PVar.ParAxis.Lead[i];
                Tools.GeerRate[0, i] = PVar.ParAxis.Ratio[i];
                Tools.PlusPerR[0, i] = PVar.ParAxis.pulse[i];
                Tools.AxisSpeed[0, i] = PVar.ParAxis.Speed[i];
            }

            for (int i = (Tools.Card1OfAxis + 1); i <= DataGridView_par.RowCount; i++)
            {
                Tools.LeadLength[1, i - Tools.Card1OfAxis] = PVar.ParAxis.Lead[i];
                Tools.GeerRate[1, i - Tools.Card1OfAxis] = PVar.ParAxis.Ratio[i];
                Tools.PlusPerR[1, i - Tools.Card1OfAxis] = PVar.ParAxis.pulse[i];
                Tools.AxisSpeed[1, i - Tools.Card1OfAxis] = PVar.ParAxis.Speed[i];
            }
        }
        /// <summary>
        /// 加载工程界面各轴参数
        /// </summary>
        /// <remarks></remarks>
        private void LoadParAxis()
        {
            for (var i = 0; i <= DataGridView_par.RowCount - 1; i++)
            {
                DataGridView_par[0, i].Value = BVar.Axisname[(int)i];//轴号
                DataGridView_par[1, i].Value = PVar.ParAxis.Lead[i + 1];//丝杠导程
                DataGridView_par[2, i].Value = PVar.ParAxis.Ratio[i + 1];//减速比
                DataGridView_par[3, i].Value = PVar.ParAxis.pulse[i + 1];//每转脉冲
                DataGridView_par[4, i].Value = PVar.ParAxis.Speed[i + 1];//轴速度
            }
            for (int i = 0; i < DataGridView_par.Columns.Count; i++)
            {
                DataGridView_par.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; //设定每一列的排序类型为不排序
            }
        }


        //写DAT二进制文件
        //参数1：文件名(包含文件路径)
        //参数2：需要写入的数据
        private void WriteParAxis(string FileName, PVar.pAxis WriteData)
        {
            int Filenumber = 0;
            try
            {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FilePut(Filenumber, WriteData);
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
            catch
            {
                FileSystem.FileClose(Filenumber); //写入出错关闭当前打开的文件
            }
        }

        //读DAT二进制文件
        //参数1：文件名(包含文件路径)
        //参数2：读取的数据存储地址
        public static void ReadParAxis(string FileName, System.ValueType ReadData)
        {
            int Filenumber = 0;
            try
            {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FileGet(Filenumber, ref ReadData);
                PVar.ParAxis = (PVar.pAxis)ReadData;
                FileSystem.FileClose(Filenumber); //读取完成关闭当前打开的文件
                PVar.IsReadParData = true;
            }
            catch
            {
                FileSystem.FileClose(Filenumber); //读取出错关闭当前打开的文件
            }
        }
        #endregion

        #region 功能：串口口接收数据

        public void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() => { SerialPort1_Received(sender); }));
            }
            catch (Exception)
            { }
        }

        private void SerialPort1_Received(object sender)
        {
            try
            {
                string[] strValue = null;
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadExisting();
                sp.DiscardInBuffer();
                if (indata != "")
                {
                    indata = indata.Replace(":V", ",");
                    strValue = indata.Split(',');
                    PVar.Sta_Work[2].PressValue = Convert.ToDouble(Conversion.Val(strValue.Last()) / 100);
                    this.PressS2_Text.Text = Strings.Format((PVar.Sta_Work[2].PressValue), "0.00");
                    this.Text_ForceS2.Text = this.PressS2_Text.Text;
                    if (PVar.ChangeF)
                    {
                        PVar.Press[0] = PVar.Sta_Work[2].PressValue;
                    }
                    if (PVar.IsCOM1_Working == false)
                    {
                        PVar.IsCOM1_Working = true;
                    }
                    if (PVar.Sta_Work[2].Step == 510 && PVar.Sta_Work[2].PressValue >= PVar.ParList.Data[19])
                    {
                        gts.GT_Stop(0, 1 << 2, 1);
                    }
                }
            }
            catch (Exception)
            { }
        }


        Chart charting;
        public void SetChart(Chart value)
        {
            charting = value;
        }

        public void Update_DataChart()
        {
            List<int> X_label = new List<int>();
            List<double> Y_label = new List<double>();

            int[] xx = new int[150];
            for (int i = PVar.Press.Count() - 1; i > 0; i--)
            {
                X_label.Add(i);
                PVar.Press[i] = PVar.Press[i - 1];
                Y_label.Add(PVar.Press[i]);
            }
            DrawSpline(X_label, Y_label, charting);
        }
        #region 绘制曲线函数
        /// <summary> 
        /// 绘制曲线函数
        /// </summary>
        /// <param name="listX">X值集合</param>
        /// <param name="listY">Y值集合</param>
        /// <param name="chart">Chart控件</param>
        public static void DrawSpline(List<int> listX, List<double> listY, Chart chart)
        {

            try
            {
                //X、Y值成员
                chart.Series[0].Points.DataBindXY(listX, listY);
                chart.Series[0].Points.DataBindY(listY);

                //点颜色
                chart.Series[0].MarkerColor = Color.Green;
                //图表类型  设置为样条图曲线
                chart.Series[0].ChartType = SeriesChartType.FastLine;
                //设置点的大小
                chart.Series[0].MarkerSize = 5;
                //设置曲线的颜色
                chart.Series[0].Color = Color.Blue;
                //设置曲线宽度
                chart.Series[0].BorderWidth = 1;
                //chart.Series[0].CustomProperties = "PointWidth=4";
                //设置是否显示坐标标注
                chart.Series[0].IsValueShownAsLabel = false;

                //设置游标
                chart.ChartAreas[0].CursorX.IsUserEnabled = true;
                chart.ChartAreas[0].CursorX.AutoScroll = true;
                chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                //设置X轴是否可以缩放
                chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                //将滚动条放到图表外
                chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
                // 设置滚动条的大小
                chart.ChartAreas[0].AxisX.ScrollBar.Size = 15;
                // 设置滚动条的按钮的风格，下面代码是将所有滚动条上的按钮都显示出来
                chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                chart.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.SkyBlue;
                // 设置自动放大与缩小的最小量
                chart.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = double.NaN;
                chart.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 1;
                //设置刻度间隔
                chart.ChartAreas[0].AxisX.Interval = 50;
                //将X轴上格网取消
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                //X轴、Y轴标题
                chart.ChartAreas[0].AxisX.Title = "";
                chart.ChartAreas[0].AxisY.Title = "压力（kg）";
                //设置Y轴范围  可以根据实际情况重新修改
                //double max = listY[0];
                //double min = listY[0];
                //foreach (var yValue in listY)
                //    {
                //    if (max < yValue)
                //        {
                //        max = yValue;
                //        }
                //    if (min > yValue)
                //        {
                //        min = yValue;
                //        }
                //    }

                //if (max > 0)
                //    {
                //    chart.ChartAreas[0].AxisY.Maximum = max;
                //    chart.ChartAreas[0].AxisY.Minimum = 0;
                //    chart.ChartAreas[0].AxisY.Interval = (max - 0) / 10;
                //    }
                //else
                //    {
                //    chart.ChartAreas[0].AxisY.Maximum = 10;
                //    chart.ChartAreas[0].AxisY.Minimum = 0;
                //    chart.ChartAreas[0].AxisY.Interval = (10 - 0) / 10;
                //    }

                chart.ChartAreas[0].AxisY.Maximum = 5;
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Interval = (5 - 0) / 10;

                //绑定数据源
                chart.DataBind();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        #endregion

        private void SerialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() => { SerialPort2_Received(sender); }));
            }
            catch (Exception)
            { }
        }

        private void SerialPort2_Received(object sender)
        {
            try
            {
                string[] strValue = null;
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadExisting();
                sp.DiscardInBuffer();
                if (indata != "")
                {
                    indata = indata.Replace(":V", ",");
                    strValue = indata.Split(',');
                    PVar.Sta_Work[3].PressValue = Convert.ToDouble(Conversion.Val(strValue.Last()) / 100);
                    this.PressS3_Text.Text = Strings.Format((PVar.Sta_Work[3].PressValue), "0.00");
                    this.Text_ForceS3.Text = this.PressS3_Text.Text;
                    if (PVar.ChangeF == false)
                    {
                        PVar.Press[0] = PVar.Sta_Work[3].PressValue;
                    }
                    if (PVar.IsCOM2_Working == false)
                    {
                        PVar.IsCOM2_Working = true;
                    }

                    if (PVar.Sta_Work[3].Step == 70 && PVar.Sta_Work[3].PressValue >= PVar.ParList.Data[40])
                    {
                        gts.GT_Stop(0, 1 << 7, 1);
                    }
                }
            }
            catch (Exception)
            { }
        }

        public void SerialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() => { SerialPort3_Received(sender); }));
            }
            catch (Exception)
            { }
        }

        private void SerialPort3_Received(object sender)
        {
            try
            {
                string[] strValue = null;
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadExisting();
                sp.DiscardInBuffer();
                if (indata != "")
                {
                    strValue = indata.Split(',');
                    if (PVar.IsCOM3_Working == false && strValue[1] == "GT")
                    {
                        PVar.IsCOM3_Working = true;
                    }
                }
            }
            catch (Exception)
            { }
        }

        #endregion

        #region 功能：Else

        private void Button3_Click(object sender, EventArgs e)
        {
            Interaction.Shell("explorer E:\\BZ-Data\\PressureData\\", Constants.vbNormalFocus);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Interaction.Shell("explorer E:\\BZ-Data\\BAM\\PDCALog\\" + DateTime.Now.Date.ToString("yyyyMM"), Constants.vbNormalFocus);
        }

        ////禁止编辑，只能选择下拉表格里面内容
        private void ComBox_PosList_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Button_S2_1_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2_2_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2_3_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S3_1_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S3_2_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_1_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_2_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_3_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_4_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_5_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_6_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_7_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_8_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S4_9_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_1_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_2_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_3_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_4_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_5_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_6_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_7_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_8_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_9_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_10_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void Button_S2g_11_Click(object sender, EventArgs e)
        {
            Btn_All_Click(sender, e);
        }

        private void CmdHoldS2_Click(object sender, EventArgs e)
        {
            if (Manual.MotionFlag[2])
            {
                if (Manual.HoldFlag[2])
                {
                    Manual.HoldFlag[2] = false;
                    CmdHoldS2.Text = "暂停";
                    CmdHoldS2.BackColor = Color.BurlyWood;
                    ShowList("运动已继续");
                }
                else
                {
                    Manual.HoldFlag[2] = true;
                    CmdHoldS2.Text = "继续";
                    CmdHoldS2.BackColor = Color.Red;
                    ShowList("运动已暂停");
                }
            }
            else
            {
                ShowList("未运动，暂停无效");
            }
        }

        private void CmdStopS2_Click(object sender, EventArgs e)
        {
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2_X - 1), 1 << (BVar.S2_X - 1)); //当站所有轴紧急停止
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2_Y - 1), 1 << (BVar.S2_Y - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S3_Z - 1), 1 << (BVar.S3_Z - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2_R - 1), 1 << (BVar.S2_R - 1));

            Teach1.Enabled = true;
            Panel1.Enabled = true;

            CommandAutoS2.Enabled = true;

            if (Manual.MotionFlag[2])
            {
                Manual.StopFlag[2] = true;
                Manual.HoldFlag[2] = false;
                CmdHoldS2.Text = "暂停";
                CmdHoldS2.BackColor = Color.BurlyWood;
            }
            ShowList("停止运动");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Sta1Run.StationR_State();
        }


        private void BtnM_B_logo_Click(object sender, EventArgs e)
        {
            Frm_Materiel.fMateriel.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            double OffsetX;
            double OffsetY;
            double OffsetT;
            double OffsetA;

            double tmpX;
            double tmpY;
            double radT;
            double radA;
            double radAT;
            double mPI = 3.1415926535897931;
            double L_Arm = Convert.ToDouble(textBox_mL.Text);

            OffsetT = Convert.ToDouble(textBox_mT.Text);
            OffsetA = Convert.ToDouble(textBox_mA.Text);

            //角度值转弧度值
            radT = OffsetT * mPI / 180;
            radA = OffsetA * mPI / 180;
            radAT = (OffsetA + OffsetT) * mPI / 180;

            //计算位移补偿
            tmpX = -(L_Arm * System.Math.Sin(radAT) - L_Arm * System.Math.Sin(radA));
            tmpY = (L_Arm * (1 - System.Math.Cos(radAT)) - L_Arm * (1 - System.Math.Cos(radA)));

            OffsetX = Convert.ToDouble(textBox_mX.Text) + tmpX;
            OffsetY = Convert.ToDouble(textBox_mY.Text) + tmpY;

            label_mX.Text = "X:" + String.Format(Convert.ToString(OffsetX), "0.000");
            label_mY.Text = "Y:" + String.Format(Convert.ToString(OffsetY), "0.000");
            label_mT.Text = "T:" + String.Format(Convert.ToString(OffsetT), "0.000");
        }

        #endregion

    }
}
