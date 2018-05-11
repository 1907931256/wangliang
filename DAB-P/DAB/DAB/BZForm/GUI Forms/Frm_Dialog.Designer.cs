
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
	partial class Frm_Dialog : System.Windows.Forms.Form
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
            this.List_Message = new System.Windows.Forms.ListBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Message
            // 
            this.List_Message.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Message.FormattingEnabled = true;
            this.List_Message.ItemHeight = 16;
            this.List_Message.Location = new System.Drawing.Point(6, 14);
            this.List_Message.Name = "List_Message";
            this.List_Message.Size = new System.Drawing.Size(383, 116);
            this.List_Message.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(126, 138);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(149, 51);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "确  定";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Frm_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 199);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.List_Message);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 237);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 237);
            this.Name = "Frm_Dialog";
            this.Text = "信息提示";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Dialog_Load);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.ListBox List_Message;
        internal System.Windows.Forms.Button Button1;
	}
	
}
