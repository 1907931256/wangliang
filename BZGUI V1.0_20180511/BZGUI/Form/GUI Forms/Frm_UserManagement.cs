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

namespace BZGUI
{
	public partial class Frm_UserManagement
	{
        public static Frm_UserManagement fUserManagement = null; 
		public Frm_UserManagement()
		{
			InitializeComponent();
            fUserManagement = this;
		}
		public short UserAuthorityTemp;

        private void Frm_UserManagement_Load(object sender, EventArgs e)
        {
            UserListDisplay();
        }

        private void PasswordConfirm_Click(object sender, EventArgs e)
        {
			UserMessageConfirm();
			AfterSaleSelected.Checked = false;
			EngineeringSelected.Checked = false;
			FE2Selected.Checked = false;
		}

        private void UserDelete_Click(object sender, EventArgs e)
        {
			FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
			if (UserListBox.Items.Count > 0)
			{
				for (var i = 0; i <= 20; i++)
				{
                if ((string)UserListBox.SelectedItem == PVar.Login.NewUser[(int)i] && PVar.Login.NewUser[i] != "")
					{
						UserListBox.Items.Remove(PVar.Login.NewUser[(int) i]);
                        Frm_Main.fMain.MainUserName.Items.Remove(PVar.Login.NewUser[(int)i]);
						Frm_Login.fLogin.MainUserName.Items.Remove(PVar.Login.NewUser[(int) i]);
						PVar.Login.NewUser[(int) i] = "";
						NewUserName.Text = PVar.Login.NewUser[(int) i];
						PVar.Login.NewPassword[(int) i] = "";
						PVar.Login.NewPasswordChecked[(int) i] = "";
						PVar.Login.NewUserAuthority[(int) i] =(short) -1;
						FileRw.WriteDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
					}
				}
			}
		}
		
		public void UserMessageConfirm()
		{
			int i = 0;
			if (NewUserName.Text != "")
			{
				if (NewUserPassword.Text != "" && NewUserPasswordChecked.Text != "")
				{
					if (NewUserPassword.Text == NewUserPasswordChecked.Text)
					{
						if (AfterSaleSelected.Checked || EngineeringSelected.Checked || FE2Selected.Checked)
						{
							for (i = 0; i <= 20; i++)
							{
								if (PVar.Login.NewUser[i] == null)
								{
									PVar.Login.NewUser[i] = NewUserName.Text;
									PVar.Login.NewPassword[i] = NewUserPassword.Text;
									PVar.Login.NewPasswordChecked[i] = NewUserPasswordChecked.Text;
									PVar.Login.NewUserAuthority[i] = UserAuthorityTemp;
									NewUserPassword.Text = "";
									NewUserPasswordChecked.Text = "";
									FileRw.WriteDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
									UserListRefresh();
									UserListBox.Items.Add(PVar.Login.NewUser[i]);
                                    Frm_Main.fMain.MainUserName.Items.Add(PVar.Login.NewUser[i]);
									Frm_Login.fLogin.MainUserName.Items.Add(PVar.Login.NewUser[i]);
									break;
								}
								else if (PVar.Login.NewUser[i] == NewUserName.Text)
								{
									PVar.Login.NewUser[i] = NewUserName.Text;
									PVar.Login.NewPassword[i] = NewUserPassword.Text;
									PVar.Login.NewPasswordChecked[i] = NewUserPasswordChecked.Text;
									PVar.Login.NewUserAuthority[i] = UserAuthorityTemp;
									NewUserPassword.Text = "";
									NewUserPasswordChecked.Text = "";
									FileRw.WriteDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
									UserListRefresh();
									UserListBox.Items.Add(PVar.Login.NewUser[i]);
									Frm_Login.fLogin.MainUserName.Items.Add(PVar.Login.NewUser[i]);
                                    Frm_Main.fMain.MainUserName.Items.Add(PVar.Login.NewUser[i]);
									break;
								}
							}
							FileRw.WriteDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
							UserListRefresh();
						}
						else
						{
                        if (Interaction.MsgBox("用户权限不能为空，请选择！", (int)Constants.vbOKCancel + Constants.vbQuestion, "提示") != Constants.vbOK)
							return;
						}
					}
					else
					{
                        if (Interaction.MsgBox("两次密码输入不同，请重新输入！", (int)Constants.vbOKCancel + Constants.vbQuestion, "提示") != Constants.vbOK)
							return;
					}
				}
				else
				{
                    if (Interaction.MsgBox("密码不能为空，请重新输入！", (int)Constants.vbOKCancel + Constants.vbQuestion, "提示") != Constants.vbOK)
						return;
				}
			}
			else
			{
            if (Interaction.MsgBox("账户不能为空，请重新输入！", (int)Constants.vbOKCancel + Constants.vbQuestion, "提示") != Constants.vbOK)
				return;
			}
		}
		
