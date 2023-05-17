using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class StudentReport : Form
    {
        private string id;
        public StudentReport(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void showDatable(string command, params MySqlParameter[] parameters)
        {
            DataTable table = Database.executeQuery(command, parameters);

            if(table.Rows.Count == 0)
            {
                MessageBox.Show("The system fails to find any results for your search. Please try again with different search criteria.", "STATUS");
                return;
            }
            dataTableStudent.DataSource = table;
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            //string command = "SELECT course_tb.course_code, course_tb.course_description, attendance_tb.arrival_date, attendance_tb.arrival_time, attendance_tb.attendance_status\r\nFROM attendance_tb\r\n  JOIN enrollment_tb ON attendance_tb.enrollment_id = enrollment_tb.enrollment_id\r\n  JOIN course_class_tb ON enrollment_tb.class_id = course_class_tb.class_id\r\n  JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n  JOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id   \r\n  JOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\nWHERE \r\n  course_tb.course_code = @code AND\r\n  student_tb.student_id = @id"; //AND\r\n  attendance_tb.arrival_date BETWEEN @start_date AND @end_date;\r\n";
            //MySqlParameter[] parameters = new MySqlParameter[] { 
            //    new MySqlParameter("@code", cmbCourse.Text),
            //    new MySqlParameter("@id", id),
            //};
            //this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            //showDatable(command, parameters);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string command = "SELECT course_tb.course_code, course_tb.course_description, attendance_tb.arrival_date, attendance_tb.arrival_time, attendance_tb.attendance_status\r\nFROM attendance_tb\r\n  JOIN enrollment_tb ON attendance_tb.enrollment_id = enrollment_tb.enrollment_id\r\n  JOIN course_class_tb ON enrollment_tb.class_id = course_class_tb.class_id\r\n  JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n  JOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id   \r\n  JOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\nWHERE \r\n  course_tb.course_code = @code AND\r\n  student_tb.school_id = @id AND\r\n  attendance_tb.arrival_date BETWEEN @start_date AND @end_date;\r\n";
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@code", cmbCourse.Text),
                new MySqlParameter("@id", id),
                new MySqlParameter("@start_date", dpStartDate.Value.ToString("yyyy-MM-dd")),
                new MySqlParameter("@end_date", dpEndDate.Value.ToString("yyyy-MM-dd"))
            };
            Debug.WriteLine(cmbCourse.Text + " " + id + " " + dpStartDate.Value.ToString("yyyy-MM-dd") + " " + dpEndDate.Value.ToString("yyyy-MM-dd"));
            showDatable(command, parameters);
        }
    }
}
