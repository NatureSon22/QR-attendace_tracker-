using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace attendance_tracker
{
    public partial class SystemReport : Form
    {
        private DataTable reportTable; 
        public SystemReport(int id)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            string command = "SELECT DISTINCT(course_code) FROM course_assignment_tb \r\n JOIn course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\n WHERE course_assignment_tb.teacher_id = @id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id) });
            string[] teacher_course = new string[table.Rows.Count];

            for (int x = 0; x < table.Rows.Count; x++)
            {
                teacher_course[x] = table.Rows[x]["course_code"].ToString();
            }
            cmbCourse.DataSource = teacher_course;

            command = "SELECT DISTINCT(section) \r\nFROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nWHERE course_assignment_tb.teacher_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id) });
            string[] teacher_section = new string[table.Rows.Count];

            for (int x = 0; x < table.Rows.Count; x++)
            {
                teacher_section[x] = table.Rows[x]["section"].ToString();
            }

            cmbSection.DataSource = teacher_section;

            command = "SELECT DISTINCT(program) FROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nWHERE course_assignment_tb.teacher_id = @id";
            table = Database.executeQuery(command, new MySqlParameter("@id", id));
            string[] teacher_program = new string[table.Rows.Count];

            for (int x = 0; x < table.Rows.Count; x++)
            {
                teacher_program[x] = table.Rows[x]["program"].ToString();
            }
            cmbProgram.DataSource = teacher_program;

            command = "SELECT start_school_year, end_school_year FROM school_year_tb WHERE school_year_id = 1";
            table = Database.executeQuery(command);

            string start = table.Rows[0]["start_school_year"].ToString().Substring(6, 5);
            string end = table.Rows[0]["end_school_year"].ToString().Substring(6, 5);
            string school_year = $"{start}-{end}";
            txtSchoolYear.Text = school_year;


            dpStartDate.Format = DateTimePickerFormat.Custom;
            dpStartDate.CustomFormat = "yyyy-MM-dd";
            dpEndDate.Format = DateTimePickerFormat.Custom;
            dpEndDate.CustomFormat = "yyyy-MM-dd";
        }

        private void numericYearLevel_ValueChanged(object sender, EventArgs e)
        {
            if(numericYearLevel.Value > 1)
            {
                numericYearLevel.Value = 1;
            } else if(numericYearLevel.Value < 4)
            {
                numericYearLevel.Value = 4;
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string command = "\r\nSELECT class_id \r\nFROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id \r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE course_class_tb.program = @prog AND course_tb.course_code =  @code AND course_class_tb.year_level = @lev AND course_class_tb.section = @sec";
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@prog", cmbProgram.Text),
                new MySqlParameter("@code", cmbCourse.Text),
                new MySqlParameter("@lev", numericYearLevel.Value.ToString()),
                new MySqlParameter("@sec", cmbSection.Text)
            };
            DataTable table = Database.executeQuery(command, parameters);
            string class_id = string.Empty;

            if (table.Rows.Count > 0)
            {
                class_id = table.Rows[0]["class_id"].ToString();
            } else
            {
                MessageBox.Show("The system fails to find any matching records!", "STATUS");
                return;
            }
            Debug.WriteLine(class_id);

            command = "SELECT \r\n  account_credentials_tb.school_id,\r\n  account_credentials_tb.first_name, \r\n  account_credentials_tb.last_name, \r\n  COUNT(CASE WHEN attendance_tb.attendance_status = 'PRESENT' THEN 1 END) AS present_count, \r\n  COUNT(CASE WHEN attendance_tb.attendance_status = 'LATE' THEN 1 END) AS late_count, \r\n  COUNT(CASE WHEN attendance_tb.attendance_status = 'ABSENT' THEN 1 END) AS absent_count\r\nFROM enrollment_tb\r\nJOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\nJOIN account_credentials_tb ON student_tb.school_id = account_credentials_tb.school_id\r\nJOIN attendance_tb ON enrollment_tb.enrollment_id = attendance_tb.enrollment_id\r\nWHERE enrollment_tb.class_id = @id AND attendance_tb.arrival_date BETWEEN @startdate AND @enddate\r\nGROUP BY account_credentials_tb.school_id, account_credentials_tb.first_name, account_credentials_tb.last_name;";
            parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", class_id),
                new MySqlParameter("@startdate", dpStartDate.Value.ToString("yyyy-MM-dd")),
                new MySqlParameter("@enddate", dpEndDate.Value.ToString("yyyy-MM-dd"))
            };
            table = Database.executeQuery(command, parameters);
            dataTableStudent.DataSource = table;

            reportTable = table;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(reportTable == null)
            {
                MessageBox.Show("Choose a record to be generated", "STATUS");
                return;
            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string filePath = @"C:\Users\ACER\Desktop\Finals\attendance.xlsx";
            FileInfo file = new FileInfo(filePath);
            if (file.Exists)
            {
                file.Delete();
            }
            using (ExcelPackage package = new ExcelPackage(file))
            {
               
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Attendance");
                worksheet.Cells["A1"].LoadFromDataTable(reportTable, true);
                package.Save();
            }
            MessageBox.Show("Report is generated successfully!", "STATUS");
        }
    }
}
