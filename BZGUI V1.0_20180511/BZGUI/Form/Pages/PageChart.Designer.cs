namespace BZGUI
{
    partial class PageChart
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
            this.chart30Day2 = new BZGUI.Chart30Day();
            this.chart30Day1 = new BZGUI.Chart30Day();
            this.chartUPH30Day1 = new BZGUI.ChartUPH30Day();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart30Day2
            // 
            this.chart30Day2.DataShow = new double[] {
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D};
            this.chart30Day2.LengedTitle = "Toosing Rate (Units: %) ";
            this.chart30Day2.Location = new System.Drawing.Point(519, 326);
            this.chart30Day2.Max = 0;
            this.chart30Day2.Name = "chart30Day2";
            this.chart30Day2.Size = new System.Drawing.Size(501, 328);
            this.chart30Day2.TabIndex = 2;
            // 
            // chart30Day1
            // 
            this.chart30Day1.DataShow = new double[] {
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D};
            this.chart30Day1.LengedTitle = "Yield Rate (Units: %) ";
            this.chart30Day1.Location = new System.Drawing.Point(3, 326);
            this.chart30Day1.Max = 0;
            this.chart30Day1.Name = "chart30Day1";
            this.chart30Day1.Size = new System.Drawing.Size(510, 328);
            this.chart30Day1.TabIndex = 1;
            // 
            // chartUPH30Day1
            // 
            this.chartUPH30Day1.DataShow = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.chartUPH30Day1.Location = new System.Drawing.Point(3, 1);
            this.chartUPH30Day1.Max = 0;
            this.chartUPH30Day1.Name = "chartUPH30Day1";
            this.chartUPH30Day1.Size = new System.Drawing.Size(1018, 329);
            this.chartUPH30Day1.TabIndex = 0;
            this.chartUPH30Day1.Load += new System.EventHandler(this.chartUPH30Day1_Load);
            // 
            // PageChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart30Day2);
            this.Controls.Add(this.chart30Day1);
            this.Controls.Add(this.chartUPH30Day1);
            this.Name = "PageChart";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageChart_Load);
            this.SizeChanged += new System.EventHandler(this.PageChart_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartUPH30Day chartUPH30Day1;
        private Chart30Day chart30Day1;
        private Chart30Day chart30Day2;
        private System.Windows.Forms.Timer timer1;


    }
}
