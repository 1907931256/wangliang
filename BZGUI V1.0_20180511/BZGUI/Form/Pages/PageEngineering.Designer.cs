namespace BZGUI
{
    partial class PageEngineering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageEngineering));
            this.btn_MStart = new System.Windows.Forms.Button();
            this.Btn_EMG = new System.Windows.Forms.Button();
            this.Btn_Manual = new BZ.UI.RoundButton();
            this.xtaskStateRichList1 = new XCore.XtaskStateRichList();
            this.xtaskStateRichList2 = new XCore.XtaskStateRichList();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Product_Num = new System.Windows.Forms.TextBox();
            this.Cycle = new System.Windows.Forms.TextBox();
            this.Label_CPK = new System.Windows.Forms.Label();
            this.Label_WorkMode = new System.Windows.Forms.Label();
            this.PictureBox25 = new System.Windows.Forms.PictureBox();
            this.SplitList_LB = new System.Windows.Forms.Panel();
            this.xtaskStateRichList3 = new XCore.XtaskStateRichList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Scanner_Status = new System.Windows.Forms.Button();
            this.CCD_Status = new System.Windows.Forms.Button();
            this.txt_SN = new System.Windows.Forms.TextBox();
            this.CurtionSts = new System.Windows.Forms.Button();
            this.AirSts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SSHsts = new System.Windows.Forms.Button();
            this.SSHOutput = new System.Windows.Forms.TextBox();
            this.datagridshow2 = new BZGUI.Datagridshow();
            this.bool_Routine3 = new BZGUI.Bool();
            this.bool_Routine2 = new BZGUI.Bool();
            this.bool_Routine1 = new BZGUI.Bool();
            this.SafeDoorSts = new BZGUI.Bool();
            this.showResult1 = new BZGUI.ShowResult();
            this.netMonitor2 = new BZGUI.NetMonitor();
            this.laserHights1 = new BZGUI.LaserHights();
            this.GroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox25)).BeginInit();
            this.SplitList_LB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MStart
            // 
            this.btn_MStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_MStart.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MStart.Location = new System.Drawing.Point(3, 262);
            this.btn_MStart.Name = "btn_MStart";
            this.btn_MStart.Size = new System.Drawing.Size(84, 38);
            this.btn_MStart.TabIndex = 81;
            this.btn_MStart.Text = "Start";
            this.btn_MStart.UseVisualStyleBackColor = false;
            this.btn_MStart.Visible = false;
            this.btn_MStart.Click += new System.EventHandler(this.btn_MStart_Click);
            // 
            // Btn_EMG
            // 
            this.Btn_EMG.BackColor = System.Drawing.Color.Maroon;
            this.Btn_EMG.Enabled = false;
            this.Btn_EMG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_EMG.Location = new System.Drawing.Point(3, 181);
            this.Btn_EMG.Name = "Btn_EMG";
            this.Btn_EMG.Size = new System.Drawing.Size(84, 36);
            this.Btn_EMG.TabIndex = 78;
            this.Btn_EMG.Text = "急停";
            this.Btn_EMG.UseVisualStyleBackColor = false;
            this.Btn_EMG.Click += new System.EventHandler(this.Btn_EMG_Click);
            // 
            // Btn_Manual
            // 
            this.Btn_Manual.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Manual.BZ_Radius = ((byte)(6));
            this.Btn_Manual.BZ_Version = "V1.0.0";
            this.Btn_Manual.FlatAppearance.BorderSize = 0;
            this.Btn_Manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Manual.ForeColor = System.Drawing.Color.Black;
            this.Btn_Manual.Location = new System.Drawing.Point(3, 557);
            this.Btn_Manual.Name = "Btn_Manual";
            this.Btn_Manual.Size = new System.Drawing.Size(251, 54);
            this.Btn_Manual.TabIndex = 77;
            this.Btn_Manual.Text = "Manual";
            this.Btn_Manual.UseVisualStyleBackColor = false;
            this.Btn_Manual.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // xtaskStateRichList1
            // 
            this.xtaskStateRichList1.Location = new System.Drawing.Point(3, 43);
            this.xtaskStateRichList1.Name = "xtaskStateRichList1";
            this.xtaskStateRichList1.Size = new System.Drawing.Size(251, 118);
            this.xtaskStateRichList1.TabIndex = 6;
            this.xtaskStateRichList1.TaskId = 0;
            // 
            // xtaskStateRichList2
            // 
            this.xtaskStateRichList2.Location = new System.Drawing.Point(3, 168);
            this.xtaskStateRichList2.Name = "xtaskStateRichList2";
            this.xtaskStateRichList2.Size = new System.Drawing.Size(251, 118);
            this.xtaskStateRichList2.TabIndex = 3;
            this.xtaskStateRichList2.TaskId = 1;
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.Label16);
            this.GroupBox8.Controls.Add(this.Label5);
            this.GroupBox8.Controls.Add(this.Product_Num);
            this.GroupBox8.Controls.Add(this.Cycle);
            this.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox8.ForeColor = System.Drawing.Color.Black;
            this.GroupBox8.Location = new System.Drawing.Point(3, 123);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(266, 53);
            this.GroupBox8.TabIndex = 93;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "生产信息";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(137, 24);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(53, 17);
            this.Label16.TabIndex = 90;
            this.Label16.Text = "Count :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 17);
            this.Label5.TabIndex = 89;
            this.Label5.Text = "CT(S):";
            // 
            // Product_Num
            // 
            this.Product_Num.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Num.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Product_Num.ForeColor = System.Drawing.Color.Blue;
            this.Product_Num.Location = new System.Drawing.Point(191, 20);
            this.Product_Num.Name = "Product_Num";
            this.Product_Num.ReadOnly = true;
            this.Product_Num.Size = new System.Drawing.Size(64, 26);
            this.Product_Num.TabIndex = 1;
            this.Product_Num.Text = "9999";
            this.Product_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cycle
            // 
            this.Cycle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cycle.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.Cycle.ForeColor = System.Drawing.Color.Blue;
            this.Cycle.Location = new System.Drawing.Point(56, 18);
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            this.Cycle.Size = new System.Drawing.Size(64, 26);
            this.Cycle.TabIndex = 1;
            this.Cycle.Text = "0.00";
            this.Cycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_CPK
            // 
            this.Label_CPK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_CPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPK.ForeColor = System.Drawing.Color.Orange;
            this.Label_CPK.Location = new System.Drawing.Point(57, 4);
            this.Label_CPK.Name = "Label_CPK";
            this.Label_CPK.Size = new System.Drawing.Size(158, 33);
            this.Label_CPK.TabIndex = 97;
            this.Label_CPK.Text = "CPK：32/32";
            this.Label_CPK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CPK.Visible = false;
            // 
            // Label_WorkMode
            // 
            this.Label_WorkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_WorkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_WorkMode.ForeColor = System.Drawing.Color.Yellow;
            this.Label_WorkMode.Location = new System.Drawing.Point(57, 83);
            this.Label_WorkMode.Name = "Label_WorkMode";
            this.Label_WorkMode.Size = new System.Drawing.Size(158, 33);
            this.Label_WorkMode.TabIndex = 96;
            this.Label_WorkMode.Text = "Dome Mode";
            this.Label_WorkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox25
            // 
            this.PictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox25.Image")));
            this.PictureBox25.Location = new System.Drawing.Point(3, 1);
            this.PictureBox25.Name = "PictureBox25";
            this.PictureBox25.Size = new System.Drawing.Size(252, 41);
            this.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox25.TabIndex = 82;
            this.PictureBox25.TabStop = false;
            // 
            // SplitList_LB
            // 
            this.SplitList_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitList_LB.Controls.Add(this.xtaskStateRichList3);
            this.SplitList_LB.Controls.Add(this.netMonitor2);
            this.SplitList_LB.Controls.Add(this.laserHights1);
            this.SplitList_LB.Controls.Add(this.PictureBox25);
            this.SplitList_LB.Controls.Add(this.Btn_Manual);
            this.SplitList_LB.Controls.Add(this.xtaskStateRichList1);
            this.SplitList_LB.Controls.Add(this.xtaskStateRichList2);
            this.SplitList_LB.Location = new System.Drawing.Point(3, 3);
            this.SplitList_LB.Name = "SplitList_LB";
            this.SplitList_LB.Size = new System.Drawing.Size(259, 654);
            this.SplitList_LB.TabIndex = 100;
            // 
            // xtaskStateRichList3
            // 
            this.xtaskStateRichList3.Location = new System.Drawing.Point(3, 168);
            this.xtaskStateRichList3.Name = "xtaskStateRichList3";
            this.xtaskStateRichList3.Size = new System.Drawing.Size(251, 118);
            this.xtaskStateRichList3.TabIndex = 105;
            this.xtaskStateRichList3.TaskId = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SafeDoorSts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Scanner_Status);
            this.panel1.Controls.Add(this.CCD_Status);
            this.panel1.Controls.Add(this.txt_SN);
            this.panel1.Controls.Add(this.CurtionSts);
            this.panel1.Controls.Add(this.AirSts);
            this.panel1.Controls.Add(this.GroupBox8);
            this.panel1.Controls.Add(this.Label_WorkMode);
            this.panel1.Controls.Add(this.Label_CPK);
            this.panel1.Controls.Add(this.Btn_EMG);
            this.panel1.Controls.Add(this.btn_MStart);
            this.panel1.Controls.Add(this.showResult1);
            this.panel1.Location = new System.Drawing.Point(747, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 389);
            this.panel1.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "SN:";
            // 
            // Scanner_Status
            // 
            this.Scanner_Status.BackColor = System.Drawing.Color.LimeGreen;
            this.Scanner_Status.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Scanner_Status.Location = new System.Drawing.Point(185, 220);
            this.Scanner_Status.Name = "Scanner_Status";
            this.Scanner_Status.Size = new System.Drawing.Size(84, 38);
            this.Scanner_Status.TabIndex = 102;
            this.Scanner_Status.Text = "Scanner connect";
            this.Scanner_Status.UseVisualStyleBackColor = false;
            this.Scanner_Status.Visible = false;
            // 
            // CCD_Status
            // 
            this.CCD_Status.BackColor = System.Drawing.Color.LimeGreen;
            this.CCD_Status.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CCD_Status.Location = new System.Drawing.Point(94, 220);
            this.CCD_Status.Name = "CCD_Status";
            this.CCD_Status.Size = new System.Drawing.Size(84, 38);
            this.CCD_Status.TabIndex = 101;
            this.CCD_Status.Text = "CCD connect";
            this.CCD_Status.UseVisualStyleBackColor = false;
            this.CCD_Status.Visible = false;
            // 
            // txt_SN
            // 
            this.txt_SN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SN.Location = new System.Drawing.Point(5, 354);
            this.txt_SN.Name = "txt_SN";
            this.txt_SN.Size = new System.Drawing.Size(264, 29);
            this.txt_SN.TabIndex = 101;
            this.txt_SN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SN.TextChanged += new System.EventHandler(this.txt_SN_TextChanged);
            // 
            // CurtionSts
            // 
            this.CurtionSts.BackColor = System.Drawing.Color.LimeGreen;
            this.CurtionSts.Enabled = false;
            this.CurtionSts.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurtionSts.Location = new System.Drawing.Point(185, 181);
            this.CurtionSts.Name = "CurtionSts";
            this.CurtionSts.Size = new System.Drawing.Size(84, 36);
            this.CurtionSts.TabIndex = 100;
            this.CurtionSts.Text = "光幕";
            this.CurtionSts.UseVisualStyleBackColor = false;
            // 
            // AirSts
            // 
            this.AirSts.BackColor = System.Drawing.Color.LimeGreen;
            this.AirSts.Enabled = false;
            this.AirSts.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AirSts.Location = new System.Drawing.Point(3, 220);
            this.AirSts.Name = "AirSts";
            this.AirSts.Size = new System.Drawing.Size(84, 38);
            this.AirSts.TabIndex = 100;
            this.AirSts.Text = "正气源";
            this.AirSts.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bool_Routine3);
            this.panel2.Controls.Add(this.bool_Routine2);
            this.panel2.Controls.Add(this.bool_Routine1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_SSHsts);
            this.panel2.Controls.Add(this.SSHOutput);
            this.panel2.Location = new System.Drawing.Point(265, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 389);
            this.panel2.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(211, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Routines:";
            // 
            // btn_SSHsts
            // 
            this.btn_SSHsts.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SSHsts.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SSHsts.Location = new System.Drawing.Point(3, 355);
            this.btn_SSHsts.Name = "btn_SSHsts";
            this.btn_SSHsts.Size = new System.Drawing.Size(36, 29);
            this.btn_SSHsts.TabIndex = 82;
            this.btn_SSHsts.Text = "SSH";
            this.btn_SSHsts.UseVisualStyleBackColor = false;
            this.btn_SSHsts.Click += new System.EventHandler(this.btn_SSHsts_Click);
            // 
            // SSHOutput
            // 
            this.SSHOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.SSHOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.SSHOutput.Location = new System.Drawing.Point(3, 1);
            this.SSHOutput.Multiline = true;
            this.SSHOutput.Name = "SSHOutput";
            this.SSHOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SSHOutput.Size = new System.Drawing.Size(472, 351);
            this.SSHOutput.TabIndex = 83;
            // 
            // datagridshow2
            // 
            this.datagridshow2.Location = new System.Drawing.Point(265, 396);
            this.datagridshow2.Name = "datagridshow2";
            this.datagridshow2.Size = new System.Drawing.Size(756, 261);
            this.datagridshow2.TabIndex = 102;
            // 
            // bool_Routine3
            // 
            this.bool_Routine3.Checked = true;
            this.bool_Routine3.Location = new System.Drawing.Point(416, 357);
            this.bool_Routine3.Name = "bool_Routine3";
            this.bool_Routine3.OFF_Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bool_Routine3.OFF_Text = "OFF";
            this.bool_Routine3.ON_Color = System.Drawing.Color.LimeGreen;
            this.bool_Routine3.ON_Text = "ON";
            this.bool_Routine3.Size = new System.Drawing.Size(62, 27);
            this.bool_Routine3.TabIndex = 90;
            this.bool_Routine3.Trigger += new System.Action<BZGUI.Bool>(this.bool_Routine3_Trigger);
            // 
            // bool_Routine2
            // 
            this.bool_Routine2.Checked = true;
            this.bool_Routine2.Location = new System.Drawing.Point(351, 357);
            this.bool_Routine2.Name = "bool_Routine2";
            this.bool_Routine2.OFF_Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bool_Routine2.OFF_Text = "OFF";
            this.bool_Routine2.ON_Color = System.Drawing.Color.LimeGreen;
            this.bool_Routine2.ON_Text = "ON";
            this.bool_Routine2.Size = new System.Drawing.Size(62, 27);
            this.bool_Routine2.TabIndex = 89;
            this.bool_Routine2.Trigger += new System.Action<BZGUI.Bool>(this.bool_Routine3_Trigger);
            // 
            // bool_Routine1
            // 
            this.bool_Routine1.Checked = true;
            this.bool_Routine1.Location = new System.Drawing.Point(286, 357);
            this.bool_Routine1.Name = "bool_Routine1";
            this.bool_Routine1.OFF_Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.bool_Routine1.OFF_Text = "OFF";
            this.bool_Routine1.ON_Color = System.Drawing.Color.LimeGreen;
            this.bool_Routine1.ON_Text = "ON";
            this.bool_Routine1.Size = new System.Drawing.Size(62, 27);
            this.bool_Routine1.TabIndex = 88;
            this.bool_Routine1.Trigger += new System.Action<BZGUI.Bool>(this.bool_Routine3_Trigger);
            // 
            // SafeDoorSts
            // 
            this.SafeDoorSts.Checked = true;
            this.SafeDoorSts.Enabled = false;
            this.SafeDoorSts.Location = new System.Drawing.Point(95, 181);
            this.SafeDoorSts.Name = "SafeDoorSts";
            this.SafeDoorSts.OFF_Color = System.Drawing.Color.Red;
            this.SafeDoorSts.OFF_Text = "安全门";
            this.SafeDoorSts.ON_Color = System.Drawing.Color.LimeGreen;
            this.SafeDoorSts.ON_Text = "安全门";
            this.SafeDoorSts.Size = new System.Drawing.Size(84, 36);
            this.SafeDoorSts.TabIndex = 104;
            // 
            // showResult1
            // 
            this.showResult1.Location = new System.Drawing.Point(3, 2);
            this.showResult1.Name = "showResult1";
            this.showResult1.Size = new System.Drawing.Size(266, 114);
            this.showResult1.TabIndex = 98;
            // 
            // netMonitor2
            // 
            this.netMonitor2.Location = new System.Drawing.Point(3, 292);
            this.netMonitor2.Name = "netMonitor2";
            this.netMonitor2.Size = new System.Drawing.Size(252, 96);
            this.netMonitor2.TabIndex = 101;
            // 
            // laserHights1
            // 
            this.laserHights1.Location = new System.Drawing.Point(3, 392);
            this.laserHights1.Name = "laserHights1";
            this.laserHights1.Size = new System.Drawing.Size(251, 135);
            this.laserHights1.TabIndex = 100;
            // 
            // PageEngineering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.datagridshow2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SplitList_LB);
            this.Name = "PageEngineering";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageEngineering_Load);
            this.SizeChanged += new System.EventHandler(this.PageEngineering_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.PageEngineering_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PageEngineering_Paint);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox25)).EndInit();
            this.SplitList_LB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XCore.XtaskStateRichList xtaskStateRichList2;
        private XCore.XtaskStateRichList xtaskStateRichList1;
        private System.Windows.Forms.Button btn_MStart;
        private System.Windows.Forms.Button Btn_EMG;
        internal BZ.UI.RoundButton Btn_Manual;
        private System.Windows.Forms.GroupBox GroupBox8;
        private System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Product_Num;
        internal System.Windows.Forms.TextBox Cycle;
        internal System.Windows.Forms.Label Label_CPK;
        private ShowResult showResult1;
        internal System.Windows.Forms.PictureBox PictureBox25;
        internal System.Windows.Forms.Panel SplitList_LB;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AirSts;
        private System.Windows.Forms.Button CurtionSts;
        private Datagridshow datagridshow1;
        private System.Windows.Forms.Button btn_SSHsts;
        private System.Windows.Forms.TextBox txt_SN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SSHOutput;
        private System.Windows.Forms.Label Label_WorkMode;
        private LaserHights laserHights1;
        private NetMonitor netMonitor1;
        private Datagridshow datagridshow2;
        private System.Windows.Forms.Button Scanner_Status;
        private System.Windows.Forms.Button CCD_Status;
        private NetMonitor netMonitor2;
        private System.Windows.Forms.Label label2;
        private Bool bool_Routine1;
        private Bool bool_Routine3;
        private Bool bool_Routine2;
        private Bool SafeDoorSts;
        private XCore.XtaskStateRichList xtaskStateRichList3;

    }
}
