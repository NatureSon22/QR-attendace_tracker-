using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class SystemAttendanceToday : Form
    {
        private Form form;
        private Panel panel;
        private string[] currentClass;
        private string[] attendance;
        public SystemAttendanceToday(Form form, Panel panel, string[] currentClass)
        {
            InitializeComponent();
            this.form = form;
            this.panel = panel;
            this.currentClass = (string[])currentClass.Clone();
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            panel.Controls.Add(form);
            form.Show();
        }

        private void SystemAttendanceToday_Load(object sender, EventArgs e)
        {
            txt_Course.Text = currentClass[1];
            showDataTable();
        }

        private void dtAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            attendance = new string[dtAttendance.Columns.Count];
            for(int i  = 0; i < attendance.Length; i++)
            {
                attendance[i] = dtAttendance.Rows[row].Cells[i].Value.ToString();
            }
            DateTime arrivalDate = DateTime.ParseExact(attendance[5].Substring(0, 10).Replace("/", "-"), "dd-MM-yyyy", CultureInfo.InvariantCulture);



            txtSchoolID.Text = attendance[0];
            txtFN.Text= attendance[1];
            txtMN.Text= attendance[2];
            txtLN.Text= attendance[3];
            cmbStatus.Text= attendance[4];
            txtDate.Text = arrivalDate.ToString("yyyy-MM-dd");
            txtTime.Text= attendance[6];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(attendance == null)
            {
                MessageBox.Show("PLease select a valid cell", "STATUS");
                return;
            } else
            {
                string command = "UPDATE attendance_tb\r\nJOIN enrollment_tb ON attendance_tb.enrollment_id = enrollment_tb.enrollment_id\r\nJOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\nJOIN account_credentials_tb ON student_tb.school_id = account_credentials_tb.school_id\r\nSET attendance_status = @status\r\nWHERE \r\n\taccount_credentials_tb.school_id = @prog AND\r\n    attendance_tb.arrival_date = @date";
                Database.query(command, new MySqlParameter[] { new MySqlParameter("@prog", txtSchoolID.Text), new MySqlParameter("@date", txtDate.Text), new MySqlParameter("@status", cmbStatus.Text)});

                MessageBox.Show("Record is updated successfully!", "STATUS");
                showDataTable();
            }
        }

        private void showDataTable()
        {
            string command = "SELECT \r\n\taccount_credentials_tb.school_id, \r\n\taccount_credentials_tb.first_name, \r\n\taccount_credentials_tb.middle_name, \r\n\taccount_credentials_tb.last_name,\r\n      attendance_tb.attendance_status,\r\n      attendance_tb.arrival_date,\r\n      attendance_tb.arrival_time \r\nFROM  attendance_tb\r\nJOIN enrollment_tb ON attendance_tb.enrollment_id = enrollment_tb.enrollment_id\r\nJOIN course_class_tb ON  enrollment_tb.class_id = course_class_tb.class_id\r\nJOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\nJOIN course_assignment_tb ON course_class_tb. course_assignment_id =  course_assignment_tb. course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id \r\nJOIN account_credentials_tb ON student_tb.school_id = account_credentials_tb.school_id\r\n      WHERE\r\n      course_class_tb.program = @prog AND \r\n      course_tb.course_code = @ccourse AND\r\n      course_class_tb.year_level = @lev AND\r\n      course_class_tb.section = @sec AND\r\n      attendance_tb.arrival_date = @date";
            MySqlParameter[] parameter = new MySqlParameter[] {
                new MySqlParameter("@prog", currentClass[0]),
                new MySqlParameter("@ccourse", currentClass[1]),
                new MySqlParameter("@lev", currentClass[2]),
                new MySqlParameter("@sec", currentClass[3]),
                new MySqlParameter("@date", currentClass[4])
            };
            DataTable table = Database.executeQuery(command, parameter);
            dtAttendance.DataSource = table;
        }
    }
}
