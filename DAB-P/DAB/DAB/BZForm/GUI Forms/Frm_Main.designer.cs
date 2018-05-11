
namespace DAB
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_Main : System.Windows.Forms.Form
	{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.MainPassword = new System.Windows.Forms.TextBox();
            this.MainUserName = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_ProductionMode = new BoTech.Button();
            this.Panel_CPK = new BoTech.Panel();
            this.Lab_CpkCount = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Lab_Cpkstatues = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Btn_CPKMode = new BoTech.Button();
            this.Btn_EngneeringMode = new BoTech.Button();
            this.Btn_MachineInfo = new BoTech.Button();
            this.Btn_Production = new BoTech.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel3 = new BoTech.Panel();
            this.Btn_ParSetting = new BoTech.Button();
            this.Btn_CCDSetting = new BoTech.Button();
            this.Btn_RunInfo = new BoTech.Button();
            this.Btn_AlarmHistory = new BoTech.Button();
            this.Btn_Start = new BoTech.Button();
            this.Btn_Pause = new BoTech.Button();
            this.Btn_Stop = new BoTech.Button();
            this.Btn_OpenDataFile = new BoTech.Button();
            this.Btn_Home = new BoTech.Button();
            this.Btn_OpenCCDFile = new BoTech.Button();
            this.Panel1 = new BoTech.Panel();
            this.Panel2 = new BoTech.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel_CPK.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.Btn_Exit, "Btn_Exit");
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.Btn_Login, "Btn_Login");
            this.Btn_Login.ForeColor = System.Drawing.Color.Black;
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // MainPassword
            // 
            this.MainPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.MainPassword, "MainPassword");
            this.MainPassword.Name = "MainPassword";
            this.MainPassword.DoubleClick += new System.EventHandler(this.MainPassword_DoubleClick);
            this.MainPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainPassword_KeyPress);
            // 
            // MainUserName
            // 
            this.MainUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MainUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.MainUserName, "MainUserName");
            this.MainUserName.FormattingEnabled = true;
            this.MainUserName.Name = "MainUserName";
            this.MainUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainUserName_KeyPress);
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Name = "Label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Name = "Label1";
            this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.PictureBox2, "PictureBox2");
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.TabStop = false;
            // 
            // Btn_ProductionMode
            // 
            this.Btn_ProductionMode.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_ProductionMode.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_ProductionMode.BZ_Radius = 10;
            this.Btn_ProductionMode.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_ProductionMode, "Btn_ProductionMode");
            this.Btn_ProductionMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_ProductionMode.Name = "Btn_ProductionMode";
            this.Btn_ProductionMode.UseVisualStyleBackColor = true;
            this.Btn_ProductionMode.Click += new System.EventHandler(this.Btn_ProductionMode_Click);
            // 
            // Panel_CPK
            // 
            this.Panel_CPK.BZ_Color = System.Drawing.Color.PaleGreen;
            this.Panel_CPK.BZ_Radius = 11;
            this.Panel_CPK.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel_CPK.Controls.Add(this.Lab_CpkCount);
            this.Panel_CPK.Controls.Add(this.Label3);
            this.Panel_CPK.Controls.Add(this.Lab_Cpkstatues);
            this.Panel_CPK.Controls.Add(this.Button1);
            resources.ApplyResources(this.Panel_CPK, "Panel_CPK");
            this.Panel_CPK.Name = "Panel_CPK";
            // 
            // Lab_CpkCount
            // 
            resources.ApplyResources(this.Lab_CpkCount, "Lab_CpkCount");
            this.Lab_CpkCount.BackColor = System.Drawing.Color.PaleGreen;
            this.Lab_CpkCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lab_CpkCount.Name = "Lab_CpkCount";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.BackColor = System.Drawing.Color.PaleGreen;
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Name = "Label3";
            // 
            // Lab_Cpkstatues
            // 
            resources.ApplyResources(this.Lab_Cpkstatues, "Lab_Cpkstatues");
            this.Lab_Cpkstatues.BackColor = System.Drawing.Color.PaleGreen;
            this.Lab_Cpkstatues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lab_Cpkstatues.Name = "Lab_Cpkstatues";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.Button1, "Button1");
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Name = "Button1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn_CPKMode
            // 
            this.Btn_CPKMode.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_CPKMode.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_CPKMode.BZ_Radius = 10;
            this.Btn_CPKMode.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_CPKMode, "Btn_CPKMode");
            this.Btn_CPKMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_CPKMode.Name = "Btn_CPKMode";
            this.Btn_CPKMode.UseVisualStyleBackColor = true;
            this.Btn_CPKMode.Click += new System.EventHandler(this.Btn_CPKMode_Click);
            // 
            // Btn_EngneeringMode
            // 
            this.Btn_EngneeringMode.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_EngneeringMode.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_EngneeringMode.BZ_Radius = 10;
            this.Btn_EngneeringMode.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_EngneeringMode, "Btn_EngneeringMode");
            this.Btn_EngneeringMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_EngneeringMode.Name = "Btn_EngneeringMode";
            this.Btn_EngneeringMode.UseVisualStyleBackColor = true;
            this.Btn_EngneeringMode.Click += new System.EventHandler(this.Btn_EngneeringMode_Click);
            // 
            // Btn_MachineInfo
            // 
            this.Btn_MachineInfo.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_MachineInfo.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_MachineInfo.BZ_Radius = 11;
            this.Btn_MachineInfo.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_MachineInfo, "Btn_MachineInfo");
            this.Btn_MachineInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_MachineInfo.Name = "Btn_MachineInfo";
            this.Btn_MachineInfo.UseVisualStyleBackColor = true;
            this.Btn_MachineInfo.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_Production
            // 
            this.Btn_Production.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Production.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Production.BZ_Radius = 11;
            this.Btn_Production.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Production.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Btn_Production, "Btn_Production");
            this.Btn_Production.Name = "Btn_Production";
            this.Btn_Production.UseVisualStyleBackColor = false;
            this.Btn_Production.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Silver;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TextBox1, "TextBox1");
            this.TextBox1.Name = "TextBox1";
            // 
            // Panel3
            // 
            this.Panel3.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.BZ_Radius = 11;
            this.Panel3.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel3.Controls.Add(this.TextBox1);
            this.Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.Panel3, "Panel3");
            this.Panel3.Name = "Panel3";
            // 
            // Btn_ParSetting
            // 
            this.Btn_ParSetting.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_ParSetting.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_ParSetting.BZ_Radius = 11;
            this.Btn_ParSetting.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_ParSetting, "Btn_ParSetting");
            this.Btn_ParSetting.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_ParSetting.Name = "Btn_ParSetting";
            this.Btn_ParSetting.UseVisualStyleBackColor = true;
            this.Btn_ParSetting.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_CCDSetting
            // 
            this.Btn_CCDSetting.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_CCDSetting.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_CCDSetting.BZ_Radius = 11;
            this.Btn_CCDSetting.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_CCDSetting, "Btn_CCDSetting");
            this.Btn_CCDSetting.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_CCDSetting.Name = "Btn_CCDSetting";
            this.Btn_CCDSetting.UseVisualStyleBackColor = true;
            this.Btn_CCDSetting.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_RunInfo
            // 
            this.Btn_RunInfo.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_RunInfo.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_RunInfo.BZ_Radius = 11;
            this.Btn_RunInfo.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_RunInfo, "Btn_RunInfo");
            this.Btn_RunInfo.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_RunInfo.Name = "Btn_RunInfo";
            this.Btn_RunInfo.UseVisualStyleBackColor = true;
            this.Btn_RunInfo.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_AlarmHistory
            // 
            this.Btn_AlarmHistory.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_AlarmHistory.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_AlarmHistory.BZ_Radius = 11;
            this.Btn_AlarmHistory.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_AlarmHistory, "Btn_AlarmHistory");
            this.Btn_AlarmHistory.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_AlarmHistory.Name = "Btn_AlarmHistory";
            this.Btn_AlarmHistory.UseVisualStyleBackColor = true;
            this.Btn_AlarmHistory.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Start.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Start.BZ_Radius = 11;
            this.Btn_Start.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_Start, "Btn_Start");
            this.Btn_Start.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Pause.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Pause.BZ_Radius = 11;
            this.Btn_Pause.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_Pause, "Btn_Pause");
            this.Btn_Pause.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Stop.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Stop.BZ_Radius = 11;
            this.Btn_Stop.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_Stop, "Btn_Stop");
            this.Btn_Stop.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_OpenDataFile
            // 
            this.Btn_OpenDataFile.BZ_BackColor = System.Drawing.Color.White;
            this.Btn_OpenDataFile.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_OpenDataFile.BZ_Radius = 11;
            this.Btn_OpenDataFile.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_OpenDataFile, "Btn_OpenDataFile");
            this.Btn_OpenDataFile.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_OpenDataFile.Name = "Btn_OpenDataFile";
            this.Btn_OpenDataFile.UseVisualStyleBackColor = true;
            this.Btn_OpenDataFile.Click += new System.EventHandler(this.Btn_OpenDataFile_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Home.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Home.BZ_Radius = 11;
            this.Btn_Home.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Home.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Btn_Home, "Btn_Home");
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_OpenCCDFile
            // 
            this.Btn_OpenCCDFile.BZ_BackColor = System.Drawing.Color.White;
            this.Btn_OpenCCDFile.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_OpenCCDFile.BZ_Radius = 11;
            this.Btn_OpenCCDFile.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            resources.ApplyResources(this.Btn_OpenCCDFile, "Btn_OpenCCDFile");
            this.Btn_OpenCCDFile.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_OpenCCDFile.Name = "Btn_OpenCCDFile";
            this.Btn_OpenCCDFile.UseVisualStyleBackColor = true;
            this.Btn_OpenCCDFile.Click += new System.EventHandler(this.Btn_OpenCCDFile_Click);
            // 
            // Panel1
            // 
            this.Panel1.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel1.BZ_Radius = 11;
            this.Panel1.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel1.Controls.Add(this.Btn_Login);
            this.Panel1.Controls.Add(this.Btn_Exit);
            this.Panel1.Controls.Add(this.MainPassword);
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.MainUserName);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // Panel2
            // 
            this.Panel2.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel2.BZ_Radius = 11;
            this.Panel2.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel2.Controls.Add(this.Panel_CPK);
            this.Panel2.Controls.Add(this.Btn_ProductionMode);
            this.Panel2.Controls.Add(this.Btn_CPKMode);
            this.Panel2.Controls.Add(this.Btn_EngneeringMode);
            this.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            resources.ApplyResources(this.Panel2, "Panel2");
            this.Panel2.Name = "Panel2";
            // 
            // Frm_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Btn_OpenCCDFile);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_OpenDataFile);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_MachineInfo);
            this.Controls.Add(this.Btn_AlarmHistory);
            this.Controls.Add(this.Btn_RunInfo);
            this.Controls.Add(this.Btn_CCDSetting);
            this.Controls.Add(this.Btn_ParSetting);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Btn_Production);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResizeBegin += new System.EventHandler(this.Frm_Main_ResizeBegin);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel_CPK.ResumeLayout(false);
            this.Panel_CPK.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        internal System.Windows.Forms.Button Btn_Exit;
        internal System.Windows.Forms.TextBox MainPassword;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Button Btn_Login;
        internal System.Windows.Forms.ComboBox MainUserName;
        internal BoTech.Button Btn_EngneeringMode;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Lab_CpkCount;
        internal System.Windows.Forms.Label Lab_Cpkstatues;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal BoTech.Panel Panel3;
        internal BoTech.Button Btn_CPKMode;
        internal BoTech.Panel Panel_CPK;
        internal BoTech.Button Btn_ProductionMode;
        internal BoTech.Button Btn_Production;
        internal BoTech.Button Btn_ParSetting;
        internal BoTech.Button Btn_MachineInfo;
        internal BoTech.Button Btn_CCDSetting;
        internal BoTech.Button Btn_RunInfo;
        internal BoTech.Button Btn_AlarmHistory;
        internal BoTech.Button Btn_Start;
        internal BoTech.Button Btn_Pause;
        internal BoTech.Button Btn_Stop;
        internal BoTech.Button Btn_OpenDataFile;
        internal BoTech.Button Btn_Home;
        internal BoTech.Button Btn_OpenCCDFile;
        internal BoTech.Panel Panel1;
        internal BoTech.Panel Panel2;	
	}
	
}
