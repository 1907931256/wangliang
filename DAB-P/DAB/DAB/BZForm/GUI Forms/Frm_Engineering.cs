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
using VB = Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;

namespace DAB
    {
    public partial class Frm_Engineering
        {
        public static Frm_Engineering fEngineering = new Frm_Engineering();
        public static event Action<string> ShowList;
        public static event Action<string> AddList; 

        //public static event Action<string> AddList2;
        private object LockConect = new object();
        private object LockBtnRobot = new object();
        private object LockRobotMotion = new object();
        private object LockAutoTimer = new object();

        //串口定义。
        internal System.IO.Ports.SerialPort SerialPort1 = new System.IO.Ports.SerialPort();
        internal System.IO.Ports.SerialPort SerialPort2 = new System.IO.Ports.SerialPort();
        internal System.IO.Ports.SerialPort SerialPort3 = new System.IO.Ports.SerialPort();

        //定时器定义。 


        internal System.Timers.Timer Conect_Time = new System.Timers.Timer() { AutoReset = true, Interval = 3000, Enabled = false };
        internal System.Timers.Timer CT_Time = new System.Timers.Timer() { AutoReset = true, Interval = 10, Enabled = true };
        internal System.Timers.Timer HeatBt_Time = new System.Timers.Timer() { AutoReset = false, Interval = 10, Enabled = false };
        internal System.Timers.Timer Status_Time = new System.Timers.Timer() { AutoReset = true, Interval = 100, Enabled = false };

        internal System.Timers.Timer PDCA_Time = new System.Timers.Timer() { AutoReset = true, Interval = 200, Enabled = false };
        internal System.Windows.Forms.Timer Alarm_Timer = new System.Windows.Forms.Timer() { Interval = 10, Enabled = false };
        internal System.Windows.Forms.Timer Home_Timer = new System.Windows.Forms.Timer() { Interval = 10, Enabled = false };
        internal System.Windows.Forms.Timer Auto_Timer = new System.Windows.Forms.Timer() { Interval = 5, Enabled = false };
        internal System.Windows.Forms.Timer Timer_Calibration = new System.Windows.Forms.Timer() { Interval = 100, Enabled = false };
        internal System.Windows.Forms.Timer AutoLoadCell_Timer = new System.Windows.Forms.Timer() { Interval = 100, Enabled = false };

        public Frm_Engineering()
            {
            InitializeComponent();
            fEngineering = this;
            Init();
            }

        private void Init()
            {
            AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Gg.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Frm_Main.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            GoHome.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Line0Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Line1Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Line2Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Line3Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            Sta4Run.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            LoadPSARun.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            EpsonRobot.AddList += ((s) => { this.infoList1.List_OnAdd(s); });
            PressRun.AddList += ((s) => { this.infoList1.List_OnAdd(s); });

            //AddList2 += ((s) => { this.infoList2.List_OnAdd(s); });
            Calibration.AddList2 += ((s) => { this.infoList2.List_OnAdd(s); });
            Calibration.ClearList2 += ((s) => { this.infoList2.List_OnClear(); });
            CCDTest.AddList2 += ((s) => { this.infoList2.List_OnAdd(s); });
            CCDTest.ClearList2 += ((s) => { this.infoList2.List_OnClear(); });
            PDCA.AddList += ((s) => { this.infoList2.List_OnAdd(s); });
            }

        //刷新状态
        private void Status_Time_Elapsed(object sender, EventArgs e)
            {
            Status_Time.Enabled = false;
            try
                {
                this.BeginInvoke(new Action(() => { StatusTimer_Tick(); }));
                }
            catch (Exception)
                {

                }
            finally
                {
                Status_Time.Enabled = true;
                }
            }

        //网路链接
        private void Conect_Time_Elapsed(object sender, EventArgs e)
            {
            lock (LockConect)
                try
                    {
                    if (Tcp_Robot.IsStart == false)
                        {
                        Tcp_Robot.StartConnect();
                        }

                    if (Tcp_RobotData.IsStart == false)
                        {
                        Tcp_RobotData.StartConnect();
                        }

                    if (Tcp_CCD.IsStart == false)
                        {
                        Tcp_CCD.StartConnect();
                        }

                    if (Tcp_Barcode.IsStart == false)
                        {
                        Tcp_Barcode.StartConnect();
                        }

                    if (Tcp_HeatBt.IsStart == false)
                        {
                        Tcp_HeatBt.StartConnect();
                        }
                    }
                catch (Exception)
                    {

                    }
            }

        #region 功能：变量定义
        public int CCD_Product_Flag;
        private double[] Dis_deviate = new double[6];
        #endregion

        #region 功能：窗体加载
        private void Frm_Engineering_FormClosed(object sender, FormClosedEventArgs e)
            {
            PVar.IsOpenFrmEngineering = false;
            PVar.IsLoadFrmEngineering = false;
            }

        private void Frm_Engineering_Load(object sender, EventArgs e)
            {
            BVar.AxisAlarm = new UMA_dll.LDPF[17] { BVar.AxisAlarm00, BVar.AxisAlarm01, BVar.AxisAlarm02, BVar.AxisAlarm03, BVar.AxisAlarm04, BVar.AxisAlarm05, BVar.AxisAlarm06, BVar.AxisAlarm07, BVar.AxisAlarm08, BVar.AxisAlarm09, BVar.AxisAlarm10, BVar.AxisAlarm11, BVar.AxisAlarm12, BVar.AxisAlarm13, BVar.AxisAlarm14, BVar.AxisAlarm15, BVar.AxisAlarm16 };
            //BVar.EMC_Stop = new UMA_dll.LDPF[2] { BVar.EMC_Stop01, BVar.EMC_Stop02 };
            //Label[] tempLab = new Label[4] { this.Label_Sta1, this.Label_Sta4, this.Label_Sta3, this.Label_Sta2 };
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Color.White;
            //TabPage_LightControl.Parent = null; //隐藏光源控制界面

            ComboBox_Cam2.SelectedIndex = 0;
            Combo_Robot_Pos.SelectedIndex = 0;
            ChangeLorR();

            //初始化串口
            FunctionSub.Init_Serial1();
            FunctionSub.Init_Serial2();
            FunctionSub.Init_Serial3();
            LoadParAxis();
            FresshMachinePar();

            Winsock_Init();

            GoHome.AxisGoHome.State = true;

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
            //网络状态事件
            this.Tcp_CCD.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_CCD_StateInfo);
            this.Tcp_Robot.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_Robot_StateInfo);
            this.Tcp_RobotData.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_RobotData_StateInfo);
            this.Tcp_HeatBt.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_HeatBt_StateInfo);
            this.Tcp_PDCA.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_PDCA_StateInfo);
            this.Tcp_Barcode.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(this.TcpClient_Barcode_StateInfo);

            //网络接收事件
            this.Tcp_Robot.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockRobot_DataArrival);
            this.Tcp_RobotData.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockRobotData_DataArrival);
            this.Tcp_CCD.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockCCD_DataArrival);
            this.Tcp_HeatBt.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockHeatBt_DataArrival);
            this.Tcp_PDCA.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockPDCA_DataArrival);
            this.Tcp_Barcode.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(this.WinsockBarcode_DataArrival);

            this.Status_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.Status_Time_Elapsed);
            this.Conect_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.Conect_Time_Elapsed);
            this.HeatBt_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.HeatBt_Time_Elapsed);
            this.CT_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.CT_Time_Elapsed);

            this.PDCA_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.PDCA_Time_Elapsed);

            this.Alarm_Timer.Tick += new System.EventHandler(this.Alarm_Timer_Tick);
            this.Home_Timer.Tick += new System.EventHandler(this.Home_Timer_Tick);
            this.Auto_Timer.Tick += new System.EventHandler(this.Auto_Timer_Tick);
            this.Timer_Calibration.Tick += new System.EventHandler(this.Timer_Calibration_Tick);
            this.SerialPort1.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            this.SerialPort2.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort2_DataReceived);
            this.SerialPort3.DataReceived += new SerialDataReceivedEventHandler(this.SerialPort3_DataReceived);

            Alarm_Timer.Enabled = true;
            }
        #endregion

        #region 功能：网口加载
        private void Winsock_Init()
            {
            try
                {
                //机械手网络
                this.Tcp_Robot.ServerIp = "192.168.0.1"; //设置远程IP
                this.Tcp_Robot.ServerPort = Int16.Parse("2000"); //设置远程port
                this.Tcp_Robot.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                this.Tcp_RobotData.ServerIp = "192.168.0.1"; //设置远程IP
                this.Tcp_RobotData.ServerPort = Int16.Parse("2001"); //设置远程port
                this.Tcp_RobotData.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //CCD1网络
                this.Tcp_CCD.ServerIp = "127.0.0.1"; //设置远程IP
                this.Tcp_CCD.ServerPort = Int16.Parse("5001"); //设置远程port
                this.Tcp_CCD.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连


                //Barcode网络
                this.Tcp_Barcode.ServerIp = "192.168.10.55"; //设置远程IP
                this.Tcp_Barcode.ServerPort = Int16.Parse("10000"); //设置远程port
                this.Tcp_Barcode.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

                //PDCA网络
                this.Tcp_PDCA.ServerIp = "169.254.1.10"; //设置远程IP
                this.Tcp_PDCA.ServerPort = Int16.Parse("1111"); //设置远程port
                this.Tcp_PDCA.IsReconnection = false; //设置是否自动重连，true自动重连，反之不重连

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
            if (Tcp_Robot.IsStart && Tcp_RobotData.IsStart)
            {
                this.Lab_Robot_Sts.BackColor = PVar.BZColor_SelectedBtn;
            }
            else
            {
                this.Lab_Robot_Sts.BackColor = PVar.BZColor_ErrorRed;
            }
        }
        private void TcpClient_RobotData_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            if ((int)iState.State == 1)
            {
                Tcp_RobotData.IsStart = true;
            }
            else
            {
                Tcp_RobotData.IsStart = false;
            }
            if (Tcp_Robot.IsStart && Tcp_RobotData.IsStart)
            {
                this.Lab_Robot_Sts.BackColor = PVar.BZColor_SelectedBtn;
            }
            else
            {
                this.Lab_Robot_Sts.BackColor = PVar.BZColor_ErrorRed;
            }
        }
        private void TcpClient_CCD_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
            {
            if ((int)iState.State == 1)
                { 
                Tcp_CCD.IsStart = true;
                this.Lab_CCD_Sts.BackColor = PVar.BZColor_SelectedBtn;
                }
            else
                {
                Tcp_CCD.IsStart = false;
                this.Lab_CCD_Sts.BackColor = PVar.BZColor_ErrorRed;
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
                this.Lab_PDCA_Sts.BackColor = PVar.BZColor_SelectedBtn;
                }
            else
                {
                Tcp_PDCA.IsStart = false;
                this.Lab_PDCA_Sts.BackColor = PVar.BZColor_ErrorRed;
                }
            }

        private void TcpClient_Barcode_StateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
            {
            if ((int)iState.State == 1)
                {
                Tcp_Barcode.IsStart = true;
                this.Lab_Barcode_Sts.BackColor = PVar.BZColor_SelectedBtn;
                }
            else
                {
                Tcp_Barcode.IsStart = false;
                this.Lab_Barcode_Sts.BackColor = PVar.BZColor_ErrorRed;
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

            this.Txt_PalletNum.Text = BVar.FileRorW.ReadINI("Material_index ", "Display", "1", PVar.PublicParPath);
            PVar.Tray.MaterialCnt = int.Parse(this.Txt_PalletNum.Text);
            this.Txt_PalletSelectNum.Text = this.Txt_PalletNum.Text;

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
            this.Btn_L1Z1.BackColor = (Gg.GetDo(0, 12)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Btn_L2Z1.BackColor = (Gg.GetDo(0, 13)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Btn_L3Z1.BackColor = (Gg.GetDo(0, 13)) == 1 ? Color.LightGreen : Color.WhiteSmoke;

            this.Button_J_1.BackColor = (Gg.GetDo(0, 9)) == 1 ? Color.Gold : Color.WhiteSmoke;

            this.Button_X_1.BackColor = (Gg.GetExDo(1, 4)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_X_2.BackColor = (Gg.GetExDo(1, 6)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_X_3.BackColor = (Gg.GetExDo(1, 8)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_X_4.BackColor = (Gg.GetExDo(1, 10)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_X_5.BackColor = (Gg.GetExDo(1, 0)) == 1 ? Color.Khaki : Color.WhiteSmoke;
            this.Button_X_6.BackColor = (Gg.GetExDo(1, 2)) == 1 ? Color.Khaki : Color.WhiteSmoke;

            this.Button_P_1.BackColor = (Gg.GetExDo(1, 5)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_P_2.BackColor = (Gg.GetExDo(0, 7)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_P_3.BackColor = (Gg.GetExDo(0, 9)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_P_4.BackColor = (Gg.GetExDo(0, 11)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_P_5.BackColor = (Gg.GetExDo(1, 1)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;
            this.Button_P_6.BackColor = (Gg.GetExDo(1, 3)) == 1 ? Color.LightSalmon : Color.WhiteSmoke;

            this.Button_O_1.BackColor = (Gg.GetExDo(0, 0)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_2.BackColor = (Gg.GetExDo(0, 4)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_3.BackColor = (Gg.GetExDo(0, 5)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_4.BackColor = (Gg.GetExDo(0, 6)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_5.BackColor = (Gg.GetExDo(0, 14)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_6.BackColor = (Gg.GetExDo(1, 14)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_7.BackColor = (Gg.GetExDo(1, 15)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_8.BackColor = (Gg.GetExDo(0, 12)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_9.BackColor = (Gg.GetExDo(0, 8)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_10.BackColor = (Gg.GetExDo(0, 10)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_11.BackColor = (Gg.GetExDo(0, 2)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_12.BackColor = (Gg.GetExDo(2, 11)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
            this.Button_O_13.BackColor = (Gg.GetExDo(2, 13)) == 1 ? Color.LightGreen : Color.WhiteSmoke;
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
                    this.Txt_PalletNum.Text = BVar.FileRorW.ReadINI("Material_index ", "Display", "1", PVar.PublicParPath);
                    PVar.Tray.MaterialCnt = Int32.Parse(this.Txt_PalletNum.Text);
                    this.Txt_PalletSelectNum.Text = this.Txt_PalletNum.Text;
                    break;
                }
            }


        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e) //I/O输出界面 和 手动调试界面 进入跳转管理
            {
            TabControl3.Enabled = false; //输出界面
            TabControl4.Enabled = false; //手动调试界面
            PVar.IsOpenFrmManual = false;
            TabControl4.SelectedIndex = 0;
            TabControl5.SelectedIndex = 0;
            Frm_Engineering.fEngineering.机械参数.Parent = null;
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
                    InputClass4.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
                    OutputClass4.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    Frm_Login.fLogin.Close();
                    FunctionSub.Close_NumberKey_Process();
                    //--------------------------------------------
                    this.Txt_PalletNum.Text = BVar.FileRorW.ReadINI("Material_index ", "Display", "1", PVar.PublicParPath);
                    PVar.Tray.MaterialCnt = Int32.Parse(this.Txt_PalletNum.Text);
                    this.Txt_PalletSelectNum.Text = this.Txt_PalletNum.Text;
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
                    InputClass4.Timer.Enabled = true;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
                    OutputClass4.Timer.Enabled = false;
                    Frm_Login.fLogin.Close();
                    FunctionSub.Close_NumberKey_Process();
                    break;

                case 2:
                    if (Manual.MotionFlag[0] == true || Manual.MotionFlag[2] == true || Manual.MotionFlag[3] == true || Manual.MotionFlag[4] == true || (GoHome.Reset.State == false && PVar.Sta_Work[0].State == false && PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false))
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
                    Auto_Timer.Enabled = false;

                    Teach1.Timer.Enabled = false;
                    Teach2.Timer.Enabled = false;
                    Teach3.Timer.Enabled = false;
                    Teach4.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = true;
                    OutputClass2.Timer.Enabled = true;
                    OutputClass3.Timer.Enabled = true;
                    OutputClass4.Timer.Enabled = true;
                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    InputClass4.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    break;

                case 3:
                    if (Manual.MotionFlag[0] == true || Manual.MotionFlag[2] == true || Manual.MotionFlag[3] == true || Manual.MotionFlag[4] == true || (GoHome.Reset.State == false && PVar.Sta_Work[0].State == false && PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false))
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
                    this.Txt_PalletNum.Text = BVar.FileRorW.ReadINI("Material_index ", "Display", "1", PVar.PublicParPath);
                    PVar.Tray.MaterialCnt = Int32.Parse(this.Txt_PalletNum.Text);
                    this.Txt_PalletSelectNum.Text = this.Txt_PalletNum.Text;

                    Auto_Timer.Enabled = false;
                    Teach1.Timer.Enabled = true;
                    Teach2.Timer.Enabled = true;
                    Teach3.Timer.Enabled = true;
                    Teach4.Timer.Enabled = true;
                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = false;
                    MotorStatus2.Timer.Enabled = false;
                    OutputClass1.Timer.Enabled = false;
                    OutputClass2.Timer.Enabled = false;
                    OutputClass3.Timer.Enabled = false;
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
                    break;
                case 1:
                    InputClass1.Timer.Enabled = false;
                    InputClass2.Timer.Enabled = false;
                    InputClass3.Timer.Enabled = false;
                    MotorStatus1.Timer.Enabled = true;
                    MotorStatus2.Timer.Enabled = true;
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
            try
                {
                if (Line1Run.CT_Start == true)
                    {
                    this.BeginInvoke(new Action(() => { CT_Count(); }));
                    }
                }
            catch (Exception) { }
            }
        private void CT_Count()
            {
            PVar.StorCycleTimer = Convert.ToDouble((API.GetTickCount() - PVar.StaTime[0]) / 1000.0); //系统周期时间
            Cycle.Text = PVar.StorCycleTimer.ToString("0.00");
            if (PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false && PVar.Sta_Work[4].State == false)
                {
                BVar.ProData[4, 3] = Frm_Engineering.fEngineering.Cycle.Text;//周期时间
                Line1Run.CT_Start = false;
                }
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
        private void BtnRobot_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            int mCardType = 0;
            int mCardNum = 0;
            int mMdl = 0;
            int mIndex = 0;
            string[] tmpArray = null;
            lock (LockBtnRobot)
                btn.BackColor = Color.LightGreen;
            mCardType = btn.TabIndex;
            tmpArray = Strings.Split(Strings.Mid(System.Convert.ToString(btn.Tag), 2, btn.Tag.ToString().Length - 2), ",", -1);
            mCardNum = System.Convert.ToInt32(tmpArray[0]);
            mMdl = System.Convert.ToInt32(tmpArray[1]);
            mIndex = System.Convert.ToInt32(tmpArray[2]);
            Gg.SetDo(0, mIndex, 1);
            WinAPI.Wait(200);
            Gg.SetDo(0, mIndex, 0);
            btn.BackColor = System.Drawing.SystemColors.Menu;
            }

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
            if (btn.TabIndex == 1 && mMdl == 0 && mIndex == 2)//保压气缸双头电磁阀
                {
                //if (GoHome.AxisHome[0, 4].Result == false)
                //    {
                //    ShowList("保压Z轴没有回原点，气缸运动可能撞机！");
                //    return;
                //    }
                if (Gg.GetHomeDi(0, 4) == 0)
                    {
                    ShowList("保压Z轴不在安全高度，禁止气缸运动！");
                    return;
                    }

                if (Frm_Engineering.fEngineering.Tcp_RobotData.IsStart == false )//判断机械手是否在流水线外
                    {
                    ShowList("请先确认机械手网络，无法确认位置状态！");
                    return;
                    }

                if ( EpsonRobot.RobotLivePos.Y < -150)//判断机械手是否在流水线外
                    {
                    ShowList("请先把机械移开，或工程师更改安全位置！");
                    return;
                    }

                if (!(Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 0 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 1))
                    {
                    ShowList("光源旋转气缸不在缩回状态或请检测信号异常！");
                    return;
                    }

                if (Gg.GetExDo(0, 2) == 1)
                    {
                    Gg.SetExDo(0, 0, 2, 0);
                    Gg.SetExDo(0, 0, 3, 1);
                    }
                else
                    {
                    Gg.SetExDo(0, 0, 2, 1);
                    Gg.SetExDo(0, 0, 3, 0);
                    }
                }
            else if (btn.TabIndex == 1 && mMdl == 0 && mIndex == 14)
                {
                if (!(Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 0 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 1))
                    {
                    ShowList("保压无杆气缸不在右侧或请检测信号异常！");
                    return;
                    }

                if (Frm_Engineering.fEngineering.Tcp_RobotData.IsStart == false)//判断机械手是否在流水线外
                    {
                    ShowList("请先确认机械手网络，无法确认位置状态！");
                    return;
                    }

                if (EpsonRobot.RobotLivePos.Y < -150)//判断机械手是否在流水线外
                    {
                    ShowList("请先把机械移开，或工程师更改安全位置！");
                    return;
                    }
                mFunction.NSetDO(mCardType, mCardNum, mMdl, mIndex);
                }
            else if (btn.TabIndex == 1 && mMdl == 2 && mIndex == 11)
                {
                if (Gg.GetExDo(2, 11) == 1)
                    {
                    Gg.SetExDo(0, 2, 11, 0);
                    Gg.SetExDo(0, 2, 12, 1);
                    }
                else
                    {
                    Gg.SetExDo(0, 2, 11, 1);
                    Gg.SetExDo(0, 2, 12, 0);
                    }
                }
            else if (btn.TabIndex == 1 && mMdl == 2 && mIndex == 13)
                {
                if (Gg.GetExDo(2, 13) == 1)
                    {
                    Gg.SetExDo(0, 2, 13, 0);
                    Gg.SetExDo(0, 2, 14, 1);
                    }
                else
                    {
                    Gg.SetExDo(0, 2, 13, 1);
                    Gg.SetExDo(0, 2, 14, 0);
                    }
                }
            else
                {
                mFunction.NSetDO(mCardType, mCardNum, mMdl, mIndex);
                }
            //Fressh_ManualBtn();
            }
        #endregion

        #region 功能：手动界面CCD按钮


        private void CCD_Trigger_Click(object sender, EventArgs e)
            { 
            int watchTime = 0;
            if (Tcp_CCD.IsStart == false)
                {
                ShowList("CCD通信连接异常，请确认！");
                return;
                }
            CCD_Trigger.Enabled = false;
            switch (this.ComboBox_Cam2.SelectedIndex)
                {
                case 0:
                    Command.TCP_CCD_Send(Command.取料PSA拍照, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.取料PSA拍照 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 1:
                    Command.TCP_CCD_Send(Command.PSA定位拍照, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.PSA定位拍照 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 2:
                    Command.TCP_CCD_Send(Command.装配PSA拍照, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.装配PSA拍照 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 3:
                    Command.TCP_CCD_Send(Command.取Display拍照, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.取Display拍照 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 4:
                    Command.TCP_CCD_Send(Command.Display定位拍照, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.Display定位拍照 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 5:
                    Command.TCP_CCD_Send(Command.装配Display拍照, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.装配Display拍照 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 6:
                    Command.TCP_CCD_Send(Command.上相机复检, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.上相机复检 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                case 7:
                    Command.TCP_CCD_Send(Command.下相机复检, PVar.SN);
                    watchTime = System.Convert.ToInt32(API.GetTickCount());
                    do
                        {
                        Thread.Sleep(5);
                        if (System.Convert.ToInt32(API.GetTickCount()) - watchTime > 3000)
                            {
                            ShowList("接收" + Command.下相机复检 + "数据超时！");
                            break;
                            }
                        Application.DoEvents();
                        } while (!(PVar.CCD_StrData != ""));
                    TextBox_CCD.Text = PVar.CCD_StrData;
                    CCD_Trigger.Enabled = true;
                    break;

                }
            }
        #endregion

        #region 功能：设备开始初始化
        public void MacReset()
            {
            //清空界面的条码
            Lab_Station1.Text = "";
            Lab_Station2.Text = "";
            Lab_Station3.Text = "";
            Txt_BarCode.Text = "";

            if (Tcp_PDCA.IsStart == false)
                {
                Tcp_PDCA.StopConnect();
                }

            for (int i = 1; i <= 8; i++) //所有轴回原点步序号清0
                {
                GoHome.AxisHome[0, i].Step = 0;
                GoHome.AxisHome[0, i].Result = false;
                }

            if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1)
                {
                AddList("急停按钮被按下,请检查!");
                ShowList("急停按钮被按下,请检查!");
                return;
                }

            Gg.SetDo(0, Gg.OutPut0.机械手停止, 1);
            WinAPI.Wait(100);
            Gg.SetDo(0, Gg.OutPut0.机械手停止, 0);

            if (Gg.GetDi(0, Gg.InPut0.正气压信号侦测) == 0)
                {
                AddList("正压检测异常，请检查！");
                ShowList("正压检测异常，请检查！");
                return;
                }

            if (Gg.Get_AlarmDi(0, Gg.InAlarm0.PSA搬运Y轴) == 1)
                {
                AddList("PSA搬运Y轴伺服报警!");
                ShowList("PSA搬运Y轴伺服报警!");
                return;
                }
 
            //检查安全门
            if (PVar.ParList.CheckSts[1])
                {
                string tempStr = "";
                if (Gg.GetDi(0, Gg.InPut0.安全门) == 0)
                    {
                    tempStr = "安全门";
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
            InputClass4.Timer.Enabled = false;
            OutputClass1.Timer.Enabled = false;
            OutputClass2.Timer.Enabled = false;
            OutputClass3.Timer.Enabled = false;
            MotorStatus1.Timer.Enabled = false;
            MotorStatus2.Timer.Enabled = false;

            //打开所轴有使能
            Gg.SetDo(0, Gg.OutPut0.步进电机使能, 0);//打开所有步进使能
            if (Gg.Set_AllServoON(0, 1, 8) == false)//只有8轴是伺服
                {
                return;
                }

            for (int i = 0; i <= 10; i++)
                {
                PVar.Sta_Work[i].State = false;
                PVar.Sta_Work[i].IsHaveFix = false;
                PVar.Sta_Work[i].Step = 0;
                }

            //清空缓存里面数据
            BVar.InitProData();
            PVar.Autorun.Enable = false;
            EpsonRobot.IsRobotAlarm = false;
            PVar.IsSysEmcStop = false;
            Frm_Main.fMain.Btn_Start.Enabled = false;
            Frm_Main.fMain.Btn_Stop.Enabled = false;
            PVar.Stop_Flag = false;
            this.Home_Timer.Enabled = true;
            GoHome.StepHome = 10;
            }

        private void Home_Timer_Tick(object sender, EventArgs e)
            {
            Home_Timer.Enabled = false;
            if (Gg.GetDi(0, Gg.InPut0.正气压信号侦测) == 0)
                {
                AddList("正压检测异常，请检查！");
                ShowList("正压检测异常，请检查！");
                Frm_Engineering.fEngineering.MacStop();
                return;
                }

            GoHome.HomeSub();
   
            if (GoHome.Reset.State)
                {
                Home_Timer.Enabled = true;
                }
            else
                {
                Home_Timer.Enabled = false;
                }
            }

        //private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        //    {
        //GoHome.AxisGoHome.State = true;
        //    }
        #endregion

        #region 功能：自动运行
        public void Auto_Assemble()
            {
            Frm_Main.fMain.Btn_Start.Enabled = false;
            if (PVar.ParList.CheckSts[1] && PVar.Stop_Flag == false)
                {
                string tempStr = "";
                if (Gg.GetDi(0, Gg.InPut0.安全门) == 0)
                    {
                    tempStr = "安全门";
                    }

                if (!string.IsNullOrEmpty(tempStr))
                    {
                    AddList("请关闭" + tempStr);
                    ShowList("请关闭" + tempStr);
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    return;
                    }
                }
            
            if (PVar.Sta_Work[0].State || PVar.Sta_Work[1].State || PVar.Sta_Work[2].State || PVar.Sta_Work[3].State
                || PVar.Sta_Work[4].State || PVar.Sta_Work[5].State || PVar.Sta_Work[6].State || PVar.Sta_Work[7].State
                || PVar.Sta_Work[8].State || PVar.Sta_Work[9].State || PVar.Sta_Work[10].State)   //PVar.AutoRunFlag
                {
                AddList("设备运行中…");
                ShowList("设备运行中…");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
                }

            //打开所轴有使能
            Gg.SetDo(0, Gg.OutPut0.步进电机使能, 0);//打开所有步进使能
            if (Gg.Set_AllServoON(0, 1, 8) == false)
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

            if (PVar.IsOpenFrmManual)
                {
                AddList("手动调试界面打开中…请先关闭！");
                ShowList("手动调试界面打开中…请先关闭！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
                }
            Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;

            for (int i = 0; i <= 10; i++)
                {
                PVar.Sta_Work[i].StaHold = false;
                }

            for (short j = 4; j <= 8; j++)
                {
                if (Gg.ZSPD(0, j) == false)
                    {
                    ShowList(BVar.Axisname[j - 1] + "轴伺服正在运动中…");
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    return;
                    }
                }

            if (Tcp_CCD.IsStart == false && PVar.ParList.CheckSts[17] == false)
                {
                AddList("CCD网络通讯异常！");
                ShowList("CCD网络通讯异常！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
                }

            if (Tcp_Robot.IsStart == false)
                {
                AddList("机械手网络通讯异常！");
                ShowList("机械手网络通讯异常！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
                }

            if (Tcp_RobotData.IsStart == false)
                {
                AddList("机械手压力网络通讯异常！");
                ShowList("机械手压力网络通讯异常！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
                }

            if (Tcp_Barcode.IsStart == false && PVar.ParList.CheckSts[17] == false)
                {
                AddList("条码枪网络通讯异常！");
                ShowList("条码枪网络通讯异常！");
                Frm_Main.fMain.Btn_Start.Enabled = true;
                return;
                }

            Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, "20", "0", "0", "0", "0", "0", "0", "", "0", "0", "0", "20");

         
            int iTime = System.Convert.ToInt32(API.GetTickCount());
            do
                {
                Thread.Sleep(10);
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 10000 & Gg.GetDi(0, 2) == 0 & Gg.GetDi(0, 3) == 0)
                    {
                    break;//运行完成退出
                    }
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 10000 & (Gg.GetDi(0, 4) == 1 || Gg.GetDi(0, 1) == 0))
                    {
                    AddList("机械手回待机位置超时！");
                    ShowList("机械手回待机位置超时！");
                    return;
                    }
                Application.DoEvents();
                } while (EpsonRobot.sRobot_Status != "Step" + RobotPosName.待机位置);

            Teach1.Timer.Enabled = false;
            Teach2.Timer.Enabled = false;
            Teach3.Timer.Enabled = false;
            Teach4.Timer.Enabled = false;

            InputClass1.Timer.Enabled = false;
            InputClass2.Timer.Enabled = false;
            InputClass3.Timer.Enabled = false;
            InputClass4.Timer.Enabled = false;
            OutputClass1.Timer.Enabled = false;
            OutputClass2.Timer.Enabled = false;
            OutputClass3.Timer.Enabled = false;
            OutputClass4.Timer.Enabled = false;
            MotorStatus1.Timer.Enabled = false;
            MotorStatus2.Timer.Enabled = false;
            TabPage3.Parent = null;
            TabPage4.Parent = null;

            PVar.AutoRunFlag = true;
            PVar.Autorun.Enable = true;

            //按钮
            Frm_Main.fMain.Btn_Start.Enabled = false;
            Frm_Main.fMain.Btn_Pause.Enabled = true;
            Frm_Main.fMain.Btn_Stop.Enabled = true;
            Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_SelectedBtn; ////运行按钮
            Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;

            for (int i = 0; i <= 10; i++)
                {
                PVar.TimeStart[i] = System.Convert.ToInt64(API.GetTickCount());
                if (PVar.Sta_Work[i].Step == 0)
                    {
                    PVar.Sta_Work[i].Step = 10;
                    }
                }

            this.CT_Time.Enabled = true;
            PVar.MacHold = false;
            PVar.Stop_Flag = false;
            if (PVar.ParList.CheckSts[17])
                {
                PVar.LampStatus = 40;
                }
            else
                {
                PVar.LampStatus = 30;
                }

            Auto_Timer.Enabled = true; //自动运行开始
            AddList("设备进入自动运行中…");
            }
        #endregion

        #region 功能：设备状态更新定时器
        private void StatusTimer_Tick()
            {
                if (PVar.Sta_Work[(int)BVar.工位.机械手].Step < 1000)
                {
                this.Btn_SelectMaterial.Enabled = true;
                }

            if (PVar.ParList.CheckSts[1] && PVar.Stop_Flag == false && PVar.MacHold == false)
                {
                string tempStr = "";
                if (Gg.GetDi(0, Gg.InPut0.安全门) == 0)
                    {
                    tempStr = "安全门";
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

            //流水线中的光纤感应刷新
            this.Box_InL.BackColor = (Gg.GetDi(0, 10) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn; //左侧接近
            this.Box_InR.BackColor = (Gg.GetDi(0, 11) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn; //右侧接近

            this.Box_InL1.BackColor = (Gg.GetExDi(1, 7) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射1
            this.Box_InL2.BackColor = (Gg.GetExDi(1, 8) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射2
            this.Box_InL3.BackColor = (Gg.GetExDi(1, 9) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射3
            this.Box_InL4.BackColor = (Gg.GetExDi(1, 10) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射4
            this.Box_InL5.BackColor = (Gg.GetExDi(1, 11) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射5

            this.Box_InR1.BackColor = (Gg.GetExDi(1, 7) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射1
            this.Box_InR2.BackColor = (Gg.GetExDi(1, 8) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射2
            this.Box_InR3.BackColor = (Gg.GetExDi(1, 9) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射3
            this.Box_InR4.BackColor = (Gg.GetExDi(1, 10) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射4
            this.Box_InR5.BackColor = (Gg.GetExDi(1, 11) == 1) ? PVar.BZColor_SelectedBtn : PVar.BZColor_UnselectedBtn;//对射5

            this.Lab_EMG_Sts.BackColor = PVar.IsSysEmcStop == false ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //急停按钮指示信号
            this.Lab_Safe_Sts.BackColor = Gg.GetDi(0, 6) == 1 ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //安全门信号

            this.Lab_Robot_ASts.BackColor = Gg.GetDi(0, 4) == 0 ? Color.WhiteSmoke : PVar.BZColor_ErrorRed; //机械手报警
            this.Label_Rbt4.BackColor = Gg.GetDi(0, 4) == 0 ? Color.White : PVar.BZColor_ErrorRed; //机械手报警
            this.Label_Rbt1.BackColor = Gg.GetDi(0, 1) == 0 ? Color.White : PVar.BZColor_SelectedBtn; //机械手准备好
            this.Label_Rbt3.BackColor = Gg.GetDi(0, 3) == 0 ? Color.White : PVar.BZColor_SelectedBtn; //机械手准暂停中
            this.Label_Rbt2.BackColor = Gg.GetDi(0, 2) == 0 ? Color.White : PVar.BZColor_SelectedBtn; //机械手准运动中

            this.Lab_LC1_Sts.BackColor = this.SerialPort1.IsOpen == true ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //压力传感器串口是否打开
            this.Lab_LC2_Sts.BackColor = this.SerialPort2.IsOpen == true ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //压力传感器串口是否打开
            this.Lab_Air_Sts.BackColor = Gg.GetDi(0, 5) == 1 ? PVar.BZColor_SelectedBtn : PVar.BZColor_ErrorRed; //正气压信号

            //更新步序号
            Lab_HomeStep.Text = "Home：" + System.Convert.ToString(GoHome.StepHome); //回原点
            this.Lab_Line0Step.Text = "Start：" + Convert.ToString(PVar.Sta_Work[0].Step);//启动

            this.Lab_RobotStep.Text = "Robot：" + Convert.ToString(PVar.Sta_Work[1].Step);//机械手
            this.Lab_DIS_LStep.Text = "Left：" + Convert.ToString(PVar.Sta_Work[2].Step);//左供料仓
            this.Lab_DIS_RStep.Text = "Rirht：" + Convert.ToString(PVar.Sta_Work[3].Step);//右供料仓
            this.Lab_PSAStep.Text = "PSA：" + Convert.ToString(PVar.Sta_Work[4].Step);//PSA供料
            this.Lab_PressStep.Text = "Press：" + Convert.ToString(PVar.Sta_Work[5].Step);//保压


            Lab_Line1Step.Text = "L1：" + Convert.ToString(PVar.Sta_Work[7].Step);
            Lab_Line2Step.Text = "L2：" + Convert.ToString(PVar.Sta_Work[8].Step);
            Lab_Line3Step.Text = "L3：" + Convert.ToString(PVar.Sta_Work[9].Step);

            if (PVar.WorkMode == 1)
                {
                Label_CPK.Text = "CPK：" + System.Convert.ToString(PVar.CPKDoneCounts) + "/32";
                Frm_Main.fMain.Lab_CpkCount.Text = PVar.CPKDoneCounts + "/32";
                }

            this.Label_PDCA_Step.Text = PDCA.UpLoadStep.ToString();
            }
        #endregion

        #region 功能：报警处理
        private void Alarm_Timer_Tick(object sender, EventArgs e)
            {
            Alarm_Timer.Enabled = false;

            if (BVar.EMC_Stop.LDP(Gg.GetDi(0, Gg.InPut0.急停按钮)))
                {
                MacStop();
                AddList("急停按钮被触发！");
                ShowList("急停按钮被触发！");
                }

            if (BVar.EMC_Stop.LDF(Gg.GetDi(0, Gg.InPut0.急停按钮)))
            {
                MacStop();
                AddList("急停按钮已解除！");
                ShowList("急停按钮已解除！");
                PVar.IsSysEmcStop = false;
            }

            if (BVar.RobotAlarm.LDP(Gg.GetDi(0, Gg.InPut0.机械手报警)))
                {
                AddList("机械手报警！");
                ShowList("机械手报警！");
                EpsonRobot.IsRobotAlarm = true;
                }
            else if (BVar.EMC_Stop.LDF(Gg.GetDi(0, Gg.InPut0.急停按钮)))
                {
                if (Gg.GetDi(0, Gg.InPut0.机械手报警) == 1)
                    {
                    Gg.SetDo(0, Gg.OutPut0.机械手复位, 1);
                    WinAPI.Wait(50);
                    Gg.SetDo(0, Gg.OutPut0.机械手复位, 0);
                    EpsonRobot.IsRobotAlarm = false;
                    }
                }

            if (GoHome.Reset.Result && PVar.Autorun.Enable)
                {
                WatchLimitAlarm(); //监控正负极限
                }

            if ((GoHome.Reset.State || PVar.Autorun.Enable) && BVar.InPutAir.LDF(Gg.GetDi(0, Gg.InPut0.正气压信号侦测)))
                {
                MacStop();
                AddList("正压检测异常！");
                ShowList("正压检测异常！");
                }

            Alarm_Timer.Enabled = true;
            }

        private void WatchAxisAlarm()
            {
            for (short i = 0; i <= 8; i++)
                {
                if (BVar.AxisAlarm[8].LDP(Gg.Get_AlarmDi(i / 8, (i % 8) + 1)))
                    {
                    ShowList(BVar.Axisname[i] + "伺服报警!");
                    MacStop();
                    return;
                    }
                }
            }

        private void WatchLimitAlarm()
            {
            if (GoHome.Reset.Result)
                {
                if (PVar.IsSysEmcStop == false)
                    {
                    for (short i = 0; i <= 8; i++)
                        {
                        if (GoHome.AxisHome[i / 8, i % 8 + 1].Result)
                            {
                            if (Gg.GetLimitDi_Z(System.Convert.ToInt16(i / 8), (short)(i % 8 + 1)) == 1)
                                {
                                MacStop();
                                for (short j = 0; j <= 8; i++)
                                    {
                                    gts.GT_Stop(Convert.ToInt16(j / 8), 1 << ((short)(j % 8 + 1) - 1), 0);
                                    }
                                ShowList(BVar.Axisname[i - 1] + "触发正极限报警!");
                                break;
                                }
                            if (Gg.GetLimitDi_F(System.Convert.ToInt16(i / 8), (short)(i % 8 + 1)) == 1)
                                {
                                MacStop();
                                for (short j = 0; j <= 8; j++)
                                    {
                                    gts.GT_Stop(Convert.ToInt16(j / 8), 1 << ((short)(j % 8 + 1) - 1), 0);
                                    }
                                ShowList(BVar.Axisname[i - 1] + "触发负极限报警!");
                                break;
                                }
                            }
                        }
                    }
                }
            }

        public void MacStop()
            {
            PVar.Autorun.Enable = false;
            PVar.Stop_Flag = true;
            GoHome.Reset.Result = false;
            if (PVar.IsSysEmcStop)
                {
                return;
                }

            PVar.Rtn = gts.GT_Stop(0, 255, 255); //紧急停止0号卡所有轴

            Auto_Timer.Enabled = false;
            for (int i = 0; i <= 10; i++)
                {
                PVar.Sta_Work[i].State = false;
                PVar.Sta_Work[i].IsHaveFix = false;
                PVar.Sta_Work[i].Step = 0;
                }

            for (int i = 1; i <= 8; i++) //所有轴回原点步序号清0
                {
                GoHome.AxisHome[0, i].Step = 0;
                GoHome.AxisHome[0, i].Result = false;
                }

            PVar.LampStatus = 10;
            GoHome.StepHome = 0;
            Home_Timer.Enabled = false;
            GoHome.Reset.Result = false;

            this.CT_Time.Enabled = false;

            TabPage3.Parent = TabControl1;
            TabPage4.Parent = TabControl1;
            GoHome.Reset.State = false;

            Gg.SetDo(0,Gg.OutPut0.机械手停止, 1);
            WinAPI.Wait(50);
            Gg.SetDo(0, Gg.OutPut0.机械手停止, 0);

            Gg.SetDo(0, Gg.OutPut0.机械手复位, 1);
            WinAPI.Wait(50);
            Gg.SetDo(0, Gg.OutPut0.机械手复位, 0);

            if (Frm_ProgressBar.fProgressBar == null || Frm_ProgressBar.fProgressBar.IsDisposed)
                {
                Frm_ProgressBar.fProgressBar = new Frm_ProgressBar();
                }
            Frm_ProgressBar.fProgressBar.Hide();
            Frm_Main.fMain.Btn_Start.Enabled = true;
            Frm_Main.fMain.Btn_Pause.Enabled = false;
            Frm_Main.fMain.Btn_Stop.Enabled = false;
            Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn; //主页面初始化和自动运行按钮
            Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
            Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
            PVar.IsSysEmcStop = true;
            }
        #endregion

        #region 功能：自动运行定时器
        private void Auto_Timer_Tick(object sender, EventArgs e)
            {
            lock (LockAutoTimer)
                if (PVar.MacHold == false || PVar.Sta_Work[0].StaHold || PVar.Sta_Work[1].StaHold || PVar.Sta_Work[2].StaHold || PVar.Sta_Work[3].StaHold ||
                    PVar.Sta_Work[4].StaHold || PVar.Sta_Work[5].StaHold || PVar.Sta_Work[7].StaHold || PVar.Sta_Work[8].StaHold || PVar.Sta_Work[9].StaHold)
                    {
                    if (PVar.ParList.CheckSts[1])
                        {
                        string tempStr = "";
                        if (Gg.GetDi(0, Gg.InPut0.安全门) == 0)
                            {
                            tempStr = "安全门";
                            }

                        if (!string.IsNullOrEmpty(tempStr))
                            {
                            PVar.MacHold = true;
                            PVar.Stop_Flag = false;
                            //按钮
                            //Frm_Main.fMain.Btn_Start.Enabled = false;
                            Frm_Main.fMain.Btn_Pause.Enabled = true;
                            Frm_Main.fMain.Btn_Stop.Enabled = false;
                            Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn; //主页面初始化和自动运行按钮
                            Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                            Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                            Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;
                            PVar.LampStatus = 20;

                            ////PVar.MacHold = true;
                            ////PVar.Stop_Flag = false;
                            ////Frm_Main.fMain.Btn_Start.Enabled = false;
                            ////Frm_Main.fMain.Btn_Stop.Enabled = false;
                            ////Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                            ////this.Auto_Timer.Enabled = false;
                            ////Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedPauseBtn;
                            //////Btn_Start.BackColor = BZColor_UnselectedBtn
                            ////PVar.LampStatus = 20;
                            AddList("请关闭" + tempStr);
                            ShowList(tempStr + "被打开，设备暂停！");
                            return;
                            }
                        }

                    if (PVar.Sta_Work[(int)BVar.工位.流水线0].StaHold == false)
                        {
                            Line0Run.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.流水线0]);
                        }

                    if (PVar.Sta_Work[(int)BVar.工位.流水线1].StaHold == false)
                        {
                        Line1Run.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.流水线1]);
                        }

                    if (PVar.Sta_Work[(int)BVar.工位.流水线2].StaHold == false)
                    {
                        Line2Run.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.流水线2]);
                    }

                    if (PVar.Sta_Work[(int)BVar.工位.流水线3].StaHold == false)
                    {
                        Line3Run.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.流水线3]);
                    }

                    if (PVar.Sta_Work[(int)BVar.工位.PSA供料].StaHold == false)
                    {
                        LoadPSARun.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.PSA供料]);
                    }

                    if (PVar.Sta_Work[(int)BVar.工位.机械手].StaHold == false)
                    {
                        EpsonRobot.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.机械手]);
                    }

                    //if (PVar.Sta_Work[(int)BVar.工位.料盘左供料].StaHold == false)
                    //{
                    //    Line1Run.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.料盘左供料]);
                    //}

                    //if (PVar.Sta_Work[(int)BVar.工位.料盘右供料].StaHold == false)
                    //{
                    //    Line1Run.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.料盘右供料]);
                    //}

                    if (PVar.Sta_Work[(int)BVar.工位.保压].StaHold == false)
                    {
                        PressRun.AutoRun(ref PVar.Sta_Work[(int)BVar.工位.保压]);
                    }

                    //if (BVar.TmpStep[1] != PVar.Sta_Work[1].Step || BVar.TmpStep[1] != PVar.Sta_Work[2].Step || BVar.TmpStep[3] != PVar.Sta_Work[3].Step)
                    //    {
                    //    BVar.FileRorW.WriteCsv(PVar.Sta_Work[1].Step + "," + System.Convert.ToString(PVar.Sta_Work[2].Step) + "," + System.Convert.ToString(PVar.Sta_Work[3].Step) + "," + System.Convert.ToString(API.GetTickCount()), "E:\\Log\\" + BVar.ProData[2, 1] + ".csv");
                    //    }
                    //BVar.TmpStep[1] = PVar.Sta_Work[1].Step;
                    //BVar.TmpStep[2] = PVar.Sta_Work[2].Step;
                    //BVar.TmpStep[3] = PVar.Sta_Work[3].Step;
                    }
            }
        #endregion

        #region 功能：条码枪手动触发

        private void Barcode_Trigge_Click(object sender, EventArgs e)
            {
            //return;

            if (Gg.GetDi(1, Gg.InPut1.机械手滑台气缸缩回) == 0)
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
        //机械手接收数据
        private string RobotBufferStr = ""; //以太网数据读取缓存字符 
        private void WinsockRobot_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
            {
            string robot_DataStr = "";
            robot_DataStr = "";
            try
                {
                robot_DataStr = Encoding.UTF8.GetString(e.Data);
                if (robot_DataStr.Substring(robot_DataStr.Length - 1, 1) != Constants.vbCr)
                    {
                    RobotBufferStr = RobotBufferStr + robot_DataStr;
                    }
                else
                    {
                    RobotBufferStr = RobotBufferStr + robot_DataStr;
                    RobotBufferStr = RobotBufferStr.Trim(); //删除前后空格
                    RobotBufferStr = RobotBufferStr.Replace(Constants.vbCr, ""); //删除结束符号
                    EpsonRobot.Robot_StrData = RobotBufferStr;
                    EpsonRobot.Robot_Data = RobotBufferStr.Split(',');

                    EpsonRobot.sRobot_Status = EpsonRobot.Robot_Data[0];
                    EpsonRobot.RobotPos.X = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Data[1]), "0.000"));
                    EpsonRobot.RobotPos.Y = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Data[2]), "0.000"));
                    EpsonRobot.RobotPos.Z = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Data[3]), "0.000"));
                    EpsonRobot.RobotPos.U = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Data[4]), "0.000"));
                    EpsonRobot.RobotPos.V = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Data[5]), "0.000"));
                    EpsonRobot.RobotPos.W = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Data[6]), "0.000"));

                    RobotBufferStr = "";
                    EpsonRobot.RobotIsWork = false;
                    }
                }
            catch (Exception)
                {
                AddList("机械手网络接收解析出错！");
                ShowList("机械手网络接收解析出错！");
                RobotBufferStr = "";
                }
            }

        private string RobotDataBufferStr = ""; //以太网数据读取缓存字符  
        private void WinsockRobotData_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
            {
            string robot_DataStr = "";
            robot_DataStr = "";
            try
                {
                robot_DataStr = Encoding.UTF8.GetString(e.Data);
                if (robot_DataStr.Substring(robot_DataStr.Length - 1, 1) != Constants.vbCr)
                    {
                    RobotDataBufferStr = RobotDataBufferStr + robot_DataStr;
                    }
                else
                    {
                    RobotDataBufferStr = RobotDataBufferStr + robot_DataStr;
                    RobotDataBufferStr = RobotDataBufferStr.Trim(); //删除前后空格
                    RobotDataBufferStr = RobotDataBufferStr.Replace(Constants.vbCr, ""); //删除结束符号
                    EpsonRobot.Robot_StrData = RobotDataBufferStr;
                    EpsonRobot.Robot_Fcs = RobotDataBufferStr.Split(',');

                    EpsonRobot.sRobot_FcsStatus = EpsonRobot.Robot_Fcs[0];
                    EpsonRobot.Pressure = -double.Parse(EpsonRobot.Robot_Fcs[1]);
                    PVar.Press[0] = EpsonRobot.Pressure;
                    Force_Text.Text = EpsonRobot.Pressure.ToString();

                    EpsonRobot.RobotLivePos.X = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[2]), "0.000"));
                    EpsonRobot.RobotLivePos.Y = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[3]), "0.000"));
                    EpsonRobot.RobotLivePos.Z = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[4]), "0.000"));
                    EpsonRobot.RobotLivePos.U = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[5]), "0.000"));
                    EpsonRobot.RobotLivePos.V = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[6]), "0.000"));
                    EpsonRobot.RobotLivePos.W = double.Parse(Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[7]), "0.000"));

                    if (PVar.IsOpenFrmManual)
                        {
                        Text_Robot_X.Text = Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[2]), "0.000");
                        Text_Robot_Y.Text = Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[3]), "0.000");
                        Text_Robot_Z.Text = Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[4]), "0.000");
                        Text_Robot_U.Text = Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[5]), "0.000");
                        Text_Robot_V.Text = Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[6]), "0.000");
                        Text_Robot_W.Text = Strings.Format(Conversion.Val(EpsonRobot.Robot_Fcs[7]), "0.000");
                        MForce_Text.Text = EpsonRobot.Pressure.ToString();
                        }

                    RobotDataBufferStr = "";
                    EpsonRobot.RobotIsWork = false;
                    }
                }
            catch (Exception)
                {
                RobotDataBufferStr = "";
                }
            }

        //CCD接收数据
        private string CCDBufferStr = ""; //以太网数据读取缓存字符 
        private void WinsockCCD_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
            { 
            string CCD_DataStr = "";
            try
                {
                CCD_DataStr = Encoding.UTF8.GetString(e.Data);
                if (CCD_DataStr.Substring(CCD_DataStr.Length - 1, 1) != Constants.vbCr)
                    {
                    CCDBufferStr = CCDBufferStr + CCD_DataStr;
                    }
                else
                    {
                    CCDBufferStr = CCDBufferStr + CCD_DataStr;
                    CCDBufferStr = CCDBufferStr.Trim(); //删除前后空格
                    CCDBufferStr = CCDBufferStr.Replace(Constants.vbCr, ""); //删除结束符号
                    PVar.CCD_StrData = CCDBufferStr;
                    PVar.CCD_Data = CCDBufferStr.Split(',');
                    CCDBufferStr = "";
                    Command.CCD_Resule = true;
                    }
                }
            catch (Exception)
                {
                AddList("CCD网络接收解析出错！");
                ShowList("CCD网络接收解析出错！");
                CCDBufferStr = "";
                }
            }

        //CCD2接收数据
        private string CCD2BufferStr = ""; //以太网数据读取缓存字符
        private void WinsockCCD2_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
            {
            string CCD_DataStr = "";
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
            try
                {
                if (Encoding.UTF8.GetString(e.Data) != "")
                    {
                    if ((Encoding.UTF8.GetString(e.Data).Length) > 5)
                        {
                        BVar.BarCodeData.sData = Encoding.UTF8.GetString(e.Data);
                        BVar.BarCodeData.GetCodeOK = true;
                        }
                    }
                BVar.BarCodeData.sData = Strings.Replace(BVar.BarCodeData.sData, Constants.vbCrLf, ""); //删除结束符号
                this.Txt_BarCode.Text = BVar.BarCodeData.sData.Trim();
                this.Txt_MBarCode.Text = BVar.BarCodeData.sData.Trim();
                }
            catch (Exception)
                {

                }
            }

        //PDCA网口接收数据
        private string PDCA_BufferStr = ""; 
        private void WinsockPDCA_DataArrival(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
            {
            string PDCA_DataStr = "";
            try
                {
                PDCA_DataStr = Encoding.UTF8.GetString(e.Data);
                if (PDCA_DataStr.Substring(PDCA_DataStr.Length, 1) != Constants.vbLf)
                    {
                    PDCA_BufferStr = PDCA_BufferStr + PDCA_DataStr;
                    }
                else
                    {
                    PDCA_BufferStr = PDCA_BufferStr + PDCA_DataStr;
                    PDCA_BufferStr = PDCA_BufferStr.Trim(); //删除前后空格
                    PDCA_BufferStr = PDCA_BufferStr.Replace(Constants.vbLf, ""); //删除结束符号
                    PVar.PDCA_StrData = PDCA_BufferStr;
                    PVar.PDCA_Data = PDCA_BufferStr.Split('@');
                    PDCA_BufferStr = "";
                    Command.PDCA_Resule = true;
                    }
                }
            catch (Exception)
                {
                AddList("PDCA网络接收解析出错！");
                ShowList("PDCA网络接收解析出错！");
                PDCA_BufferStr = "";
                }
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
            
            if (MessageBox.Show("是否开始相机自动标定?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
                {
                return;
                }
            ////判断初始条件
            //if (GoHome.Reset.Result == false)
            //    {
            //    AddList2("整机未初始化！");
            //    ShowList("整机未初始化！");
            //    return;
            //    }
            CCDTest.TestStop = false;
            FileLog.OperateLog("CCD标定：" + Combox_CCD_COR.Text);
            switch (Combox_CCD_COR.SelectedIndex)
                {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    MessageBox.Show("工程师没有设定这个命令，请重新选择！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return ;
                }
            string strin = "";
            strin = Interaction.InputBox("\r\n" + "\r\n" + "\r\n" + "警告：标定失败会导致无法继续正常生产！" + "\r\n" + "\r\n" + "-->请输入CCD标定密码：", "◆权限◆");

            if (strin.Length > 0)
                {
                if (strin == "789000")
                    {
                    switch (Combox_CCD_COR.SelectedIndex)
                        {
                        case 0:
                            PVar.Sta_Test[Convert.ToInt32(BVar.测试.取料标定)].Step = 10;
                            break;
                        case 1:
                            PVar.Sta_Test[Convert.ToInt32(BVar.测试.联合标定)].Step = 10;
                            break;
                        default:
                            MessageBox.Show("工程师没有设定这个命令，请重新选择！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            return;
                        }
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
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
            //CCD标定
            Calibration.cAutoRun(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.取料标定)]);
            Calibration.aAutoRun(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.联合标定)]);

            //CCD测试
            CCDTest.AutoRunTA(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机1静态)], "相机1静态");
            CCDTest.AutoRunTA(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机2静态)], "相机2静态");
            CCDTest.AutoRunTA(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机3静态)], "相机3静态");
            CCDTest.AutoRunTA(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机4静态)], "相机4静态");
            CCDTest.AutoRunTB(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机1动态)], "相机1动态", RobotPosName.PSA载台拍照位置);
            CCDTest.AutoRunTB(ref PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机2动态)], "相机2动态", RobotPosName.PSA定位拍照位置);

            if (PVar.Sta_Test[Convert.ToInt32(BVar.测试.取料标定)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.联合标定)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机1静态)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机2静态)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机3静态)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机4静态)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机1动态)].State == false
                && PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机2动态)].State == false)
                {
                Panel_Test.Enabled = true;
                PanelCalibration.Enabled = true;
                return;
                }
   
            if (CCDTest.TestStop)
                {
                for (int i = 1; i < 11; i++)
                    {
                        PVar.Sta_Test[i].Step = 0;
                    }            
                Panel_Test.Enabled = true;
                PanelCalibration.Enabled = true;
                return;
                }
            Timer_Calibration.Enabled = true;
            }

        #endregion

        #region 功能：相机冬动静态测试
        private void Button_TestStop_Click(object sender, EventArgs e)
            {
            CCDTest.TestStop = true;
            }
        private void Btn_CCDTest_Click(object sender, EventArgs e)
            {
            ////判断初始条件
            //if (GoHome.Reset.Result == false)
            //    {
            //    AddList2("整机未初始化！");
            //    ShowList("整机未初始化！");
            //    return;
            //    }
            if (MessageBox.Show("是否开始" + Combox_CCDTest.Text + "?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
                {
                return;
                }
            CCDTest.TestStop = false;
            FileLog.OperateLog("CCD测试：" + Combox_CCDTest.Text);
            switch (Combox_CCDTest.SelectedIndex)
                {
                case 0:
                    PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机1静态)].Step = 10;
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
                    break;
                case 1:
                    PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机1动态)].Step = 10;
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
                    break;
                case 2:
                    PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机2静态)].Step = 10;
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
                    break;
                case 3:
                    PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机2动态)].Step = 10;
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
                    break;
                case 4:
                    PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机3静态)].Step = 10;
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
                    break;
                case 5:
                    ShowList("暂无此功能，请重新选择！");
                    //PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机3动态)].Step = 10;
                    break;
                case 6:
                    PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机4静态)].Step = 10;
                    Panel_Test.Enabled = false;
                    PanelCalibration.Enabled = false;
                    Timer_Calibration.Enabled = true;
                    break;
                case 7:
                    ShowList("暂无此功能，请重新选择！");
                    //PVar.Sta_Test[Convert.ToInt32(BVar.测试.相机4动态)].Step = 10;
                    break;
                default:
                    MessageBox.Show("工程师没有设定这个命令，请重新选择！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
                }
            }

        #endregion

        #region 功能：PDCA验证模块
        private void Btn_PDCATest_Click(object sender, EventArgs e)
            {
            if (PDCA.PDCAIsWorking == false) //要等待上次PDCA数据传送结束才可开始上传
                {
                PDCA.UpLoadStep = 10;
                PDCA.PDCAIsWorking = true;
                PDCA_Time.Enabled = true;
                string[] tempTestData = new string[] { this.Txt_MBarCode.Text.Trim(), "0", "0.03", "-0.04", "0.05", "0.16", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                PVar.sPDCAData = tempTestData;
                FileLog.OperateLog("PDCA测试按钮");
                }
            }

        private static object LockPDCA = new object();
        private void PDCA_Time_Elapsed(object sender, EventArgs e)
            {
            lock (LockPDCA)
                {
                try
                    {
                    this.BeginInvoke(new Action(() => {PDCA.Bali_PDCA(PVar.sPDCAData);}));
                    }
                catch (Exception)
                    {
                    }
                }
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

        private void Btn_OpenSerial1_Click(object sender, EventArgs e)
            {
            try 
                {
                if (Btn_OpenSerial1.Text == "Open")
                    {
                    if (this.SerialPort1.IsOpen == false)
                        {
                        this.SerialPort1.Open();
                        WinAPI.Wait(100);
                        }
                    this.SerialPort1.Write(":O000000o" + Constants.vbCrLf);
                    Btn_OpenSerial1.Text = "Close";
                    }
                else
                    {
                    if (this.SerialPort1.IsOpen == true)
                        {
                        this.SerialPort1.Write(":Q000000q" + Constants.vbCrLf);
                        }
                    Application.DoEvents();
                    this.SerialPort1.Close();
                    Btn_OpenSerial1.Text = "Open";
                    }
                }
            catch (Exception)
                {
                MessageBox.Show("COM:【" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[46]))) + "】端口不成在，打开失败！", "提示", MessageBoxButtons.OK);
                }
            }
        private void Btn_OpenSerial2_Click(object sender, EventArgs e)
            {
            try
                {
                if (Btn_OpenSerial2.Text == "Open")
                    {
                    if (this.SerialPort2.IsOpen == false)
                        {
                        this.SerialPort2.Open();
                        WinAPI.Wait(100);
                        }
                    this.SerialPort2.Write(":O000000o" + Constants.vbCrLf);
                    Btn_OpenSerial2.Text = "Close";
                    }
                else
                    {
                    if (this.SerialPort2.IsOpen == true)
                        {
                        this.SerialPort2.Write(":Q000000q" + Constants.vbCrLf);
                        }
                    Application.DoEvents();
                    this.SerialPort2.Close();
                    Btn_OpenSerial2.Text = "Open";
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
                            Tcp_HeatBt.SendData(Encoding.UTF8.GetBytes("Send_HB, DAB," + DateTime.Now.ToString("yyyyMMddHHmmss") + ",0,@"));
                            }
                        else
                            {
                            Tcp_HeatBt.SendData(Encoding.UTF8.GetBytes("Send_HB, DAB," + DateTime.Now.ToString("yyyyMMddHHmmss") + ",1,@"));
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

        #region 参数保存
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
                    PVar.Sta_Work[(int)BVar.工位.保压].PressValue = Convert.ToDouble(Conversion.Val(strValue.Last()) / 100);
                    this.Press1_Text.Text = PVar.Sta_Work[(int)BVar.工位.保压].PressValue.ToString("0.00");
                    this.Text_Force1.Text = this.Press1_Text.Text;
                    if (PVar.IsCOM1_Working == false)
                        {
                        PVar.IsCOM1_Working = true;
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
            Random rd = new Random();
            List<int> X_label = new List<int>();
            List<double> Y_label = new List<double>();
            for (int i = PVar.Press.Count() - 1; i > 0; i--)
                {
                double dd = rd.Next(5);
                //Y_label.Add(dd);
                X_label.Add(i);
                PVar.Press[i] = PVar.Press[i - 1];
                Y_label.Add(PVar.Press[i] );
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
                chart.ChartAreas[0].AxisX.Maximum = 1000;
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Interval = 100;
                //将X轴上格网取消
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                //X轴、Y轴标题
                chart.ChartAreas[0].AxisX.Title = "";
                chart.ChartAreas[0].AxisY.Title = "Force（Unit：N）";
                //设置Y轴范围  可以根据实际情况重新修改
                chart.ChartAreas[0].AxisY.Maximum = 50;
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Interval = 5;

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
                    PVar.Sta_Work[(int)BVar.工位.校正压力].PressValue = Convert.ToDouble(Conversion.Val(strValue.Last()) / 100);
                    this.Text_Force2.Text = PVar.Sta_Work[(int)BVar.工位.校正压力].PressValue.ToString("0.00");
                    if (PVar.IsCOM2_Working == false)
                        {
                        PVar.IsCOM2_Working = true;
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
                //string[] strValue = null;
                //SerialPort sp = (SerialPort)sender;
                //string indata = sp.ReadExisting();
                //sp.DiscardInBuffer();
                //if (indata != "")
                //    {
                //    strValue = indata.Split(',');
                //    if (PVar.IsCOM3_Working == false && strValue[1] == "GT")
                //        {
                //        PVar.IsCOM3_Working = true;
                //        Thread.Sleep(50);
                //        }
                //    }
                }
            catch (Exception)
            { }
            }

        #endregion

        private void Button3_Click(object sender, EventArgs e)
            {
            Interaction.Shell("explorer E:\\BZ-Data\\PressureData\\", Constants.vbNormalFocus);
            }

        private void Button4_Click_1(object sender, EventArgs e)
            {
            Interaction.Shell("explorer E:\\BZ-Data\\DAB\\PDCALog\\" + DateTime.Now.Date.ToString("yyyyMM"), Constants.vbNormalFocus);
            }


        ////禁止编辑，只能选择下拉表格里面内容
        private void ComBox_PosList_KeyPress(object sender, KeyPressEventArgs e)
            {
            e.Handled = true;
            }


 

        private void CmdHoldS0_Click(object sender, EventArgs e)
            {
            if (Manual.MotionFlag[0])
                {
                if (Manual.HoldFlag[0])
                    {
                    Manual.HoldFlag[0] = false;
                    CmdHoldS0.Text = "暂停";
                    CmdHoldS0.BackColor = Color.BurlyWood;
                    ShowList("运动已继续");
                    }
                else
                    {
                    Manual.HoldFlag[0] = true;
                    CmdHoldS0.Text = "继续";
                    CmdHoldS0.BackColor = Color.Red;
                    ShowList("运动已暂停");
                    }
                }
            else
                {
                ShowList("未运动，暂停无效");
                }
            }



        private void CmdStopS0_Click(object sender, EventArgs e)
            {
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2_X - 1), 1 << (BVar.S2_X - 1)); //当站所有轴紧急停止
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2_Y - 1), 1 << (BVar.S2_Y - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S3_Z - 1), 1 << (BVar.S3_Z - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2_R - 1), 1 << (BVar.S2_R - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2G_Y - 1), 1 << (BVar.S2G_Y - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2G_Z - 1), 1 << (BVar.S2G_Z - 1));
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S2L_Z - 1), 1 << (BVar.S2L_Z - 1));
            PVar.Rtn = gts.GT_Stop(1, 1 << (BVar.S0_R - 1), 1 << (BVar.S0_R - 1));




            CommandAutoS0.Enabled = true;

            //if (Manual.MotionFlag[0])
            //    {
            Manual.StopFlag[0] = true;
            Manual.HoldFlag[0] = false;
            PVar.Sta_Work[0].Step = 0;
            PVar.Sta_Work[0].State = false;
            CmdHoldS0.Text = "暂停";
            CmdHoldS0.BackColor = Color.BurlyWood;
            //}
            ShowList("停止运动");
            }


        private void CmdHoldS3_Click(object sender, EventArgs e)
            {
            if (Manual.MotionFlag[3])
                {
                if (Manual.HoldFlag[3])
                    {
                    Manual.HoldFlag[3] = false;
                    CmdHoldPress.Text = "暂停";
                    CmdHoldPress.BackColor = Color.BurlyWood;
                    ShowList("运动已继续");
                    }
                else
                    {
                    Manual.HoldFlag[3] = true;
                    CmdHoldPress.Text = "继续";
                    CmdHoldPress.BackColor = Color.Red;
                    ShowList("运动已暂停");
                    }
                }
            else
                {
                ShowList("未运动，暂停无效");
                }
            }

        private void CmdStopS3_Click(object sender, EventArgs e)
            {
            PVar.Rtn = gts.GT_Stop(0, 1 << (BVar.S3_Z - 1), 1 << (BVar.S3_Z - 1)); //当站所有轴紧急停止
            PVar.Rtn = gts.GT_Stop(1, 1 << (BVar.S0_R - 1), 1 << (BVar.S0_R - 1));

            Teach4.Enabled = true;
            panel4.Enabled = true;

            CommandAutoPress.Enabled = true;

            //if (Manual.MotionFlag[3])
            //    {
            Manual.StopFlag[3] = true;
            Manual.HoldFlag[3] = false;
            CmdHoldPress.Text = "暂停";
            CmdHoldPress.BackColor = Color.BurlyWood;
            //}
            ShowList("停止运动");
            }

        private void CmdHoldS4_Click(object sender, EventArgs e)
            {
            if (Manual.MotionFlag[4])
                {
                if (Manual.HoldFlag[4])
                    {
                    Manual.HoldFlag[4] = false;
                    CmdHold.Text = "暂停";
                    CmdHold.BackColor = Color.BurlyWood;
                    ShowList("运动已继续");
                    }
                else
                    {
                    Manual.HoldFlag[4] = true;
                    CmdHold.Text = "继续";
                    CmdHold.BackColor = Color.Red;
                    ShowList("运动已暂停");
                    }
                }
            else
                {
                ShowList("未运动，暂停无效");
                }
            }

        private void CmdStopS4_Click(object sender, EventArgs e)
            {
            PVar.Rtn = gts.GT_Stop(1, 1 << (BVar.S0_R - 1), 1 << (BVar.S0_R - 1));


            panel5.Enabled = true;

            CommandAuto.Enabled = true;

            //if (Manual.MotionFlag[4])
            //    {
            Manual.StopFlag[4] = true;
            Manual.HoldFlag[4] = false;
            CmdHold.Text = "暂停";
            CmdHold.BackColor = Color.BurlyWood;
            //}
            ShowList("停止运动");
            }



        /// <summary>
        /// 供料手动界面自动运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandAutoS0_Click(object sender, EventArgs e)
            {
            if (Interaction.MsgBox("确定【供料自动运行】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【自动运行】") == Constants.vbCancel)
                {
                return;
                }
            if (PVar.Sta_Work[2].State)
                {
                ShowList("2站正在运行中!");
                return;
                }
            this.CommandAutoS0.Enabled = false;
            if (GoHome.Reset.Result == false)
                {
                ShowList("设备没有初始化!");
                this.CommandAutoS0.Enabled = true;
                return;
                }
            if (Gg.Set_AllServoON(0, 1, 8) == false)
                {
                this.CommandAutoS0.Enabled = true;
                return;
                }

            //if (!(Gg.GetExDo(0, 1, 14) == 0 && Gg.GetExDo(0, 1, 15) == 0))
            //{
            //    ShowList("Feeder物料夹爪没有夹紧！");
            //    this.CommandAutoS0.Enabled = true;
            //    return;
            //}

            Manual.MotionFlag[0] = true;
            Manual.AutoMotionFlag[0] = true;
            PVar.Sta_Work[0].Step = 10;
            while (true)
                {
                System.Threading.Thread.Sleep(5);

                if (Manual.AutoMotionFlag[0] == false) //等待运动完成
                    {
                    PVar.Sta_Work[0].Step = 0;
                    PVar.Sta_Work[10].Step = 0;
                    ShowList("供料单站自动运行完成");
                    break;
                    }
                if (Gg.GetDi(0, 15) == 1 || Gg.GetDi(1, 15) == 1) //判断急停按钮是否按下
                    {
                    PVar.Sta_Work[0].Step = 0;
                    PVar.Sta_Work[10].Step = 0;
                    ShowList("供料单站自动运行" + "，急停中断");
                    break;
                    }
                if (Manual.StopFlag[0]) //判断【B-logo组装站】停止按钮是否按下
                    {
                    PVar.Sta_Work[0].Step = 0;
                    PVar.Sta_Work[10].Step = 0;
                    ShowList("供料单站自动运行" + "，停止中断");
                    break;
                    }
                if (Manual.HoldFlag[0] == false)
                    {
                    Line0Run.AutoRun(ref PVar.Sta_Work[0]);
                    WinAPI.Wait(50);
                    }

                Application.DoEvents();
                }
            Manual.AutoMotionFlag[0] = false;
            Manual.MotionFlag[0] = false;
            Manual.StopFlag[0] = false;
            this.CommandAutoS0.Enabled = true;
            }




        /// <summary>
        /// 3站手动界面自动运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandAutoS3_Click(object sender, EventArgs e)
            {
            if (Interaction.MsgBox("确定【3站自动运行】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【自动运行】") == Constants.vbCancel)
                {
                return;
                }
            this.CommandAutoPress.Enabled = false;
            if (GoHome.Reset.Result == false)
                {
                ShowList("设备没有初始化!");
                this.CommandAutoPress.Enabled = true;
                return;
                }
            if (Gg.Set_AllServoON(0, 1, 8) == false )
                {
                this.CommandAutoPress.Enabled = true;
                return;
                }

            Manual.MotionFlag[3] = true;
            Manual.AutoMotionFlag[3] = true;
            PVar.Sta_Work[3].Step = 10;
            while (true)
                {
                System.Threading.Thread.Sleep(5);

                if (Manual.AutoMotionFlag[3] == false) //等待运动完成
                    {
                    PVar.Sta_Work[3].Step = 0;
                    ShowList("3站单站自动运行完成");
                    break;
                    }
                if (Gg.GetDi(0, 15) == 1 || Gg.GetDi(1, 15) == 1) //判断急停按钮是否按下
                    {
                    PVar.Sta_Work[3].Step = 0;
                    ShowList("3站单站自动运行" + "，急停中断");
                    break;
                    }
                if (Manual.StopFlag[3]) //判断停止按钮是否按下
                    {
                    PVar.Sta_Work[3].Step = 0;
                    ShowList("3站单站自动运行" + "，停止中断");
                    break;
                    }
                if (Manual.HoldFlag[3] == false)
                    {
                    Line3Run.AutoRun(ref PVar.Sta_Work[3]);
                    WinAPI.Wait(50);
                    }

                Application.DoEvents();
                }
            Manual.AutoMotionFlag[3] = false;
            Manual.MotionFlag[3] = false;
            Manual.StopFlag[3] = false;
            this.CommandAutoPress.Enabled = true;
            }
        /// <summary>
        /// 4站手动界面自动运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandAutoS4_Click(object sender, EventArgs e)
            {
            if (Interaction.MsgBox("确定【4站自动运行】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【自动运行】") == Constants.vbCancel)
                {
                return;
                }
            this.CommandAuto.Enabled = false;
            if (GoHome.Reset.Result == false)
                {
                ShowList("设备没有初始化!");
                this.CommandAuto.Enabled = true;
                return;
                }
            if (Gg.Set_AllServoON(0, 1, 8) == false)
                {
                this.CommandAuto.Enabled = true;
                return;
                }

            Manual.MotionFlag[4] = true;
            Manual.AutoMotionFlag[4] = true;
            PVar.Sta_Work[4].Step = 10;
            while (true)
                {
                System.Threading.Thread.Sleep(5);

                if (Manual.AutoMotionFlag[4] == false) //等待运动完成
                    {
                    PVar.Sta_Work[4].Step = 0;
                    ShowList("4站单站自动运行完成");
                    break;
                    }
                if (Gg.GetDi(0, 15) == 1 || Gg.GetDi(1, 15) == 1) //判断急停按钮是否按下
                    {
                    PVar.Sta_Work[4].Step = 0;
                    ShowList("4站单站自动运行" + "，急停中断");
                    break;
                    }
                if (Manual.StopFlag[4]) //判断停止按钮是否按下
                    {
                    PVar.Sta_Work[4].Step = 0;
                    ShowList("4站单站自动运行" + "，停止中断");
                    break;
                    }
                if (Manual.HoldFlag[4] == false)
                    {
                    Sta4Run.AutoRun(ref PVar.Sta_Work[4]);
                    WinAPI.Wait(50);
                    }
                Application.DoEvents();
                }
            Manual.AutoMotionFlag[4] = false;
            Manual.MotionFlag[4] = false;
            Manual.StopFlag[4] = false;
            this.CommandAuto.Enabled = true;
            }

        private void Change_M_Click(object sender, EventArgs e)
            {
            if (PVar.AutoRunFlag == false && PVar.Sta_Work[0].Step < 20 && PVar.Sta_Work[1].Step < 20 && PVar.Sta_Work[2].Step < 20 && PVar.Sta_Work[3].Step < 20 && PVar.Sta_Work[4].Step < 20)
                {
                if (Interaction.MsgBox("确定【是否手动换料】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【自动运行】") == Constants.vbCancel)
                    {
                    return;
                    }
                Auto_Timer.Enabled = false; //自动运行开始

                if (PVar.ParList.CheckSts[1])
                    {
                    string tempStr = "";
                    if (Gg.GetDi(0, Gg.InPut0.安全门) == 0)
                        {
                        tempStr = "安全门";
                        }

                    if (!string.IsNullOrEmpty(tempStr))
                        {
                        AddList("请关闭" + tempStr + "!");
                        ShowList("请关闭" + tempStr + "!");
                        return;
                        }
                    }

                this.Change_M.Enabled = false;
                if (GoHome.Reset.Result == false)
                    {
                    ShowList("设备没有初始化!");
                    this.Change_M.Enabled = true;
                    return;
                    }

                if (Gg.Set_AllServoON(0, 1, 8) == false )
                    {
                    this.Change_M.Enabled = true;
                    return;
                    }

                Manual.MotionFlag[0] = true;
                Manual.AutoMotionFlag[0] = true;
                PVar.Sta_Work[0].Step = 500;
                while (true)
                    {

                    System.Threading.Thread.Sleep(5);

                    if (Manual.AutoMotionFlag[0] == false) //等待运动完成
                        {
                        PVar.Sta_Work[0].Step = 0;
                        ShowList("换料自动运行完成，请放物料");
                        break;
                        }
                    if (Gg.GetDi(0, 15) == 1 || Gg.GetDi(1, 15) == 1) //判断急停按钮是否按下
                        {
                        PVar.Sta_Work[0].Step = 0;
                        ShowList("换料自动运行" + "，急停中断");
                        break;
                        }


                    Line0Run.AutoRun(ref PVar.Sta_Work[0]);
                    WinAPI.Wait(50);


                    Application.DoEvents();
                    }
                Manual.AutoMotionFlag[0] = false;
                Manual.MotionFlag[0] = false;
                Manual.StopFlag[0] = false;
                this.Change_M.Enabled = true;
                }
            else
                {
                ShowList("设备正在运行中…");
                return;
                }
            }

        private void CCD_Screen_S2_Click(object sender, EventArgs e)
            {

            }

        private void button7_Click(object sender, EventArgs e)
            {

            }

        private void BtnM_B_logo_Click(object sender, EventArgs e)
            {
            Frm_Materiel.fMateriel.ShowDialog();
            }

        private void Change_LC_Click(object sender, EventArgs e)
            {
            if (PVar.AutoRunFlag == false && PVar.Sta_Work[0].Step < 20 && PVar.Sta_Work[1].Step < 20 && PVar.Sta_Work[2].Step < 20 && PVar.Sta_Work[3].Step < 20 && PVar.Sta_Work[4].Step < 20)
                {
                if (Interaction.MsgBox("确定【是否料仓上料】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【自动运行】") == Constants.vbCancel)
                    {
                    return;
                    }
                Auto_Timer.Enabled = false; //自动运行开始

                if (PVar.ParList.CheckSts[1])
                    {
                    string tempStr = "";
                    if (Gg.GetDi(1, Gg.InPut1.载具夹紧气缸缩回) == 0)
                        {
                        tempStr = "后门安全门1";
                        }
                    if (Gg.GetDi(1, Gg.InPut1.保压无杆气缸左) == 0)
                        {
                        tempStr = "后门安全门2";
                        }
                    if (Gg.GetDi(1, Gg.InPut1.机械手滑台气缸缩回) == 0)
                        {
                        tempStr = "右安全门1";
                        }
                    if (Gg.GetDi(1, Gg.InPut1.机械手撕膜升降气缸伸出) == 0)
                        {
                        tempStr = "右安全门2";
                        }
                    if (Gg.GetDi(1, Gg.InPut1.保压无杆气缸右) == 0)
                        {
                        tempStr = "左安全门1";
                        }
                    if (Gg.GetDi(1, Gg.InPut1.机械手滑台气缸伸出) == 0)
                        {
                        tempStr = "左安全门2";
                        }
                    if (Gg.GetDi(1, Gg.InPut1.载具夹紧气缸伸出) == 0)
                        {
                        tempStr = "前门安全门";
                        }

                    if (Gg.GetDi(0, Gg.InPut0.机械手准备好) == 0)
                        {
                        AddList("请勿遮挡安全光幕！");
                        ShowList("请勿遮挡安全光幕！");
                        return;
                        }

                    if (!string.IsNullOrEmpty(tempStr))
                        {
                        AddList("请关闭" + tempStr + "!");
                        ShowList("请关闭" + tempStr + "!");
                        return;
                        }
                    }

                Manual.MotionFlag[0] = true;
                Manual.AutoMotionFlag[0] = true;
                PVar.Sta_Work[0].Step = 600;
                while (true)
                    {

                    System.Threading.Thread.Sleep(5);

                    if (Manual.AutoMotionFlag[0] == false) //等待运动完成
                        {
                        PVar.Sta_Work[0].Step = 0;
                        ShowList("换料自动运行完成，请放物料！");
                        break;
                        }
                    if (Gg.GetDi(0, 15) == 1 || Gg.GetDi(1, 15) == 1) //判断急停按钮是否按下
                        {
                        PVar.Sta_Work[0].Step = 0;
                        ShowList("换料自动运行" + "，急停中断");
                        break;
                        }


                    Line0Run.AutoRun(ref PVar.Sta_Work[0]);
                    WinAPI.Wait(50);


                    Application.DoEvents();
                    }
                Manual.AutoMotionFlag[0] = false;
                Manual.MotionFlag[0] = false;
                Manual.StopFlag[0] = false;
                }
            else
                {
                ShowList("设备正在运行中…");
                return;
                }

            }

        private void TabPage14_Click(object sender, EventArgs e)
            {

            }

        private void button13_MouseUp(object sender, MouseEventArgs e)
            {
            if (PVar.AutoRunFlag == false)
                {
                AddList("设备没有自动运行！");
                ShowList("设备没有自动运行！");
                return;
                }
            if (Gg.GetDi(0, Gg.InPut0.机械手报警) == 1 && PVar.ParList.CheckSts[17] == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false && PVar.Sta_Work[4].State == false)
                {
                AddList("请先取出产品！");
                ShowList("请先取出产品！");
                return;
                }

            if (Gg.GetDi(0, Gg.InPut0.机械手准备好) == 0 && PVar.ParList.CheckSts[17] == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false && PVar.Sta_Work[4].State == false)
                {
                AddList("安全光幕被遮挡！");
                ShowList("安全光幕被遮挡！");
                return;
                }

            if (Gg.GetDi(0, Gg.InPut0.机械手准备好) == 1 && PVar.ParList.CheckSts[17] == false && PVar.Sta_Work[1].State == false && PVar.Sta_Work[2].State == false && PVar.Sta_Work[3].State == false && PVar.Sta_Work[4].State == false)
                {
                PVar.mStart = true;
                }
            }

        private void LightControl1_Load(object sender, EventArgs e)
            {

            }

        private void button13_Click(object sender, EventArgs e)
            {

            }

        private void button14_Click(object sender, EventArgs e)
            {
            if ((PVar.AutoRunFlag == false && PVar.Sta_Work[1].Step < 20 && PVar.Sta_Work[2].Step < 20 && PVar.Sta_Work[3].Step < 20 && PVar.Sta_Work[4].Step < 20))
            { }
            else
                {
                ShowList("设备正在运行中…");
                return;
                }
            Btn_All_Click(sender, e);
            PVar.Sta_Work[0].Result = false;
            PVar.Tray.MaterialCnt = 1;
            Frm_Engineering.fEngineering.Txt_PalletNum.Text = PVar.Tray.MaterialCnt.ToString();
            Frm_Engineering.fEngineering.Txt_PalletSelectNum.Text = Frm_Engineering.fEngineering.Txt_PalletNum.Text;
            BVar.FileRorW.WriteINI("Material_index", "Display", PVar.Tray.MaterialCnt.ToString(), PVar.PublicParPath);
            }

        private void buttonTrigger_Click(object sender, EventArgs e)
            {
            if (Command.TCP_Barcode_Send("||>trigger on")!=1)
                {
                AddList("条码枪网络未连接！");
                ShowList("条码枪网络未连接！");
                }
            }

        public void ChangeLorR()
            {
            if (PVar.ParList.CheckSts[3] == false) //左右机切换
                {//左进
                this.PB_Left1.Visible = false;
                this.PB_Left2.Visible = false;
                this.PB_Left3.Visible = false;
                this.PB_Right1.Visible = true;
                this.PB_Right2.Visible = true;
                this.PB_Right3.Visible = true;
                this.Lab_Line1Step.Text = "S1";
                this.Lab_Line3Step.Text = "S3";
                this.Panel1_Left.Visible = true;
                this.Panel1_Right.Visible = false;
                this.Box_InL1.Visible = true;
                this.Box_InL2.Visible = true;
                this.Box_InL3.Visible = true;
                this.Box_InL4.Visible = true;
                this.Box_InL5.Visible = true;
                this.Box_InR1.Visible = false;
                this.Box_InR2.Visible = false;
                this.Box_InR3.Visible = false;
                this.Box_InR4.Visible = false;
                this.Box_InR5.Visible = false;
                }
            else
                {
                this.PB_Left1.Visible = true;
                this.PB_Left2.Visible = true;
                this.PB_Left3.Visible = true;
                this.PB_Right1.Visible = false;
                this.PB_Right2.Visible = false;
                this.PB_Right3.Visible = false;
                this.Lab_Line1Step.Text = "S3";
                this.Lab_Line3Step.Text = "S1";
                this.Panel1_Left.Visible = false;
                this.Panel1_Right.Visible = true;
                this.Box_InL1.Visible = false;
                this.Box_InL2.Visible = false;
                this.Box_InL3.Visible = false;
                this.Box_InL4.Visible = false;
                this.Box_InL5.Visible = false;
                this.Box_InR1.Visible = true;
                this.Box_InR2.Visible = true;
                this.Box_InR3.Visible = true;
                this.Box_InR4.Visible = true;
                this.Box_InR5.Visible = true;
                }
            }


        #region 功能：机械手手动相关
        public void TrackBar1_Scroll(object sender, EventArgs e)
            {
            Combo_RbtSpeed.Text = System.Convert.ToString(TrackBar1.Value);
            }

        private void TrackBar2_Scroll(object sender, EventArgs e)
            {
            Combo_RbtDist.Text = System.Convert.ToString(TrackBar2.Value);
            }

        private void Btn_RbtRun1_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            String Manual_Speed = this.Combo_RbtSpeed.Text;
            String Manual_Distance = this.Combo_RbtDist.Text;
            string mDir = "";
            string Atag = btn.Tag.ToString();
            lock (LockRobotMotion)
                if (btn.TabIndex == 0)
                    {
                    mDir = "-";
                    }
                else
                    {
                    mDir = "+";
                    }
            checkBox_Live.CheckState = CheckState.Checked;
            if (Rbt_SendCmd("Move", "0", Manual_Speed.ToString(), "0", "0", "0", "0", "0", Atag, Manual_Distance, mDir, "0", "0", Manual_Speed) == false)
                {
                return;//命令发送失败退出
                }
            btn.BackColor = Color.LightGreen;
            int iTime = System.Convert.ToInt32(API.GetTickCount());
            do
                {
                Thread.Sleep(1);
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 1000 & Gg.GetDi(0, 2) == 0 & Gg.GetDi(0, 3) == 0)
                    {
                    break;//运行完成退出
                    }
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 5000 & (Gg.GetDi(0, 3) == 1))
                    {
                    break;//暂停超出5秒后退出
                    }
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 1000 & (Gg.GetDi(0, 4) == 1 || Gg.GetDi(0, 1) == 0))
                    {
                    break;
                    }
                Application.DoEvents();
                } while (EpsonRobot.sRobot_Status != "Move");
            Text_Robot_X.Text = EpsonRobot.RobotPos.X.ToString("f3");
            Text_Robot_Y.Text = EpsonRobot.RobotPos.Y.ToString("f3");
            Text_Robot_Z.Text = EpsonRobot.RobotPos.Z.ToString("f3");
            Text_Robot_U.Text = EpsonRobot.RobotPos.U.ToString("f3");
            Text_Robot_V.Text = EpsonRobot.RobotPos.V.ToString("f3");
            Text_Robot_W.Text = EpsonRobot.RobotPos.W.ToString("f3");
            btn.BackColor = System.Drawing.SystemColors.Menu;
            }

        //机械手伺服开启和关闭
        private void Cmd_MotorON_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;

            if (Rbt_SendCmd("Motor", btn.TabIndex.ToString(), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0") == false)
                {
                return;
                }

            btn.BackColor = Color.LightGreen;
            int iTime = System.Convert.ToInt32(API.GetTickCount());
            do
                {
                Thread.Sleep(1);
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 1000)
                    {
                    EpsonRobot.RobotIsWork = false;
                    break;
                    }
                Application.DoEvents();
                } while (EpsonRobot.sRobot_Status != "Motor");
            btn.BackColor = System.Drawing.SystemColors.Menu;
            }

        private void Combo_S2_Pos_SelectionChangeCommitted(object sender, EventArgs e)
            {
            int mPx = Combo_Robot_Pos.SelectedIndex;
            checkBox_Live.CheckState = CheckState.Unchecked;
            if (Combo_Robot_Pos.SelectedIndex == 6 || Combo_Robot_Pos.SelectedIndex == 7)
                {
                Btn_SelectPalletNum.Visible = true;
                Txt_PalletSelectNum.Visible = true;
                }
            else
                {
                Btn_SelectPalletNum.Visible = false;
                Txt_PalletSelectNum.Visible = false;
                }
            if (Frm_Engineering.fEngineering.Tcp_Robot.IsStart == false) //判断机械手连接是否成功
                {
                return;
                }

            if (Rbt_SendCmd("GetPos", "0", "0", "0", "0", "0", "0", mPx.ToString(), "0", "0", "0", "0", "0", "0") == false)
                {
                return;
                }
            int iTime = System.Convert.ToInt32(API.GetTickCount());
            do
                {
                //Thread.Sleep(5);
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 100)
                    {
                    EpsonRobot.RobotIsWork = false;
                    return;//超时退出
                    }
                Application.DoEvents();
                } while (EpsonRobot.sRobot_Status != "GetPos");
            Text_Robot_X.Text = EpsonRobot.RobotPos.X.ToString("f3");
            Text_Robot_Y.Text = EpsonRobot.RobotPos.Y.ToString("f3");
            Text_Robot_Z.Text = EpsonRobot.RobotPos.Z.ToString("f3");
            Text_Robot_U.Text = EpsonRobot.RobotPos.U.ToString("f3");
            Text_Robot_V.Text = EpsonRobot.RobotPos.V.ToString("f3");
            Text_Robot_W.Text = EpsonRobot.RobotPos.W.ToString("f3");
            }

        //机械手手动点位运动
        private void Cmd_RobotRun_Click(object sender, EventArgs e)
            {
            String ActiveStep = Combo_Robot_Pos.SelectedIndex.ToString();
            int ActiveSpeed = Convert.ToInt32(Combo_RbtSpeed.Text);
            int Myval = (int)(Interaction.MsgBox("机械手准备运动到【" + Combo_Robot_Pos.Text + "】" + Constants.vbCr + "谨防撞机，请确认？", Constants.vbYesNo, "运动"));
            if (Myval != (int)Constants.vbYes)
                {
                return;
                }
            checkBox_Live.CheckState = CheckState.Checked;
            EpsonRobot.ManualRun(ActiveStep, ActiveSpeed);
            }

        private void CmdS2_Save_Click(object sender, EventArgs e)
            {
            SavePoint_Check.CheckState = CheckState.Unchecked;
            CmdS2_Save.Enabled = false;
            Robot_ManualPosSave();
            }
        #endregion

        #region 功能：手动运行下的机械手点位保存
        private void Robot_ManualPosSave()
            {
            if (Interaction.MsgBox("确定要保存机械手当前位置为<<" + this.Combo_Robot_Pos.Text + ">>吗？？？", (int)Constants.vbOKCancel + Constants.vbQuestion, null) != Constants.vbOK) //判断是否确认退出主窗体
                {
                this.SavePoint_Check.CheckState = CheckState.Unchecked;
                return;
                }
            Rbt_SendCmd("SavePx", "0", "0", "0", "0", "0", "0", Convert.ToString(this.Combo_Robot_Pos.SelectedIndex), "0",
                "0", "0", "0", "0", "5");
            }
        #endregion

        #region 功能：机械手网络发送命令
        //' <summary>
        //' Rbt_SendCmd 程式发送指令给机械手控制器
        //' </summary>[1:机械手执行的命令],[2:执行的步序号],[3:运动速度],[4:OffsetX],[5:OffsetY],[6:OffsetZ],[7:OffsetR],[],[],[],[],[],[],[],[],[]
        //' <param name="Item">参数1：机械手指令类别参数 Item$</param>
        //' <param name="Pos_Num">参数2：“Step”指令下的步序号 </param>
        //' <param name="Rbt_Speed">参数3：机械手运动速度</param>
        //' <param name="OffsetX">参数4：OffsetX</param>
        //' <param name="OffsetY">参数5: OffsetY</param>
        //' <param name="OffsetZ">参数6：OffsetZ</param>
        //' <param name="OffsetR">参数7：OffsetR</param>
        //' <param name="Px">参数8：点位编号 Px</param>
        //' <param name="Axis">参数9：轴编号 Axis$</param>
        //' <param name="Length">参数10：运动距离 Length</param>
        //' <param name="Direction">参数11：运动方向 Direction$</param>
        //' <param name="Pallet_Num">参数12：料盘编号 PalletNum</param>
        //' <param name="Point_Num">参数13：料件编号 ProductNum</param>
        //' <remarks>##AABBCC</remarks>Main.Winsock_PDCA.SendData
        /// <summary>
        /// [1:机械手执行的命令],[2:执行的步序号],[3:运动速度百分比],[4:OffsetX],[5:OffsetY],[6:OffsetZ],[7:OffsetR],[8:点位编号],[9:轴编号],[10:运动距离],[11:运动方向],[12:料盘编号],[13:料件编号],[14:运动速度]
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Pos_Num"></param>
        /// <param name="Rbt_Speed"></param>
        /// <param name="OffsetX"></param>
        /// <param name="OffsetY"></param>
        /// <param name="OffsetZ"></param>
        /// <param name="OffsetR"></param>
        /// <param name="Px"></param>
        /// <param name="Axis"></param>
        /// <param name="Length"></param>
        /// <param name="Direction"></param>
        /// <param name="Pallet_Num"></param>
        /// <param name="Point_Num"></param>
        /// <param name="Speeds"></param>
        /// <remarks></remarks>

        public bool Rbt_SendCmd(string Item, string Pos_Num, string Rbt_Speed, string OffsetX, string OffsetY, string OffsetZ, string OffsetR, string Px, string Axis, string Length, string Direction, string Pallet_Num, string Point_Num, string Speeds)
            {
            if (Frm_Engineering.fEngineering.Tcp_Robot.IsStart == false) //判断机械手连接是否成功
                {
                AddList("机械手网络未连接！");
                ShowList("机械手网络未连接！");
                return false;
                }
            try
                {
                if (EpsonRobot.RobotIsWork == false)
                    {
                    EpsonRobot.RobotIsWork = true;
                    EpsonRobot.RobotCMDSendTime = System.Convert.ToInt32(API.GetTickCount());
                    EpsonRobot.sRobot_Status = "";
                    String S_Robot = "";
                    S_Robot = Item + "," + Pos_Num + "," + Rbt_Speed + "," + OffsetX + "," + OffsetY + "," + OffsetZ;
                    S_Robot = S_Robot + "," + OffsetR + "," + Px + "," + Axis + "," + Length + "," + Direction + "," + Pallet_Num + "," + Point_Num + "," + Speeds + Constants.vbCr;
                    this.Tcp_Robot.SendData(Encoding.ASCII.GetBytes(S_Robot));
                    FileLog.Robot_log(">> Rbt ||: " + S_Robot);
                    }
                return true;
                }
            catch
                {
                EpsonRobot.RobotIsWork = false;
                AddList("机械手网络命令发送出错！--" + Item + "--" + Pos_Num);
                ShowList("机械手网络命令发送出错！--" + Item + "--" + Pos_Num);
                return false;
                }
            }
        #endregion

        private void SavePoint_Check_CheckedChanged(object sender, EventArgs e)
            {
            if (SavePoint_Check.CheckState == CheckState.Checked)
                {
                CmdS2_Save.Enabled = true;
                }
            else
                {
                CmdS2_Save.Enabled = false;
                }
            }

        private void Btn_L1D_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            string sTag = btn.Tag.ToString();
            Gg.JogMotion(0, (short)btn.TabIndex, (int)PVar.ParList.Data[43], sTag);
            if (sTag == "-")
                {
                switch (btn.TabIndex)
                    {
                    case 1:
                        Btn_L1AZ.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L1AF.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L1BZ.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L1BF.BackColor = PVar.BZColor_SelectedBtn;
                        break;
                    case 2:
                        Btn_L2AZ.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L2AF.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L2BZ.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L2BF.BackColor = PVar.BZColor_SelectedBtn;
                        break;
                    case 3:
                        Btn_L3AZ.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L3AF.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L3BZ.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L3BF.BackColor = PVar.BZColor_SelectedBtn;
                        break;
                    }
                }
            else
                {
                switch (btn.TabIndex)
                    {
                    case 1:
                        Btn_L1AZ.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L1AF.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L1BZ.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L1BF.BackColor = PVar.BZColor_UnselectedBtn;
                        break;
                    case 2:
                        Btn_L2AZ.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L2AF.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L2BZ.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L2BF.BackColor = PVar.BZColor_UnselectedBtn;
                        break;
                    case 3:
                        Btn_L3AZ.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L3AF.BackColor = PVar.BZColor_UnselectedBtn;
                        Btn_L3BZ.BackColor = PVar.BZColor_SelectedBtn;
                        Btn_L3BF.BackColor = PVar.BZColor_UnselectedBtn;
                        break;
                    }
                }
            }


        private void Btn_L1AST_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            string sTag = btn.Tag.ToString();
            gts.GT_Stop(0, 1 << (btn.TabIndex - 1), 1 << (btn.TabIndex - 1));
            switch (btn.TabIndex)
                {
                case 1:
                    Btn_L1AZ.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L1AF.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L1BZ.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L1BF.BackColor = PVar.BZColor_UnselectedBtn;
                    break;
                case 2:
                    Btn_L2AZ.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L2AF.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L2BZ.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L2BF.BackColor = PVar.BZColor_UnselectedBtn;
                    break;
                case 3:
                    Btn_L3AZ.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L3AF.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L3BZ.BackColor = PVar.BZColor_UnselectedBtn;
                    Btn_L3BF.BackColor = PVar.BZColor_UnselectedBtn;
                    break;
                }
            }

        private void Rot_SetPress_Click(object sender, EventArgs e)
            { 
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            checkBox_Live.CheckState = CheckState.Checked;
                if (Frm_Engineering.fEngineering.Tcp_RobotData.IsStart == false) //判断机械手连接是否成功
                    {
                    return;
                    }
                try
                    {
                    String S_Robot = "";
                    S_Robot = "Zero" + Constants.vbCr;
                    this.Tcp_RobotData.SendData(Encoding.ASCII.GetBytes(S_Robot));
                    FileLog.Robot_log(">> Rbt ||: " + S_Robot);
                    }
                catch { }
                WinAPI.Wait(100);
                btn.BackColor = Color.Khaki;
            }

        private void checkBox_Live_CheckedChanged(object sender, EventArgs e)
            {
            if (checkBox_Live.CheckState == CheckState.Checked)
                {

                if (Frm_Engineering.fEngineering.Tcp_RobotData.IsStart == false) //判断机械手连接是否成功
                    {
                    return;
                    }
                try
                    {
                    String S_Robot = "";
                    S_Robot = "Play" + Constants.vbCr;
                    this.Tcp_RobotData.SendData(Encoding.ASCII.GetBytes(S_Robot));
                    FileLog.Robot_log(">> Rbt ||: " + S_Robot);
                    }
                catch { }
                }
            else
                {
                if (Frm_Engineering.fEngineering.Tcp_RobotData.IsStart == false) //判断机械手连接是否成功
                    {
                    return;
                    }
                try
                    {
                    String S_Robot = "";
                    S_Robot = "Stop" + Constants.vbCr;
                    this.Tcp_RobotData.SendData(Encoding.ASCII.GetBytes(S_Robot));
                    FileLog.Robot_log(">> Rbt ||: " + S_Robot);
                    }
                catch { }
                }
            }

        private void Button_OpenPDCAlog_Click(object sender, EventArgs e)
            {
            if (System.IO.File.Exists(PVar.BZ_PDCALogPath) == false)
                {
                System.IO.Directory.CreateDirectory(PVar.BZ_PDCALogPath);
                }
            System.IO.DirectoryInfo SFile = new System.IO.DirectoryInfo(PVar.BZ_PDCALogPath);
            if (SFile.Exists)
                {
                try
                    {
                    System.Diagnostics.Process.Start("explorer.exe", PVar.BZ_PDCALogPath);
                    }
                catch { }
                }
            else
                {

                }
            }

        private void Change_PSA_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            if (GoHome.Reset.Result == false)
                {
                ShowList("设备没有初始化!");
                return;
                }
            if (Interaction.MsgBox("确定【是否换料】？", (int)Constants.vbInformation + Constants.vbOKCancel, "【更换PSA】") == Constants.vbCancel)
                {
                return;
                }
            Tool.Delay intTime = new Tool.Delay();
            if (btn.Text == "PSA 换料")
                {
                btn.Enabled = false;
                PVar.Sta_Work[(int)BVar.工位.PSA供料].IsLoadPSA = true;
                btn.Text = "完  成";
                Gg.SetDo(0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴初始位置], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);                
                intTime.InitialTime();
                while (true)
                    {
                    System.Threading.Thread.Sleep(5);
                    if (Gg.GetDi(0, 15) == 1) //判断急停按钮是否按下
                        {
                        break;
                        }
                    if (Gg.ZSPD(0, Axis.PSA供料Z轴))
                        {
                        break;
                        }
                    if (intTime.TimeIsUp(20000))
                        {
                        ShowList("PSA供料Z轴回初始位置超时!");
                        btn.Enabled = true;
                        return;
                        }
                    Application.DoEvents();
                    }
                Gg.SetDo(0, Gg.OutPut1.PSA料仓夹紧气缸, 0);
                intTime.InitialTime();
                while (true)
                    {
                    System.Threading.Thread.Sleep(5);
                    if (Gg.GetDi(0, 15) == 1) //判断急停按钮是否按下
                        {
                        break;
                        }
                    if (Gg.GetExDi(0, Gg.InPut1.PSA料仓夹紧气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA料仓夹紧气缸伸出) == 0)
                        {
                        break;
                        }
                    else if (intTime.TimeIsUp(2000))
                        {
                        ShowList("PSA料仓夹紧气缸缩回超时!");
                        btn.Enabled = true;
                        return;
                        }
                    Application.DoEvents();
                    }
                btn.Enabled = true;
                }
            else
                {
                if (Gg.GetExDi(1, Gg.InPut2.PSA料仓到位感应信号) == 1)
                    {
                    Gg.SetDo(0, Gg.OutPut1.PSA料仓夹紧气缸, 1);
                    intTime.InitialTime();
                    while (true)
                        {
                        System.Threading.Thread.Sleep(5);
                        if (Gg.GetDi(0, 15) == 1) //判断急停按钮是否按下
                            {
                            break;
                            }
                        if (Gg.GetExDi(0, Gg.InPut1.PSA料仓夹紧气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut1.PSA料仓夹紧气缸伸出) == 1)
                            {
                            btn.Text = "PSA 换料";
                            PVar.Sta_Work[(int)BVar.工位.PSA供料].IsLoadPSA = false;
                            break;
                            }
                        else if (intTime.TimeIsUp(2000))
                            {
                            Gg.SetDo(0, Gg.OutPut1.PSA料仓夹紧气缸, 0);
                            ShowList("PSA料仓夹紧气缸缩回超时!");
                            btn.Enabled = true;
                            return;
                            }
                        Application.DoEvents();
                        }                   
                    }
                else
                    {
                    AddList("PSA料仓没有合上，请确认！");
                    ShowList("PSA料仓没有合上，请确认！");
                    }

                }           
            }




        }
    }
