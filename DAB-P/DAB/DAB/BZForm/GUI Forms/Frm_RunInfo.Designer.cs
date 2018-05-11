
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
	partial class Frm_RunInfo : System.Windows.Forms.Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RoundPanel1 = new BZ.UI.RoundPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button_YeildDay_Jia = new System.Windows.Forms.Button();
            this.Button_YeildDay_Jian = new System.Windows.Forms.Button();
            this.TrackBar_yeild = new System.Windows.Forms.TrackBar();
            this.Chart_YieldOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RoundPanel2 = new BZ.UI.RoundPanel();
            this.Button_UPHDay_Jia = new System.Windows.Forms.Button();
            this.Button_UPHDay_Jian = new System.Windows.Forms.Button();
            this.TrackBar_uph = new System.Windows.Forms.TrackBar();
            this.Button_TossingDay_Jia = new System.Windows.Forms.Button();
            this.Button_TossingDay_Jian = new System.Windows.Forms.Button();
            this.TrackBar_tossing = new System.Windows.Forms.TrackBar();
            this.Chart_UPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_Tossing = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RoundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_yeild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_YieldOverview)).BeginInit();
            this.RoundPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_uph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_tossing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_UPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Tossing)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundPanel1
            // 
            this.RoundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RoundPanel1.BZ_AutoBkColor = true;
            this.RoundPanel1.BZ_Radius = ((byte)(6));
            this.RoundPanel1.BZ_Version = "V1.0.0";
            this.RoundPanel1.Controls.Add(this.Label1);
            this.RoundPanel1.Controls.Add(this.Button_YeildDay_Jia);
            this.RoundPanel1.Controls.Add(this.Button_YeildDay_Jian);
            this.RoundPanel1.Controls.Add(this.TrackBar_yeild);
            this.RoundPanel1.Controls.Add(this.Chart_YieldOverview);
            this.RoundPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel1.Location = new System.Drawing.Point(0, 3);
            this.RoundPanel1.Name = "RoundPanel1";
            this.RoundPanel1.Size = new System.Drawing.Size(1020, 320);
            this.RoundPanel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(479, 265);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 12);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Date:";
            // 
            // Button_YeildDay_Jia
            // 
            this.Button_YeildDay_Jia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_YeildDay_Jia.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_YeildDay_Jia.ForeColor = System.Drawing.Color.Black;
            this.Button_YeildDay_Jia.Location = new System.Drawing.Point(653, 276);
            this.Button_YeildDay_Jia.Name = "Button_YeildDay_Jia";
            this.Button_YeildDay_Jia.Size = new System.Drawing.Size(40, 30);
            this.Button_YeildDay_Jia.TabIndex = 1;
            this.Button_YeildDay_Jia.Text = "+";
            this.Button_YeildDay_Jia.UseVisualStyleBackColor = true;
            // 
            // Button_YeildDay_Jian
            // 
            this.Button_YeildDay_Jian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_YeildDay_Jian.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_YeildDay_Jian.ForeColor = System.Drawing.Color.Black;
            this.Button_YeildDay_Jian.Location = new System.Drawing.Point(298, 276);
            this.Button_YeildDay_Jian.Name = "Button_YeildDay_Jian";
            this.Button_YeildDay_Jian.Size = new System.Drawing.Size(40, 30);
            this.Button_YeildDay_Jian.TabIndex = 1;
            this.Button_YeildDay_Jian.Text = "-";
            this.Button_YeildDay_Jian.UseVisualStyleBackColor = true;
            // 
            // TrackBar_yeild
            // 
            this.TrackBar_yeild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TrackBar_yeild.Location = new System.Drawing.Point(346, 276);
            this.TrackBar_yeild.Maximum = 30;
            this.TrackBar_yeild.Minimum = 1;
            this.TrackBar_yeild.Name = "TrackBar_yeild";
            this.TrackBar_yeild.Size = new System.Drawing.Size(300, 45);
            this.TrackBar_yeild.TabIndex = 25;
            this.TrackBar_yeild.Value = 15;
            // 
            // Chart_YieldOverview
            // 
            this.Chart_YieldOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea1.Name = "ChartArea1";
            this.Chart_YieldOverview.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_YieldOverview.Legends.Add(legend1);
            this.Chart_YieldOverview.Location = new System.Drawing.Point(-34, 18);
            this.Chart_YieldOverview.Name = "Chart_YieldOverview";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_YieldOverview.Series.Add(series1);
            this.Chart_YieldOverview.Size = new System.Drawing.Size(1057, 261);
            this.Chart_YieldOverview.TabIndex = 14;
            this.Chart_YieldOverview.Text = "Chart1";
            // 
            // RoundPanel2
            // 
            this.RoundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RoundPanel2.BZ_AutoBkColor = true;
            this.RoundPanel2.BZ_Radius = ((byte)(6));
            this.RoundPanel2.BZ_Version = "V1.0.0";
            this.RoundPanel2.Controls.Add(this.Button_UPHDay_Jia);
            this.RoundPanel2.Controls.Add(this.Button_UPHDay_Jian);
            this.RoundPanel2.Controls.Add(this.TrackBar_uph);
            this.RoundPanel2.Controls.Add(this.Button_TossingDay_Jia);
            this.RoundPanel2.Controls.Add(this.Button_TossingDay_Jian);
            this.RoundPanel2.Controls.Add(this.TrackBar_tossing);
            this.RoundPanel2.Controls.Add(this.Chart_UPH);
            this.RoundPanel2.Controls.Add(this.Chart_Tossing);
            this.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel2.Location = new System.Drawing.Point(0, 329);
            this.RoundPanel2.Name = "RoundPanel2";
            this.RoundPanel2.Size = new System.Drawing.Size(1020, 329);
            this.RoundPanel2.TabIndex = 1;
            // 
            // Button_UPHDay_Jia
            // 
            this.Button_UPHDay_Jia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_UPHDay_Jia.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_UPHDay_Jia.ForeColor = System.Drawing.Color.Black;
            this.Button_UPHDay_Jia.Location = new System.Drawing.Point(915, 277);
            this.Button_UPHDay_Jia.Name = "Button_UPHDay_Jia";
            this.Button_UPHDay_Jia.Size = new System.Drawing.Size(40, 30);
            this.Button_UPHDay_Jia.TabIndex = 3;
            this.Button_UPHDay_Jia.Text = "+";
            this.Button_UPHDay_Jia.UseVisualStyleBackColor = true;
            // 
            // Button_UPHDay_Jian
            // 
            this.Button_UPHDay_Jian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_UPHDay_Jian.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_UPHDay_Jian.ForeColor = System.Drawing.Color.Black;
            this.Button_UPHDay_Jian.Location = new System.Drawing.Point(560, 277);
            this.Button_UPHDay_Jian.Name = "Button_UPHDay_Jian";
            this.Button_UPHDay_Jian.Size = new System.Drawing.Size(40, 30);
            this.Button_UPHDay_Jian.TabIndex = 3;
            this.Button_UPHDay_Jian.Text = "-";
            this.Button_UPHDay_Jian.UseVisualStyleBackColor = true;
            // 
            // TrackBar_uph
            // 
            this.TrackBar_uph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TrackBar_uph.Location = new System.Drawing.Point(608, 277);
            this.TrackBar_uph.Maximum = 30;
            this.TrackBar_uph.Minimum = 1;
            this.TrackBar_uph.Name = "TrackBar_uph";
            this.TrackBar_uph.Size = new System.Drawing.Size(300, 45);
            this.TrackBar_uph.TabIndex = 31;
            this.TrackBar_uph.Value = 15;
            // 
            // Button_TossingDay_Jia
            // 
            this.Button_TossingDay_Jia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_TossingDay_Jia.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_TossingDay_Jia.ForeColor = System.Drawing.Color.Black;
            this.Button_TossingDay_Jia.Location = new System.Drawing.Point(426, 277);
            this.Button_TossingDay_Jia.Name = "Button_TossingDay_Jia";
            this.Button_TossingDay_Jia.Size = new System.Drawing.Size(40, 30);
            this.Button_TossingDay_Jia.TabIndex = 2;
            this.Button_TossingDay_Jia.Text = "+";
            this.Button_TossingDay_Jia.UseVisualStyleBackColor = true;
            // 
            // Button_TossingDay_Jian
            // 
            this.Button_TossingDay_Jian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_TossingDay_Jian.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_TossingDay_Jian.ForeColor = System.Drawing.Color.Black;
            this.Button_TossingDay_Jian.Location = new System.Drawing.Point(71, 277);
            this.Button_TossingDay_Jian.Name = "Button_TossingDay_Jian";
            this.Button_TossingDay_Jian.Size = new System.Drawing.Size(40, 30);
            this.Button_TossingDay_Jian.TabIndex = 2;
            this.Button_TossingDay_Jian.Text = "-";
            this.Button_TossingDay_Jian.UseVisualStyleBackColor = true;
            // 
            // TrackBar_tossing
            // 
            this.TrackBar_tossing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TrackBar_tossing.Location = new System.Drawing.Point(119, 277);
            this.TrackBar_tossing.Maximum = 30;
            this.TrackBar_tossing.Minimum = 1;
            this.TrackBar_tossing.Name = "TrackBar_tossing";
            this.TrackBar_tossing.Size = new System.Drawing.Size(300, 45);
            this.TrackBar_tossing.TabIndex = 28;
            this.TrackBar_tossing.Value = 15;
            // 
            // Chart_UPH
            // 
            this.Chart_UPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea2.Name = "ChartArea1";
            this.Chart_UPH.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_UPH.Legends.Add(legend2);
            this.Chart_UPH.Location = new System.Drawing.Point(492, 21);
            this.Chart_UPH.Name = "Chart_UPH";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_UPH.Series.Add(series2);
            this.Chart_UPH.Size = new System.Drawing.Size(516, 256);
            this.Chart_UPH.TabIndex = 16;
            this.Chart_UPH.Text = "Chart2";
            // 
            // Chart_Tossing
            // 
            this.Chart_Tossing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea3.Name = "ChartArea1";
            this.Chart_Tossing.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart_Tossing.Legends.Add(legend3);
            this.Chart_Tossing.Location = new System.Drawing.Point(0, 21);
            this.Chart_Tossing.Name = "Chart_Tossing";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart_Tossing.Series.Add(series3);
            this.Chart_Tossing.Size = new System.Drawing.Size(516, 256);
            this.Chart_Tossing.TabIndex = 15;
            this.Chart_Tossing.Text = "Chart1";
            // 
            // Frm_RunInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.RoundPanel2);
            this.Controls.Add(this.RoundPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RunInfo";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Frm_RunInfo_Load);
            this.RoundPanel1.ResumeLayout(false);
            this.RoundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_yeild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_YieldOverview)).EndInit();
            this.RoundPanel2.ResumeLayout(false);
            this.RoundPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_uph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_tossing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_UPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Tossing)).EndInit();
            this.ResumeLayout(false);

		}
		internal BZ.UI.RoundPanel RoundPanel1;
		internal BZ.UI.RoundPanel RoundPanel2;
		internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_YieldOverview;
		internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_Tossing;
		internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_UPH;
		internal System.Windows.Forms.Button Button_YeildDay_Jia;
		internal System.Windows.Forms.Button Button_YeildDay_Jian;
		internal System.Windows.Forms.TrackBar TrackBar_yeild;
		internal System.Windows.Forms.Button Button_UPHDay_Jia;
		internal System.Windows.Forms.Button Button_UPHDay_Jian;
		internal System.Windows.Forms.TrackBar TrackBar_uph;
		internal System.Windows.Forms.Button Button_TossingDay_Jia;
		internal System.Windows.Forms.Button Button_TossingDay_Jian;
		internal System.Windows.Forms.TrackBar TrackBar_tossing;
		internal System.Windows.Forms.Label Label1;
	}
	
}
