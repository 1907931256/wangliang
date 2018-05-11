
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
	partial class Frm_AlarmInfo : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AlarmInfo));
            this.RoundPanel2 = new BZ.UI.RoundPanel();
            this.Chart_ErrorCode = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.RoundPanel3 = new BZ.UI.RoundPanel();
            this.Panel3 = new BoTech.Panel();
            this.DataGridView_ErrorCode = new System.Windows.Forms.DataGridView();
            this.Button_Store = new System.Windows.Forms.Button();
            this.LB_CodeDescription = new System.Windows.Forms.ListBox();
            this.RoundPanel4 = new BZ.UI.RoundPanel();
            this.RoundPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_ErrorCode)).BeginInit();
            this.RoundPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ErrorCode)).BeginInit();
            this.RoundPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoundPanel2
            // 
            this.RoundPanel2.BackColor = System.Drawing.Color.Magenta;
            this.RoundPanel2.BZ_AutoBkColor = true;
            this.RoundPanel2.BZ_Radius = ((byte)(6));
            this.RoundPanel2.BZ_Version = "V1.0.0";
            this.RoundPanel2.Controls.Add(this.Chart_ErrorCode);
            this.RoundPanel2.Controls.Add(this.CheckBox1);
            this.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel2.Location = new System.Drawing.Point(558, 2);
            this.RoundPanel2.Name = "RoundPanel2";
            this.RoundPanel2.Size = new System.Drawing.Size(458, 653);
            this.RoundPanel2.TabIndex = 4;
            // 
            // Chart_ErrorCode
            // 
            this.Chart_ErrorCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Chart_ErrorCode.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea1.Name = "ChartArea1";
            this.Chart_ErrorCode.ChartAreas.Add(chartArea1);
            this.Chart_ErrorCode.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            this.Chart_ErrorCode.Legends.Add(legend1);
            this.Chart_ErrorCode.Location = new System.Drawing.Point(18, 18);
            this.Chart_ErrorCode.Name = "Chart_ErrorCode";
            this.Chart_ErrorCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.Chart_ErrorCode.Series.Add(series1);
            this.Chart_ErrorCode.Size = new System.Drawing.Size(416, 505);
            this.Chart_ErrorCode.TabIndex = 8;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.ForeColor = System.Drawing.Color.Black;
            this.CheckBox1.Location = new System.Drawing.Point(314, 617);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(120, 16);
            this.CheckBox1.TabIndex = 7;
            this.CheckBox1.Text = "以百分比方式查看";
            this.CheckBox1.UseVisualStyleBackColor = false;
            this.CheckBox1.Visible = false;
            // 
            // RoundPanel3
            // 
            this.RoundPanel3.BackColor = System.Drawing.Color.Magenta;
            this.RoundPanel3.BZ_AutoBkColor = true;
            this.RoundPanel3.BZ_Radius = ((byte)(6));
            this.RoundPanel3.BZ_Version = "V1.0.0";
            this.RoundPanel3.Controls.Add(this.Panel3);
            this.RoundPanel3.Controls.Add(this.DataGridView_ErrorCode);
            this.RoundPanel3.Controls.Add(this.Button_Store);
            this.RoundPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel3.Location = new System.Drawing.Point(3, 87);
            this.RoundPanel3.Name = "RoundPanel3";
            this.RoundPanel3.Size = new System.Drawing.Size(550, 568);
            this.RoundPanel3.TabIndex = 5;
            // 
            // Panel3
            // 
            this.Panel3.BZ_Color = System.Drawing.Color.Magenta;
            this.Panel3.BZ_Radius = 11;
            this.Panel3.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.Location = new System.Drawing.Point(46, 467);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(328, 51);
            this.Panel3.TabIndex = 47;
            // 
            // DataGridView_ErrorCode
            // 
            this.DataGridView_ErrorCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ErrorCode.Location = new System.Drawing.Point(7, 29);
            this.DataGridView_ErrorCode.Name = "DataGridView_ErrorCode";
            this.DataGridView_ErrorCode.ReadOnly = true;
            this.DataGridView_ErrorCode.RowTemplate.Height = 23;
            this.DataGridView_ErrorCode.Size = new System.Drawing.Size(534, 346);
            this.DataGridView_ErrorCode.TabIndex = 6;
            // 
            // Button_Store
            // 
            this.Button_Store.Image = ((System.Drawing.Image)(resources.GetObject("Button_Store.Image")));
            this.Button_Store.Location = new System.Drawing.Point(230, 381);
            this.Button_Store.Name = "Button_Store";
            this.Button_Store.Size = new System.Drawing.Size(78, 70);
            this.Button_Store.TabIndex = 5;
            this.Button_Store.UseVisualStyleBackColor = true;
            // 
            // LB_CodeDescription
            // 
            this.LB_CodeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.LB_CodeDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_CodeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CodeDescription.FormattingEnabled = true;
            this.LB_CodeDescription.ItemHeight = 20;
            this.LB_CodeDescription.Items.AddRange(new object[] {
            "● Code: xxxx & Category",
            "● Description"});
            this.LB_CodeDescription.Location = new System.Drawing.Point(9, 19);
            this.LB_CodeDescription.Name = "LB_CodeDescription";
            this.LB_CodeDescription.Size = new System.Drawing.Size(533, 40);
            this.LB_CodeDescription.TabIndex = 0;
            // 
            // RoundPanel4
            // 
            this.RoundPanel4.BackColor = System.Drawing.Color.Magenta;
            this.RoundPanel4.BZ_AutoBkColor = true;
            this.RoundPanel4.BZ_Radius = ((byte)(6));
            this.RoundPanel4.BZ_Version = "V1.0.0";
            this.RoundPanel4.Controls.Add(this.LB_CodeDescription);
            this.RoundPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.RoundPanel4.Location = new System.Drawing.Point(3, 2);
            this.RoundPanel4.Name = "RoundPanel4";
            this.RoundPanel4.Size = new System.Drawing.Size(550, 80);
            this.RoundPanel4.TabIndex = 6;
            // 
            // Frm_AlarmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.RoundPanel2);
            this.Controls.Add(this.RoundPanel3);
            this.Controls.Add(this.RoundPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AlarmInfo";
            this.ShowInTaskbar = false;
            this.Text = "Frm_AlarmInfo";
            this.Load += new System.EventHandler(this.Frm_AlarmInfo_Load);
            this.RoundPanel2.ResumeLayout(false);
            this.RoundPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_ErrorCode)).EndInit();
            this.RoundPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ErrorCode)).EndInit();
            this.RoundPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal BZ.UI.RoundPanel RoundPanel2;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal BZ.UI.RoundPanel RoundPanel3;
		internal System.Windows.Forms.Button Button_Store;
		internal System.Windows.Forms.ListBox LB_CodeDescription;
		internal BZ.UI.RoundPanel RoundPanel4;
		internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_ErrorCode;
		internal System.Windows.Forms.DataGridView DataGridView_ErrorCode;
		internal BoTech.Panel Panel3;
	}
	
}
