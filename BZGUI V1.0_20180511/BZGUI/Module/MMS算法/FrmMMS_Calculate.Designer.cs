namespace BZGUI
{
    partial class FrmMMS_Calculate
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.btn_Readheigh = new System.Windows.Forms.Button();
            this.btn_ShowQ = new System.Windows.Forms.Button();
            this.btn_ShowAQ = new System.Windows.Forms.Button();
            this.btn_Curretn = new System.Windows.Forms.Button();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.btn_SaveAll = new System.Windows.Forms.Button();
            this.btn_Save_Current = new System.Windows.Forms.Button();
            this.btn_CopyScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(495, 324);
            this.zedGraphControl1.TabIndex = 5;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(504, 3);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(495, 324);
            this.zedGraphControl2.TabIndex = 6;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(3, 333);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(495, 324);
            this.zedGraphControl3.TabIndex = 7;
            // 
            // btn_Readheigh
            // 
            this.btn_Readheigh.Location = new System.Drawing.Point(504, 333);
            this.btn_Readheigh.Name = "btn_Readheigh";
            this.btn_Readheigh.Size = new System.Drawing.Size(90, 39);
            this.btn_Readheigh.TabIndex = 8;
            this.btn_Readheigh.Text = "读高度值";
            this.btn_Readheigh.UseVisualStyleBackColor = true;
            this.btn_Readheigh.Click += new System.EventHandler(this.btn_Readheigh_Click);
            // 
            // btn_ShowQ
            // 
            this.btn_ShowQ.Location = new System.Drawing.Point(504, 378);
            this.btn_ShowQ.Name = "btn_ShowQ";
            this.btn_ShowQ.Size = new System.Drawing.Size(90, 38);
            this.btn_ShowQ.TabIndex = 9;
            this.btn_ShowQ.Text = "显示θ";
            this.btn_ShowQ.UseVisualStyleBackColor = true;
            this.btn_ShowQ.Click += new System.EventHandler(this.btn_ShowQ_Click);
            // 
            // btn_ShowAQ
            // 
            this.btn_ShowAQ.Location = new System.Drawing.Point(504, 422);
            this.btn_ShowAQ.Name = "btn_ShowAQ";
            this.btn_ShowAQ.Size = new System.Drawing.Size(90, 37);
            this.btn_ShowAQ.TabIndex = 10;
            this.btn_ShowAQ.Text = "显示Δθ \'";
            this.btn_ShowAQ.UseVisualStyleBackColor = true;
            this.btn_ShowAQ.Click += new System.EventHandler(this.btn_ShowAQ_Click);
            // 
            // btn_Curretn
            // 
            this.btn_Curretn.Location = new System.Drawing.Point(504, 573);
            this.btn_Curretn.Name = "btn_Curretn";
            this.btn_Curretn.Size = new System.Drawing.Size(90, 36);
            this.btn_Curretn.TabIndex = 11;
            this.btn_Curretn.Text = "读电流";
            this.btn_Curretn.UseVisualStyleBackColor = true;
            this.btn_Curretn.Click += new System.EventHandler(this.btn_Curretn_Click);
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Location = new System.Drawing.Point(600, 333);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(399, 324);
            this.zedGraphControl4.TabIndex = 12;
            // 
            // btn_SaveAll
            // 
            this.btn_SaveAll.Location = new System.Drawing.Point(504, 468);
            this.btn_SaveAll.Name = "btn_SaveAll";
            this.btn_SaveAll.Size = new System.Drawing.Size(90, 36);
            this.btn_SaveAll.TabIndex = 13;
            this.btn_SaveAll.Text = "保存数据";
            this.btn_SaveAll.UseVisualStyleBackColor = true;
            this.btn_SaveAll.Click += new System.EventHandler(this.btn_SaveAll_Click);
            // 
            // btn_Save_Current
            // 
            this.btn_Save_Current.Location = new System.Drawing.Point(504, 623);
            this.btn_Save_Current.Name = "btn_Save_Current";
            this.btn_Save_Current.Size = new System.Drawing.Size(90, 36);
            this.btn_Save_Current.TabIndex = 14;
            this.btn_Save_Current.Text = "保存电流值";
            this.btn_Save_Current.UseVisualStyleBackColor = true;
            this.btn_Save_Current.Click += new System.EventHandler(this.btn_Save_Current_Click);
            // 
            // btn_CopyScreen
            // 
            this.btn_CopyScreen.Location = new System.Drawing.Point(504, 521);
            this.btn_CopyScreen.Name = "btn_CopyScreen";
            this.btn_CopyScreen.Size = new System.Drawing.Size(90, 36);
            this.btn_CopyScreen.TabIndex = 15;
            this.btn_CopyScreen.Text = "截屏";
            this.btn_CopyScreen.UseVisualStyleBackColor = true;
            this.btn_CopyScreen.Click += new System.EventHandler(this.btn_CopyScreen_Click);
            // 
            // FrmMMS_Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 692);
            this.Controls.Add(this.btn_CopyScreen);
            this.Controls.Add(this.btn_Save_Current);
            this.Controls.Add(this.btn_SaveAll);
            this.Controls.Add(this.zedGraphControl4);
            this.Controls.Add(this.btn_Curretn);
            this.Controls.Add(this.btn_ShowAQ);
            this.Controls.Add(this.btn_ShowQ);
            this.Controls.Add(this.btn_Readheigh);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "FrmMMS_Calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMMS_Calculate";
            this.Load += new System.EventHandler(this.FrmMMS_Calculate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.Button btn_Readheigh;
        private System.Windows.Forms.Button btn_ShowQ;
        private System.Windows.Forms.Button btn_ShowAQ;
        private System.Windows.Forms.Button btn_Curretn;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private System.Windows.Forms.Button btn_SaveAll;
        private System.Windows.Forms.Button btn_Save_Current;
        private System.Windows.Forms.Button btn_CopyScreen;
    }
}