using System;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Data.OleDb;
using System.IO;
using BZGUI.Module.Setting;
using XCore;

namespace BZGUI
{
    public class PVar
    {
        public PVar()
        { 
        
        }

        public struct sFlag3
        {
            public bool Result;
            public bool Enable;
            public bool State;
        }

        public struct HomeType
        {
            public bool Result;
            public bool Enable;
            public bool State;
            public int Step;
            public short Capture;
            public int Counter;
            public int status;
            public int oldtime;
            public int TempPos;
        }

        public struct WorkType
        {
            public int Step; //步序号
            public bool Enable; //可否工作
            public bool State; //工作状态
            public bool Result; //工作结果
            public bool IsHaveHSG; //有无HSG
            public bool IsHavePianliao; //有无片料
            public bool IsHaveBlogo; //有无Blogo
            public bool IsHaveSN; //有无条码
            public double PressValue;  //压力值
        }

        #region 用户密码
        public struct sPassWord
        {
            public string[] NewGroup;
            public string[] NewUser; //新用户
            public string[] NewPassword; //新密码
            public string[] NewPasswordChecked; //新密码确认
            public short[] NewUserAuthority; //用户权限
        }
        public static sPassWord Login;
        #endregion

        #region 数组ReDim

        public static void ReDimSpassWord()
        {
            Login.NewGroup = new string[21];
            Login.NewUser = new string[21];
            Login.NewPassword = new string[21];
            Login.NewPasswordChecked = new string[21];
            Login.NewUserAuthority = new short[21];
            ParAxis.Speed = new double[13];
            ParAxis.pulse = new double[13];
            ParAxis.Ratio = new double[13];
            ParAxis.Lead = new double[13];
            PVar.ParList.Data = new double[201];
            PVar.ParList.MacInfo = new string[21];
            PVar.ParList.CheckSts = new bool[101];
        }

        #endregion

        #region BZ 自定义颜色常量
        public static Color BZColor_SelectedBtn = Color.FromArgb(175, 218, 150);
        public static Color BZColor_UnselectedBtn = Color.FromArgb(238, 238, 238);
        public static Color BZColor_SelectedPauseBtn = Color.FromArgb(132, 193, 251);
        public static Color BZColor_SelectedEndBtn = Color.FromArgb(228, 146, 138);
        public static Color BZColor_ErrorRed = Color.FromArgb(236, 93, 87);
        #endregion

        #region 窗体操作变量
        public static bool IsSystemOnPauseMode;
        public static bool IsSysOnEngineerMode;
        public static bool IsSysOnAutoRunMode;
        public static bool IsSysOnManualMode;
        public static bool IsSysInitialized;
        public static bool IsSysInitializing;
        public static bool IsAirOrVacuumAlarm;
        public static bool IsSysErrorOccured;
        #endregion

        #region 系统变量
        public static bool IsOpenFrmEngineering;
        public static bool IsOpenFrmProduction;
        public static bool IsOpenFrmManual = false;
        public static bool IsLoadFrmEngineering;
        public static bool IsOpenFrmLogin;
        public static bool LoginFrmEngineeringEnable; //工程界面
        public static bool LoginFrmParEnable; //参数界面
        public static bool LoginFrmParCCDEnable;
        public static bool LoginOutputEnable; //I/O输出界面
        public static bool LoginManualEnable; //机械参数界面
        public static bool LoginMachineParEnable; //机械参数界面
        public static string[] CheckEnableString = new string[48];
        public static int LightCMDSendTime;
        public static int CMDSendTime;
        public static double StorCycleTimer;
        public static bool IsCOM1_Working = false;
        public static bool IsCOM2_Working = false;
        public static bool IsCOM3_Working = false;
        public static bool ChangeF = false;

