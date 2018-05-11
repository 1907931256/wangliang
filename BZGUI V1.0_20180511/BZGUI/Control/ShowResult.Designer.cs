namespace BZGUI
{
    partial class ShowResult
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
            this.lab_OKNG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_OKNG
            // 
            this.lab_OKNG.BackColor = System.Drawing.SystemColors.Highlight;
            this.lab_OKNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_OKNG.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_OKNG.ForeColor = System.Drawing.Color.Lime;
            this.lab_OKNG.Location = new System.Drawing.Point(0, 0);
            this.lab_OKNG.Name = "lab_OKNG";
            this.lab_OKNG.Size = new System.Drawing.Size(271, 150);
            this.lab_OKNG.TabIndex = 81;
            this.lab_OKNG.Text = "OK";
            this.lab_OKNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_OKNG);
            this.Name = "ShowResult";
            this.Size = new System.Drawing.Size(271, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_OKNG;

    }
}
