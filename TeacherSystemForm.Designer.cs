namespace attendance_tracker
{
    partial class TeacherSystemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panelFeature = new System.Windows.Forms.Panel();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageClass = new Guna.UI2.WinForms.Guna2Button();
            this.btnAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position: ";
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeDate.Location = new System.Drawing.Point(1095, 90);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(0, 17);
            this.lblTimeDate.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(352, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 22);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label4";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(352, 55);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 22);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "label4";
            // 
            // panelFeature
            // 
            this.panelFeature.Location = new System.Drawing.Point(250, 114);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(1077, 676);
            this.panelFeature.TabIndex = 7;
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
            this.btnReport.Location = new System.Drawing.Point(11, 447);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.btnReport.Size = new System.Drawing.Size(230, 45);
            this.btnReport.TabIndex = 4;
            this.btnReport.Tag = "4";
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.BorderRadius = 5;
            this.btnManageStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudent.ForeColor = System.Drawing.Color.White;
            this.btnManageStudent.Image = global::attendance_tracker.Properties.Resources.icons8_schoolboy_at_a_desk_30;
            this.btnManageStudent.ImageOffset = new System.Drawing.Point(-50, 0);
            this.btnManageStudent.ImageSize = new System.Drawing.Size(30, 33);
            this.btnManageStudent.Location = new System.Drawing.Point(11, 382);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnManageStudent.Size = new System.Drawing.Size(230, 45);
            this.btnManageStudent.TabIndex = 3;
            this.btnManageStudent.Tag = "3";
            this.btnManageStudent.Text = "Manage Student";
            this.btnManageStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // btnManageClass
            // 
            this.btnManageClass.BorderRadius = 5;
            this.btnManageClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClass.ForeColor = System.Drawing.Color.White;
            this.btnManageClass.Image = global::attendance_tracker.Properties.Resources._1979353;
            this.btnManageClass.ImageOffset = new System.Drawing.Point(-50, 0);
            this.btnManageClass.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageClass.Location = new System.Drawing.Point(11, 317);
            this.btnManageClass.Name = "btnManageClass";
            this.btnManageClass.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnManageClass.Size = new System.Drawing.Size(230, 45);
            this.btnManageClass.TabIndex = 2;
            this.btnManageClass.Tag = "2";
            this.btnManageClass.Text = "Manage Class";
            this.btnManageClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnManageClass.Click += new System.EventHandler(this.btnManageClass_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BorderRadius = 5;
            this.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAttendance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = global::attendance_tracker.Properties.Resources.calendar1;
            this.btnAttendance.ImageOffset = new System.Drawing.Point(-50, 0);
            this.btnAttendance.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAttendance.Location = new System.Drawing.Point(11, 252);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(0, 0, 42, 0);
            this.btnAttendance.Size = new System.Drawing.Size(230, 45);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Tag = "1";
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::attendance_tracker.Properties.Resources.logout;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-5, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(11, 720);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.guna2Button1.Size = new System.Drawing.Size(230, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Tag = "5";
            this.guna2Button1.Text = "Log out";
            this.guna2Button1.TextOffset = new System.Drawing.Point(-9, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(794, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "\"Nurturing Tomorrow\'s Noblest\"";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::attendance_tracker.Properties.Resources._343377971_947319489623852_6717023610931298900_n;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(29, 17);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(180, 180);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = global::attendance_tracker.Properties.Resources.image_removebg_preview__18_;
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(1250, 10);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(68, 67);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox7.TabIndex = 0;
            this.guna2PictureBox7.TabStop = false;
            // 
            // TeacherSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 790);
            this.Controls.Add(this.guna2PictureBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnManageStudent);
            this.Controls.Add(this.btnManageClass);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.panelFeature);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemForm";
            this.Load += new System.EventHandler(this.SystemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panelFeature;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnManageStudent;
        private Guna.UI2.WinForms.Guna2Button btnManageClass;
        private Guna.UI2.WinForms.Guna2Button btnAttendance;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private System.Windows.Forms.Timer timer1;
    }
}