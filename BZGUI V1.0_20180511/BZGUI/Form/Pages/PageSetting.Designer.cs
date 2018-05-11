namespace BZGUI
{
    partial class PageSetting
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
            this.xSettingGrid2 = new XCore.XSettingGrid();
            this.xSettingGrid3 = new XCore.XSettingGrid();
            this.SuspendLayout();
            // 
            // xSettingGrid1
            // 
            this.xSettingGrid1.Id = 1;
            this.xSettingGrid1.Location = new System.Drawing.Point(4, 3);
            this.xSettingGrid1.Name = "xSettingGrid1";
            this.xSettingGrid1.Size = new System.Drawing.Size(373, 606);
            this.xSettingGrid1.TabIndex = 0;
            // 
            // xSettingGrid2
            // 
            this.xSettingGrid2.Id = 2;
            this.xSettingGrid2.Location = new System.Drawing.Point(388, 3);
            this.xSettingGrid2.Name = "xSettingGrid2";
            this.xSettingGrid2.Size = new System.Drawing.Size(310, 606);
            this.xSettingGrid2.TabIndex = 0;
            // 
            // xSettingGrid3
            // 
            this.xSettingGrid3.Id = 3;
            this.xSettingGrid3.Location = new System.Drawing.Point(709, 3);
            this.xSettingGrid3.Name = "xSettingGrid3";
            this.xSettingGrid3.Size = new System.Drawing.Size(310, 606);
            this.xSettingGrid3.TabIndex = 0;
            // 
            // PageSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xSettingGrid3);
            this.Controls.Add(this.xSettingGrid2);
            this.Controls.Add(this.xSettingGrid1);
            this.Name = "PageSetting";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageSetting_Load);
            this.SizeChanged += new System.EventHandler(this.PageSetting_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XSettingGrid xSettingGrid1;
        private XCore.XSettingGrid xSettingGrid2;
        private XCore.XSettingGrid xSettingGrid3;

    }
}
