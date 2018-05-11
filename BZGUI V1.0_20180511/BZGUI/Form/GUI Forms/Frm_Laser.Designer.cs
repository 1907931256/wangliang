namespace BZGUI
{
    partial class Frm_Laser
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
            this.SuspendLayout();
            // 
            // xSettingGrid1
            // 
            this.xSettingGrid1.Id = 4;
            this.xSettingGrid1.Location = new System.Drawing.Point(3, 2);
            this.xSettingGrid1.Name = "xSettingGrid1";
            this.xSettingGrid1.Size = new System.Drawing.Size(300, 650);
            this.xSettingGrid1.TabIndex = 0;
            // 
            // Frm_Laser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.xSettingGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Laser";
            this.Text = "Frm_Laser";
            this.Load += new System.EventHandler(this.Frm_Laser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XSettingGrid xSettingGrid1;
    }
}