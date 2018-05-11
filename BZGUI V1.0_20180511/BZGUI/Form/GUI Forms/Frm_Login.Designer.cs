
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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_Login : System.Windows.Forms.Form
	{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.CB_PasswordChanges = new System.Windows.Forms.CheckBox();
            this.Btn_Change = new System.Windows.Forms.Button();
            this.Lb_NPassword1 = new System.Windows.Forms.Label();
            this.Lb_NPassword2 = new System.Windows.Forms.Label();
            this.MainUserName = new System.Windows.Forms.ComboBox();
            this.TB_NPassword1 = new System.Windows.Forms.TextBox();
            this.TB_NPassword2 = new System.Windows.Forms.TextBox();
            this.MainPassword = new System.Windows.Forms.TextBox();
            this.Btn_UserManagement = new System.Windows.Forms.Button();
            this.AxScriptControl1 = new AxMSScriptControl.AxScriptControl();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AxScriptControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.ErrorImage")));
            this.PictureBox2.Location = new System.Drawing.Point(449, 43);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 80);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 17);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "User Name";
            this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 17);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Password";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(124, 174);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(89, 32);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(302, 174);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(89, 32);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // CB_PasswordChanges
            // 
            this.CB_PasswordChanges.AutoSize = true;
            this.CB_PasswordChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_PasswordChanges.Location = new System.Drawing.Point(432, 186);
            this.CB_PasswordChanges.Name = "CB_PasswordChanges";
            this.CB_PasswordChanges.Size = new System.Drawing.Size(164, 21);
            this.CB_PasswordChanges.TabIndex = 9;
            this.CB_PasswordChanges.Text = "Password Changes";
            this.CB_PasswordChanges.UseVisualStyleBackColor = true;
            this.CB_PasswordChanges.Visible = false;
            // 
            // Btn_Change
            // 
            this.Btn_Change.Enabled = false;
            this.Btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Change.Location = new System.Drawing.Point(213, 353);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(89, 32);
            this.Btn_Change.TabIndex = 12;
            this.Btn_Change.Text = "Change";
            this.Btn_Change.UseVisualStyleBackColor = true;
            // 
            // Lb_NPassword1
            // 
            this.Lb_NPassword1.AutoSize = true;
            this.Lb_NPassword1.Enabled = false;
            this.Lb_NPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NPassword1.Location = new System.Drawing.Point(33, 245);
            this.Lb_NPassword1.Name = "Lb_NPassword1";
            this.Lb_NPassword1.Size = new System.Drawing.Size(126, 17);
            this.Lb_NPassword1.TabIndex = 13;
            this.Lb_NPassword1.Text = "New Password 1";
            // 
            // Lb_NPassword2
            // 
            this.Lb_NPassword2.AutoSize = true;
            this.Lb_NPassword2.Enabled = false;
            this.Lb_NPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NPassword2.Location = new System.Drawing.Point(33, 310);
            this.Lb_NPassword2.Name = "Lb_NPassword2";
            this.Lb_NPassword2.Size = new System.Drawing.Size(126, 17);
            this.Lb_NPassword2.TabIndex = 14;
            this.Lb_NPassword2.Text = "New Password 2";
            // 
            // MainUserName
            // 
            this.MainUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainUserName.FormattingEnabled = true;
            this.MainUserName.Location = new System.Drawing.Point(168, 50);
            this.MainUserName.Name = "MainUserName";
            this.MainUserName.Size = new System.Drawing.Size(240, 33);
            this.MainUserName.TabIndex = 16;
            this.MainUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainUserName_KeyPress);
            // 
            // TB_NPassword1
            // 
            this.TB_NPassword1.Enabled = false;
            this.TB_NPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NPassword1.Location = new System.Drawing.Point(168, 245);
            this.TB_NPassword1.Name = "TB_NPassword1";
            this.TB_NPassword1.Size = new System.Drawing.Size(240, 31);
            this.TB_NPassword1.TabIndex = 17;
            // 
            // TB_NPassword2
            // 
            this.TB_NPassword2.Enabled = false;
            this.TB_NPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NPassword2.Location = new System.Drawing.Point(168, 300);
            this.TB_NPassword2.Name = "TB_NPassword2";
            this.TB_NPassword2.Size = new System.Drawing.Size(240, 31);
            this.TB_NPassword2.TabIndex = 18;
            // 
            // MainPassword
            // 
            this.MainPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPassword.Location = new System.Drawing.Point(168, 107);
            this.MainPassword.Name = "MainPassword";
            this.MainPassword.PasswordChar = '*';
            this.MainPassword.Size = new System.Drawing.Size(240, 31);
            this.MainPassword.TabIndex = 19;
            this.MainPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainPassword.DoubleClick += new System.EventHandler(this.MainPassword_DoubleClick);
            this.MainPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainPassword_KeyPress);
            // 
            // Btn_UserManagement
            // 
            this.Btn_UserManagement.Location = new System.Drawing.Point(478, 353);
            this.Btn_UserManagement.Name = "Btn_UserManagement";
            this.Btn_UserManagement.Size = new System.Drawing.Size(94, 32);
            this.Btn_UserManagement.TabIndex = 20;
            this.Btn_UserManagement.Text = "用户管理";
            this.Btn_UserManagement.UseVisualStyleBackColor = true;
            // 
            // AxScriptControl1
            // 
            this.AxScriptControl1.Enabled = true;
            this.AxScriptControl1.Location = new System.Drawing.Point(478, 63);
            this.AxScriptControl1.Name = "AxScriptControl1";
            this.AxScriptControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxScriptControl1.OcxState")));
            this.AxScriptControl1.Size = new System.Drawing.Size(38, 38);
            this.AxScriptControl1.TabIndex = 21;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 408);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Btn_UserManagement);
            this.Controls.Add(this.MainPassword);
            this.Controls.Add(this.TB_NPassword2);
            this.Controls.Add(this.TB_NPassword1);
            this.Controls.Add(this.MainUserName);
            this.Controls.Add(this.Lb_NPassword2);
            this.Controls.Add(this.Lb_NPassword1);
            this.Controls.Add(this.Btn_Change);
            this.Controls.Add(this.CB_PasswordChanges);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.AxScriptControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Login_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Login_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AxScriptControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Btn_Login;
		internal System.Windows.Forms.Button Btn_Cancel;
		internal System.Windows.Forms.CheckBox CB_PasswordChanges;
		internal System.Windows.Forms.Button Btn_Change;
		internal System.Windows.Forms.Label Lb_NPassword1;
		internal System.Windows.Forms.Label Lb_NPassword2;
		internal System.Windows.Forms.ComboBox MainUserName;
		internal System.Windows.Forms.TextBox TB_NPassword1;
		internal System.Windows.Forms.TextBox TB_NPassword2;
		internal System.Windows.Forms.TextBox MainPassword;
		internal System.Windows.Forms.Button Btn_UserManagement;
		internal AxMSScriptControl.AxScriptControl AxScriptControl1;
	}
	
}
