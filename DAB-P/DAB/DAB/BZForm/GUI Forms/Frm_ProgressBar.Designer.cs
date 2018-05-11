
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

namespace DAB
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_ProgressBar : System.Windows.Forms.Form
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
			this.InitProgressBar = new System.Windows.Forms.ProgressBar();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//InitProgressBar
			//
			this.InitProgressBar.Location = new System.Drawing.Point(20, 55);
			this.InitProgressBar.Name = "InitProgressBar";
			this.InitProgressBar.Size = new System.Drawing.Size(434, 28);
			this.InitProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.InitProgressBar.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (24.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(94, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(281, 37);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "设备正在初始化中";
			//
			//Frm_ProgressBar
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ClientSize = new System.Drawing.Size(477, 97);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.InitProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frm_ProgressBar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frm_ProgressBar";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.ProgressBar InitProgressBar;
		internal System.Windows.Forms.Label Label1;
	}
	
}
