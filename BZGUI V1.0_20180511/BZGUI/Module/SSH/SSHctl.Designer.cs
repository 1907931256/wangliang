namespace BZGUI
{
    partial class SSHctl
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
            this.SSHOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SSHOutput
            // 
            this.SSHOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.SSHOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSHOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.SSHOutput.Location = new System.Drawing.Point(0, 0);
            this.SSHOutput.Multiline = true;
            this.SSHOutput.Name = "SSHOutput";
            this.SSHOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SSHOutput.Size = new System.Drawing.Size(628, 445);
            this.SSHOutput.TabIndex = 8;
            // 
            // SSHctl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SSHOutput);
            this.Name = "SSHctl";
            this.Size = new System.Drawing.Size(628, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SSHOutput;
    }
}
