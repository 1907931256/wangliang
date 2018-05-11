namespace BZGUI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pageContainer = new System.Windows.Forms.Panel();
            this.Btn_MachineInfo = new BoTech.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Stop = new BZ.UI.RoundButton();
            this.Btn_Pause = new BZ.UI.RoundButton();
            this.Btn_Start = new BZ.UI.RoundButton();
            this.Btn_OpenCCDFile = new BoTech.Button();
            this.Btn_Home = new BoTech.Button();
            this.Btn_OpenDataFile = new BoTech.Button();
            this.Btn_AlarmHistory = new BoTech.Button();
            this.Btn_RunInfo = new BoTech.Button();
            this.Btn_CCDSetting = new BoTech.Button();
            this.Btn_ParSetting = new BoTech.Button();
            this.Btn_Production = new BoTech.Button();
            this.SuspendLayout();
            // 
            // pageContainer
            // 
            this.pageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageContainer.BackColor = System.Drawing.Color.White;
            this.pageContainer.Location = new System.Drawing.Point(0, 66);
            this.pageContainer.Name = "pageContainer";
            this.pageContainer.Size = new System.Drawing.Size(1022, 625);
            this.pageContainer.TabIndex = 77;
            // 
            // Btn_MachineInfo
            // 
            this.Btn_MachineInfo.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_MachineInfo.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_MachineInfo.BZ_Radius = 11;
            this.Btn_MachineInfo.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_MachineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MachineInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_MachineInfo.Location = new System.Drawing.Point(329, 3);
            this.Btn_MachineInfo.Name = "Btn_MachineInfo";
            this.Btn_MachineInfo.Size = new System.Drawing.Size(160, 60);
            this.Btn_MachineInfo.TabIndex = 61;
            this.Btn_MachineInfo.Text = "Blogo-001";
            this.Btn_MachineInfo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(87)))));
            this.Btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Stop.BZ_Radius = ((byte)(6));
            this.Btn_Stop.BZ_Version = "V1.0.0";
            this.Btn_Stop.FlatAppearance.BorderSize = 0;
            this.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.Btn_Stop.Image = global::BZGUI.Properties.Resources.Stop_White;
            this.Btn_Stop.Location = new System.Drawing.Point(690, 3);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(60, 60);
            this.Btn_Stop.TabIndex = 80;
            this.Btn_Stop.UseVisualStyleBackColor = false;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Pause.BZ_Radius = ((byte)(6));
            this.Btn_Pause.BZ_Version = "V1.0.0";
            this.Btn_Pause.FlatAppearance.BorderSize = 0;
            this.Btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pause.ForeColor = System.Drawing.Color.Black;
            this.Btn_Pause.Image = global::BZGUI.Properties.Resources.Pause_White;
            this.Btn_Pause.Location = new System.Drawing.Point(625, 3);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(60, 60);
            this.Btn_Pause.TabIndex = 79;
            this.Btn_Pause.Tag = "0";
            this.Btn_Pause.UseVisualStyleBackColor = false;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Start.BZ_Radius = ((byte)(6));
            this.Btn_Start.BZ_Version = "V1.0.0";
            this.Btn_Start.FlatAppearance.BorderSize = 0;
            this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Start.ForeColor = System.Drawing.Color.Black;
            this.Btn_Start.Image = global::BZGUI.Properties.Resources.play_White;
            this.Btn_Start.Location = new System.Drawing.Point(560, 3);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(60, 60);
            this.Btn_Start.TabIndex = 78;
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_OpenCCDFile
            // 
            this.Btn_OpenCCDFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OpenCCDFile.BZ_BackColor = System.Drawing.Color.White;
            this.Btn_OpenCCDFile.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_OpenCCDFile.BZ_Radius = 11;
            this.Btn_OpenCCDFile.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_OpenCCDFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenCCDFile.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_OpenCCDFile.Image = ((System.Drawing.Image)(resources.GetObject("Btn_OpenCCDFile.Image")));
            this.Btn_OpenCCDFile.Location = new System.Drawing.Point(895, 3);
            this.Btn_OpenCCDFile.Name = "Btn_OpenCCDFile";
            this.Btn_OpenCCDFile.Size = new System.Drawing.Size(60, 60);
            this.Btn_OpenCCDFile.TabIndex = 65;
            this.Btn_OpenCCDFile.UseVisualStyleBackColor = true;
            this.Btn_OpenCCDFile.Click += new System.EventHandler(this.Btn_OpenCCDFile_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Home.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Home.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Home.BZ_Radius = 11;
            this.Btn_Home.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Home.ForeColor = System.Drawing.Color.Black;
            this.Btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Home.Image")));
            this.Btn_Home.Location = new System.Drawing.Point(960, 3);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(60, 60);
            this.Btn_Home.TabIndex = 55;
            this.Btn_Home.UseVisualStyleBackColor = false;
            // 
            // Btn_OpenDataFile
            // 
            this.Btn_OpenDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OpenDataFile.BZ_BackColor = System.Drawing.Color.White;
            this.Btn_OpenDataFile.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_OpenDataFile.BZ_Radius = 11;
            this.Btn_OpenDataFile.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_OpenDataFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenDataFile.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_OpenDataFile.Image = ((System.Drawing.Image)(resources.GetObject("Btn_OpenDataFile.Image")));
            this.Btn_OpenDataFile.Location = new System.Drawing.Point(830, 3);
            this.Btn_OpenDataFile.Name = "Btn_OpenDataFile";
            this.Btn_OpenDataFile.Size = new System.Drawing.Size(60, 60);
            this.Btn_OpenDataFile.TabIndex = 57;
            this.Btn_OpenDataFile.UseVisualStyleBackColor = true;
            this.Btn_OpenDataFile.Click += new System.EventHandler(this.Btn_OpenDataFile_Click);
            // 
            // Btn_AlarmHistory
            // 
            this.Btn_AlarmHistory.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_AlarmHistory.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_AlarmHistory.BZ_Radius = 11;
            this.Btn_AlarmHistory.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_AlarmHistory.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_AlarmHistory.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_AlarmHistory.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AlarmHistory.Image")));
            this.Btn_AlarmHistory.Location = new System.Drawing.Point(264, 3);
            this.Btn_AlarmHistory.Name = "Btn_AlarmHistory";
            this.Btn_AlarmHistory.Size = new System.Drawing.Size(60, 60);
            this.Btn_AlarmHistory.TabIndex = 62;
            this.Btn_AlarmHistory.UseVisualStyleBackColor = true;
            // 
            // Btn_RunInfo
            // 
            this.Btn_RunInfo.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_RunInfo.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_RunInfo.BZ_Radius = 11;
            this.Btn_RunInfo.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_RunInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RunInfo.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_RunInfo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RunInfo.Image")));
            this.Btn_RunInfo.Location = new System.Drawing.Point(199, 3);
            this.Btn_RunInfo.Name = "Btn_RunInfo";
            this.Btn_RunInfo.Size = new System.Drawing.Size(60, 60);
            this.Btn_RunInfo.TabIndex = 63;
            this.Btn_RunInfo.UseVisualStyleBackColor = true;
            // 
            // Btn_CCDSetting
            // 
            this.Btn_CCDSetting.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_CCDSetting.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_CCDSetting.BZ_Radius = 11;
            this.Btn_CCDSetting.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_CCDSetting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_CCDSetting.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_CCDSetting.Image = global::BZGUI.Properties.Resources.Camera45x45;
            this.Btn_CCDSetting.Location = new System.Drawing.Point(134, 3);
            this.Btn_CCDSetting.Name = "Btn_CCDSetting";
            this.Btn_CCDSetting.Size = new System.Drawing.Size(60, 60);
            this.Btn_CCDSetting.TabIndex = 64;
            this.Btn_CCDSetting.UseVisualStyleBackColor = true;
            // 
            // Btn_ParSetting
            // 
            this.Btn_ParSetting.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_ParSetting.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_ParSetting.BZ_Radius = 11;
            this.Btn_ParSetting.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_ParSetting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_ParSetting.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_ParSetting.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ParSetting.Image")));
            this.Btn_ParSetting.Location = new System.Drawing.Point(69, 3);
            this.Btn_ParSetting.Name = "Btn_ParSetting";
            this.Btn_ParSetting.Size = new System.Drawing.Size(60, 60);
            this.Btn_ParSetting.TabIndex = 56;
            this.Btn_ParSetting.UseVisualStyleBackColor = true;
            // 
            // Btn_Production
            // 
            this.Btn_Production.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Production.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Production.BZ_Radius = 11;
            this.Btn_Production.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Production.ForeColor = System.Drawing.Color.Black;
            this.Btn_Production.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Production.Image")));
            this.Btn_Production.Location = new System.Drawing.Point(4, 3);
            this.Btn_Production.Name = "Btn_Production";
            this.Btn_Production.Size = new System.Drawing.Size(60, 60);
            this.Btn_Production.TabIndex = 54;
            this.Btn_Production.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1024, 692);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.pageContainer);
            this.Controls.Add(this.Btn_OpenCCDFile);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_OpenDataFile);
            this.Controls.Add(this.Btn_MachineInfo);
            this.Controls.Add(this.Btn_AlarmHistory);
            this.Controls.Add(this.Btn_RunInfo);
            this.Controls.Add(this.Btn_CCDSetting);
            this.Controls.Add(this.Btn_ParSetting);
            this.Controls.Add(this.Btn_Production);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageContainer;
        internal BoTech.Button Btn_Home;
        internal BoTech.Button Btn_OpenCCDFile;
        internal BoTech.Button Btn_OpenDataFile;
        internal BoTech.Button Btn_MachineInfo;
        internal BoTech.Button Btn_AlarmHistory;
        internal BoTech.Button Btn_RunInfo;
        internal BoTech.Button Btn_CCDSetting;
        internal BoTech.Button Btn_ParSetting;
        internal BoTech.Button Btn_Production;
        private System.Windows.Forms.Timer timer1;
        internal BZ.UI.RoundButton Btn_Stop;
        internal BZ.UI.RoundButton Btn_Pause;
        internal BZ.UI.RoundButton Btn_Start;
    }
}