using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System;
using VB = Microsoft.VisualBasic;

namespace DAB
    {
    sealed class PDCA
        {
        private static int CMDRtn;
        private static bool CheckResult = false; 
        private static Tool.Delay InitTime = new Tool.Delay();
        public static event Action<string> AddList;
        private static string[] strBalli = new string[36];
        public static int UpLoadStep;
        public static bool PDCAIsWorking = false;
        public static string MLBSN;
        private static string ResultofPDCA; 
        static int UpLoad_PDCA_count = 0; 
         
        public static void Bali_PDCA(string[] upLoadDataRec)
            {
            strBalli = upLoadDataRec;
            string tempLogStr = "";
            try
                {
                switch (UpLoadStep)
                    {
                    case 10:
                        tempLogStr = "-----------------------" + "\r\n" +
                            "-->> Start Test: [" + DateTime.Now.ToString("HH:mm:ss") + "]";
                        UpLoad_PDCA_count = 0;
                        UpLoadStep = 11;
                        break;

                    case 11:
                        if (Frm_Engineering.fEngineering.Tcp_PDCA.IsStart == false)
                            {
                            Frm_Engineering.fEngineering.Tcp_PDCA.StartConnect(); //PDCA连接
                            tempLogStr = "与服务端建立握手协议连接...";
                            InitTime.InitialTime();
                            UpLoadStep = 12;
                            }
                        else
                            {
                            InitTime.InitialTime();
                            UpLoadStep = 20;
                            }
                        break;

                    case 12:
                        if (Frm_Engineering.fEngineering.Tcp_PDCA.IsStart)
                            {
                            InitTime.InitialTime();
                            UpLoadStep = 20;
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(3000))
                                {
                                tempLogStr = "与服务端握手协议连接超时！";
                                Mod_ErrorCode.WriteErrorCode("ERR-SSW01-50201", 0);
                                UpLoadStep = 250;
                                }
                            }
                        break;

                    case 20:
                        CMDRtn = Command.TCP_PDCA_Send(strBalli[0] + ",@");
                        if (CMDRtn == 1)
                            {
                            tempLogStr = "发送信息到Mac Mini ====>[" + strBalli[0] + ",@\n]";
                            UpLoad_PDCA_count++;
                            InitTime.InitialTime();
                            UpLoadStep = 30;
                            }
                        else
                            {
                            InitTime.InitialTime();
                            UpLoadStep = 11;
                            }
                        break;

                    case 30:
                        if (PVar.PDCA_Data[0] == "ok")
                            {
                            MLBSN = VB.Strings.Mid(PVar.PDCA_Data[1], 2, PVar.PDCA_Data[1].Length-2);
                            tempLogStr = "收到信息： <====["+ PVar.PDCA_StrData + "]";
                            
                            InitTime.InitialTime();
                            UpLoadStep = 40;
                            }
                        else if (InitTime.TimeIsUp(10000))
                            {
                            tempLogStr = "接收ok@{MLBSN}@\n,10S超时 <==== [" + PVar.PDCA_StrData + "]";
                            UpLoadStep = 200;
                            }
                        break;

                    case 40:
                        if (CheckResult)
                            {
                            AddList("等待CCD最终复检数据...");
                            tempLogStr = "等待CCD最终复检数据...";
                            InitTime.InitialTime();
                            UpLoadStep = 69;
                            }
                        break;

                    case 70:
                        //*************************************************************************************
                        string testDatas = "";
                        testDatas = MLBSN + ":BZ" + "-" + PVar.MeshineSW + "-" + PVar.ParList.MacInfo[9] + "-S6.g0-NN.NN:";
                        for (int i = 2; i <= strBalli.Length - 1; i++)
                            {
                            testDatas = testDatas + strBalli[i] + ":";
                            }
                        testDatas = testDatas + System.Convert.ToString(strBalli.Last()) + ",@mm";
                        CMDRtn = Command.TCP_PDCA_Send(testDatas);
                        if (CMDRtn == 1)
                            {
                            tempLogStr = "发送信息到Mac Mini ====>[" + testDatas + "\n]";
                            InitTime.InitialTime();
                            UpLoadStep = 80;
                            }
                        else
                            {
                            InitTime.InitialTime();
                            UpLoadStep = 200;
                            }
                        break;

                    case 80:
                        if (Command.PDCA_Resule)
                            {
                            if (PVar.PDCA_Data[0] == "ok")
                                {
                                ResultofPDCA = VB.Strings.Mid(PVar.PDCA_Data[1], 2, PVar.PDCA_Data[1].Length - 2);
                                tempLogStr = "收到信息： <====[" + PVar.PDCA_StrData + "]";
                                UpLoadStep = 90;
                                }
                            else if (InitTime.TimeIsUp(500))
                                {
                                tempLogStr = "接收信息错误 <==== [" + PVar.PDCA_StrData + "]";
                                UpLoadStep = 200;
                                }
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            tempLogStr = "接收信息6s超时 <==== [" + PVar.PDCA_StrData + "]";
                            UpLoadStep = 200;
                            }
                        break;

                    case 90:
                            Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes("Check_status,@"));
                            tempLogStr = "发送信息到Mac Mini ====>[Check_status,@]";
                            InitTime.InitialTime();
                            UpLoadStep = 100;
                        break;

                    case 100:
    
                        break;

                    case 150:
                        if (System.Convert.ToInt32(API.GetTickCount()) - PVar.CMDSendTime > 5)
                            {
                            Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes("Ack,@"));
                            tempLogStr = "发送信息到Mac Mini ====>[Ack,@]";
                            UpLoadStep = 250;
                            }
                        break;

                    case 200:
                        if (UpLoad_PDCA_count > 2)
                            {
                            UpLoadStep = 250;
                            }
                        else
                            {
                            MLBSN = "";
                            tempLogStr = "******上传数据到Mac Mini失败,开始第" + System.Convert.ToString(UpLoad_PDCA_count + 1) + "次上传:";
                            InitTime.InitialTime();
                            UpLoadStep = 210;
                            }
                        break;

                    case 210:
                        if (UpLoad_PDCA_count > 3)
                            {
                            tempLogStr = "PDCA上传次数超过" + System.Convert.ToString(UpLoad_PDCA_count + 1) + ",PDCA上传结束";
                            UpLoadStep = 250;
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(1000))
                                {
                                UpLoadStep = 11;
                                }
                            }
                        break;

                    case 250:
                        UpLoad_PDCA_count = 0;
                        tempLogStr = "";
                        PDCAIsWorking = false;
                        UpLoadStep = 0;
                        break;

                    }

                if (!string.IsNullOrEmpty(tempLogStr))
                    {
                    WritePDCALog(PVar.BZ_PDCALogPath + DateTime.Now.ToString("yyyyMM") + "\\", DateTime.Now.ToString("yyyyMMdd") + "-2" + ".log", UpLoadStep + "-->" + tempLogStr);
                    if (PVar.IsOpenFrmEngineering == true)
                        {
                        AddList(UpLoadStep + ":" + tempLogStr);
                        }

                    tempLogStr = "";
                    }

                }
            catch (Exception)
                {
                UpLoadStep = 0;
                PDCAIsWorking = false;
                }
            }


        private static void WritePDCALog(string PDCALogPath, string PDCALogFileName, string LogStr, string HsgSN = "")
            {
            if (System.IO.Directory.Exists(PDCALogPath) == false)
                {
                System.IO.Directory.CreateDirectory(PDCALogPath);
                }

            System.IO.StreamWriter rs = new System.IO.StreamWriter(PDCALogPath + PDCALogFileName, true);
            if (HsgSN != "")
                {
                rs.WriteLine("**************************************************");
                rs.WriteLine("MLB_SN: " + HsgSN + " Start:" + DateTime.Now.ToString("HH:MM:ss"));
                rs.WriteLine("PDCA上传开始！");
                }

            rs.WriteLine(LogStr);
            rs.Close();

            }
        }

    }
