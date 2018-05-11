namespace BZGUI
{
    partial class CheckDatactl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Label3 = new BoTech.Label();
            this.Chart_CheckData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_CheckData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Label3.Location = new System.Drawing.Point(229, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(133, 33);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "CheckData";
            // 
            // Chart_CheckData
            // 
            this.Chart_CheckData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart_CheckData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.Chart_CheckData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_CheckData.Legends.Add(legend1);
            this.Chart_CheckData.Location = new System.Drawing.Point(-27, 40);
            this.Chart_CheckData.Name = "Chart_CheckData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Blue;
            this.Chart_CheckData.Series.Add(series1);
            this.Chart_CheckData.Size = new System.Drawing.Size(757, 278);
            this.Chart_CheckData.TabIndex = 26;
            this.Chart_CheckData.TabStop = false;
            this.Chart_CheckData.Text = "Chart1";
            this.Chart_CheckData.SizeChanged += new System.EventHandler(this.Chart_CheckData_SizeChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(679, 42);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CheckDatactl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Chart_CheckData);
            this.Name = "CheckDatactl";
            this.Size = new System.Drawing.Size(679, 353);
            this.Load += new System.EventHandler(this.CheckDatactl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_CheckData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal BoTech.Label Label3;
        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_CheckData;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
