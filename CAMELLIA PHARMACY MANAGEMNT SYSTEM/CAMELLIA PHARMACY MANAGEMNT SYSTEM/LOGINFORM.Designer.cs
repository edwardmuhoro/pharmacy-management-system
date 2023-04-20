namespace CAMELLIA_PHARMACY_MANAGEMNT_SYSTEM
{
    partial class LOGINFORM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seepasschk = new XanderUI.XUICheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.btnlogin1 = new XanderUI.XUIButton();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnreset = new XanderUI.XUIButton();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cbousertypes = new System.Windows.Forms.ComboBox();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbl_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.seepasschk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.btnlogin1);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.cbousertypes);
            this.panel1.Location = new System.Drawing.Point(351, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 410);
            this.panel1.TabIndex = 22;
            // 
            // lbl_exit
            // 
            this.lbl_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.Red;
            this.lbl_exit.Location = new System.Drawing.Point(382, 380);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(50, 30);
            this.lbl_exit.TabIndex = 36;
            this.lbl_exit.Text = "Exit";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Show password";
            // 
            // seepasschk
            // 
            this.seepasschk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seepasschk.CheckboxCheckColor = System.Drawing.Color.Black;
            this.seepasschk.CheckboxColor = System.Drawing.Color.White;
            this.seepasschk.CheckboxHoverColor = System.Drawing.Color.White;
            this.seepasschk.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.seepasschk.Checked = false;
            this.seepasschk.ForeColor = System.Drawing.Color.White;
            this.seepasschk.Location = new System.Drawing.Point(154, 276);
            this.seepasschk.Name = "seepasschk";
            this.seepasschk.Size = new System.Drawing.Size(22, 22);
            this.seepasschk.TabIndex = 34;
            this.seepasschk.TickThickness = 2;
            this.seepasschk.Click += new System.EventHandler(this.seepasschk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(533, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "X";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(141, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(154, 32);
            this.login.TabIndex = 1;
            this.login.Text = "LOGIN HERE";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(46, 236);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(95, 25);
            this.password.TabIndex = 4;
            this.password.Text = "PassWord";
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(46, 179);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 25);
            this.username.TabIndex = 3;
            this.username.Text = "UserName";
            // 
            // btnlogin1
            // 
            this.btnlogin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlogin1.BackgroundColor = System.Drawing.Color.White;
            this.btnlogin1.ButtonImage = null;
            this.btnlogin1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnlogin1.ButtonText = "login";
            this.btnlogin1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnlogin1.ClickTextColor = System.Drawing.Color.Black;
            this.btnlogin1.CornerRadius = 5;
            this.btnlogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnlogin1.HoverTextColor = System.Drawing.Color.Black;
            this.btnlogin1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnlogin1.Location = new System.Drawing.Point(100, 330);
            this.btnlogin1.Name = "btnlogin1";
            this.btnlogin1.Size = new System.Drawing.Size(90, 34);
            this.btnlogin1.TabIndex = 15;
            this.btnlogin1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnlogin1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin1.Click += new System.EventHandler(this.btnlogin1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(154, 232);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(204, 29);
            this.txtpassword.TabIndex = 9;
            // 
            // btnreset
            // 
            this.btnreset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnreset.BackgroundColor = System.Drawing.Color.White;
            this.btnreset.ButtonImage = null;
            this.btnreset.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnreset.ButtonText = "Reset";
            this.btnreset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnreset.ClickTextColor = System.Drawing.Color.Black;
            this.btnreset.CornerRadius = 5;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnreset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnreset.HoverTextColor = System.Drawing.Color.Black;
            this.btnreset.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnreset.Location = new System.Drawing.Point(206, 330);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(89, 34);
            this.btnreset.TabIndex = 17;
            this.btnreset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnreset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(154, 175);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(204, 29);
            this.txtusername.TabIndex = 8;
            // 
            // cbousertypes
            // 
            this.cbousertypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbousertypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbousertypes.FormattingEnabled = true;
            this.cbousertypes.Items.AddRange(new object[] {
            "Owner",
            "Pharmacist",
            "Stock Manager"});
            this.cbousertypes.Location = new System.Drawing.Point(196, 87);
            this.cbousertypes.Name = "cbousertypes";
            this.cbousertypes.Size = new System.Drawing.Size(162, 29);
            this.cbousertypes.TabIndex = 16;
            this.cbousertypes.Text = "Select user";
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Chocolate;
            this.xuiGradientPanel1.Controls.Add(this.iconPictureBox5);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-1, -2);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(354, 410);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 21;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.Tomato;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Salmon;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 180;
            this.iconPictureBox5.Location = new System.Drawing.Point(87, 101);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(180, 187);
            this.iconPictureBox5.TabIndex = 10;
            this.iconPictureBox5.TabStop = false;
            // 
            // LOGINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGINFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGINFORM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xuiGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUICheckBox seepasschk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private XanderUI.XUIButton btnlogin1;
        private System.Windows.Forms.TextBox txtpassword;
        private XanderUI.XUIButton btnreset;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ComboBox cbousertypes;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}