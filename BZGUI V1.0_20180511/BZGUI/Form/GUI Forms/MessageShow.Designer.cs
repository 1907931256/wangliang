
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
	partial class MessageShow : System.Windows.Forms.Form
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
			this.Lab_Message = new System.Windows.Forms.Label();
			this.Btn_Confirm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Lab_Message
			//
			this.Lab_Message.Font = new System.Drawing.Font("宋体", (float) (24.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Lab_Message.Location = new System.Drawing.Point(-2, 64);
			this.Lab_Message.Name = "Lab_Message";
			this.Lab_Message.Size = new System.Drawing.Size(398, 47);
			this.Lab_Message.TabIndex = 0;
			this.Lab_Message.Text = "物料已用完,请换料！";
			this.Lab_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Btn_Confirm
			//
			this.Btn_Confirm.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Btn_Confirm.Location = new System.Drawing.Point(141, 160);
			this.Btn_Confirm.Name = "Btn_Confirm";
			this.Btn_Confirm.Size = new System.Drawing.Size(123, 43);
			this.Btn_Confirm.TabIndex = 1;
			this.Btn_Confirm.Text = "我知道啦！";
			this.Btn_Confirm.UseVisualStyleBackColor = true;
			//
			//MessageShow
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 241);
			this.Controls.Add(this.Btn_Confirm);
			this.Controls.Add(this.Lab_Message);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MessageShow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "提示信息";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Label Lab_Message;
		internal System.Windows.Forms.Button Btn_Confirm;
	}
	
}
