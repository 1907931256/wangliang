
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
	partial class MotorStatus : System.Windows.Forms.UserControl
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
            this.Frame_MotorStaus = new System.Windows.Forms.GroupBox();
            this.R_Axis_Name = new System.Windows.Forms.Label();
            this.Z_Axis_Name = new System.Windows.Forms.Label();
            this.Y_Axis_Name = new System.Windows.Forms.Label();
            this.X_Axis_Name = new System.Windows.Forms.Label();
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
            this.Frame_MotorStaus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame_MotorStaus
            // 
            this.Frame_MotorStaus.BackColor = System.Drawing.Color.White;
            this.Frame_MotorStaus.Controls.Add(this.R_Axis_Name);
            this.Frame_MotorStaus.Controls.Add(this.Z_Axis_Name);
            this.Frame_MotorStaus.Controls.Add(this.Y_Axis_Name);
            this.Frame_MotorStaus.Controls.Add(this.X_Axis_Name);
            this.Frame_MotorStaus.Controls.Add(this.Label17);
            this.Frame_MotorStaus.Controls.Add(this.Label16);
            this.Frame_MotorStaus.Controls.Add(this.Label15);
            this.Frame_MotorStaus.Controls.Add(this.Label14);
            this.Frame_MotorStaus.Controls.Add(this.Label13);
            this.Frame_MotorStaus.Controls.Add(this.Label12);
            this.Frame_MotorStaus.Controls.Add(this.Label11);
            this.Frame_MotorStaus.Controls.Add(this.ShapeContainer1);
            this.Frame_MotorStaus.Location = new System.Drawing.Point(3, 0);
            this.Frame_MotorStaus.Name = "Frame_MotorStaus";
            this.Frame_MotorStaus.Size = new System.Drawing.Size(409, 150);
            this.Frame_MotorStaus.TabIndex = 260;
            this.Frame_MotorStaus.TabStop = false;
            this.Frame_MotorStaus.Tag = "0(0,1)(0,2)(0,3)(0,4)";
            this.Frame_MotorStaus.Text = "轴状态";
            // 
            // R_Axis_Name
            // 
            this.R_Axis_Name.AutoSize = true;
            this.R_Axis_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R_Axis_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.R_Axis_Name.Location = new System.Drawing.Point(4, 124);
            this.R_Axis_Name.Name = "R_Axis_Name";
            this.R_Axis_Name.Size = new System.Drawing.Size(28, 14);
            this.R_Axis_Name.TabIndex = 11;
            this.R_Axis_Name.Text = "轴4";
            // 
            // Z_Axis_Name
            // 
            this.Z_Axis_Name.AutoSize = true;
            this.Z_Axis_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Z_Axis_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Z_Axis_Name.Location = new System.Drawing.Point(4, 95);
            this.Z_Axis_Name.Name = "Z_Axis_Name";
            this.Z_Axis_Name.Size = new System.Drawing.Size(28, 14);
            this.Z_Axis_Name.TabIndex = 10;
            this.Z_Axis_Name.Text = "轴3";
            // 
            // Y_Axis_Name
            // 
            this.Y_Axis_Name.AutoSize = true;
            this.Y_Axis_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Y_Axis_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Y_Axis_Name.Location = new System.Drawing.Point(4, 66);
            this.Y_Axis_Name.Name = "Y_Axis_Name";
            this.Y_Axis_Name.Size = new System.Drawing.Size(28, 14);
            this.Y_Axis_Name.TabIndex = 9;
            this.Y_Axis_Name.Text = "轴2";
            // 
            // X_Axis_Name
            // 
            this.X_Axis_Name.AutoSize = true;
            this.X_Axis_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.X_Axis_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.X_Axis_Name.Location = new System.Drawing.Point(4, 37);
            this.X_Axis_Name.Name = "X_Axis_Name";
            this.X_Axis_Name.Size = new System.Drawing.Size(28, 14);
            this.X_Axis_Name.TabIndex = 8;
            this.X_Axis_Name.Tag = "(0,0)(0,0)(0,0)(0,0)";
            this.X_Axis_Name.Text = "轴1";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label17.Location = new System.Drawing.Point(365, 17);
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
            this.Label16.Location = new System.Drawing.Point(315, 17);
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
            this.Label15.Location = new System.Drawing.Point(272, 17);
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
            this.Label14.Location = new System.Drawing.Point(234, 17);
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
            this.Label13.Location = new System.Drawing.Point(184, 17);
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
            this.Label12.Location = new System.Drawing.Point(146, 17);
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
            this.Label11.Location = new System.Drawing.Point(101, 17);
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
            this.ShapeContainer1.Size = new System.Drawing.Size(403, 130);
            this.ShapeContainer1.TabIndex = 0;
            this.ShapeContainer1.TabStop = false;
            // 
            // OvalShape27
            // 
            this.OvalShape27.BorderColor = System.Drawing.Color.Black;
            this.OvalShape27.FillColor = System.Drawing.Color.White;
            this.OvalShape27.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape27.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape27.Location = new System.Drawing.Point(366, 106);
            this.OvalShape27.Name = "OvalShape27";
            this.OvalShape27.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape26
            // 
            this.OvalShape26.BorderColor = System.Drawing.Color.Black;
            this.OvalShape26.FillColor = System.Drawing.Color.White;
            this.OvalShape26.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape26.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape26.Location = new System.Drawing.Point(322, 107);
            this.OvalShape26.Name = "OvalShape26";
            this.OvalShape26.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape25
            // 
            this.OvalShape25.BorderColor = System.Drawing.Color.Black;
            this.OvalShape25.FillColor = System.Drawing.Color.White;
            this.OvalShape25.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape25.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape25.Location = new System.Drawing.Point(278, 107);
            this.OvalShape25.Name = "OvalShape25";
            this.OvalShape25.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape24
            // 
            this.OvalShape24.BorderColor = System.Drawing.Color.Black;
            this.OvalShape24.FillColor = System.Drawing.Color.White;
            this.OvalShape24.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape24.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape24.Location = new System.Drawing.Point(234, 107);
            this.OvalShape24.Name = "OvalShape24";
            this.OvalShape24.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape23
            // 
            this.OvalShape23.BorderColor = System.Drawing.Color.Black;
            this.OvalShape23.FillColor = System.Drawing.Color.White;
            this.OvalShape23.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape23.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape23.Location = new System.Drawing.Point(190, 107);
            this.OvalShape23.Name = "OvalShape23";
            this.OvalShape23.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape22
            // 
            this.OvalShape22.BorderColor = System.Drawing.Color.Black;
            this.OvalShape22.FillColor = System.Drawing.Color.White;
            this.OvalShape22.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape22.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape22.Location = new System.Drawing.Point(146, 107);
            this.OvalShape22.Name = "OvalShape22";
            this.OvalShape22.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape21
            // 
            this.OvalShape21.BorderColor = System.Drawing.Color.Black;
            this.OvalShape21.FillColor = System.Drawing.Color.White;
            this.OvalShape21.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape21.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape21.Location = new System.Drawing.Point(102, 106);
            this.OvalShape21.Name = "OvalShape21";
            this.OvalShape21.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape20
            // 
            this.OvalShape20.BorderColor = System.Drawing.Color.Black;
            this.OvalShape20.FillColor = System.Drawing.Color.White;
            this.OvalShape20.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape20.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape20.Location = new System.Drawing.Point(366, 77);
            this.OvalShape20.Name = "OvalShape20";
            this.OvalShape20.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape19
            // 
            this.OvalShape19.BorderColor = System.Drawing.Color.Black;
            this.OvalShape19.FillColor = System.Drawing.Color.White;
            this.OvalShape19.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape19.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape19.Location = new System.Drawing.Point(322, 78);
            this.OvalShape19.Name = "OvalShape19";
            this.OvalShape19.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape18
            // 
            this.OvalShape18.BorderColor = System.Drawing.Color.Black;
            this.OvalShape18.FillColor = System.Drawing.Color.White;
            this.OvalShape18.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape18.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape18.Location = new System.Drawing.Point(278, 78);
            this.OvalShape18.Name = "OvalShape18";
            this.OvalShape18.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape17
            // 
            this.OvalShape17.BorderColor = System.Drawing.Color.Black;
            this.OvalShape17.FillColor = System.Drawing.Color.White;
            this.OvalShape17.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape17.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape17.Location = new System.Drawing.Point(234, 78);
            this.OvalShape17.Name = "OvalShape17";
            this.OvalShape17.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape16
            // 
            this.OvalShape16.BorderColor = System.Drawing.Color.Black;
            this.OvalShape16.FillColor = System.Drawing.Color.White;
            this.OvalShape16.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape16.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape16.Location = new System.Drawing.Point(190, 78);
            this.OvalShape16.Name = "OvalShape16";
            this.OvalShape16.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape15
            // 
            this.OvalShape15.BorderColor = System.Drawing.Color.Black;
            this.OvalShape15.FillColor = System.Drawing.Color.White;
            this.OvalShape15.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape15.Location = new System.Drawing.Point(146, 78);
            this.OvalShape15.Name = "OvalShape15";
            this.OvalShape15.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape14
            // 
            this.OvalShape14.BorderColor = System.Drawing.Color.Black;
            this.OvalShape14.FillColor = System.Drawing.Color.White;
            this.OvalShape14.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape14.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape14.Location = new System.Drawing.Point(102, 77);
            this.OvalShape14.Name = "OvalShape14";
            this.OvalShape14.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape13
            // 
            this.OvalShape13.BorderColor = System.Drawing.Color.Black;
            this.OvalShape13.FillColor = System.Drawing.Color.White;
            this.OvalShape13.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape13.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape13.Location = new System.Drawing.Point(366, 46);
            this.OvalShape13.Name = "OvalShape13";
            this.OvalShape13.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape12
            // 
            this.OvalShape12.BorderColor = System.Drawing.Color.Black;
            this.OvalShape12.FillColor = System.Drawing.Color.White;
            this.OvalShape12.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape12.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape12.Location = new System.Drawing.Point(322, 47);
            this.OvalShape12.Name = "OvalShape12";
            this.OvalShape12.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape11
            // 
            this.OvalShape11.BorderColor = System.Drawing.Color.Black;
            this.OvalShape11.FillColor = System.Drawing.Color.White;
            this.OvalShape11.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape11.Location = new System.Drawing.Point(278, 47);
            this.OvalShape11.Name = "OvalShape11";
            this.OvalShape11.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape10
            // 
            this.OvalShape10.BorderColor = System.Drawing.Color.Black;
            this.OvalShape10.FillColor = System.Drawing.Color.White;
            this.OvalShape10.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape10.Location = new System.Drawing.Point(234, 47);
            this.OvalShape10.Name = "OvalShape10";
            this.OvalShape10.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape9
            // 
            this.OvalShape9.BorderColor = System.Drawing.Color.Black;
            this.OvalShape9.FillColor = System.Drawing.Color.White;
            this.OvalShape9.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape9.Location = new System.Drawing.Point(190, 47);
            this.OvalShape9.Name = "OvalShape9";
            this.OvalShape9.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape8
            // 
            this.OvalShape8.BorderColor = System.Drawing.Color.Black;
            this.OvalShape8.FillColor = System.Drawing.Color.White;
            this.OvalShape8.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape8.Location = new System.Drawing.Point(146, 47);
            this.OvalShape8.Name = "OvalShape8";
            this.OvalShape8.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape7
            // 
            this.OvalShape7.BorderColor = System.Drawing.Color.Black;
            this.OvalShape7.FillColor = System.Drawing.Color.White;
            this.OvalShape7.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape7.Location = new System.Drawing.Point(102, 46);
            this.OvalShape7.Name = "OvalShape7";
            this.OvalShape7.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape6
            // 
            this.OvalShape6.BorderColor = System.Drawing.Color.Black;
            this.OvalShape6.FillColor = System.Drawing.Color.White;
            this.OvalShape6.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape6.Location = new System.Drawing.Point(366, 18);
            this.OvalShape6.Name = "OvalShape6";
            this.OvalShape6.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape5
            // 
            this.OvalShape5.BorderColor = System.Drawing.Color.Black;
            this.OvalShape5.FillColor = System.Drawing.Color.White;
            this.OvalShape5.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape5.Location = new System.Drawing.Point(322, 19);
            this.OvalShape5.Name = "OvalShape5";
            this.OvalShape5.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape4
            // 
            this.OvalShape4.BorderColor = System.Drawing.Color.Black;
            this.OvalShape4.FillColor = System.Drawing.Color.White;
            this.OvalShape4.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape4.Location = new System.Drawing.Point(278, 19);
            this.OvalShape4.Name = "OvalShape4";
            this.OvalShape4.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape3
            // 
            this.OvalShape3.BorderColor = System.Drawing.Color.Black;
            this.OvalShape3.FillColor = System.Drawing.Color.White;
            this.OvalShape3.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape3.Location = new System.Drawing.Point(234, 19);
            this.OvalShape3.Name = "OvalShape3";
            this.OvalShape3.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape2
            // 
            this.OvalShape2.BorderColor = System.Drawing.Color.Black;
            this.OvalShape2.FillColor = System.Drawing.Color.White;
            this.OvalShape2.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape2.Location = new System.Drawing.Point(190, 19);
            this.OvalShape2.Name = "OvalShape2";
            this.OvalShape2.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape1
            // 
            this.OvalShape1.BorderColor = System.Drawing.Color.Black;
            this.OvalShape1.FillColor = System.Drawing.Color.White;
            this.OvalShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape1.Location = new System.Drawing.Point(146, 19);
            this.OvalShape1.Name = "OvalShape1";
            this.OvalShape1.Size = new System.Drawing.Size(16, 16);
            // 
            // OvalShape0
            // 
            this.OvalShape0.BorderColor = System.Drawing.Color.Black;
            this.OvalShape0.FillColor = System.Drawing.Color.White;
            this.OvalShape0.FillGradientColor = System.Drawing.Color.Transparent;
            this.OvalShape0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.OvalShape0.Location = new System.Drawing.Point(102, 18);
            this.OvalShape0.Name = "OvalShape0";
            this.OvalShape0.Size = new System.Drawing.Size(16, 16);
            // 
            // MotorStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Frame_MotorStaus);
            this.Name = "MotorStatus";
            this.Size = new System.Drawing.Size(417, 154);
            this.Tag = "(0,0)(0,0)(0,0)(0,0)";
            this.Load += new System.EventHandler(this.MotorStatus_Load);
            this.Frame_MotorStaus.ResumeLayout(false);
            this.Frame_MotorStaus.PerformLayout();
            this.ResumeLayout(false);

        }
		internal System.Windows.Forms.Label R_Axis_Name;
		internal System.Windows.Forms.Label Z_Axis_Name;
		internal System.Windows.Forms.Label Y_Axis_Name;
		internal System.Windows.Forms.Label X_Axis_Name;
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
        internal System.Timers.Timer Timer = new System.Timers.Timer() { AutoReset = true, Interval = 200, Enabled = false };
        public GroupBox Frame_MotorStaus; 
	}
	
}
