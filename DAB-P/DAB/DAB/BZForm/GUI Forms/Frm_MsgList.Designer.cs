
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

namespace DAB
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_MsgList : System.Windows.Forms.Form
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
			this.Label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Label1.Font = new System.Drawing.Font("宋体", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label1.Location = new System.Drawing.Point(1, 58);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(460, 66);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "信息提示";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.Color.Gainsboro;
			this.Button1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button1.Location = new System.Drawing.Point(183, 145);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(92, 38);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "确定";
			this.Button1.UseVisualStyleBackColor = false;
			//
			//Frm_MsgList
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(463, 213);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_MsgList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frm_MsgList";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
	}
	
}
