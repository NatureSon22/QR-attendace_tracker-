using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class ClassHistory : Form
    {
        private Form form;
        Panel panel;
        private string[] info;
        public ClassHistory(Form form, Panel panel)
        {
            InitializeComponent();
            this.form = form;
            this.panel = panel;
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
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

        private void ClassHistory_Load(object sender, EventArgs e)
        {
            showDataTable();   
        }

        private void showDataTable()
        {
            string command = "SELECT class_id, program, year_level, section, course_assignment_id, class_count_male, class_count_female, class_time_start, class_time_end FROM deleted_course_class_tb";
            DataTable table = Database.executeQuery(command);
            dtClass.DataSource = table;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(info == null)
            {
                MessageBox.Show("Please select a valid cell to be restored", "STATUS");
                return;
            }

            string command = "INSERT INTO course_class_tb (class_id, school_year_id, program, year_level, section, course_assignment_id, class_count_male, class_count_female, class_time_start, class_time_end) VALUES (@id, @year, @prog, @lev, @sec, @cid, @cmale, @cfemale, @start, @end)";
            MySqlParameter[] parameter = new MySqlParameter[] {
                //@id, @prog, @lev, @sec, @cid, @cmale, @cfemale, @start, @end
                new MySqlParameter("@id", info[0]),
                new MySqlParameter("@year", 1),
                new MySqlParameter("@prog", info[1]),
                new MySqlParameter("@lev", info[2]),
                new MySqlParameter("@sec", info[3]),
                new MySqlParameter("@cid", info[4]),
                new MySqlParameter("@cmale", info[5]),
                new MySqlParameter("@cfemale", info[6]),
                new MySqlParameter("@start", info[7]),
                new MySqlParameter("@end", info[8])
            };
            Database.query(command, parameter);

            
            command = "";

            command = "DELETE FROM deleted_course_class_tb WHERE program = @prog AND year_level = @lev AND section = @sec AND course_assignment_id = @id";
            parameter = new MySqlParameter[]
            {
                new MySqlParameter("@prog", info[1]),
                new MySqlParameter("@lev", info[2]),
                new MySqlParameter("@sec", info[3]),
                new MySqlParameter("@id", info[4]),
            };

            Database.query(command, parameter);
            MessageBox.Show("Restored successfully!", "STATUS");
            showDataTable();
        }

        private void dtClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            info = new string[dtClass.Columns.Count];

            for(int i = 0; i < info.Length; i++)
            {
                info[i] = dtClass.Rows[row].Cells[i].Value.ToString(); 
            }
        }
    }
}
