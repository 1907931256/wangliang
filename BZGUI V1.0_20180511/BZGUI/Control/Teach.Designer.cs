
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
	partial class Teach : System.Windows.Forms.UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.OvalShape27 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape26 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape25 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape24 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape23 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape22 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape21 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape20 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape19 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape18 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape17 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape16 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape15 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape14 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape13 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape12 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape11 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape10 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape9 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape8 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape0 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Home_R = new System.Windows.Forms.Button();
            this.Btn_Home_X = new System.Windows.Forms.Button();
            this.Btn_Home_Y = new System.Windows.Forms.Button();
            this.Btn_Home_Z = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Servo_R = new System.Windows.Forms.Button();
            this.Btn_Servo_Z = new System.Windows.Forms.Button();
            this.Btn_Servo_Y = new System.Windows.Forms.Button();
            this.Btn_Servo_X = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_AddPos = new System.Windows.Forms.Button();
            this.ComBox_PosList = new System.Windows.Forms.ComboBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Btn_Go = new System.Windows.Forms.Button();
            this.ComBox_CMD = new System.Windows.Forms.ComboBox();
            this.ComBox_Aim = new System.Windows.Forms.ComboBox();
            this.Teach_XYZR = new System.Windows.Forms.GroupBox();
            this.Label_AName = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.ComBox_Speed = new System.Windows.Forms.ComboBox();
            this.RDec = new System.Windows.Forms.Button();
            this.RAdd = new System.Windows.Forms.Button();
            this.ZAdd = new System.Windows.Forms.Button();
            this.ZDec = new System.Windows.Forms.Button();
            this.YDec = new System.Windows.Forms.Button();
            this.YAdd = new System.Windows.Forms.Button();
            this.XDec = new System.Windows.Forms.Button();
            this.XAdd = new System.Windows.Forms.Button();
            this.Move_Distance = new System.Windows.Forms.GroupBox();
            this.mDinYi = new System.Windows.Forms.RadioButton();
            this.mLianXu = new System.Windows.Forms.RadioButton();
            this.SmallDist = new System.Windows.Forms.RadioButton();
            this.MidDist = new System.Windows.Forms.RadioButton();
            this.LongDist = new System.Windows.Forms.RadioButton();
            this.Text_Dist_R = new System.Windows.Forms.TextBox();
            this.ALabel4 = new System.Windows.Forms.Label();
            this.Text_Dist_Z = new System.Windows.Forms.TextBox();
            this.ALabel3 = new System.Windows.Forms.Label();
            this.Text_Dist_Y = new System.Windows.Forms.TextBox();
            this.ALabel2 = new System.Windows.Forms.Label();
            this.Text_Dist_X = new System.Windows.Forms.TextBox();
            this.ALabel1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Text_PrfPos_R = new System.Windows.Forms.TextBox();
            this.Text_PrfPos_Z = new System.Windows.Forms.TextBox();
            this.Text_PrfPos_Y = new System.Windows.Forms.TextBox();
            this.Text_PrfPos_X = new System.Windows.Forms.TextBox();
            this.Text_EncPos_R = new System.Windows.Forms.TextBox();
            this.Label_Pos_R = new System.Windows.Forms.Label();
            this.Text_EncPos_Z = new System.Windows.Forms.TextBox();
            this.Label_Pos_Z = new System.Windows.Forms.Label();
            this.Text_EncPos_Y = new System.Windows.Forms.TextBox();
            this.Label_Pos_Y = new System.Windows.Forms.Label();
            this.Text_EncPos_X = new System.Windows.Forms.TextBox();
            this.Label_Pos_X = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.Btn_SavePos = new System.Windows.Forms.Button();
            this.Btn_DeletePos = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachAxis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachAxis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachAxis3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachAxis4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.Teach_XYZR.SuspendLayout();
            this.Move_Distance.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Controls.Add(this.TabPage2);
            this.TabControl.Controls.Add(this.TabPage5);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabControl.ItemSize = new System.Drawing.Size(96, 30);
            this.TabControl.Location = new System.Drawing.Point(1, 1);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(486, 332);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 259;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Location = new System.Drawing.Point(4, 34);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(478, 294);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "使能原点";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label21);
            this.GroupBox3.Controls.Add(this.Label20);
            this.GroupBox3.Controls.Add(this.Label19);
            this.GroupBox3.Controls.Add(this.Label18);
            this.GroupBox3.Controls.Add(this.Label17);
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.ShapeContainer1);
            this.GroupBox3.Location = new System.Drawing.Point(150, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(323, 150);
            this.GroupBox3.TabIndex = 259;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "轴状态";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label21.Location = new System.Drawing.Point(8, 124);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(14, 14);
            this.Label21.TabIndex = 11;
            this.Label21.Text = "R";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label20.Location = new System.Drawing.Point(8, 95);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(14, 14);
            this.Label20.TabIndex = 10;
            this.Label20.Text = "Z";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label19.Location = new System.Drawing.Point(8, 66);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(14, 14);
            this.Label19.TabIndex = 9;
            this.Label19.Text = "Y";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label18.Location = new System.Drawing.Point(8, 37);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(14, 14);
            this.Label18.TabIndex = 8;
            this.Label18.Text = "X";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label17.Location = new System.Drawing.Point(290, 17);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(29, 12);
            this.Label17.TabIndex = 7;
            this.Label17.Text = "误差";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label16.Location = new System.Drawing.Point(240, 17);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(41, 12);
            this.Label16.TabIndex = 6;
            this.Label16.Text = "运动中";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label15.Location = new System.Drawing.Point(197, 17);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(41, 12);
            this.Label15.TabIndex = 5;
            this.Label15.Text = "负限位";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label14.Location = new System.Drawing.Point(159, 17);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(29, 12);
            this.Label14.TabIndex = 4;
            this.Label14.Text = "原点";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label13.Location = new System.Drawing.Point(109, 17);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(41, 12);
            this.Label13.TabIndex = 3;
            this.Label13.Text = "正限位";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label12.Location = new System.Drawing.Point(71, 17);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(29, 12);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "报警";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label11.Location = new System.Drawing.Point(26, 17);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(29, 12);
            this.Label11.TabIndex = 1;
            this.Label11.Text = "使能";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(3, 17);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.OvalShape27,
            this.OvalShape26,
            this.OvalShape25,
            this.OvalShape24,
            this.OvalShape23,
            this.OvalShape22,
            this.OvalShape21,
            this.OvalShape20,
            this.OvalShape19,
            this.OvalShape18,
            this.OvalShape17,
            this.OvalShape16,
            this.OvalShape15,
            this.OvalShape14,
            this.OvalShape13,
            this.OvalShape12,
            this.OvalShape11,
            this.OvalShape10,
            this.OvalShape9,
            this.OvalShape8,
            this.OvalShape7,
            this.OvalShape6,
            this.OvalShape5,
            this.OvalShape4,
            this.OvalShape3,
            this.OvalShape2,
            this.OvalShape1,
            this.OvalShape0});
            this.ShapeContainer1.Size = new System.Drawing.Size(317, 130);
            this.ShapeContainer1.TabIndex = 0;
            this.ShapeContainer1.TabStop = false;
            // 
            // OvalShape27
            // 
            this.OvalShape27.BorderColor = System.Drawing.Color.Black;
            this.OvalShape27.FillColor = System.Drawing.Color.White;
            this.OvalShape27.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape27.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape27.Location = new System.Drawing.Point(293, 106);
            this.OvalShape27.Name = "OvalShape27";
            this.OvalShape27.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape26
            // 
            this.OvalShape26.BorderColor = System.Drawing.Color.Black;
            this.OvalShape26.FillColor = System.Drawing.Color.White;
            this.OvalShape26.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape26.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape26.Location = new System.Drawing.Point(249, 107);
            this.OvalShape26.Name = "OvalShape26";
            this.OvalShape26.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape25
            // 
            this.OvalShape25.BorderColor = System.Drawing.Color.Black;
            this.OvalShape25.FillColor = System.Drawing.Color.White;
            this.OvalShape25.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape25.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape25.Location = new System.Drawing.Point(205, 107);
            this.OvalShape25.Name = "OvalShape25";
            this.OvalShape25.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape24
            // 
            this.OvalShape24.BorderColor = System.Drawing.Color.Black;
            this.OvalShape24.FillColor = System.Drawing.Color.White;
            this.OvalShape24.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape24.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape24.Location = new System.Drawing.Point(161, 107);
            this.OvalShape24.Name = "OvalShape24";
            this.OvalShape24.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape23
            // 
            this.OvalShape23.BorderColor = System.Drawing.Color.Black;
            this.OvalShape23.FillColor = System.Drawing.Color.White;
            this.OvalShape23.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape23.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape23.Location = new System.Drawing.Point(117, 107);
            this.OvalShape23.Name = "OvalShape23";
            this.OvalShape23.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape22
            // 
            this.OvalShape22.BorderColor = System.Drawing.Color.Black;
            this.OvalShape22.FillColor = System.Drawing.Color.White;
            this.OvalShape22.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape22.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape22.Location = new System.Drawing.Point(73, 107);
            this.OvalShape22.Name = "OvalShape22";
            this.OvalShape22.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape21
            // 
            this.OvalShape21.BorderColor = System.Drawing.Color.Black;
            this.OvalShape21.FillColor = System.Drawing.Color.White;
            this.OvalShape21.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape21.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape21.Location = new System.Drawing.Point(29, 106);
            this.OvalShape21.Name = "OvalShape21";
            this.OvalShape21.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape20
            // 
            this.OvalShape20.BorderColor = System.Drawing.Color.Black;
            this.OvalShape20.FillColor = System.Drawing.Color.White;
            this.OvalShape20.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape20.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape20.Location = new System.Drawing.Point(293, 77);
            this.OvalShape20.Name = "OvalShape20";
            this.OvalShape20.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape19
            // 
            this.OvalShape19.BorderColor = System.Drawing.Color.Black;
            this.OvalShape19.FillColor = System.Drawing.Color.White;
            this.OvalShape19.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape19.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape19.Location = new System.Drawing.Point(249, 78);
            this.OvalShape19.Name = "OvalShape19";
            this.OvalShape19.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape18
            // 
            this.OvalShape18.BorderColor = System.Drawing.Color.Black;
            this.OvalShape18.FillColor = System.Drawing.Color.White;
            this.OvalShape18.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape18.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape18.Location = new System.Drawing.Point(205, 78);
            this.OvalShape18.Name = "OvalShape18";
            this.OvalShape18.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape17
            // 
            this.OvalShape17.BorderColor = System.Drawing.Color.Black;
            this.OvalShape17.FillColor = System.Drawing.Color.White;
            this.OvalShape17.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape17.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape17.Location = new System.Drawing.Point(161, 78);
            this.OvalShape17.Name = "OvalShape17";
            this.OvalShape17.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape16
            // 
            this.OvalShape16.BorderColor = System.Drawing.Color.Black;
            this.OvalShape16.FillColor = System.Drawing.Color.White;
            this.OvalShape16.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape16.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape16.Location = new System.Drawing.Point(117, 78);
            this.OvalShape16.Name = "OvalShape16";
            this.OvalShape16.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape15
            // 
            this.OvalShape15.BorderColor = System.Drawing.Color.Black;
            this.OvalShape15.FillColor = System.Drawing.Color.White;
            this.OvalShape15.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape15.Location = new System.Drawing.Point(73, 78);
            this.OvalShape15.Name = "OvalShape15";
            this.OvalShape15.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape14
            // 
            this.OvalShape14.BorderColor = System.Drawing.Color.Black;
            this.OvalShape14.FillColor = System.Drawing.Color.White;
            this.OvalShape14.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape14.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape14.Location = new System.Drawing.Point(29, 77);
            this.OvalShape14.Name = "OvalShape14";
            this.OvalShape14.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape13
            // 
            this.OvalShape13.BorderColor = System.Drawing.Color.Black;
            this.OvalShape13.FillColor = System.Drawing.Color.White;
            this.OvalShape13.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape13.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape13.Location = new System.Drawing.Point(293, 46);
            this.OvalShape13.Name = "OvalShape13";
            this.OvalShape13.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape12
            // 
            this.OvalShape12.BorderColor = System.Drawing.Color.Black;
            this.OvalShape12.FillColor = System.Drawing.Color.White;
            this.OvalShape12.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape12.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape12.Location = new System.Drawing.Point(249, 47);
            this.OvalShape12.Name = "OvalShape12";
            this.OvalShape12.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape11
            // 
            this.OvalShape11.BorderColor = System.Drawing.Color.Black;
            this.OvalShape11.FillColor = System.Drawing.Color.White;
            this.OvalShape11.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape11.Location = new System.Drawing.Point(205, 47);
            this.OvalShape11.Name = "OvalShape11";
            this.OvalShape11.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape10
            // 
            this.OvalShape10.BorderColor = System.Drawing.Color.Black;
            this.OvalShape10.FillColor = System.Drawing.Color.White;
            this.OvalShape10.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape10.Location = new System.Drawing.Point(161, 47);
            this.OvalShape10.Name = "OvalShape10";
            this.OvalShape10.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape9
            // 
            this.OvalShape9.BorderColor = System.Drawing.Color.Black;
            this.OvalShape9.FillColor = System.Drawing.Color.White;
            this.OvalShape9.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape9.Location = new System.Drawing.Point(117, 47);
            this.OvalShape9.Name = "OvalShape9";
            this.OvalShape9.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape8
            // 
            this.OvalShape8.BorderColor = System.Drawing.Color.Black;
            this.OvalShape8.FillColor = System.Drawing.Color.White;
            this.OvalShape8.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape8.Location = new System.Drawing.Point(73, 47);
            this.OvalShape8.Name = "OvalShape8";
            this.OvalShape8.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape7
            // 
            this.OvalShape7.BorderColor = System.Drawing.Color.Black;
            this.OvalShape7.FillColor = System.Drawing.Color.White;
            this.OvalShape7.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape7.Location = new System.Drawing.Point(29, 46);
            this.OvalShape7.Name = "OvalShape7";
            this.OvalShape7.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape6
            // 
            this.OvalShape6.BorderColor = System.Drawing.Color.Black;
            this.OvalShape6.FillColor = System.Drawing.Color.White;
            this.OvalShape6.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape6.Location = new System.Drawing.Point(293, 18);
            this.OvalShape6.Name = "OvalShape6";
            this.OvalShape6.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape5
            // 
            this.OvalShape5.BorderColor = System.Drawing.Color.Black;
            this.OvalShape5.FillColor = System.Drawing.Color.White;
            this.OvalShape5.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape5.Location = new System.Drawing.Point(249, 19);
            this.OvalShape5.Name = "OvalShape5";
            this.OvalShape5.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape4
            // 
            this.OvalShape4.BorderColor = System.Drawing.Color.Black;
            this.OvalShape4.FillColor = System.Drawing.Color.White;
            this.OvalShape4.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape4.Location = new System.Drawing.Point(205, 19);
            this.OvalShape4.Name = "OvalShape4";
            this.OvalShape4.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape3
            // 
            this.OvalShape3.BorderColor = System.Drawing.Color.Black;
            this.OvalShape3.FillColor = System.Drawing.Color.White;
            this.OvalShape3.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape3.Location = new System.Drawing.Point(161, 19);
            this.OvalShape3.Name = "OvalShape3";
            this.OvalShape3.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape2
            // 
            this.OvalShape2.BorderColor = System.Drawing.Color.Black;
            this.OvalShape2.FillColor = System.Drawing.Color.White;
            this.OvalShape2.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape2.Location = new System.Drawing.Point(117, 19);
            this.OvalShape2.Name = "OvalShape2";
            this.OvalShape2.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape1
            // 
            this.OvalShape1.BorderColor = System.Drawing.Color.Black;
            this.OvalShape1.FillColor = System.Drawing.Color.White;
            this.OvalShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape1.Location = new System.Drawing.Point(73, 19);
            this.OvalShape1.Name = "OvalShape1";
            this.OvalShape1.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape0
            // 
            this.OvalShape0.BorderColor = System.Drawing.Color.Black;
            this.OvalShape0.FillColor = System.Drawing.Color.White;
            this.OvalShape0.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape0.Location = new System.Drawing.Point(29, 18);
            this.OvalShape0.Name = "OvalShape0";
            this.OvalShape0.Size = new System.Drawing.Size(16, 16);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Btn_Home_R);
            this.GroupBox4.Controls.Add(this.Btn_Home_X);
            this.GroupBox4.Controls.Add(this.Btn_Home_Y);
            this.GroupBox4.Controls.Add(this.Btn_Home_Z);
            this.GroupBox4.Location = new System.Drawing.Point(6, 146);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(138, 134);
            this.GroupBox4.TabIndex = 258;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "回原点";
            // 
            // Btn_Home_R
            // 
            this.Btn_Home_R.BackColor = System.Drawing.Color.White;
            this.Btn_Home_R.Location = new System.Drawing.Point(79, 79);
            this.Btn_Home_R.Name = "Btn_Home_R";
            this.Btn_Home_R.Size = new System.Drawing.Size(50, 50);
            this.Btn_Home_R.TabIndex = 4;
            this.Btn_Home_R.Tag = "4";
            this.Btn_Home_R.Text = "R原点";
            this.Btn_Home_R.UseVisualStyleBackColor = false;
            this.Btn_Home_R.Click += new System.EventHandler(this.Btn_Home_X_Click);
            // 
            // Btn_Home_X
            // 
            this.Btn_Home_X.BackColor = System.Drawing.Color.White;
            this.Btn_Home_X.Location = new System.Drawing.Point(9, 20);
            this.Btn_Home_X.Name = "Btn_Home_X";
            this.Btn_Home_X.Size = new System.Drawing.Size(50, 50);
            this.Btn_Home_X.TabIndex = 1;
            this.Btn_Home_X.Tag = "1";
            this.Btn_Home_X.Text = "X原点";
            this.Btn_Home_X.UseVisualStyleBackColor = false;
            this.Btn_Home_X.Click += new System.EventHandler(this.Btn_Home_X_Click);
            // 
            // Btn_Home_Y
            // 
            this.Btn_Home_Y.BackColor = System.Drawing.Color.White;
            this.Btn_Home_Y.Location = new System.Drawing.Point(79, 20);
            this.Btn_Home_Y.Name = "Btn_Home_Y";
            this.Btn_Home_Y.Size = new System.Drawing.Size(50, 50);
            this.Btn_Home_Y.TabIndex = 2;
            this.Btn_Home_Y.Tag = "2";
            this.Btn_Home_Y.Text = "Y原点";
            this.Btn_Home_Y.UseVisualStyleBackColor = false;
            this.Btn_Home_Y.Click += new System.EventHandler(this.Btn_Home_X_Click);
            // 
            // Btn_Home_Z
            // 
            this.Btn_Home_Z.BackColor = System.Drawing.Color.White;
            this.Btn_Home_Z.Location = new System.Drawing.Point(9, 77);
            this.Btn_Home_Z.Name = "Btn_Home_Z";
            this.Btn_Home_Z.Size = new System.Drawing.Size(50, 50);
            this.Btn_Home_Z.TabIndex = 3;
            this.Btn_Home_Z.Tag = "3";
            this.Btn_Home_Z.Text = "Z原点";
            this.Btn_Home_Z.UseVisualStyleBackColor = false;
            this.Btn_Home_Z.Click += new System.EventHandler(this.Btn_Home_X_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Btn_Servo_R);
            this.GroupBox2.Controls.Add(this.Btn_Servo_Z);
            this.GroupBox2.Controls.Add(this.Btn_Servo_Y);
            this.GroupBox2.Controls.Add(this.Btn_Servo_X);
            this.GroupBox2.Location = new System.Drawing.Point(6, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(138, 134);
            this.GroupBox2.TabIndex = 257;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "使能";
            // 
            // Btn_Servo_R
            // 
            this.Btn_Servo_R.BackColor = System.Drawing.Color.White;
            this.Btn_Servo_R.Location = new System.Drawing.Point(79, 76);
            this.Btn_Servo_R.Name = "Btn_Servo_R";
            this.Btn_Servo_R.Size = new System.Drawing.Size(50, 50);
            this.Btn_Servo_R.TabIndex = 4;
            this.Btn_Servo_R.Tag = "4";
            this.Btn_Servo_R.Text = "R使能";
            this.Btn_Servo_R.UseVisualStyleBackColor = false;
            this.Btn_Servo_R.Click += new System.EventHandler(this.Btn_Servo_X_Click);
            // 
            // Btn_Servo_Z
            // 
            this.Btn_Servo_Z.BackColor = System.Drawing.Color.White;
            this.Btn_Servo_Z.Location = new System.Drawing.Point(9, 76);
            this.Btn_Servo_Z.Name = "Btn_Servo_Z";
            this.Btn_Servo_Z.Size = new System.Drawing.Size(50, 50);
            this.Btn_Servo_Z.TabIndex = 3;
            this.Btn_Servo_Z.Tag = "3";
            this.Btn_Servo_Z.Text = "Z使能";
            this.Btn_Servo_Z.UseVisualStyleBackColor = false;
            this.Btn_Servo_Z.Click += new System.EventHandler(this.Btn_Servo_X_Click);
            // 
            // Btn_Servo_Y
            // 
            this.Btn_Servo_Y.BackColor = System.Drawing.Color.White;
            this.Btn_Servo_Y.Location = new System.Drawing.Point(79, 20);
            this.Btn_Servo_Y.Name = "Btn_Servo_Y";
            this.Btn_Servo_Y.Size = new System.Drawing.Size(50, 50);
            this.Btn_Servo_Y.TabIndex = 2;
            this.Btn_Servo_Y.Tag = "2";
            this.Btn_Servo_Y.Text = "Y使能";
            this.Btn_Servo_Y.UseVisualStyleBackColor = false;
            this.Btn_Servo_Y.Click += new System.EventHandler(this.Btn_Servo_X_Click);
            // 
            // Btn_Servo_X
            // 
            this.Btn_Servo_X.BackColor = System.Drawing.Color.White;
            this.Btn_Servo_X.Location = new System.Drawing.Point(9, 20);
            this.Btn_Servo_X.Name = "Btn_Servo_X";
            this.Btn_Servo_X.Size = new System.Drawing.Size(50, 50);
            this.Btn_Servo_X.TabIndex = 1;
            this.Btn_Servo_X.Tag = "1";
            this.Btn_Servo_X.Text = "X使能";
            this.Btn_Servo_X.UseVisualStyleBackColor = false;
            this.Btn_Servo_X.Click += new System.EventHandler(this.Btn_Servo_X_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.TabControl1);
            this.TabPage2.Controls.Add(this.Teach_XYZR);
            this.TabPage2.Controls.Add(this.Move_Distance);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 34);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(478, 294);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "手动控制";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Location = new System.Drawing.Point(180, 191);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(299, 100);
            this.TabControl1.TabIndex = 257;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.Btn_AddPos);
            this.TabPage3.Controls.Add(this.ComBox_PosList);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(291, 74);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "示教点";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_AddPos
            // 
            this.Btn_AddPos.BackColor = System.Drawing.Color.Salmon;
            this.Btn_AddPos.Location = new System.Drawing.Point(14, 18);
            this.Btn_AddPos.Name = "Btn_AddPos";
            this.Btn_AddPos.Size = new System.Drawing.Size(53, 34);
            this.Btn_AddPos.TabIndex = 5;
            this.Btn_AddPos.Text = "加点";
            this.Btn_AddPos.UseVisualStyleBackColor = false;
            this.Btn_AddPos.Click += new System.EventHandler(this.Btn_AddPos_Click);
            // 
            // ComBox_PosList
            // 
            this.ComBox_PosList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComBox_PosList.FormattingEnabled = true;
            this.ComBox_PosList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBox_PosList.Location = new System.Drawing.Point(92, 24);
            this.ComBox_PosList.Name = "ComBox_PosList";
            this.ComBox_PosList.Size = new System.Drawing.Size(161, 22);
            this.ComBox_PosList.TabIndex = 4;
            this.ComBox_PosList.Text = "P0";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.Label23);
            this.TabPage4.Controls.Add(this.Label22);
            this.TabPage4.Controls.Add(this.Btn_Go);
            this.TabPage4.Controls.Add(this.ComBox_CMD);
            this.TabPage4.Controls.Add(this.ComBox_Aim);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(291, 74);
            this.TabPage4.TabIndex = 1;
            this.TabPage4.Text = "执行运动";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label23.ForeColor = System.Drawing.Color.Blue;
            this.Label23.Location = new System.Drawing.Point(65, 16);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(41, 12);
            this.Label23.TabIndex = 245;
            this.Label23.Text = "目标：";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.BackColor = System.Drawing.Color.Transparent;
            this.Label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label22.ForeColor = System.Drawing.Color.Blue;
            this.Label22.Location = new System.Drawing.Point(6, 16);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(41, 12);
            this.Label22.TabIndex = 244;
            this.Label22.Text = "命令：";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Btn_Go
            // 
            this.Btn_Go.Location = new System.Drawing.Point(228, 28);
            this.Btn_Go.Name = "Btn_Go";
            this.Btn_Go.Size = new System.Drawing.Size(53, 34);
            this.Btn_Go.TabIndex = 7;
            this.Btn_Go.Text = "运动";
            this.Btn_Go.UseVisualStyleBackColor = true;
            this.Btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
            // 
            // ComBox_CMD
            // 
            this.ComBox_CMD.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComBox_CMD.FormattingEnabled = true;
            this.ComBox_CMD.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBox_CMD.Items.AddRange(new object[] {
            "Jump",
            "Go"});
            this.ComBox_CMD.Location = new System.Drawing.Point(3, 34);
            this.ComBox_CMD.Name = "ComBox_CMD";
            this.ComBox_CMD.Size = new System.Drawing.Size(54, 22);
            this.ComBox_CMD.TabIndex = 6;
            this.ComBox_CMD.Text = "Go";
            // 
            // ComBox_Aim
            // 
            this.ComBox_Aim.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComBox_Aim.FormattingEnabled = true;
            this.ComBox_Aim.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComBox_Aim.Location = new System.Drawing.Point(63, 34);
            this.ComBox_Aim.Name = "ComBox_Aim";
            this.ComBox_Aim.Size = new System.Drawing.Size(161, 22);
            this.ComBox_Aim.TabIndex = 5;
            this.ComBox_Aim.Text = "P0";
            // 
            // Teach_XYZR
            // 
            this.Teach_XYZR.BackColor = System.Drawing.Color.White;
            this.Teach_XYZR.Controls.Add(this.Label_AName);
            this.Teach_XYZR.Controls.Add(this.Label10);
            this.Teach_XYZR.Controls.Add(this.ComBox_Speed);
            this.Teach_XYZR.Controls.Add(this.RDec);
            this.Teach_XYZR.Controls.Add(this.RAdd);
            this.Teach_XYZR.Controls.Add(this.ZAdd);
            this.Teach_XYZR.Controls.Add(this.ZDec);
            this.Teach_XYZR.Controls.Add(this.YDec);
            this.Teach_XYZR.Controls.Add(this.YAdd);
            this.Teach_XYZR.Controls.Add(this.XDec);
            this.Teach_XYZR.Controls.Add(this.XAdd);
            this.Teach_XYZR.Location = new System.Drawing.Point(3, 3);
            this.Teach_XYZR.Name = "Teach_XYZR";
            this.Teach_XYZR.Size = new System.Drawing.Size(171, 289);
            this.Teach_XYZR.TabIndex = 254;
            this.Teach_XYZR.TabStop = false;
            this.Teach_XYZR.Text = "XY轴调试";
            // 
            // Label_AName
            // 
            this.Label_AName.BackColor = System.Drawing.Color.Gold;
            this.Label_AName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_AName.Location = new System.Drawing.Point(21, 206);
            this.Label_AName.Name = "Label_AName";
            this.Label_AName.Size = new System.Drawing.Size(130, 49);
            this.Label_AName.TabIndex = 260;
            this.Label_AName.Text = "工位名称";
            this.Label_AName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.Blue;
            this.Label10.Location = new System.Drawing.Point(14, 24);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(41, 12);
            this.Label10.TabIndex = 259;
            this.Label10.Text = "速度：";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComBox_Speed
            // 
            this.ComBox_Speed.FormattingEnabled = true;
            this.ComBox_Speed.Items.AddRange(new object[] {
            "低  （1mm/s）",
            "低 （5mm/s）",
            "低 （10mm/s）",
            "中 （30mm/s）",
            "中 （50mm/s）",
            "高（100mm/s）"});
            this.ComBox_Speed.Location = new System.Drawing.Point(61, 20);
            this.ComBox_Speed.Name = "ComBox_Speed";
            this.ComBox_Speed.Size = new System.Drawing.Size(104, 20);
            this.ComBox_Speed.TabIndex = 258;
            this.ComBox_Speed.Text = "低  （1mm/s）";
            // 
            // RDec
            // 
            this.RDec.BackColor = System.Drawing.Color.LightGreen;
            this.RDec.Cursor = System.Windows.Forms.Cursors.Default;
            this.RDec.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RDec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RDec.Image = ((System.Drawing.Image)(resources.GetObject("RDec.Image")));
            this.RDec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RDec.Location = new System.Drawing.Point(116, 206);
            this.RDec.Name = "RDec";
            this.RDec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RDec.Size = new System.Drawing.Size(49, 49);
            this.RDec.TabIndex = 4;
            this.RDec.Tag = "-1";
            this.RDec.Text = "R-";
            this.RDec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RDec.UseVisualStyleBackColor = false;
            this.RDec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.RDec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // RAdd
            // 
            this.RAdd.BackColor = System.Drawing.Color.LightGreen;
            this.RAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.RAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RAdd.Image = ((System.Drawing.Image)(resources.GetObject("RAdd.Image")));
            this.RAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RAdd.Location = new System.Drawing.Point(6, 206);
            this.RAdd.Name = "RAdd";
            this.RAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RAdd.Size = new System.Drawing.Size(49, 49);
            this.RAdd.TabIndex = 4;
            this.RAdd.Tag = "1";
            this.RAdd.Text = "R+";
            this.RAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RAdd.UseVisualStyleBackColor = false;
            this.RAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.RAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // ZAdd
            // 
            this.ZAdd.BackColor = System.Drawing.Color.LightGreen;
            this.ZAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZAdd.Image = ((System.Drawing.Image)(resources.GetObject("ZAdd.Image")));
            this.ZAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZAdd.Location = new System.Drawing.Point(61, 234);
            this.ZAdd.Name = "ZAdd";
            this.ZAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZAdd.Size = new System.Drawing.Size(49, 49);
            this.ZAdd.TabIndex = 3;
            this.ZAdd.Tag = "1";
            this.ZAdd.Text = "Z+";
            this.ZAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZAdd.UseVisualStyleBackColor = false;
            this.ZAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.ZAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // ZDec
            // 
            this.ZDec.BackColor = System.Drawing.Color.LightGreen;
            this.ZDec.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZDec.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZDec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZDec.Image = ((System.Drawing.Image)(resources.GetObject("ZDec.Image")));
            this.ZDec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZDec.Location = new System.Drawing.Point(61, 179);
            this.ZDec.Name = "ZDec";
            this.ZDec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZDec.Size = new System.Drawing.Size(49, 49);
            this.ZDec.TabIndex = 3;
            this.ZDec.Tag = "-1";
            this.ZDec.Text = "Z-";
            this.ZDec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZDec.UseVisualStyleBackColor = false;
            this.ZDec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.ZDec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // YDec
            // 
            this.YDec.BackColor = System.Drawing.Color.LightGreen;
            this.YDec.Cursor = System.Windows.Forms.Cursors.Default;
            this.YDec.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.YDec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YDec.Image = ((System.Drawing.Image)(resources.GetObject("YDec.Image")));
            this.YDec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YDec.Location = new System.Drawing.Point(61, 56);
            this.YDec.Name = "YDec";
            this.YDec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YDec.Size = new System.Drawing.Size(49, 49);
            this.YDec.TabIndex = 2;
            this.YDec.Tag = "1";
            this.YDec.Text = "Y-";
            this.YDec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.YDec.UseVisualStyleBackColor = false;
            this.YDec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.YDec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // YAdd
            // 
            this.YAdd.BackColor = System.Drawing.Color.LightGreen;
            this.YAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.YAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.YAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YAdd.Image = ((System.Drawing.Image)(resources.GetObject("YAdd.Image")));
            this.YAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YAdd.Location = new System.Drawing.Point(61, 111);
            this.YAdd.Name = "YAdd";
            this.YAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YAdd.Size = new System.Drawing.Size(49, 49);
            this.YAdd.TabIndex = 2;
            this.YAdd.Tag = "-1";
            this.YAdd.Text = "Y+";
            this.YAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.YAdd.UseVisualStyleBackColor = false;
            this.YAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.YAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // XDec
            // 
            this.XDec.BackColor = System.Drawing.Color.LightGreen;
            this.XDec.Cursor = System.Windows.Forms.Cursors.Default;
            this.XDec.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XDec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.XDec.Image = ((System.Drawing.Image)(resources.GetObject("XDec.Image")));
            this.XDec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.XDec.Location = new System.Drawing.Point(6, 83);
            this.XDec.Name = "XDec";
            this.XDec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.XDec.Size = new System.Drawing.Size(49, 49);
            this.XDec.TabIndex = 1;
            this.XDec.Tag = "-1";
            this.XDec.Text = "X-";
            this.XDec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.XDec.UseVisualStyleBackColor = false;
            this.XDec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.XDec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // XAdd
            // 
            this.XAdd.BackColor = System.Drawing.Color.LightGreen;
            this.XAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.XAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.XAdd.Image = global::BZGUI.Properties.Resources.you;
            this.XAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.XAdd.Location = new System.Drawing.Point(116, 83);
            this.XAdd.Name = "XAdd";
            this.XAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.XAdd.Size = new System.Drawing.Size(49, 49);
            this.XAdd.TabIndex = 1;
            this.XAdd.Tag = "1";
            this.XAdd.Text = "X+";
            this.XAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.XAdd.UseVisualStyleBackColor = false;
            this.XAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseDown);
            this.XAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XDec_MouseUp);
            // 
            // Move_Distance
            // 
            this.Move_Distance.BackColor = System.Drawing.Color.White;
            this.Move_Distance.Controls.Add(this.mDinYi);
            this.Move_Distance.Controls.Add(this.mLianXu);
            this.Move_Distance.Controls.Add(this.SmallDist);
            this.Move_Distance.Controls.Add(this.MidDist);
            this.Move_Distance.Controls.Add(this.LongDist);
            this.Move_Distance.Controls.Add(this.Text_Dist_R);
            this.Move_Distance.Controls.Add(this.ALabel4);
            this.Move_Distance.Controls.Add(this.Text_Dist_Z);
            this.Move_Distance.Controls.Add(this.ALabel3);
            this.Move_Distance.Controls.Add(this.Text_Dist_Y);
            this.Move_Distance.Controls.Add(this.ALabel2);
            this.Move_Distance.Controls.Add(this.Text_Dist_X);
            this.Move_Distance.Controls.Add(this.ALabel1);
            this.Move_Distance.Location = new System.Drawing.Point(180, 91);
            this.Move_Distance.Name = "Move_Distance";
            this.Move_Distance.Size = new System.Drawing.Size(294, 98);
            this.Move_Distance.TabIndex = 255;
            this.Move_Distance.TabStop = false;
            this.Move_Distance.Text = "移动距离";
            // 
            // mDinYi
            // 
            this.mDinYi.AutoSize = true;
            this.mDinYi.Location = new System.Drawing.Point(223, 12);
            this.mDinYi.Name = "mDinYi";
            this.mDinYi.Size = new System.Drawing.Size(59, 16);
            this.mDinYi.TabIndex = 255;
            this.mDinYi.Text = "自定义";
            this.mDinYi.UseVisualStyleBackColor = true;
            this.mDinYi.CheckedChanged += new System.EventHandler(this.mDinYi_CheckedChanged);
            // 
            // mLianXu
            // 
            this.mLianXu.AutoSize = true;
            this.mLianXu.Location = new System.Drawing.Point(223, 72);
            this.mLianXu.Name = "mLianXu";
            this.mLianXu.Size = new System.Drawing.Size(59, 16);
            this.mLianXu.TabIndex = 254;
            this.mLianXu.Text = "连  续";
            this.mLianXu.UseVisualStyleBackColor = true;
            this.mLianXu.CheckedChanged += new System.EventHandler(this.mLianXu_CheckedChanged);
            // 
            // SmallDist
            // 
            this.SmallDist.AutoSize = true;
            this.SmallDist.Checked = true;
            this.SmallDist.Location = new System.Drawing.Point(151, 72);
            this.SmallDist.Name = "SmallDist";
            this.SmallDist.Size = new System.Drawing.Size(59, 16);
            this.SmallDist.TabIndex = 253;
            this.SmallDist.TabStop = true;
            this.SmallDist.Text = "短距离";
            this.SmallDist.UseVisualStyleBackColor = true;
            this.SmallDist.CheckedChanged += new System.EventHandler(this.SmallDist_CheckedChanged);
            // 
            // MidDist
            // 
            this.MidDist.AutoSize = true;
            this.MidDist.Location = new System.Drawing.Point(151, 42);
            this.MidDist.Name = "MidDist";
            this.MidDist.Size = new System.Drawing.Size(59, 16);
            this.MidDist.TabIndex = 252;
            this.MidDist.Text = "中距离";
            this.MidDist.UseVisualStyleBackColor = true;
            this.MidDist.CheckedChanged += new System.EventHandler(this.MidDist_CheckedChanged);
            // 
            // LongDist
            // 
            this.LongDist.AutoSize = true;
            this.LongDist.Location = new System.Drawing.Point(151, 12);
            this.LongDist.Name = "LongDist";
            this.LongDist.Size = new System.Drawing.Size(59, 16);
            this.LongDist.TabIndex = 251;
            this.LongDist.Text = "长距离";
            this.LongDist.UseVisualStyleBackColor = true;
            this.LongDist.CheckedChanged += new System.EventHandler(this.LongDist_CheckedChanged);
            // 
            // Text_Dist_R
            // 
            this.Text_Dist_R.AcceptsReturn = true;
            this.Text_Dist_R.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Dist_R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Dist_R.Enabled = false;
            this.Text_Dist_R.ForeColor = System.Drawing.Color.Black;
            this.Text_Dist_R.Location = new System.Drawing.Point(64, 73);
            this.Text_Dist_R.MaxLength = 0;
            this.Text_Dist_R.Name = "Text_Dist_R";
            this.Text_Dist_R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Dist_R.Size = new System.Drawing.Size(52, 21);
            this.Text_Dist_R.TabIndex = 250;
            this.Text_Dist_R.Text = "0.1";
            this.Text_Dist_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ALabel4
            // 
            this.ALabel4.AutoSize = true;
            this.ALabel4.BackColor = System.Drawing.Color.Transparent;
            this.ALabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.ALabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALabel4.ForeColor = System.Drawing.Color.Blue;
            this.ALabel4.Location = new System.Drawing.Point(74, 57);
            this.ALabel4.Name = "ALabel4";
            this.ALabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALabel4.Size = new System.Drawing.Size(35, 12);
            this.ALabel4.TabIndex = 249;
            this.ALabel4.Text = "R(°)";
            this.ALabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_Dist_Z
            // 
            this.Text_Dist_Z.AcceptsReturn = true;
            this.Text_Dist_Z.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Dist_Z.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Dist_Z.Enabled = false;
            this.Text_Dist_Z.ForeColor = System.Drawing.Color.Black;
            this.Text_Dist_Z.Location = new System.Drawing.Point(6, 73);
            this.Text_Dist_Z.MaxLength = 0;
            this.Text_Dist_Z.Name = "Text_Dist_Z";
            this.Text_Dist_Z.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Dist_Z.Size = new System.Drawing.Size(52, 21);
            this.Text_Dist_Z.TabIndex = 248;
            this.Text_Dist_Z.Text = "0.1";
            this.Text_Dist_Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ALabel3
            // 
            this.ALabel3.AutoSize = true;
            this.ALabel3.BackColor = System.Drawing.Color.Transparent;
            this.ALabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.ALabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALabel3.ForeColor = System.Drawing.Color.Blue;
            this.ALabel3.Location = new System.Drawing.Point(16, 57);
            this.ALabel3.Name = "ALabel3";
            this.ALabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALabel3.Size = new System.Drawing.Size(35, 12);
            this.ALabel3.TabIndex = 247;
            this.ALabel3.Text = "Z(mm)";
            this.ALabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_Dist_Y
            // 
            this.Text_Dist_Y.AcceptsReturn = true;
            this.Text_Dist_Y.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Dist_Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Dist_Y.Enabled = false;
            this.Text_Dist_Y.ForeColor = System.Drawing.Color.Black;
            this.Text_Dist_Y.Location = new System.Drawing.Point(64, 32);
            this.Text_Dist_Y.MaxLength = 0;
            this.Text_Dist_Y.Name = "Text_Dist_Y";
            this.Text_Dist_Y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Dist_Y.Size = new System.Drawing.Size(52, 21);
            this.Text_Dist_Y.TabIndex = 246;
            this.Text_Dist_Y.Text = "0.1";
            this.Text_Dist_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ALabel2
            // 
            this.ALabel2.AutoSize = true;
            this.ALabel2.BackColor = System.Drawing.Color.Transparent;
            this.ALabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ALabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALabel2.ForeColor = System.Drawing.Color.Blue;
            this.ALabel2.Location = new System.Drawing.Point(74, 16);
            this.ALabel2.Name = "ALabel2";
            this.ALabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALabel2.Size = new System.Drawing.Size(35, 12);
            this.ALabel2.TabIndex = 245;
            this.ALabel2.Text = "Y(mm)";
            this.ALabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_Dist_X
            // 
            this.Text_Dist_X.AcceptsReturn = true;
            this.Text_Dist_X.BackColor = System.Drawing.SystemColors.Window;
            this.Text_Dist_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Dist_X.Enabled = false;
            this.Text_Dist_X.ForeColor = System.Drawing.Color.Black;
            this.Text_Dist_X.Location = new System.Drawing.Point(6, 32);
            this.Text_Dist_X.MaxLength = 0;
            this.Text_Dist_X.Name = "Text_Dist_X";
            this.Text_Dist_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_Dist_X.Size = new System.Drawing.Size(52, 21);
            this.Text_Dist_X.TabIndex = 244;
            this.Text_Dist_X.Text = "0.1";
            this.Text_Dist_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ALabel1
            // 
            this.ALabel1.AutoSize = true;
            this.ALabel1.BackColor = System.Drawing.Color.Transparent;
            this.ALabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ALabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALabel1.ForeColor = System.Drawing.Color.Blue;
            this.ALabel1.Location = new System.Drawing.Point(16, 16);
            this.ALabel1.Name = "ALabel1";
            this.ALabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ALabel1.Size = new System.Drawing.Size(35, 12);
            this.ALabel1.TabIndex = 243;
            this.ALabel1.Text = "X(mm)";
            this.ALabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Text_PrfPos_R);
            this.GroupBox1.Controls.Add(this.Text_PrfPos_Z);
            this.GroupBox1.Controls.Add(this.Text_PrfPos_Y);
            this.GroupBox1.Controls.Add(this.Text_PrfPos_X);
            this.GroupBox1.Controls.Add(this.Text_EncPos_R);
            this.GroupBox1.Controls.Add(this.Label_Pos_R);
            this.GroupBox1.Controls.Add(this.Text_EncPos_Z);
            this.GroupBox1.Controls.Add(this.Label_Pos_Z);
            this.GroupBox1.Controls.Add(this.Text_EncPos_Y);
            this.GroupBox1.Controls.Add(this.Label_Pos_Y);
            this.GroupBox1.Controls.Add(this.Text_EncPos_X);
            this.GroupBox1.Controls.Add(this.Label_Pos_X);
            this.GroupBox1.Location = new System.Drawing.Point(180, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(294, 82);
            this.GroupBox1.TabIndex = 256;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "当前位置";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.Blue;
            this.Label9.Location = new System.Drawing.Point(6, 61);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(35, 10);
            this.Label9.TabIndex = 256;
            this.Label9.Text = "规划器";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.Blue;
            this.Label8.Location = new System.Drawing.Point(6, 35);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(35, 10);
            this.Label8.TabIndex = 255;
            this.Label8.Text = "编码器";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_PrfPos_R
            // 
            this.Text_PrfPos_R.AcceptsReturn = true;
            this.Text_PrfPos_R.BackColor = System.Drawing.SystemColors.Window;
            this.Text_PrfPos_R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_PrfPos_R.ForeColor = System.Drawing.Color.Black;
            this.Text_PrfPos_R.Location = new System.Drawing.Point(232, 56);
            this.Text_PrfPos_R.MaxLength = 0;
            this.Text_PrfPos_R.Name = "Text_PrfPos_R";
            this.Text_PrfPos_R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_PrfPos_R.Size = new System.Drawing.Size(52, 21);
            this.Text_PrfPos_R.TabIndex = 254;
            this.Text_PrfPos_R.Tag = "4";
            this.Text_PrfPos_R.Text = "0.000";
            this.Text_PrfPos_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_PrfPos_Z
            // 
            this.Text_PrfPos_Z.AcceptsReturn = true;
            this.Text_PrfPos_Z.BackColor = System.Drawing.SystemColors.Window;
            this.Text_PrfPos_Z.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_PrfPos_Z.ForeColor = System.Drawing.Color.Black;
            this.Text_PrfPos_Z.Location = new System.Drawing.Point(174, 56);
            this.Text_PrfPos_Z.MaxLength = 0;
            this.Text_PrfPos_Z.Name = "Text_PrfPos_Z";
            this.Text_PrfPos_Z.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_PrfPos_Z.Size = new System.Drawing.Size(52, 21);
            this.Text_PrfPos_Z.TabIndex = 253;
            this.Text_PrfPos_Z.Tag = "3";
            this.Text_PrfPos_Z.Text = "0.000";
            this.Text_PrfPos_Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_PrfPos_Y
            // 
            this.Text_PrfPos_Y.AcceptsReturn = true;
            this.Text_PrfPos_Y.BackColor = System.Drawing.SystemColors.Window;
            this.Text_PrfPos_Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_PrfPos_Y.ForeColor = System.Drawing.Color.Black;
            this.Text_PrfPos_Y.Location = new System.Drawing.Point(116, 56);
            this.Text_PrfPos_Y.MaxLength = 0;
            this.Text_PrfPos_Y.Name = "Text_PrfPos_Y";
            this.Text_PrfPos_Y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_PrfPos_Y.Size = new System.Drawing.Size(52, 21);
            this.Text_PrfPos_Y.TabIndex = 252;
            this.Text_PrfPos_Y.Tag = "2";
            this.Text_PrfPos_Y.Text = "0.000";
            this.Text_PrfPos_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_PrfPos_X
            // 
            this.Text_PrfPos_X.AcceptsReturn = true;
            this.Text_PrfPos_X.BackColor = System.Drawing.SystemColors.Window;
            this.Text_PrfPos_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_PrfPos_X.ForeColor = System.Drawing.Color.Black;
            this.Text_PrfPos_X.Location = new System.Drawing.Point(58, 56);
            this.Text_PrfPos_X.MaxLength = 0;
            this.Text_PrfPos_X.Name = "Text_PrfPos_X";
            this.Text_PrfPos_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_PrfPos_X.Size = new System.Drawing.Size(52, 21);
            this.Text_PrfPos_X.TabIndex = 251;
            this.Text_PrfPos_X.Tag = "1";
            this.Text_PrfPos_X.Text = "0.000";
            this.Text_PrfPos_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_EncPos_R
            // 
            this.Text_EncPos_R.AcceptsReturn = true;
            this.Text_EncPos_R.BackColor = System.Drawing.SystemColors.Window;
            this.Text_EncPos_R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_EncPos_R.ForeColor = System.Drawing.Color.Black;
            this.Text_EncPos_R.Location = new System.Drawing.Point(232, 29);
            this.Text_EncPos_R.MaxLength = 0;
            this.Text_EncPos_R.Name = "Text_EncPos_R";
            this.Text_EncPos_R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_EncPos_R.Size = new System.Drawing.Size(52, 21);
            this.Text_EncPos_R.TabIndex = 4;
            this.Text_EncPos_R.Tag = "4";
            this.Text_EncPos_R.Text = "0.000";
            this.Text_EncPos_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Pos_R
            // 
            this.Label_Pos_R.AutoSize = true;
            this.Label_Pos_R.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pos_R.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Pos_R.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Pos_R.ForeColor = System.Drawing.Color.Blue;
            this.Label_Pos_R.Location = new System.Drawing.Point(242, 13);
            this.Label_Pos_R.Name = "Label_Pos_R";
            this.Label_Pos_R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Pos_R.Size = new System.Drawing.Size(35, 12);
            this.Label_Pos_R.TabIndex = 249;
            this.Label_Pos_R.Text = "R(°)";
            this.Label_Pos_R.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_EncPos_Z
            // 
            this.Text_EncPos_Z.AcceptsReturn = true;
            this.Text_EncPos_Z.BackColor = System.Drawing.SystemColors.Window;
            this.Text_EncPos_Z.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_EncPos_Z.ForeColor = System.Drawing.Color.Black;
            this.Text_EncPos_Z.Location = new System.Drawing.Point(174, 29);
            this.Text_EncPos_Z.MaxLength = 0;
            this.Text_EncPos_Z.Name = "Text_EncPos_Z";
            this.Text_EncPos_Z.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_EncPos_Z.Size = new System.Drawing.Size(52, 21);
            this.Text_EncPos_Z.TabIndex = 3;
            this.Text_EncPos_Z.Tag = "3";
            this.Text_EncPos_Z.Text = "0.000";
            this.Text_EncPos_Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Pos_Z
            // 
            this.Label_Pos_Z.AutoSize = true;
            this.Label_Pos_Z.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pos_Z.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Pos_Z.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Pos_Z.ForeColor = System.Drawing.Color.Blue;
            this.Label_Pos_Z.Location = new System.Drawing.Point(184, 13);
            this.Label_Pos_Z.Name = "Label_Pos_Z";
            this.Label_Pos_Z.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Pos_Z.Size = new System.Drawing.Size(35, 12);
            this.Label_Pos_Z.TabIndex = 247;
            this.Label_Pos_Z.Text = "Z(mm)";
            this.Label_Pos_Z.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_EncPos_Y
            // 
            this.Text_EncPos_Y.AcceptsReturn = true;
            this.Text_EncPos_Y.BackColor = System.Drawing.SystemColors.Window;
            this.Text_EncPos_Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_EncPos_Y.ForeColor = System.Drawing.Color.Black;
            this.Text_EncPos_Y.Location = new System.Drawing.Point(116, 29);
            this.Text_EncPos_Y.MaxLength = 0;
            this.Text_EncPos_Y.Name = "Text_EncPos_Y";
            this.Text_EncPos_Y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_EncPos_Y.Size = new System.Drawing.Size(52, 21);
            this.Text_EncPos_Y.TabIndex = 2;
            this.Text_EncPos_Y.Tag = "2";
            this.Text_EncPos_Y.Text = "0.000";
            this.Text_EncPos_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Pos_Y
            // 
            this.Label_Pos_Y.AutoSize = true;
            this.Label_Pos_Y.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pos_Y.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Pos_Y.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Pos_Y.ForeColor = System.Drawing.Color.Blue;
            this.Label_Pos_Y.Location = new System.Drawing.Point(126, 13);
            this.Label_Pos_Y.Name = "Label_Pos_Y";
            this.Label_Pos_Y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Pos_Y.Size = new System.Drawing.Size(35, 12);
            this.Label_Pos_Y.TabIndex = 245;
            this.Label_Pos_Y.Text = "Y(mm)";
            this.Label_Pos_Y.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Text_EncPos_X
            // 
            this.Text_EncPos_X.AcceptsReturn = true;
            this.Text_EncPos_X.BackColor = System.Drawing.SystemColors.Window;
            this.Text_EncPos_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_EncPos_X.ForeColor = System.Drawing.Color.Black;
            this.Text_EncPos_X.Location = new System.Drawing.Point(58, 29);
            this.Text_EncPos_X.MaxLength = 0;
            this.Text_EncPos_X.Name = "Text_EncPos_X";
            this.Text_EncPos_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_EncPos_X.Size = new System.Drawing.Size(52, 21);
            this.Text_EncPos_X.TabIndex = 1;
            this.Text_EncPos_X.Tag = "1";
            this.Text_EncPos_X.Text = "0.000";
            this.Text_EncPos_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Pos_X
            // 
            this.Label_Pos_X.AutoSize = true;
            this.Label_Pos_X.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pos_X.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Pos_X.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Pos_X.ForeColor = System.Drawing.Color.Blue;
            this.Label_Pos_X.Location = new System.Drawing.Point(68, 13);
            this.Label_Pos_X.Name = "Label_Pos_X";
            this.Label_Pos_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Pos_X.Size = new System.Drawing.Size(35, 12);
            this.Label_Pos_X.TabIndex = 243;
            this.Label_Pos_X.Text = "X(mm)";
            this.Label_Pos_X.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.Btn_SavePos);
            this.TabPage5.Controls.Add(this.Btn_DeletePos);
            this.TabPage5.Controls.Add(this.DataGridView1);
            this.TabPage5.Location = new System.Drawing.Point(4, 34);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(478, 294);
            this.TabPage5.TabIndex = 2;
            this.TabPage5.Text = "点数据";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // Btn_SavePos
            // 
            this.Btn_SavePos.Location = new System.Drawing.Point(408, 260);
            this.Btn_SavePos.Name = "Btn_SavePos";
            this.Btn_SavePos.Size = new System.Drawing.Size(55, 30);
            this.Btn_SavePos.TabIndex = 210;
            this.Btn_SavePos.Tag = "";
            this.Btn_SavePos.Text = "保存";
            this.Btn_SavePos.UseVisualStyleBackColor = true;
            this.Btn_SavePos.Click += new System.EventHandler(this.Btn_SavePos_Click);
            // 
            // Btn_DeletePos
            // 
            this.Btn_DeletePos.Location = new System.Drawing.Point(17, 260);
            this.Btn_DeletePos.Name = "Btn_DeletePos";
            this.Btn_DeletePos.Size = new System.Drawing.Size(55, 30);
            this.Btn_DeletePos.TabIndex = 209;
            this.Btn_DeletePos.Tag = "";
            this.Btn_DeletePos.Text = "删除";
            this.Btn_DeletePos.UseVisualStyleBackColor = true;
            this.Btn_DeletePos.Click += new System.EventHandler(this.Btn_DeletePos_Click);
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 20;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.mName,
            this.TeachAxis1,
            this.TeachAxis2,
            this.TeachAxis3,
            this.TeachAxis4});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.GridColor = System.Drawing.Color.Blue;
            this.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView1.RowHeadersWidth = 25;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(478, 258);
            this.DataGridView1.TabIndex = 208;
            // 
            // Index
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Index.DefaultCellStyle = dataGridViewCellStyle3;
            this.Index.HeaderText = "编号";
            this.Index.Name = "Index";
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 36;
            // 
            // mName
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.mName.DefaultCellStyle = dataGridViewCellStyle4;
            this.mName.HeaderText = "名称";
            this.mName.Name = "mName";
            this.mName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mName.Width = 124;
            // 
            // TeachAxis1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0";
            this.TeachAxis1.DefaultCellStyle = dataGridViewCellStyle5;
            this.TeachAxis1.HeaderText = "X";
            this.TeachAxis1.Name = "TeachAxis1";
            this.TeachAxis1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachAxis1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeachAxis1.Width = 68;
            // 
            // TeachAxis2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = "0";
            this.TeachAxis2.DefaultCellStyle = dataGridViewCellStyle6;
            this.TeachAxis2.HeaderText = "Y";
            this.TeachAxis2.Name = "TeachAxis2";
            this.TeachAxis2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachAxis2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeachAxis2.Width = 68;
            // 
            // TeachAxis3
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = "0";
            this.TeachAxis3.DefaultCellStyle = dataGridViewCellStyle7;
            this.TeachAxis3.HeaderText = "Z";
            this.TeachAxis3.Name = "TeachAxis3";
            this.TeachAxis3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachAxis3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeachAxis3.Width = 68;
            // 
            // TeachAxis4
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = "0";
            this.TeachAxis4.DefaultCellStyle = dataGridViewCellStyle8;
            this.TeachAxis4.HeaderText = "R";
            this.TeachAxis4.Name = "TeachAxis4";
            this.TeachAxis4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachAxis4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TeachAxis4.Width = 68;
            // 
            // Teach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TabControl);
            this.Name = "Teach";
            this.Size = new System.Drawing.Size(486, 332);
            this.Load += new System.EventHandler(this.Teach_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.Teach_XYZR.ResumeLayout(false);
            this.Teach_XYZR.PerformLayout();
            this.Move_Distance.ResumeLayout(false);
            this.Move_Distance.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label11;
		internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape27;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape26;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape25;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape24;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape23;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape22;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape21;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape20;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape19;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape18;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape17;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape16;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape15;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape14;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape13;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape12;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape11;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape10;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape9;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape8;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape7;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape6;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape5;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape4;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape3;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape2;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape1;
		internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape0;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Button Btn_Home_R;
		internal System.Windows.Forms.Button Btn_Home_X;
		internal System.Windows.Forms.Button Btn_Home_Y;
		internal System.Windows.Forms.Button Btn_Home_Z;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button Btn_Servo_R;
		internal System.Windows.Forms.Button Btn_Servo_Z;
		internal System.Windows.Forms.Button Btn_Servo_Y;
		internal System.Windows.Forms.Button Btn_Servo_X;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.Button Btn_AddPos;
		internal System.Windows.Forms.ComboBox ComBox_PosList;
		internal System.Windows.Forms.TabPage TabPage4;
		public System.Windows.Forms.Label Label23;
		public System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.Button Btn_Go;
		internal System.Windows.Forms.ComboBox ComBox_CMD;
		internal System.Windows.Forms.ComboBox ComBox_Aim;
		internal System.Windows.Forms.GroupBox Teach_XYZR;
		public System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.ComboBox ComBox_Speed;
		public System.Windows.Forms.Button RDec;
		public System.Windows.Forms.Button RAdd;
		public System.Windows.Forms.Button ZAdd;
		public System.Windows.Forms.Button ZDec;
		public System.Windows.Forms.Button YDec;
		public System.Windows.Forms.Button YAdd;
		public System.Windows.Forms.Button XDec;
		public System.Windows.Forms.Button XAdd;
		internal System.Windows.Forms.GroupBox Move_Distance;
		internal System.Windows.Forms.RadioButton mDinYi;
		internal System.Windows.Forms.RadioButton mLianXu;
		internal System.Windows.Forms.RadioButton SmallDist;
		internal System.Windows.Forms.RadioButton MidDist;
		internal System.Windows.Forms.RadioButton LongDist;
		public System.Windows.Forms.TextBox Text_Dist_R;
		public System.Windows.Forms.Label ALabel4;
		public System.Windows.Forms.TextBox Text_Dist_Z;
		public System.Windows.Forms.Label ALabel3;
		public System.Windows.Forms.TextBox Text_Dist_Y;
		public System.Windows.Forms.Label ALabel2;
		public System.Windows.Forms.TextBox Text_Dist_X;
		public System.Windows.Forms.Label ALabel1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.TextBox Text_PrfPos_R;
		public System.Windows.Forms.TextBox Text_PrfPos_Z;
		public System.Windows.Forms.TextBox Text_PrfPos_Y;
		public System.Windows.Forms.TextBox Text_PrfPos_X;
		public System.Windows.Forms.TextBox Text_EncPos_R;
		public System.Windows.Forms.Label Label_Pos_R;
		public System.Windows.Forms.TextBox Text_EncPos_Z;
		public System.Windows.Forms.Label Label_Pos_Z;
		public System.Windows.Forms.TextBox Text_EncPos_Y;
		public System.Windows.Forms.Label Label_Pos_Y;
		public System.Windows.Forms.TextBox Text_EncPos_X;
		public System.Windows.Forms.Label Label_Pos_X;
		internal System.Windows.Forms.TabPage TabPage5;
		internal System.Windows.Forms.Button Btn_SavePos;
		internal System.Windows.Forms.Button Btn_DeletePos;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Index;
		internal System.Windows.Forms.DataGridViewTextBoxColumn mName;
		internal System.Windows.Forms.DataGridViewTextBoxColumn TeachAxis1;
		internal System.Windows.Forms.DataGridViewTextBoxColumn TeachAxis2;
		internal System.Windows.Forms.DataGridViewTextBoxColumn TeachAxis3;
		internal System.Windows.Forms.DataGridViewTextBoxColumn TeachAxis4;
        public System.Windows.Forms.Label Label_AName;
		public System.Windows.Forms.TabControl TabControl;
        //internal System.Windows.Forms.Timer Timer = new Timer() { Interval = 50, Enabled = false };
        internal System.Timers.Timer Timer = new System.Timers.Timer() { AutoReset = true, Interval = 10, Enabled = false };
        internal DataGridView DataGridView1; 
	}
	
}
