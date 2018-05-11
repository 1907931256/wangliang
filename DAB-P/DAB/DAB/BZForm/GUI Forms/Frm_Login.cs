using System.Drawing;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DAB
{
	public partial class Frm_Login
	{
        public static Frm_Login fLogin = null;
        public Frm_Login()
            {
            InitializeComponent();
            fLogin = this; 
            }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
            {
            PVar.IsOpenFrmLogin = false;
            }

        private void Frm_Login_Load(object sender, EventArgs e)
            {
            PVar.IsOpenFrmLogin = true;
            this.Location = new Point(PVar.ChildFrmOffsetPoint.X + 200, PVar.ChildFrmOffsetPoint.Y + 100);
            this.Size = new Size(600, 235);
            this.TopMost = true;
            this.Opacity = 0.85;
            MainUserNameDisplay();
            }

        private void MainUserNameDisplay()
            {
            FileRw.ReadDatFilePassWord(PVar.BZ_ParameterPath + "PassWord.dat", PVar.Login);
            
            for (var i = 0; i <= 20; i++)
                {
                if (PVar.Login.NewUser[(int)i] != "OP" && PVar.Login.NewUser[(int)i] != "Administrator")
                    {
                    if (PVar.Login.NewUser[(int)i] != "" && PVar.Login.NewUser[(int)i] != null)
                        {
                        MainUserName.Items.Add(PVar.Login.NewUser[(int)i]);
                        }
                    }
                }
            Frm_Login.fLogin.MainUserName.Items.Add("Administrator");
            MainUserName.SelectedIndex = 0;
            MainPassword.Focus();
            //Call Start_NumberKey_Process()
            //MainPassword.SelectionStart = 0     '选取的起始位置设为0，即从头开始进行文本框内容的选取
            //MainPassword.SelectionLength = Len(MainPassword.Text)       '选取内容的长度为文本框已经接受的文本长度
            }


        private void Btn_Cancel_Click(object sender, EventArgs e)
            {
            Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 0;
            FunctionSub.Close_NumberKey_Process();
            this.Close();
            }

        private void CB_PasswordChanges_CheckedChanged(object sender, EventArgs e)
            {
            if (CB_PasswordChanges.Checked)
                {
                this.Lb_NPassword1.Enabled = true;
                this.Lb_NPassword2.Enabled = true;
                this.TB_NPassword1.Enabled = true;
                this.TB_NPassword2.Enabled = true;
                this.Btn_Change.Enabled = true;

                this.Size = new Size(600, 408);
                this.Opacity = 0.85;
                this.ResizeRedraw = true;
                }
            else
                {
                this.Lb_NPassword1.Enabled = false;
                this.Lb_NPassword2.Enabled = false;
                this.TB_NPassword1.Enabled = false;
                this.TB_NPassword2.Enabled = false;
                this.Btn_Change.Enabled = false;
                this.Size = new Size(600, 235);
                this.Opacity = 0.85;
                this.ResizeRedraw = true;
                }
            }

        private void Btn_Change_MouseDown(object sender, EventArgs e)
            {
            CB_PasswordChanges.Checked = false;
            }

        private void Btn_Login_Click(object sender, EventArgs e)
            {
            Frm_Main.fMain.UserLogin();
            switch (Frm_Engineering.fEngineering.TabControl1.SelectedIndex)
                {
                case 2:
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 2;
                    if (PVar.LoginOutputEnable)
                        {
                        Frm_Engineering.fEngineering.TabControl3.Enabled = true;
                        Frm_Engineering.fEngineering.OutputClass1.Timer.Enabled = true;
                        Frm_Engineering.fEngineering.OutputClass2.Timer.Enabled = true;
                        Frm_Engineering.fEngineering.OutputClass3.Timer.Enabled = true;
                        Frm_Engineering.fEngineering.OutputClass4.Timer.Enabled = true;
                        }
                    else
                        {
                        Frm_Engineering.fEngineering.TabControl3.Enabled = false;
                        }
                    break;
                case 3:
                    Frm_Engineering.fEngineering.TabControl1.SelectedIndex = 3;
                    if (PVar.LoginManualEnable)
                        {
                        Frm_Engineering.fEngineering.TabControl4.Enabled = true;
                        Frm_Engineering.fEngineering.Teach1.Timer.Enabled = true;
                        Frm_Engineering.fEngineering.Teach2.Timer.Enabled = true;
                        Frm_Engineering.fEngineering.Teach3.Timer.Enabled = true;
                        Frm_Engineering.fEngineering.Teach4.Timer.Enabled = true;
                        PVar.IsOpenFrmManual = true;
                        }
                    else
                        {
                        Frm_Engineering.fEngineering.TabControl4.Enabled = false;
                        }
                    break;
                }

            if (PVar.LoginFrmParEnable)
                {
                Frm_Par.fPar.Btn_ParBackup.Enabled = true;
                Frm_Par.fPar.Btn_ParEnable.Enabled = true;
                Frm_Par.fPar.Btn_ParKeyboard.Enabled = true;
                Frm_Par.fPar.Btn_ParSave.Enabled = true;
                Frm_Par.fPar.TableLayoutPanel1.Enabled = true;
                Frm_Par.fPar.TableLayoutPanel3.Enabled = true;
                Frm_Par.fPar.TableLayoutPanel4.Enabled = true;
                }
            else
                {
                Frm_Par.fPar.Btn_ParBackup.Enabled = false;
                Frm_Par.fPar.Btn_ParKeyboard.Enabled = false;
                Frm_Par.fPar.Btn_ParSave.Enabled = false;
                Frm_Par.fPar.TableLayoutPanel1.Enabled = false;
                Frm_Par.fPar.TableLayoutPanel3.Enabled = false;
                Frm_Par.fPar.TableLayoutPanel4.Enabled = false;
                }

            if (PVar.LoginFrmParCCDEnable)
                {
                Frm_Par_CCD.fPar_CCD.Btn_ParBackup.Enabled = true;
                Frm_Par_CCD.fPar_CCD.Btn_ParEnable.Enabled = true;
                Frm_Par_CCD.fPar_CCD.Btn_ParKeyboard.Enabled = true;
                Frm_Par_CCD.fPar_CCD.Btn_ParSave.Enabled = true;
                Frm_Par_CCD.fPar_CCD.TableLayoutPanel1.Enabled = true;
                }
            else
                {
                Frm_Par_CCD.fPar_CCD.Btn_ParBackup.Enabled = false;
                Frm_Par_CCD.fPar_CCD.Btn_ParKeyboard.Enabled = false;
                Frm_Par_CCD.fPar_CCD.Btn_ParSave.Enabled = false;
                Frm_Par_CCD.fPar_CCD.TableLayoutPanel1.Enabled = false;
                }

            if (PVar.LoginOutputEnable || PVar.LoginManualEnable || PVar.LoginMachineParEnable || PVar.LoginFrmParEnable || PVar.LoginFrmParCCDEnable)
                {
                PVar.LoginFrmEngineeringEnable = false;
                PVar.LoginFrmParEnable = false;
                PVar.LoginFrmParCCDEnable = false;
                PVar.LoginOutputEnable = false;
                PVar.LoginManualEnable = false;
                PVar.LoginMachineParEnable = false;
                this.Close();
                }
            }

        private void Btn_UserManagement_Click(object sender, EventArgs e)
            {
            if (FileRw.IsNotShow("UserManagement"))
                {
                if (Frm_UserManagement.fUserManagement == null || Frm_UserManagement.fUserManagement.IsDisposed)
                    {
                    Frm_UserManagement.fUserManagement = new Frm_UserManagement();
                    }
                Frm_UserManagement.fUserManagement.Show(this);
                }
            }

        private void MainUserName_KeyPress(object sender, KeyPressEventArgs e)
            {
            e.Handled = true;
            }

        private void Label1_DoubleClick(object sender, EventArgs e)
            {
            MainUserName.Text = PVar.Login.NewUser[1];
            MainPassword.Text = PVar.Login.NewPassword[1];
            }

        private void MainPassword_DoubleClick(object sender, EventArgs e)
            {
            FunctionSub.Start_NumberKey_Process();
            }

        private void MainPassword_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == Convert.ToChar(Constants.vbCr))
                {
                Btn_Login_Click(sender, e);
                }
            }

	}
}