        public static long[] TimeStart = new long[11]; //用于计时
        public static long CT;
        public static long[] StaTime = new long[21]; //时间存储变量
        public static string S2RbtSendStr; //接收机械手返回字符
        public static double[] LoadCell = new double[3];
        public static double[] LoadCell_Value = new double[5];
        public static bool AutoRunFlag; //自动运行标志位
        public static int DataCount;
        public static bool[] PortOpenFlag = new bool[7];
        public static string MachineName; //存储条码
        public static bool Stop_Flag; //停止标志位
        public static bool MacHold; //机器暂停标志
        public static bool Dialogfrm; //提示窗体加载标志
        public static Point ChildFrmOffsetPoint; //各子界面在主界面中位置定位点
        public static string sOpenTargetForm; //主界面开启相关界面时，传递窗口名称变量

        public static bool isShowAxisPara = false;//显示Super admin

        /// <summary>
        /// 急停是否按下标志
        /// </summary>
        /// <remarks></remarks>
        public static bool IsSysEmcStop;
        public static bool IsSysStop;
        public static bool IsSysPause;
        public static MachineType machineType = MachineType.DisAutoRun;
        public enum MachineType
        {
            DisAutoRun,
            AutoRun,
            Runing,
            Stoped,
            Pause,
            Manual,
            Ready,
            Hold
        }

        public struct Propotys
        {
            public bool Enable;
            public bool Stoped;
            public bool Runing;
            public bool Ready;
            public bool Pause;
            public bool Manual;
        }
        public static Propotys Autorun;
        /// <summary>
        /// 16位PDCA数据
        /// </summary>
        /// <remarks></remarks>
        public static string[] sPDCAData = new string[16];
        /// <summary>
        /// 单双标志，值1为单，2为双
        /// </summary>
        /// <remarks></remarks>
        public static int DS_Flag;
        /// <summary>
        /// 三色灯状态序号：
        /// 【10】异常报警,
        /// 【20】设备初始化完毕,
        /// 【30】机器工作正常,
        /// 【40】机器空跑,
        /// 【50】开机无报警
        /// </summary>
        /// <remarks></remarks>
        public static int LampStatus;

        public static int KeyNum;

        public static bool AutoLoadCellFlag = false;

        public static bool Ring_EN; //蜂鸣器
        public static bool ChangeLight_EN; //换料

        public struct mPar
        {
            public double[] Data;
            public string[] MacInfo;
            /// <summary>
            /// 1:开启安全门；
            /// 2：开启手持条码枪；
            /// 3：设备镜像；
            /// 4：开启外部条码；
            /// 5：开启SF路径检测；
            /// 6：；
            /// 7：开启夹紧定位扫条码；
            /// 8:空跑开启截图；
            /// 17：开启演示功能；
            /// 18：开启一次补正功能；
            /// 19：开启Errorcode；
            /// 20：勾上开启PDCA；
            /// 21：开启HeatBt；
            /// </summary>
            /// <remarks></remarks>
            public bool[] CheckSts;
        }

        public static mPar ParList;

        //程序第一次加载判断参数是否加载成功
        public static bool IsReadParData;
        public static bool IsReadPosData;
        /// <summary>
        /// 工作模式：正常生产[0],CPK[1],空跑[2]
        /// </summary>
        /// <remarks></remarks>
        public static short Work_Mode = (short)1;
        public static string[] DataGrid_CheckDataHeadName = new string[] { "Date", "Time", "SN", "Result", "X", "Y", "A", "Dis"};
        public static string[] DataGrid_IPDMCheckDataHeadName = new string[] { "Date", "Time", "SN", "Result", "IPD_Left1", "IPD_Right1", "IPD_Left2", "IPD_Right2" };

        public static string[] BarcodeArrayList = new string[100]; //定义界面存储的数据

        #endregion

        #region 工作状态参数定义

        /// <summary>
        /// 0：供料站；
        /// 1：人工站；
        /// 2：组装站；
        /// 3：保压站；
        /// 4：复检站；
        /// </summary>
        /// <remarks></remarks>
        public static WorkType[] Sta_Work = new WorkType[11];

        #endregion

        #region Feeder上的物料索引定义
        public struct NumData
        {
            public int MaterialCnt;
        }

        public static NumData Blogo;
        #endregion

