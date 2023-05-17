using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace attendance_tracker
{
    public partial class TeacherSystemForm : Form
    {
        private string user;
        private string[] name;
        private int id;
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
            Debug.WriteLine(id);
        }

        public TeacherSystemForm(string user, string position, string[] name)
        {
            InitializeComponent();

            lblUser.Text = user;
            lblPosition.Text = position;
            this.user = user;
            this.name = name;

            string command = "SELECT teacher_tb.teacher_id \r\nFROM teacher_tb \r\nJOIN account_credentials_tb ON teacher_tb.school_id = account_credentials_tb.school_id \r\nWHERE account_credentials_tb.first_name = @fn AND account_credentials_tb.middle_name = @mn AND account_credentials_tb.last_name = @ln";
            MySqlParameter[] parameter = new MySqlParameter[] {
                new MySqlParameter("@fn", name[0]),
                new MySqlParameter("@mn", name[1]),
                new MySqlParameter("@ln", name[2])
            };
            DataTable table = Database.executeQuery(command, parameter);

            id = int.Parse(table.Rows[0]["teacher_id"].ToString());
            this.BackColor = ColorTranslator.FromHtml("#0F3744");

            //foreach(Guna.UI2.WinForms.Guna2Button button in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>)
            //{
            //    button.ForeColor = ColorTranslator.FromHtml("#0F3744");        
            //}
            //btnDashBoard.ForeColor = ColorTranslator.FromHtml("#0F3744");
            btnAttendance.ForeColor = ColorTranslator.FromHtml("#0F3744");
            btnReport.ForeColor = ColorTranslator.FromHtml("#0F3744");
            btnManageStudent.ForeColor = ColorTranslator.FromHtml("#0F3744");
            btnManageClass.ForeColor = ColorTranslator.FromHtml("#0F3744");
            guna2Button1.ForeColor = ColorTranslator.FromHtml("#0F3744");

            foreach (Guna2Button button in this.Controls.OfType<Guna2Button>())
            {
                button.MouseEnter += (sender, e) => btnEnter(button);
                button.MouseLeave += (sender, e) => btnLeave(button);
            }
        }
        private void SystemForm_Load(object sender, EventArgs e)
        { 
            timer1.Interval = 1000; // Update every 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
            InitializeControl(new SystemAttendance(panelFeature, id), panelFeature);
            //InitializeControl(new SystemDashBoard(id), panelFeature);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy h:mm tt");
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            InitializeControl(new SystemAttendance(panelFeature, id), panelFeature);
        }

        private void btnManageClass_Click(object sender, EventArgs e)
        {
            InitializeControl(new SystemManageClass(user, name, id, panelFeature), panelFeature);
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            InitializeControl(new SystemManageStudent(id, panelFeature), panelFeature);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            InitializeControl(new SystemReport(id), panelFeature);
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

        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {

        }
    }
}
