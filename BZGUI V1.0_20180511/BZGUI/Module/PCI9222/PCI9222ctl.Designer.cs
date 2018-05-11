namespace BZGUI
{
    partial class PCI9222ctl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCI9222ctl));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Save_csv = new System.Windows.Forms.Button();
            this.btn_DataBack = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Combo_Date = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Save_csv
            // 
            this.Save_csv.Location = new System.Drawing.Point(136, 19);
            this.Save_csv.Name = "Save_csv";
            this.Save_csv.Size = new System.Drawing.Size(59, 37);
            this.Save_csv.TabIndex = 35;
            this.Save_csv.Text = "Save csv";
            this.Save_csv.UseVisualStyleBackColor = true;
            this.Save_csv.Visible = false;
            this.Save_csv.Click += new System.EventHandler(this.Save_csv_Click);
            // 
            // btn_DataBack
            // 
            this.btn_DataBack.Location = new System.Drawing.Point(72, 21);
            this.btn_DataBack.Name = "btn_DataBack";
            this.btn_DataBack.Size = new System.Drawing.Size(58, 34);
            this.btn_DataBack.TabIndex = 28;
            this.btn_DataBack.Text = "Data Reload";
            this.btn_DataBack.UseVisualStyleBackColor = true;
            this.btn_DataBack.Click += new System.EventHandler(this.btn_DataBack_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(73, 20);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(57, 35);
            this.btn_Stop.TabIndex = 27;
            this.btn_Stop.Text = "Stop Monitor";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(4, 20);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(63, 35);
            this.btn_Start.TabIndex = 26;
            this.btn_Start.Text = "Start Monitor";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1018, 586);
            this.zedGraphControl1.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(137, 20);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(57, 35);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(196, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "100000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SN
            // 
            this.txt_SN.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SN.Location = new System.Drawing.Point(187, 27);
            this.txt_SN.Name = "txt_SN";
            this.txt_SN.Size = new System.Drawing.Size(386, 30);
            this.txt_SN.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Controls.Add(this.Save_csv);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_DataBack);
            this.groupBox1.Location = new System.Drawing.Point(3, 589);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 68);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Count.Location = new System.Drawing.Point(627, 30);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(118, 24);
            this.label_Count.TabIndex = 107;
            this.label_Count.Text = "1001/3000";
            this.label_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(188, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 9);
            this.label2.TabIndex = 108;
            this.label2.Text = "SN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.Combo_Date);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Prev);
            this.groupBox2.Controls.Add(this.btn_Forward);
            this.groupBox2.Controls.Add(this.label_Count);
            this.groupBox2.Controls.Add(this.txt_SN);
            this.groupBox2.Location = new System.Drawing.Point(277, 589);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 68);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.BackgroundImage = global::BZGUI.Properties.Resources.Zoom;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Search.Location = new System.Drawing.Point(549, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(22, 22);
            this.btn_Search.TabIndex = 110;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Combo_Date
            // 
            this.Combo_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Date.FormattingEnabled = true;
            this.Combo_Date.Items.AddRange(new object[] {
            "20180510"});
            this.Combo_Date.Location = new System.Drawing.Point(6, 24);
            this.Combo_Date.Name = "Combo_Date";
            this.Combo_Date.Size = new System.Drawing.Size(123, 33);
            this.Combo_Date.TabIndex = 110;
            this.Combo_Date.SelectedIndexChanged += new System.EventHandler(this.Combo_Date_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 9);
            this.label3.TabIndex = 109;
            this.label3.Text = "Date";
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Prev.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Prev.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Prev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prev.Image")));
            this.btn_Prev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Prev.Location = new System.Drawing.Point(135, 22);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Prev.Size = new System.Drawing.Size(49, 37);
            this.btn_Prev.TabIndex = 105;
            this.btn_Prev.Tag = "-1";
            this.btn_Prev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Forward.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Forward.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Forward.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Forward.Image = global::BZGUI.Properties.Resources.you;
            this.btn_Forward.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Forward.Location = new System.Drawing.Point(579, 24);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Forward.Size = new System.Drawing.Size(49, 35);
            this.btn_Forward.TabIndex = 106;
            this.btn_Forward.Tag = "1";
            this.btn_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Forward.UseVisualStyleBackColor = false;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // PCI9222ctl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PCI9222ctl";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PCI9222ctl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PCI9222ctl_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_csv;
        private System.Windows.Forms.Button btn_DataBack;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Clear;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SN;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_Prev;
        public System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox Combo_Date;
        private System.Windows.Forms.Button btn_Search;
    }
}