        #region 2维矩阵参数设定
        public static long Feed1_RowNumber; //行
        public static long Feed1_ColNumber; //列
        public const double Feed1_RowDist = 8.15; //行间距mm
        public const double Feed1_ColDist = 11.167; //列间距mm
        public const double Feed_P1_ColDist = 21.05; //列间距mm
        public static double[] Feed1_ArrayX = new double[90]; //片料X矩阵
        public static double[] Feed1_ArrayY = new double[90]; //片料Y矩阵
        public const double Feed1_2Dist = 7.22; //第1列到二间距mm
        public const double Feed_P1_2Dist_1 = 7.73; //第1列到二间距mm

        //Public Const Feed1_RowNumber_1 As Long = 15  '行
        //Public Const Feed1_ColNumber_1 As Long = 6    '列
        public const double Feed1_RowDist_1 = 8.15; //行间距mm
        public const double Feed1_ColDist_1 = 19.58; //列间距mm
        public static double[] Feed1_ArrayX_1 = new double[90]; //片料X矩阵
        public static double[] Feed1_ArrayY_1 = new double[90]; //片料Y矩阵
        public const double Feed1_2Dist_1 = 4.88; //第1列到二间距mm
        #endregion

        #region 光源控制
        public static string ColorSelectd = "P10";
        #endregion

        #region Path所有文件路径名称定义

        /// <summary>
        /// "D:\\BZ-Program\\"; //复制到本机路径上
        /// </summary>
        public const string FileDirectoryDes = "D:\\BZ-Program\\"; //复制到本机路径上

        /// <summary>
        /// 当前程序存放路径:"D:\BZ-Program\BZGUI\"BZGUI
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_ProgramPath = "D:\\BZ-Program\\BZGUI\\"; //BAM设备存放程序的路径路径
        /// <summary>
        /// 当前设备重要程序重要参数:"D:\BZ-Parameter\BZGUI\"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_ParameterPath = "D:\\BZ-Parameter\\BZGUI\\"; //BAM设备存放参数的路径路径

        /// <summary>
        /// "\\\\169.254.0.10\\live\\";服务器上软件地址
        /// </summary>
        public const string FileDirectorySrc = "\\\\169.254.0.10\\live\\"; //服务器上软件地址

        /// <summary>
        /// 当前设备存放数据路径:"E:\BZ-Data\"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_DataPath = "D:\\BZ-Data\\"; //BAM设备存放数据路径
        /// <summary>
        /// 存放复检数据路径:"E:\BZ-Data\MMS\CheckData\"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_CheckDataPath = BZ_DataPath+"CheckData\\";
        /// <summary>
        /// 运行日志路径："E:\BZ-Data\MMS\RunLog\"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_LogPath = BZ_DataPath + "Logs\\RunLog\\";
        public const string BZ_PDCALogPath = BZ_DataPath + "Logs\\PDCAlog\\";
        public const string BZ_TaskLogPath = BZ_DataPath + "Logs\\Tasklog\\";
        public const string BZ_CaliLogPath = BZ_DataPath + "Logs\\Calilog\\";
        /// <summary>
        /// CPK数据存ini路径:"D:\BZ-Parameter\BAM\CPKData.dat"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_CPKDataFilePath = BZ_DataPath + "CPKData.dat";
        /// <summary>
        ///当天良率存放in路径:"D:\BZ-Parameter\BAM\YieldData.ini"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_YieldDataFileName = BZ_DataPath + "YieldData.ini";
        /// <summary>
        /// 标定信息存储路径"D:\BZ-Parameter\BAM\Calibration.ini"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_CalibrationFileName = BZ_DataPath + "Calibration.ini";
        /// <summary>
        /// 机械手里面的点位缓存
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_RobotPosFileName = BZ_DataPath + "RobotPos.ini";
        /// <summary>
        /// 当月良率存放路径:"D:\BZ-Parameter\BAM\YieldMonthData.dat"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_YieldMonthDataFileName = BZ_DataPath + "YieldMonthData.dat";
        /// <summary>
        /// 抛料统计文件路径:"D:\BZ-Parameter\BAM\ErrStatistics.ini"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_ErrStatisticsPath = BZ_DataPath + "ErrStatistics.ini";
        /// <summary>
        /// 存放图片路径:"E:\BZ-Data\MMS\CCD_Image\当前日期\CCD1\"
        /// </summary>
        /// <remarks></remarks>
        public static string BZ_CCD1_ImagePath = BZ_DataPath + "CCD_Image\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "\\CCD1\\"; //存放图片路径
        public static string BZ_CCD2_ImagePath = BZ_DataPath + "CCD_Image\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "\\CCD2\\"; //存放图片路径
        public static string BZ_CCD_ImagePath = BZ_DataPath + "CCD_Image\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "\\";
        /// <summary>
        /// 光源参数存放路径:"D:\BZ-Parameter\BAM\LightSetting.ini"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_LightSettingPath = BZ_ParameterPath + "LightSetting.ini";
        /// <summary>
        /// 异常记录CSV文件路径："E:\BZ-Data\MMS\AlarmHistory_Data\BAMAlarmHistory.csv"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_AlarmHistoryCSVPath = BZ_DataPath + "AlarmHistory_Data\\BAMAlarmHistory.csv";

