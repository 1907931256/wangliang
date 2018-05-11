namespace BZGUI
{
    partial class FrmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManual));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Task1 = new System.Windows.Forms.TabPage();
            this.panel_Manual = new System.Windows.Forms.Panel();
            this.SSH = new System.Windows.Forms.TabPage();
            this.panel_SSH = new System.Windows.Forms.Panel();
            this.IO = new System.Windows.Forms.TabPage();
            this.motorStatus1 = new BZGUI.MotorStatus();
            this.outputClass1 = new BZGUI.OutputClass();
            this.inputClass1 = new BZGUI.InputClass();
            this.PAxis = new System.Windows.Forms.TabPage();
            this.paraAxis1 = new BZGUI.ParaAxis();
            this.Help = new System.Windows.Forms.TabPage();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label160 = new System.Windows.Forms.Label();
            this.Label151 = new System.Windows.Forms.Label();
            this.Label149 = new System.Windows.Forms.Label();
            this.Label145 = new System.Windows.Forms.Label();
            this.Label159 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Task1.SuspendLayout();
            this.SSH.SuspendLayout();
            this.IO.SuspendLayout();
            this.PAxis.SuspendLayout();
            this.Help.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Task1);
            this.tabControl1.Controls.Add(this.SSH);
            this.tabControl1.Controls.Add(this.IO);
            this.tabControl1.Controls.Add(this.PAxis);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 693);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // Task1
            // 
            this.Task1.BackColor = System.Drawing.SystemColors.Control;
            this.Task1.Controls.Add(this.panel_Manual);
            this.Task1.Location = new System.Drawing.Point(4, 25);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(993, 664);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "测试工站";
            // 
            // panel_Manual
            // 
            this.panel_Manual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Manual.Location = new System.Drawing.Point(3, 3);
            this.panel_Manual.Name = "panel_Manual";
            this.panel_Manual.Size = new System.Drawing.Size(987, 658);
            this.panel_Manual.TabIndex = 1;
            // 
            // SSH
            // 
            this.SSH.Controls.Add(this.panel_SSH);
            this.SSH.Location = new System.Drawing.Point(4, 25);
            this.SSH.Name = "SSH";
            this.SSH.Size = new System.Drawing.Size(993, 664);
            this.SSH.TabIndex = 2;
            this.SSH.Text = "SSH调试";
            this.SSH.UseVisualStyleBackColor = true;
            // 
            // panel_SSH
            // 
            this.panel_SSH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SSH.Location = new System.Drawing.Point(0, 0);
            this.panel_SSH.Name = "panel_SSH";
            this.panel_SSH.Size = new System.Drawing.Size(993, 664);
            this.panel_SSH.TabIndex = 0;
            // 
            // IO
            // 
            this.IO.Controls.Add(this.motorStatus1);
            this.IO.Controls.Add(this.outputClass1);
            this.IO.Controls.Add(this.inputClass1);
            this.IO.Location = new System.Drawing.Point(4, 25);
            this.IO.Name = "IO";
            this.IO.Size = new System.Drawing.Size(993, 664);
            this.IO.TabIndex = 4;
            this.IO.Text = "输入输出";
            this.IO.UseVisualStyleBackColor = true;
            // 
            // motorStatus1
            // 
            this.motorStatus1.Location = new System.Drawing.Point(315, 390);
            this.motorStatus1.Name = "motorStatus1";
            this.motorStatus1.Size = new System.Drawing.Size(417, 151);
            this.motorStatus1.TabIndex = 0;
            this.motorStatus1.Tag = "0(0,1)(0,2)(0,3)(0,4)";
            // 
            // outputClass1
            // 
            this.outputClass1.Location = new System.Drawing.Point(316, 3);
            this.outputClass1.Name = "outputClass1";
            this.outputClass1.Size = new System.Drawing.Size(333, 371);
            this.outputClass1.TabIndex = 1;
            this.outputClass1.Tag = "0";
            // 
            // inputClass1
            // 
            this.inputClass1.Location = new System.Drawing.Point(5, 3);
            this.inputClass1.Name = "inputClass1";
            this.inputClass1.Size = new System.Drawing.Size(305, 539);
            this.inputClass1.TabIndex = 0;
            this.inputClass1.Tag = "0";
            // 
            // PAxis
            // 
            this.PAxis.Controls.Add(this.paraAxis1);
            this.PAxis.Location = new System.Drawing.Point(4, 25);
            this.PAxis.Name = "PAxis";
            this.PAxis.Size = new System.Drawing.Size(993, 664);
            this.PAxis.TabIndex = 6;
            this.PAxis.Text = "ParaAixs";
            this.PAxis.UseVisualStyleBackColor = true;
            // 
            // paraAxis1
            // 
            this.paraAxis1.Location = new System.Drawing.Point(5, 3);
            this.paraAxis1.Name = "paraAxis1";
            this.paraAxis1.Size = new System.Drawing.Size(724, 427);
            this.paraAxis1.TabIndex = 0;
            // 
            // Help
            // 
            this.Help.Controls.Add(this.GroupBox5);
            this.Help.Location = new System.Drawing.Point(4, 25);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(993, 664);
            this.Help.TabIndex = 7;
            this.Help.Text = "帮助";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // GroupBox5
            // 
            this.GroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.GroupBox5.Controls.Add(this.Label160);
            this.GroupBox5.Controls.Add(this.Label151);
            this.GroupBox5.Controls.Add(this.Label149);
            this.GroupBox5.Controls.Add(this.Label145);
            this.GroupBox5.Controls.Add(this.Label159);
            this.GroupBox5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox5.Location = new System.Drawing.Point(5, 3);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(984, 657);
            this.GroupBox5.TabIndex = 2;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "驱动器配置参数";
            // 
            // Label160
            // 
            this.Label160.AutoSize = true;
            this.Label160.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label160.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label160.Location = new System.Drawing.Point(274, 104);
            this.Label160.Name = "Label160";
            this.Label160.Size = new System.Drawing.Size(174, 21);
            this.Label160.TabIndex = 17;
            this.Label160.Text = "◆条码枪:192.168.10.55";
            // 
            // Label151
            // 
            this.Label151.AutoSize = true;
            this.Label151.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label151.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label151.Location = new System.Drawing.Point(476, 104);
            this.Label151.Name = "Label151";
            this.Label151.Size = new System.Drawing.Size(161, 21);
            this.Label151.TabIndex = 16;
            this.Label151.Text = "◆PDCA:169.254.0.10";
            // 
            // Label149
            // 
            this.Label149.AutoSize = true;
            this.Label149.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label149.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label149.Location = new System.Drawing.Point(32, 104);
            this.Label149.Name = "Label149";
            this.Label149.Size = new System.Drawing.Size(237, 21);
            this.Label149.TabIndex = 14;
            this.Label149.Text = "网络IP：◆交换机:192.168.10.68";
            // 
            // Label145
            // 
            this.Label145.AutoSize = true;
            this.Label145.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label145.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label145.Location = new System.Drawing.Point(32, 69);
            this.Label145.Name = "Label145";
            this.Label145.Size = new System.Drawing.Size(692, 21);
            this.Label145.TabIndex = 11;
            this.Label145.Text = "注意：P2-08 :10 为复位伺服，需要断电后，重新设置参数      P1-37 :1-100旋转轴刚性调整参数";
            // 
            // Label159
            // 
            this.Label159.AutoSize = true;
            this.Label159.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label159.Location = new System.Drawing.Point(31, 36);
            this.Label159.Name = "Label159";
            this.Label159.Size = new System.Drawing.Size(715, 21);
            this.Label159.TabIndex = 1;
            this.Label159.Text = "测试Y轴：◆P1-00:1001 ◆ P1-01:0000 ◆ P1-44:16 ◆ P1-45:1 ◆P2-15:122 ◆P2-16:123 ◆P2-17:1" +
    "21";
            // 
            // FrmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 692);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManual_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmManual_FormClosed);
            this.Load += new System.EventHandler(this.FrmManual_Load);
            this.SizeChanged += new System.EventHandler(this.FrmManual_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.SSH.ResumeLayout(false);
            this.IO.ResumeLayout(false);
            this.PAxis.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SSH;
        private System.Windows.Forms.TabPage IO;
        private System.Windows.Forms.TabPage PAxis;
        private InputClass inputClass1;
        private OutputClass outputClass1;
        private MotorStatus motorStatus1;
        private ParaAxis paraAxis1;
        private System.Windows.Forms.TabPage Help;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label Label160;
        internal System.Windows.Forms.Label Label151;
        internal System.Windows.Forms.Label Label149;
        internal System.Windows.Forms.Label Label145;
        internal System.Windows.Forms.Label Label159;
        private System.Windows.Forms.Panel panel_SSH;
        private System.Windows.Forms.TabPage Task1;
        private System.Windows.Forms.Panel panel_Manual;
    }
}