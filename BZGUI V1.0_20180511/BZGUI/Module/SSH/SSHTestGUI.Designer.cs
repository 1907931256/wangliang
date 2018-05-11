namespace BZGUI
{
    partial class SSHTestGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.bExecuteCommand = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SSHsts = new System.Windows.Forms.Button();
            this.txtCammand = new System.Windows.Forms.ComboBox();
            this.btnSSHopen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Step1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Step2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.SSHOutput = new System.Windows.Forms.TextBox();
            this.btn_CreatSSHfolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHostAddress);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Properties";
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
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(119, 412);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(77, 30);
            this.bDisconnect.TabIndex = 3;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(3, 412);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(77, 30);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bExecuteCommand
            // 
            this.bExecuteCommand.Location = new System.Drawing.Point(644, 414);
            this.bExecuteCommand.Name = "bExecuteCommand";
            this.bExecuteCommand.Size = new System.Drawing.Size(77, 30);
            this.bExecuteCommand.TabIndex = 10;
            this.bExecuteCommand.Text = "Execute";
            this.bExecuteCommand.UseVisualStyleBackColor = true;
            this.bExecuteCommand.Click += new System.EventHandler(this.bExecuteCommand_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Password",
            "Private key"});
            this.comboBox1.Location = new System.Drawing.Point(3, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Private key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Connection Type";
            // 
            // btn_SSHsts
            // 
            this.btn_SSHsts.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SSHsts.Enabled = false;
            this.btn_SSHsts.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SSHsts.Location = new System.Drawing.Point(154, 190);
            this.btn_SSHsts.Name = "btn_SSHsts";
            this.btn_SSHsts.Size = new System.Drawing.Size(44, 26);
            this.btn_SSHsts.TabIndex = 83;
            this.btn_SSHsts.Text = "SSH";
            this.btn_SSHsts.UseVisualStyleBackColor = false;
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
            this.txtCammand.Location = new System.Drawing.Point(204, 415);
            this.txtCammand.Name = "txtCammand";
            this.txtCammand.Size = new System.Drawing.Size(434, 27);
            this.txtCammand.TabIndex = 84;
            this.txtCammand.Text = "ls";
            // 
            // btnSSHopen
            // 
            this.btnSSHopen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSSHopen.Enabled = false;
            this.btnSSHopen.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSSHopen.Location = new System.Drawing.Point(5, 190);
            this.btnSSHopen.Name = "btnSSHopen";
            this.btnSSHopen.Size = new System.Drawing.Size(93, 26);
            this.btnSSHopen.TabIndex = 85;
            this.btnSSHopen.Text = "SSH功能打开";
            this.btnSSHopen.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 86;
            this.label5.Text = "Calibration Current";
            // 
            // Btn_Step1
            // 
            this.Btn_Step1.Location = new System.Drawing.Point(728, 62);
            this.Btn_Step1.Name = "Btn_Step1";
            this.Btn_Step1.Size = new System.Drawing.Size(167, 30);
            this.Btn_Step1.TabIndex = 87;
            this.Btn_Step1.Text = "Step1";
            this.Btn_Step1.UseVisualStyleBackColor = true;
            this.Btn_Step1.Click += new System.EventHandler(this.Btn_Step1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 86;
            this.label6.Text = "请进入参数设置，打开SSH功能";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(732, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 88;
            this.label7.Text = "Showed as below:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 12);
            this.label8.TabIndex = 88;
            this.label8.Text = "0) view2-05000111-1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(732, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 12);
            this.label9.TabIndex = 88;
            this.label9.Text = "1) view2-05000111-temp";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(732, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 12);
            this.label10.TabIndex = 88;
            this.label10.Text = "2) view2-05000111-dac";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(732, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 12);
            this.label11.TabIndex = 88;
            this.label11.Text = "3) view2-05000111-digital";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(732, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 12);
            this.label12.TabIndex = 88;
            this.label12.Text = "Choose which view:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Step2
            // 
            this.btn_Step2.Location = new System.Drawing.Point(728, 256);
            this.btn_Step2.Name = "btn_Step2";
            this.btn_Step2.Size = new System.Drawing.Size(167, 30);
            this.btn_Step2.TabIndex = 90;
            this.btn_Step2.Text = "Step2";
            this.btn_Step2.UseVisualStyleBackColor = true;
            this.btn_Step2.Click += new System.EventHandler(this.btn_Step2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(732, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 12);
            this.label13.TabIndex = 89;
            this.label13.Text = "2.Press \"Step2\"";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(732, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 12);
            this.label14.TabIndex = 88;
            this.label14.Text = "Start calibration,wait ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(732, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 12);
            this.label15.TabIndex = 88;
            this.label15.Text = "about 5 minutes to  ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(732, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 12);
            this.label16.TabIndex = 88;
            this.label16.Text = "complete till Success!! ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(732, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 12);
            this.label17.TabIndex = 88;
            this.label17.Text = "Showed as below:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(732, 389);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 12);
            this.label18.TabIndex = 88;
            this.label18.Text = "Calibration completed";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(732, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 12);
            this.label19.TabIndex = 88;
            this.label19.Text = "Calibration Success";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(905, 454);
            this.shapeContainer1.TabIndex = 91;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(727, 9);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(170, 432);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(732, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 12);
            this.label20.TabIndex = 93;
            this.label20.Text = "1.Press \"Step1\"";
            // 
            // SSHOutput
            // 
            this.SSHOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.SSHOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.SSHOutput.Location = new System.Drawing.Point(204, 3);
            this.SSHOutput.Multiline = true;
            this.SSHOutput.Name = "SSHOutput";
            this.SSHOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SSHOutput.Size = new System.Drawing.Size(517, 405);
            this.SSHOutput.TabIndex = 94;
            // 
            // btn_CreatSSHfolder
            // 
            this.btn_CreatSSHfolder.Location = new System.Drawing.Point(5, 284);
            this.btn_CreatSSHfolder.Name = "btn_CreatSSHfolder";
            this.btn_CreatSSHfolder.Size = new System.Drawing.Size(193, 33);
            this.btn_CreatSSHfolder.TabIndex = 95;
            this.btn_CreatSSHfolder.Text = "一键创建Private_Key连接";
            this.btn_CreatSSHfolder.UseVisualStyleBackColor = true;
            this.btn_CreatSSHfolder.Click += new System.EventHandler(this.btn_CreatSSHfolder_Click);
            // 
            // SSHTestGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 454);
            this.Controls.Add(this.btn_CreatSSHfolder);
            this.Controls.Add(this.SSHOutput);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_Step2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_Step1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSSHopen);
            this.Controls.Add(this.txtCammand);
            this.Controls.Add(this.btn_SSHsts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bExecuteCommand);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SSHTestGUI";
            this.Text = "`";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SSHTestGUI_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bExecuteCommand;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SSHsts;
        private System.Windows.Forms.ComboBox txtCammand;
        private System.Windows.Forms.Button btnSSHopen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Step1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Step2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox SSHOutput;
        private System.Windows.Forms.Button btn_CreatSSHfolder;
    }
}