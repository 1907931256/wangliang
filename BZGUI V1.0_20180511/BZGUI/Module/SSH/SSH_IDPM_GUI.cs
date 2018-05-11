using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BZGUI
{
    public partial class SSH_IDPM_GUI : Form
    {
        private bool isConn = false;

        public SSH_IDPM_GUI()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            SSH_Thread.Instance.OnSSHInf += Instance_SSHInfoShow;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.Text != "Private key")
                {
                    SSH.Instance.Connect(this.tbHostAddress.Text, 22, this.tbUserName.Text, this.tbPassword.Text, out isConn);
                }
                else
                {
                    SSH.Instance.Connect(this.tbHostAddress.Text, 22, this.tbUserName.Text, out isConn);
                }
                if (isConn) SSH_Thread.Instance.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            SSH.Instance.disConnect(out isConn);
        }

        private void bExecuteCommand_Click(object sender, EventArgs e)
        {
            if (isConn)
                SSH.Instance.ExecuteCommand(this.txtCammand.Text);
        }

        private void SSH_IDPM_GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void Instance_SSHInfoShow(string SSHinfo)
        {
            SSHOutput.AppendText(SSHinfo);
            SSHOutput.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.btnSSHopen.BackColor = Globals.settingFunc.打开SSH通信 ? Color.LimeGreen : Color.Red;
            this.btn_CreatSSHfolder.Visible = Globals.settingFunc.打开SSH通信 ? false : true;
            //if (Globals.settingFunc.打开SSH通信)
            //{
            //    this.Enabled = true;
            this.btn_SSHsts.BackColor = isConn ? Color.LimeGreen : Color.Red;
            Globals.SSHconnSt = isConn;//如果在手动打开了，更新全局变量
            ////}
            //else
            //{
            //    this.Enabled = false;
            //    this.btn_SSHsts.BackColor = Color.Red;
            //}

        }

        private void btn_CreatSSHfolder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定需要创建Private key 的连接方式吗？？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //先密码连接
                SSH.Instance.Connect(this.tbHostAddress.Text, 22, this.tbUserName.Text, this.tbPassword.Text, out isConn);
                if (isConn)
                {
                    try
                    {
                        SSH.Instance.ExecuteCommand("cd /Users/gdlocal");//指向此文件夹
                        Thread.Sleep(500);
                        if (Directory.Exists(@"\\192.168.1.20\gdlocal\.ssh") == false)
                        {
                            SSH.Instance.ExecuteCommand("mkdir .ssh");//创建.ssh文件夹  
                        }
                        Thread.Sleep(500);
                        Globals.comf.copyFile(PVar.BZ_ParameterPath + "PrivateKey\\ssh\\id_rsa.pub", @"\\192.168.1.20\gdlocal\.ssh\\id_rsa.pub", false);
                        Globals.comf.copyFile(PVar.BZ_ParameterPath + "PrivateKey\\ssh\\authorized_keys", @"\\192.168.1.20\gdlocal\.ssh\authorized_keys", false);
                        Globals.comf.copyFile(PVar.BZ_ParameterPath + "PrivateKey\\ssh\\id_rsa", @"\\192.168.1.20\gdlocal\.ssh\id_rsa", false);
                        //SSH.Instance.disConnect(out isConn);
                        Globals.settingFunc.打开SSH通信 = true;
                        Globals.settingFunc.SaveSetting();
                        MessageBox.Show("创建Private key 的连接方式 成功！");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                { MessageBox.Show("SSH连接错误，请确认网络是否连接；IP地址是否正确；密码是否正确？"); }
            }
        }


    }
}
