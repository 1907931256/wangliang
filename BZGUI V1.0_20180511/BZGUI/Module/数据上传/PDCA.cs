using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System;

namespace BZGUI
{
    sealed class PDCA
    {
        public event Action<string> AddList;
        private string[] upLoadDataDes = new string[36];
        public short UpLoadStep;
        public bool PDCAIsWorking = false;
        public string PDCA_RtnSN;
        public string PDCA_Data;
        private int UpLoad_PDCA_watchTime = 0;
        private short UpLoad_PDCA_count = 0;
        private readonly static PDCA instance = new PDCA();

        /// <summary>
        /// 构造函数
        /// </summary>
        public PDCA()
        { }

        public static PDCA Instance
        {
            get { return instance; }
        }

        public void UpLoad_PDCA(string[] upLoadDataRec)
        {
            upLoadDataDes = upLoadDataRec;
            string tempLogStr = "";
            try
            {
                switch (UpLoadStep)
                {
                    case (short)10:
                        tempLogStr = "-----------------------" + "\r\n" +
                            "-->> Start Test: [" + DateTime.Now.ToString("HH:mm:ss") + "]";
                        PDCA_Data = "";
                        PDCA_RtnSN = "";
                        UpLoad_PDCA_count = (short)0;
                        UpLoadStep = (short)11;
                        break;

                    case (short)11:
                        if (Frm_Engineering.fEngineering.Tcp_PDCA.IsStart == false)
                        {
                            Frm_Engineering.fEngineering.Tcp_PDCA.StartConnect(); //PDCA连接
                            tempLogStr = "与服务端建立握手协议连接...";
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)12;
                        }
                        else
                        {
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)20;
                        }
                        break;

                    case (short)12:
                        if (Frm_Engineering.fEngineering.Tcp_PDCA.IsStart)
                        {
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)20;
                        }
                        else
                        {
                            if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 2000)
                            {
                                tempLogStr = "与服务端握手协议连接超时！";
                                Mod_ErrorCode.WriteErrorCode("ERR-SSW01-50201", 0);
                                UpLoadStep = (short)250;
                            }
                        }
                        break;

