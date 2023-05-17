namespace attendance_tracker
{
    partial class SystemAttendance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnViewRecord = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSection = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtYearLevel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProgram = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStudentId = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbScanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEnterRecord = new Guna.UI2.WinForms.Guna2Button();
            this.rad_Female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rad_Male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.numericYearLevel = new System.Windows.Forms.NumericUpDown();
            this.cmb_Sec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbProg = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_LN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCOURSE = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanner)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(47, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btnViewRecord);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSection);
            this.tabPage1.Controls.Add(this.txtYearLevel);
            this.tabPage1.Controls.Add(this.txtProgram);
            this.tabPage1.Controls.Add(this.txtLN);
            this.tabPage1.Controls.Add(this.txtMN);
            this.tabPage1.Controls.Add(this.txtFN);
            this.tabPage1.Controls.Add(this.txtStudentId);
            this.tabPage1.Controls.Add(this.pbScanner);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QR Scan";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(844, 376);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Section:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(714, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "Year Level:";
            // 
            // btnViewRecord
            // 
            this.btnViewRecord.BorderRadius = 3;
            this.btnViewRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRecord.ForeColor = System.Drawing.Color.White;
            this.btnViewRecord.Location = new System.Drawing.Point(675, 475);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(180, 45);
            this.btnViewRecord.TabIndex = 3;
            this.btnViewRecord.Text = "VIEW RECORD";
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Program:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "STUDENT ID:";
            // 
            // txtSection
            // 
            this.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSection.DefaultText = "";
            this.txtSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSection.Location = new System.Drawing.Point(848, 410);
            this.txtSection.Margin = new System.Windows.Forms.Padding(4);
            this.txtSection.Name = "txtSection";
            this.txtSection.PasswordChar = '\0';
            this.txtSection.PlaceholderText = "";
            this.txtSection.SelectedText = "";
            this.txtSection.Size = new System.Drawing.Size(105, 34);
            this.txtSection.TabIndex = 1;
            // 
            // txtYearLevel
            // 
            this.txtYearLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYearLevel.DefaultText = "";
            this.txtYearLevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYearLevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYearLevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYearLevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYearLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYearLevel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYearLevel.Location = new System.Drawing.Point(717, 410);
            this.txtYearLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearLevel.Name = "txtYearLevel";
            this.txtYearLevel.PasswordChar = '\0';
            this.txtYearLevel.PlaceholderText = "";
            this.txtYearLevel.SelectedText = "";
            this.txtYearLevel.Size = new System.Drawing.Size(105, 34);
            this.txtYearLevel.TabIndex = 1;
            // 
            // txtProgram
            // 
            this.txtProgram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProgram.DefaultText = "";
            this.txtProgram.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProgram.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProgram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProgram.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProgram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProgram.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProgram.Location = new System.Drawing.Point(589, 410);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.PasswordChar = '\0';
            this.txtProgram.PlaceholderText = "";
            this.txtProgram.SelectedText = "";
            this.txtProgram.Size = new System.Drawing.Size(105, 34);
            this.txtProgram.TabIndex = 1;
            // 
            // txtLN
            // 
            this.txtLN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLN.DefaultText = "";
            this.txtLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLN.Location = new System.Drawing.Point(589, 318);
            this.txtLN.Margin = new System.Windows.Forms.Padding(4);
            this.txtLN.Name = "txtLN";
            this.txtLN.PasswordChar = '\0';
            this.txtLN.PlaceholderText = "";
            this.txtLN.SelectedText = "";
            this.txtLN.Size = new System.Drawing.Size(315, 34);
            this.txtLN.TabIndex = 1;
            // 
            // txtMN
            // 
            this.txtMN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMN.DefaultText = "";
            this.txtMN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMN.Location = new System.Drawing.Point(589, 234);
            this.txtMN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMN.Name = "txtMN";
            this.txtMN.PasswordChar = '\0';
            this.txtMN.PlaceholderText = "";
            this.txtMN.SelectedText = "";
            this.txtMN.Size = new System.Drawing.Size(315, 34);
            this.txtMN.TabIndex = 1;
            // 
            // txtFN
            // 
            this.txtFN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFN.DefaultText = "";
            this.txtFN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFN.Location = new System.Drawing.Point(589, 150);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4);
            this.txtFN.Name = "txtFN";
            this.txtFN.PasswordChar = '\0';
            this.txtFN.PlaceholderText = "";
            this.txtFN.SelectedText = "";
            this.txtFN.Size = new System.Drawing.Size(315, 34);
            this.txtFN.TabIndex = 1;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentId.DefaultText = "";
            this.txtStudentId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentId.Location = new System.Drawing.Point(589, 66);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.PasswordChar = '\0';
            this.txtStudentId.PlaceholderText = "";
            this.txtStudentId.SelectedText = "";
            this.txtStudentId.Size = new System.Drawing.Size(266, 34);
            this.txtStudentId.TabIndex = 1;
            // 
            // pbScanner
            // 
            this.pbScanner.BorderRadius = 10;
            this.pbScanner.ImageRotate = 0F;
            this.pbScanner.Location = new System.Drawing.Point(33, 32);
            this.pbScanner.Name = "pbScanner";
            this.pbScanner.Size = new System.Drawing.Size(486, 459);
            this.pbScanner.TabIndex = 0;
            this.pbScanner.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEnterRecord);
            this.tabPage2.Controls.Add(this.rad_Female);
            this.tabPage2.Controls.Add(this.rad_Male);
            this.tabPage2.Controls.Add(this.numericYearLevel);
            this.tabPage2.Controls.Add(this.cmb_Sec);
            this.tabPage2.Controls.Add(this.cmbProg);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_LN);
            this.tabPage2.Controls.Add(this.txt_MN);
            this.tabPage2.Controls.Add(this.txt_FirstName);
            this.tabPage2.Controls.Add(this.txt_ID);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual Input";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEnterRecord
            // 
            this.btnEnterRecord.BorderRadius = 3;
            this.btnEnterRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnterRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnterRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnterRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnterRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterRecord.ForeColor = System.Drawing.Color.White;
            this.btnEnterRecord.Location = new System.Drawing.Point(786, 470);
            this.btnEnterRecord.Name = "btnEnterRecord";
            this.btnEnterRecord.Size = new System.Drawing.Size(180, 45);
            this.btnEnterRecord.TabIndex = 8;
            this.btnEnterRecord.Text = "ENTER RECORD";
            this.btnEnterRecord.Click += new System.EventHandler(this.btnEnterRecord_Click);
            // 
            // rad_Female
            // 
            this.rad_Female.AutoSize = true;
            this.rad_Female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_Female.CheckedState.BorderThickness = 0;
            this.rad_Female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_Female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rad_Female.CheckedState.InnerOffset = -4;
            this.rad_Female.Location = new System.Drawing.Point(140, 359);
            this.rad_Female.Name = "rad_Female";
            this.rad_Female.Size = new System.Drawing.Size(79, 22);
            this.rad_Female.TabIndex = 7;
            this.rad_Female.Text = "Female";
            this.rad_Female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rad_Female.UncheckedState.BorderThickness = 2;
            this.rad_Female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rad_Female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rad_Male
            // 
            this.rad_Male.AutoSize = true;
            this.rad_Male.Checked = true;
            this.rad_Male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_Male.CheckedState.BorderThickness = 0;
            this.rad_Male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rad_Male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rad_Male.CheckedState.InnerOffset = -4;
            this.rad_Male.Location = new System.Drawing.Point(46, 359);
            this.rad_Male.Name = "rad_Male";
            this.rad_Male.Size = new System.Drawing.Size(60, 22);
            this.rad_Male.TabIndex = 7;
            this.rad_Male.TabStop = true;
            this.rad_Male.Text = "Male";
            this.rad_Male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rad_Male.UncheckedState.BorderThickness = 2;
            this.rad_Male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rad_Male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // numericYearLevel
            // 
            this.numericYearLevel.Location = new System.Drawing.Point(606, 361);
            this.numericYearLevel.Name = "numericYearLevel";
            this.numericYearLevel.Size = new System.Drawing.Size(120, 26);
            this.numericYearLevel.TabIndex = 6;
            this.numericYearLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYearLevel.ValueChanged += new System.EventHandler(this.numericYearLevel_ValueChanged);
            // 
            // cmb_Sec
            // 
            this.cmb_Sec.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Sec.BorderRadius = 5;
            this.cmb_Sec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sec.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Sec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Sec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Sec.ItemHeight = 30;
            this.cmb_Sec.Location = new System.Drawing.Point(757, 356);
            this.cmb_Sec.Name = "cmb_Sec";
            this.cmb_Sec.Size = new System.Drawing.Size(120, 36);
            this.cmb_Sec.TabIndex = 5;
            // 
            // cmbProg
            // 
            this.cmbProg.BackColor = System.Drawing.Color.Transparent;
            this.cmbProg.BorderRadius = 5;
            this.cmbProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProg.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProg.ItemHeight = 30;
            this.cmbProg.Items.AddRange(new object[] {
            "BSBA",
            "BSOA",
            "BSA",
            "BSIT",
            "BSIS"});
            this.cmbProg.Location = new System.Drawing.Point(325, 356);
            this.cmbProg.Name = "cmbProg";
            this.cmbProg.Size = new System.Drawing.Size(242, 36);
            this.cmbProg.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(754, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Section:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Last Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(603, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Year Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "MIddle Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 18);
            this.label15.TabIndex = 4;
            this.label15.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Program:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "STUDENT ID:";
            // 
            // txt_LN
            // 
            this.txt_LN.BorderRadius = 3;
            this.txt_LN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LN.DefaultText = "";
            this.txt_LN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LN.Location = new System.Drawing.Point(604, 235);
            this.txt_LN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LN.Name = "txt_LN";
            this.txt_LN.PasswordChar = '\0';
            this.txt_LN.PlaceholderText = "";
            this.txt_LN.SelectedText = "";
            this.txt_LN.Size = new System.Drawing.Size(242, 41);
            this.txt_LN.TabIndex = 3;
            // 
            // txt_MN
            // 
            this.txt_MN.BorderRadius = 3;
            this.txt_MN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MN.DefaultText = "";
            this.txt_MN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MN.Location = new System.Drawing.Point(325, 235);
            this.txt_MN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MN.Name = "txt_MN";
            this.txt_MN.PasswordChar = '\0';
            this.txt_MN.PlaceholderText = "";
            this.txt_MN.SelectedText = "";
            this.txt_MN.Size = new System.Drawing.Size(242, 41);
            this.txt_MN.TabIndex = 3;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BorderRadius = 3;
            this.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FirstName.DefaultText = "";
            this.txt_FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FirstName.Location = new System.Drawing.Point(46, 235);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.PasswordChar = '\0';
            this.txt_FirstName.PlaceholderText = "";
            this.txt_FirstName.SelectedText = "";
            this.txt_FirstName.Size = new System.Drawing.Size(242, 41);
            this.txt_FirstName.TabIndex = 3;
            // 
            // txt_ID
            // 
            this.txt_ID.BorderRadius = 5;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.DefaultText = "";
            this.txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.Location = new System.Drawing.Point(46, 112);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.PlaceholderText = "";
            this.txt_ID.SelectedText = "";
            this.txt_ID.Size = new System.Drawing.Size(219, 41);
            this.txt_ID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(831, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course:";
            // 
            // txtCOURSE
            // 
            this.txtCOURSE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCOURSE.DefaultText = "";
            this.txtCOURSE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCOURSE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCOURSE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCOURSE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCOURSE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCOURSE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOURSE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCOURSE.Location = new System.Drawing.Point(898, 39);
            this.txtCOURSE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCOURSE.Name = "txtCOURSE";
            this.txtCOURSE.PasswordChar = '\0';
            this.txtCOURSE.PlaceholderText = "";
            this.txtCOURSE.SelectedText = "";
            this.txtCOURSE.Size = new System.Drawing.Size(137, 43);
            this.txtCOURSE.TabIndex = 3;
            this.txtCOURSE.Load += new System.EventHandler(this.guna2TextBox2_Load);
            // 
            // SystemAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 676);
            this.Controls.Add(this.txtCOURSE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemAttendance";
            this.Text = "QR Scan";
            this.Load += new System.EventHandler(this.SystemAttendance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanner)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentId;
        private Guna.UI2.WinForms.Guna2PictureBox pbScanner;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnViewRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtLN;
        private Guna.UI2.WinForms.Guna2TextBox txtMN;
        private Guna.UI2.WinForms.Guna2TextBox txtFN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_LN;
        private Guna.UI2.WinForms.Guna2TextBox txt_MN;
        private Guna.UI2.WinForms.Guna2TextBox txt_FirstName;
        private Guna.UI2.WinForms.Guna2TextBox txt_ID;
        private System.Windows.Forms.NumericUpDown numericYearLevel;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Sec;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2RadioButton rad_Male;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2RadioButton rad_Female;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Button btnEnterRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSection;
        private Guna.UI2.WinForms.Guna2TextBox txtYearLevel;
        private Guna.UI2.WinForms.Guna2TextBox txtProgram;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProg;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtCOURSE;
    }
}