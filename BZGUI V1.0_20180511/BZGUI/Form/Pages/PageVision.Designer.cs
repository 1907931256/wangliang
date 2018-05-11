namespace BZGUI
{
    partial class PageVision
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
            this.xSettingGrid1 = new XCore.XSettingGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // xSettingGrid1
            // 
            this.xSettingGrid1.Id = 4;
            this.xSettingGrid1.Location = new System.Drawing.Point(3, 3);
            this.xSettingGrid1.Name = "xSettingGrid1";
            this.xSettingGrid1.Size = new System.Drawing.Size(312, 630);
            this.xSettingGrid1.TabIndex = 0;
            this.xSettingGrid1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 654);
            this.panel1.TabIndex = 1;
            // 
            // PageVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xSettingGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "PageVision";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageVision_Load);
            this.SizeChanged += new System.EventHandler(this.PageVision_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XSettingGrid xSettingGrid1;
        private System.Windows.Forms.Panel panel1;

    }
}
