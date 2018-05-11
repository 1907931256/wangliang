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
using System.Threading;
using VB = Microsoft.VisualBasic;
using System.IO;
using System.Text;
using System.IO.Ports;

namespace BZGUI
{
    sealed class FunctionSub
    {
        public static DateTime[] AlarmHistoryTimeStor = new DateTime[3];
        public static string ErrCodeMessageStor;

        #region 功能：串口操作

        public static bool Init_Serial1()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort1.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort1.Close();
                }

                if (Frm_Engineering.fEngineering.SerialPort1.PortName != "COM" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[21]))))
                {
                    Frm_Engineering.fEngineering.SerialPort1.PortName = "COM" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[21])));
                }
                Frm_Engineering.fEngineering.SerialPort1.BaudRate = 115200;
                Frm_Engineering.fEngineering.SerialPort1.Parity = System.IO.Ports.Parity.None;
                Frm_Engineering.fEngineering.SerialPort1.DataBits = 8;
                Frm_Engineering.fEngineering.SerialPort1.StopBits = System.IO.Ports.StopBits.One;
                Frm_Engineering.fEngineering.SerialPort1.Encoding = System.Text.Encoding.UTF8;
                Frm_Engineering.fEngineering.SerialPort1.ReadTimeout = 500;
                Frm_Engineering.fEngineering.SerialPort1.WriteTimeout = 500;

                if (Open_Serial1() == false)
                {
                    return false;
                }
                if (Frm_Engineering.fEngineering.SerialPort1.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort1.Write(":Q000000q" + Constants.vbCrLf);
                }
                return true;
            }
            catch (Exception)
            {
                if (Frm_Engineering.fEngineering.SerialPort1.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort1.Close();
                }
                return false;
            }
        }

        public static bool Init_Serial2()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort2.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort2.Close();
                }

                if (Frm_Engineering.fEngineering.SerialPort2.PortName != "COM" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[42]))))
                {
                    Frm_Engineering.fEngineering.SerialPort2.PortName = "COM" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[42])));
                }
                Frm_Engineering.fEngineering.SerialPort2.BaudRate = 115200;
                Frm_Engineering.fEngineering.SerialPort2.Parity = System.IO.Ports.Parity.None;
                Frm_Engineering.fEngineering.SerialPort2.DataBits = 8;
                Frm_Engineering.fEngineering.SerialPort2.StopBits = System.IO.Ports.StopBits.One;
                Frm_Engineering.fEngineering.SerialPort2.Encoding = System.Text.Encoding.UTF8;
                Frm_Engineering.fEngineering.SerialPort2.ReadTimeout = 500;
                Frm_Engineering.fEngineering.SerialPort2.WriteTimeout = 500;
                if (Open_Serial2() == false)
                {
                    return false;
                }
                if (Frm_Engineering.fEngineering.SerialPort2.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort2.Write(":Q000000q" + Constants.vbCrLf);
                }
                return true;
            }
            catch (Exception)
            {
                if (Frm_Engineering.fEngineering.SerialPort2.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort2.Close();
                }
                return false;
            }
        }

        public static bool Init_Serial3()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort3.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort3.Close();
                }

                if (Frm_Engineering.fEngineering.SerialPort3.PortName != "COM" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[63]))))
                {
                    Frm_Engineering.fEngineering.SerialPort3.PortName = "COM" + System.Convert.ToString(Conversion.Val(System.Convert.ToString(PVar.ParList.Data[63])));
                }
                Frm_Engineering.fEngineering.SerialPort3.BaudRate = 56000;
                Frm_Engineering.fEngineering.SerialPort3.Parity = System.IO.Ports.Parity.None;
                Frm_Engineering.fEngineering.SerialPort3.DataBits = 8;
                Frm_Engineering.fEngineering.SerialPort3.StopBits = System.IO.Ports.StopBits.One;
                Frm_Engineering.fEngineering.SerialPort3.Encoding = System.Text.Encoding.UTF8;
                Frm_Engineering.fEngineering.SerialPort3.ReadTimeout = 500;
                Frm_Engineering.fEngineering.SerialPort3.WriteTimeout = 500;
                if (Open_Serial3() == false)
                {
                    return false;
                }
                if (Frm_Engineering.fEngineering.SerialPort3.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort3.Write("LMD,GT,00," + Constants.vbCrLf);//获取温度
                }
                return true;
            }
            catch (Exception)
            {
                if (Frm_Engineering.fEngineering.SerialPort3.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort3.Close();
                }
                return false;
            }
        }

        public static bool Open_Serial1()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort1.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort1.Close();
                }
                Frm_Engineering.fEngineering.SerialPort1.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Open_Serial2()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort2.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort2.Close();
                }
                Frm_Engineering.fEngineering.SerialPort2.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Open_Serial3()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort3.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort3.Close();
                }
                Frm_Engineering.fEngineering.SerialPort3.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Close_Serial1()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort1.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort1.Write(":Q000000q" + Constants.vbCrLf);
                }
                Application.DoEvents();
                Frm_Engineering.fEngineering.SerialPort1.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Close_Serial2()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort2.IsOpen)
                {
                    Frm_Engineering.fEngineering.SerialPort2.Write(":Q000000q" + Constants.vbCrLf);
                }
                Application.DoEvents();
                Frm_Engineering.fEngineering.SerialPort2.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Close_Serial3()
        {
            try
            {
                if (Frm_Engineering.fEngineering.SerialPort3.IsOpen)
                {
                    Command.Com3_Send("LMD,4SPLN,00" + ",000,000,000,000,");
                }
                Application.DoEvents();
                Frm_Engineering.fEngineering.SerialPort3.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region 功能：数据右移
        public static int SHR(int a, int n)
        {
            int returnValue = 0;
            a = (int)(a / (Math.Pow(2, n)));
            returnValue = a;
            return returnValue;
        }
        #endregion

        #region 功能：十进制转换为二进制
        public static dynamic Int_Union_Bool(ref bool[] Bit, int n, int data)
        {
            long Temp1 = 0;
            int i = 0;
            for (i = 0; i <= n - 1; i++)
            {
                Temp1 = SHR(data, i);
                Bit[i] = System.Convert.ToBoolean(Temp1 & 0x1);
            }
            return Bit;
        }
        #endregion

        #region 功能：创建文件函数
        /// <summary>
        /// 创建路径
        /// </summary>
        /// <remarks></remarks>
        public static void FileInit()
        {
            if (!System.IO.Directory.Exists(PVar.BZ_ProgramPath)) //程序路径
            {
                System.IO.Directory.CreateDirectory(PVar.BZ_ProgramPath);
            }

            if (!System.IO.Directory.Exists(PVar.BZ_ParameterPath)) //参数路径
            {
                System.IO.Directory.CreateDirectory(PVar.BZ_ParameterPath);
            }

        }

        public static bool FolderCreat(string filePath)
        {
            string[] tempStr = null;
            short n = (short)0;
            short len = 0;
            string tempPath = "";
            try
            {
                if (Directory.Exists(filePath) == false)
                {
                    tempStr = filePath.Split('\\');
                    tempPath = tempStr[0];
                    n = (short)1;
                    len = (short)(tempStr.Length - 1);
                    if ((tempStr[len]).IndexOf(".") + 1 > 0)
                    {
                        len--;
                    }
                    for (short i = n; i <= len; i++)
                    {
                        if (n <= len)
                        {
                            tempPath = tempPath + "\\" + tempStr[n];
                            if (Directory.Exists(tempPath) == false)
                            {
                                System.IO.Directory.CreateDirectory(tempPath);
                            }
                            n++;
                        }
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

        #region 功能：提示信息暂存

        public static void AddListCalib(string ListStr, short listType = 0)
        {
            if (Frm_Engineering.fEngineering.List_Info.Items.Count == 1000)
            {
                Frm_Engineering.fEngineering.List_Info.Items.Clear();
            }
            Frm_Engineering.fEngineering.List_Info.Items.Add(DateAndTime.TimeOfDay + "◇" + ListStr);
            Frm_Engineering.fEngineering.List_Info.SelectedIndex = Frm_Engineering.fEngineering.List_Info.Items.Count - 1;
        }

        public void AlarmMsgStor(DateTime AlarmTime, string ErrorCode)
        {
            Frm_Production.fProduction.AlarmStatus.BZ_SmallText = "Alarm";
            Frm_Production.fProduction.AlarmStatus.BZ_Color = Color.Red;
            Frm_Production.fProduction.AlarmTime.BZ_Color = Color.Red;
            Frm_Production.fProduction.AlarmTime.BZ_BigText = AlarmTime.ToString("HH:mm:ss");
            Frm_Production.fProduction.AlarmStatus.BZ_BigText = ErrorCode;
            AlarmHistoryTimeStor[0] = AlarmTime;
            ErrCodeMessageStor = ErrorCode;
        }
        #endregion

        #region 功能：计算重测率
        public static void IsBarcodeNg(string NgSN)
        {
            //Dim i As Integer
            //Dim ss As Int32
            //'ss = Frm_Main.ListBox1.Items.Count - 1
            //'For i = 0 To Frm_Main.ListBox1.Items.Count - 1
            //'    If Frm_Main.ListBox1.Items.Item(i) = NgSN Then
            //'        IniWriteKeyAdd(UIChartYieldOverViewName, Now.ToString("yyyyMMdd"), "Retest", "0")
            //'        Exit For
            //'    End If
            //'Next i
            //If "HsgBarcodeError" <> NgSN Then StoreNgBarcode(NgSN)
        }

        public static void StoreNgBarcode(string NgSN)
        {
            //Dim i As Integer
            //Frm_Main.ListBox1.Items.Add(NgSN)
            //If Frm_Main.ListBox1.Items.Count > 2500 Then
            //    For i = 0 To 1500
            //        Frm_Main.ListBox1.Items.RemoveAt(0)
            //    Next i
            //End If
        }
        #endregion

        #region 功能：获取计算机串口
        /// <summary>
        /// 获取计算机串口
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        ///
        private static int EnumSerialPortNames()
        {
            int nTotal = -1;
            //Me.SerialPort1.Items.Clear()
            //Me.SerialPort2.Items.Clear()
            //Me.SerialPort3.Items.Clear()
            //Me.SerialPort4.Items.Clear()

            foreach (string sp in (new Microsoft.VisualBasic.Devices.Computer()).Ports.SerialPortNames)
            {
                //    Me.SerialPort1.Items.Add(sp)
                //    Me.SerialPort2.Items.Add(sp)
                //    Me.SerialPort3.Items.Add(sp)
                //    Me.SerialPort4.Items.Add(sp)
                nTotal++;
            }
            return nTotal;
        }
        #endregion

        #region 功能：必须开启的功能
        public static void IsFunctionOpen()
        {
            //Par.Par_ChkBox(4) = 1
            //Par.Par_ChkBox(5) = 1
            //Par.Par_ChkBox(1) = 1
            //Par.Par_ChkBox(7) = 1
            //Par.Par_ChkBox(8) = 1
            //Par.Par_ChkBox(9) = 1
            //Par.Par_ChkBox(10) = 1
            //Par.Par_ChkBox(11) = 1
            //Par.Par_ChkBox(18) = 1
            //Par.Par_ChkBox(21) = 1
            //Frm_Par.CheckBox4.Checked = True
            //Frm_Par.CheckBox5.Checked = True
            //Frm_Par.CheckBox1.Checked = True
            //Frm_Par.CheckBox7.Checked = True
            //Frm_Par.CheckBox8.Checked = True
            //Frm_Par.CheckBox9.Checked = True
            //Frm_Par.CheckBox10.Checked = True
            //Frm_Par.CheckBox11.Checked = True
            //Frm_Par.CheckBox18.Checked = True
            //Frm_Par.CheckBox21.Checked = True
            //Frm_Par.CheckBox4.BackColor = Color.Lime
            //Frm_Par.CheckBox5.BackColor = Color.Lime
            //Frm_Par.CheckBox1.BackColor = Color.Lime
            //Frm_Par.CheckBox7.BackColor = Color.Lime
            //Frm_Par.CheckBox8.BackColor = Color.Lime
            //Frm_Par.CheckBox9.BackColor = Color.Lime
            //Frm_Par.CheckBox10.BackColor = Color.Lime
            //Frm_Par.CheckBox11.BackColor = Color.Lime
            //Frm_Par.CheckBox18.BackColor = Color.Lime
            //Frm_Par.CheckBox21.BackColor = Color.Lime
            //If Par.Par_ChkBox(3) Then
            //    Par.Par_ChkBox(1) = 0
            //    Frm_Par.CheckBox1.Checked = False
            //End If
            //WriteDatFile(BZ_ParameterPath & "Par.dat", Par)
        }
        #endregion

        #region 退出程序关闭运动控制卡和扩展模块
        public static void UnLoadMachineGTSCard()
        {
            short i = 0;
            short rtn;
            for (i = 1; i <= 8; i++)
            {
                rtn = System.Convert.ToInt16(gts.GT_AxisOff((short)0, i));
                rtn = System.Convert.ToInt16(gts.GT_AxisOff((short)1, i));
            }
            WinAPI.Wait(200);
            for (i = 0; i <= 15; i++)
            {
                //Call Set_Ex_EXO(0, i, 1) : Set_Ex_EXO(1, i, 1)
            }
            WinAPI.Wait(200);
            rtn = System.Convert.ToInt16(gts.GT_ResetExtMdlGts((short)0));
            rtn = System.Convert.ToInt16(gts.GT_ResetExtMdlGts((short)1));
            rtn = System.Convert.ToInt16(gts.GT_CloseExtMdlGts((short)0));
            rtn = System.Convert.ToInt16(gts.GT_CloseExtMdlGts((short)1));
            for (i = 0; i <= 2; i++)
            {
                rtn = System.Convert.ToInt16(gts.GT_SetDo(i, gts.MC_GPO, 65535));
                rtn = System.Convert.ToInt16(gts.GT_Reset(i));
                rtn = System.Convert.ToInt16(gts.GT_Close(i));
            }
        }
        #endregion

        #region 特殊函数
        public static string DecToBin(ref int Dec) //''''''''''''''十进制转二进制
        {
            string returnValue = "";
            returnValue = "";
            while (Dec > 0)
            {
                returnValue = Dec % 2 + returnValue;
                Dec = Dec / 2;
                Application.DoEvents();
            }
            if (returnValue == "")
            {
                returnValue = "0000000000000000";
            }
            else
            {
                returnValue = "0000000000000000" + System.Convert.ToString(returnValue);
                returnValue = Strings.Right(System.Convert.ToString(returnValue), 16);
            }

            return returnValue;
        }

        public static dynamic StrReplace(string StrOld, short StartStr, string StrTmpl)
        {
            dynamic returnValue = default(dynamic);
            returnValue = StrOld.Substring(0, StartStr - 1) + StrTmpl + StrOld.Substring(StrOld.Length - (StrOld.Length - (StartStr + StrTmpl.Length - 1)), StrOld.Length - (StartStr + StrTmpl.Length - 1));
            return returnValue;
        }

        public static string StrUnion(string StrInPut)
        {
            try
            {
                string TemStr = "";
                TemStr = System.Convert.ToString(StrInPut[0]);
                for (int i = 1; i <= (StrInPut.Length - 1); i++)
                {
                    TemStr = TemStr + "," + System.Convert.ToString(StrInPut[i]);
                }
                return TemStr;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string ArrayUnion(string StrInPut)
        {
            try
            {
                string TemStr = "";
                TemStr = System.Convert.ToString(StrInPut[0]);
                for (int i = 1; i <= (StrInPut.Length - 1); i++)
                {
                    TemStr = TemStr + "," + System.Convert.ToString(StrInPut[i]);
                }
                return TemStr;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static bool SetArray(string SectionName, string KeyWord, string[] ArrayInPut, string FileName)
        {
            try
            {
                string TemStr = "";
                TemStr = System.Convert.ToString(ArrayInPut[0]);
                for (int i = 1; i <= (ArrayInPut.Length - 1); i++)
                {
                    TemStr = TemStr + "," + System.Convert.ToString(ArrayInPut[i]);
                }
                BVar.FileRorW.WriteINI(SectionName, KeyWord, TemStr, FileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static double[] GetArrayN(string SectionName, string KeyWord, object ArrayInPut, string FileName)
        {
            string[] LnArray = null;
            double[] Array = null;
            try
            {
                string TemStr = "";
                TemStr = BVar.FileRorW.ReadINI(SectionName, KeyWord, "0,0,0,0,0", FileName);
                LnArray = TemStr.Split(',');
                Array = new double[(LnArray.Length - 1) + 1];
                for (int i = 0; i <= (LnArray.Length - 1); i++)
                {
                    Array[i] = System.Convert.ToDouble(System.Convert.ToDouble(LnArray[i]));
                }
            }
            catch (Exception)
            {
                Array = new double[] { 0, 0, 0, 0 };
            }
            return Array;
        }

        public static string[] GetArrayS(string SectionName, string KeyWord, object ArrayInPut, string FileName)
        {
            string[] Array = null;
            try
            {
                string TemStr = "";
                TemStr = BVar.FileRorW.ReadINI(SectionName, KeyWord, "0,0,0,0,0", FileName);
                Array = TemStr.Split(',');
            }
            catch (Exception)
            {
                Array = new string[] { "0", "0", "0", "0" };
            }
            return Array;
        }

        public static string HexToBin(string strHex) //'''十六进制转二进制
        {
            string returnValue = "";
            string strTmp = "";
            int lngTmp = 0;
            short intLen = 0;
            string strBin = "";
            short n1 = 0;
            short n2 = 0;
            intLen = (short)strHex.Length;
            for (n1 = 1; n1 <= intLen; n1++)
            {
                strTmp = strHex.Substring(n1 - 1, 1);
                if (Strings.Asc(strTmp) >= 48 && Strings.Asc(strTmp) <= 57)
                {
                    lngTmp = (int)(Conversion.Val(strTmp));
                }
                else if (Strings.Asc(strTmp) >= 65 && Strings.Asc(strTmp) <= 70)
                {
                    lngTmp = Strings.Asc(strTmp) - 55;
                }
                else
                {
                    returnValue = "";
                    return returnValue;
                }
                strTmp = "";
                for (n2 = 1; n2 <= 4; n2++)
                {
                    strTmp = lngTmp % 2 + strTmp;
                    lngTmp = (int)(((double)lngTmp / 2));
                }
                strBin = strBin + strTmp;
            }
            returnValue = strBin;
            return returnValue;
        }

        /// <summary>
        ///坐标系换算
        /// </summary>
        /// <param name="X">CCD坐标的X值</param>
        /// <param name="Y">CCD坐标的Y值</param>
        /// <param name="A_x">与CCDX方向夹角为锐角轴的角度(轴的正方向与CCD 0度方向的夹角)</param>
        /// <param name="A_y">与CCDY方向夹角为锐角轴的角度(轴的正方向与CCD 0度方向的夹角)</param>
        /// <param name="Xn">转换后坐标的X值</param>
        /// <param name="Yn">转换后坐标的Y值</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool ExChangeXY(double X, double Y, double A_x, double A_y, ref double Xn, ref double Yn)
        {
            //CCD坐标的X值----X As Double
            //CCD坐标的Y值--- Y As Double
            //与CCDX方向夹角为锐角轴的角度(轴的正方向与CCD 0度方向的夹角)--- A_x As Double  '绝对值小于180度
            //与CCDY方向夹角为锐角轴的角度(轴的正方向与CCD 0度方向的夹角)--- A_y As Double  '绝对值小于180度
            //Xn 是与CCDX方向成锐角的运动轴的值  '十字架右下角为0--90度（顺时针），为正
            //Yn 是与CCDY方向成锐角的运动轴的值
            //输出的X Y值有可能取正，也可能是负，以验证为准（CCD 正方向与运动轴正方向一致为正）
            double Xo = 0;
            double Yo = 0;
            double Ax = 0;
            double Ay = 0;
            double Xa = 0;
            double Ya = 0;
            double Xb = 0;
            double Yb = 0;
            try
            {
                Xo = X;
                Yo = Y;
                Ax = Conversion.Val(System.Convert.ToString(A_x)) / 45 * System.Math.Atan(1);
                Ay = Conversion.Val(System.Convert.ToString(A_y)) / 45 * System.Math.Atan(1);
                if (System.Math.Sin(Ax) != 0)
                {
                    Xa = (Yo - System.Math.Tan(Ay) * Xo) / (System.Math.Tan(Ax) - System.Math.Tan(Ay));
                    Ya = System.Math.Tan(Ax) * Xa;
                }
                else
                {
                    Xa = Xo - Yo / System.Math.Tan(Ay);
                    Ya = 0;
                }
                if (System.Math.Sin(Ay) != 1)
                {
                    Xb = (Yo - System.Math.Tan(Ax) * Xo) / (System.Math.Tan(Ay) - System.Math.Tan(Ax));
                    Yb = System.Math.Tan(Ay) * Xb;
                }
                else
                {
                    Xb = 0;
                    Yb = Yo - Xo * System.Math.Tan(Ax);
                }
                if (Xa >= 0)
                {
                    Xn = System.Math.Sqrt(Math.Pow((Xa), 2) + Math.Pow((Ya), 2));
                }
                else
                {
                    Xn = -System.Math.Sqrt(Math.Pow((Xa), 2) + Math.Pow((Ya), 2));
                }
                if (Yb >= 0)
                {
                    Yn = System.Math.Sqrt(Math.Pow((Xb), 2) + Math.Pow((Yb), 2));
                }
                else
                {
                    Yn = -System.Math.Sqrt(Math.Pow((Xb), 2) + Math.Pow((Yb), 2));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region 工程界面数据表格颜色更新
        public static bool Grid_TestData_Show(DataGridView dataGrid, int row, int col, string value, bool ErrColorEn = true)
        {
            try
            {
                if (dataGrid.RowCount < row)
                {
                    dataGrid.RowCount = 100;
                }
                dataGrid.Rows[row].Cells[col].Value = value;
                if (ErrColorEn == false || Convert.ToString(dataGrid.Rows[row].Cells[col].Value) == "NG")
                {
                    dataGrid.Rows[row].Cells[col].Style.ForeColor = Color.Red;
                    dataGrid.Rows[row].Cells[col].Style.BackColor = Color.FromArgb(175, 218, 150);
                }
                else
                {
                    dataGrid.Rows[row].Cells[col].Style.ForeColor = Color.Black;
                    dataGrid.Rows[row].Cells[col].Style.BackColor = Color.White;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 根据HSG_SN查找对应的索引
        /// <summary>
        /// 100代表没有，也即是新的条码
        /// </summary>
        /// <param name="HSG_SN"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int FindRowfromSN(string HSG_SN)
        {
            string tempValue = "";
            try
            {
                for (short i = 0; i <= PVar.BarcodeArrayList.Count() - 1; i++)
                {
                    tempValue = PVar.BarcodeArrayList[i];
                    if (tempValue.ToUpper() == HSG_SN.ToUpper())
                    {
                        return i;
                    }
                }
                return 100; //代表没找到
            }
            catch (Exception)
            {
                return 1000; //代表没找到
            }
        }
        #endregion

        #region 三色灯状态显示及蜂蜜器

        public static void LightStatus()
        {
            switch (PVar.LampStatus)
            {
                case 10: //异常报警
                    Alarm_Light(); //报警模式闪灯
                    break;

                case 20: //设备初始化完毕
                    IntOK_Light(); //初始化完成黄灯常亮
                    break;

                case 30: //机器工作正常
                    Gg.SetDo(0, 3, 0); //蜂鸣器
                    Gg.SetDo(0, 0, 0); //红色指示灯
                    Gg.SetDo(0, 1, 0); //黄色指示灯
                    Gg.SetDo(0, 2, 1); //绿色指示灯
                    break;

                case 40: //机器空跑
                    Run_Light(); //空跑工作闪灯
                    break;

                case 50: //开机无报警
                    Int_Light(); //开机无报警，黄灯闪，等待初始化
                    break;
            }
            Buzzer();
        }

        //蜂鸣器
        static int Buzzer_Time_N = 0;
        static bool Buzzer_Time_EN = false;
        private static void Buzzer()
        {
            if (PVar.Ring_EN)
            {
                PVar.Ring_EN = false;
                Buzzer_Time_EN = true;
                //Gg.SetExDo(0, 0, 13, 1);
                Gg.SetDo(0, Gg.OutPutMMS0.警示蜂鸣器, 1);
                Buzzer_Time_N = API.GetTickCount();
            }
            if (Buzzer_Time_EN)
            {
                if (API.GetTickCount() - Buzzer_Time_N > 500)
                {
                    Buzzer_Time_EN = false;
                    Buzzer_Time_N = 0;
                    //Gg.SetExDo(0, 0, 13, 0);
                    Gg.SetDo(0, Gg.OutPutMMS0.警示蜂鸣器, 0);
                }
            }
        }

        //  //报警闪灯逻辑：蜂鸣器和红灯一起闪，工作0.5S，停2S
        static int Alarm_Light_Time_N1 = 0;
        static int Alarm_Light_Time_N2 = 0;
        static bool Alarm_Light_Time_EN = false;

        private static void Alarm_Light()
        {
            if (Alarm_Light_Time_EN == false)
            {
                Alarm_Light_Time_EN = true;
                Gg.SetDo(0, 3, 0); //蜂鸣器
                Gg.SetDo(0, 0, 1); //红色指示灯
                Gg.SetDo(0, 1, 0); //黄色指示灯
                Gg.SetDo(0, 2, 0); //绿色指示灯

                Alarm_Light_Time_N1 = API.GetTickCount();
            }
            if (API.GetTickCount() - Alarm_Light_Time_N1 > 500)
            {
                if (API.GetTickCount() - Alarm_Light_Time_N2 > 500)
                {
                    Alarm_Light_Time_EN = false;
                }
                Gg.SetDo(0, 3, 0); //蜂鸣器
                Gg.SetDo(0, 0, 0); //红色指示灯
            }
            else
            {
                Alarm_Light_Time_N2 = API.GetTickCount();
            }
        }

        //  //无报警，初始化完成黄灯常亮
        static int IntOK_Light_Time_N1 = 0;
        static int IntOK_Light_Time_N2 = 0;
        static bool IntOK_Light_Time_EN = false;

        private static void IntOK_Light()
        {
            if (IntOK_Light_Time_EN == false)
            {
                IntOK_Light_Time_EN = true;
                Gg.SetDo(0, 3, 0); //蜂鸣器
                Gg.SetDo(0, 0, 0); //红色指示灯
                Gg.SetDo(0, 1, 1); //黄色指示灯
                Gg.SetDo(0, 2, 0); //绿色指示灯
                IntOK_Light_Time_N1 = API.GetTickCount();
            }
            if (API.GetTickCount() - IntOK_Light_Time_N1 > 500)
            {
                if (API.GetTickCount() - IntOK_Light_Time_N2 > 500)
                {
                    IntOK_Light_Time_EN = false;
                }
                //Gg.SetDo(0, 1, 0); //黄色指示灯'开启变成闪亮
            }
            else
            {
                IntOK_Light_Time_N2 = API.GetTickCount();
            }

        }

        //  //无报警，开机指示灯，黄灯闪
        static int Int_Light_Time_N1 = 0;
        static int Int_Light_Time_N2 = 0;
        static bool Int_Light_Time_EN = false;

        private static void Int_Light()
        {
            if (Int_Light_Time_EN == false)
            {
                Int_Light_Time_EN = true;
                Gg.SetDo(0, 3, 0); //蜂鸣器
                Gg.SetDo(0, 0, 0); //红色指示灯
                Gg.SetDo(0, 1, 1); //黄色指示灯
                Gg.SetDo(0, 2, 0); //绿色指示灯
                Int_Light_Time_N1 = API.GetTickCount();
            }
            if (API.GetTickCount() - Int_Light_Time_N1 > 500)
            {
                if (API.GetTickCount() - Int_Light_Time_N2 > 500)
                {
                    Int_Light_Time_EN = false;
                }
                Gg.SetDo(0, 1, 0); //黄色指示灯
            }
            else
            {
                Int_Light_Time_N2 = API.GetTickCount();
            }
        }

        //  //空跑模式红灯闪
        static int Run_Light_Time_N1 = 0;
        static int Run_Light_Time_N2 = 0;
        static bool Run_Light_Time_EN = false;

        private static void Run_Light()
        {
            if (Run_Light_Time_EN == false)
            {
                Run_Light_Time_EN = true;
                Gg.SetDo(0, 3, 0); //蜂鸣器
                Gg.SetDo(0, 0, 1); //红色指示灯
                Gg.SetDo(0, 1, 0); //黄色指示灯
                Gg.SetDo(0, 2, 0); //绿色指示灯
                Run_Light_Time_N1 = API.GetTickCount();
            }
            if (API.GetTickCount() - Run_Light_Time_N1 > 500)
            {
                if (API.GetTickCount() - Run_Light_Time_N2 > 500)
                {
                    Run_Light_Time_EN = false;
                }
                Gg.SetDo(0, 0, 0); //红色指示灯
            }
            else
            {
                Run_Light_Time_N2 = API.GetTickCount();
            }
        }
        #endregion

        #region 启动/关闭进程

        /// <summary>
        /// 启动屏幕键盘程序
        /// </summary>
        /// <remarks></remarks>
        public static void Start_NumberKey_Process()
        {
            string Path = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\TabTip.exe";
            System.Diagnostics.Process.Start(Path);
        }

        /// <summary>
        /// 关闭屏幕键盘进程函数
        /// </summary>
        /// <remarks></remarks>
        public static void Close_NumberKey_Process()
        {
            System.Diagnostics.Process[] sProcess = null; //定义一个进程数组
            sProcess = System.Diagnostics.Process.GetProcessesByName("TabTip"); //获取指定进程
            try
            {
                if (sProcess.Length > 0) //判断进程个数
                {
                    sProcess[0].CloseMainWindow(); //关闭获取的第一个进程
                }
            }
            catch (Exception)
            {

            }
        }

        public static void Close_Key_Process()
        {
            System.Diagnostics.Process[] sProcess = null; //定义一个进程数组
            sProcess = System.Diagnostics.Process.GetProcessesByName("屏幕键盘"); //获取指定进程
            try
            {
                if (sProcess.Length > 0) //判断进程个数
                {
                    sProcess[0].CloseMainWindow(); //关闭获取的第一个进程
                }
            }
            catch (Exception)
            { }
        }

        public static void Close_Excel_Process()
        {
            System.Diagnostics.Process[] sProcess = null; //定义一个进程数组
            sProcess = System.Diagnostics.Process.GetProcessesByName("EXCEL"); //获取指定进程
            try
            {
                if (sProcess.Length > 0) //判断进程个数
                {
                    sProcess[0].CloseMainWindow(); //关闭获取的第一个进程
                }
            }
            catch (Exception)
            { }
        }

        #endregion

    }

}
