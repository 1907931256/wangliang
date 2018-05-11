
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

namespace BZGUI
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_UserManagement : System.Windows.Forms.Form
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.UserExist = new System.Windows.Forms.Button();
            this.UserDelete = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.FE2Selected = new System.Windows.Forms.CheckBox();
            this.AfterSaleSelected = new System.Windows.Forms.CheckBox();
            this.EngineeringSelected = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NewUserPasswordChecked = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NewUserPassword = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.NewUserName = new System.Windows.Forms.TextBox();
            this.PasswordConfirm = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.White;
            this.GroupBox3.Controls.Add(this.UserExist);
            this.GroupBox3.Controls.Add(this.UserDelete);
            this.GroupBox3.Controls.Add(this.GroupBox4);
            this.GroupBox3.Controls.Add(this.GroupBox2);
            this.GroupBox3.Controls.Add(this.GroupBox1);
            this.GroupBox3.Controls.Add(this.PasswordConfirm);
            this.GroupBox3.Location = new System.Drawing.Point(11, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(490, 361);
            this.GroupBox3.TabIndex = 15;
            this.GroupBox3.TabStop = false;
            // 
            // UserExist
            // 
            this.UserExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserExist.Location = new System.Drawing.Point(357, 308);
            this.UserExist.Name = "UserExist";
            this.UserExist.Size = new System.Drawing.Size(115, 38);
            this.UserExist.TabIndex = 21;
            this.UserExist.Text = "退 出";
            this.UserExist.UseVisualStyleBackColor = true;
            this.UserExist.Click += new System.EventHandler(this.UserExist_Click);
            // 
            // UserDelete
            // 
            this.UserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDelete.Location = new System.Drawing.Point(182, 308);
            this.UserDelete.Name = "UserDelete";
            this.UserDelete.Size = new System.Drawing.Size(115, 38);
            this.UserDelete.TabIndex = 20;
            this.UserDelete.Text = "删 除";
            this.UserDelete.UseVisualStyleBackColor = true;
            this.UserDelete.Click += new System.EventHandler(this.UserDelete_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.UserListBox);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(306, 16);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(175, 275);
            this.GroupBox4.TabIndex = 19;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "用户列表";
            // 
            // UserListBox
            // 
            this.UserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 15;
            this.UserListBox.Location = new System.Drawing.Point(7, 16);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(162, 244);
            this.UserListBox.TabIndex = 0;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.FE2Selected);
            this.GroupBox2.Controls.Add(this.AfterSaleSelected);
            this.GroupBox2.Controls.Add(this.EngineeringSelected);
            this.GroupBox2.Location = new System.Drawing.Point(6, 225);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(293, 66);
            this.GroupBox2.TabIndex = 18;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "用户权限";
            // 
            // FE2Selected
            // 
            this.FE2Selected.AutoSize = true;
            this.FE2Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FE2Selected.Location = new System.Drawing.Point(241, 31);
            this.FE2Selected.Name = "FE2Selected";
            this.FE2Selected.Size = new System.Drawing.Size(48, 19);
            this.FE2Selected.TabIndex = 3;
            this.FE2Selected.Text = "FE2";
            this.FE2Selected.UseVisualStyleBackColor = true;
            this.FE2Selected.CheckedChanged += new System.EventHandler(this.FE2Selected_CheckedChanged);
            // 
            // AfterSaleSelected
            // 
            this.AfterSaleSelected.AutoSize = true;
            this.AfterSaleSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterSaleSelected.Location = new System.Drawing.Point(17, 31);
            this.AfterSaleSelected.Name = "AfterSaleSelected";
            this.AfterSaleSelected.Size = new System.Drawing.Size(81, 19);
            this.AfterSaleSelected.TabIndex = 1;
            this.AfterSaleSelected.Text = "Post Sale ";
            this.AfterSaleSelected.UseVisualStyleBackColor = true;
            this.AfterSaleSelected.CheckedChanged += new System.EventHandler(this.AfterSaleSelected_CheckedChanged);
            // 
            // EngineeringSelected
            // 
            this.EngineeringSelected.AutoSize = true;
            this.EngineeringSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineeringSelected.Location = new System.Drawing.Point(126, 31);
            this.EngineeringSelected.Name = "EngineeringSelected";
            this.EngineeringSelected.Size = new System.Drawing.Size(93, 19);
            this.EngineeringSelected.TabIndex = 2;
            this.EngineeringSelected.Text = "Engineering";
            this.EngineeringSelected.UseVisualStyleBackColor = true;
            this.EngineeringSelected.CheckedChanged += new System.EventHandler(this.EngineeringSelected_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.NewUserPasswordChecked);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.NewUserPassword);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txt_password);
            this.GroupBox1.Controls.Add(this.NewUserName);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(7, 16);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(293, 203);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "用户信息";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(5, 156);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 15);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "新密码确认：";
            // 
            // NewUserPasswordChecked
            // 
            this.NewUserPasswordChecked.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewUserPasswordChecked.Location = new System.Drawing.Point(98, 151);
            this.NewUserPasswordChecked.Multiline = true;
            this.NewUserPasswordChecked.Name = "NewUserPasswordChecked";
            this.NewUserPasswordChecked.Size = new System.Drawing.Size(159, 27);
            this.NewUserPasswordChecked.TabIndex = 12;
            this.NewUserPasswordChecked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(29, 112);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 15);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "新密码：";
            // 
            // NewUserPassword
            // 
            this.NewUserPassword.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewUserPassword.Location = new System.Drawing.Point(98, 107);
            this.NewUserPassword.Multiline = true;
            this.NewUserPassword.Name = "NewUserPassword";
            this.NewUserPassword.Size = new System.Drawing.Size(159, 27);
            this.NewUserPassword.TabIndex = 10;
            this.NewUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(35, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 15);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "账 户：";
            // 
            // NewUserName
            // 
            this.NewUserName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewUserName.Location = new System.Drawing.Point(98, 23);
            this.NewUserName.Multiline = true;
            this.NewUserName.Name = "NewUserName";
            this.NewUserName.Size = new System.Drawing.Size(159, 27);
            this.NewUserName.TabIndex = 8;
            // 
            // PasswordConfirm
            // 
            this.PasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordConfirm.Location = new System.Drawing.Point(7, 308);
            this.PasswordConfirm.Name = "PasswordConfirm";
            this.PasswordConfirm.Size = new System.Drawing.Size(115, 38);
            this.PasswordConfirm.TabIndex = 15;
            this.PasswordConfirm.Text = "确  认";
            this.PasswordConfirm.UseVisualStyleBackColor = true;
            this.PasswordConfirm.Click += new System.EventHandler(this.PasswordConfirm_Click);
            // 
            // txt_password
            // 
            this.txt_password.Enabled = false;
            this.txt_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(98, 65);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(159, 25);
            this.txt_password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "密码：";
            // 
            // Frm_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 376);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_User";
            this.Load += new System.EventHandler(this.Frm_UserManagement_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Button UserExist;
		internal System.Windows.Forms.Button UserDelete;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.ListBox UserListBox;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.CheckBox FE2Selected;
		internal System.Windows.Forms.CheckBox AfterSaleSelected;
		internal System.Windows.Forms.CheckBox EngineeringSelected;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox NewUserPasswordChecked;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox NewUserPassword;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox NewUserName;
		internal System.Windows.Forms.Button PasswordConfirm;
        internal Label label4;
        internal TextBox txt_password;
	}
	
}
