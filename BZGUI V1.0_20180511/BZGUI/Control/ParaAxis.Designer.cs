namespace BZGUI
{
    partial class ParaAxis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button62 = new System.Windows.Forms.Button();
            this.Button61 = new System.Windows.Forms.Button();
            this.DataGridView_par = new System.Windows.Forms.DataGridView();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_par)).BeginInit();
            this.SuspendLayout();
            // 
            // Button62
            // 
            this.Button62.BackColor = System.Drawing.Color.SpringGreen;
            this.Button62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button62.Location = new System.Drawing.Point(608, 328);
            this.Button62.Name = "Button62";
            this.Button62.Size = new System.Drawing.Size(80, 41);
            this.Button62.TabIndex = 16;
            this.Button62.Text = "修改";
            this.Button62.UseVisualStyleBackColor = false;
            this.Button62.Click += new System.EventHandler(this.Button62_Click);
            // 
            // Button61
            // 
            this.Button61.BackColor = System.Drawing.Color.SpringGreen;
            this.Button61.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button61.Location = new System.Drawing.Point(608, 382);
            this.Button61.Name = "Button61";
            this.Button61.Size = new System.Drawing.Size(80, 41);
            this.Button61.TabIndex = 15;
            this.Button61.Text = "保存";
            this.Button61.UseVisualStyleBackColor = false;
            this.Button61.Click += new System.EventHandler(this.Button61_Click);
            // 
            // DataGridView_par
            // 
            this.DataGridView_par.AllowUserToAddRows = false;
            this.DataGridView_par.AllowUserToDeleteRows = false;
            this.DataGridView_par.AllowUserToResizeColumns = false;
            this.DataGridView_par.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView_par.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_par.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_par.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_par.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView_par.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_par.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28});
            this.DataGridView_par.GridColor = System.Drawing.Color.DarkOrange;
            this.DataGridView_par.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_par.MultiSelect = false;
            this.DataGridView_par.Name = "DataGridView_par";
            this.DataGridView_par.ReadOnly = true;
            this.DataGridView_par.RowHeadersWidth = 4;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView_par.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_par.RowTemplate.Height = 23;
            this.DataGridView_par.Size = new System.Drawing.Size(584, 420);
            this.DataGridView_par.TabIndex = 14;
            // 
            // Column24
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column24.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column24.HeaderText = "轴号名称";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column24.Width = 150;
            // 
            // Column25
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column25.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column25.HeaderText = "丝杆导程";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column26
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column26.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column26.HeaderText = "减速比";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column27
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column27.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column27.HeaderText = "每转脉冲数";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column27.Width = 120;
            // 
            // Column28
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column28.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column28.HeaderText = "轴速度";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            // 
            // ParaAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button62);
            this.Controls.Add(this.Button61);
            this.Controls.Add(this.DataGridView_par);
            this.Name = "ParaAxis";
            this.Size = new System.Drawing.Size(721, 426);
            this.Load += new System.EventHandler(this.ParaAxis_Load);
            this.SizeChanged += new System.EventHandler(this.ParaAxis_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_par)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button62;
        internal System.Windows.Forms.Button Button61;
        internal System.Windows.Forms.DataGridView DataGridView_par;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column28;
    }
}
