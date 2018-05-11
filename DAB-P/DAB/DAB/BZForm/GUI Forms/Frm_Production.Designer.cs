
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
	partial class Frm_Production : System.Windows.Forms.Form
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
        private System.ComponentModel.IContainer components = null;

		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Production));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_A = new BoTech.Button();
            this.BTN_Y = new BoTech.Button();
            this.BTN_CC = new BoTech.Button();
            this.BTN_X = new BoTech.Button();
            this.Chart_CheckData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PB_Right2 = new System.Windows.Forms.PictureBox();
            this.Lbl_EndTime = new System.Windows.Forms.Label();
            this.Lbl_StartTime = new System.Windows.Forms.Label();
            this.Panel1 = new BoTech.Panel();
            this.buttonStop = new BoTech.Button();
            this.buttonStart = new BoTech.Button();
            this.chartForce = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cpk_X = new BoTech.Button();
            this.Panel2 = new BoTech.Panel();
            this.Btn_Retest = new BoTech.Button();
            this.Btn_Yield = new BoTech.Button();
            this.DRB_YieldRetest = new BoTech.DoubleRoundBar();
            this.Panel3 = new BoTech.Panel();
            this.Cpk_A = new BoTech.Button();
            this.Cpk_Y = new BoTech.Button();
            this.Cpk_CC = new BoTech.Button();
            this.Label_CPK = new BoTech.Label();
            this.Panel4 = new BoTech.Panel();
            this.Panel5 = new BoTech.Panel();
            this.Label3 = new BoTech.Label();
            this.AlarmStatus = new BoTech.Label();
            this.AlarmTime = new BoTech.Label();
            this.UPH = new BoTech.Label();
            this.MaterialLevel = new BoTech.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_CheckData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right2)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForce)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea2";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(3, 79);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea2";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(322, 230);
            this.Chart1.TabIndex = 23;
            this.Chart1.Text = "Chart_Cpk";
            // 
            // BTN_A
            // 
            this.BTN_A.BZ_BackColor = System.Drawing.Color.LightGray;
            this.BTN_A.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.BTN_A.BZ_Radius = 11;
            this.BTN_A.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.BTN_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_A.ForeColor = System.Drawing.Color.Black;
            this.BTN_A.Location = new System.Drawing.Point(605, 216);
            this.BTN_A.Name = "BTN_A";
            this.BTN_A.Size = new System.Drawing.Size(60, 60);
            this.BTN_A.TabIndex = 30;
            this.BTN_A.Text = "θ";
            this.BTN_A.UseVisualStyleBackColor = true;
            this.BTN_A.Click += new System.EventHandler(this.BTN_X_Click);
            // 
            // BTN_Y
            // 
            this.BTN_Y.BZ_BackColor = System.Drawing.Color.LightGray;
            this.BTN_Y.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.BTN_Y.BZ_Radius = 11;
            this.BTN_Y.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.BTN_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Y.ForeColor = System.Drawing.Color.Black;
            this.BTN_Y.Location = new System.Drawing.Point(605, 76);
            this.BTN_Y.Name = "BTN_Y";
            this.BTN_Y.Size = new System.Drawing.Size(60, 60);
            this.BTN_Y.TabIndex = 28;
            this.BTN_Y.Text = "Y";
            this.BTN_Y.UseVisualStyleBackColor = true;
            this.BTN_Y.Click += new System.EventHandler(this.BTN_X_Click);
            // 
            // BTN_CC
            // 
            this.BTN_CC.BZ_BackColor = System.Drawing.Color.LightGray;
            this.BTN_CC.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.BTN_CC.BZ_Radius = 11;
            this.BTN_CC.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.BTN_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CC.ForeColor = System.Drawing.Color.Black;
            this.BTN_CC.Location = new System.Drawing.Point(605, 146);
            this.BTN_CC.Name = "BTN_CC";
            this.BTN_CC.Size = new System.Drawing.Size(60, 60);
            this.BTN_CC.TabIndex = 29;
            this.BTN_CC.Text = "CC";
            this.BTN_CC.UseVisualStyleBackColor = true;
            this.BTN_CC.Click += new System.EventHandler(this.BTN_X_Click);
            // 
            // BTN_X
            // 
            this.BTN_X.BZ_BackColor = System.Drawing.Color.LightGray;
            this.BTN_X.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.BTN_X.BZ_Radius = 11;
            this.BTN_X.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.BTN_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_X.ForeColor = System.Drawing.Color.Black;
            this.BTN_X.Location = new System.Drawing.Point(605, 6);
            this.BTN_X.Name = "BTN_X";
            this.BTN_X.Size = new System.Drawing.Size(60, 60);
            this.BTN_X.TabIndex = 25;
            this.BTN_X.Text = "X";
            this.BTN_X.UseVisualStyleBackColor = true;
            this.BTN_X.Click += new System.EventHandler(this.BTN_X_Click);
            // 
            // Chart_CheckData
            // 
            this.Chart_CheckData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.Chart_CheckData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_CheckData.Legends.Add(legend2);
            this.Chart_CheckData.Location = new System.Drawing.Point(-24, 26);
            this.Chart_CheckData.Name = "Chart_CheckData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.Blue;
            this.Chart_CheckData.Series.Add(series2);
            this.Chart_CheckData.Size = new System.Drawing.Size(662, 263);
            this.Chart_CheckData.TabIndex = 13;
            this.Chart_CheckData.TabStop = false;
            this.Chart_CheckData.Text = "Chart1";
            // 
            // PB_Right2
            // 
            this.PB_Right2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PB_Right2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Right2.BackgroundImage")));
            this.PB_Right2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Right2.Location = new System.Drawing.Point(98, 151);
            this.PB_Right2.Name = "PB_Right2";
            this.PB_Right2.Size = new System.Drawing.Size(20, 20);
            this.PB_Right2.TabIndex = 29;
            this.PB_Right2.TabStop = false;
            // 
            // Lbl_EndTime
            // 
            this.Lbl_EndTime.AutoSize = true;
            this.Lbl_EndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Lbl_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Lbl_EndTime.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndTime.Location = new System.Drawing.Point(43, 163);
            this.Lbl_EndTime.Name = "Lbl_EndTime";
            this.Lbl_EndTime.Size = new System.Drawing.Size(41, 12);
            this.Lbl_EndTime.TabIndex = 6;
            this.Lbl_EndTime.Text = "10/01/16";
            // 
            // Lbl_StartTime
            // 
            this.Lbl_StartTime.AutoSize = true;
            this.Lbl_StartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Lbl_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Lbl_StartTime.ForeColor = System.Drawing.Color.Black;
            this.Lbl_StartTime.Location = new System.Drawing.Point(43, 151);
            this.Lbl_StartTime.Name = "Lbl_StartTime";
            this.Lbl_StartTime.Size = new System.Drawing.Size(41, 12);
            this.Lbl_StartTime.TabIndex = 5;
            this.Lbl_StartTime.Text = "06/09/16";
            // 
            // Panel1
            // 
            this.Panel1.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel1.BZ_Radius = 11;
            this.Panel1.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel1.Controls.Add(this.buttonStop);
            this.Panel1.Controls.Add(this.buttonStart);
            this.Panel1.Controls.Add(this.chartForce);
            this.Panel1.Location = new System.Drawing.Point(3, 365);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(680, 290);
            this.Panel1.TabIndex = 11;
            // 
            // buttonStop
            // 
            this.buttonStop.BZ_BackColor = System.Drawing.Color.LightGray;
            this.buttonStop.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.buttonStop.BZ_Radius = 11;
            this.buttonStop.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(614, 149);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(60, 60);
            this.buttonStop.TabIndex = 32;
            this.buttonStop.Text = "θ";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BZ_BackColor = System.Drawing.Color.LightGray;
            this.buttonStart.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.buttonStart.BZ_Radius = 11;
            this.buttonStart.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(614, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(60, 60);
            this.buttonStart.TabIndex = 31;
            this.buttonStart.Text = "CC";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartForce
            // 
            chartArea3.AxisX.Interval = 50D;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.Maximum = 150D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Interval = 1D;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.Maximum = 5D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea";
            this.chartForce.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartForce.Legends.Add(legend3);
            this.chartForce.Location = new System.Drawing.Point(12, 14);
            this.chartForce.Name = "chartForce";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "pressure";
            this.chartForce.Series.Add(series3);
            this.chartForce.Size = new System.Drawing.Size(586, 264);
            this.chartForce.TabIndex = 24;
            // 
            // Cpk_X
            // 
            this.Cpk_X.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Cpk_X.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Cpk_X.BZ_Radius = 11;
            this.Cpk_X.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Cpk_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpk_X.ForeColor = System.Drawing.Color.Black;
            this.Cpk_X.Location = new System.Drawing.Point(15, 10);
            this.Cpk_X.Name = "Cpk_X";
            this.Cpk_X.Size = new System.Drawing.Size(60, 60);
            this.Cpk_X.TabIndex = 24;
            this.Cpk_X.Text = "X";
            this.Cpk_X.UseVisualStyleBackColor = true;
            this.Cpk_X.Click += new System.EventHandler(this.Cpk_X_Click);
            // 
            // Panel2
            // 
            this.Panel2.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel2.BZ_Radius = 11;
            this.Panel2.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel2.Controls.Add(this.Btn_Retest);
            this.Panel2.Controls.Add(this.Btn_Yield);
            this.Panel2.Controls.Add(this.PB_Right2);
            this.Panel2.Controls.Add(this.Lbl_StartTime);
            this.Panel2.Controls.Add(this.Lbl_EndTime);
            this.Panel2.Controls.Add(this.DRB_YieldRetest);
            this.Panel2.Location = new System.Drawing.Point(688, 365);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(328, 290);
            this.Panel2.TabIndex = 12;
            // 
            // Btn_Retest
            // 
            this.Btn_Retest.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_Retest.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Retest.BZ_Radius = 11;
            this.Btn_Retest.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Retest.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Retest.ForeColor = System.Drawing.Color.Black;
            this.Btn_Retest.Location = new System.Drawing.Point(213, 200);
            this.Btn_Retest.Name = "Btn_Retest";
            this.Btn_Retest.Size = new System.Drawing.Size(60, 60);
            this.Btn_Retest.TabIndex = 27;
            this.Btn_Retest.Text = "Retest";
            this.Btn_Retest.UseVisualStyleBackColor = true;
            this.Btn_Retest.Click += new System.EventHandler(this.Btn_Retest_Click);
            // 
            // Btn_Yield
            // 
            this.Btn_Yield.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_Yield.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Yield.BZ_Radius = 11;
            this.Btn_Yield.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Yield.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Yield.ForeColor = System.Drawing.Color.Black;
            this.Btn_Yield.Location = new System.Drawing.Point(72, 200);
            this.Btn_Yield.Name = "Btn_Yield";
            this.Btn_Yield.Size = new System.Drawing.Size(60, 60);
            this.Btn_Yield.TabIndex = 26;
            this.Btn_Yield.Text = "Yield";
            this.Btn_Yield.UseVisualStyleBackColor = true;
            this.Btn_Yield.Click += new System.EventHandler(this.Btn_Yield_Click);
            // 
            // DRB_YieldRetest
            // 
            this.DRB_YieldRetest.BZ_NGColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(6)))));
            this.DRB_YieldRetest.BZ_NgRateDay = 4;
            this.DRB_YieldRetest.BZ_NgRateMonth = 2;
            this.DRB_YieldRetest.BZ_OKColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(64)))));
            this.DRB_YieldRetest.BZ_RateFont = new System.Drawing.Font("Verdana", 8F);
            this.DRB_YieldRetest.BZ_ResultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(64)))));
            this.DRB_YieldRetest.BZ_Resultradius = 30;
            this.DRB_YieldRetest.BZ_ResultText = "OK";
            this.DRB_YieldRetest.BZ_ResultTextColor = System.Drawing.Color.Black;
            this.DRB_YieldRetest.BZ_ResultTextFont = new System.Drawing.Font("Verdana", 18F);
            this.DRB_YieldRetest.Font = new System.Drawing.Font("Verdana", 16F);
            this.DRB_YieldRetest.Location = new System.Drawing.Point(45, 19);
            this.DRB_YieldRetest.Name = "DRB_YieldRetest";
            this.DRB_YieldRetest.Size = new System.Drawing.Size(243, 175);
            this.DRB_YieldRetest.TabIndex = 30;
            this.DRB_YieldRetest.Text = "DoubleRoundBar1";
            this.DRB_YieldRetest.UseVisualStyleBackColor = true;
            // 
            // Panel3
            // 
            this.Panel3.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.BZ_Radius = 11;
            this.Panel3.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel3.Controls.Add(this.Cpk_A);
            this.Panel3.Controls.Add(this.Cpk_Y);
            this.Panel3.Controls.Add(this.Cpk_CC);
            this.Panel3.Controls.Add(this.Cpk_X);
            this.Panel3.Controls.Add(this.Label_CPK);
            this.Panel3.Controls.Add(this.Chart1);
            this.Panel3.Location = new System.Drawing.Point(688, 2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(328, 357);
            this.Panel3.TabIndex = 13;
            // 
            // Cpk_A
            // 
            this.Cpk_A.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Cpk_A.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Cpk_A.BZ_Radius = 11;
            this.Cpk_A.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Cpk_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpk_A.ForeColor = System.Drawing.Color.Black;
            this.Cpk_A.Location = new System.Drawing.Point(258, 10);
            this.Cpk_A.Name = "Cpk_A";
            this.Cpk_A.Size = new System.Drawing.Size(60, 60);
            this.Cpk_A.TabIndex = 27;
            this.Cpk_A.Text = "θ";
            this.Cpk_A.UseVisualStyleBackColor = true;
            this.Cpk_A.Click += new System.EventHandler(this.Cpk_X_Click);
            // 
            // Cpk_Y
            // 
            this.Cpk_Y.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Cpk_Y.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Cpk_Y.BZ_Radius = 11;
            this.Cpk_Y.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Cpk_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpk_Y.ForeColor = System.Drawing.Color.Black;
            this.Cpk_Y.Location = new System.Drawing.Point(96, 10);
            this.Cpk_Y.Name = "Cpk_Y";
            this.Cpk_Y.Size = new System.Drawing.Size(60, 60);
            this.Cpk_Y.TabIndex = 25;
            this.Cpk_Y.Text = "Y";
            this.Cpk_Y.UseVisualStyleBackColor = true;
            this.Cpk_Y.Click += new System.EventHandler(this.Cpk_X_Click);
            // 
            // Cpk_CC
            // 
            this.Cpk_CC.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Cpk_CC.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Cpk_CC.BZ_Radius = 11;
            this.Cpk_CC.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Cpk_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpk_CC.ForeColor = System.Drawing.Color.Black;
            this.Cpk_CC.Location = new System.Drawing.Point(177, 10);
            this.Cpk_CC.Name = "Cpk_CC";
            this.Cpk_CC.Size = new System.Drawing.Size(60, 60);
            this.Cpk_CC.TabIndex = 26;
            this.Cpk_CC.Text = "CC";
            this.Cpk_CC.UseVisualStyleBackColor = true;
            this.Cpk_CC.Click += new System.EventHandler(this.Cpk_X_Click);
            // 
            // Label_CPK
            // 
            this.Label_CPK.BZ_BigText = "CPK 1.6";
            this.Label_CPK.BZ_BigTextFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPK.BZ_BigTextOffset = 0;
            this.Label_CPK.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_CPK.BZ_Radius = 11;
            this.Label_CPK.BZ_RoundStyle = BoTech.Label.RoundStyle.All;
            this.Label_CPK.BZ_ShowMode = false;
            this.Label_CPK.BZ_SmallText = "Count 140";
            this.Label_CPK.BZ_SmallTextFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPK.BZ_SmallTextOffset = 5;
            this.Label_CPK.Location = new System.Drawing.Point(110, 315);
            this.Label_CPK.Name = "Label_CPK";
            this.Label_CPK.Size = new System.Drawing.Size(102, 36);
            this.Label_CPK.TabIndex = 24;
            this.Label_CPK.Text = "Label2";
            // 
            // Panel4
            // 
            this.Panel4.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel4.BZ_Radius = 11;
            this.Panel4.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel4.Controls.Add(this.Panel5);
            this.Panel4.Location = new System.Drawing.Point(3, 67);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(680, 292);
            this.Panel4.TabIndex = 0;
            // 
            // Panel5
            // 
            this.Panel5.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel5.BZ_Radius = 60;
            this.Panel5.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel5.Controls.Add(this.Label3);
            this.Panel5.Controls.Add(this.BTN_A);
            this.Panel5.Controls.Add(this.BTN_Y);
            this.Panel5.Controls.Add(this.BTN_CC);
            this.Panel5.Controls.Add(this.BTN_X);
            this.Panel5.Controls.Add(this.Chart_CheckData);
            this.Panel5.Location = new System.Drawing.Point(9, 3);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(668, 279);
            this.Panel5.TabIndex = 24;
            // 
            // Label3
            // 
            this.Label3.BZ_BigText = "BigText";
            this.Label3.BZ_BigTextFont = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.BZ_BigTextOffset = 0;
            this.Label3.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label3.BZ_Radius = 11;
            this.Label3.BZ_RoundStyle = BoTech.Label.RoundStyle.All;
            this.Label3.BZ_ShowMode = true;
            this.Label3.BZ_SmallText = "SmallText";
            this.Label3.BZ_SmallTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.BZ_SmallTextOffset = 15;
            this.Label3.Location = new System.Drawing.Point(71, 6);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(133, 33);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "CheckData";
            // 
            // AlarmStatus
            // 
            this.AlarmStatus.BZ_BigText = "BigText";
            this.AlarmStatus.BZ_BigTextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatus.BZ_BigTextOffset = 0;
            this.AlarmStatus.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.AlarmStatus.BZ_Radius = 11;
            this.AlarmStatus.BZ_RoundStyle = BoTech.Label.RoundStyle.All;
            this.AlarmStatus.BZ_ShowMode = true;
            this.AlarmStatus.BZ_SmallText = "SmallText";
            this.AlarmStatus.BZ_SmallTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatus.BZ_SmallTextOffset = 15;
            this.AlarmStatus.Location = new System.Drawing.Point(3, 2);
            this.AlarmStatus.Name = "AlarmStatus";
            this.AlarmStatus.Size = new System.Drawing.Size(125, 60);
            this.AlarmStatus.TabIndex = 24;
            this.AlarmStatus.Text = "No Alarm";
            // 
            // AlarmTime
            // 
            this.AlarmTime.BZ_BigText = "BigText";
            this.AlarmTime.BZ_BigTextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTime.BZ_BigTextOffset = 0;
            this.AlarmTime.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.AlarmTime.BZ_Radius = 11;
            this.AlarmTime.BZ_RoundStyle = BoTech.Label.RoundStyle.All;
            this.AlarmTime.BZ_ShowMode = false;
            this.AlarmTime.BZ_SmallText = "SmallText";
            this.AlarmTime.BZ_SmallTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTime.BZ_SmallTextOffset = 15;
            this.AlarmTime.Location = new System.Drawing.Point(133, 2);
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.Size = new System.Drawing.Size(125, 60);
            this.AlarmTime.TabIndex = 24;
            this.AlarmTime.Text = "Label2";
            // 
            // UPH
            // 
            this.UPH.BZ_BigText = "BigText";
            this.UPH.BZ_BigTextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPH.BZ_BigTextOffset = 0;
            this.UPH.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.UPH.BZ_Radius = 11;
            this.UPH.BZ_RoundStyle = BoTech.Label.RoundStyle.All;
            this.UPH.BZ_ShowMode = false;
            this.UPH.BZ_SmallText = "SmallText";
            this.UPH.BZ_SmallTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPH.BZ_SmallTextOffset = 15;
            this.UPH.Location = new System.Drawing.Point(263, 2);
            this.UPH.Name = "UPH";
            this.UPH.Size = new System.Drawing.Size(60, 60);
            this.UPH.TabIndex = 24;
            this.UPH.Text = "Label2";
            // 
            // MaterialLevel
            // 
            this.MaterialLevel.BZ_BigText = "BigText";
            this.MaterialLevel.BZ_BigTextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLevel.BZ_BigTextOffset = 0;
            this.MaterialLevel.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.MaterialLevel.BZ_Radius = 11;
            this.MaterialLevel.BZ_RoundStyle = BoTech.Label.RoundStyle.All;
            this.MaterialLevel.BZ_ShowMode = false;
            this.MaterialLevel.BZ_SmallText = "SmallText";
            this.MaterialLevel.BZ_SmallTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLevel.BZ_SmallTextOffset = 15;
            this.MaterialLevel.Location = new System.Drawing.Point(328, 2);
            this.MaterialLevel.Name = "MaterialLevel";
            this.MaterialLevel.Size = new System.Drawing.Size(160, 60);
            this.MaterialLevel.TabIndex = 24;
            this.MaterialLevel.Text = "Label4";
            // 
            // Frm_Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MaterialLevel);
            this.Controls.Add(this.UPH);
            this.Controls.Add(this.AlarmTime);
            this.Controls.Add(this.AlarmStatus);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Production";
            this.ShowInTaskbar = false;
            this.Text = "Frm_Home";
            this.Load += new System.EventHandler(this.Frm_Production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_CheckData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right2)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartForce)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		internal System.Windows.Forms.PictureBox PB_Right2;
		internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_CheckData;
        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        internal BoTech.Panel Panel1;
		internal BoTech.Panel Panel2;
		internal BoTech.Panel Panel3;
		internal BoTech.Label Label_CPK;
		internal BoTech.Button Cpk_X;
		internal BoTech.Button Cpk_Y;
		internal BoTech.Button Cpk_A;
		internal BoTech.Button Cpk_CC;
		internal BoTech.Button BTN_A;
		internal BoTech.Button BTN_Y;
		internal BoTech.Button BTN_CC;
		internal BoTech.Button BTN_X;
		internal BoTech.Panel Panel4;
		internal BoTech.Label Label3;
		internal BoTech.Button Btn_Yield;
        internal BoTech.Button Btn_Retest;
		internal BoTech.Panel Panel5;
		internal BoTech.Label AlarmStatus;
        internal BoTech.Label AlarmTime;
		internal BoTech.Label MaterialLevel;
        internal Label Lbl_EndTime;
        internal Label Lbl_StartTime;
        internal BoTech.DoubleRoundBar DRB_YieldRetest;
        internal BoTech.Label UPH;
       
        public System.Windows.Forms.DataVisualization.Charting.Chart chartForce;
        internal BoTech.Button buttonStop;
        internal BoTech.Button buttonStart;
	}
	
}
