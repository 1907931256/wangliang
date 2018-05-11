namespace BZGUI
{
    partial class PageLogin
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
            this.RoundPanel2 = new BZ.UI.RoundPanel();
            this.btn_Language = new BZ.UI.RoundButton();
            this.Panel_CPK = new BoTech.Panel();
            this.Lab_CpkCount = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Lab_Cpkstatues = new System.Windows.Forms.Label();
            this.btn_ExitCPK = new System.Windows.Forms.Button();
            this.Btn_CPKGRRMode = new BZ.UI.RoundButton();
            this.Btn_EngneeringMode = new BZ.UI.RoundButton();
            this.Btn_ProductionMode = new BZ.UI.RoundButton();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Combo_User = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.RoundPanel1 = new BZ.UI.RoundPanel();
            this.Btn_Home = new BoTech.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.RoundPanel3 = new BZ.UI.RoundPanel();
            this.RoundPanel2.SuspendLayout();
            this.Panel_CPK.SuspendLayout();
            this.RoundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoundPanel2
            // 
            this.RoundPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.RoundPanel2.BZ_AutoBkColor = true;
            this.RoundPanel2.BZ_Radius = ((byte)(6));
            this.RoundPanel2.BZ_Version = "V1.0.0";
            this.RoundPanel2.Controls.Add(this.btn_Language);
            this.RoundPanel2.Controls.Add(this.Panel_CPK);
            this.RoundPanel2.Controls.Add(this.Btn_CPKGRRMode);
            this.RoundPanel2.Controls.Add(this.Btn_EngneeringMode);
            this.RoundPanel2.Controls.Add(this.Btn_ProductionMode);
            this.RoundPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel2.Location = new System.Drawing.Point(4, 0);
            this.RoundPanel2.Name = "RoundPanel2";
            this.RoundPanel2.Size = new System.Drawing.Size(680, 660);
            this.RoundPanel2.TabIndex = 63;
            // 
            // btn_Language
            // 
            this.btn_Language.BackColor = System.Drawing.Color.LightGray;
            this.btn_Language.BZ_Radius = ((byte)(6));
            this.btn_Language.BZ_Version = "V1.0.0";
            this.btn_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Language.ForeColor = System.Drawing.Color.Black;
            this.btn_Language.Location = new System.Drawing.Point(3, 3);
            this.btn_Language.Name = "btn_Language";
            this.btn_Language.Size = new System.Drawing.Size(108, 42);
            this.btn_Language.TabIndex = 50;
            this.btn_Language.Text = "英文";
            this.btn_Language.UseVisualStyleBackColor = false;
            this.btn_Language.Visible = false;
            this.btn_Language.Click += new System.EventHandler(this.btn_Language_Click);
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
            this.Panel_CPK.Location = new System.Drawing.Point(233, 448);
            this.Panel_CPK.Name = "Panel_CPK";
            this.Panel_CPK.Size = new System.Drawing.Size(200, 194);
            this.Panel_CPK.TabIndex = 48;
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
            // Btn_CPKGRRMode
            // 
            this.Btn_CPKGRRMode.BackColor = System.Drawing.Color.LightGray;
            this.Btn_CPKGRRMode.BZ_Radius = ((byte)(6));
            this.Btn_CPKGRRMode.BZ_Version = "V1.0.0";
            this.Btn_CPKGRRMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPKGRRMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_CPKGRRMode.Location = new System.Drawing.Point(180, 353);
            this.Btn_CPKGRRMode.Name = "Btn_CPKGRRMode";
            this.Btn_CPKGRRMode.Size = new System.Drawing.Size(300, 60);
            this.Btn_CPKGRRMode.TabIndex = 3;
            this.Btn_CPKGRRMode.Text = "GRR Mode";
            this.Btn_CPKGRRMode.UseVisualStyleBackColor = false;
            this.Btn_CPKGRRMode.Click += new System.EventHandler(this.Btn_CPKGRRMode_Click);
            // 
            // Btn_EngneeringMode
            // 
            this.Btn_EngneeringMode.BackColor = System.Drawing.Color.LightGray;
            this.Btn_EngneeringMode.BZ_Radius = ((byte)(6));
            this.Btn_EngneeringMode.BZ_Version = "V1.0.0";
            this.Btn_EngneeringMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EngneeringMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_EngneeringMode.Location = new System.Drawing.Point(180, 248);
            this.Btn_EngneeringMode.Name = "Btn_EngneeringMode";
            this.Btn_EngneeringMode.Size = new System.Drawing.Size(300, 60);
            this.Btn_EngneeringMode.TabIndex = 2;
            this.Btn_EngneeringMode.Text = "Engineering Mode";
            this.Btn_EngneeringMode.UseVisualStyleBackColor = false;
            this.Btn_EngneeringMode.Click += new System.EventHandler(this.Btn_EngneeringMode_Click);
            // 
            // Btn_ProductionMode
            // 
            this.Btn_ProductionMode.BackColor = System.Drawing.Color.LightGray;
            this.Btn_ProductionMode.BZ_Radius = ((byte)(6));
            this.Btn_ProductionMode.BZ_Version = "V1.0.0";
            this.Btn_ProductionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ProductionMode.ForeColor = System.Drawing.Color.Black;
            this.Btn_ProductionMode.Location = new System.Drawing.Point(180, 143);
            this.Btn_ProductionMode.Name = "Btn_ProductionMode";
            this.Btn_ProductionMode.Size = new System.Drawing.Size(300, 60);
            this.Btn_ProductionMode.TabIndex = 1;
            this.Btn_ProductionMode.Text = "Production Mode";
            this.Btn_ProductionMode.UseVisualStyleBackColor = false;
            this.Btn_ProductionMode.Click += new System.EventHandler(this.Btn_ProductionMode_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Login.Enabled = false;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.Black;
            this.Btn_Login.Location = new System.Drawing.Point(26, 296);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 32);
            this.Btn_Login.TabIndex = 24;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(196, 296);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(100, 32);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Text_Password
            // 
            this.Text_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Text_Password.Enabled = false;
            this.Text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Password.Location = new System.Drawing.Point(27, 229);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '*';
            this.Text_Password.Size = new System.Drawing.Size(270, 31);
            this.Text_Password.TabIndex = 23;
            this.Text_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Password.Click += new System.EventHandler(this.Text_Password_Click);
            this.Text_Password.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Text_Password_MouseDoubleClick);
            // 
            // Combo_User
            // 
            this.Combo_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Combo_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_User.Enabled = false;
            this.Combo_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_User.FormattingEnabled = true;
            this.Combo_User.Location = new System.Drawing.Point(27, 150);
            this.Combo_User.Name = "Combo_User";
            this.Combo_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Combo_User.Size = new System.Drawing.Size(270, 33);
            this.Combo_User.TabIndex = 22;
            this.Combo_User.SelectedIndexChanged += new System.EventHandler(this.Combo_User_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(27, 199);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 17);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Password";
            // 
            // RoundPanel1
            // 
            this.RoundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.RoundPanel1.BZ_AutoBkColor = true;
            this.RoundPanel1.BZ_Radius = ((byte)(6));
            this.RoundPanel1.BZ_Version = "V1.0.0";
            this.RoundPanel1.Controls.Add(this.Btn_Home);
            this.RoundPanel1.Controls.Add(this.Btn_Login);
            this.RoundPanel1.Controls.Add(this.Btn_Exit);
            this.RoundPanel1.Controls.Add(this.Text_Password);
            this.RoundPanel1.Controls.Add(this.Combo_User);
            this.RoundPanel1.Controls.Add(this.Label2);
            this.RoundPanel1.Controls.Add(this.Label1);
            this.RoundPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel1.Location = new System.Drawing.Point(693, 0);
            this.RoundPanel1.Name = "RoundPanel1";
            this.RoundPanel1.Size = new System.Drawing.Size(328, 402);
            this.RoundPanel1.TabIndex = 61;
            // 
            // Btn_Home
            // 
            this.Btn_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Home.BZ_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Btn_Home.BZ_OnMouseColor = System.Drawing.Color.LightGreen;
            this.Btn_Home.BZ_Radius = 11;
            this.Btn_Home.BZ_RoundStyle = BoTech.Button.RoundStyle.All;
            this.Btn_Home.Enabled = false;
            this.Btn_Home.ForeColor = System.Drawing.Color.Black;
            this.Btn_Home.Image = global::BZGUI.Properties.Resources.user;
            this.Btn_Home.Location = new System.Drawing.Point(16, 12);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(97, 89);
            this.Btn_Home.TabIndex = 56;
            this.Btn_Home.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(27, 115);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 17);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "User Name";
            this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
            // 
            // RoundPanel3
            // 
            this.RoundPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.RoundPanel3.BZ_AutoBkColor = true;
            this.RoundPanel3.BZ_Radius = ((byte)(6));
            this.RoundPanel3.BZ_Version = "V1.0.0";
            this.RoundPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.RoundPanel3.Location = new System.Drawing.Point(693, 407);
            this.RoundPanel3.Name = "RoundPanel3";
            this.RoundPanel3.Size = new System.Drawing.Size(328, 253);
            this.RoundPanel3.TabIndex = 62;
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoundPanel2);
            this.Controls.Add(this.RoundPanel1);
            this.Controls.Add(this.RoundPanel3);
            this.Name = "PageLogin";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageLogin_Load);
            this.SizeChanged += new System.EventHandler(this.PageLogin_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.PageLogin_VisibleChanged);
            this.RoundPanel2.ResumeLayout(false);
            this.Panel_CPK.ResumeLayout(false);
            this.Panel_CPK.PerformLayout();
            this.RoundPanel1.ResumeLayout(false);
            this.RoundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal BZ.UI.RoundPanel RoundPanel2;
        internal BZ.UI.RoundButton Btn_CPKGRRMode;
        internal BZ.UI.RoundButton Btn_EngneeringMode;
        internal BZ.UI.RoundButton Btn_ProductionMode;
        internal System.Windows.Forms.Button Btn_Login;
        internal System.Windows.Forms.Button Btn_Exit;
        internal System.Windows.Forms.TextBox Text_Password;
        internal System.Windows.Forms.ComboBox Combo_User;
        internal System.Windows.Forms.Label Label2;
        internal BZ.UI.RoundPanel RoundPanel1;
        internal System.Windows.Forms.Label Label1;
        internal BZ.UI.RoundPanel RoundPanel3;
        internal BoTech.Panel Panel_CPK;
        internal System.Windows.Forms.Label Lab_CpkCount;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Lab_Cpkstatues;
        internal System.Windows.Forms.Button btn_ExitCPK;
        internal BoTech.Button Btn_Home;
        internal BZ.UI.RoundButton btn_Language;
    }
}
