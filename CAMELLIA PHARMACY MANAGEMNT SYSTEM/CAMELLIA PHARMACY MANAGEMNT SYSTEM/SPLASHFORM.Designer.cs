namespace CAMELLIA_PHARMACY_MANAGEMNT_SYSTEM
{
    partial class SPLASHFORM
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
            this.progressivebar = new XanderUI.XUIFlatProgressBar();
            this.lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // progressivebar
            // 
            this.progressivebar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressivebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressivebar.BarStyle = XanderUI.XUIFlatProgressBar.Style.Flat;
            this.progressivebar.BorderColor = System.Drawing.Color.Black;
            this.progressivebar.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressivebar.InocmpletedColor = System.Drawing.Color.White;
            this.progressivebar.Location = new System.Drawing.Point(1, 316);
            this.progressivebar.MaxValue = 100;
            this.progressivebar.Name = "progressivebar";
            this.progressivebar.ShowBorder = false;
            this.progressivebar.Size = new System.Drawing.Size(670, 20);
            this.progressivebar.TabIndex = 10;
            this.progressivebar.Value = 50;
            // 
            // lab
            // 
            this.lab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(195, 9);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(328, 40);
            this.lab.TabIndex = 11;
            this.lab.Text = "CAMELLIA PHARMACY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Loading....";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 131;
            this.iconPictureBox5.Location = new System.Drawing.Point(273, 63);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(131, 135);
            this.iconPictureBox5.TabIndex = 14;
            this.iconPictureBox5.TabStop = false;
            // 
            // SPLASHFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(671, 336);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.progressivebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SPLASHFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPLASHFORM";
            this.Load += new System.EventHandler(this.SPLASHFORM_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIFlatProgressBar progressivebar;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}

