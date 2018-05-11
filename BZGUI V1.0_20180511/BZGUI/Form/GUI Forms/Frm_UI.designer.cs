
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
	partial class Frm_UI : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.List_Sts = new System.Windows.Forms.ListBox();
			this.Btn_Confirm = new System.Windows.Forms.Button();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.Txt_UIPassword = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Btn_Cancel
			//
			this.Btn_Cancel.Location = new System.Drawing.Point(206, 209);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(110, 41);
			this.Btn_Cancel.TabIndex = 0;
			this.Btn_Cancel.Text = "取消(Cancel)";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			//
			//List_Sts
			//
			this.List_Sts.FormattingEnabled = true;
			this.List_Sts.ItemHeight = 12;
			this.List_Sts.Location = new System.Drawing.Point(12, 12);
			this.List_Sts.Name = "List_Sts";
			this.List_Sts.Size = new System.Drawing.Size(560, 184);
			this.List_Sts.TabIndex = 1;
			//
			//Btn_Confirm
			//
			this.Btn_Confirm.Location = new System.Drawing.Point(12, 209);
			this.Btn_Confirm.Name = "Btn_Confirm";
			this.Btn_Confirm.Size = new System.Drawing.Size(110, 41);
			this.Btn_Confirm.TabIndex = 2;
			this.Btn_Confirm.Text = "确定(Confirm)";
			this.Btn_Confirm.UseVisualStyleBackColor = true;
			//
			//Timer
			//
			this.Timer.Enabled = true;
			//
			//Txt_UIPassword
			//
			this.Txt_UIPassword.Font = new System.Drawing.Font("宋体", (float) (15.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Txt_UIPassword.Location = new System.Drawing.Point(375, 220);
			this.Txt_UIPassword.Name = "Txt_UIPassword";
			this.Txt_UIPassword.Size = new System.Drawing.Size(197, 30);
			this.Txt_UIPassword.TabIndex = 3;
			this.Txt_UIPassword.Visible = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(360, 199);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(215, 12);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "取消时，请输入PDCACancel_ID解锁密码";
			this.Label1.Visible = false;
			//
			//Frm_UI
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 262);
			this.ControlBox = false;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Txt_UIPassword);
			this.Controls.Add(this.Btn_Confirm);
			this.Controls.Add(this.List_Sts);
			this.Controls.Add(this.Btn_Cancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_UI";
			this.Text = "UI";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button Btn_Cancel;
		internal System.Windows.Forms.ListBox List_Sts;
		internal System.Windows.Forms.Button Btn_Confirm;
		internal System.Windows.Forms.Timer Timer;
		internal System.Windows.Forms.TextBox Txt_UIPassword;
		internal System.Windows.Forms.Label Label1;
	}
	
}
