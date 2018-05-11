using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;


namespace BZGUI
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class OutputClass : System.Windows.Forms.UserControl
	{
		
		//UserControl 重写 Dispose，以清理组件列表。
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
            this.Output_0 = new System.Windows.Forms.Button();
            this.Output_1 = new System.Windows.Forms.Button();
            this.Output_2 = new System.Windows.Forms.Button();
            this.Output_3 = new System.Windows.Forms.Button();
            this.Output_4 = new System.Windows.Forms.Button();
            this.Output_5 = new System.Windows.Forms.Button();
            this.Output_6 = new System.Windows.Forms.Button();
            this.Output_7 = new System.Windows.Forms.Button();
            this.Output_8 = new System.Windows.Forms.Button();
            this.Output_9 = new System.Windows.Forms.Button();
            this.Output_10 = new System.Windows.Forms.Button();
            this.Output_11 = new System.Windows.Forms.Button();
            this.Output_12 = new System.Windows.Forms.Button();
            this.Output_13 = new System.Windows.Forms.Button();
            this.Output_14 = new System.Windows.Forms.Button();
            this.Output_15 = new System.Windows.Forms.Button();
            this.Name_Index_15 = new System.Windows.Forms.Label();
            this.Name_Index_14 = new System.Windows.Forms.Label();
            this.Lab_Output_0 = new System.Windows.Forms.Label();
            this.Lab_Output_1 = new System.Windows.Forms.Label();
            this.Lab_Output_2 = new System.Windows.Forms.Label();
            this.Lab_Output_3 = new System.Windows.Forms.Label();
            this.Lab_Output_4 = new System.Windows.Forms.Label();
            this.Lab_Output_5 = new System.Windows.Forms.Label();
            this.Frame_Output = new System.Windows.Forms.GroupBox();
            this.Lab_Output_6 = new System.Windows.Forms.Label();
            this.Lab_Output_7 = new System.Windows.Forms.Label();
            this.Lab_Output_8 = new System.Windows.Forms.Label();
            this.Lab_Output_9 = new System.Windows.Forms.Label();
            this.Lab_Output_10 = new System.Windows.Forms.Label();
            this.Lab_Output_11 = new System.Windows.Forms.Label();
            this.Lab_Output_12 = new System.Windows.Forms.Label();
            this.Lab_Output_13 = new System.Windows.Forms.Label();
            this.Lab_Output_14 = new System.Windows.Forms.Label();
            this.Lab_Output_15 = new System.Windows.Forms.Label();
            this.Name_Index_0 = new System.Windows.Forms.Label();
            this.Name_Index_1 = new System.Windows.Forms.Label();
            this.Name_Index_2 = new System.Windows.Forms.Label();
            this.Name_Index_3 = new System.Windows.Forms.Label();
            this.Name_Index_4 = new System.Windows.Forms.Label();
            this.Name_Index_5 = new System.Windows.Forms.Label();
            this.Name_Index_6 = new System.Windows.Forms.Label();
            this.Name_Index_7 = new System.Windows.Forms.Label();
            this.Name_Index_8 = new System.Windows.Forms.Label();
            this.Name_Index_9 = new System.Windows.Forms.Label();
            this.Name_Index_10 = new System.Windows.Forms.Label();
            this.Name_Index_11 = new System.Windows.Forms.Label();
            this.Name_Index_12 = new System.Windows.Forms.Label();
            this.Name_Index_13 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.OvalShape_15 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_14 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_13 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_12 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_11 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_10 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_9 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_8 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_0 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Frame_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output_0
            // 
            this.Output_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_0.Location = new System.Drawing.Point(273, 22);
            this.Output_0.Name = "Output_0";
            this.Output_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_0.Size = new System.Drawing.Size(41, 20);
            this.Output_0.TabIndex = 0;
            this.Output_0.Tag = "0";
            this.Output_0.Text = "ON";
            this.Output_0.UseVisualStyleBackColor = false;
            this.Output_0.Click += new System.EventHandler(this.Output_0_Click);
            // 
            // Output_1
            // 
            this.Output_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_1.Location = new System.Drawing.Point(273, 54);
            this.Output_1.Name = "Output_1";
            this.Output_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_1.Size = new System.Drawing.Size(41, 20);
            this.Output_1.TabIndex = 1;
            this.Output_1.Tag = "1";
            this.Output_1.Text = "ON";
            this.Output_1.UseVisualStyleBackColor = false;
            this.Output_1.Click += new System.EventHandler(this.Output_1_Click);
            // 
            // Output_2
            // 
            this.Output_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_2.Location = new System.Drawing.Point(273, 86);
            this.Output_2.Name = "Output_2";
            this.Output_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_2.Size = new System.Drawing.Size(41, 20);
            this.Output_2.TabIndex = 2;
            this.Output_2.Tag = "2";
            this.Output_2.Text = "ON";
            this.Output_2.UseVisualStyleBackColor = false;
            this.Output_2.Click += new System.EventHandler(this.Output_2_Click);
            // 
            // Output_3
            // 
            this.Output_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_3.Location = new System.Drawing.Point(273, 118);
            this.Output_3.Name = "Output_3";
            this.Output_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_3.Size = new System.Drawing.Size(41, 20);
            this.Output_3.TabIndex = 3;
            this.Output_3.Tag = "3";
            this.Output_3.Text = "ON";
            this.Output_3.UseVisualStyleBackColor = false;
            this.Output_3.Click += new System.EventHandler(this.Output_3_Click);
            // 
            // Output_4
            // 
            this.Output_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_4.Location = new System.Drawing.Point(273, 150);
            this.Output_4.Name = "Output_4";
            this.Output_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_4.Size = new System.Drawing.Size(41, 20);
            this.Output_4.TabIndex = 4;
            this.Output_4.Tag = "4";
            this.Output_4.Text = "ON";
            this.Output_4.UseVisualStyleBackColor = false;
            this.Output_4.Click += new System.EventHandler(this.Output_4_Click);
            // 
            // Output_5
            // 
            this.Output_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_5.Location = new System.Drawing.Point(273, 182);
            this.Output_5.Name = "Output_5";
            this.Output_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_5.Size = new System.Drawing.Size(41, 20);
            this.Output_5.TabIndex = 5;
            this.Output_5.Tag = "5";
            this.Output_5.Text = "ON";
            this.Output_5.UseVisualStyleBackColor = false;
            this.Output_5.Click += new System.EventHandler(this.Output_5_Click);
            // 
            // Output_6
            // 
            this.Output_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_6.Location = new System.Drawing.Point(273, 214);
            this.Output_6.Name = "Output_6";
            this.Output_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_6.Size = new System.Drawing.Size(41, 20);
            this.Output_6.TabIndex = 6;
            this.Output_6.Tag = "6";
            this.Output_6.Text = "ON";
            this.Output_6.UseVisualStyleBackColor = false;
            this.Output_6.Click += new System.EventHandler(this.Output_6_Click);
            // 
            // Output_7
            // 
            this.Output_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_7.Location = new System.Drawing.Point(273, 246);
            this.Output_7.Name = "Output_7";
            this.Output_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_7.Size = new System.Drawing.Size(41, 20);
            this.Output_7.TabIndex = 7;
            this.Output_7.Tag = "7";
            this.Output_7.Text = "ON";
            this.Output_7.UseVisualStyleBackColor = false;
            this.Output_7.Click += new System.EventHandler(this.Output_7_Click);
            // 
            // Output_8
            // 
            this.Output_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_8.Location = new System.Drawing.Point(273, 278);
            this.Output_8.Name = "Output_8";
            this.Output_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_8.Size = new System.Drawing.Size(41, 20);
            this.Output_8.TabIndex = 8;
            this.Output_8.Tag = "8";
            this.Output_8.Text = "ON";
            this.Output_8.UseVisualStyleBackColor = false;
            this.Output_8.Click += new System.EventHandler(this.Output_8_Click);
            // 
            // Output_9
            // 
            this.Output_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_9.Location = new System.Drawing.Point(273, 310);
            this.Output_9.Name = "Output_9";
            this.Output_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_9.Size = new System.Drawing.Size(41, 20);
            this.Output_9.TabIndex = 9;
            this.Output_9.Tag = "9";
            this.Output_9.Text = "ON";
            this.Output_9.UseVisualStyleBackColor = false;
            this.Output_9.Click += new System.EventHandler(this.Output_9_Click);
            // 
            // Output_10
            // 
            this.Output_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_10.Location = new System.Drawing.Point(273, 342);
            this.Output_10.Name = "Output_10";
            this.Output_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_10.Size = new System.Drawing.Size(41, 20);
            this.Output_10.TabIndex = 10;
            this.Output_10.Tag = "10";
            this.Output_10.Text = "ON";
            this.Output_10.UseVisualStyleBackColor = false;
            this.Output_10.Click += new System.EventHandler(this.Output_10_Click);
            // 
            // Output_11
            // 
            this.Output_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_11.Location = new System.Drawing.Point(273, 374);
            this.Output_11.Name = "Output_11";
            this.Output_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_11.Size = new System.Drawing.Size(41, 20);
            this.Output_11.TabIndex = 11;
            this.Output_11.Tag = "11";
            this.Output_11.Text = "ON";
            this.Output_11.UseVisualStyleBackColor = false;
            this.Output_11.Click += new System.EventHandler(this.Output_11_Click);
            // 
            // Output_12
            // 
            this.Output_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_12.Location = new System.Drawing.Point(273, 406);
            this.Output_12.Name = "Output_12";
            this.Output_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_12.Size = new System.Drawing.Size(41, 20);
            this.Output_12.TabIndex = 12;
            this.Output_12.Tag = "12";
            this.Output_12.Text = "ON";
            this.Output_12.UseVisualStyleBackColor = false;
            this.Output_12.Click += new System.EventHandler(this.Output_12_Click);
            // 
            // Output_13
            // 
            this.Output_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_13.Location = new System.Drawing.Point(273, 438);
            this.Output_13.Name = "Output_13";
            this.Output_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_13.Size = new System.Drawing.Size(41, 20);
            this.Output_13.TabIndex = 13;
            this.Output_13.Tag = "13";
            this.Output_13.Text = "ON";
            this.Output_13.UseVisualStyleBackColor = false;
            this.Output_13.Click += new System.EventHandler(this.Output_13_Click);
            // 
            // Output_14
            // 
            this.Output_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_14.Location = new System.Drawing.Point(273, 470);
            this.Output_14.Name = "Output_14";
            this.Output_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_14.Size = new System.Drawing.Size(41, 20);
            this.Output_14.TabIndex = 14;
            this.Output_14.Tag = "14";
            this.Output_14.Text = "ON";
            this.Output_14.UseVisualStyleBackColor = false;
            this.Output_14.Click += new System.EventHandler(this.Output_14_Click);
            // 
            // Output_15
            // 
            this.Output_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Output_15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output_15.Location = new System.Drawing.Point(273, 502);
            this.Output_15.Name = "Output_15";
            this.Output_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Output_15.Size = new System.Drawing.Size(41, 20);
            this.Output_15.TabIndex = 15;
            this.Output_15.Tag = "15";
            this.Output_15.Text = "ON";
            this.Output_15.UseVisualStyleBackColor = false;
            this.Output_15.Click += new System.EventHandler(this.Output_15_Click);
            // 
            // Name_Index_15
            // 
            this.Name_Index_15.AutoSize = true;
            this.Name_Index_15.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_15.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_15.Location = new System.Drawing.Point(8, 504);
            this.Name_Index_15.Name = "Name_Index_15";
            this.Name_Index_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_15.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_15.TabIndex = 75;
            this.Name_Index_15.Text = "DO-15";
            // 
            // Name_Index_14
            // 
            this.Name_Index_14.AutoSize = true;
            this.Name_Index_14.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_14.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_14.Location = new System.Drawing.Point(8, 472);
            this.Name_Index_14.Name = "Name_Index_14";
            this.Name_Index_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_14.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_14.TabIndex = 74;
            this.Name_Index_14.Text = "DO-14";
            // 
            // Lab_Output_0
            // 
            this.Lab_Output_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_0.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_0.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_0.Location = new System.Drawing.Point(72, 24);
            this.Lab_Output_0.Name = "Lab_Output_0";
            this.Lab_Output_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_0.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_0.TabIndex = 73;
            this.Lab_Output_0.Text = "备用";
            // 
            // Lab_Output_1
            // 
            this.Lab_Output_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_1.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_1.Location = new System.Drawing.Point(72, 56);
            this.Lab_Output_1.Name = "Lab_Output_1";
            this.Lab_Output_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_1.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_1.TabIndex = 72;
            this.Lab_Output_1.Text = "备用";
            // 
            // Lab_Output_2
            // 
            this.Lab_Output_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_2.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_2.Location = new System.Drawing.Point(72, 88);
            this.Lab_Output_2.Name = "Lab_Output_2";
            this.Lab_Output_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_2.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_2.TabIndex = 71;
            this.Lab_Output_2.Text = "备用";
            // 
            // Lab_Output_3
            // 
            this.Lab_Output_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_3.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_3.Location = new System.Drawing.Point(72, 120);
            this.Lab_Output_3.Name = "Lab_Output_3";
            this.Lab_Output_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_3.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_3.TabIndex = 70;
            this.Lab_Output_3.Text = "备用";
            // 
            // Lab_Output_4
            // 
            this.Lab_Output_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_4.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_4.Location = new System.Drawing.Point(72, 152);
            this.Lab_Output_4.Name = "Lab_Output_4";
            this.Lab_Output_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_4.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_4.TabIndex = 69;
            this.Lab_Output_4.Text = "备用";
            // 
            // Lab_Output_5
            // 
            this.Lab_Output_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_5.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_5.Location = new System.Drawing.Point(72, 184);
            this.Lab_Output_5.Name = "Lab_Output_5";
            this.Lab_Output_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_5.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_5.TabIndex = 68;
            this.Lab_Output_5.Text = "备用";
            // 
            // Frame_Output
            // 
            this.Frame_Output.BackColor = System.Drawing.Color.White;
            this.Frame_Output.Controls.Add(this.Output_0);
            this.Frame_Output.Controls.Add(this.Output_1);
            this.Frame_Output.Controls.Add(this.Output_2);
            this.Frame_Output.Controls.Add(this.Output_3);
            this.Frame_Output.Controls.Add(this.Output_4);
            this.Frame_Output.Controls.Add(this.Output_5);
            this.Frame_Output.Controls.Add(this.Output_6);
            this.Frame_Output.Controls.Add(this.Output_7);
            this.Frame_Output.Controls.Add(this.Output_8);
            this.Frame_Output.Controls.Add(this.Output_9);
            this.Frame_Output.Controls.Add(this.Output_10);
            this.Frame_Output.Controls.Add(this.Output_11);
            this.Frame_Output.Controls.Add(this.Output_12);
            this.Frame_Output.Controls.Add(this.Output_13);
            this.Frame_Output.Controls.Add(this.Output_14);
            this.Frame_Output.Controls.Add(this.Output_15);
            this.Frame_Output.Controls.Add(this.Name_Index_15);
            this.Frame_Output.Controls.Add(this.Name_Index_14);
            this.Frame_Output.Controls.Add(this.Lab_Output_0);
            this.Frame_Output.Controls.Add(this.Lab_Output_1);
            this.Frame_Output.Controls.Add(this.Lab_Output_2);
            this.Frame_Output.Controls.Add(this.Lab_Output_3);
            this.Frame_Output.Controls.Add(this.Lab_Output_4);
            this.Frame_Output.Controls.Add(this.Lab_Output_5);
            this.Frame_Output.Controls.Add(this.Lab_Output_6);
            this.Frame_Output.Controls.Add(this.Lab_Output_7);
            this.Frame_Output.Controls.Add(this.Lab_Output_8);
            this.Frame_Output.Controls.Add(this.Lab_Output_9);
            this.Frame_Output.Controls.Add(this.Lab_Output_10);
            this.Frame_Output.Controls.Add(this.Lab_Output_11);
            this.Frame_Output.Controls.Add(this.Lab_Output_12);
            this.Frame_Output.Controls.Add(this.Lab_Output_13);
            this.Frame_Output.Controls.Add(this.Lab_Output_14);
            this.Frame_Output.Controls.Add(this.Lab_Output_15);
            this.Frame_Output.Controls.Add(this.Name_Index_0);
            this.Frame_Output.Controls.Add(this.Name_Index_1);
            this.Frame_Output.Controls.Add(this.Name_Index_2);
            this.Frame_Output.Controls.Add(this.Name_Index_3);
            this.Frame_Output.Controls.Add(this.Name_Index_4);
            this.Frame_Output.Controls.Add(this.Name_Index_5);
            this.Frame_Output.Controls.Add(this.Name_Index_6);
            this.Frame_Output.Controls.Add(this.Name_Index_7);
            this.Frame_Output.Controls.Add(this.Name_Index_8);
            this.Frame_Output.Controls.Add(this.Name_Index_9);
            this.Frame_Output.Controls.Add(this.Name_Index_10);
            this.Frame_Output.Controls.Add(this.Name_Index_11);
            this.Frame_Output.Controls.Add(this.Name_Index_12);
            this.Frame_Output.Controls.Add(this.Name_Index_13);
            this.Frame_Output.Controls.Add(this.ShapeContainer1);
            this.Frame_Output.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Frame_Output.ForeColor = System.Drawing.Color.Blue;
            this.Frame_Output.Location = new System.Drawing.Point(2, 2);
            this.Frame_Output.Name = "Frame_Output";
            this.Frame_Output.Padding = new System.Windows.Forms.Padding(0);
            this.Frame_Output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame_Output.Size = new System.Drawing.Size(328, 534);
            this.Frame_Output.TabIndex = 46;
            this.Frame_Output.TabStop = false;
            this.Frame_Output.Text = "输出 DO 00-15";
            // 
            // Lab_Output_6
            // 
            this.Lab_Output_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_6.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_6.Location = new System.Drawing.Point(72, 216);
            this.Lab_Output_6.Name = "Lab_Output_6";
            this.Lab_Output_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_6.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_6.TabIndex = 67;
            this.Lab_Output_6.Text = "备用";
            // 
            // Lab_Output_7
            // 
            this.Lab_Output_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_7.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_7.Location = new System.Drawing.Point(72, 248);
            this.Lab_Output_7.Name = "Lab_Output_7";
            this.Lab_Output_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_7.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_7.TabIndex = 66;
            this.Lab_Output_7.Text = "备用";
            // 
            // Lab_Output_8
            // 
            this.Lab_Output_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_8.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_8.Location = new System.Drawing.Point(72, 280);
            this.Lab_Output_8.Name = "Lab_Output_8";
            this.Lab_Output_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_8.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_8.TabIndex = 65;
            this.Lab_Output_8.Text = "备用";
            // 
            // Lab_Output_9
            // 
            this.Lab_Output_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_9.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_9.Location = new System.Drawing.Point(72, 312);
            this.Lab_Output_9.Name = "Lab_Output_9";
            this.Lab_Output_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_9.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_9.TabIndex = 64;
            this.Lab_Output_9.Text = "备用";
            // 
            // Lab_Output_10
            // 
            this.Lab_Output_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_10.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_10.Location = new System.Drawing.Point(72, 344);
            this.Lab_Output_10.Name = "Lab_Output_10";
            this.Lab_Output_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_10.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_10.TabIndex = 63;
            this.Lab_Output_10.Text = "备用";
            // 
            // Lab_Output_11
            // 
            this.Lab_Output_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_11.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_11.Location = new System.Drawing.Point(72, 376);
            this.Lab_Output_11.Name = "Lab_Output_11";
            this.Lab_Output_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_11.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_11.TabIndex = 62;
            this.Lab_Output_11.Text = "备用";
            // 
            // Lab_Output_12
            // 
            this.Lab_Output_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_12.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_12.Location = new System.Drawing.Point(72, 408);
            this.Lab_Output_12.Name = "Lab_Output_12";
            this.Lab_Output_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_12.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_12.TabIndex = 61;
            this.Lab_Output_12.Text = "备用";
            // 
            // Lab_Output_13
            // 
            this.Lab_Output_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_13.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_13.Location = new System.Drawing.Point(72, 440);
            this.Lab_Output_13.Name = "Lab_Output_13";
            this.Lab_Output_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_13.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_13.TabIndex = 60;
            this.Lab_Output_13.Text = "备用";
            // 
            // Lab_Output_14
            // 
            this.Lab_Output_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_14.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_14.Location = new System.Drawing.Point(72, 472);
            this.Lab_Output_14.Name = "Lab_Output_14";
            this.Lab_Output_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_14.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_14.TabIndex = 59;
            this.Lab_Output_14.Text = "备用";
            // 
            // Lab_Output_15
            // 
            this.Lab_Output_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Output_15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Output_15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Output_15.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Output_15.Location = new System.Drawing.Point(72, 504);
            this.Lab_Output_15.Name = "Lab_Output_15";
            this.Lab_Output_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Output_15.Size = new System.Drawing.Size(195, 17);
            this.Lab_Output_15.TabIndex = 58;
            this.Lab_Output_15.Text = "备用";
            // 
            // Name_Index_0
            // 
            this.Name_Index_0.AutoSize = true;
            this.Name_Index_0.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_0.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_0.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_0.Location = new System.Drawing.Point(8, 24);
            this.Name_Index_0.Name = "Name_Index_0";
            this.Name_Index_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_0.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_0.TabIndex = 57;
            this.Name_Index_0.Text = "DO-00";
            // 
            // Name_Index_1
            // 
            this.Name_Index_1.AutoSize = true;
            this.Name_Index_1.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_1.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_1.Location = new System.Drawing.Point(8, 56);
            this.Name_Index_1.Name = "Name_Index_1";
            this.Name_Index_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_1.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_1.TabIndex = 56;
            this.Name_Index_1.Text = "DO-01";
            // 
            // Name_Index_2
            // 
            this.Name_Index_2.AutoSize = true;
            this.Name_Index_2.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_2.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_2.Location = new System.Drawing.Point(8, 88);
            this.Name_Index_2.Name = "Name_Index_2";
            this.Name_Index_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_2.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_2.TabIndex = 55;
            this.Name_Index_2.Text = "DO-02";
            // 
            // Name_Index_3
            // 
            this.Name_Index_3.AutoSize = true;
            this.Name_Index_3.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_3.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_3.Location = new System.Drawing.Point(8, 120);
            this.Name_Index_3.Name = "Name_Index_3";
            this.Name_Index_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_3.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_3.TabIndex = 54;
            this.Name_Index_3.Text = "DO-03";
            // 
            // Name_Index_4
            // 
            this.Name_Index_4.AutoSize = true;
            this.Name_Index_4.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_4.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_4.Location = new System.Drawing.Point(8, 152);
            this.Name_Index_4.Name = "Name_Index_4";
            this.Name_Index_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_4.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_4.TabIndex = 53;
            this.Name_Index_4.Text = "DO-04";
            // 
            // Name_Index_5
            // 
            this.Name_Index_5.AutoSize = true;
            this.Name_Index_5.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_5.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_5.Location = new System.Drawing.Point(8, 184);
            this.Name_Index_5.Name = "Name_Index_5";
            this.Name_Index_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_5.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_5.TabIndex = 52;
            this.Name_Index_5.Text = "DO-05";
            // 
            // Name_Index_6
            // 
            this.Name_Index_6.AutoSize = true;
            this.Name_Index_6.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_6.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_6.Location = new System.Drawing.Point(8, 216);
            this.Name_Index_6.Name = "Name_Index_6";
            this.Name_Index_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_6.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_6.TabIndex = 51;
            this.Name_Index_6.Text = "DO-06";
            // 
            // Name_Index_7
            // 
            this.Name_Index_7.AutoSize = true;
            this.Name_Index_7.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_7.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_7.Location = new System.Drawing.Point(8, 248);
            this.Name_Index_7.Name = "Name_Index_7";
            this.Name_Index_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_7.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_7.TabIndex = 50;
            this.Name_Index_7.Text = "DO-07";
            // 
            // Name_Index_8
            // 
            this.Name_Index_8.AutoSize = true;
            this.Name_Index_8.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_8.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_8.Location = new System.Drawing.Point(8, 280);
            this.Name_Index_8.Name = "Name_Index_8";
            this.Name_Index_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_8.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_8.TabIndex = 49;
            this.Name_Index_8.Text = "DO-08";
            // 
            // Name_Index_9
            // 
            this.Name_Index_9.AutoSize = true;
            this.Name_Index_9.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_9.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_9.Location = new System.Drawing.Point(8, 312);
            this.Name_Index_9.Name = "Name_Index_9";
            this.Name_Index_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_9.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_9.TabIndex = 48;
            this.Name_Index_9.Text = "DO-09";
            // 
            // Name_Index_10
            // 
            this.Name_Index_10.AutoSize = true;
            this.Name_Index_10.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_10.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_10.Location = new System.Drawing.Point(8, 344);
            this.Name_Index_10.Name = "Name_Index_10";
            this.Name_Index_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_10.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_10.TabIndex = 47;
            this.Name_Index_10.Text = "DO-10";
            // 
            // Name_Index_11
            // 
            this.Name_Index_11.AutoSize = true;
            this.Name_Index_11.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_11.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_11.Location = new System.Drawing.Point(8, 376);
            this.Name_Index_11.Name = "Name_Index_11";
            this.Name_Index_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_11.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_11.TabIndex = 46;
            this.Name_Index_11.Text = "DO-11";
            // 
            // Name_Index_12
            // 
            this.Name_Index_12.AutoSize = true;
            this.Name_Index_12.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_12.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_12.Location = new System.Drawing.Point(8, 408);
            this.Name_Index_12.Name = "Name_Index_12";
            this.Name_Index_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_12.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_12.TabIndex = 45;
            this.Name_Index_12.Text = "DO-12";
            // 
            // Name_Index_13
            // 
            this.Name_Index_13.AutoSize = true;
            this.Name_Index_13.BackColor = System.Drawing.Color.Transparent;
            this.Name_Index_13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name_Index_13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name_Index_13.ForeColor = System.Drawing.Color.Blue;
            this.Name_Index_13.Location = new System.Drawing.Point(8, 440);
            this.Name_Index_13.Name = "Name_Index_13";
            this.Name_Index_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_Index_13.Size = new System.Drawing.Size(42, 14);
            this.Name_Index_13.TabIndex = 44;
            this.Name_Index_13.Text = "DO-13";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 16);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.OvalShape_15,
            this.OvalShape_14,
            this.OvalShape_13,
            this.OvalShape_12,
            this.OvalShape_11,
            this.OvalShape_10,
            this.OvalShape_9,
            this.OvalShape_8,
            this.OvalShape_7,
            this.OvalShape_6,
            this.OvalShape_5,
            this.OvalShape_4,
            this.OvalShape_3,
            this.OvalShape_2,
            this.OvalShape_1,
            this.OvalShape_0});
            this.ShapeContainer1.Size = new System.Drawing.Size(328, 518);
            this.ShapeContainer1.TabIndex = 76;
            this.ShapeContainer1.TabStop = false;
            // 
            // OvalShape_15
            // 
            this.OvalShape_15.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_15.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_15.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_15.Location = new System.Drawing.Point(50, 487);
            this.OvalShape_15.Name = "OvalShape_15";
            this.OvalShape_15.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_14
            // 
            this.OvalShape_14.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_14.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_14.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_14.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_14.Location = new System.Drawing.Point(50, 455);
            this.OvalShape_14.Name = "OvalShape_14";
            this.OvalShape_14.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_13
            // 
            this.OvalShape_13.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_13.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_13.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_13.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_13.Location = new System.Drawing.Point(50, 423);
            this.OvalShape_13.Name = "OvalShape_13";
            this.OvalShape_13.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_12
            // 
            this.OvalShape_12.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_12.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_12.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_12.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_12.Location = new System.Drawing.Point(50, 391);
            this.OvalShape_12.Name = "OvalShape_12";
            this.OvalShape_12.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_11
            // 
            this.OvalShape_11.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_11.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_11.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_11.Location = new System.Drawing.Point(50, 359);
            this.OvalShape_11.Name = "OvalShape_11";
            this.OvalShape_11.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_10
            // 
            this.OvalShape_10.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_10.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_10.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_10.Location = new System.Drawing.Point(50, 327);
            this.OvalShape_10.Name = "OvalShape_10";
            this.OvalShape_10.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_9
            // 
            this.OvalShape_9.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_9.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_9.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_9.Location = new System.Drawing.Point(50, 295);
            this.OvalShape_9.Name = "OvalShape_9";
            this.OvalShape_9.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_8
            // 
            this.OvalShape_8.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_8.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_8.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_8.Location = new System.Drawing.Point(50, 263);
            this.OvalShape_8.Name = "OvalShape_8";
            this.OvalShape_8.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_7
            // 
            this.OvalShape_7.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_7.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_7.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_7.Location = new System.Drawing.Point(50, 231);
            this.OvalShape_7.Name = "OvalShape_7";
            this.OvalShape_7.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_6
            // 
            this.OvalShape_6.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_6.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_6.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_6.Location = new System.Drawing.Point(50, 199);
            this.OvalShape_6.Name = "OvalShape_6";
            this.OvalShape_6.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_5
            // 
            this.OvalShape_5.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_5.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_5.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_5.Location = new System.Drawing.Point(50, 167);
            this.OvalShape_5.Name = "OvalShape_5";
            this.OvalShape_5.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_4
            // 
            this.OvalShape_4.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_4.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_4.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_4.Location = new System.Drawing.Point(50, 135);
            this.OvalShape_4.Name = "OvalShape_4";
            this.OvalShape_4.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_3
            // 
            this.OvalShape_3.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_3.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_3.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_3.Location = new System.Drawing.Point(50, 103);
            this.OvalShape_3.Name = "OvalShape_3";
            this.OvalShape_3.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_2
            // 
            this.OvalShape_2.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_2.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_2.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_2.Location = new System.Drawing.Point(50, 71);
            this.OvalShape_2.Name = "OvalShape_2";
            this.OvalShape_2.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_1
            // 
            this.OvalShape_1.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_1.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_1.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_1.Location = new System.Drawing.Point(50, 39);
            this.OvalShape_1.Name = "OvalShape_1";
            this.OvalShape_1.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape_0
            // 
            this.OvalShape_0.BorderColor = System.Drawing.Color.Black;
            this.OvalShape_0.FillColor = System.Drawing.Color.Lime;
            this.OvalShape_0.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape_0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape_0.Location = new System.Drawing.Point(50, 7);
            this.OvalShape_0.Name = "OvalShape_0";
            this.OvalShape_0.Size = new System.Drawing.Size(16, 16);
            // 
            // OutputClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Frame_Output);
            this.Name = "OutputClass";
            this.Size = new System.Drawing.Size(333, 538);
            this.Load += new System.EventHandler(this.OutputClass_Load);
            this.Frame_Output.ResumeLayout(false);
            this.Frame_Output.PerformLayout();
            this.ResumeLayout(false);

		}
		public System.Windows.Forms.Button Output_0;
		public System.Windows.Forms.Button Output_1;
		public System.Windows.Forms.Button Output_2;
		public System.Windows.Forms.Button Output_3;
		public System.Windows.Forms.Button Output_4;
		public System.Windows.Forms.Button Output_5;
		public System.Windows.Forms.Button Output_6;
		public System.Windows.Forms.Button Output_7;
		public System.Windows.Forms.Button Output_8;
		public System.Windows.Forms.Button Output_9;
		public System.Windows.Forms.Button Output_10;
		public System.Windows.Forms.Button Output_11;
		public System.Windows.Forms.Button Output_12;
		public System.Windows.Forms.Button Output_13;
		public System.Windows.Forms.Button Output_14;
		public System.Windows.Forms.Button Output_15;
		public System.Windows.Forms.Label Name_Index_15;
		public System.Windows.Forms.Label Name_Index_14;
		public System.Windows.Forms.Label Lab_Output_0;
		public System.Windows.Forms.Label Lab_Output_1;
		public System.Windows.Forms.Label Lab_Output_2;
		public System.Windows.Forms.Label Lab_Output_3;
		public System.Windows.Forms.Label Lab_Output_4;
		public System.Windows.Forms.Label Lab_Output_5;
		public System.Windows.Forms.GroupBox Frame_Output;
		public System.Windows.Forms.Label Lab_Output_6;
		public System.Windows.Forms.Label Lab_Output_7;
		public System.Windows.Forms.Label Lab_Output_8;
		public System.Windows.Forms.Label Lab_Output_9;
		public System.Windows.Forms.Label Lab_Output_10;
		public System.Windows.Forms.Label Lab_Output_11;
		public System.Windows.Forms.Label Lab_Output_12;
		public System.Windows.Forms.Label Lab_Output_13;
		public System.Windows.Forms.Label Lab_Output_14;
		public System.Windows.Forms.Label Lab_Output_15;
		public System.Windows.Forms.Label Name_Index_0;
		public System.Windows.Forms.Label Name_Index_1;
		public System.Windows.Forms.Label Name_Index_2;
		public System.Windows.Forms.Label Name_Index_3;
		public System.Windows.Forms.Label Name_Index_4;
		public System.Windows.Forms.Label Name_Index_5;
		public System.Windows.Forms.Label Name_Index_6;
		public System.Windows.Forms.Label Name_Index_7;
		public System.Windows.Forms.Label Name_Index_8;
		public System.Windows.Forms.Label Name_Index_9;
		public System.Windows.Forms.Label Name_Index_10;
		public System.Windows.Forms.Label Name_Index_11;
		public System.Windows.Forms.Label Name_Index_12;
		public System.Windows.Forms.Label Name_Index_13;
		internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_15;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_14;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_13;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_12;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_11;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_10;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_9;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_8;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_7;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_6;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_5;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_4;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_3;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_2;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_1;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_0;
        internal System.Timers.Timer Timer = new System.Timers.Timer() { AutoReset = true, Interval = 200, Enabled = false };   
	}
	
}
