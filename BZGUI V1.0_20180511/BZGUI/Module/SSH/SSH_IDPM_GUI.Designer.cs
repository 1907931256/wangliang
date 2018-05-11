namespace BZGUI
{
    partial class SSH_IDPM_GUI
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
            this.btn_CreatSSHfolder = new System.Windows.Forms.Button();
            this.SSHOutput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnSSHopen = new System.Windows.Forms.Button();
            this.txtCammand = new System.Windows.Forms.ComboBox();
            this.btn_SSHsts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bExecuteCommand = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CreatSSHfolder
            // 
            this.btn_CreatSSHfolder.Location = new System.Drawing.Point(7, 278);
            this.btn_CreatSSHfolder.Name = "btn_CreatSSHfolder";
            this.btn_CreatSSHfolder.Size = new System.Drawing.Size(193, 33);
            this.btn_CreatSSHfolder.TabIndex = 124;
            this.btn_CreatSSHfolder.Text = "一键创建Private_Key连接";
            this.btn_CreatSSHfolder.UseVisualStyleBackColor = true;
            this.btn_CreatSSHfolder.Click += new System.EventHandler(this.btn_CreatSSHfolder_Click);
            // 
            // SSHOutput
            // 
            this.SSHOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.SSHOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.SSHOutput.Location = new System.Drawing.Point(206, -3);
            this.SSHOutput.Multiline = true;
            this.SSHOutput.Name = "SSHOutput";
            this.SSHOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SSHOutput.Size = new System.Drawing.Size(517, 405);
            this.SSHOutput.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 105;
            this.label6.Text = "请进入参数设置，打开SSH功能";
            // 
            // btnSSHopen
            // 
            this.btnSSHopen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSSHopen.Enabled = false;
            this.btnSSHopen.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSSHopen.Location = new System.Drawing.Point(7, 184);
            this.btnSSHopen.Name = "btnSSHopen";
            this.btnSSHopen.Size = new System.Drawing.Size(93, 26);
            this.btnSSHopen.TabIndex = 104;
            this.btnSSHopen.Text = "SSH功能打开";
            this.btnSSHopen.UseVisualStyleBackColor = false;
            // 
            // txtCammand
            // 
            this.txtCammand.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCammand.FormattingEnabled = true;
            this.txtCammand.Items.AddRange(new object[] {
            "/Users/gdlocal/Desktop/MMS/RunningMotorRIGHT.txt",
            "/Users/gdlocal/Desktop/MMS/RunningMotorLEFT.txt",
            "ls",
            "ifconfig",
            "ls /dev/cu.*",
            "cd /Users/gdlocal/Desktop/MMS",
            "./axonctl",
            "./axonctl help",
            "/Users/gdlocal/Desktop/MMS/axonctl gpio -d  /dev/cu.usbserial-DO0069FA -p 8 -l 1",
            "/Users/gdlocal/Desktop/MMS/axonctl gpio -d  /dev/cu.usbserial-DO0069FA -p 8 -l 0",
            "cd /Users/gdlocal",
            "mkdir .ssh"});
            this.txtCammand.Location = new System.Drawing.Point(206, 409);
            this.txtCammand.Name = "txtCammand";
            this.txtCammand.Size = new System.Drawing.Size(434, 27);
            this.txtCammand.TabIndex = 103;
            this.txtCammand.Text = "ls";
            // 
            // btn_SSHsts
            // 
            this.btn_SSHsts.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SSHsts.Enabled = false;
            this.btn_SSHsts.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SSHsts.Location = new System.Drawing.Point(156, 184);
            this.btn_SSHsts.Name = "btn_SSHsts";
            this.btn_SSHsts.Size = new System.Drawing.Size(44, 26);
            this.btn_SSHsts.TabIndex = 102;
            this.btn_SSHsts.Text = "SSH";
            this.btn_SSHsts.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 101;
            this.label4.Text = "Connection Type";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Password",
            "Private key"});
            this.comboBox1.Location = new System.Drawing.Point(5, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 100;
            this.comboBox1.Text = "Private key";
            // 
            // bExecuteCommand
            // 
            this.bExecuteCommand.Location = new System.Drawing.Point(646, 408);
            this.bExecuteCommand.Name = "bExecuteCommand";
            this.bExecuteCommand.Size = new System.Drawing.Size(77, 30);
            this.bExecuteCommand.TabIndex = 99;
            this.bExecuteCommand.Text = "Execute";
            this.bExecuteCommand.UseVisualStyleBackColor = true;
            this.bExecuteCommand.Click += new System.EventHandler(this.bExecuteCommand_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(121, 406);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(77, 30);
            this.bDisconnect.TabIndex = 97;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(5, 406);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(77, 30);
            this.bConnect.TabIndex = 96;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host Address";
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Location = new System.Drawing.Point(85, 18);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(100, 21);
            this.tbHostAddress.TabIndex = 0;
            this.tbHostAddress.Text = "192.168.1.20";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(85, 42);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 21);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "gdlocal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(85, 66);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 21);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "gdlocal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHostAddress);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 107);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Properties";
            // 
            // SSH_IDPM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btn_CreatSSHfolder);
            this.Controls.Add(this.SSHOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSSHopen);
            this.Controls.Add(this.txtCammand);
            this.Controls.Add(this.btn_SSHsts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bExecuteCommand);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SSH_IDPM_GUI";
            this.Text = "SSH_IDPM_GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SSH_IDPM_GUI_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreatSSHfolder;
        private System.Windows.Forms.TextBox SSHOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSSHopen;
        private System.Windows.Forms.ComboBox txtCammand;
        private System.Windows.Forms.Button btn_SSHsts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bExecuteCommand;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}