        public const string ListDataIniPath = BZ_ParameterPath + "GridViewData100.csv";
        public const string ListDataIniPathIPDM = BZ_ParameterPath + "GridViewDataIPDM100.csv";
        /// <summary>
        /// "D:\BZ-Parameter\BAM\PublicPar.ini"
        /// </summary>
        /// <remarks></remarks>
        public const string PublicParPath = BZ_ParameterPath + "PublicPar.ini";
        /// <summary>
        /// "D:\BZ-Parameter\BAM\ParAxis.dat"
        /// </summary>
        /// <remarks></remarks>
        public const string ParAxisPath = BZ_ParameterPath + "ParAxis.dat";
        /// <summary>
        /// "D:\BZ-Parameter\BAM\CPK_SN.ini"
        /// </summary>
        /// <remarks></remarks>
        public const string CPK_SN_Path = BZ_ParameterPath + "CPK_SN.ini";
        public const string ManualPath = BZ_DataPath + "ManualPath.ini";

        #endregion

        #region 功能：数据统计定义

        public static double[] StorYieldOverView = new double[31];
        public static double[] StorTossing = new double[31];
        public static double[] StorUPH = new double[31];
        public static string[] StorXData = new string[31];
        public static string strUserSelYieldOrRetest; //Yield 或者 Retest
        public static float TodayNGYeildUI; //分别为当天与最近一月的产品产出良率,保留小数点后一位
        public static float OneMonthNGYeildUI;
        public static float TodayRetestUI; //分别为当天与最近一月的产品重测率,保留小数点后一位
        public static float OneMonthRetestUI;
        public static float TodayOKYeildUI;
        public static float TodayTossingUI;
        public static float TodayUphUI;
        #endregion

        #region BAM 变量定义
        public static short Rtn;
        public struct Limit
        {
            public double max;
            public double min;
        }

        public struct a
        {

        }

        public struct CCDDataType
        {
            public double X;
            public double Y;
            public double T;
            public double A;
            public double L;
            public double CC;
            public double Judge;
        }

