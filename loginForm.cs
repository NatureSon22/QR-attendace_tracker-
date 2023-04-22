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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar= true;
            Database.setUpConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createAccountForm createAccountForm = new createAccountForm();
            createAccountForm.Show();
            this.Hide();
        }

        private void pbRevealPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = txtPassword.UseSystemPasswordChar ? false : true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            const string command = "SELECT * FROM account_credentials_tb WHERE school_id = @id AND password = @pass";
            MySqlParameter[] parameters = new MySqlParameter [] {
                new MySqlParameter("@id", txtSchoolID.Text),
                new MySqlParameter("@pass", txtPassword.Text)
            };
            DataTable dataTable = Database.executeQuery(command, parameters);
            if(dataTable.Rows.Count > 0)
            {
                string[] name = new string[3];
                name[0] = dataTable.Rows[0]["first_name"].ToString();
                name[1] = dataTable.Rows[0]["middle_name"].ToString();
                name[2] = dataTable.Rows[0]["last_name"].ToString();

                string username = $"{name[0]} {name[1].Substring(0, 1)}. {name[2]}";
                string position = dataTable.Rows[0]["school_position"].ToString();
                 

                if(position == "Student")
                {

                } else
                {
                    TeacherSystemForm form = new TeacherSystemForm(username, position, name);
                    form.Show();
                    this.Hide();
                }
            } else
            {
                MessageBox.Show("Account does not exist!", "STATUS");
            }
        }
    }
}
