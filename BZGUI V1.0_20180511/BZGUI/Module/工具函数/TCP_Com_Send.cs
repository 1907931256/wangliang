
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using AxMSScriptControl;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Text;


namespace BZGUI
{
    sealed class Command
    {
        public static bool CCD1_Resule = false;
        public static bool CCD2_Resule = false;
        public const string 取料拍照 = "T1";
        public const string 装配角度拍照 = "T2";
        public const string 装配HSG圆拍照 = "T3";
        public const string 装配Blogo拍照 = "T4"; 
        public const string 装配拍照 = "T5";
        public const string 复检角度 = "T10";
        public const string 复检同心度 = "T11";

        public const string 压力控制打开 = ":O000000o";
        public const string 压力控制关闭 = ":Q000000q";   
         
        #region 功能:数据发送

        /// <summary>
        /// 网络发送，已经含有回车符
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int TCP_CCD1_Send(string cmd)
            {
            int returnValue = 0;
            CCD1_Resule = false;
            if (Frm_Engineering.fEngineering.Tcp_CCD1.IsStart == false) //判断CCD1连接是否成功
                {
                returnValue = 2; //网络连接失败，返回2
                return returnValue;
                }
            PVar.CCD1_Data = new[] { "" }; //发送数据前，清空换存的数据
            PVar.CCD1_Data[0] = "ERR";
            PVar.CCD1_StrData = "";
            try
                {
                Frm_Engineering.fEngineering.Tcp_CCD1.SendData(Encoding.UTF8.GetBytes(cmd + Constants.vbCr));
                returnValue = 1; //命令发送成功，返回1
                }
            catch (Exception)
                {
                returnValue = 3; //命令发送失败，返回0
                }
            return returnValue;
            }

        /// <summary>
        /// 网络发送，已经含有回车符
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int TCP_CCD2_Send(string cmd)
            {
            int returnValue = 0;
            CCD1_Resule = false;
            PVar.CMDSendTime = System.Convert.ToInt32(API.GetTickCount());
            if (Frm_Engineering.fEngineering.Tcp_CCD2.IsStart == false) //判断CCD2连接是否成功
                {
                returnValue = 2; //网络连接失败，返回2
                return returnValue;
                }
            PVar.CCD2_Data = new[] { "" }; //发送数据前，清空换存的数据
            PVar.CCD2_StrData = "";
            try
                {
                Frm_Engineering.fEngineering.Tcp_CCD2.SendData(Encoding.UTF8.GetBytes(cmd + Constants.vbCr));
                returnValue = 1; //命令发送成功，返回1
                }
            catch (Exception)
                {
                returnValue = 3; //命令发送成功，返回0
                }
            return returnValue;
            }

        public bool LightOn(string TriggerStr)
            {
            int LightControlNum = 0;
            int[] ChTriggerValue = new int[5];
            PVar.LightCMDSendTime = System.Convert.ToInt32(API.GetTickCount());
            try
                {
                if (System.Convert.ToInt16(TriggerStr.Substring(4, 1)) == 4 || System.Convert.ToInt16(TriggerStr.Substring(4, 1)) == 2)
                    {
                    LightControlNum = 1;
                    }
                else
                    {
                    LightControlNum = 0;
                    }

                ChTriggerValue[1] = System.Convert.ToInt32(Tool.GetArrayIndex(PVar.ColorSelectd, TriggerStr, "0,0,0,0", 1, PVar.BZ_LightSettingPath));
                ChTriggerValue[2] = System.Convert.ToInt32(Tool.GetArrayIndex(PVar.ColorSelectd, TriggerStr, "0,0,0,0", 2, PVar.BZ_LightSettingPath));
                ChTriggerValue[3] = System.Convert.ToInt32(Tool.GetArrayIndex(PVar.ColorSelectd, TriggerStr, "0,0,0,0", 3, PVar.BZ_LightSettingPath));
                ChTriggerValue[4] = System.Convert.ToInt32(Tool.GetArrayIndex(PVar.ColorSelectd, TriggerStr, "0,0,0,0", 4, PVar.BZ_LightSettingPath));

                if (PVar.ParList.CheckSts[48] == true)
                    {
                    if (LightControlNum == 0)
                        {
                        //Frm_Main.MSComm3.Output = "LMD,4SPLN,00" & "," & Format(ChTriggerValue(1), "000") & "," & Format(ChTriggerValue(2), "000") & "," & Format(ChTriggerValue(3), "000") & "," & Format(ChTriggerValue(4), "000") & "," & vbCrLf
                        }
                    else
                        {
                        //Frm_Main.MSComm4.Output = "LMD,4SPLN,00" & "," & Format(ChTriggerValue(1), "000") & "," & Format(ChTriggerValue(2), "000") & "," & Format(ChTriggerValue(3), "000") & "," & Format(ChTriggerValue(4), "000") & "," & vbCrLf
                        }
                    }

                return true;
                }
            catch (Exception)
                {
                return false;
                }
            }
        #endregion

        #region 功能：串口命令发送
        /// <summary>
        /// 串口1发送命令
        /// </summary>
        /// <remarks></remarks>
        public static int Com1_Send(string cmd) 
            {
            int returnValue = 0;
            PVar.IsCOM1_Working = false; 
            PVar.CMDSendTime = API.GetTickCount();
            if (Frm_Engineering.fEngineering.SerialPort1.IsOpen == false)
                {
                Frm_Engineering.fEngineering.SerialPort1.Open();
                }
            if (Frm_Engineering.fEngineering.SerialPort1.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort1.Write(cmd + Constants.vbCrLf);
                returnValue = 1; 
                return returnValue;
                }
            else
                {
                returnValue = 2;
                return returnValue;
                }
            }

        public static int Com2_Send(string cmd)
        {
            int returnValue = 0;
            PVar.IsCOM2_Working = false;
            PVar.CMDSendTime = API.GetTickCount();
            if (Frm_Engineering.fEngineering.SerialPort2.IsOpen == false)
            {
                Frm_Engineering.fEngineering.SerialPort2.Open();
            }
            if (Frm_Engineering.fEngineering.SerialPort2.IsOpen)
            {
                Frm_Engineering.fEngineering.SerialPort2.Write(cmd + Constants.vbCrLf);
                returnValue = 1;
                return returnValue;
            }
            else
            {
                returnValue = 2;
                return returnValue;
            }
        }

        public static int Com3_Send(string cmd)
        {
            int returnValue = 0;
            //::PVar.IsCOM3_Working = false;
            PVar.CMDSendTime = API.GetTickCount();
            if (PVar.IsCOM3_Working==false)//光源控制器接收数据失败，代表通信异常
            {
                returnValue = 2;
                return returnValue;
            }
            if (Frm_Engineering.fEngineering.SerialPort3.IsOpen == false)
            {
                Frm_Engineering.fEngineering.SerialPort3.Open();
            }
            if (Frm_Engineering.fEngineering.SerialPort3.IsOpen)
            {
                Frm_Engineering.fEngineering.SerialPort3.Write(cmd + Constants.vbCrLf);
                returnValue = 1;
                return returnValue;
            }
            else
            {
                returnValue = -1;
                return returnValue;
            }
        }
        #endregion

    }
}