        //CCD相关参数
        public static string[] CCD1_Data = new string[21];
        public static string CCD1_StrData;
        public static string[] CCD2_Data = new string[21];
        public static string CCD2_StrData;
        public static string HeatBtReceiveStr;
        public static bool CCD1IsWorking;
        public static bool CCD2IsWorking;
        public static short[] CCD1TrigNumber = new short[6];
        public static short[] CCD2TrigNumber = new short[6];
        public static double[] PressTime = new double[4];
        /// <summary>
        /// 版本编号格式：0x.xx
        /// </summary>
        /// <remarks></remarks>
        public static string MeshineSW = "00.00";
        public const string ErrorCodeIPName = "\\\\169.254.0.10\\Workspace";
        public const string ErrorCodeDeviCename = "BAM"; //999999'//设备名称（在ErrorCode中用）
        public struct ERR_Information
        {
            public string ErrorCode;
            public string ErrDescription;
            public int NUM;
            public ERR_Information(string strErrorCode, string strErrDescription)
            {
                this.ErrorCode = strErrorCode;
                this.ErrDescription = strErrDescription;
                this.NUM = 0;
            }
        }
        public static ERR_Information[] ERROR_CODE = new ERR_Information[] {
                new ERR_Information("ERR-ESB01-10001", "Manually pressed"),
                new ERR_Information("ERR-DOR01-10001", "Manually opened"),
                new ERR_Information("ERR-Servo04-30001", "Hold pressure X Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo05-30001", "Hold pressure Y Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo06-30001", "Hold pressure Z Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo07-30001", "Hold pressure R Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo08-30001", "Feeder Z Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo10-30001", "Reclaimer CCD X Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo11-30001", "Reclaimer light X Motor /driver abnormal alarm"),
                new ERR_Information("ERR-Servo04-30002", "Hold pressure X  Motor Plus limit alarm"),
                new ERR_Information("ERR-Servo05-30002", "Hold pressure Y  Motor Plus limit alarm"),
                new ERR_Information("ERR-Servo06-30002", "Hold pressure Z  Motor Plus limit alarm"),
                new ERR_Information("ERR-Servo08-30002", "Feeder Z  Motor Plus limit alarm"),
                new ERR_Information("ERR-Servo10-30002", "Reclaimer CCD X  Motor Plus limit alarm"),
                new ERR_Information("ERR-Servo11-30002", "Reclaimer light X  Motor Plus limit alarm"),
                new ERR_Information("ERR-Servo04-30003", "Hold pressure X Motor Negative limit alarm"),
                new ERR_Information("ERR-Servo05-30003", "Hold pressure Y Motor Negative limit alarm"),
                new ERR_Information("ERR-Servo06-30003", "Hold pressure Z Motor Negative limit alarm"),
                new ERR_Information("ERR-Servo07-30003", "Hold pressure R Motor Negative limit alarm"),
                new ERR_Information("ERR-Servo08-30003", "Feeder Z Motor Negative limit alarm"),
                new ERR_Information("ERR-Servo10-30003", "Reclaimer CCD X Motor Negative limit alarm"),
                new ERR_Information("ERR-Servo11-30003", "Reclaimer light X Motor Negative limit alarm"),
                new ERR_Information("ERR-RBC01-10001", "Robot communication abnormal"),
                new ERR_Information("ERR-RBC01-20001", "Robot alarm"),
                new ERR_Information("ERR-FXA01-20001", "Hold pressure sensor communication abnormal"),
                new ERR_Information("ERR-FXA01-30001", "Assembly Tray Vacuum Abnormal"),
                new ERR_Information("ERR-FXA01-30002", "Hold pressure Tray Vacuum Abnormal"),
                new ERR_Information("ERR-FXA01-30003", "No.1 Nozzle Vacuum Abnormal"),
                new ERR_Information("ERR-FXA01-30004", "Main Positive Pressure Abnormal"),
                new ERR_Information("ERR-FXA01-30005", "Main Negative Pressure Abnormal"),
                new ERR_Information("ERR-FXB01-30001", "Rotation cylinder arrives signal abnormal"),
                new ERR_Information("ERR-FXB02-30001", "Assembly lift cylinder arrives signal abnormal"),
                new ERR_Information("ERR-FXB03-30001", "Assembly push cylinder arrives signal abnormal"),
                new ERR_Information("ERR-FXB04-30001", "Hold pressure lift cylinder arrives signal abnormal"),
                new ERR_Information("ERR-FXB05-30001", "Hold pressure push cylinder arrives signal abnormal"),
                new ERR_Information("ERR-FXB01-30002", "Rotation cylinder retract signal abnormal"),
                new ERR_Information("ERR-FXB02-30002", "Assembly lift cylinder return signal abnormal"),
                new ERR_Information("ERR-FXB03-30002", "Assembly push cylinder return signal abnormal"),
                new ERR_Information("ERR-FXB04-30002", "Hold pressure lift cylinder return signal abnormal"),
                new ERR_Information("ERR-FXB05-30002", "Hold pressure push cylinder return signal abnormal"),
                new ERR_Information("ERR-CCD01-20001", "CCD1 communication abnormal"),
                new ERR_Information("ERR-CCD02-20001", "CCD2 communication abnormal"),
                new ERR_Information("ERR-SSW01-50201", "PDCA communication abnormal"),
                new ERR_Information("ERR-BSC01-20001", "Barcode scanner communication abnormal"),
                new ERR_Information("ALM-PFC01-60101", "MIC2 Membrane run out"),
                new ERR_Information("WRN-PFC01-70101", "MIC2_Membrane 5 times picture capturing abnormal"),
                new ERR_Information("WRN-PFC02-70101", "MIC2 Membrane 3 times picking-up abnormal"),
                new ERR_Information("TOS-PFC01-70201", "MIC2 Membrane tossing abnormal"),
                new ERR_Information("NPK-PFC01-70601", "MIC2 Membrane missing")};

