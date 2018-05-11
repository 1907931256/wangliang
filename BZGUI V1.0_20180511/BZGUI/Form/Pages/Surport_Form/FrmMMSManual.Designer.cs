namespace BZGUI
{
    partial class FrmMMSManual
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
            this.btn_LaserCal = new System.Windows.Forms.Button();
            this.teach1 = new BZGUI.Teach();
            this.btn_OutputGRR = new System.Windows.Forms.Button();
            this.btn_ManualPDCA = new System.Windows.Forms.Button();
            this.xtaskStateRichList1 = new XCore.XtaskStateRichList();
            this.taskControlPanel1 = new BZGUI.TaskControlPanel();
            this.laserHights1 = new BZGUI.LaserHights();
            this.btn_Cylinder = new BZGUI.Bool();
            this.SuspendLayout();
            // 
            // xtaskStateBar1
            // 
            this.xtaskStateBar1.Location = new System.Drawing.Point(496, 194);
            this.xtaskStateBar1.Name = "xtaskStateBar1";
            this.xtaskStateBar1.Size = new System.Drawing.Size(269, 25);
            this.xtaskStateBar1.TabIndex = 15;
            this.xtaskStateBar1.TaskId = 2;
            // 
            // btn_LaserCal
            // 
            this.btn_LaserCal.Location = new System.Drawing.Point(492, 241);
            this.btn_LaserCal.Name = "btn_LaserCal";
            this.btn_LaserCal.Size = new System.Drawing.Size(76, 32);
            this.btn_LaserCal.TabIndex = 13;
            this.btn_LaserCal.Text = "Laser校正";
            this.btn_LaserCal.UseVisualStyleBackColor = true;
            this.btn_LaserCal.Click += new System.EventHandler(this.btn_LaserCal_Click);
            // 
            // teach1
            // 
            this.teach1.Location = new System.Drawing.Point(2, 2);
            this.teach1.Name = "teach1";
            this.teach1.Size = new System.Drawing.Size(486, 332);
            this.teach1.TabIndex = 12;
            this.teach1.Tag = "0";
            // 
            // btn_OutputGRR
            // 
            this.btn_OutputGRR.Location = new System.Drawing.Point(414, 346);
            this.btn_OutputGRR.Name = "btn_OutputGRR";
            this.btn_OutputGRR.Size = new System.Drawing.Size(74, 32);
            this.btn_OutputGRR.TabIndex = 85;
            this.btn_OutputGRR.Text = "导出GRR";
            this.btn_OutputGRR.UseVisualStyleBackColor = true;
            this.btn_OutputGRR.Click += new System.EventHandler(this.btn_OutputGRR_Click);
            // 
            // btn_ManualPDCA
            // 
            this.btn_ManualPDCA.Location = new System.Drawing.Point(587, 241);
            this.btn_ManualPDCA.Name = "btn_ManualPDCA";
            this.btn_ManualPDCA.Size = new System.Drawing.Size(76, 32);
            this.btn_ManualPDCA.TabIndex = 87;
            this.btn_ManualPDCA.Text = "手动上传PDCA";
            this.btn_ManualPDCA.UseVisualStyleBackColor = true;
            this.btn_ManualPDCA.Click += new System.EventHandler(this.btn_ManualPDCA_Click);
            // 
            // xtaskStateRichList1
            // 
            this.xtaskStateRichList1.Location = new System.Drawing.Point(496, 55);
            this.xtaskStateRichList1.Name = "xtaskStateRichList1";
            this.xtaskStateRichList1.Size = new System.Drawing.Size(269, 138);
            this.xtaskStateRichList1.TabIndex = 18;
            this.xtaskStateRichList1.TaskId = 2;
            // 
            // taskControlPanel1
            // 
            this.taskControlPanel1.Location = new System.Drawing.Point(495, 2);
            this.taskControlPanel1.Name = "taskControlPanel1";
            this.taskControlPanel1.Size = new System.Drawing.Size(192, 53);
            this.taskControlPanel1.TabIndex = 88;
            this.taskControlPanel1.TaskId = 2;
            // 
            // laserHights1
            // 
            this.laserHights1.Location = new System.Drawing.Point(2, 340);
            this.laserHights1.Name = "laserHights1";
            this.laserHights1.Size = new System.Drawing.Size(183, 137);
            this.laserHights1.TabIndex = 89;
            // 
            // btn_Cylinder
            // 
            this.btn_Cylinder.Checked = true;
            this.btn_Cylinder.Location = new System.Drawing.Point(191, 340);
            this.btn_Cylinder.Name = "btn_Cylinder";
            this.btn_Cylinder.OFF_Color = System.Drawing.Color.Red;
            this.btn_Cylinder.OFF_Text = "定位气缸";
            this.btn_Cylinder.ON_Color = System.Drawing.Color.LimeGreen;
            this.btn_Cylinder.ON_Text = "定位气缸";
            this.btn_Cylinder.Size = new System.Drawing.Size(84, 36);
            this.btn_Cylinder.TabIndex = 105;
            this.btn_Cylinder.Trigger += new System.Action<BZGUI.Bool>(this.btn_Cylinder_Trigger);
            // 
            // FrmMMSManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btn_Cylinder);
            this.Controls.Add(this.laserHights1);
            this.Controls.Add(this.taskControlPanel1);
            this.Controls.Add(this.btn_ManualPDCA);
            this.Controls.Add(this.btn_OutputGRR);
            this.Controls.Add(this.xtaskStateRichList1);
            this.Controls.Add(this.xtaskStateBar1);
            this.Controls.Add(this.btn_LaserCal);
            this.Controls.Add(this.teach1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMMSManual";
            this.Text = "FrmMMSManual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMMSManual_FormClosed);
            this.Load += new System.EventHandler(this.FrmMMSManual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XtaskStateBar xtaskStateBar1;
        private System.Windows.Forms.Button btn_LaserCal;
        private Teach teach1;
        private System.Windows.Forms.Button btn_OutputGRR;
        private System.Windows.Forms.Button btn_ManualPDCA;
        private XCore.XtaskStateRichList xtaskStateRichList1;
        private TaskControlPanel taskControlPanel1;
        private LaserHights laserHights1;
        private Bool btn_Cylinder;
    }
}