                    case (short)20:
                        try
                        {
                            if (System.Convert.ToInt32(API.GetTickCount()) - PVar.CMDSendTime > 5)
                            {
                                PVar.CMDSendTime = System.Convert.ToInt32(API.GetTickCount());
                                Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes("Send_msg,@"));
                                tempLogStr = "发送信息到Mac Mini ====>[Send_msg,@]";
                                UpLoad_PDCA_count++;
                                UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                                UpLoadStep = (short)30;
                            }
                        }
                        catch (Exception)
                        {
                            UpLoadStep = (short)11;
                        }
                        break;

                    case (short)30:
                        if (PDCA_Data.IndexOf("Ack") + 1 != 0)
                        {
                            tempLogStr = "收到信息： <====[Ack,@]";
                            UpLoadStep = (short)40;
                        }
                        else if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 6000)
                        {
                            tempLogStr = "接收Ack,@6s超时 <==== [" + PDCA_Data + "]";
                            UpLoadStep = (short)200;
                        }
                        break;

                    case (short)40:
                        PDCA_Data = "";
                        UpLoadStep = (short)50;
                        break;

                    case (short)50:
                        if (System.Convert.ToInt32(API.GetTickCount()) - PVar.CMDSendTime > 5)
                        {
                            PVar.CMDSendTime = System.Convert.ToInt32(API.GetTickCount());
                            string testSN = "";
                            testSN = Strings.Trim(upLoadDataDes[0]); //条码数据
                            Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes(testSN + ":" + Strings.Trim(upLoadDataDes[1]) + ",@"));
                            tempLogStr = "发送信息到Mac Mini ====>[" + testSN + ",@]";
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)60;
                        }
                        break;

                    case (short)60:
                        if (PDCA_Data != "")
                        {
                            if (PDCA_Data.Length < 10 || PDCA_Data.IndexOf("SYNC_ERROR") + 1 > 0)
                            {
                                tempLogStr = "接收到SN错误 <==== [" + PDCA_Data + "]";
                                UpLoadStep = (short)200;
                            }
                            else
                            {
                                PDCA_RtnSN = PDCA_Data.Trim().Substring(0, 17);
                                BVar.ProData[4, 2] = PDCA_RtnSN;
                                tempLogStr = "收到返回SN： <==== [" + PDCA_Data + "]";
                                PDCA_Data = "";
                                UpLoadStep = (short)70;
                            }
                        }
                        else if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 10000)
                        {
                            tempLogStr = "接收SN10s超时 <==== [" + PDCA_Data + "]";
                            UpLoadStep = (short)200;
                        }
                        break;

                    case (short)70:
                        //*************************************************************************************
                        string testDatas = "";
                        testDatas = PDCA_RtnSN + ":BZ" + "-" + PVar.MeshineSW + "-" + PVar.ParList.MacInfo[9] + "-S6.g0-NN.NN:";
                        for (int i = 2; i <= upLoadDataDes.Length - 1; i++)
                        {
                            testDatas = testDatas + upLoadDataDes[i] + ":";
                        }
                        testDatas = testDatas + System.Convert.ToString(upLoadDataDes.Last()) + ",@";
                        if (System.Convert.ToInt32(API.GetTickCount()) - PVar.CMDSendTime > 5)
                        {
                            PVar.CMDSendTime = System.Convert.ToInt32(API.GetTickCount());
                            Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes(testDatas));
                            //Frm_Engineering.TCP_PDCA.SendData("Ack,@")
                            tempLogStr = "发送信息到Mac Mini ====>[" + testDatas.Replace("\r\n", "") + "]";
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)80;
                        }
                        break;

                    case (short)80:
                        if (PDCA_Data != "")
                        {
                            if (PDCA_Data.IndexOf("Ack") + 1 != 0)
                            {
                                tempLogStr = "收到信息： <====[Ack,@]";
                                UpLoadStep = (short)90;
                            }
                            else if (PDCA_Data.IndexOf("NACK") + 1 != 0)
                            {
                                tempLogStr = "接收到错误信息 <==== [" + PDCA_Data + "]";
                                UpLoadStep = (short)200;
                            }
                            else if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 6000)
                            {
                                tempLogStr = "接收错误信息6s超时 <==== [" + PDCA_Data + "]";
                                UpLoadStep = (short)200;
                            }
                        }
                        else if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 6000)
                        {
                            tempLogStr = "接收信息6s超时 <==== [" + PDCA_Data + "]";
                            UpLoadStep = (short)200;
                        }
                        break;

                    case (short)90:
                        if (System.Convert.ToInt32(API.GetTickCount()) - PVar.CMDSendTime > 5)
                        {
                            PVar.CMDSendTime = System.Convert.ToInt32(API.GetTickCount());
                            PDCA_Data = "";
                            Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes("Check_status,@"));
                            tempLogStr = "发送信息到Mac Mini ====>[Check_status,@]";
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)100;
                        }
                        break;

                    case (short)100:
                        if (PDCA_Data.IndexOf("OK") + 1 != 0)
                        {
                            tempLogStr = "收到信息： <====[OK,@]";
                            UpLoadStep = (short)150;
                        }
                        else if (PDCA_Data.IndexOf("Fatal_Error") + 1 != 0)
                        {
                            tempLogStr = "接收到错误信息 <==== [" + PDCA_Data + "]";
                            UpLoadStep = (short)200;
                        }
                        else if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 6000)
                        {
                            tempLogStr = "接收信息6s超时 <==== [" + PDCA_Data + "]";
                            UpLoadStep = (short)200;
                        }
                        break;

                    case (short)150:
                        if (System.Convert.ToInt32(API.GetTickCount()) - PVar.CMDSendTime > 5)
                        {
                            PVar.CMDSendTime = System.Convert.ToInt32(API.GetTickCount());
                            PDCA_Data = "";
                            Frm_Engineering.fEngineering.Tcp_PDCA.SendData(Encoding.UTF8.GetBytes("Ack,@"));
                            tempLogStr = "发送信息到Mac Mini ====>[Ack,@]";
                            UpLoadStep = (short)250;
                        }
                        break;

                    case (short)200:
                        if (UpLoad_PDCA_count > 2)
                        {
                            UpLoadStep = (short)250;
                        }
                        else
                        {
                            PDCA_Data = "";
                            PDCA_RtnSN = "";
                            tempLogStr = "******上传数据到Mac Mini失败,开始第" + System.Convert.ToString(UpLoad_PDCA_count + 1) + "次上传:";
                            UpLoad_PDCA_watchTime = System.Convert.ToInt32(API.GetTickCount());
                            UpLoadStep = (short)210;
                        }
                        break;

                    case (short)210:
                        if (UpLoad_PDCA_count > 3)
                        {
                            tempLogStr = "PDCA上传次数超过" + System.Convert.ToString(UpLoad_PDCA_count + 1) + ",PDCA上传结束";
                            UpLoadStep = (short)250;
                        }
                        else
                        {
                            if (System.Convert.ToInt32(API.GetTickCount()) - UpLoad_PDCA_watchTime > 1000)
                            {
                                UpLoadStep = (short)11;
                            }
                        }
                        break;

                    case (short)250:
                        UpLoad_PDCA_count = (short)0;
                        tempLogStr = "";
                        PDCAIsWorking = false;
                        UpLoadStep = (short)10;
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
                UpLoadStep = (short)0;
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
