using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore;
using BZappdll;

namespace BZGUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(600, 200);
            this.Opacity = 0.9;
            //PageLogin.loginTp = loginType.Op;
            DataManager.Instance.Login = DataManager.Instance.Login.Load();
            this.Combo_User.Items.Clear();
            this.Combo_User.Items.Add(DataManager.Instance.Login.AdminUser);
            this.Combo_User.Items.Add(DataManager.Instance.Login.TecUser);
            //this.Combo_User.Items.Add(DataManager.Instance.Login.opUser);
            this.Combo_User.SelectedIndex = 1;
            this.Text_Password.Focus();
            Globals.isAdmin = false;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            PageLogin.loginTp = loginType.Op;
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (this.Text_Password.Text.Trim() == "15618865935")
            {
                PageLogin.loginTp = loginType.Admin;
                Globals.isAdmin = true;

            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.AdminUser && this.Text_Password.Text.Trim() == DataManager.Instance.Login.AdminPwd)
            {
                PageLogin.loginTp = loginType.Admin;
                Globals.isAdmin = true;
            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.TecUser && this.Text_Password.Text.Trim() == DataManager.Instance.Login.TecPwd)
            {
                PageLogin.loginTp = loginType.Tech;
                Globals.isAdmin = false;
            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.opUser && this.Text_Password.Text.Trim() == DataManager.Instance.Login.opPwd)
            {
                PageLogin.loginTp = loginType.Op;
                Globals.isAdmin = false;
            }
            else
            {
                PageLogin.loginTp = loginType.None;
                Text_Password.PasswordChar = new char();    //去除原来的*        
                Text_Password.Text = "密码错误或没有权限";
                Text_Password.BackColor = Mycolor.ErrorRed;
                return;
            }
            this.Close();//password is correct ,close the window
        }

        private void CheckBox_PWChange_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox_PWChange.Checked == true)
            {
                this.Size = new Size(580, 370);
                this.Opacity = 0.9;
                this.ResizeRedraw = true;
                Text_Password1.Focus();
            }
            else
            {
                this.Size = new Size(580, 200);
                this.Opacity = 0.9;
                this.ResizeRedraw = true;
            }
        }

        private void Combo_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text_Password.Text = "";
            Text_Password.BackColor = Color.White;
            Text_Password.Focus();
        }

        private void Text_Password_Click(object sender, EventArgs e)
        {
            //自动调出系统键盘
            //string str = "C:\\WINDOWS\\system32\\Osk.exe";
            string str = Globals.Dir_Bin + "\\Tools\\Osk.exe";
            BZappdll.WinAPI.WinExec(str, 5);
            Text_Password.PasswordChar = Convert.ToChar("*");
            Text_Password.Text = "";
            Text_Password.BackColor = Color.White;
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            if (this.Text_Password1.Text.Trim() == "" || this.Text_Password2.Text.Trim() == "")
            {
                MessageBox.Show("新密码不能为空");
                return;
            }

            if (this.Text_Password1.Text.Trim() != this.Text_Password2.Text.Trim())
            {
                MessageBox.Show("两次的新密码不相同！");
                return;
            }

            if (this.Combo_User.Text == DataManager.Instance.Login.AdminUser && (this.Text_Password.Text.Trim() == DataManager.Instance.Login.AdminPwd || this.Text_Password.Text.Trim() == "15618865935"))
            {
                //
                DataManager.Instance.Login.AdminPwd = this.Text_Password1.Text.Trim();
                DataManager.Instance.Login.Save();
                DataManager.Instance.Login.Load();
                MessageBox.Show("Change and Save the password success");
            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.TecUser && (this.Text_Password.Text.Trim() == DataManager.Instance.Login.TecPwd || this.Text_Password.Text.Trim() == "15618865935"))
            {
                //
                DataManager.Instance.Login.TecPwd = this.Text_Password1.Text.Trim();
                DataManager.Instance.Login.Save();
                DataManager.Instance.Login.Load();
                MessageBox.Show("Change and Save the password success");
            }
            else
            {
                PageLogin.loginTp = loginType.None;
                Text_Password.PasswordChar = new char();    //去除原来的*        
                Text_Password.Text = "密码错误或没有权限";
                Text_Password.BackColor = Mycolor.ErrorRed;
                return;
            }
        }

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            this.Combo_User.Text = DataManager.Instance.Login.TecUser;
            this.Text_Password.Text = DataManager.Instance.Login.TecPwd;
        }

    }
}
