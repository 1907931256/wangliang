namespace BZGUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Text_Password2 = new System.Windows.Forms.TextBox();
            this.Text_Password1 = new System.Windows.Forms.TextBox();
            this.Combo_User = new System.Windows.Forms.ComboBox();
            this.Lb_NPassword2 = new System.Windows.Forms.Label();
            this.Lb_NPassword1 = new System.Windows.Forms.Label();
            this.Btn_Change = new System.Windows.Forms.Button();
            this.CheckBox_PWChange = new System.Windows.Forms.CheckBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_Password
            // 
            this.Text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Password.Location = new System.Drawing.Point(156, 80);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '*';
            this.Text_Password.Size = new System.Drawing.Size(240, 31);
            this.Text_Password.TabIndex = 71;
            this.Text_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Password.Click += new System.EventHandler(this.Text_Password_Click);
            // 
            // Text_Password2
            // 
            this.Text_Password2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Password2.Location = new System.Drawing.Point(156, 273);
            this.Text_Password2.Name = "Text_Password2";
            this.Text_Password2.Size = new System.Drawing.Size(240, 32);
            this.Text_Password2.TabIndex = 70;
            this.Text_Password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Password1
            // 
            this.Text_Password1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Password1.Location = new System.Drawing.Point(156, 218);
            this.Text_Password1.Name = "Text_Password1";
            this.Text_Password1.Size = new System.Drawing.Size(240, 32);
            this.Text_Password1.TabIndex = 69;
            this.Text_Password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Combo_User
            // 
            this.Combo_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_User.FormattingEnabled = true;
            this.Combo_User.Location = new System.Drawing.Point(156, 23);
            this.Combo_User.Name = "Combo_User";
            this.Combo_User.Size = new System.Drawing.Size(240, 33);
            this.Combo_User.TabIndex = 68;
            this.Combo_User.SelectedIndexChanged += new System.EventHandler(this.Combo_User_SelectedIndexChanged);
            // 
            // Lb_NPassword2
            // 
            this.Lb_NPassword2.AutoSize = true;
            this.Lb_NPassword2.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NPassword2.Location = new System.Drawing.Point(21, 283);
            this.Lb_NPassword2.Name = "Lb_NPassword2";
            this.Lb_NPassword2.Size = new System.Drawing.Size(111, 16);
            this.Lb_NPassword2.TabIndex = 67;
            this.Lb_NPassword2.Text = "New Password 2";
            // 
            // Lb_NPassword1
            // 
            this.Lb_NPassword1.AutoSize = true;
            this.Lb_NPassword1.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NPassword1.Location = new System.Drawing.Point(21, 218);
            this.Lb_NPassword1.Name = "Lb_NPassword1";
            this.Lb_NPassword1.Size = new System.Drawing.Size(111, 16);
            this.Lb_NPassword1.TabIndex = 66;
            this.Lb_NPassword1.Text = "New Password 1";
            // 
            // Btn_Change
            // 
            this.Btn_Change.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Change.Location = new System.Drawing.Point(291, 326);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(89, 32);
            this.Btn_Change.TabIndex = 65;
            this.Btn_Change.Text = "Change";
            this.Btn_Change.UseVisualStyleBackColor = true;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            // 
            // CheckBox_PWChange
            // 
            this.CheckBox_PWChange.AutoSize = true;
            this.CheckBox_PWChange.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_PWChange.Location = new System.Drawing.Point(420, 159);
            this.CheckBox_PWChange.Name = "CheckBox_PWChange";
            this.CheckBox_PWChange.Size = new System.Drawing.Size(142, 20);
            this.CheckBox_PWChange.TabIndex = 64;
            this.CheckBox_PWChange.Text = "Password Changes";
            this.CheckBox_PWChange.UseVisualStyleBackColor = true;
            this.CheckBox_PWChange.CheckedChanged += new System.EventHandler(this.CheckBox_PWChange_CheckedChanged);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(290, 147);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(89, 32);
            this.Btn_Cancel.TabIndex = 63;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(157, 147);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(89, 32);
            this.Btn_Login.TabIndex = 62;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(21, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 24);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(21, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 24);
            this.Label1.TabIndex = 60;
            this.Label1.Text = "User Name";
            this.Label1.DoubleClick += new System.EventHandler(this.Label1_DoubleClick);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.ErrorImage")));
            this.PictureBox2.Location = new System.Drawing.Point(437, 16);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 80);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 59;
            this.PictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(580, 370);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Text_Password2);
            this.Controls.Add(this.Text_Password1);
            this.Controls.Add(this.Combo_User);
            this.Controls.Add(this.Lb_NPassword2);
            this.Controls.Add(this.Lb_NPassword1);
            this.Controls.Add(this.Btn_Change);
            this.Controls.Add(this.CheckBox_PWChange);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox Text_Password;
        internal System.Windows.Forms.TextBox Text_Password2;
        internal System.Windows.Forms.TextBox Text_Password1;
        internal System.Windows.Forms.ComboBox Combo_User;
        internal System.Windows.Forms.Label Lb_NPassword2;
        internal System.Windows.Forms.Label Lb_NPassword1;
        internal System.Windows.Forms.Button Btn_Change;
        internal System.Windows.Forms.CheckBox CheckBox_PWChange;
        internal System.Windows.Forms.Button Btn_Cancel;
        internal System.Windows.Forms.Button Btn_Login;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox2;
    }
}