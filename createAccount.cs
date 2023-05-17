using MimeKit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace attendance_tracker
{
    public partial class createAccount : Form
    {
        
        public createAccount()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.BackColor = ColorTranslator.FromHtml("#0F3744");
            textBox1.BackColor = ColorTranslator.FromHtml("#0F3744");
            btnSubmit.BackColor = ColorTranslator.FromHtml("#0F3744");
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

            if (values.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("Please fill in all required fields before submitting your form. Thank you for your cooperation.", "STATUS");
                return;
            }

            if (txtPassword.Text.Length < 8) {
                MessageBox.Show("Your password must be at least 8 characters long. Please choose a longer password for better security.", "STATUS");
                return;
            }

            if (string.IsNullOrEmpty(cmbSchoolPosition.Text))
            {
                MessageBox.Show("Please select a school position before submitting your form. Thank you for your cooperation.", "STATUS");
                return;
            }

            //string command = "SELECT * FROM db_registrar.ref_tb WHERE school_id = @id";
            //DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", values[0])});

            //if(table.Rows.Count == 0)
            //{
            //    MessageBox.Show("Information is not recognized!");
            //    return;
            //}

            string command = "INSERT INTO account_credentials_tb(school_id, school_position, first_name, middle_name, last_name, password) VALUES (@id, @pos, @fn, @mn, @ln, @pass)";
            MySqlParameter[] parameters = new MySqlParameter[]{
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

            //// Generate a new verification code
            //string code = GenerateCode();

            //// Keep generating new codes until a unique one is found
            //while (true)
            //{
            //    command = "SELECT code FROM verification_tb JOIN ref_tb ON verification_tb.reference_id = ref_tb.reference_id  WHERE code = @code AND school_id = @id";
            //    //try
            //    //{
            //        MySqlParameter[] parameters = new MySqlParameter[] {
            //            new MySqlParameter("@code", code),
            //            new MySqlParameter("@id", values[0])
            //        };
            //        table = Database.executeQuery2(command, parameters);
            //    //}
            //    //catch {
            //        //MessageBox.Show(code + " " + values[0]);
            //    //};

            //    // If no rows are returned, the code is unique and can be used
            //    if (table.Rows.Count == 0)
            //    {
            //        break;
            //    }
            //    // Otherwise, generate a new code and try again
            //    else
            //    {
            //        code = GenerateCode();
            //    }
            //};


            //MessageBox.Show("You will receive a code via email", "STATUS");
            //sendToGmail(code, txtEmail.Text);
            //btnSubmit.Text = "VERIFY ACCOUNT";
            //VerifyAccount verify = new VerifyAccount(this, values, code);
            //verify.Show();
        }

        private string GenerateCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var code = new string(
                Enumerable.Repeat(chars, 10)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return code;
        }

        private void sendToGmail(string code, string email)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var message = new MimeMessage();
                var builder = new BodyBuilder();
                message.From.Add(new MailboxAddress("Attendance Tracker System", "ATS_finals@gmail.com"));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = "User Verification";

                builder.HtmlBody = $"<p>Verify your account with this code: <b>{code}</b></p>";
                message.Body = builder.ToMessageBody();

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("bantajio22@gmail.com", "fncgpqydhzmozhlx");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
        }
    }
}
