
namespace BZGUI
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
            this.Btn_ProductionMode = new BoTech.Button();
            this.Panel_CPK = new BoTech.Panel();
            this.Lab_CpkCount = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Lab_Cpkstatues = new System.Windows.Forms.Label();
            this.btn_ExitCPK = new System.Windows.Forms.Button();
            this.Btn_CPKMode = new BoTech.Button();
            this.Btn_EngneeringMode = new BoTech.Button();
            this.Btn_MachineInfo = new BoTech.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Panel3 = new BoTech.Panel();
            this.Panel1 = new BoTech.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new BoTech.Panel();
            this.Btn_OpenCCDFile = new BoTech.Button();
            this.Btn_Home = new BoTech.Button();
            this.Btn_OpenDataFile = new BoTech.Button();
            this.Btn_Stop = new BoTech.Button();
            this.Btn_Pause = new BoTech.Button();
            this.Btn_Start = new BoTech.Button();
            this.Btn_AlarmHistory = new BoTech.Button();
            this.Btn_RunInfo = new BoTech.Button();
            this.Btn_CCDSetting = new BoTech.Button();
            this.Btn_ParSetting = new BoTech.Button();
            this.Btn_Production = new BoTech.Button();
            this.Panel_CPK.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(166, 303);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(100, 32);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Login.Enabled = false;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.Black;
            this.Btn_Login.Location = new System.Drawing.Point(26, 304);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 32);
            this.Btn_Login.TabIndex = 24;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // MainPassword
            // 
            this.MainPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MainPassword.Enabled = false;
            this.MainPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPassword.Location = new System.Drawing.Point(26, 229);
            this.MainPassword.Name = "MainPassword";
            this.MainPassword.PasswordChar = '*';
            this.MainPassword.Size = new System.Drawing.Size(240, 31);
            this.MainPassword.TabIndex = 23;
            this.MainPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainPassword.DoubleClick += new System.EventHandler(this.MainPassword_DoubleClick);
            this.MainPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainPassword_KeyPress);
            // 
            // MainUserName
            // 
            this.MainUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MainUserName.Enabled = false;
            this.MainUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainUserName.FormattingEnabled = true;
            this.MainUserName.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.MainUserName.Location = new System.Drawing.Point(26, 150);
            this.MainUserName.Name = "MainUserName";
            this.MainUserName.Size = new System.Drawing.Size(240, 33);
            this.MainUserName.TabIndex = 22;
            this.MainUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainUserName_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(23, 199);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 17);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(23, 115);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 17);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "User Name";
            this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
            // 
            // Btn_ProductionMode
            // 
            this.Btn_ProductionMode.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_ProductionMode.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_ProductionMode.BZ_Radius = 10;
            this.Btn_ProductionMode.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_ProductionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ProductionMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_ProductionMode.Location = new System.Drawing.Point(171, 108);
            this.Btn_ProductionMode.Name = "Btn_ProductionMode";
            this.Btn_ProductionMode.Size = new System.Drawing.Size(300, 60);
            this.Btn_ProductionMode.TabIndex = 48;
            this.Btn_ProductionMode.Text = "Production Mode";
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
            this.Panel_CPK.Controls.Add(this.btn_ExitCPK);
            this.Panel_CPK.Location = new System.Drawing.Point(195, 440);
            this.Panel_CPK.Name = "Panel_CPK";
            this.Panel_CPK.Size = new System.Drawing.Size(200, 194);
            this.Panel_CPK.TabIndex = 47;
            this.Panel_CPK.Visible = false;
            // 
            // Lab_CpkCount
            // 
            this.Lab_CpkCount.AutoSize = true;
            this.Lab_CpkCount.BackColor = System.Drawing.Color.PaleGreen;
            this.Lab_CpkCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_CpkCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lab_CpkCount.Location = new System.Drawing.Point(68, 105);
            this.Lab_CpkCount.Name = "Lab_CpkCount";
            this.Lab_CpkCount.Size = new System.Drawing.Size(55, 25);
            this.Lab_CpkCount.TabIndex = 29;
            this.Lab_CpkCount.Text = "0/32";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.PaleGreen;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(17, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(168, 29);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Wizard Count";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lab_Cpkstatues
            // 
            this.Lab_Cpkstatues.AutoSize = true;
            this.Lab_Cpkstatues.BackColor = System.Drawing.Color.PaleGreen;
            this.Lab_Cpkstatues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Cpkstatues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lab_Cpkstatues.Location = new System.Drawing.Point(57, 66);
            this.Lab_Cpkstatues.Name = "Lab_Cpkstatues";
            this.Lab_Cpkstatues.Size = new System.Drawing.Size(81, 17);
            this.Lab_Cpkstatues.TabIndex = 28;
            this.Lab_Cpkstatues.Text = "On_Going";
            // 
            // btn_ExitCPK
            // 
            this.btn_ExitCPK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_ExitCPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitCPK.ForeColor = System.Drawing.Color.Black;
            this.btn_ExitCPK.Location = new System.Drawing.Point(51, 146);
            this.btn_ExitCPK.Name = "btn_ExitCPK";
            this.btn_ExitCPK.Size = new System.Drawing.Size(100, 32);
            this.btn_ExitCPK.TabIndex = 27;
            this.btn_ExitCPK.Text = "Exit CPK";
            this.btn_ExitCPK.UseVisualStyleBackColor = false;
            this.btn_ExitCPK.Click += new System.EventHandler(this.btn_ExitCPK_Click);
            // 
            // Btn_CPKMode
            // 
            this.Btn_CPKMode.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_CPKMode.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_CPKMode.BZ_Radius = 10;
            this.Btn_CPKMode.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_CPKMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPKMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_CPKMode.Location = new System.Drawing.Point(171, 318);
            this.Btn_CPKMode.Name = "Btn_CPKMode";
            this.Btn_CPKMode.Size = new System.Drawing.Size(300, 60);
            this.Btn_CPKMode.TabIndex = 46;
            this.Btn_CPKMode.Text = "CPK Mode";
            this.Btn_CPKMode.UseVisualStyleBackColor = true;
            this.Btn_CPKMode.Click += new System.EventHandler(this.Btn_CPKMode_Click);
            // 
            // Btn_EngneeringMode
            // 
            this.Btn_EngneeringMode.BZ_BackColor = System.Drawing.Color.LightGray;
            this.Btn_EngneeringMode.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_EngneeringMode.BZ_Radius = 10;
            this.Btn_EngneeringMode.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_EngneeringMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EngneeringMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_EngneeringMode.Location = new System.Drawing.Point(171, 213);
            this.Btn_EngneeringMode.Name = "Btn_EngneeringMode";
            this.Btn_EngneeringMode.Size = new System.Drawing.Size(300, 60);
            this.Btn_EngneeringMode.TabIndex = 45;
            this.Btn_EngneeringMode.Text = "Engineering Mode";
            this.Btn_EngneeringMode.UseVisualStyleBackColor = true;
            this.Btn_EngneeringMode.Click += new System.EventHandler(this.Btn_EngneeringMode_Click);
            // 
            // Btn_MachineInfo
            // 
            this.Btn_MachineInfo.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_MachineInfo.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_MachineInfo.BZ_Radius = 11;
            this.Btn_MachineInfo.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_MachineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MachineInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_MachineInfo.Location = new System.Drawing.Point(330, 5);
            this.Btn_MachineInfo.Name = "Btn_MachineInfo";
            this.Btn_MachineInfo.Size = new System.Drawing.Size(160, 60);
            this.Btn_MachineInfo.TabIndex = 52;
            this.Btn_MachineInfo.Text = "Blogo-001";
            this.Btn_MachineInfo.UseVisualStyleBackColor = true;
            this.Btn_MachineInfo.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Silver;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Location = new System.Drawing.Point(11, 228);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(73, 14);
            this.TextBox1.TabIndex = 45;
            this.TextBox1.Visible = false;
            // 
            // Panel3
            // 
            this.Panel3.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.BZ_Radius = 11;
            this.Panel3.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel3.Controls.Add(this.TextBox1);
            this.Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.Location = new System.Drawing.Point(690, 462);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(328, 261);
            this.Panel3.TabIndex = 46;
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
            this.Panel1.Location = new System.Drawing.Point(690, 70);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(328, 387);
            this.Panel1.TabIndex = 54;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.ErrorImage")));
            this.PictureBox2.Location = new System.Drawing.Point(26, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 85);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
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
            this.Panel2.Location = new System.Drawing.Point(5, 70);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(680, 653);
            this.Panel2.TabIndex = 55;
            // 
            // Btn_OpenCCDFile
            // 
            this.Btn_OpenCCDFile.BZ_BackColor = System.Drawing.Color.White;
            this.Btn_OpenCCDFile.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_OpenCCDFile.BZ_Radius = 11;
            this.Btn_OpenCCDFile.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_OpenCCDFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenCCDFile.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_OpenCCDFile.Image = ((System.Drawing.Image)(resources.GetObject("Btn_OpenCCDFile.Image")));
            this.Btn_OpenCCDFile.Location = new System.Drawing.Point(893, 5);
            this.Btn_OpenCCDFile.Name = "Btn_OpenCCDFile";
            this.Btn_OpenCCDFile.Size = new System.Drawing.Size(60, 60);
            this.Btn_OpenCCDFile.TabIndex = 53;
            this.Btn_OpenCCDFile.UseVisualStyleBackColor = true;
            this.Btn_OpenCCDFile.Click += new System.EventHandler(this.Btn_OpenCCDFile_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Home.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Home.BZ_Radius = 11;
            this.Btn_Home.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Home.ForeColor = System.Drawing.Color.Black;
            this.Btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Home.Image")));
            this.Btn_Home.Location = new System.Drawing.Point(958, 5);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(60, 60);
            this.Btn_Home.TabIndex = 50;
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_OpenDataFile
            // 
            this.Btn_OpenDataFile.BZ_BackColor = System.Drawing.Color.White;
            this.Btn_OpenDataFile.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_OpenDataFile.BZ_Radius = 11;
            this.Btn_OpenDataFile.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_OpenDataFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenDataFile.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_OpenDataFile.Image = ((System.Drawing.Image)(resources.GetObject("Btn_OpenDataFile.Image")));
            this.Btn_OpenDataFile.Location = new System.Drawing.Point(828, 5);
            this.Btn_OpenDataFile.Name = "Btn_OpenDataFile";
            this.Btn_OpenDataFile.Size = new System.Drawing.Size(60, 60);
            this.Btn_OpenDataFile.TabIndex = 52;
            this.Btn_OpenDataFile.UseVisualStyleBackColor = true;
            this.Btn_OpenDataFile.Click += new System.EventHandler(this.Btn_OpenDataFile_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Stop.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Stop.BZ_Radius = 11;
            this.Btn_Stop.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Stop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Stop.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Stop.Image")));
            this.Btn_Stop.Location = new System.Drawing.Point(625, 5);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(60, 60);
            this.Btn_Stop.TabIndex = 52;
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Pause.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Pause.BZ_Radius = 11;
            this.Btn_Pause.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Pause.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Pause.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Pause.Image")));
            this.Btn_Pause.Location = new System.Drawing.Point(560, 5);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(60, 60);
            this.Btn_Pause.TabIndex = 52;
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Start.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Start.BZ_Radius = 11;
            this.Btn_Start.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Start.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Start.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Start.Image")));
            this.Btn_Start.Location = new System.Drawing.Point(495, 5);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(60, 60);
            this.Btn_Start.TabIndex = 52;
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
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
            this.Btn_AlarmHistory.Location = new System.Drawing.Point(265, 5);
            this.Btn_AlarmHistory.Name = "Btn_AlarmHistory";
            this.Btn_AlarmHistory.Size = new System.Drawing.Size(60, 60);
            this.Btn_AlarmHistory.TabIndex = 52;
            this.Btn_AlarmHistory.UseVisualStyleBackColor = true;
            this.Btn_AlarmHistory.Click += new System.EventHandler(this.Btn_Production_Click);
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
            this.Btn_RunInfo.Location = new System.Drawing.Point(200, 5);
            this.Btn_RunInfo.Name = "Btn_RunInfo";
            this.Btn_RunInfo.Size = new System.Drawing.Size(60, 60);
            this.Btn_RunInfo.TabIndex = 52;
            this.Btn_RunInfo.UseVisualStyleBackColor = true;
            this.Btn_RunInfo.Click += new System.EventHandler(this.Btn_Production_Click);
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
            this.Btn_CCDSetting.Location = new System.Drawing.Point(135, 5);
            this.Btn_CCDSetting.Name = "Btn_CCDSetting";
            this.Btn_CCDSetting.Size = new System.Drawing.Size(60, 60);
            this.Btn_CCDSetting.TabIndex = 52;
            this.Btn_CCDSetting.UseVisualStyleBackColor = true;
            this.Btn_CCDSetting.Click += new System.EventHandler(this.Btn_Production_Click);
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
            this.Btn_ParSetting.Location = new System.Drawing.Point(70, 5);
            this.Btn_ParSetting.Name = "Btn_ParSetting";
            this.Btn_ParSetting.Size = new System.Drawing.Size(60, 60);
            this.Btn_ParSetting.TabIndex = 51;
            this.Btn_ParSetting.UseVisualStyleBackColor = true;
            this.Btn_ParSetting.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Btn_Production
            // 
            this.Btn_Production.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Production.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Production.BZ_Radius = 11;
            this.Btn_Production.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Production.ForeColor = System.Drawing.Color.Black;
            this.Btn_Production.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Production.Image")));
            this.Btn_Production.Location = new System.Drawing.Point(5, 5);
            this.Btn_Production.Name = "Btn_Production";
            this.Btn_Production.Size = new System.Drawing.Size(60, 60);
            this.Btn_Production.TabIndex = 49;
            this.Btn_Production.UseVisualStyleBackColor = false;
            this.Btn_Production.Click += new System.EventHandler(this.Btn_Production_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1024, 730);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.Text = "BAM";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Panel_CPK.ResumeLayout(false);
            this.Panel_CPK.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
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
        internal System.Windows.Forms.Button btn_ExitCPK;
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
