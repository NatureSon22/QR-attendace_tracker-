using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace attendance_tracker
{
    public partial class SystemManageClass : Form
    {
        private string user;
        private string[] name;
        private string[] cellValues;
        private int teacher_id;
        private System.Windows.Forms.Panel panel;
        public SystemManageClass(string user, string[] name, int id, System.Windows.Forms.Panel panel)
        {
            InitializeComponent();
            this.user = user;
            this.name = name;
            this.teacher_id = id;
            
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            this.panel = panel;
        }

        private void SystemManageClass_Load(object sender, EventArgs e)
        {
            setTime();
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);
            //tabControl3.SelectedIndexChanged += new EventHandler(tabControl2_SelectedIndexChanged);
        }

        //setting the time format for time picker
        private void setTime()
        {
            string school_year = string.Empty;
            string start = string.Empty;
            string end = string.Empty;
            string command = "SELECT start_school_year, end_school_year FROM school_year_tb WHERE school_year_id = 1";
            DataTable table = Database.executeQuery(command);

            start = table.Rows[0]["start_school_year"].ToString().Substring(6, 5);
            end = table.Rows[0]["end_school_year"].ToString().Substring(6, 5);

            school_year = $"{start}-{end}";
            txtSchoolYear.Text = school_year;


            timeStart.Format = DateTimePickerFormat.Custom;
            timeStart.CustomFormat = "hh:mm tt";
            timeEnd.Format = DateTimePickerFormat.Custom;
            timeEnd.CustomFormat = "hh:mm tt";

            timeUpdateStart.Format = DateTimePickerFormat.Custom;
            timeUpdateStart.CustomFormat = "hh:mm tt";
            timeUpdateEnd.Format = DateTimePickerFormat.Custom;
            timeUpdateEnd.CustomFormat = "hh:mm tt";

            timeRemoveStart.Format = DateTimePickerFormat.Custom;
            timeRemoveStart.CustomFormat = "hh:mm tt";
            timeRemoveEnd.Format = DateTimePickerFormat.Custom;
            timeRemoveEnd.CustomFormat = "hh:mm tt";
        }

        //adding class
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            int teacherID = 0;
            int courseID = cmbCourse.SelectedIndex + 1;
            string program = cmbProgram.SelectedItem.ToString();
            string schoolID = string.Empty;
            int yearLevel = (int)numericYearLevel.Value;
            int courseAssignmentID = 0;
            int maleCount = int.Parse(txtMaleCount.Text);
            int femaleCount = int.Parse(txtFemaleCount.Text);
            string startTime = timeStart.Value.ToString("HH:mm:ss");
            string endTime = timeEnd.Value.ToString("HH:mm:ss");
            int schoolyearID = 1;
            string section = txtSection.Text;
            Debug.WriteLine(program + "\n" + section + "\n" + yearLevel);

            // getting the school ID of the user
            string command = "SELECT school_id FROM account_credentials_tb WHERE first_name = @fn AND middle_name = @mn AND last_name = @ln";
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@fn", name[0]),
                new MySqlParameter("@mn", name[1]),
                new MySqlParameter("@ln", name[2])
            };

            DataTable table = Database.executeQuery(command, parameters);
            foreach (DataRow row in table.Rows)
            {
                schoolID = row["school_id"].ToString();
            }

            // getting the teacher ID of the user
            command = "SELECT teacher_id FROM teacher_tb WHERE school_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", schoolID) });
            //foreach (DataRow row in table.Rows)
            //{
            //    teacherID = int.Parse(row["teacher_id"].ToString());
            //}
            Debug.WriteLine(schoolID);
            teacherID = int.Parse(table.Rows[0]["teacher_id"].ToString());
            Debug.Write(teacherID);
            
            command = "SELECT course_class_tb.*\r\nFROM course_class_tb \r\nLEFT JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id \r\nWHERE course_assignment_tb.course_id = @courseid\r\nAND course_class_tb.program = @prog\r\nAND course_class_tb.year_level = @level\r\nAND course_class_tb.section = @section";
            parameters = new MySqlParameter[]
            {
                new MySqlParameter("@prog", program),
                new MySqlParameter("@level", yearLevel),
                new MySqlParameter("@section", section),
                new MySqlParameter("@courseid", courseID)
            };

            table = Database.executeQuery(command, parameters);
            int rowCheck = table.Rows.Count;

            Debug.WriteLine(rowCheck);

            if (rowCheck > 0) // check if any rows were returned
            {
                // loop through the rows and compare values
              
                MessageBox.Show("Class already exists", "STATUS");
                return;
            }

            //inserting assigned teacher on the course
            try
            {
                command = "INSERT INTO course_assignment_tb(teacher_id, course_id) VALUES (@teacher_id, @course_id)";
                parameters = new MySqlParameter[]
                {
                new MySqlParameter("@teacher_id", teacherID),
                new MySqlParameter("@course_id", courseID)
                };
                Database.query(command, parameters);
            } catch(Exception)
            {
                MessageBox.Show(teacherID + " " + courseID);
                return;
            }

            command = "SELECT course_assignment_id FROM course_assignment_tb WHERE teacher_id = @teacherID";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@teacherID", teacherID) });
            foreach (DataRow row in table.Rows)
            {
                courseAssignmentID = int.Parse(row["course_assignment_id"].ToString());
            }

            //addign the class on the course_class_tb
            command = "INSERT INTO course_class_tb(course_assignment_id, school_year_id, class_count_male, class_count_female, class_time_start, class_time_end, program, section, year_level) VALUES(@courseID, @yearID, @countMale, @countFemale, TIME(@start), TIME(@end), @prog, @sec, @level)";
            parameters = new MySqlParameter[] {
                new MySqlParameter("@courseID", courseAssignmentID),
                new MySqlParameter("@yearID", schoolyearID),
                new MySqlParameter("@countMale", maleCount),
                new MySqlParameter("@countFemale", femaleCount),
                new MySqlParameter("@start", startTime),
                new MySqlParameter("@end", endTime),
                new MySqlParameter("@prog", program),
                new MySqlParameter("@sec", section),
                new MySqlParameter("@level", yearLevel)
            };
            Database.query(command, parameters);

            MessageBox.Show("Class added successfully", "STATUS");
        }

        // sets the range for the numeric level to be only between (1 and 4) (inclusive)
        private void numericYearLevel_ValueChanged(object sender, EventArgs e)
        {
            if (numericYearLevel.Value < 1)
            {
                numericYearLevel.Value = 1;
            }
            else if (numericYearLevel.Value > 4)
            {
                numericYearLevel.Value = 4;
            }
        }

        //selecting the data in a row when a cell is clicked
        private void dataTableClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            cellValues = new string[dataTableClass.Columns.Count];

            for (int i = 0; i < dataTableClass.Columns.Count; i++)
            {
                cellValues[i] = dataTableClass.Rows[rowIndex].Cells[i].Value.ToString(); 
            }
        }

        //searching class
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table;
            string value = txtSearch.Text;
            int choice = cmbFilter.SelectedIndex;
            string selection = filter(choice);

            //selecting the command for the search query
            string where = string.Empty;
            string command;
            if (choice > 0)
            {
                where = $"{selection}";
                command = $"SELECT \r\n  course_class_tb.program, \r\n  course_class_tb.year_level, \r\n  course_class_tb.section, \r\n  course_tb.course_code, \r\n  course_tb.course_description, \r\n  course_class_tb.class_count_male, \r\n  course_class_tb.class_count_female, \r\n  course_class_tb.class_time_start, \r\n  course_class_tb.class_time_end\r\nFROM \r\n  course_class_tb\r\n  JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n  JOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id WHERE {where} AND teacher_id = @id";
                Debug.WriteLine(selection);
                table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@value", value), new MySqlParameter("@id", teacher_id) });
            }
            else
            {
                command = $"SELECT \r\n  course_class_tb.program, \r\n  course_class_tb.year_level, \r\n  course_class_tb.section, \r\n  course_tb.course_code, \r\n  course_tb.course_description, \r\n  course_class_tb.class_count_male, \r\n  course_class_tb.class_count_female, \r\n  course_class_tb.class_time_start, \r\n  course_class_tb.class_time_end\r\nFROM \r\n  course_class_tb\r\n  JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n  JOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE teacher_id = @id\r\n";
                table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", teacher_id) });
            }
            dataTableClass.DataSource = table;
        }

        //search filter
        private string filter(int choice)
        {
            string select = string.Empty;

            switch (choice)
            {
                case 1:
                    select = "program = @value";
                    break;
                case 2:
                    select = "course_assignment_id = @value";
                    break;
                case 3:
                    select = "year_level = @value";
                    break;
                case 4:
                    select = "section = @value";
                    break;
                case 5:
                    select = "school_year_id = @value";
                    break;
            }
            return select;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(tabControl1.SelectedIndex == 1)
            {
                loadSearch();
            }else if(tabControl1.SelectedIndex == 2)
            {
                loadUpdate();
            }else if(tabControl1.SelectedIndex == 3)
            {
                loadRemove();
            }
        }

        private void loadSearch()
        {
            cmbCourse.Text = "All";
            cmbCourse.SelectedIndex = 0;
            DataTable table;
            string value = txtSearch.Text;
            int choice = cmbFilter.SelectedIndex;
            string selection = filter(choice);

            //selecting the command for the search query
            string command = $"SELECT \r\n  course_class_tb.program, \r\n  course_class_tb.year_level, \r\n  course_class_tb.section, \r\n  course_tb.course_code, \r\n  course_tb.course_description, \r\n  course_class_tb.class_count_male, \r\n  course_class_tb.class_count_female, \r\n  course_class_tb.class_time_start, \r\n  course_class_tb.class_time_end\r\nFROM \r\n  course_class_tb\r\n  JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n  JOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE teacher_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", teacher_id) });
            dataTableClass.DataSource = table;
        }

        private bool isNull()
        {
            if (cellValues == null)
            {
                DialogResult result = MessageBox.Show("Cell values are null. Please select a valid cell.", "STATUS");

                if (result == DialogResult.OK)
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                    return false;
                }
            }
            return true;
        }

        private void loadUpdate()
        {
            if (isNull())
            {
                cmbUpdateProgram.Text = cellValues[0];
                cmbUpdateCourse.Text = cellValues[3];
                numericUpdateYearLevel.Value = int.Parse(cellValues[1]);
                txtUpdateSection.Text = cellValues[2];
                txtUpdateMaleCount.Text = cellValues[5];
                txtUpdateFemaleCount.Text = cellValues[6];
                timeUpdateStart.Text = cellValues[7];
                timeUpdateEnd.Text = cellValues[8];
            }
        }

        private void loadRemove()
        {
            if (isNull())
            {
                txtRemoveProgram.Text = cellValues[0];
                txtRemoveCourse.Text = cellValues[3];
                txtRemoveYearLevel.Text = cellValues[1];
                txtRemoveSection.Text = cellValues[2];
                txtRemoveMaleCount.Text = cellValues[5];
                txtRemoveFemaleCount.Text = cellValues[6];
                timeRemoveStart.Text = cellValues[7];
                timeRemoveEnd.Text = cellValues[8];
            }
        }

        // update selected row
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable table;
            string id, newCourseId;
            string command = "SELECT course_id FROM course_tb WHERE course_description = @course";
            table = Database.executeQuery(command, new MySqlParameter[] {new MySqlParameter("@course", cellValues[4])});
            id = table.Rows[0]["course_id"].ToString();


            command = "SELECT course_id FROM course_tb WHERE course_code = @des";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@des", cmbUpdateCourse.Text)});
            newCourseId = table.Rows[0]["course_id"].ToString();
            Debug.WriteLine(newCourseId);

            command = $"UPDATE course_class_tb\r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nSET \r\n  course_class_tb.class_count_male = @maleCount,\r\n  course_class_tb.class_count_female = @femaleCount,\r\n  course_class_tb.class_time_start = @timeStart,\r\n  course_class_tb.class_time_end = @endStart,  course_class_tb.program = @prog,  course_class_tb.section = @sec,\r\n  course_assignment_tb.course_id = @id\r\nWHERE  course_class_tb.program = '{cellValues[0]}' AND  course_class_tb.section = '{cellValues[2]}' AND  course_assignment_tb.course_id = {id}";

            MySqlParameter[] parameters = new MySqlParameter[] { 
                new MySqlParameter("@maleCount", txtUpdateMaleCount.Text),
                new MySqlParameter("@femaleCount", txtUpdateFemaleCount.Text),
                new MySqlParameter("@timeStart", timeUpdateStart.Value),
                new MySqlParameter("@endStart", timeUpdateEnd.Value),
                new MySqlParameter("@prog", cmbUpdateProgram.Text),
                new MySqlParameter("@sec", txtUpdateSection.Text),
                new MySqlParameter("@id", newCourseId)
            };

            Database.query(command, parameters);

            DialogResult dialogResult = MessageBox.Show("Class is updated successfully!", "STATUS");
            if(dialogResult == DialogResult.OK)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                cmbUpdateProgram.Text = "";
                cmbUpdateCourse.Text = "";
                numericUpdateYearLevel.Value = 1;
                txtUpdateSection.Clear();
                txtUpdateMaleCount.Clear();
                txtUpdateFemaleCount.Clear();
                timeUpdateStart.Text = "";
                timeUpdateEnd.Text = "";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ClassHistory form = new ClassHistory(this, panel);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            panel.Controls.Add(form);
            clearField();
            form.Show();
        }

        private void btnRemoveClass_Click(object sender, EventArgs e)
        {
            string classID = string.Empty;
            string courseID = string.Empty;
            MySqlParameter[] parameters;
            string schoolYearID = "1";
            string command = "SELECT course_id FROM course_tb WHERE course_code = @code;";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@code", txtRemoveCourse.Text)});
            courseID = table.Rows[0]["course_id"].ToString();

            command = "SELECT course_assignment_id FROM course_assignment_tb WHERE course_id = @course_id AND teacher_id = @teacher_id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@course_id", courseID), new MySqlParameter("@teacher_id", teacher_id)});
            string course_assignment = table.Rows[0]["course_assignment_id"].ToString();

            command = "SELECT class_id FROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE \r\ncourse_assignment_tb.teacher_id = @id\r\nAND course_tb.course_code = @code \r\nAND program = @prog \r\nAND section = @sec \r\nAND year_level = @lev";
            parameters = new MySqlParameter[] {
                new MySqlParameter("@id", teacher_id),
                new MySqlParameter("@code", txtRemoveCourse.Text),
                new MySqlParameter("@prog", txtRemoveProgram.Text),
                new MySqlParameter("@sec", txtRemoveSection.Text),
                new MySqlParameter("@lev", txtRemoveYearLevel.Text)
            };

            try
            {
                table = Database.executeQuery(command, parameters);
                classID = table.Rows[0]["class_id"].ToString();
            } catch
            {
                Debug.Write(courseID + " " + course_assignment);
                return;
            }

            command = "INSERT INTO deleted_course_class_tb(class_id, course_assignment_id, school_year_id, class_count_male, class_count_female, class_time_start, class_time_end, program, section, year_level) VALUES(@classID, @courseID, @yearID, @countMale, @countFemale, TIME(@start), TIME(@end), @prog, @sec, @level)";
            parameters = new MySqlParameter[] {
                new MySqlParameter("@classID", classID),
                new MySqlParameter("@courseID", course_assignment),
                new MySqlParameter("@yearID", schoolYearID),
                new MySqlParameter("@countMale", txtRemoveMaleCount.Text),
                new MySqlParameter("@countFemale", txtRemoveFemaleCount.Text),
                new MySqlParameter("@start", timeRemoveStart.Value.ToString("HH:mm:ss")),
                new MySqlParameter("@end", timeRemoveEnd.Value.ToString("HH:mm:ss")),
                new MySqlParameter("@prog", txtRemoveProgram.Text),
                new MySqlParameter("@sec", txtRemoveSection.Text),
                new MySqlParameter("@level", txtRemoveYearLevel.Text)
            };
            Database.query(command, parameters);

            command = "DELETE FROM course_class_tb WHERE course_assignment_id = @id AND program = @prog AND section = @sec AND year_level = @level";
            parameters = new MySqlParameter[] {
                  new MySqlParameter("@id", course_assignment),
                  new MySqlParameter("@prog", txtRemoveProgram.Text),
                  new MySqlParameter("@sec", txtRemoveSection.Text),
                  new MySqlParameter("@level", txtRemoveYearLevel.Text)
            };
            Database.query(command, parameters);
            MessageBox.Show("Class is removed successfully!", "STATUS");
            clearField();
        }

        private void clearField()
        {
            txtRemoveProgram.Clear();
            txtRemoveSection.Clear();
            txtRemoveYearLevel.Clear();
            txtRemoveMaleCount.Clear();
            txtRemoveFemaleCount.Clear();
            txtRemoveCourse.Clear();
        }
    }
}
