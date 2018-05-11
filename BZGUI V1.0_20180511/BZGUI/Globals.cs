using System;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Data.OleDb;
using System.IO;
using BZGUI.Module.Setting;
using XCore;
using BZappdll;

namespace BZGUI
{
    class Globals
    {
        public Globals()
        { }
        /// <summary>
        /// 控件委托
        /// </summary>
        public static BZappdll.InvokerClass Invoker = new BZappdll.InvokerClass();
        public static BZappdll.CsvHelper csv = new BZappdll.CsvHelper();
        public static BZappdll.ComSub comf = new BZappdll.ComSub();
        public static DataTable dt_100data = new DataTable();
        public static DataTable dt_ErrCode = new DataTable();//以后给报警用

        #region Value变量

        public static bool isAdmin = false;
        public static bool Flag_ManualStart = false;//手动启动按钮
        public static MachineModeType MachineMode = MachineModeType.Production;
        public static bool SSHconnSt=false;         //ssh 的连接状态
        public static string SSHstring = "";        //SSH收到的使用String
        public static string BarcodeSN = "";        //条码的中间变量

        #endregion    
    
        #region path相关
        /// <summary>
        /// 当前设备重要程序重要参数:"D:\BZ-Parameter\MMS\"
        /// </summary>
        /// <remarks></remarks>
        public const string BZ_ParameterPath = PVar.BZ_ParameterPath; //BAM设备存放参数的路径路径
        public const string Dir_SettingPara = BZ_ParameterPath + "Setting\\SettingPara.xml";
        public const string Dir_SettingFunc = BZ_ParameterPath + "Setting\\SettingFunc.xml";
        public const string Dir_SettingMachineInfo = BZ_ParameterPath + "Setting\\SettingMachineInfo.xml";
        public const string Dir_SettingLaser = BZ_ParameterPath + "Setting\\SettingLaser.xml";
        public const string Dir_Task0_Machine =PVar.BZ_TaskLogPath + "Task0_Machinelog";
        public const string Dir_Task1_测试 = PVar.BZ_TaskLogPath + "Task1_测试log";
        public const string Dir_Task2_组装 = PVar.BZ_TaskLogPath + "Task2_组装log";
        public const string Dir_Task1_IPDM测试 = PVar.BZ_TaskLogPath + "Task2_组装log";
        public static string Dir_Bin = Application.StartupPath;
        public const string Dir_Record_Report = PVar.BZ_DataPath + "Report";
        public const string Dir_Record_Alarm = PVar.BZ_DataPath + "Alarm";
        public const string Dir_Record_Image = PVar.BZ_DataPath + "Images";
        public const string Dir_Record_Tossing = PVar.BZ_DataPath + @"Tossing\";
        public const string Dir_Record_UPH = PVar.BZ_DataPath + @"UPH\";
        public const string Dir_Record_Yield = PVar.BZ_DataPath + @"Yield\";
        public const string Dir_TempPara = PVar.BZ_DataPath + @"TempPara\";

        public static SettingPara settingPara = new SettingPara();
        public static SettingFunc settingFunc = new SettingFunc();
        public static SettingMachineInfo settingMachineInfo = new SettingMachineInfo();
        public static SettingLaser settingLaser = new SettingLaser();

        #endregion

        #region Bind初始化

        public static void BindDevice()
        {
            #region 创建文件夹

            CreateDirectory(PVar.BZ_TaskLogPath);
            CreateDirectory(Dir_Record_Report);
            CreateDirectory(Dir_Record_Image);
            CreateDirectory(Dir_Record_Tossing);
            CreateDirectory(Dir_Record_UPH);
            CreateDirectory(Dir_Record_Yield);

            #endregion

            #region 加载配置信息
            settingPara.SetPathAndRoot(Dir_SettingPara, "Setting");
            settingFunc.SetPathAndRoot(Dir_SettingFunc, "Setting");
            settingMachineInfo.SetPathAndRoot(Dir_SettingMachineInfo, "Setting");
            settingLaser.SetPathAndRoot(Dir_SettingLaser, "Setting");
            XSettingManager.Instance.BindSetting((int)SettingId.参数设定, settingPara, SettingId.参数设定.ToString());
            XSettingManager.Instance.BindSetting((int)SettingId.功能设定, settingFunc, SettingId.功能设定.ToString());
            XSettingManager.Instance.BindSetting((int)SettingId.设备参数, settingMachineInfo, SettingId.设备参数.ToString());
            XSettingManager.Instance.BindSetting((int)SettingId.Laser参数, settingLaser, SettingId.Laser参数.ToString());
            XSettingManager.Instance.LoadSettings();
            #endregion

            #region 绑定Task
            XTaskManager.Instance.BindTask((int)TasksId.Manchine, new Task0_Machine(Dir_Task0_Machine), TasksId.Manchine.ToString());
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            { XTaskManager.Instance.BindTask((int)TasksId.MMS测试, new Task1_MMS测试(Dir_Task1_测试), TasksId.MMS测试.ToString()); }
            else
            { XTaskManager.Instance.BindTask((int)TasksId.测试, new Task1_测试(Dir_Task1_测试), TasksId.测试.ToString()); }
            #endregion

            #region 加载参数
            ParaAxisFile.Instance.ReadParAxis(PVar.ParAxisPath, PVar.ParAxis);//读取机械参数
            ParaAxisFile.Instance.FresshMachinePar();//把1维参数转换成2维的机械参数
            Globals.dt_ErrCode = Globals.comf.ReadExcelByTable(BZ_ParameterPath + "Config\\ErrorCode.xls", 0);//read errcode
            #endregion
        }

        public static void InitDevice()
        {
            Gg.GTS_MotionInit(0, 1, Globals.Dir_Bin + "\\GTS_Config\\GTS800.cfg");
            mFunction.ReDimData();
            mFunction.ReadPosData(PVar.BZ_ParameterPath + "\\PosData.dat", mFunction.Pos);//加载点位
            if (!PVar.IsReadPosData)
            {
                if (Interaction.MsgBox("ReadPosData()函数读取数据失败，程序拒绝加载！", Constants.vbExclamation, "重要参数文件") == Constants.vbOK)
                {
                    ProjectData.EndApp();
                }
            }
        }

        public static void CloseDevice()
        {
            Gg.GTS_Close(0);
        }

        #endregion

        #region 网络定义

        public static TcpIPHelper TCPIP_PDCA = new TcpIPHelper();
        public static TcpIPHelper TCPIP_CCD1 = new TcpIPHelper();
        public static TcpIPHelper TCPIP_Scanner = new TcpIPHelper();
        #endregion

        #region 其他

        //Addlist at task 0---for machine
        public static void addList(string str,Color color)
        {
            XTaskManager.Instance.FindTaskById(0).SetStep(str, color);
        }
        //PostAlarm
        public static void PostAlarmMachine(XAlarmLevel level, int Code, string category, string append = "")
        {
            XTaskManager.Instance.FindTaskById(0).PostTaskAlarm(level, Code, category, append);//for errorcode
        }
        //using csvserve to write log,logpath is just like .../Logs/PDCAlog
        public static void WriteLog(string message,string logpath)
        {
            string path = logpath + "_" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            string str = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff") + " => " + message;
            CsvServer.Instance.WriteLine(path, str);
        }

        private static void CreateDirectory(string dir)
        {
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
        }
        #endregion

    }
}
