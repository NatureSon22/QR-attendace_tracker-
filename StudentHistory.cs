using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace attendance_tracker
{
    public partial class StudentHistory : Form
    {
        private Form form;
        private Panel panel;
        private string[] info;
        public StudentHistory(Form form, Panel panel)
        {
            InitializeComponent();
            this.form = form;
            this.panel = panel;
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
        }

        private void StudentHistory_Load(object sender, EventArgs e)
        {
            showDatable();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

        private void dtStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            info = new string[dtStudent.Columns.Count];

            for(int i = 0; i < info.Length; i++)
            {
                info[i] = dtStudent.Rows[row].Cells[i].Value.ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(info[0]);
            int classId = int.Parse(info[9]);
            string command = "INSERT INTO enrollment_tb(student_id, class_id) VALUES(@student_id, @class_id)";
            Database.query(command, new MySqlParameter[] { new MySqlParameter("@student_id", studentId), new MySqlParameter("@class_id", classId) });
            MessageBox.Show("Data restored successfully!", "STATUS");

            command = "DELETE FROM deleted_student_tb WHERE student_id = @student_id AND class_id = @class_id";
            Database.query(command, new MySqlParameter[] { new MySqlParameter("@student_id", studentId), new MySqlParameter("@class_id", classId) });
            showDatable();
        }

        private void showDatable()
        {
            string command = "SELECT student_id, school_id, first_name, middle_name, last_name, program, year_level, section, gender, class_id FROM deleted_student_tb";
            DataTable table = Database.executeQuery(command);
            dtStudent.DataSource = table;
        }
    }
}