		private void OPSelected_CheckedChanged(dynamic sender, EventArgs e)
		{
			if ((int) sender.TabIndex == 1)
			{
				if (AfterSaleSelected.Checked)
				{
					PVar.Login.NewGroup[0] = "Post Safe";
					UserAuthorityTemp = 1;
                    AfterSaleSelected.Checked = true;
                    EngineeringSelected.Checked = false;
                    FE2Selected.Checked = false;
				}
			}
            else if ((int)sender.TabIndex == 2)
			{
				if (EngineeringSelected.Checked)
				{
					PVar.Login.NewGroup[1] = "Engineering";
					UserAuthorityTemp = 2;
                    AfterSaleSelected.Checked = false;
                    EngineeringSelected.Checked = true;
                    FE2Selected.Checked = false;
				}
			}
            else if ((int)sender.TabIndex == 3)
			{
				if (FE2Selected.Checked)
				{
					PVar.Login.NewGroup[2] = "FE2";
					UserAuthorityTemp = 3;
                    AfterSaleSelected.Checked = false;
                    EngineeringSelected.Checked = false;
                    FE2Selected.Checked = true;
				}
			}
		}
		
		private void UserListRefresh()
		{
			FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
			for (var i = 0; i <= 20; i++)
			{
                if (PVar.Login.NewUser[i] != "")
				{
					if (UserListBox.Items.Count > 0)
					{
						for (var j = 0; j <= (UserListBox.Items.Count - 1); j++)
						{
							if (j <= (UserListBox.Items.Count - 1))
							{
								string ss;
								string FF;
                                ss = System.Convert.ToString(UserListBox.Items[j]);
                                FF = System.Convert.ToString(Frm_Main.fMain.MainUserName.Items[j]);
                                if (ss == NewUserName.Text)
								{
									UserListBox.Items.Remove(PVar.Login.NewUser[(int) j]);
                                    Frm_Main.fMain.MainUserName.Items.Remove(PVar.Login.NewUser[(int)j]);
									Frm_Login.fLogin.MainUserName.Items.Remove(PVar.Login.NewUser[(int) j]);
								}
							}
						}
					}
				}
			}
			NewUserName.Text = "";
			FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
		}

        private void UserListDisplay()
        {
            UserListBox.Items.Clear();
            FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "\\PassWord.dat", PVar.Login);
            for (var i = 0; i <= 20; i++)
            {
                if (PVar.Login.NewUser[i] != "" && PVar.Login.NewUser[i] != null)
                {
                    UserListBox.Items.Add(PVar.Login.NewUser[(int)i]);
                }
            }
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListBox listbox = sender as ListBox;
            if (UserListBox.Items.Count > 0)
            {
                NewUserName.Text = System.Convert.ToString(UserListBox.SelectedItem);
                int i=UserListBox.SelectedIndex;
                this.txt_password.Text = PVar.Login.NewPassword[i];
                int Authority = PVar.Login.NewUserAuthority[i];
                if (Authority == 1)
                {
                    this.AfterSaleSelected.Checked = true;
                    this.EngineeringSelected.Checked = false;
                    this.FE2Selected.Checked = false;
                }
                if (Authority == 2)
                {
                    this.AfterSaleSelected.Checked = false;
                    this.EngineeringSelected.Checked = true;
                    this.FE2Selected.Checked = false;
                }
                if (Authority == 3)
                {
                    this.AfterSaleSelected.Checked = false;
                    this.EngineeringSelected.Checked = false;
                    this.FE2Selected.Checked = true;
                }
            }
        }
		
		private void UserExist_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["Frm_UserManagement"] != null)
			{
				this.Close();
			}
		}

        private void AfterSaleSelected_CheckedChanged(object sender, EventArgs e)
        {
            OPSelected_CheckedChanged( sender,  e);
        }

        private void FE2Selected_CheckedChanged(object sender, EventArgs e)
        {
            OPSelected_CheckedChanged(sender, e);
        }

        private void EngineeringSelected_CheckedChanged(object sender, EventArgs e)
        {
            OPSelected_CheckedChanged(sender, e);
        }
	
	}
}
