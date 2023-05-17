using Guna.UI2.WinForms;
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
    public partial class StudentSystemForm : Form
    {
        private string[] name;
        private string position;
        private string username;
        private string id;

        private void InitializeControl<TPanel>(Object Form, TPanel panel)
          where TPanel : System.Windows.Forms.Panel
        {
            Form form = (Form)Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            panel.Controls.Add(form);
            form.Show();

            foreach(Guna2Button button in this.Controls.OfType<Guna2Button>())
            {
                button.ForeColor = ColorTranslator.FromHtml("#0F3744");
                button.MouseEnter += (sender, e) => btnEnter(button);
                button.MouseLeave += (sender, e) => btnLeave(button);
            }
        }

        public StudentSystemForm(string username, string position, string[] name, string id)
        {
            InitializeComponent();
            this.username = username;
            this.position = position;
            this.name = name;
            this.id = id;
            this.BackColor = ColorTranslator.FromHtml("#0F3744");
            Debug.WriteLine(id);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void StudentSystemForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = username;
            lblPosition.Text = position;
            timer1.Interval = 1000; // Update every 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
            InitializeControl(new StudentReport(id), panelFeature);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy h:mm tt");
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            InitializeControl(new StudentDashBoard(), panelFeature);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            InitializeControl(new StudentReport(id), panelFeature);
        }

        private void btnGenerateQr_Click(object sender, EventArgs e)
        {
            InitializeControl(new StudentGenerateQR(id), panelFeature);
        }

        private void btnEnter(Guna2Button button)
        {
            button.FillColor = ColorTranslator.FromHtml("#D09B0A");
            button.Cursor = Cursors.Hand;
        }

        private void btnLeave(Guna2Button button)
        {
            button.FillColor = Color.FromArgb(94, 148, 255);
            button.Cursor = Cursors.Default;
        }
    }
}
