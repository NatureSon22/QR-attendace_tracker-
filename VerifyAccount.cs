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
    public partial class VerifyAccount : Form
    {
        private Form form;
        private string[] values;
        private string code;
        public VerifyAccount(Form form, string[] values, string code)
        {
            InitializeComponent();
            this.form = form;
            this.values = values;
            form.Opacity = 0.5;  
            this.code = code;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string command = "SELECT reference_id FROM ref_tb WHERE school_id = @id AND first_name = @fn AND middle_name = @mn AND last_name = @ln";
            MySqlParameter[] parameters = new MySqlParameter[] { 
                new MySqlParameter("@id", values[0]),
                new MySqlParameter("@fn", values[2]),
                new MySqlParameter("@mn", values[3]),
                new MySqlParameter("@ln", values[4])
            };
            DataTable table = Database.executeQuery2(command, parameters);
            string ref_id = table.Rows[0]["reference_id"].ToString();

            Debug.WriteLine(values[0]);

            try
            {
                command = "INSERT INTO verification_tb(reference_id, code) VALUES(@id, @code)";
                parameters = new MySqlParameter[] {
                    new MySqlParameter("@id", ref_id),
                    new MySqlParameter("@code", code)
                };

                Database.query2(command, parameters);
            }
            catch (MySqlException)
            {
                MessageBox.Show(ref_id);
            }
            //insertion point
            command = "INSERT INTO account_credentials_tb(school_id, school_position, first_name, middle_name, last_name, password) VALUES (@id, @pos, @fn, @mn, @ln, @pass)";
            parameters = new MySqlParameter []{
                new MySqlParameter("@id", values[0]),
                new MySqlParameter("@pos", values[1]),
                new MySqlParameter("@fn", values[2]),
                new MySqlParameter("@mn", values[3]),
                new MySqlParameter("@ln", values[4]),
                new MySqlParameter("@pass", values[5])
            };

            Database.query(command, parameters);
            MessageBox.Show("Account created successfully!", "STATUS");
            if (values[1] == "Professor/Instructor")
            {
                command = "INSERT INTO teacher_tb(school_id) VALUE(@id)";
            }
            else if (values[1] == "Student")
            {
                command = "INSERT INTO student_tb(school_id) VALUE(@id)";
            }
            Database.query(command, new MySqlParameter[] { new MySqlParameter("@id", values[0]) });

            //another form
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }
    }
}
