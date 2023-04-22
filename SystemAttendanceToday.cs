using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class SystemAttendanceToday : Form
    {
        private Form form;
        private Panel panel;
        public SystemAttendanceToday(Form form, Panel panel)
        {
            InitializeComponent();
            this.form = form;
            this.panel = panel;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            panel.Controls.Add(form);
            form.Show();
        }

        private void SystemAttendanceToday_Load(object sender, EventArgs e)
        {

        }
    }
}
