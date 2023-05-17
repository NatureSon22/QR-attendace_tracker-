using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_tracker
{
    public partial class SystemManageStudent : Form
    {
        private Panel panel;
        private string[] cellValues;
        private int id;
        public SystemManageStudent(int id, Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            this.id = id;
            string command = "SELECT DISTINCT(section) FROM course_class_tb";
            // search for optimized version
            DataTable table = Database.executeQuery(command);
            int i = table.Rows.Count;
            string[] value = new string[i];

            for (int x = 0; x < i; x++)
            {
                value[x] = table.Rows[x]["section"].ToString();
            }
            cmbSection.DataSource = value;
            cmbUpdateSection.DataSource = value;
            set();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = filterSearch(cmbFilter.SelectedIndex);
            string command = $"SELECT \r\n\taccount_credentials_tb.school_id,\r\n\taccount_credentials_tb.first_name,\r\n\taccount_credentials_tb.middle_name,\r\n\taccount_credentials_tb.last_name,\r\n\tcourse_class_tb.program,\r\n\tcourse_tb.course_description,\r\n\tcourse_class_tb.year_level,\r\n\tcourse_class_tb.section\r\nFROM \r\n\tenrollment_tb\r\n\tJOIN course_class_tb ON enrollment_tb.class_id = course_class_tb.class_id\r\n\tJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n\tJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\n\tJOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\n\tJOIN account_credentials_tb ON student_tb.school_id = account_credentials_tb.school_id\r\nWHERE {filter} AND course_assignment_tb.teacher_id = @teacher_id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@value", txtSearch.Text), new MySqlParameter("@teacher_id", id) });
            dataTableStudent.DataSource = table;
        }

        private string filterSearch(int choose)
        {
            string filter = string.Empty;

            switch (choose)
            {
                case 0:
                    filter = "";
                    break;
                case 1:
                    filter = "account_credentials_tb.school_id = @value";
                    break;
                case 2:
                    filter = "course_class_tb.program = @value";
                    break;
                case 3:
                    filter = "course_class_tb.year_level = @value";
                    break;
                case 4:
                    filter = "account_credentials_tb.first_name = @value";
                    break;
                case 5:
                    filter = "account_credentials_tb.last_name = @value";
                    break;
            }

            return filter;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked ? radMale.Text : radFemale.Text;
            string[] value = new string[5];
            value[0] = txtSchoolID.Text;
            value[1] = gender;
            value[2] = cmbProgram.Text;
            value[3] = numericYearLevel.Text;
            value[4] = cmbSection.Text;

            if (value.Any(val => val.Length == 0)) {
                MessageBox.Show("Please fill in all required fields", "STATUS");
                return;
            }

            // check if the student to be added has an existing account
            MySqlParameter[] parameters;
            DataTable table;
            string command, school_id = txtSchoolID.Text;

            command = "SELECT school_id FROM account_credentials_tb WHERE first_name = @fn AND middle_name = @mn AND last_name = @ln";
            parameters = new MySqlParameter[] { 
                new MySqlParameter("@fn", txtFN.Text),
                new MySqlParameter("@mn", txtMN.Text),
                new MySqlParameter("@ln", txtLN.Text)
            };

            if (!exist(command, parameters))
            {
                MessageBox.Show("The system is unable to find any records matching the student.", "STATUS");
                return;
            }
          

            // check first if a class exist
            // check if a student is already enrolled on the class

            // course_id 
            command = "SELECT class_id FROM course_class_tb\r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\n  WHERE program = @prog \r\n  AND section = @sec \r\n  AND year_level = @level\r\n  AND course_tb.course_code = @code; ";
            parameters = new MySqlParameter[] {
                new MySqlParameter("@prog", cmbProgram.Text),
                new MySqlParameter("@sec", cmbSection.Text),
                new MySqlParameter("@level", numericYearLevel.Text),
                new MySqlParameter("@code", cmbCourse.Text)
            };
            table = Database.executeQuery(command, parameters);
            string class_id, student_id;

            if(!exist(command, parameters))
            {
                MessageBox.Show("Class is not yet created", "STATUS");
                return;
            }else 
            {
                class_id = table.Rows[0]["class_id"].ToString();
                command = "SELECT student_id FROM student_tb WHERE school_id = @id";
                table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", school_id)});
                student_id = exist(command, new MySqlParameter[] { new MySqlParameter("@id", txtSchoolID.Text) }) ? table.Rows[0]["student_id"].ToString() : null; 
            }
            

            command = "SELECT enrollment_id FROM enrollment_tb WHERE student_id = @sid AND class_id = @cid";
            parameters = new MySqlParameter[]
            {
                new MySqlParameter("@sid", student_id),
                new MySqlParameter("@cid", class_id)
            };
            if(exist(command, parameters))
            {
                MessageBox.Show("Student is already enrolled in the class!", "STATUS");
                return;
            }


            if (student_id == null)
            {
                command = "INSERT INTO student_tb(school_id, gender, program, year_level, section) VALUES (@id, @gender, @prog, @level, @sec)";
                parameters = new MySqlParameter[] {
                new MySqlParameter("@id", value[0]),
                new MySqlParameter("@gender", value[1]),
                new MySqlParameter("@prog", value[2]),
                new MySqlParameter("@level", value[3]),
                new MySqlParameter("@sec", value[4])
                };
                // error
                Database.query(command, parameters);
             }

            command = "SELECT student_id FROM student_tb WHERE school_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", school_id) });
            student_id = exist(command, new MySqlParameter[] { new MySqlParameter("@id", txtSchoolID.Text) }) ? table.Rows[0]["student_id"].ToString() : null;


            command = "INSERT INTO enrollment_tb (student_id, class_id) VALUES (@sid, @cid)";
            parameters = new MySqlParameter[] { 
                new MySqlParameter("@sid", student_id),
                new MySqlParameter("@cid", class_id)
            };
            Database.query(command, parameters);
            MessageBox.Show("Student enrolled successfully!", "STATUS");
        }

        private void numericYearLevel_ValueChanged(object sender, EventArgs e)
        {
            if(numericYearLevel.Value <= 0) { 
                numericYearLevel.Value = 1;
            } else if(numericYearLevel.Value > 4)
            {
                numericYearLevel.Value = 4;
            } 
        }

        private bool exist(string command, MySqlParameter[] parameter)
        {
            DataTable table = new DataTable();
            try
            {
                table = Database.executeQuery(command, parameter);
            }catch(Exception)
            {
                MessageBox.Show("The system is unable to find any records matching the student.", "STATUS");
                return false;
            }
            if(table.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }

        private void SystemManageStudent_Load(object sender, EventArgs e)
        {
            
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
        }

        private void set()
        {
            string command = "SELECT start_school_year, end_school_year FROM school_year_tb WHERE school_year_id = 1";
            DataTable table = Database.executeQuery(command);

            string start = table.Rows[0]["start_school_year"].ToString().Substring(6, 5);
            string end = table.Rows[0]["end_school_year"].ToString().Substring(6, 5);
            string school_year = $"{start}-{end}";

            txtSchoolYear.Text = school_year;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1) {
                loadSearch();
            } else if(tabControl1.SelectedIndex == 2)
            {
                loadUpdate();
            } else if(tabControl1.SelectedIndex == 3)
            {
                loadDelete();
            }
        }

        private void loadSearch()
        {
            string command = "SELECT \r\n\taccount_credentials_tb.school_id,\r\n\taccount_credentials_tb.first_name,\r\n\taccount_credentials_tb.middle_name,\r\n\taccount_credentials_tb.last_name,\r\n\tcourse_class_tb.program, course_tb.course_code,\r\n\tcourse_class_tb.year_level,\r\n\tcourse_class_tb.section\r\nFROM \r\n\tenrollment_tb\r\n\tJOIN course_class_tb ON enrollment_tb.class_id = course_class_tb.class_id\r\n\tJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n\tJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\n\tJOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\n\tJOIN account_credentials_tb ON student_tb.school_id = account_credentials_tb.school_id AND course_assignment_tb.teacher_id = @teacher_id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { (new MySqlParameter("@teacher_id", id))});
            dataTableStudent.DataSource = table;
        }

        private void loadUpdate()
        {
            if (isNull())
            {
                Debug.WriteLine(string.Join(" ", cellValues));
                string command = "SELECT gender FROM student_tb WHERE school_id = @id";
                DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", cellValues[0]) });
                string gender = table.Rows[0]["gender"].ToString();
                txtUpdateSchoolID.Text = cellValues[0];
                txtUpdateFN.Text = cellValues[1];
                txtUpdateMN.Text = cellValues[2];
                txtUpdateLN.Text = cellValues[3];
                if (gender == "Male")
                {
                    radUpdateMale.Checked = true;
                }
                else
                {
                    radUpdateFemale.Checked = true;
                }
                cmbUpdateProgram.Text = cellValues[4];
                cmbUpdateCourse.Text = cellValues[5];
                numericYearUpdateLevel.Text = cellValues[6];
                cmbUpdateCourse.Text = cellValues[7];    
            }
        }

        private void loadDelete()
        {
            if (isNull())
            {
                string command = "SELECT gender FROM student_tb WHERE school_id = @id";
                DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", cellValues[0]) });
                string gender = table.Rows[0]["gender"].ToString();
                txtRemoveSchoolID.Text = cellValues[0];
                txtRemoveFN.Text = cellValues[1];
                txtRemoveMN.Text = cellValues[2];
                txtRemoveLN.Text = cellValues[3];
                txtRemoveProgram.Text = cellValues[4];
                if (gender == "Male")
                {
                    radRemoveMale.Checked = true;
                } 
                else
                {
                    radRemoveMale.Checked = true;
                }
                txtRemoveSection.Text = cellValues[7];
                txtRemoveCourse.Text = cellValues[5];
                numericRemoveYearLevel.Text = cellValues[6];
                Debug.WriteLine(string.Join(" ", cellValues));
            }
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

        private void dataTableStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellValues = new string[dataTableStudent.Columns.Count];
            int row = e.RowIndex;
           

            for (int i = 0; i < dataTableStudent.Columns.Count; i++)
            {
                cellValues[i] = dataTableStudent.Rows[row].Cells[i].Value.ToString();
                Debug.WriteLine(cellValues[i]);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {

            string command = "SELECT \r\n\tclass_id\r\nFROM course_class_tb \r\n    JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n\tJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE\r\n\tcourse_class_tb.program = @prog\r\n    AND course_tb.course_code = @ccode\r\n    AND course_class_tb.year_level = @lev\r\n    AND course_class_tb.section = @sec";
            MySqlParameter[] parameter = new MySqlParameter[]
            {
                new MySqlParameter("@prog", cmbUpdateProgram.Text),
                new MySqlParameter("@ccode", cmbUpdateCourse.Text),
                new MySqlParameter("@lev", numericYearUpdateLevel.Text),
                new MySqlParameter("@sec", cmbUpdateSection.Text)
            };
            DataTable table = Database.executeQuery(command, parameter);
            string class_id;

            if(table.Rows.Count > 0)
            {
                class_id = table.Rows[0]["class_id"].ToString();
            }
            else
            {
                MessageBox.Show("The class you are trying to enroll in does not exist.", "STATUS");
                return;
            }

            command = "SELECT program, year_level, section FROM student_tb WHERE school_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", txtUpdateSchoolID.Text)});
            string[] info = new string[table.Columns.Count];

            info[0] = table.Rows[0]["program"].ToString();
            info[1] = table.Rows[0]["year_level"].ToString();
            info[2] = table.Rows[0]["section"].ToString();

            if(!check(info))
            {
                return;
            }

            command = "UPDATE account_credentials_tb \r\nSET \r\n   first_name = @fn,\r\n   middle_name = @mn,\r\n   last_name = @ln\r\nWHERE \r\n   school_id = @id";
            parameter = new MySqlParameter[] { 
                new MySqlParameter("@fn", txtUpdateFN.Text),
                new MySqlParameter("@mn", txtUpdateMN.Text),
                new MySqlParameter("@ln", txtUpdateLN.Text),
                new MySqlParameter("@id", txtUpdateSchoolID.Text),
            };
            Database.query(command, parameter);

            command = "UPDATE enrollment_tb \r\nJOIN student_tb ON enrollment_tb.student_id = student_tb.student_id\r\nSET enrollment_tb.class_id = @cid \r\nWHERE student_tb.school_id = @sid;\r\n";
            Database.query(command, new MySqlParameter[] { new MySqlParameter("@sid", txtUpdateSchoolID.Text), new MySqlParameter("@cid", class_id)});

            DialogResult result = MessageBox.Show("Updated successfully!", "STATUS");

            if(result == DialogResult.OK)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
        }

        private bool check(string[] info)
        {
            if (info[0] != cmbUpdateProgram.Text || info[1] != numericYearUpdateLevel.Text || info[2] != cmbUpdateSection.Text)
            {
                MessageBox.Show("Student is not enrolled in the specified program or year level and section.", "STATUS");
                return false;
            }
            return true;
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            StudentHistory student = new StudentHistory(this, panel);
            student.TopLevel = false;
            student.Dock = DockStyle.Fill;
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            panel.Controls.Add(student);
            student.Show();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            string gender = radRemoveMale.Checked ? "Male" : "Female";
            string studentID = string.Empty;
            string classID = string.Empty;
            string enrollment_id = string.Empty;
            string command = "SELECT student_id FROM student_tb WHERE school_id = @id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", txtRemoveSchoolID.Text) });
            studentID = table.Rows[0]["student_id"].ToString();

            command = "SELECT class_id FROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE\r\n    course_assignment_tb.teacher_id = @teacher_id AND\r\n    course_class_tb.program = @prog AND\r\n    course_class_tb.year_level = @lev AND\r\n    course_class_tb.section = @sec AND\r\n    course_tb.course_code = @code\r\n      ";
            MySqlParameter[] mySqlParameters = new MySqlParameter[] {
                new MySqlParameter("@teacher_id", id),
                new MySqlParameter("@prog", txtRemoveProgram.Text),
                new MySqlParameter("@lev", numericRemoveYearLevel.Value.ToString()),
                new MySqlParameter("@sec", txtRemoveSection.Text),
                new MySqlParameter("@code", txtRemoveCourse.Text)
            };
            table = Database.executeQuery(command, mySqlParameters);
            classID = table.Rows[0]["class_id"].ToString();

            command = "INSERT deleted_student_tb(student_id, school_id, first_name, middle_name, last_name, program, year_level, section, gender, class_id) VALUES(@student, @school, @fn, @mn, @ln, @program, @lev, @section, @gender, @class_id)";
            mySqlParameters = new MySqlParameter[] { 
                new MySqlParameter("@student", studentID),
                new MySqlParameter("@school", txtRemoveSchoolID.Text),
                new MySqlParameter("@fn", txtRemoveFN.Text),
                new MySqlParameter("@mn", txtRemoveMN.Text),
                new MySqlParameter("@ln", txtRemoveLN.Text),
                new MySqlParameter("@gender", gender),
                new MySqlParameter("@program", txtRemoveProgram.Text),
                new MySqlParameter("@lev", numericRemoveYearLevel.Value.ToString()),
                new MySqlParameter("@section", txtRemoveSection.Text),
                new MySqlParameter("@class_id", classID)
            };
            Database.query(command, mySqlParameters);

            command = "SELECT enrollment_id FROM enrollment_tb WHERE student_id = @stud_id AND class_id = @class_id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@stud_id", studentID), new MySqlParameter("@class_id", classID) });
            enrollment_id = table.Rows[0]["enrollment_id"].ToString();

            // Delete attendance records for the enrollment
            command = "DELETE FROM attendance_tb WHERE enrollment_id = @enrollment_id";
            Database.query(command, new MySqlParameter[] { new MySqlParameter("@enrollment_id", enrollment_id) });

            // Delete the enrollment record
            command = "DELETE FROM enrollment_tb WHERE enrollment_id = @enrollment_id";
            Database.query(command, new MySqlParameter[] { new MySqlParameter("@enrollment_id", enrollment_id) });
            MessageBox.Show("Student is removed sucessfully", "STATUS");
        }

        // check if class can still accomodate students
    }
}
