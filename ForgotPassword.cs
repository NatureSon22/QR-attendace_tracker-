using MimeKit;
using MySql.Data.MySqlClient;
using qrTry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class ForgotPassword : Form
    {
        Form form;
        public ForgotPassword(Form form)
        {
            InitializeComponent();
            this.form = form;
            this.BackColor = ColorTranslator.FromHtml("#0F3744");
            textBox1.BackColor = ColorTranslator.FromHtml("#0F3744");
            guna2Button1.ForeColor = ColorTranslator.FromHtml("#0F3744");
            guna2CircleButton1.ForeColor = ColorTranslator.FromHtml("#0F3744");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Opacity = 1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM account_credentials_tb WHERE school_id = @id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", txtSchoolID.Text)});
            string password = string.Empty;

            if(table.Rows.Count < 0)
            {
                MessageBox.Show("Account does not exist!", "STATUS");
                return;
            }

            string id = table.Rows[0]["school_id"].ToString();

            string userID = txtSchoolID.Text;
            string email = txtEmail.Text;
            string pattern = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            bool isValid = Regex.IsMatch(email, pattern);
            Debug.WriteLine(string.IsNullOrEmpty(email) + " " + isValid);
            if (string.IsNullOrEmpty(email) || !isValid)
            {
                MessageBox.Show("Please provide a valid email!", "STATUS");
                return;
            }

            command = "SELECT password FROM account_credentials_tb WHERE school_id = @id ";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", userID)});

            if(table.Rows.Count < 0)
            {
                MessageBox.Show("The system fails to search for any matching record on the ID", "STATUS");
                return;
            }
            password = table.Rows[0]["password"].ToString();

            sendToEmail(txtEmail.Text, password);
            MessageBox.Show("Check your email for the passowrd", "STATUS");
            this.Hide();
            form.Opacity = 1;
        }

        public string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-[]{}|;:,.<>?";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void sendToEmail(string email, string password)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var message = new MimeMessage();
                var builder = new BodyBuilder();
                message.From.Add(new MailboxAddress("Attendance Tracker System", "ATS_finals@gmail.com"));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = "User Password";

                builder.HtmlBody = $"<p>Your previous password is {password}</p>";
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




