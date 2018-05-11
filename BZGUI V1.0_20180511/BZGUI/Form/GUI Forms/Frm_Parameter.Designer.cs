namespace BZGUI
{
    partial class Frm_Parameter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.xSettingGrid1.Location = new System.Drawing.Point(2, 2);
            this.xSettingGrid1.Name = "xSettingGrid1";
            this.xSettingGrid1.Size = new System.Drawing.Size(328, 650);
            this.xSettingGrid1.TabIndex = 0;
            // 
            // xSettingGrid2
            // 
            this.xSettingGrid2.Id = 2;
            this.xSettingGrid2.Location = new System.Drawing.Point(346, 2);
            this.xSettingGrid2.Name = "xSettingGrid2";
            this.xSettingGrid2.Size = new System.Drawing.Size(328, 650);
            this.xSettingGrid2.TabIndex = 0;
            // 
            // xSettingGrid3
            // 
            this.xSettingGrid3.Id = 3;
            this.xSettingGrid3.Location = new System.Drawing.Point(690, 2);
            this.xSettingGrid3.Name = "xSettingGrid3";
            this.xSettingGrid3.Size = new System.Drawing.Size(328, 650);
            this.xSettingGrid3.TabIndex = 0;
            // 
            // Frm_Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.ControlBox = false;
            this.Controls.Add(this.xSettingGrid3);
            this.Controls.Add(this.xSettingGrid2);
            this.Controls.Add(this.xSettingGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Parameter";
            this.ShowInTaskbar = false;
            this.Text = "Frm_Parameter";
            this.Load += new System.EventHandler(this.Frm_Parameter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XSettingGrid xSettingGrid1;
        private XCore.XSettingGrid xSettingGrid2;
        private XCore.XSettingGrid xSettingGrid3;

    }
}