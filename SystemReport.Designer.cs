namespace attendance_tracker
{
    partial class SystemReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSchoolYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dataTableStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.numericYearLevel = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProgram = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BorderRadius = 5;
            this.txtSchoolYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSchoolYear.DefaultText = "";
            this.txtSchoolYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSchoolYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSchoolYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSchoolYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSchoolYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSchoolYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSchoolYear.Location = new System.Drawing.Point(870, 32);
            this.txtSchoolYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.PasswordChar = '\0';
            this.txtSchoolYear.PlaceholderText = "";
            this.txtSchoolYear.SelectedText = "";
            this.txtSchoolYear.Size = new System.Drawing.Size(158, 38);
            this.txtSchoolYear.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(765, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "School Year:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(893, 598);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(135, 45);
            this.guna2Button3.TabIndex = 37;
            this.guna2Button3.Text = "GENERATE";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::attendance_tracker.Properties.Resources.excel;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(825, 598);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(63, 45);
            this.guna2Button1.TabIndex = 36;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::attendance_tracker.Properties.Resources.calendar1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(96, 603);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 34;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Checked = true;
            this.dpEndDate.FillColor = System.Drawing.Color.Cyan;
            this.dpEndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpEndDate.Location = new System.Drawing.Point(361, 605);
            this.dpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(200, 36);
            this.dpEndDate.TabIndex = 32;
            this.dpEndDate.Value = new System.DateTime(2023, 4, 27, 2, 46, 0, 460);
            // 
            // dpStartDate
            // 
            this.dpStartDate.Checked = true;
            this.dpStartDate.FillColor = System.Drawing.Color.Cyan;
            this.dpStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpStartDate.Location = new System.Drawing.Point(149, 605);
            this.dpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(200, 36);
            this.dpStartDate.TabIndex = 33;
            this.dpStartDate.Value = new System.DateTime(2023, 4, 27, 2, 46, 0, 460);
            // 
            // dataTableStudent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataTableStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTableStudent.ColumnHeadersHeight = 20;
            this.dataTableStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableStudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataTableStudent.Location = new System.Drawing.Point(51, 195);
            this.dataTableStudent.Name = "dataTableStudent";
            this.dataTableStudent.RowHeadersVisible = false;
            this.dataTableStudent.Size = new System.Drawing.Size(978, 376);
            this.dataTableStudent.TabIndex = 31;
            this.dataTableStudent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dataTableStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dataTableStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTableStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTableStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTableStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTableStudent.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTableStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dataTableStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dataTableStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTableStudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTableStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTableStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTableStudent.ThemeStyle.HeaderStyle.Height = 20;
            this.dataTableStudent.ThemeStyle.ReadOnly = false;
            this.dataTableStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dataTableStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTableStudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTableStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataTableStudent.ThemeStyle.RowsStyle.Height = 22;
            this.dataTableStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dataTableStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 3;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::attendance_tracker.Properties.Resources.magnifying_glass;
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(848, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 45);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // numericYearLevel
            // 
            this.numericYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.numericYearLevel.BorderRadius = 5;
            this.numericYearLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericYearLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYearLevel.Location = new System.Drawing.Point(573, 133);
            this.numericYearLevel.Name = "numericYearLevel";
            this.numericYearLevel.Size = new System.Drawing.Size(100, 36);
            this.numericYearLevel.TabIndex = 29;
            this.numericYearLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbCourse
            // 
            this.cmbCourse.BackColor = System.Drawing.Color.Transparent;
            this.cmbCourse.BorderRadius = 5;
            this.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCourse.ItemHeight = 30;
            this.cmbCourse.Items.AddRange(new object[] {
            "Filipino 2 (PHPP)",
            "GE ELEC 1 (ES)",
            "HUM 1",
            "IT 1",
            "IT 2 (IHCI)",
            "ITE 5",
            "NSTP 2 (NSTP)",
            "PE 2",
            "Sci, Tech & Society"});
            this.cmbCourse.Location = new System.Drawing.Point(343, 133);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(200, 36);
            this.cmbCourse.TabIndex = 27;
            // 
            // cmbSection
            // 
            this.cmbSection.BackColor = System.Drawing.Color.Transparent;
            this.cmbSection.BorderRadius = 5;
            this.cmbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSection.ItemHeight = 30;
            this.cmbSection.Location = new System.Drawing.Point(699, 133);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(114, 36);
            this.cmbSection.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Program:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Course:";
            // 
            // cmbProgram
            // 
            this.cmbProgram.BackColor = System.Drawing.Color.Transparent;
            this.cmbProgram.BorderRadius = 5;
            this.cmbProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProgram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProgram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProgram.ItemHeight = 30;
            this.cmbProgram.Items.AddRange(new object[] {
            "BSBA",
            "BSOA",
            "BSA",
            "BSIT",
            "BSIS"});
            this.cmbProgram.Location = new System.Drawing.Point(113, 133);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(200, 36);
            this.cmbProgram.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Year Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(696, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Section:";
            // 
            // SystemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 676);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.dataTableStudent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.numericYearLevel);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProgram);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSchoolYear);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemReport";
            this.Text = "SystemReport";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSchoolYear;
        private System.Windows.Forms.Label label10;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpStartDate;
        private Guna.UI2.WinForms.Guna2DataGridView dataTableStudent;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericYearLevel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCourse;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProgram;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}