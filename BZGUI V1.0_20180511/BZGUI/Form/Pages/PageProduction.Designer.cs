namespace BZGUI
{
    partial class PageProduction
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UPH = new BoTech.Label();
            this.AlarmTime = new BoTech.Label();
            this.AlarmStatus = new BoTech.Label();
            this.Panel4 = new BoTech.Panel();
            this.GroupBox34 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new BoTech.Button();
            this.txt_Yield = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_NGCounts = new System.Windows.Forms.TextBox();
            this.Text_OKCounts = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.checkDatactl1 = new BZGUI.CheckDatactl();
            this.MaterialLevel = new BoTech.Label();
            this.Panel3 = new BoTech.Panel();
            this.chartCPK1 = new BZGUI.ChartCPK();
            this.Panel2 = new BoTech.Panel();
            this.chartYield1 = new BZGUI.ChartYield();
            this.Btn_Retest = new BoTech.Button();
            this.Btn_Yield = new BoTech.Button();
            this.Panel4.SuspendLayout();
            this.GroupBox34.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.UPH.Location = new System.Drawing.Point(266, 4);
            this.UPH.Name = "UPH";
            this.UPH.Size = new System.Drawing.Size(60, 60);
            this.UPH.TabIndex = 29;
            this.UPH.Text = "Label2";
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
            this.AlarmTime.Location = new System.Drawing.Point(136, 4);
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.Size = new System.Drawing.Size(125, 60);
            this.AlarmTime.TabIndex = 30;
            this.AlarmTime.Text = "Label2";
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
            this.AlarmStatus.Location = new System.Drawing.Point(6, 4);
            this.AlarmStatus.Name = "AlarmStatus";
            this.AlarmStatus.Size = new System.Drawing.Size(125, 60);
            this.AlarmStatus.TabIndex = 31;
            this.AlarmStatus.Text = "No Alarm";
            // 
            // Panel4
            // 
            this.Panel4.BZ_Color = System.Drawing.SystemColors.Control;
            this.Panel4.BZ_Radius = 11;
            this.Panel4.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel4.Controls.Add(this.GroupBox34);
            this.Panel4.Controls.Add(this.checkDatactl1);
            this.Panel4.Location = new System.Drawing.Point(6, 69);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(663, 588);
            this.Panel4.TabIndex = 25;
            // 
            // GroupBox34
            // 
            this.GroupBox34.Controls.Add(this.btn_Clear);
            this.GroupBox34.Controls.Add(this.txt_Yield);
            this.GroupBox34.Controls.Add(this.txtCount);
            this.GroupBox34.Controls.Add(this.label3);
            this.GroupBox34.Controls.Add(this.label1);
            this.GroupBox34.Controls.Add(this.label4);
            this.GroupBox34.Controls.Add(this.label2);
            this.GroupBox34.Controls.Add(this.Text_NGCounts);
            this.GroupBox34.Controls.Add(this.Text_OKCounts);
            this.GroupBox34.Controls.Add(this.label45);
            this.GroupBox34.Controls.Add(this.label55);
            this.GroupBox34.Controls.Add(this.label56);
            this.GroupBox34.Controls.Add(this.label57);
            this.GroupBox34.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox34.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GroupBox34.Location = new System.Drawing.Point(3, 473);
            this.GroupBox34.Name = "GroupBox34";
            this.GroupBox34.Size = new System.Drawing.Size(657, 101);
            this.GroupBox34.TabIndex = 6;
            this.GroupBox34.TabStop = false;
            this.GroupBox34.Text = "生产良率统计";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BZ_BackColor = System.Drawing.Color.LightGray;
            this.btn_Clear.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.btn_Clear.BZ_Radius = 11;
            this.btn_Clear.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.btn_Clear.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(460, 51);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(60, 25);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Yield
            // 
            this.txt_Yield.Location = new System.Drawing.Point(341, 54);
            this.txt_Yield.Name = "txt_Yield";
            this.txt_Yield.ReadOnly = true;
            this.txt_Yield.Size = new System.Drawing.Size(70, 25);
            this.txt_Yield.TabIndex = 5;
            this.txt_Yield.Text = "0";
            this.txt_Yield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(228, 54);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(70, 25);
            this.txtCount.TabIndex = 4;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(413, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(303, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "pcs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(338, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yield：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(227, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total：";
            // 
            // Text_NGCounts
            // 
            this.Text_NGCounts.Location = new System.Drawing.Point(119, 54);
            this.Text_NGCounts.Name = "Text_NGCounts";
            this.Text_NGCounts.ReadOnly = true;
            this.Text_NGCounts.Size = new System.Drawing.Size(70, 25);
            this.Text_NGCounts.TabIndex = 1;
            this.Text_NGCounts.Text = "0";
            this.Text_NGCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_OKCounts
            // 
            this.Text_OKCounts.BackColor = System.Drawing.SystemColors.Control;
            this.Text_OKCounts.Location = new System.Drawing.Point(8, 54);
            this.Text_OKCounts.Name = "Text_OKCounts";
            this.Text_OKCounts.ReadOnly = true;
            this.Text_OKCounts.Size = new System.Drawing.Size(70, 25);
            this.Text_OKCounts.TabIndex = 1;
            this.Text_OKCounts.Text = "0";
            this.Text_OKCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(192, 56);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(32, 17);
            this.label45.TabIndex = 0;
            this.label45.Text = "pcs";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(81, 56);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 17);
            this.label55.TabIndex = 0;
            this.label55.Text = "pcs";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Red;
            this.label56.Location = new System.Drawing.Point(120, 33);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(43, 17);
            this.label56.TabIndex = 0;
            this.label56.Text = "NG：";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label57.Location = new System.Drawing.Point(7, 33);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(43, 17);
            this.label57.TabIndex = 0;
            this.label57.Text = "OK：";
            // 
            // checkDatactl1
            // 
            this.checkDatactl1.Location = new System.Drawing.Point(3, 3);
            this.checkDatactl1.Name = "checkDatactl1";
            this.checkDatactl1.Size = new System.Drawing.Size(657, 467);
            this.checkDatactl1.TabIndex = 0;
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
            this.MaterialLevel.Location = new System.Drawing.Point(331, 4);
            this.MaterialLevel.Name = "MaterialLevel";
            this.MaterialLevel.Size = new System.Drawing.Size(160, 60);
            this.MaterialLevel.TabIndex = 32;
            this.MaterialLevel.Text = "Label4";
            // 
            // Panel3
            // 
            this.Panel3.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.BZ_Radius = 11;
            this.Panel3.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel3.Controls.Add(this.chartCPK1);
            this.Panel3.Location = new System.Drawing.Point(675, 4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(344, 357);
            this.Panel3.TabIndex = 28;
            // 
            // chartCPK1
            // 
            this.chartCPK1.BackColor = System.Drawing.SystemColors.Control;
            this.chartCPK1.Location = new System.Drawing.Point(4, 2);
            this.chartCPK1.Name = "chartCPK1";
            this.chartCPK1.Size = new System.Drawing.Size(337, 352);
            this.chartCPK1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BZ_Color = System.Drawing.SystemColors.Control;
            this.Panel2.BZ_Radius = 11;
            this.Panel2.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel2.Controls.Add(this.chartYield1);
            this.Panel2.Controls.Add(this.Btn_Retest);
            this.Panel2.Controls.Add(this.Btn_Yield);
            this.Panel2.Location = new System.Drawing.Point(675, 368);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(344, 290);
            this.Panel2.TabIndex = 27;
            // 
            // chartYield1
            // 
            this.chartYield1.BackColor = System.Drawing.SystemColors.Control;
            this.chartYield1.Location = new System.Drawing.Point(1, 3);
            this.chartYield1.Name = "chartYield1";
            this.chartYield1.Size = new System.Drawing.Size(333, 191);
            this.chartYield1.TabIndex = 34;
            // 
            // Btn_Retest
            // 
            this.Btn_Retest.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_Retest.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Retest.BZ_Radius = 11;
            this.Btn_Retest.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Retest.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Retest.ForeColor = System.Drawing.Color.Black;
            this.Btn_Retest.Location = new System.Drawing.Point(213, 214);
            this.Btn_Retest.Name = "Btn_Retest";
            this.Btn_Retest.Size = new System.Drawing.Size(60, 48);
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
            this.Btn_Yield.Location = new System.Drawing.Point(72, 214);
            this.Btn_Yield.Name = "Btn_Yield";
            this.Btn_Yield.Size = new System.Drawing.Size(60, 48);
            this.Btn_Yield.TabIndex = 26;
            this.Btn_Yield.Text = "Yield";
            this.Btn_Yield.UseVisualStyleBackColor = true;
            this.Btn_Yield.Click += new System.EventHandler(this.Btn_Yield_Click);
            // 
            // PageProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UPH);
            this.Controls.Add(this.AlarmTime);
            this.Controls.Add(this.AlarmStatus);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.MaterialLevel);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Name = "PageProduction";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageProduction_Load);
            this.SizeChanged += new System.EventHandler(this.PageProduction_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.PageProduction_VisibleChanged);
            //this.Resize += new System.EventHandler(this.PageProduction_Resize);
            this.Panel4.ResumeLayout(false);
            this.GroupBox34.ResumeLayout(false);
            this.GroupBox34.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal BoTech.Label UPH;
        internal BoTech.Label AlarmTime;
        internal BoTech.Label AlarmStatus;
        internal BoTech.Panel Panel4;
        internal BoTech.Label MaterialLevel;
        internal BoTech.Panel Panel3;
        internal BoTech.Panel Panel2;
        internal BoTech.Button Btn_Retest;
        internal BoTech.Button Btn_Yield;
        private ChartYield chartYield1;
        private ChartCPK chartCPK1;
        private CheckDatactl checkDatactl1;
        internal System.Windows.Forms.GroupBox GroupBox34;
        internal System.Windows.Forms.TextBox Text_NGCounts;
        internal System.Windows.Forms.TextBox Text_OKCounts;
        internal System.Windows.Forms.Label label45;
        internal System.Windows.Forms.Label label55;
        internal System.Windows.Forms.Label label56;
        internal System.Windows.Forms.Label label57;
        internal System.Windows.Forms.TextBox txtCount;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_Yield;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal BoTech.Button btn_Clear;

    }
}
