using qrTry;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MimeKit;
using System.Drawing.Imaging;
using System.IO;

namespace attendance_tracker
{
    public partial class StudentGenerateQR : Form
    {
        private ArrayList courseList = new ArrayList();
        private string id;
        string[] student_info = new string[9];
        public StudentGenerateQR(string id)
        {
            InitializeComponent();
            this.id = id;

            string command = "SELECT student_tb.school_id, account_credentials_tb.first_name, account_credentials_tb.middle_name, account_credentials_tb.last_name, student_tb.gender, student_tb.program, student_tb.year_level, student_tb.section\r\nFROM student_tb \r\nJOIN account_credentials_tb ON student_tb.school_id = account_credentials_tb.school_id\r\nWHERE student_tb.school_id = @id";
            DataTable dataTable = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id)});
            setInfo(dataTable);
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            textBox1.BackColor = ColorTranslator.FromHtml("#A7CDDA");
        }

        private void setInfo(DataTable table)
        {
            txtSchoolID.Text = table.Rows[0]["school_id"].ToString();
            txtFN.Text = table.Rows[0]["first_name"].ToString();
            txtMN.Text = table.Rows[0]["middle_name"].ToString();
            txtLN.Text = table.Rows[0]["last_name"].ToString();
            if(table.Rows[0]["gender"].ToString() == "Male")
            {
                radMale.Checked = true;
            } else
            {
                radFemale.Checked = true;
            }
            cmbProgram.Text = table.Rows[0]["program"].ToString();
            //numericYearLevel.Value = int.Parse(table.Rows[0]["program"].ToString());
            txtSection.Text = table.Rows[0]["section"].ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            student_info[0] = txtSchoolID.Text;
            student_info[1] = txtFN.Text;
            student_info[2] = txtMN.Text;
            student_info[3] = txtLN.Text;
            student_info[4] = radMale.Checked ? radMale.Text : radFemale.Text;
            student_info[5] = cmbProgram.Text;
            student_info[6] = numericYearLevel.Value.ToString();
            student_info[7] = txtSection.Text;
            student_info[8] = string.Join("|", (string[])courseList.ToArray(typeof(string)));

            string student_information = string.Join(Environment.NewLine, student_info);
            if(student_info.Any(info => string.IsNullOrEmpty(info)) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields", "STATUS");
                return;
            }

            QrGenerator.generateQR(student_information);
            QrGenerator.sendQrToEmail(txtEmail.Text);
            DialogResult dialogResult = MessageBox.Show("Check your email for the qr code", "STATUS");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!courseList.Contains(cmbCourse.Text))
            {
                courseList.Add(cmbCourse.Text);
            } else
            {
                MessageBox.Show("Class is already added", "STATUS");
                return;
            }

        }
    }
}