        #endregion

        #region 机械参数结构体
        public struct pAxis
        {
            public double[] Speed;
            public double[] pulse;
            public double[] Ratio;
            public double[] Lead;
        }
        /// <summary>
        /// 各参数集合
        /// </summary>
        /// <remarks></remarks>
        public static pAxis ParAxis;
        #endregion

        #region 数据库 变量定义
        public static OleDbConnection Conn = new OleDbConnection(); //数据库连接
        public static OleDbCommand CmdView = new OleDbCommand();
        public static OleDbDataReader Dr;
        public static string CurrentDate;
        public static string BeforeDate;

        public static string TrayiniFileName;
        public static string FeederiniFileName;
        public static string RecordiniFileName;
        public static string GrriniFileName;
        public static string LightiniFileName;

        public static string UIFileName;
        public static string UICpkFileName;

        public static string AlarmHistoryFileName;

        public static string UIChartCurveName;
        public static string UIChartHistogramName;
        public static string UIChartYieldOverViewName;
        public static string UIRateName;
        #endregion

        #region 物料变量
        public static int PalletRowNum = 15;
        public static int PalletColumnNum = 4;
        public static int PalletSelectNum;
        #endregion

        #region CPK结构体

        public static double[] Press;
        public struct CPKData
        {
            public double[] X;
            public double[] Y;
            public double[] A;
            public double[] CC;
            public DateTime[] ProTime;

        }

        public static CPKData tmpCpkData = new CPKData();
        #endregion

        #region 产量统计
        public static int ProductCounts = int.Parse(BVar.FileRorW.ReadINI("Product", "Counts", System.Convert.ToString(0), BZ_ParameterPath + "YieldData.ini"));
        public static int OKCounts = int.Parse(BVar.FileRorW.ReadINI("Product", "OKCounts", System.Convert.ToString(0), BZ_ParameterPath + "YieldData.ini"));
        public static int NGCounts = int.Parse(BVar.FileRorW.ReadINI("Product", "NGCounts", System.Convert.ToString(0), BZ_ParameterPath + "YieldData.ini"));
        public static long TotalLifeCycles = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeCycles", System.Convert.ToString(0), BZ_ParameterPath + "YieldData.ini"));
        public static long TotalLifeRejects = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeRejects", System.Convert.ToString(0), BZ_ParameterPath + "YieldData.ini"));
        #endregion

        #region 计算良率相关变量
        public static double DayYieldOfNg;
        public static double MonthYieldOfNg;
        public static int NgCountOfDay;
        public static int ProductCountOfDay;
        public static int NgCountOfMonth;
        public static int ProductCountOfMonth;
        public static string RecordTimeOfDate;
        public static string RecordTimeOfMonth;

        public struct YieldOfMonthData
        {
            public int[] ProductCount;
            public int[] NgCount;
            public DateTime[] RecordTime;
        }

        public static YieldOfMonthData YieldOfMonth;

        #endregion

        #region 异常统计变量
        public static int CPKCounts;
        public static int CPKDoneCounts;
        public static int PickCCDErrCounts;
        public static int PickErrCounts;
        public static int HsgSnErrCounts;
        public static int HsgErrCounts;
        public static int MEMErrCounts;
        public static int WorkMode;
        #endregion

    }


}
