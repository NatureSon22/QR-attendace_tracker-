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
            this.BackColor = ColorTranslator.FromHtml("#00171F");
            textBox1.BackColor = ColorTranslator.FromHtml("#00171F");
            btnLogIn.ForeColor = ColorTranslator.FromHtml("#00171F");

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
                    string id = txtSchoolID.Text;
                    StudentSystemForm form = new StudentSystemForm(username, position, name, id);
                    form.Show();
                    this.Hide();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword form = new ForgotPassword(this);
            form.Show();
            this.Opacity= 0.3;
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.FillColor = ColorTranslator.FromHtml("#D09B0A");
            btnLogIn.Cursor = Cursors.Hand;
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.FillColor = Color.FromArgb(94, 148, 255);
            btnLogIn.Cursor = Cursors.Default;
        }
    }
}
