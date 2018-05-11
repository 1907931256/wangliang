namespace BZGUI
{
    partial class FrmIPDMManual
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
            this.xtaskStateBar1 = new XCore.XtaskStateBar();
            this.Btn_Scanner = new System.Windows.Forms.Button();
            this.btn_CCD = new System.Windows.Forms.Button();
            this.teach1 = new BZGUI.Teach();
            this.xtaskStateRichList1 = new XCore.XtaskStateRichList();
            this.taskControlPanel1 = new BZGUI.TaskControlPanel();
            this.SuspendLayout();
            // 
            // xtaskStateBar1
            // 
            this.xtaskStateBar1.Location = new System.Drawing.Point(493, 139);
            this.xtaskStateBar1.Name = "xtaskStateBar1";
            this.xtaskStateBar1.Size = new System.Drawing.Size(210, 25);
            this.xtaskStateBar1.TabIndex = 21;
            this.xtaskStateBar1.TaskId = 1;
            // 
            // Btn_Scanner
            // 
            this.Btn_Scanner.Location = new System.Drawing.Point(628, 242);
            this.Btn_Scanner.Name = "Btn_Scanner";
            this.Btn_Scanner.Size = new System.Drawing.Size(101, 38);
            this.Btn_Scanner.TabIndex = 20;
            this.Btn_Scanner.Text = "Scanner Trigger";
            this.Btn_Scanner.UseVisualStyleBackColor = true;
            this.Btn_Scanner.Click += new System.EventHandler(this.Btn_Scanner_Click);
            // 
            // btn_CCD
            // 
            this.btn_CCD.Location = new System.Drawing.Point(504, 242);
            this.btn_CCD.Name = "btn_CCD";
            this.btn_CCD.Size = new System.Drawing.Size(104, 38);
            this.btn_CCD.TabIndex = 19;
            this.btn_CCD.Text = "CCD Trigger";
            this.btn_CCD.UseVisualStyleBackColor = true;
            this.btn_CCD.Click += new System.EventHandler(this.btn_CCD_Click);
            // 
            // teach1
            // 
            this.teach1.Location = new System.Drawing.Point(1, 3);
            this.teach1.Name = "teach1";
            this.teach1.Size = new System.Drawing.Size(486, 332);
            this.teach1.TabIndex = 18;
            this.teach1.Tag = "0";
            // 
            // xtaskStateRichList1
            // 
            this.xtaskStateRichList1.Location = new System.Drawing.Point(493, 15);
            this.xtaskStateRichList1.Name = "xtaskStateRichList1";
            this.xtaskStateRichList1.Size = new System.Drawing.Size(210, 119);
            this.xtaskStateRichList1.TabIndex = 24;
            this.xtaskStateRichList1.TaskId = 1;
            // 
            // taskControlPanel1
            // 
            this.taskControlPanel1.Location = new System.Drawing.Point(491, 170);
            this.taskControlPanel1.Name = "taskControlPanel1";
            this.taskControlPanel1.Size = new System.Drawing.Size(196, 51);
            this.taskControlPanel1.TabIndex = 25;
            this.taskControlPanel1.TaskId = 1;
            // 
            // FrmIPDMManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.taskControlPanel1);
            this.Controls.Add(this.xtaskStateRichList1);
            this.Controls.Add(this.xtaskStateBar1);
            this.Controls.Add(this.Btn_Scanner);
            this.Controls.Add(this.btn_CCD);
            this.Controls.Add(this.teach1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIPDMManual";
            this.Text = "FrmIPDMManual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIPDMManual_FormClosed);
            this.Load += new System.EventHandler(this.FrmIPDMManual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XtaskStateBar xtaskStateBar1;
        private System.Windows.Forms.Button Btn_Scanner;
        private System.Windows.Forms.Button btn_CCD;
        private Teach teach1;
        private XCore.XtaskStateRichList xtaskStateRichList1;
        private TaskControlPanel taskControlPanel1;
    }
}