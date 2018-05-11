
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
	partial class InputClass : System.Windows.Forms.UserControl
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
            this.Name_Index_15 = new System.Windows.Forms.Label();
            this.Name_Index_14 = new System.Windows.Forms.Label();
            this.Lab_Input_00 = new System.Windows.Forms.Label();
            this.Lab_Input_01 = new System.Windows.Forms.Label();
            this.Lab_Input_02 = new System.Windows.Forms.Label();
            this.Lab_Input_03 = new System.Windows.Forms.Label();
            this.Lab_Input_04 = new System.Windows.Forms.Label();
            this.Lab_Input_05 = new System.Windows.Forms.Label();
            this.Lab_Input_06 = new System.Windows.Forms.Label();
            this.Lab_Input_07 = new System.Windows.Forms.Label();
            this.Lab_Input_08 = new System.Windows.Forms.Label();
            this.Lab_Input_09 = new System.Windows.Forms.Label();
            this.Lab_Input_10 = new System.Windows.Forms.Label();
            this.Lab_Input_11 = new System.Windows.Forms.Label();
            this.Lab_Input_12 = new System.Windows.Forms.Label();
            this.Lab_Input_13 = new System.Windows.Forms.Label();
            this.Frame_Input = new System.Windows.Forms.GroupBox();
            this.Lab_Input_14 = new System.Windows.Forms.Label();
            this.Lab_Input_15 = new System.Windows.Forms.Label();
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
            this.Frame_Input.SuspendLayout();
            this.SuspendLayout();
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
            this.Name_Index_15.Text = "DI-15";
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
            this.Name_Index_14.Text = "DI-14";
            // 
            // Lab_Input_00
            // 
            this.Lab_Input_00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_00.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_00.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_00.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_00.Location = new System.Drawing.Point(72, 23);
            this.Lab_Input_00.Name = "Lab_Input_00";
            this.Lab_Input_00.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_00.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_00.TabIndex = 73;
            this.Lab_Input_00.Text = "备用";
            // 
            // Lab_Input_01
            // 
            this.Lab_Input_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_01.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_01.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_01.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_01.Location = new System.Drawing.Point(72, 55);
            this.Lab_Input_01.Name = "Lab_Input_01";
            this.Lab_Input_01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_01.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_01.TabIndex = 72;
            this.Lab_Input_01.Text = "备用";
            // 
            // Lab_Input_02
            // 
            this.Lab_Input_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_02.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_02.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_02.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_02.Location = new System.Drawing.Point(72, 87);
            this.Lab_Input_02.Name = "Lab_Input_02";
            this.Lab_Input_02.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_02.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_02.TabIndex = 71;
            this.Lab_Input_02.Text = "备用";
            // 
            // Lab_Input_03
            // 
            this.Lab_Input_03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_03.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_03.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_03.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_03.Location = new System.Drawing.Point(72, 119);
            this.Lab_Input_03.Name = "Lab_Input_03";
            this.Lab_Input_03.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_03.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_03.TabIndex = 70;
            this.Lab_Input_03.Text = "备用";
            // 
            // Lab_Input_04
            // 
            this.Lab_Input_04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_04.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_04.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_04.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_04.Location = new System.Drawing.Point(72, 151);
            this.Lab_Input_04.Name = "Lab_Input_04";
            this.Lab_Input_04.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_04.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_04.TabIndex = 69;
            this.Lab_Input_04.Text = "备用";
            // 
            // Lab_Input_05
            // 
            this.Lab_Input_05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_05.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_05.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_05.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_05.Location = new System.Drawing.Point(72, 183);
            this.Lab_Input_05.Name = "Lab_Input_05";
            this.Lab_Input_05.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_05.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_05.TabIndex = 68;
            this.Lab_Input_05.Text = "备用\r\n";
            // 
            // Lab_Input_06
            // 
            this.Lab_Input_06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_06.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_06.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_06.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_06.Location = new System.Drawing.Point(72, 216);
            this.Lab_Input_06.Name = "Lab_Input_06";
            this.Lab_Input_06.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_06.Size = new System.Drawing.Size(224, 17);
            this.Lab_Input_06.TabIndex = 67;
            this.Lab_Input_06.Text = "备用";
            // 
            // Lab_Input_07
            // 
            this.Lab_Input_07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_07.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_07.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_07.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_07.Location = new System.Drawing.Point(72, 247);
            this.Lab_Input_07.Name = "Lab_Input_07";
            this.Lab_Input_07.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_07.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_07.TabIndex = 66;
            this.Lab_Input_07.Text = "备用";
            // 
            // Lab_Input_08
            // 
            this.Lab_Input_08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_08.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_08.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_08.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_08.Location = new System.Drawing.Point(72, 279);
            this.Lab_Input_08.Name = "Lab_Input_08";
            this.Lab_Input_08.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_08.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_08.TabIndex = 65;
            this.Lab_Input_08.Text = "备用";
            // 
            // Lab_Input_09
            // 
            this.Lab_Input_09.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_09.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_09.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_09.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_09.Location = new System.Drawing.Point(72, 311);
            this.Lab_Input_09.Name = "Lab_Input_09";
            this.Lab_Input_09.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_09.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_09.TabIndex = 64;
            this.Lab_Input_09.Text = "备用";
            // 
            // Lab_Input_10
            // 
            this.Lab_Input_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_10.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_10.Location = new System.Drawing.Point(72, 343);
            this.Lab_Input_10.Name = "Lab_Input_10";
            this.Lab_Input_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_10.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_10.TabIndex = 63;
            this.Lab_Input_10.Text = "备用";
            // 
            // Lab_Input_11
            // 
            this.Lab_Input_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_11.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_11.Location = new System.Drawing.Point(72, 375);
            this.Lab_Input_11.Name = "Lab_Input_11";
            this.Lab_Input_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_11.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_11.TabIndex = 62;
            this.Lab_Input_11.Text = "备用";
            // 
            // Lab_Input_12
            // 
            this.Lab_Input_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_12.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_12.Location = new System.Drawing.Point(72, 407);
            this.Lab_Input_12.Name = "Lab_Input_12";
            this.Lab_Input_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_12.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_12.TabIndex = 61;
            this.Lab_Input_12.Text = "备用";
            // 
            // Lab_Input_13
            // 
            this.Lab_Input_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_13.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_13.Location = new System.Drawing.Point(72, 439);
            this.Lab_Input_13.Name = "Lab_Input_13";
            this.Lab_Input_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_13.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_13.TabIndex = 60;
            this.Lab_Input_13.Text = "备用";
            // 
            // Frame_Input
            // 
            this.Frame_Input.BackColor = System.Drawing.Color.White;
            this.Frame_Input.Controls.Add(this.Name_Index_15);
            this.Frame_Input.Controls.Add(this.Name_Index_14);
            this.Frame_Input.Controls.Add(this.Lab_Input_00);
            this.Frame_Input.Controls.Add(this.Lab_Input_01);
            this.Frame_Input.Controls.Add(this.Lab_Input_02);
            this.Frame_Input.Controls.Add(this.Lab_Input_03);
            this.Frame_Input.Controls.Add(this.Lab_Input_04);
            this.Frame_Input.Controls.Add(this.Lab_Input_05);
            this.Frame_Input.Controls.Add(this.Lab_Input_06);
            this.Frame_Input.Controls.Add(this.Lab_Input_07);
            this.Frame_Input.Controls.Add(this.Lab_Input_08);
            this.Frame_Input.Controls.Add(this.Lab_Input_09);
            this.Frame_Input.Controls.Add(this.Lab_Input_10);
            this.Frame_Input.Controls.Add(this.Lab_Input_11);
            this.Frame_Input.Controls.Add(this.Lab_Input_12);
            this.Frame_Input.Controls.Add(this.Lab_Input_13);
            this.Frame_Input.Controls.Add(this.Lab_Input_14);
            this.Frame_Input.Controls.Add(this.Lab_Input_15);
            this.Frame_Input.Controls.Add(this.Name_Index_0);
            this.Frame_Input.Controls.Add(this.Name_Index_1);
            this.Frame_Input.Controls.Add(this.Name_Index_2);
            this.Frame_Input.Controls.Add(this.Name_Index_3);
            this.Frame_Input.Controls.Add(this.Name_Index_4);
            this.Frame_Input.Controls.Add(this.Name_Index_5);
            this.Frame_Input.Controls.Add(this.Name_Index_6);
            this.Frame_Input.Controls.Add(this.Name_Index_7);
            this.Frame_Input.Controls.Add(this.Name_Index_8);
            this.Frame_Input.Controls.Add(this.Name_Index_9);
            this.Frame_Input.Controls.Add(this.Name_Index_10);
            this.Frame_Input.Controls.Add(this.Name_Index_11);
            this.Frame_Input.Controls.Add(this.Name_Index_12);
            this.Frame_Input.Controls.Add(this.Name_Index_13);
            this.Frame_Input.Controls.Add(this.ShapeContainer1);
            this.Frame_Input.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Frame_Input.ForeColor = System.Drawing.Color.Blue;
            this.Frame_Input.Location = new System.Drawing.Point(2, 2);
            this.Frame_Input.Name = "Frame_Input";
            this.Frame_Input.Padding = new System.Windows.Forms.Padding(0);
            this.Frame_Input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame_Input.Size = new System.Drawing.Size(302, 535);
            this.Frame_Input.TabIndex = 0;
            this.Frame_Input.TabStop = false;
            this.Frame_Input.Tag = "0";
            this.Frame_Input.Text = "输入 DI 00-15";
            // 
            // Lab_Input_14
            // 
            this.Lab_Input_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_14.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_14.Location = new System.Drawing.Point(72, 471);
            this.Lab_Input_14.Name = "Lab_Input_14";
            this.Lab_Input_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_14.Size = new System.Drawing.Size(224, 18);
            this.Lab_Input_14.TabIndex = 59;
            this.Lab_Input_14.Text = "备用";
            // 
            // Lab_Input_15
            // 
            this.Lab_Input_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lab_Input_15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_Input_15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Input_15.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Input_15.Location = new System.Drawing.Point(72, 504);
            this.Lab_Input_15.Name = "Lab_Input_15";
            this.Lab_Input_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lab_Input_15.Size = new System.Drawing.Size(224, 17);
            this.Lab_Input_15.TabIndex = 58;
            this.Lab_Input_15.Text = "备用";
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
            this.Name_Index_0.Text = "DI-00";
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
            this.Name_Index_1.Text = "DI-01";
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
            this.Name_Index_2.Text = "DI-02";
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
            this.Name_Index_3.Text = "DI-03";
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
            this.Name_Index_4.Text = "DI-04";
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
            this.Name_Index_5.Text = "DI-05";
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
            this.Name_Index_6.Text = "DI-06";
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
            this.Name_Index_7.Text = "DI-07";
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
            this.Name_Index_8.Text = "DI-08";
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
            this.Name_Index_9.Text = "DI-09";
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
            this.Name_Index_10.Text = "DI-10";
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
            this.Name_Index_11.Text = "DI-11";
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
            this.Name_Index_12.Text = "DI-12";
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
            this.Name_Index_13.Text = "DI-13";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 14);
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
            this.ShapeContainer1.Size = new System.Drawing.Size(302, 521);
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
            // InputClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Frame_Input);
            this.Name = "InputClass";
            this.Size = new System.Drawing.Size(306, 538);
            this.Load += new System.EventHandler(this.InputClass_Load);
            this.Frame_Input.ResumeLayout(false);
            this.Frame_Input.PerformLayout();
            this.ResumeLayout(false);

		}
		public System.Windows.Forms.Label Name_Index_15;
		public System.Windows.Forms.Label Name_Index_14;
		public System.Windows.Forms.Label Lab_Input_00;
		public System.Windows.Forms.Label Lab_Input_01;
		public System.Windows.Forms.Label Lab_Input_02;
		public System.Windows.Forms.Label Lab_Input_03;
		public System.Windows.Forms.Label Lab_Input_04;
		public System.Windows.Forms.Label Lab_Input_05;
		public System.Windows.Forms.Label Lab_Input_06;
		public System.Windows.Forms.Label Lab_Input_07;
		public System.Windows.Forms.Label Lab_Input_08;
		public System.Windows.Forms.Label Lab_Input_09;
		public System.Windows.Forms.Label Lab_Input_10;
		public System.Windows.Forms.Label Lab_Input_11;
		public System.Windows.Forms.Label Lab_Input_12;
		public System.Windows.Forms.Label Lab_Input_13;
		public System.Windows.Forms.GroupBox Frame_Input;
		public System.Windows.Forms.Label Lab_Input_14;
		public System.Windows.Forms.Label Lab_Input_15;
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
        internal System.Timers.Timer Timer = new System.Timers.Timer() { AutoReset = true, Interval = 100, Enabled = false };
	}
	
}
