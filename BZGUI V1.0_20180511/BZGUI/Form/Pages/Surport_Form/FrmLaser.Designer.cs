namespace BZGUI
{
    partial class FrmLaser
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
            this.pcI9222ctl1 = new BZGUI.PCI9222ctl();
            this.SuspendLayout();
            // 
            // pcI9222ctl1
            // 
            this.pcI9222ctl1.Location = new System.Drawing.Point(-1, -1);
            this.pcI9222ctl1.Name = "pcI9222ctl1";
            this.pcI9222ctl1.Size = new System.Drawing.Size(1019, 667);
            this.pcI9222ctl1.TabIndex = 0;
            // 
            // FrmLaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.Controls.Add(this.pcI9222ctl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLaser";
            this.Text = "FrmLaser";
            this.Load += new System.EventHandler(this.FrmLaser_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmLaser_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private PCI9222ctl pcI9222ctl1;


    }
}