namespace BZGUI
{
    partial class PageAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAlarm));
            this.LB_CodeDescription = new System.Windows.Forms.ListBox();
            this.RoundPanel4 = new BZ.UI.RoundPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Alarm = new System.Windows.Forms.TabPage();
            this.Button_Store = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_Errorcode = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.alarmChart1 = new BZGUI.AlarmChart();
            this.RoundPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Alarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Errorcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_CodeDescription
            // 
            this.LB_CodeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.LB_CodeDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_CodeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CodeDescription.FormattingEnabled = true;
            this.LB_CodeDescription.ItemHeight = 20;
            this.LB_CodeDescription.Items.AddRange(new object[] {
            "● Code: xxxx & Category",
            "● Description"});
            this.LB_CodeDescription.Location = new System.Drawing.Point(9, 11);
            this.LB_CodeDescription.Name = "LB_CodeDescription";
            this.LB_CodeDescription.Size = new System.Drawing.Size(533, 60);
            this.LB_CodeDescription.TabIndex = 0;
            // 
            // RoundPanel4
            // 
            this.RoundPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.RoundPanel4.BZ_AutoBkColor = true;
            this.RoundPanel4.BZ_Radius = ((byte)(6));
            this.RoundPanel4.BZ_Version = "V1.0.0";
            this.RoundPanel4.Controls.Add(this.LB_CodeDescription);
            this.RoundPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.RoundPanel4.Location = new System.Drawing.Point(6, 4);
            this.RoundPanel4.Name = "RoundPanel4";
            this.RoundPanel4.Size = new System.Drawing.Size(550, 80);
            this.RoundPanel4.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tab_Alarm);
            this.tabControl1.Controls.Add(this.tab_Errorcode);
            this.tabControl1.Location = new System.Drawing.Point(3, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 560);
            this.tabControl1.TabIndex = 18;
            // 
            // tab_Alarm
            // 
            this.tab_Alarm.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Alarm.Controls.Add(this.Button_Store);
            this.tab_Alarm.Controls.Add(this.dataGridView1);
            this.tab_Alarm.Location = new System.Drawing.Point(4, 25);
            this.tab_Alarm.Name = "tab_Alarm";
            this.tab_Alarm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Alarm.Size = new System.Drawing.Size(545, 531);
            this.tab_Alarm.TabIndex = 0;
            this.tab_Alarm.Text = "Alarm";
            // 
            // Button_Store
            // 
            this.Button_Store.Image = ((System.Drawing.Image)(resources.GetObject("Button_Store.Image")));
            this.Button_Store.Location = new System.Drawing.Point(237, 458);
            this.Button_Store.Name = "Button_Store";
            this.Button_Store.Size = new System.Drawing.Size(78, 70);
            this.Button_Store.TabIndex = 5;
            this.Button_Store.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(534, 452);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tab_Errorcode
            // 
            this.tab_Errorcode.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Errorcode.Controls.Add(this.dataGridView2);
            this.tab_Errorcode.Location = new System.Drawing.Point(4, 25);
            this.tab_Errorcode.Name = "tab_Errorcode";
            this.tab_Errorcode.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Errorcode.Size = new System.Drawing.Size(545, 531);
            this.tab_Errorcode.TabIndex = 1;
            this.tab_Errorcode.Text = "ErrorCode";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(534, 515);
            this.dataGridView2.TabIndex = 17;
            // 
            // alarmChart1
            // 
            this.alarmChart1.Location = new System.Drawing.Point(562, 4);
            this.alarmChart1.Name = "alarmChart1";
            this.alarmChart1.Size = new System.Drawing.Size(459, 653);
            this.alarmChart1.TabIndex = 19;
            // 
            // PageAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alarmChart1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RoundPanel4);
            this.Name = "PageAlarm";
            this.Size = new System.Drawing.Size(1024, 660);
            this.Load += new System.EventHandler(this.PageAlarm_Load);
            this.SizeChanged += new System.EventHandler(this.PageAlarm_SizeChanged);
            this.RoundPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_Alarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Errorcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox LB_CodeDescription;
        internal BZ.UI.RoundPanel RoundPanel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Alarm;
        internal System.Windows.Forms.Button Button_Store;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tab_Errorcode;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AlarmChart alarmChart1;

    }
}
