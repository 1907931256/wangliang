
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
	partial class LightControl : System.Windows.Forms.UserControl
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
            this.Panel17 = new System.Windows.Forms.Panel();
            this.Cmb_SelectColor = new System.Windows.Forms.ComboBox();
            this.Btn_Load_CH = new System.Windows.Forms.Button();
            this.Cmb_TriggerSelect = new System.Windows.Forms.ComboBox();
            this.Btn_Save_CH = new System.Windows.Forms.Button();
            this.Lab_Ch4 = new System.Windows.Forms.Label();
            this.Lab_Ch3 = new System.Windows.Forms.Label();
            this.Lab_Ch2 = new System.Windows.Forms.Label();
            this.Lab_Ch1 = new System.Windows.Forms.Label();
            this.NumericUpDown_CH4 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_CH3 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_CH2 = new System.Windows.Forms.NumericUpDown();
            this.TrackBar_CH4 = new System.Windows.Forms.TrackBar();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.TrackBar_CH3 = new System.Windows.Forms.TrackBar();
            this.TrackBar_CH2 = new System.Windows.Forms.TrackBar();
            this.Lab_LightControlName = new System.Windows.Forms.Label();
            this.NumericUpDown_CH1 = new System.Windows.Forms.NumericUpDown();
            this.TrackBar_CH1 = new System.Windows.Forms.TrackBar();
            this.Panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel17
            // 
            this.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel17.Controls.Add(this.Cmb_SelectColor);
            this.Panel17.Controls.Add(this.Btn_Load_CH);
            this.Panel17.Controls.Add(this.Cmb_TriggerSelect);
            this.Panel17.Controls.Add(this.Btn_Save_CH);
            this.Panel17.Controls.Add(this.Lab_Ch4);
            this.Panel17.Controls.Add(this.Lab_Ch3);
            this.Panel17.Controls.Add(this.Lab_Ch2);
            this.Panel17.Controls.Add(this.Lab_Ch1);
            this.Panel17.Controls.Add(this.NumericUpDown_CH4);
            this.Panel17.Controls.Add(this.NumericUpDown_CH3);
            this.Panel17.Controls.Add(this.NumericUpDown_CH2);
            this.Panel17.Controls.Add(this.TrackBar_CH4);
            this.Panel17.Controls.Add(this.Btn_Open);
            this.Panel17.Controls.Add(this.TrackBar_CH3);
            this.Panel17.Controls.Add(this.TrackBar_CH2);
            this.Panel17.Controls.Add(this.Lab_LightControlName);
            this.Panel17.Controls.Add(this.NumericUpDown_CH1);
            this.Panel17.Controls.Add(this.TrackBar_CH1);
            this.Panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel17.Location = new System.Drawing.Point(0, 0);
            this.Panel17.Name = "Panel17";
            this.Panel17.Size = new System.Drawing.Size(412, 416);
            this.Panel17.TabIndex = 10;
            this.Panel17.Tag = "0";
            // 
            // Cmb_SelectColor
            // 
            this.Cmb_SelectColor.FormattingEnabled = true;
            this.Cmb_SelectColor.Items.AddRange(new object[] {
            "P10(白色)",
            "P20(黑色)",
            "P30()",
            "P40()",
            "P50()"});
            this.Cmb_SelectColor.Location = new System.Drawing.Point(15, 379);
            this.Cmb_SelectColor.Name = "Cmb_SelectColor";
            this.Cmb_SelectColor.Size = new System.Drawing.Size(91, 20);
            this.Cmb_SelectColor.TabIndex = 27;
            // 
            // Btn_Load_CH
            // 
            this.Btn_Load_CH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load_CH.Location = new System.Drawing.Point(244, 379);
            this.Btn_Load_CH.MaximumSize = new System.Drawing.Size(75, 23);
            this.Btn_Load_CH.Name = "Btn_Load_CH";
            this.Btn_Load_CH.Size = new System.Drawing.Size(75, 23);
            this.Btn_Load_CH.TabIndex = 26;
            this.Btn_Load_CH.Text = "载入";
            this.Btn_Load_CH.UseVisualStyleBackColor = true;
            this.Btn_Load_CH.Click += new System.EventHandler(this.Btn_Load_CH_Click);
            // 
            // Cmb_TriggerSelect
            // 
            this.Cmb_TriggerSelect.FormattingEnabled = true;
            this.Cmb_TriggerSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Cmb_TriggerSelect.Location = new System.Drawing.Point(112, 379);
            this.Cmb_TriggerSelect.MaximumSize = new System.Drawing.Size(121, 0);
            this.Cmb_TriggerSelect.Name = "Cmb_TriggerSelect";
            this.Cmb_TriggerSelect.Size = new System.Drawing.Size(80, 20);
            this.Cmb_TriggerSelect.TabIndex = 25;
            this.Load += new System.EventHandler(this.LightControl_Load);
            // 
            // Btn_Save_CH
            // 
            this.Btn_Save_CH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save_CH.Location = new System.Drawing.Point(325, 379);
            this.Btn_Save_CH.MaximumSize = new System.Drawing.Size(75, 23);
            this.Btn_Save_CH.Name = "Btn_Save_CH";
            this.Btn_Save_CH.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save_CH.TabIndex = 5;
            this.Btn_Save_CH.Text = "保存";
            this.Btn_Save_CH.UseVisualStyleBackColor = true;
            this.Btn_Save_CH.Click += new System.EventHandler(this.Btn_Save_CH_Click);
            // 
            // Lab_Ch4
            // 
            this.Lab_Ch4.AutoSize = true;
            this.Lab_Ch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Ch4.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Ch4.Location = new System.Drawing.Point(12, 272);
            this.Lab_Ch4.Name = "Lab_Ch4";
            this.Lab_Ch4.Size = new System.Drawing.Size(31, 15);
            this.Lab_Ch4.TabIndex = 24;
            this.Lab_Ch4.Text = "CH4";
            // 
            // Lab_Ch3
            // 
            this.Lab_Ch3.AutoSize = true;
            this.Lab_Ch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Ch3.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Ch3.Location = new System.Drawing.Point(12, 190);
            this.Lab_Ch3.Name = "Lab_Ch3";
            this.Lab_Ch3.Size = new System.Drawing.Size(31, 15);
            this.Lab_Ch3.TabIndex = 23;
            this.Lab_Ch3.Text = "CH3";
            // 
            // Lab_Ch2
            // 
            this.Lab_Ch2.AutoSize = true;
            this.Lab_Ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Ch2.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Ch2.Location = new System.Drawing.Point(12, 110);
            this.Lab_Ch2.Name = "Lab_Ch2";
            this.Lab_Ch2.Size = new System.Drawing.Size(31, 15);
            this.Lab_Ch2.TabIndex = 22;
            this.Lab_Ch2.Text = "CH2";
            // 
            // Lab_Ch1
            // 
            this.Lab_Ch1.AutoSize = true;
            this.Lab_Ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Ch1.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Ch1.Location = new System.Drawing.Point(12, 30);
            this.Lab_Ch1.Name = "Lab_Ch1";
            this.Lab_Ch1.Size = new System.Drawing.Size(31, 15);
            this.Lab_Ch1.TabIndex = 21;
            this.Lab_Ch1.Text = "CH1";
            // 
            // NumericUpDown_CH4
            // 
            this.NumericUpDown_CH4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_CH4.Location = new System.Drawing.Point(345, 287);
            this.NumericUpDown_CH4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_CH4.MaximumSize = new System.Drawing.Size(55, 0);
            this.NumericUpDown_CH4.Name = "NumericUpDown_CH4";
            this.NumericUpDown_CH4.Size = new System.Drawing.Size(55, 21);
            this.NumericUpDown_CH4.TabIndex = 4;
            this.NumericUpDown_CH4.ValueChanged += new System.EventHandler(this.NumericUpDown_CH4_ValueChanged);
            // 
            // NumericUpDown_CH3
            // 
            this.NumericUpDown_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_CH3.Location = new System.Drawing.Point(345, 207);
            this.NumericUpDown_CH3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_CH3.MaximumSize = new System.Drawing.Size(55, 0);
            this.NumericUpDown_CH3.Name = "NumericUpDown_CH3";
            this.NumericUpDown_CH3.Size = new System.Drawing.Size(55, 21);
            this.NumericUpDown_CH3.TabIndex = 3;
            this.NumericUpDown_CH3.ValueChanged += new System.EventHandler(this.NumericUpDown_CH3_ValueChanged);
            // 
            // NumericUpDown_CH2
            // 
            this.NumericUpDown_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_CH2.Location = new System.Drawing.Point(345, 127);
            this.NumericUpDown_CH2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_CH2.MaximumSize = new System.Drawing.Size(55, 0);
            this.NumericUpDown_CH2.Name = "NumericUpDown_CH2";
            this.NumericUpDown_CH2.Size = new System.Drawing.Size(55, 21);
            this.NumericUpDown_CH2.TabIndex = 2;
            this.NumericUpDown_CH2.ValueChanged += new System.EventHandler(this.NumericUpDown_CH2_ValueChanged);
            // 
            // TrackBar_CH4
            // 
            this.TrackBar_CH4.AutoSize = false;
            this.TrackBar_CH4.Location = new System.Drawing.Point(8, 287);
            this.TrackBar_CH4.Maximum = 255;
            this.TrackBar_CH4.MaximumSize = new System.Drawing.Size(385, 45);
            this.TrackBar_CH4.Name = "TrackBar_CH4";
            this.TrackBar_CH4.Size = new System.Drawing.Size(331, 45);
            this.TrackBar_CH4.TabIndex = 4;
            this.TrackBar_CH4.ValueChanged += new System.EventHandler(this.TrackBar_CH4_ValueChanged);
            // 
            // Btn_Open
            // 
            this.Btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Open.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Open.Location = new System.Drawing.Point(325, 338);
            this.Btn_Open.MaximumSize = new System.Drawing.Size(75, 23);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(75, 23);
            this.Btn_Open.TabIndex = 4;
            this.Btn_Open.Text = "关闭";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // TrackBar_CH3
            // 
            this.TrackBar_CH3.AutoSize = false;
            this.TrackBar_CH3.Location = new System.Drawing.Point(8, 207);
            this.TrackBar_CH3.Maximum = 255;
            this.TrackBar_CH3.MaximumSize = new System.Drawing.Size(385, 45);
            this.TrackBar_CH3.Name = "TrackBar_CH3";
            this.TrackBar_CH3.Size = new System.Drawing.Size(331, 45);
            this.TrackBar_CH3.TabIndex = 3;
            this.TrackBar_CH3.ValueChanged += new System.EventHandler(this.TrackBar_CH3_ValueChanged);
            // 
            // TrackBar_CH2
            // 
            this.TrackBar_CH2.AutoSize = false;
            this.TrackBar_CH2.Location = new System.Drawing.Point(8, 127);
            this.TrackBar_CH2.Maximum = 255;
            this.TrackBar_CH2.MaximumSize = new System.Drawing.Size(385, 45);
            this.TrackBar_CH2.Name = "TrackBar_CH2";
            this.TrackBar_CH2.Size = new System.Drawing.Size(331, 45);
            this.TrackBar_CH2.TabIndex = 2;
            this.TrackBar_CH2.ValueChanged += new System.EventHandler(this.TrackBar_CH2_ValueChanged);
            // 
            // Lab_LightControlName
            // 
            this.Lab_LightControlName.AutoSize = true;
            this.Lab_LightControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_LightControlName.Location = new System.Drawing.Point(6, 9);
            this.Lab_LightControlName.Name = "Lab_LightControlName";
            this.Lab_LightControlName.Size = new System.Drawing.Size(67, 15);
            this.Lab_LightControlName.TabIndex = 8;
            this.Lab_LightControlName.Text = "光源控制器";
            // 
            // NumericUpDown_CH1
            // 
            this.NumericUpDown_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_CH1.Location = new System.Drawing.Point(345, 47);
            this.NumericUpDown_CH1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_CH1.MaximumSize = new System.Drawing.Size(55, 0);
            this.NumericUpDown_CH1.Name = "NumericUpDown_CH1";
            this.NumericUpDown_CH1.Size = new System.Drawing.Size(55, 21);
            this.NumericUpDown_CH1.TabIndex = 1;
            this.NumericUpDown_CH1.ValueChanged += new System.EventHandler(this.NumericUpDown_CH1_ValueChanged);
            // 
            // TrackBar_CH1
            // 
            this.TrackBar_CH1.AutoSize = false;
            this.TrackBar_CH1.Location = new System.Drawing.Point(8, 47);
            this.TrackBar_CH1.Maximum = 255;
            this.TrackBar_CH1.MaximumSize = new System.Drawing.Size(385, 45);
            this.TrackBar_CH1.Name = "TrackBar_CH1";
            this.TrackBar_CH1.Size = new System.Drawing.Size(331, 45);
            this.TrackBar_CH1.TabIndex = 1;
            this.TrackBar_CH1.ValueChanged += new System.EventHandler(this.TrackBar_CH1_ValueChanged);
            // 
            // LightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Panel17);
            this.Name = "LightControl";
            this.Size = new System.Drawing.Size(412, 416);
            this.Panel17.ResumeLayout(false);
            this.Panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_CH1)).EndInit();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel Panel17;
		internal System.Windows.Forms.Label Lab_Ch4;
		internal System.Windows.Forms.Label Lab_Ch3;
		internal System.Windows.Forms.Label Lab_Ch2;
		internal System.Windows.Forms.Label Lab_Ch1;
		internal System.Windows.Forms.NumericUpDown NumericUpDown_CH4;
		internal System.Windows.Forms.NumericUpDown NumericUpDown_CH3;
		internal System.Windows.Forms.NumericUpDown NumericUpDown_CH2;
		internal System.Windows.Forms.TrackBar TrackBar_CH4;
		internal System.Windows.Forms.Button Btn_Open;
		internal System.Windows.Forms.TrackBar TrackBar_CH3;
		internal System.Windows.Forms.TrackBar TrackBar_CH2;
		internal System.Windows.Forms.Label Lab_LightControlName;
		internal System.Windows.Forms.NumericUpDown NumericUpDown_CH1;
		internal System.Windows.Forms.TrackBar TrackBar_CH1;
		internal System.Windows.Forms.Button Btn_Save_CH;
		internal System.Windows.Forms.ComboBox Cmb_TriggerSelect;
		internal System.Windows.Forms.Button Btn_Load_CH;
		internal System.Windows.Forms.ComboBox Cmb_SelectColor;
	}
	
}
