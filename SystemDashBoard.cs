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
    public partial class SystemDashBoard : Form
    {
        private int id;
        public SystemDashBoard(int id)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            this.id = id;
            Debug.WriteLine(id);
        }

        private void SystemDashBoard_Load(object sender, EventArgs e)
        {
            string command = "SELECT DISTINCT(course_code) FROM course_assignment_tb \r\n JOIn course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\n WHERE course_assignment_tb.teacher_id = @id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id) });
            string[] teacher_course = new string[table.Rows.Count];

            for (int x = 0; x < table.Rows.Count; x++)
            {
                teacher_course[x] = table.Rows[x]["course_code"].ToString();
            }
            cmbCourse.DataSource = teacher_course;


            command = "SELECT DISTINCT(program) FROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE teacher_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id) });
            string[] teacher_program = new string[table.Rows.Count];

            for(int x = 0; x < teacher_program.Length; x++)
            {
                teacher_program[x] = table.Rows[x]["program"].ToString();
            }
            cmbProgram.DataSource = teacher_program;

            command = "SELECT DISTINCT(section) FROM course_class_tb";
            // search for optimized version
            table = Database.executeQuery(command);
            int i = table.Rows.Count;
            string[] value = new string[i];

            for (int x = 0; x < i; x++)
            {
                value[x] = table.Rows[x]["section"].ToString();
            }
            cmbYear.DataSource = value;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
