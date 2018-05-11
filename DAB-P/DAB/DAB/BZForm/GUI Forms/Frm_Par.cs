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
using BZ.UI;
using Microsoft.VisualBasic.PowerPacks;
using VB = Microsoft.VisualBasic;
using System.IO;

namespace DAB
    {

    public partial class Frm_Par
        {
        public static Frm_Par fPar = new Frm_Par();
        public static event Action<string> ShowList;    // this.Dialog_OnAdd(s)
        private static object LockPar = new object();

        public Frm_Par()
            {
            InitializeComponent();
            fPar = this;
            }

        public struct SerialParam
            {
            public string PortName;
            public int BaudRate;
            public int DataBits;
            public System.IO.Ports.Parity Parity;
            public System.IO.Ports.StopBits StopBits;
            }

        private void Frm_Par_Load(object sender, EventArgs e)
            {
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.MainColor;
            Par_Normal("Read");

            TableLayoutPanel1.Enabled = false;
            TableLayoutPanel3.Enabled = false;
            TableLayoutPanel4.Enabled = false;

            txt_ErrCount1.Text = BVar.FileRorW.ReadINI("ErrStatistics", "PickCCDErr", System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath);
            txt_ErrCount2.Text = BVar.FileRorW.ReadINI("ErrStatistics", "PickErr", System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath);
            txt_ErrCount9.Text = BVar.FileRorW.ReadINI("ErrStatistics", "HsgSnErr", System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath);
            txt_ErrCount10.Text = BVar.FileRorW.ReadINI("ErrStatistics", "HsgErr", System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath);
            txt_ErrCount3.Text = BVar.FileRorW.ReadINI("ErrStatistics", "MEMErrCounts", System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath);

            txt_ProductCounts.Text = BVar.FileRorW.ReadINI("Product", "Counts", System.Convert.ToString(0), PVar.BZ_YieldDataFileName);
            Text_OKCounts.Text = BVar.FileRorW.ReadINI("Product", "OKCounts", System.Convert.ToString(0), PVar.BZ_YieldDataFileName);
            Text_NGCounts.Text = BVar.FileRorW.ReadINI("Product", "NGCounts", System.Convert.ToString(0), PVar.BZ_YieldDataFileName);
            PVar.OKCounts = (int)(Conversion.Val(Text_OKCounts.Text));
            PVar.NGCounts = (int)(Conversion.Val(Text_NGCounts.Text));
            if (PVar.OKCounts + PVar.NGCounts > 0)
                {
                Text_Yeild.Text = Strings.Format((double)PVar.OKCounts / (PVar.OKCounts + PVar.NGCounts) * 100, "0.00");
                }
            else
                {
                Text_Yeild.Text = System.Convert.ToString(double.Parse(Strings.Format(1, "0.00")) * 100);
                }
            }

        #region 功能：清除统计
        private void Btn_ClearCount_Click(object sender, EventArgs e)
            {
            if (Interaction.MsgBox("    确定要清零吗？", (int)MsgBoxStyle.Question + Constants.vbYesNo, "清零提示") == Constants.vbNo)
                {
                return;
                }
            Par_Clear();
            FileLog.OperateLog("清除统计");
            }

        public void Par_Clear()
            {
            PVar.ProductCounts = 0;
            PVar.OKCounts = 0;
            PVar.NGCounts = 0;
            PVar.PickCCDErrCounts = 0;
            PVar.PickErrCounts = 0;
            PVar.HsgSnErrCounts = 0;
            PVar.HsgErrCounts = 0;
            PVar.MEMErrCounts = 0;
            PVar.CPKCounts = 0;
            PVar.CPKDoneCounts = 0;

            BVar.FileRorW.WriteINI("Product", "Counts", System.Convert.ToString(PVar.ProductCounts), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("Product", "OKCounts", System.Convert.ToString(PVar.OKCounts), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("Product", "NGCounts", System.Convert.ToString(PVar.NGCounts), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("ErrStatistics", "PickCCDErr", System.Convert.ToString(PVar.PickCCDErrCounts), PVar.BZ_ErrStatisticsPath);
            BVar.FileRorW.WriteINI("ErrStatistics", "PickErr", System.Convert.ToString(PVar.PickErrCounts), PVar.BZ_ErrStatisticsPath);
            BVar.FileRorW.WriteINI("ErrStatistics", "HsgSnErr", System.Convert.ToString(PVar.HsgSnErrCounts), PVar.BZ_ErrStatisticsPath);
            BVar.FileRorW.WriteINI("ErrStatistics", "HsgErr", System.Convert.ToString(PVar.HsgErrCounts), PVar.BZ_ErrStatisticsPath);
            BVar.FileRorW.WriteINI("ErrStatistics", "MEMErrCounts", System.Convert.ToString(PVar.MEMErrCounts), PVar.BZ_ErrStatisticsPath);

            txt_ErrCount1.Text = System.Convert.ToString(PVar.PickCCDErrCounts);
            txt_ErrCount2.Text = System.Convert.ToString(PVar.PickErrCounts);
            txt_ErrCount9.Text = System.Convert.ToString(PVar.HsgSnErrCounts);
            txt_ErrCount10.Text = System.Convert.ToString(PVar.HsgErrCounts);
            txt_ErrCount3.Text = System.Convert.ToString(PVar.MEMErrCounts);

            Frm_Engineering.fEngineering.Product_Num.Text = System.Convert.ToString(PVar.ProductCounts);
            Text_OKCounts.Text = System.Convert.ToString(PVar.OKCounts);
            Text_NGCounts.Text = System.Convert.ToString(PVar.NGCounts);
            txt_ProductCounts.Text = System.Convert.ToString(PVar.ProductCounts);

            if (PVar.OKCounts + PVar.NGCounts > 0)
                {
                Text_Yeild.Text = Strings.Format((double)PVar.OKCounts / (PVar.OKCounts + PVar.NGCounts) * 100, "0.00");
                }
            else
                {
                Text_Yeild.Text = System.Convert.ToString(double.Parse(Strings.Format(1, "0.00")) * 100);
                }
            Frm_Engineering.fEngineering.DataGrid_CheckData.Rows.Clear(); //清楚工程界面表格数据
            }

        #endregion

        private void Btn_ParEnable_Click(object sender, EventArgs e)
            {
            if (PVar.MacHold || (PVar.Stop_Flag && (PVar.Sta_Work[0].Step < 20 && PVar.Sta_Work[1].Step < 20 && PVar.Sta_Work[2].Step < 20 && PVar.Sta_Work[3].Step < 20 && PVar.Sta_Work[4].Step < 20)))
                {
                }
            else
                {
                ShowList("设备运行中,请先暂停设备！");
                return;
                }

            Frm_Login FrmLogin = new Frm_Login();
            if (FrmLogin.Visible == false)
                {
                FrmLogin.Show();
                FrmLogin.MainPassword.Focus();
                }
            }

        private void Btn_ParKeyboard_Click(object sender, EventArgs e)
            {
            int SoftKeyBoard_hwnd = 0; //定义标识句柄变量
            int Temp_hwnd = 0;
            Temp_hwnd = System.Convert.ToInt32(API.FindWindow(Constants.vbNullString, "Frm_Main"));
            SoftKeyBoard_hwnd = API.FindWindow(Constants.vbNullString, "屏幕键盘"); //获取屏幕键盘的标识句柄
            if (SoftKeyBoard_hwnd > 0) //判断屏幕键盘的标识句柄是否获取成功，不等于0则说明获取成功
                {
                API.BringWindowToTop(SoftKeyBoard_hwnd); //屏幕键盘已打开则将屏幕键盘放置在所有窗体的顶部
                }
            else
                {
                API.ShellExecute(Temp_hwnd, "Open", "屏幕键盘.exe", "", Application.StartupPath, 4); //屏幕键盘未打开则指定路径打开屏幕键盘
                }
            }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
            {
            for (var i = 1; i <= 100; i++)
                {
                foreach (dynamic f in this.TableLayoutPanel4.Controls)
                    {
                    if (f.Name == "CheckBox" + (i).ToString())
                        {
                        if (f.Checked == true)
                            {
                            f.BackColor = Color.Lime;
                            }
                        else
                            {
                            f.BackColor = Color.FromArgb(238, 238, 238);
                            }
                        }
                    }
                }
            }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
            {
            Btn_ParBackup.Enabled = false;
            Btn_ParKeyboard.Enabled = false;
            //Btn_ParSave.Enabled = false;
            FileLog.OperateLog("参数备份");
            }

        public void Par_Normal(string Sts)
            {
            lock (LockPar)

            switch (Sts)
                {
                case "Read":
                    PVar.IsReadParData = false;
                    FileRw.ReadParData(PVar.BZ_ParameterPath + "\\ParData.dat", PVar.ParList); //指定目录下面					
                    try
                        {
                        for (var i = 1; i <= 10; i++)
                            {
                            foreach (dynamic f in this.TableLayoutPanel3.Controls)
                                {
                                if (f.Name == "TextMachine" + (i).ToString())
                                    {
                                    f.Text = PVar.ParList.MacInfo[i];
                                    }
                                }
                            }

                        for (var i = 1; i <= 63; i++)
                            {
                            foreach (dynamic f in this.TableLayoutPanel1.Controls)
                                {
                                if (f.Name == "TextBox_" + (i).ToString())
                                    {
                                    f.Text = Convert.ToString(PVar.ParList.Data[i]);
                                    }
                                }
                            }

                        for (var i = 1; i <= 48; i++)
                            {
                            foreach (dynamic f in this.TableLayoutPanel4.Controls)
                                {
                                if (f.Name == "CheckBox" + (i).ToString())
                                    {
                                    if (PVar.ParList.CheckSts[i])
                                        {
                                        f.Checked = true;
                                        }
                                    else
                                        {
                                        f.Checked = false;
                                        }
                                    }
                                }
                            }
                        }
                    catch (Exception)
                        {
                        MessageBox.Show("参数读取出错，请注意！");
                        }
                    break;

                case "Write":
                    try
                        {
                        for (var i = 1; i <= 10; i++)
                            {
                            foreach (dynamic f in this.TableLayoutPanel3.Controls)
                                {
                                if (f.Name == "TextMachine" + (i).ToString())
                                    {
                                    PVar.ParList.MacInfo[i] = System.Convert.ToString(f.Text);
                                    }
                                }
                            }

                        for (var i = 1; i <= 63; i++)
                            {
                            foreach (dynamic f in this.TableLayoutPanel1.Controls)
                                {
                                if (f.Name == "TextBox_" + (i).ToString())
                                    {
                                    PVar.ParList.Data[(int)i] = System.Convert.ToDouble(AxScriptControl1.Eval(f.Text));
                                    }
                                }
                            }

                        for (var i = 1; i <= 48; i++)
                            {
                            foreach (dynamic f in this.TableLayoutPanel4.Controls)
                                {
                                if (f.Name == "CheckBox" + (i).ToString())
                                    {
                                    if (f.Checked)
                                        {
                                        PVar.ParList.CheckSts[i] = true;
                                        }
                                    else
                                        {
                                        PVar.ParList.CheckSts[i] = false;
                                        }
                                    }
                                }
                            }
                        FileRw.WriteParData(PVar.BZ_ParameterPath + "\\ParData.dat", PVar.ParList);
                        }
                    catch (Exception)
                        {
                        MessageBox.Show("参数保存出错，请注意！");
                        return;
                        }
                    break;
                }

            if (PVar.ParList.CheckSts[17])
            { PVar.空跑 = true; }
            else
            { PVar.空跑 = false; }

            if (PVar.ParList.CheckSts[17])
                {
                Frm_Engineering.fEngineering.Label_WorkMode.Visible = true;
                Frm_Engineering.fEngineering.Label_NG_OK.Visible = false;
                }
            else
                {
                Frm_Engineering.fEngineering.Label_WorkMode.Visible = false;
                Frm_Engineering.fEngineering.Label_NG_OK.Visible = true;
                }
            if (PVar.WorkMode == 1)
                {
                Frm_Engineering.fEngineering.Label_CPK.Visible = true;
                }
            else
                {
                Frm_Engineering.fEngineering.Label_CPK.Visible = false;
                }
            }

        private void Btn_ParSave_Click(object sender, EventArgs e)
            {

            if (CheeckPar() == false)
                {
                Par_Normal("Read");
                FileLog.OperateLog("保存参数按钮，失败");
                return;
                }

            Par_Normal("Write");
            FileLog.OperateLog("保存参数按钮，成功");
            TableLayoutPanel1.Enabled = false;
            TableLayoutPanel3.Enabled = false;
            TableLayoutPanel4.Enabled = false;
            Par_Normal("Read");
            FunctionSub.Init_Serial1(); //重新加载串口
            FunctionSub.Init_Serial2(); //重新加载串口
            FunctionSub.Init_Serial3(); //重新加载串口

            if (Interaction.MsgBox("参数保存OK！", Constants.vbOKOnly, "提示") == Constants.vbOK)
                {
                return;
                }
            }

        /// <summary>
        /// 检测参数是否在范围内
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private bool CheeckPar()
            {
            if (Math.Abs(System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_1.Text))) > 0.2)
                {
                ShowList(VB.Strings.Left(Label33.Text, Label33.Text.Length - 1) + "的值超出：±0.2");
                return false;
                }

            if (Math.Abs(System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_2.Text))) > 0.2)
                {
                ShowList(VB.Strings.Left(Label34.Text, Label34.Text.Length - 1) + "的值超出：±0.2");
                return false;
                }

            if (Math.Abs(System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_3.Text))) > 0.5)
                {
                ShowList(VB.Strings.Left(Label35.Text, Label35.Text.Length - 1) + "的值超出：±0.5");
                return false;
                }

            //以上没错误则返回Ture
            return true;
            }

        private double Btn_UpadeSoft_Click_UpdatetTime = 0;

        private void Btn_UpadeSoft_Click(object sender, EventArgs e)
            {
            string Timestr = "";
            string Filestr = "";
            Btn_UpadeSoft.Enabled = false;
            Btn_UpadeSoft.Text = "网络链接中";
            FileLog.OperateLog("Mini下载软件");
            try
                {
                Frm_Engineering.fEngineering.Tcp_PDCA.StopConnect(); //关闭PDCA
                WinAPI.Wait(100);
                if (Frm_Engineering.fEngineering.Tcp_PDCA.IsStart == false)
                    {
                    Frm_Engineering.fEngineering.Tcp_PDCA.StartConnect(); //PDCA网络链接
                    WinAPI.Wait(2000);
                    }

                if (Frm_Engineering.fEngineering.Tcp_PDCA.IsStart == false)
                    {
                    Btn_UpadeSoft.Enabled = true;
                    Btn_UpadeSoft.Text = "Mini下载软件";
                    Interaction.MsgBox("网络未连接", (int)MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "提示");
                    return;
                    }

                Timestr = DateTime.Now.ToString("yyyyMMddHHmmss");
                System.IO.Directory.CreateDirectory(PVar.FileDirectoryDes + Timestr);

                Filestr = PVar.FileDirectorySrc + "*DAB*.rar";
                if (System.IO.File.Exists(Filestr) != false)
                    {
                    System.IO.File.Copy(Filestr, PVar.FileDirectoryDes + Timestr + "\\" + "*DAB*.rar", true);
                    Btn_UpadeSoft_Click_UpdatetTime = System.Convert.ToDouble(API.GetTickCount());
                    }
                else
                    {
                    Interaction.MsgBox("目标源文件不存在", MsgBoxStyle.OkOnly, null);
                    Btn_UpadeSoft.Text = "Mini下载软件";
                    Btn_UpadeSoft.Enabled = true;
                    return;
                    }
                Btn_UpadeSoft.Text = "正在下载中";
                do
                    {
                    if (Btn_UpadeSoft_Click_UpdatetTime - API.GetTickCount() > 10000)
                        {
                        Interaction.MsgBox("下载不成功", MsgBoxStyle.OkOnly, null);
                        Btn_UpadeSoft.Enabled = true;
                        Btn_UpadeSoft.Text = "Mini下载软件";
                        return;
                        }
                    Application.DoEvents();
                    } while (!(File.Exists(PVar.FileDirectoryDes + Timestr + "\\" + "*DAB*.rar")));

                Interaction.MsgBox("下载成功", MsgBoxStyle.OkOnly, null);
                }
            catch (Exception ex)
                {
                Btn_UpadeSoft.Enabled = true;
                Btn_UpadeSoft.Text = "Mini下载软件";
                Interaction.MsgBox(ex.Message, (int)MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "提示");
                }
            }

        private void Button1_Click(object sender, EventArgs e)
            {
            string[] ERRData = new string[3];
            try
                {

                if (RadioButton1.Checked == true)
                    {
                    ERRData = Strings.Split(Com_ErrorCode1.Text, ",");
                    ERRData[0] = ERRData[0].Replace("\u0022", ""); //把字符串双引号替换掉
                    ERRData[1] = ERRData[1].Replace("\u0022", "");
                    Mod_ErrorCode.WriteErrorCode(ERRData[0], int.Parse(ERRData[1]));
                    FileLog.OperateLog("ErrorCode测试");
                    }
                else if (RadioButton2.Checked == true)
                    {
                    ERRData = Strings.Split(Com_ErrorCode2.Text, ",");
                    ERRData[0] = ERRData[0].Replace("\u0022", "");
                    ERRData[1] = ERRData[1].Replace("\u0022", "");
                    Mod_ErrorCode.WriteErrorCode(ERRData[0], int.Parse(ERRData[1]));
                    FileLog.OperateLog("ErrorCode测试");
                    }
                else
                    {
                    Interaction.MsgBox("-->请选择测试项", (int)MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "提示");
                    }
                }
            catch (Exception)
                {
                Interaction.MsgBox("-->请选择测试项", (int)MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "提示");
                }

            }

        private void Button3_Click(object sender, EventArgs e)
            {
            Mod_ErrorCode.WriteCsvErrorCodeOK();
            FileLog.OperateLog("ErrorCode OK");
            }

        private void Button1_Click_1(object sender, EventArgs e)
            {
            Mod_ErrorCode.WriteErrorCode(Com_ErrorCode1.Text, 1);
            }

        private void Button2_Click(object sender, EventArgs e)
            {
            Mod_ErrorCode.WriteErrorCode(Com_ErrorCode2.Text, 1);
            }

        private void TextBox_1_TextChanged(object sender, EventArgs e)
            {
            try
                {
                if (System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_1.Text)) > 1
                    || System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_1.Text)) < -1)
                    {
                    Par_Normal("Read");
                    Interaction.MsgBox("流水线的速度范围-1~1，请重新设定！", (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "提示");
                    }
                }
            catch (Exception ex)
                {
                ex.ToString();
                }
            }

        private void TextBox_2_TextChanged(object sender, EventArgs e)
            { 
            try
                {
                if (System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_2.Text)) > 1
                    || System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_2.Text)) < -1)
                    {
                    Par_Normal("Read");
                    Interaction.MsgBox("流水线的速度范围-1~1，请重新设定！", (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "提示");
                    }
                }
            catch (Exception ex)
                {
                ex.ToString();
                }
            }

        private void TextBox_43_TextChanged(object sender, EventArgs e)
            {
            try
                {
                if (System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_43.Text)) > 50 
                    || System.Convert.ToInt16(AxScriptControl1.Eval(TextBox_43.Text)) < 5)
                    {
                    Par_Normal("Read");
                    Interaction.MsgBox("流水线的速度范围5~50（mm/s），请重新设定！", (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "提示");
                    }
                }
            catch (Exception ex)
                {
                ex.ToString();
                }
            }

        }
    }
