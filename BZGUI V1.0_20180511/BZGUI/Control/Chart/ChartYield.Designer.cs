namespace BZGUI
{
    partial class ChartYield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartYield));
            this.label2 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PB_Right2 = new System.Windows.Forms.PictureBox();
            this.Lbl_StartTime = new System.Windows.Forms.Label();
            this.Lbl_EndTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "NG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chart1
            // 
            this.Chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            this.Chart1.Location = new System.Drawing.Point(0, 0);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(332, 288);
            this.Chart1.TabIndex = 3;
            // 
            // PB_Right2
            // 
            this.PB_Right2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PB_Right2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Right2.BackgroundImage")));
            this.PB_Right2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Right2.Location = new System.Drawing.Point(108, 143);
            this.PB_Right2.Name = "PB_Right2";
            this.PB_Right2.Size = new System.Drawing.Size(20, 20);
            this.PB_Right2.TabIndex = 32;
            this.PB_Right2.TabStop = false;
            // 
            // Lbl_StartTime
            // 
            this.Lbl_StartTime.AutoSize = true;
            this.Lbl_StartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Lbl_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Lbl_StartTime.ForeColor = System.Drawing.Color.Black;
            this.Lbl_StartTime.Location = new System.Drawing.Point(53, 143);
            this.Lbl_StartTime.Name = "Lbl_StartTime";
            this.Lbl_StartTime.Size = new System.Drawing.Size(41, 12);
            this.Lbl_StartTime.TabIndex = 30;
            this.Lbl_StartTime.Text = "06/09/16";
            // 
            // Lbl_EndTime
            // 
            this.Lbl_EndTime.AutoSize = true;
            this.Lbl_EndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Lbl_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Lbl_EndTime.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EndTime.Location = new System.Drawing.Point(53, 155);
            this.Lbl_EndTime.Name = "Lbl_EndTime";
            this.Lbl_EndTime.Size = new System.Drawing.Size(41, 12);
            this.Lbl_EndTime.TabIndex = 31;
            this.Lbl_EndTime.Text = "10/01/16";
            // 
            // ChartYield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PB_Right2);
            this.Controls.Add(this.Lbl_StartTime);
            this.Controls.Add(this.Lbl_EndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chart1);
            this.Name = "ChartYield";
            this.Size = new System.Drawing.Size(332, 288);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        internal System.Windows.Forms.PictureBox PB_Right2;
        internal System.Windows.Forms.Label Lbl_StartTime;
        internal System.Windows.Forms.Label Lbl_EndTime;
    }
}
