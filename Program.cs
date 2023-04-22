using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] name = { "Jio", "Tullin", "Banta" };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TeacherSystemForm("Jio T. Banta", "Professor/Instructor", name));
            Application.Run(new loginForm());
        }
    }
}
