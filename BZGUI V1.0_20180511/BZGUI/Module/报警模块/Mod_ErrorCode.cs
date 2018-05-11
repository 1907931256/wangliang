
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
using System.IO;
using System.Threading;

namespace BZGUI
    {
    sealed class Mod_ErrorCode
        {
        public static bool Err_Light;
        public static string[] ErrorCodeName = new string[11]; ////异常代码
        public static int[] IndexNum = new int[11]; ////异常代码序号
        public static bool ErrorCodeOccur; ////是否有错误产生
        public static string ErrorCodeStarteTime; ////异常开始时间
        public static string ErrorCodeEndTime; ////异常结束时间
        public static string LightStatusERR;
        public static string[] ErrorPath = new string[6]; ////公用路径
        private static string[] WriteDataThread = new string[11];
        private static int[] indexThread = new int[11];
        static Thread WriteErrorCodeThread = null;
        static Thread WriteErrorCodeTOSThread = null;
        static Thread WriteCsvErrorCodeOKThread = null;
        /// <summary>
        /// WriteErrorCode（[报警内容] , [报警类型]）
        /// </summary>
        /// <param name="WriteData"></param>
        /// <param name="index"></param>
        /// <remarks></remarks>
        public static void WriteErrorCode(string WriteData, int index)
            {
            if (PVar.ParList.CheckSts[19])
                {
                WriteDataThread[0] = WriteData;
                indexThread[0] = index;
                WriteErrorCode_Once(WriteErrorCodeThread);
                }
            }
        private static void WriteErrorCode_Once(Thread threadName)
            {
            if (threadName == null)
                {
                threadName = new Thread(new ThreadStart(WriteErrorCode_Thread));
                threadName.Start();
                threadName.Priority = ThreadPriority.Normal;
                }
            }
        private static void WriteErrorCode_Thread()
            {
            string ErrorCodeAnnotationEH = "String";
            string[] FileName = new string[5];
            ErrorCodeName[0] = WriteDataThread[0];
            IndexNum[0] = indexThread[0];
            if (ErrorCodeOccur == false) //And IsAutoRun.Enable = True
                {
                ErrorCodeOccur = true;
                switch (ErrorCodeName[0])
                    {
                    //安全门和急停**********************************************************************
                    case "ERR-ESB01-10001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[EmergencyBTN][Manually pressed]" + "Manually pressed";
                        Err_Light = true;
                        break;

                    case "ERR-DOR01-10001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[SafetyDoor][Manually opened]" + "Manually opened";
                        Err_Light = true;
                        break;

                    //驱动器报警**********************************************************************
                    case "ERR-Servo04-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Hold pressure X Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo05-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Hold pressure Y Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo06-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Hold pressure Z Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo07-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Hold pressure R Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo08-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Feeder Z Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo010-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Reclaimer CCD X Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo011-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-axis][Functional NG events][Axis-alarm]" + "Reclaimer light X Motor /driver abnormal alarm";
                        Err_Light = true;
                        break;


                    //正极限报警**********************************************************************
                    case "ERR-Servo04-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure X  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo05-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure Y  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo06-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure Z  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo07-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure R  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo08-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Feeder Z  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo10-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Reclaimer CCD X  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo11-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Reclaimer light X  Motor Plus limit alarm";
                        Err_Light = true;
                        break;

                    //负极限报警**********************************************************************
                    case "ERR-Servo04-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure X Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo05-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure Y Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo06-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure Z Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo07-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Hold pressure R Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo08-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Feeder Z Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo10-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Reclaimer CCD X Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    case "ERR-Servo11-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Servo-limit][Functional NG events][Limit-alarm]" + "Reclaimer light X Motor Negative limit alarm";
                        Err_Light = true;
                        break;

                    //机械手报警**********************************************************************
                    case "ERR-RBC01-10001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Functional NG events][Robot-alarm]" + "Robot alarm";
                        Err_Light = true;
                        break;

                    case "ERR-RBC01-20001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[RobotControl][Communication NG events]" + "Robot communication abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXA01-20001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Conveyor][Communication NG events]" + "Hold pressure sensor communication abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXA01-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Conveyor][Functional NG events][Vacuum]" + "Assembly Tray Vacuum Abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXA01-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Conveyor][Functional NG events][Vacuum]" + "Hold pressure Tray Vacuum Abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXA01-30003":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Conveyor][Functional NG events][Vacuum]" + "No.1 Nozzle Vacuum Abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXA01-30004":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Nozzle][Functional NG events][Pressure]" + "Main Positive Pressure Abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXA01-30005":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[Nozzle][Functional NG events][Pressure]" + "Main Negative Pressure Abnormal";
                        Err_Light = true;
                        break;

                    //气缸磁黄信号异常**********************************************************************
                    case "ERR-FXB01-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][reach fail]" + "Rotation cylinder arrives signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB02-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][reach fail]" + "Assembly lift cylinder arrives signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB03-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][reach fail]" + "Assembly push cylinder arrives signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB04-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][reach fail]" + "Hold pressure lift cylinder arrives signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB05-30001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][reach fail]" + "Hold pressure push cylinder arrives signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB01-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][Cylinder retract fail]" + "Rotation cylinder retract signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB02-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][Cylinder retract fail]" + "Assembly lift cylinder return signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB03-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][Cylinder retract fail]" + "Assembly push cylinder return signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB04-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][Cylinder retract fail]" + "Hold pressure lift cylinder return signal abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-FXB05-30002":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[InputTrayCylinder][Functional NG events][Cylinder retract fail]" + "Hold pressure push cylinder return signal abnormal";
                        Err_Light = true;
                        break;

                    //CCD,PDCA,条码枪通信异常**********************************************************************
                    case "ERR-CCD01-20001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[CCD][Communication NG events]" + "CCD1 communication abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-CCD02-20001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[CCD][Communication NG events]" + "CCD2 communication abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-SSW01-50201":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[SystemSW][PDCA messaging errors]" + "PDCA communication abnormal";
                        Err_Light = true;
                        break;

                    case "ERR-BSC01-20001":
                        LightStatusERR = "Red";
                        ErrorCodeAnnotationEH = "[BSC][Communication NG events]" + "Barcode scanner communication abnormal";
                        Err_Light = true;
                        break;

                    //抛料异常**********************************************************************
                    case "ALM-PFC01-60101":
                        LightStatusERR = "Yellow";
                        ErrorCodeAnnotationEH = "[Workflow][Material-empty alarms][MIC2 Membrane]" + "MIC2 Membrane run out";
                        Err_Light = true;
                        break;

                    case "WRN-PFC01-70101":
                        LightStatusERR = "Yellow";
                        ErrorCodeAnnotationEH = "[Workflow][Process retry-proof events][MIC2 Membrane]" + "MIC2_Membrane 5 times picture capturing abnormal";
                        Err_Light = true;
                        break;

                    case "WRN-PFC02-70101":
                        LightStatusERR = "Yellow";
                        ErrorCodeAnnotationEH = "[Workflow][Process retry-proof events][MIC2 Membrane]" + "MIC2 Membrane 3 times picking-up abnormal";
                        Err_Light = true;
                        break;

                    case "TOS-PFC01-70201":
                        LightStatusERR = "Yellow";
                        ErrorCodeAnnotationEH = "[Workflow][MachineVision tossing events][MIC2 Membrane]" + "MIC2 Membrane tossing abnormal";
                        Err_Light = true;
                        break;

                    case "NPK-PFC01-70601":
                        LightStatusERR = "Yellow";
                        ErrorCodeAnnotationEH = "[Workflow][No-pickup-part events][MIC2 Membrane]" + "MIC2 Membrane missing";
                        Err_Light = true;
                        break;

                    }

                ErrorPath[2] = "E:\\AE\\ErrorCode\\NG\\";
                ErrorPath[0] = "E:\\AE\\ErrorCode\\NG\\BAM_DT_NG.csv";
                ErrorPath[3] = "\\\\169.254.0.10\\gdlocal\\Public\\Workspace\\AlarmFiles\\" + "Alarm_" + PVar.ErrorCodeDeviCename + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmmss") + ".csv";
                ErrorCodeOccur = true;

                if (System.IO.File.Exists(ErrorPath[2]) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory(ErrorPath[2]);
                    }

                if (System.IO.File.Exists(ErrorPath[0]) != false)
                    {
                    DeleteFile(ErrorPath[0]);
                    }

                FileName[0] = "DateTime,Project,BU,Floor,Line,AE ID,AE SubID,AE Vendor,Machine SN,SW rev.,HW rev.,Time Mode,Error Code,Error Description,Color,Notes";
                FileName[1] = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + PVar.ParList.MacInfo[1] + "," + PVar.ParList.MacInfo[2] + "," + PVar.ParList.MacInfo[3] + "," + PVar.ParList.MacInfo[4] + "," + PVar.ParList.MacInfo[5] + "," + PVar.ParList.MacInfo[6] + "," + PVar.ParList.MacInfo[7] + "," + PVar.ParList.MacInfo[8] + "," + "BZ-" + PVar.MeshineSW + "-" + PVar.ParList.MacInfo[9] + "-NN.NN-NN.NN" + "," + PVar.ParList.MacInfo[10] + "," +
                    "0 " + "," + ErrorCodeName[0] + "," + ErrorCodeAnnotationEH + "," + LightStatusERR + "," + "AE:Contact BZ";
                //记录发生的一切ERRor
                FileName[4] = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (System.IO.File.Exists(ErrorPath[0]) == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], ErrorPath[0]);
                    }
                BVar.FileRorW.WriteCsv(FileName[1], ErrorPath[0]);

                //总体数据统计
                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd")) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory("E:\\" + "BZ-Data" + "\\AlarmFiles" + "\\" + DateTime.Now.ToString("yyyy-MM-dd"));
                    }

                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv") == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], "E:\\BZ-Data\\AlarmFiles" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");
                    }
                BVar.FileRorW.WriteCsv(FileName[1], "E:\\BZ-Data\\AlarmFiles" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");

                WriteMachineIniFile("Machine", "ErrorCodeOccur", System.Convert.ToString(1));
                WriteMachineIniFile("Machine", "LightStatusERR", LightStatusERR);
                WriteMachineIniFile("Machine", "ErrorCodeName", ErrorCodeName[0]);
                WriteMachineIniFile("Machine", "ErrorCodeStarteTime", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                WriteMachineIniFile("Machine", "ErrorCodeCategory", ErrorCodeAnnotationEH);

                Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(ErrorPath[0], ErrorPath[3]);
                }
            }

        public static void WriteCsvErrorCodePRE_Thread()
            {
            string[] FileName = new string[5];
            string[] FilePath = new string[3];
            if (PVar.ParList.CheckSts[19])
                {
                FilePath[0] = "D:\\BZ-Parameter\\BAM\\AlarmHistoryData.ini";
                ErrorPath[2] = "E:\\AE\\ErrorCode\\OK\\";
                ErrorPath[0] = "E:\\AE\\ErrorCode\\OK\\BAM_DT_OK.csv";
                ErrorPath[3] = "\\\\169.254.0.10\\gdlocal\\Public\\Workspace\\AlarmFiles\\" + "Alarm_" + PVar.ErrorCodeDeviCename + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmmss") + ".csv";
                ErrorCodeOccur = bool.Parse(ReadMachineIniFile("Machine", "ErrorCodeOccur"));

                if (System.IO.File.Exists(ErrorPath[0]) != false)
                    {
                    DeleteFile(ErrorPath[0]);
                    }

                if (System.IO.File.Exists(ErrorPath[2]) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory(ErrorPath[2]);
                    }
                Err_Light = true;
                FileName[0] = "DateTime,Project,BU,Floor,Line,AE ID,AE SubID,AE Vendor,Machine SN,SW rev.,HW rev.,Time Mode,Error Code,Error Description,Color,Notes";
                FileName[1] = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + PVar.ParList.MacInfo[1] + "," + PVar.ParList.MacInfo[2] + "," + PVar.ParList.MacInfo[3] + "," + PVar.ParList.MacInfo[4] + "," + PVar.ParList.MacInfo[5] + "," + PVar.ParList.MacInfo[6] + "," + PVar.ParList.MacInfo[7] + "," + PVar.ParList.MacInfo[8] + "," + "BZ-" + PVar.MeshineSW + "-" + PVar.ParList.MacInfo[9] + "-NN.NN-NN.NN" + "," + PVar.ParList.MacInfo[10] + "," +
                    "0" + "," + "PRE" + "," + "System in preparation mode" + "," + "Red" + "," + "N/A";
                //\\记录发生的一切ERRor
                FileName[4] = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (System.IO.File.Exists(ErrorPath[0]) == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], ErrorPath[0]);
                    }
                BVar.FileRorW.WriteCsv(FileName[1], ErrorPath[0]);

                //\\\\\\\\\\\\\\总体数据统计
                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd")) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd"));
                    }
                System.IO.File.Copy(ErrorPath[0], ErrorPath[3], true);

                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv") == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], "E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");
                    }
                BVar.FileRorW.WriteCsv(FileName[1], "E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");
                }

            }

        public static string ReadMachineIniFile(string Section, string AppName)
            {
            string returnValue = "";
            string Filepath = "D:\\BZ-Parameter\\BAM\\MachineSetting.ini";
            returnValue = BVar.FileRorW.ReadINI(Section, AppName, System.Convert.ToString(0), Filepath);
            return returnValue;
            }

        public static void WriteMachineIniFile(string Section, string AppName, string lpString)
            {
            string Filepath = "D:\\BZ-Parameter\\BAM\\MachineSetting.ini";
            BVar.FileRorW.WriteINI(Section, AppName, lpString, Filepath);
            }

        public static void WriteErrorCodeTOS(string WriteData, int index)
            {
            WriteDataThread[1] = WriteData;
            indexThread[1] = index;
            WriteErrorCodeTOS_Once(WriteErrorCodeTOSThread);
            }

        private static void WriteErrorCodeTOS_Once(Thread threadName)
            {
            if (threadName == null)
                {
                threadName = new Thread(new ThreadStart(WriteErrorCodeTOS_Thread));
                threadName.Start();
                threadName.Priority = ThreadPriority.Normal;
                }
            }

        public static void WriteErrorCodeTOS_Thread()
            {
            string ErrorCodeAnnotationEH = "";
            string[] FileName = new string[5];
            ErrorCodeName[1] = WriteDataThread[1];
            ErrorCodeAnnotationEH = "String";
            if (PVar.ParList.CheckSts[19] && PVar.Autorun.Enable == true && ErrorCodeOccur == false) //
                {
                switch (ErrorCodeName[1])
                    {
                    case "TOS-PFC01-70203":
                        LightStatusERR = "";
                        ErrorCodeAnnotationEH = "[Workflow][MachineVision tossing events][MIC Membrane]MIC Membrane tossing abnormal";
                        break;

                    case "NPK-PFC01-70602":
                        LightStatusERR = "";
                        ErrorCodeAnnotationEH = "[Workflow][No-pickup-part events][MIC Membrane]MIC Membrane missing";
                        break;
                    }

                ErrorPath[2] = "E:\\AE\\ErrorCode\\NG\\";
                ErrorPath[0] = "E:\\AE\\ErrorCode\\NG\\BAM_DT_NG.csv";
                ErrorPath[3] = "\\\\169.254.0.10\\gdlocal\\Public\\Workspace\\AlarmFiles\\" + "Alarm_" + PVar.ErrorCodeDeviCename + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmmss") + ".csv";

                if (System.IO.File.Exists(ErrorPath[2]) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory(ErrorPath[2]);
                    }

                if (System.IO.File.Exists(ErrorPath[0]) != false)
                    {
                    DeleteFile(ErrorPath[0]);
                    }

                FileName[0] = "DateTime,Project,BU,Floor,Line,AE ID,AE SubID,AE Vendor,Machine SN,SW rev.,HW rev.,Time Mode,Error Code,Error Description,Color,Notes";
                FileName[1] = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + PVar.ParList.MacInfo[1] + "," + PVar.ParList.MacInfo[2] + "," + PVar.ParList.MacInfo[3] + "," + PVar.ParList.MacInfo[4] + "," + PVar.ParList.MacInfo[5] + "," + PVar.ParList.MacInfo[6] + "," + PVar.ParList.MacInfo[7] + "," + PVar.ParList.MacInfo[8] + "," + "BZ-" + PVar.MeshineSW + "-" + PVar.ParList.MacInfo[9] + "-NN.NN-NN.NN" + "," + PVar.ParList.MacInfo[10] + "," +
                    "" + "," + ErrorCodeName[1] + "," +
                    ErrorCodeAnnotationEH + "," + LightStatusERR + "," + "AE:Contact BZ";
                //\\记录发生的一切ERRor
                FileName[4] = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (System.IO.File.Exists(ErrorPath[0]) == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], ErrorPath[0]);
                    }
                BVar.FileRorW.WriteCsv(FileName[1], ErrorPath[0]);

                //总体数据统计
                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd")) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd"));
                    }
                System.IO.File.Copy(ErrorPath[0], ErrorPath[3], true);

                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv") == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], "E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");
                    }
                BVar.FileRorW.WriteCsv(FileName[1], "E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");
                }
            }

        public static void WriteCsvErrorCodeOK()
            {
            WriteCsvErrorCodeOK_Once(WriteCsvErrorCodeOKThread);
            }
        private static void WriteCsvErrorCodeOK_Once(Thread threadName)
            {
            try
                {
                if (threadName == null)
                    {
                    threadName = new Thread(new ThreadStart(WriteCsvErrorCodeOK_Thread));
                    threadName.Start();
                    threadName.Priority = ThreadPriority.Normal;
                    }
                }
            catch (Exception)
                {

                }
            }

        //异常结束发送结束命令
        private static void WriteCsvErrorCodeOK_Thread()
            {
            string[] FileName = new string[5];
            string[] FilePath = new string[3];
            string ErrorCodeAnnotationEH = "";
            int AlarmNumber = 0;
            string AlarmString = "";
            string ErrorCodeName = "";

            if (PVar.ParList.CheckSts[19])
                {
                FilePath[0] = "D:\\BZ-Parameter\\BAM\\AlarmHistoryData.ini";
                ErrorPath[2] = "E:\\AE\\ErrorCode\\OK\\";
                ErrorPath[0] = "E:\\AE\\ErrorCode\\OK\\BAM_DT_OK.csv";
                ErrorPath[3] = "\\\\169.254.0.10\\gdlocal\\Public\\Workspace\\AlarmFiles\\" + "Alarm_" + PVar.ErrorCodeDeviCename + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmmss") + ".csv";

                ErrorCodeOccur = bool.Parse(ReadMachineIniFile("Machine", "ErrorCodeOccur"));

                if (ErrorCodeOccur == false)
                    {
                    return;
                    }
                if (System.IO.File.Exists(ErrorPath[0]) != false)
                    {
                    DeleteFile(ErrorPath[0]);
                    }

                if (System.IO.File.Exists(ErrorPath[2]) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory(ErrorPath[2]);
                    }
                ErrorCodeOccur = false;

                FileName[0] = "DateTime,Project,BU,Floor,Line,AE ID,AE SubID,AE Vendor,Machine SN,SW rev.,HW rev.,Time Mode,Error Code,Error Description,Color,Notes";
                FileName[1] = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + PVar.ParList.MacInfo[1] + "," + PVar.ParList.MacInfo[2] + "," + PVar.ParList.MacInfo[3] + "," + PVar.ParList.MacInfo[4] + "," + PVar.ParList.MacInfo[5] + "," + PVar.ParList.MacInfo[6] + "," + PVar.ParList.MacInfo[7] + "," + PVar.ParList.MacInfo[8] + "," + "BZ-" + PVar.MeshineSW + "-" + PVar.ParList.MacInfo[9] + "-NN.NN-NN.NN" + "," + PVar.ParList.MacInfo[10] + "," +
                    "1" + "," + "RST" + "," + "SW initialization or restarting" + "," + "Green" + "," + "N/A";
                //\\记录发生的一切ERRor
                FileName[4] = DateTime.Now.ToString("yyyyMMddHHmmss");
                if (System.IO.File.Exists(ErrorPath[0]) == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], ErrorPath[0]);
                    }
                BVar.FileRorW.WriteCsv(FileName[1], ErrorPath[0]);

                //\\\\\\\\\\\\\\总体数据统计
                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd")) == false)
                    {
                    (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.CreateDirectory("E:\\" + "BZ-Data" + "\\AlarmFiles" + "\\" + DateTime.Now.ToString("yyyy-MM-dd"));
                    }

                if (System.IO.File.Exists("E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv") == false)
                    {
                    BVar.FileRorW.WriteCsv(FileName[0], "E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");
                    }
                BVar.FileRorW.WriteCsv(FileName[1], "E:\\BZ-Data\\AlarmFiles\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\BAM_DT.csv");

                ErrorCodeName = ReadMachineIniFile("Machine", "ErrorCodeName");
                ErrorCodeStarteTime = ReadMachineIniFile("Machine", "ErrorCodeStarteTime");
                ErrorCodeAnnotationEH = ReadMachineIniFile("Machine", "ErrorCodeCategory");
                ErrorCodeEndTime = DateTime.Now.ToString("HH:mm:ss");

                //\\\\\\\\写进统计部分

                AlarmNumber = int.Parse(BVar.FileRorW.ReadINI(DateTime.Now.ToString("yyyyMMdd"), "TotalAlarmNum", "999", FilePath[0]));
                if (AlarmNumber == 999)
                    {
                    AlarmNumber = 0;
                    }
                AlarmNumber++;
                BVar.FileRorW.WriteINI(DateTime.Now.ToString("yyyyMMdd"), "TotalAlarmNum", System.Convert.ToString(AlarmNumber), FilePath[0]);
                if (ErrorCodeStarteTime.Length - 7 >= 0)
                    {
                    AlarmString = ErrorCodeStarteTime.Substring(ErrorCodeStarteTime.Length - 7 - 1, 8) + "," + ErrorCodeEndTime + "," + ErrorCodeName + "," + ErrorCodeAnnotationEH;
                    BVar.FileRorW.WriteINI(DateTime.Now.ToString("yyyyMMdd"), "Alarm" + System.Convert.ToString(AlarmNumber), AlarmString, FilePath[0]);
                    }

                WriteMachineIniFile("Machine", "ErrorCodeOccur", System.Convert.ToString(0));
                WriteMachineIniFile("Machine", "LightStatus", "");
                WriteMachineIniFile("Machine", "ErrorCodeName", "");
                WriteMachineIniFile("Machine", "ErrorCodeStarteTime", "");
                WriteMachineIniFile("Machine", "ErrorCodeCategory", "");
                Err_Light = true;
                System.IO.File.Copy(ErrorPath[0], ErrorPath[3], true);
                }

            }

        public static void DeleteFile(string FileName)
            {
            //// 删除非空文件夹
            //DirectoryInfo dir = new DirectoryInfo(FileName);
            //if (dir.Exists)
            //    {
            //    DirectoryInfo[] childs = dir.GetDirectories();
            //    foreach (DirectoryInfo child in childs)
            //        {
            //        child.Delete(true);
            //        }
            //    dir.Delete(true);
            //    }

            DirectoryInfo di = new DirectoryInfo(FileName);
            di.Delete(true);  //path是你要删除的非空目录；true：你要删除里面所有的文件，包括文件夹和子文件夹
            }

        #region 系统时间设置

        //\\\\\\\\\\\\\\\\\\\更改系统时间模块
        public static Thread SystimeSetStarting;
        public static string SystemData;
        public static string SystemTime;
        /// <summary>
        /// 系统时间同步步序号
        /// </summary>
        public static int CheckSystemTimeStep;

        public static void SystimeSet(string LocalSystemTime, string MiniSystemTime)
            {
            bool SysTimechang;
            int[] SysTime = new int[3];
            int i = 0;
            string[] SystemYear = new string[3];
            string[] Systemmonth = new string[3];
            string[] Systemday = new string[3];
            string[] Systemhour = new string[3];
            string[] Systemmin = new string[3];
            string[] Systemss = new string[3];
            SystemYear[0] = LocalSystemTime.Substring(0, 4);
            Systemmonth[0] = LocalSystemTime.Substring(4, 2);
            Systemday[0] = LocalSystemTime.Substring(6, 2);
            Systemhour[0] = LocalSystemTime.Substring(8, 2);
            Systemmin[0] = LocalSystemTime.Substring(10, 2);
            Systemss[0] = LocalSystemTime.Substring(12, 2);
            SystemYear[1] = MiniSystemTime.Substring(0, 4);
            Systemmonth[1] = MiniSystemTime.Substring(4, 2);
            Systemday[1] = MiniSystemTime.Substring(6, 2);
            Systemhour[1] = MiniSystemTime.Substring(8, 2);
            Systemmin[1] = MiniSystemTime.Substring(10, 2);
            Systemss[1] = MiniSystemTime.Substring(12, 2);
            SysTime[0] = Convert.ToInt32(Systemhour[0]) * 3600 + Convert.ToInt32(Systemmin[0]) * 60 + Convert.ToInt32(Systemss[0]);
            SysTime[1] = Convert.ToInt32(Systemhour[1]) * 3600 + Convert.ToInt32(Systemmin[1]) * 60 + Convert.ToInt32(Systemss[1]);
            SysTimechang = false;
            for (i = 1; i <= 8; i++)
                {
                if (LocalSystemTime.Substring(i - 1, 1) != MiniSystemTime.Substring(i - 1, 1))
                    {
                    SysTimechang = true;
                    break;
                    }
                }
            if (SysTimechang == false)
                {
                if (Math.Abs(SysTime[0] - SysTime[1]) > 0)
                    {
                    SysTimechang = true;
                    }
                }
            if (SysTimechang == false)
                {
                return;
                }

            SystemData = SystemYear[1] + "/" + Systemmonth[1] + "/" + Systemday[1];
            SystemTime = Systemhour[1] + ":" + Systemmin[1] + ":" + Systemss[1];
            SystimeSetStarting = new Thread(new System.Threading.ThreadStart(SystimeSetStart));
            SystimeSetStarting.Priority = ThreadPriority.Highest;
            SystimeSetStarting.IsBackground = false;
            SystimeSetStarting.Start();

            }
        static public void SystimeSetStart()
            {
            DateAndTime.Today = DateTime.Parse(SystemData);
            DateAndTime.TimeOfDay = DateTime.Parse(SystemTime);
            }

        #endregion

        }

    }
