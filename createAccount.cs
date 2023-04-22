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
using System.Windows.Markup;

namespace attendance_tracker
{
    public partial class createAccount : Form
    {
        private bool isClicked = false;
        public createAccount()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.Text = GenerateRandomPassword(15);
        }

        public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-[]{}|;:,.<>?";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void pbRevealPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] values = { txtSchoolID.Text, cmbSchoolPosition.Text, txtFN.Text, txtMN.Text, txtLN.Text, txtPassword.Text};
            Debug.WriteLine(string.Join(", ", values));

            if (values.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Please fill in all required fields before submitting your form. Thank you for your cooperation.", "STATUS");
                return;
            }

            if (txtPassword.Text.Length < 8) {
                MessageBox.Show("Your password must be at least 8 characters long. Please choose a longer password for better security.", "STATUS");
                return;
            }

            string command = "INSERT INTO account_credentials_tb(school_id, school_position, first_name, middle_name, last_name, password) VALUES (@id, @pos, @fn, @mn, @ln, @pass)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@id", values[0]),
                new MySqlParameter("@pos", values[1]),
                new MySqlParameter("@fn", values[2]),
                new MySqlParameter("@mn", values[3]),
                new MySqlParameter("@ln", values[4]),
                new MySqlParameter("@pass", values[5])
             };

            try
            {
                Database.query(command, parameters);
                MessageBox.Show("Account created successfully!", "STATUS");
                command = "INSERT INTO teacher_tb(school_id) VALUE(@id)";
                Database.query(command, new MySqlParameter[] { new MySqlParameter("@id", values[0]) });
            } catch (MySqlException)
            {
                MessageBox.Show("Account already exist!");
            }
        }
    }
}
