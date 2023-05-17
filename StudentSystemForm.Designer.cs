namespace attendance_tracker
{
    partial class StudentSystemForm
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
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.panelFeature = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateQr = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 5;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::attendance_tracker.Properties.Resources.logout;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(9, 719);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(230, 45);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelFeature
            // 
            this.panelFeature.Location = new System.Drawing.Point(249, 113);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(1077, 676);
            this.panelFeature.TabIndex = 25;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(344, 54);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 22);
            this.lblPosition.TabIndex = 24;
            this.lblPosition.Text = "label4";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(344, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 22);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "label4";
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeDate.Location = new System.Drawing.Point(1076, 89);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(0, 18);
            this.lblTimeDate.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Position: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Username:";
            // 
            // btnGenerateQr
            // 
            this.btnGenerateQr.BorderRadius = 5;
            this.btnGenerateQr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateQr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateQr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateQr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateQr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQr.ForeColor = System.Drawing.Color.White;
            this.btnGenerateQr.Image = global::attendance_tracker.Properties.Resources.qr_code;
            this.btnGenerateQr.ImageOffset = new System.Drawing.Point(-50, 0);
            this.btnGenerateQr.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateQr.Location = new System.Drawing.Point(10, 339);
            this.btnGenerateQr.Name = "btnGenerateQr";
            this.btnGenerateQr.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnGenerateQr.Size = new System.Drawing.Size(230, 45);
            this.btnGenerateQr.TabIndex = 38;
            this.btnGenerateQr.Text = "Generate Qr";
            this.btnGenerateQr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnGenerateQr.Click += new System.EventHandler(this.btnGenerateQr_Click);
            // 
            // btnReport
            // 
            this.btnReport.BorderRadius = 5;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::attendance_tracker.Properties.Resources.image_removebg_preview__16_;
            this.btnReport.ImageOffset = new System.Drawing.Point(-50, 0);
            this.btnReport.ImageSize = new System.Drawing.Size(50, 40);
            this.btnReport.Location = new System.Drawing.Point(10, 274);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(0, 0, 73, 0);
            this.btnReport.Size = new System.Drawing.Size(230, 45);
            this.btnReport.TabIndex = 39;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::attendance_tracker.Properties.Resources._343377971_947319489623852_6717023610931298900_n1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(28, 16);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(180, 180);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 26;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::attendance_tracker.Properties.Resources.image_removebg_preview__18_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1248, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 67);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 44;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(792, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 33);
            this.label3.TabIndex = 45;
            this.label3.Text = "\"Nurturing Tomorrow\'s Noblest\"";
            // 
            // StudentSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 790);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.panelFeature);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnGenerateQr);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentSystemForm";
            this.Load += new System.EventHandler(this.StudentSystemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panelFeature;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGenerateQr;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
    }
}