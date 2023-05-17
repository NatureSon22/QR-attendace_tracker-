using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Security.Policy;
using Guna.UI2.WinForms;

namespace attendance_tracker
{
    public partial class SystemAttendance : Form
    {
        private string[] infoClass = new string[5];
        Panel panel;
        private VideoCaptureDevice _videoCaptureDevice;
        private bool isDetected = false;
        private int id;
        bool isFound = false;


        public SystemAttendance(Panel panel, int id)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#A7CDDA");
            this.panel = panel;
            this.id = id;

            string command = "SELECT DISTINCT(course_code) FROM course_assignment_tb \r\n JOIn course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\n WHERE course_assignment_tb.teacher_id = @id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id)});
            string[] teacher_course = new string[table.Rows.Count];

            for(int x = 0; x < table.Rows.Count; x++)
            {
                teacher_course[x] = table.Rows[x]["course_code"].ToString();
            }
            //cmbCourse.DataSource = teacher_course;
            //cmbProg.DataSource = teacher_course;

            command = "SELECT DISTINCT(section) \r\nFROM course_class_tb \r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nWHERE course_assignment_tb.teacher_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", id) });
            string[] teacher_section =  new string[table.Rows.Count];

            for (int x = 0; x < table.Rows.Count; x++)
            {
                teacher_section[x] = table.Rows[x]["section"].ToString();
            }

            cmb_Sec.DataSource = teacher_section;

        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            SystemAttendanceToday systemAttendanceToday = new SystemAttendanceToday(this, panel, infoClass);
            systemAttendanceToday.TopLevel = false;
            systemAttendanceToday.Dock = DockStyle.Fill;
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            panel.Controls.Add(systemAttendanceToday);
            systemAttendanceToday.Show();
        }

        private void SystemAttendance_Load(object sender, EventArgs e)
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                _videoCaptureDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                _videoCaptureDevice.NewFrame += new NewFrameEventHandler(video_NewFrame);
                _videoCaptureDevice.Start();
            }
            else
            {
                MessageBox.Show("No video device found");
            }

            timer1.Interval = 50;
            if (!isDetected)
            {
                timer1.Tick += new EventHandler(timer1_Tick);

            }
            timer1.Start();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
         
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap cameraImage = (Bitmap)eventArgs.Frame.Clone();
            this.Invoke((MethodInvoker)delegate {
                pbScanner.Image = cameraImage;
            });
        }

        private void ScanQr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
            {
                _videoCaptureDevice.SignalToStop();
                _videoCaptureDevice.WaitForStop();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (_videoCaptureDevice == null || !_videoCaptureDevice.IsRunning)
            {
                MessageBox.Show("Camera not available.", "STATUS");
                return;
            }

            if (pbScanner.Image != null)
            {
                Bitmap cameraImage = new Bitmap(pbScanner.Image);
                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();

                // Convert the bitmap to a byte array
                BitmapData bitmapData = cameraImage.LockBits(new Rectangle(0, 0, cameraImage.Width, cameraImage.Height), ImageLockMode.ReadOnly, cameraImage.PixelFormat);
                IntPtr ptr = bitmapData.Scan0;
                int bytes = bitmapData.Stride * cameraImage.Height;
                byte[] rgbValues = new byte[bytes];
                Marshal.Copy(ptr, rgbValues, 0, bytes);
                cameraImage.UnlockBits(bitmapData);

                // Decode the QR code
                var result = barcodeReader.Decode(rgbValues, cameraImage.Width, cameraImage.Height, ZXing.RGBLuminanceSource.BitmapFormat.RGBA32);

                // If a QR code was successfully decoded, display the result in a message box
                if (result != null && !isDetected)
                {
                    isDetected = true;
                    enterAttendance(result.ToString());
                    Debug.WriteLine(isFound);

                    if (isFound)
                    {
                        isDetected = false;
                        isFound = false;
                        return;
                    }
                    Debug.WriteLine(isFound);
                    DialogResult res = MessageBox.Show("Attendance is succesfully recorded!");

                    if (res == DialogResult.OK)
                    {
                        await Task.Delay(2000).ContinueWith(_ =>
                        {
                            this.Invoke(new Action(() =>
                            {
                                removeRecord();
                                isDetected = false;
                                isFound = false;
                            }));
                        });
                    }
                }
            }
        }

        private void enterAttendance(string result)
        {
            string[] info = result.Split('\n').Select(x => x.Trim()).ToArray();
            string[] courses = new string[0];

            if (info.Length >= 9 && info[8].Length == 1)
            {
                courses = new string[] { info[8] };
            }
            else
            {
                try
                {
                    courses = info[8].Split('|').Select(x => x.Trim()).ToArray();
                }
                catch (Exception)
                {
  
                    showMessage("The QR code you scanned is not recognized. Please make sure you have scanned the correct QR code and try again.");
                    isFound = true;
                    return;
                }
            }


            string command;
            DataTable table;

            command = "SELECT student_id FROM student_tb WHERE school_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", info[0]) });
            string studentID;
            string class_id = string.Empty;
            MySqlParameter[] parameters;

            if (table.Rows.Count > 0)
            {
                studentID = table.Rows[0]["student_id"].ToString();
            } else
            {
                showMessage("The system is unable to find any records matching the student.");
                isFound = true;
                return;
            }

            string course;
            if (info[8].Length == 1) { 
                course = info[8];
            } else
            {
                course = courses.Contains(txtCOURSE.Text) ? txtCOURSE.Text : null;
            }


            if(course == null)
            {
                showMessage("Student is not enrolled in this class");
                isFound = true;
                return;
            }

            command = "SELECT class_id \r\nFROM course_class_tb \r\n    JOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\n\tJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE\r\n\tcourse_assignment_tb.teacher_id = @id\r\n    AND course_class_tb.program = @prog\r\n    AND course_tb.course_code = @ccode\r\n    AND course_class_tb.year_level = @lev\r\n\tAND course_class_tb.section = @section;";
            parameters = new MySqlParameter[] {
                    new MySqlParameter("@id", id),
                    new MySqlParameter("@prog", info[5]),
                    new MySqlParameter("@ccode", course),
                    new MySqlParameter("@lev", info[6]),
                    new MySqlParameter("@section", info[7])
            };
            table = Database.executeQuery(command, parameters);

            
            try
            {
                class_id = table.Rows[0]["class_id"].ToString();
            } catch
            {
                showMessage("Student is not enrolled in this class");
                isFound = true;
                return;
            }


            command = "SELECT class_time_start, class_time_end FROM course_class_tb WHERE class_id = @id";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@id", class_id)});
            DateTime startTime = DateTime.Parse(table.Rows[0]["class_time_start"].ToString());
            DateTime endTime = DateTime.Parse(table.Rows[0]["class_time_end"].ToString());
            DateTime nowTime = DateTime.Today.Add(DateTime.Now.TimeOfDay);
            string dateToday = DateTime.Now.ToString("yyyy-MM-dd");

            //check if the student is late00
            string record = "";

            if (nowTime < startTime)
            {
                showMessage("Class has not started yet");
                isFound = true;
                return;
            }
            else if (nowTime > startTime.AddMinutes(15))
            {
                // student arrived more than 15 minutes after the start time
                record = "LATE";
            }
            else if (nowTime >= startTime && nowTime <= endTime)
            {
                // student arrived on time
                record = "PRESENT";
            }
            else
            {
                // student arrived after the end time
                record = "ABSENT";
            }

            command = "SELECT * FROM attendance_tb \r\nJOIN enrollment_tb ON attendance_tb.enrollment_id = enrollment_tb.enrollment_id\r\nWHERE\r\n\tenrollment_tb.student_id = @sid AND\r\n    enrollment_tb.class_id = @cid AND\r\n    attendance_tb.arrival_date = @date";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@sid", studentID), new MySqlParameter("@cid", class_id), new MySqlParameter("@date", dateToday) });

            if (table.Rows.Count > 0)
            {
                showMessage("Attendance for student has already been recorded for the given date. Please check the date or update the existing attendance record.");
                isFound = true;
                return;
            }


            txtStudentId.Text = info[0];
            txtFN.Text = info[1];
            txtMN.Text = info[2];
            txtLN.Text = info[3];
            txtProgram.Text = info[5];
            txtYearLevel.Text = info[6];
            txtSection.Text = info[7];
            insertAttendance(studentID, class_id, nowTime, dateToday, record);
            infoClass[0] = info[5];
            infoClass[1] = txtCOURSE.Text;
            infoClass[2] = info[6];
            infoClass[3] = info[7];
            infoClass[4] = dateToday;
        }

        private void removeRecord()
        {
            txtStudentId.Clear();
            txtFN.Clear();
            txtMN.Clear();
            txtLN.Clear();
            txtProgram.Clear();
            txtYearLevel.Clear();
            txtSection.Clear();
        }

        private void btnEnterRecord_Click(object sender, EventArgs e)
        {
            string[] info = new string[9];
            info[0] = txt_ID.Text;
            info[1] = txt_FirstName.Text;
            info[2] = txt_MN.Text;
            info[3] = txt_LN.Text;
            info[4] = rad_Male.Checked ? "Male" : "Female";
            info[5] = cmbProg.Text;
            info[6] = numericYearLevel.Text;
            info[7] = cmb_Sec.Text;
            info[8] = txtCOURSE.Text;
            string result = string.Join("\n", info);
            enterAttendance(result);
        }

        private void insertAttendance(string studentID, string classID, DateTime timein, string datein, string record)
        {

            string command = "SELECT enrollment_id FROM enrollment_tb WHERE student_id = @stud_id AND class_id = @class_id";
            DataTable table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@stud_id", studentID), new MySqlParameter("@class_id", classID)});
            string enrollmentID = "";
            try
            {

                enrollmentID = table.Rows[0]["enrollment_id"].ToString();
            }catch
            {
                MessageBox.Show("Student is not enrolled in this class", "STATUS");
                return;
            }

            command = "INSERT INTO attendance_tb(enrollment_id, arrival_time, arrival_date, attendance_status) VALUES(@id, @time, @date, DEFAULT)";
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@id", enrollmentID),
                new MySqlParameter("@time", timein),
                new MySqlParameter("@date", datein)
            };

            Database.query(command, parameters);

            
            if (record == "PRESENT")
            {
                command = "UPDATE attendance_tb SET attendance_status = @status WHERE arrival_date = @date and enrollment_id = @id";
                parameters = new MySqlParameter[] { 
                    new MySqlParameter("@status", "PRESENT"),
                    new MySqlParameter("@date", datein),
                    new MySqlParameter("@id", enrollmentID)
                };
                Database.query(command, parameters);
            }
        }

        private void numericYearLevel_ValueChanged(object sender, EventArgs e)
        {
            if(numericYearLevel.Value < 1)
            {
                numericYearLevel.Value = 1;
            } else if(numericYearLevel.Value > 4)
            {
                numericYearLevel.Value = 4;
            }
        }

        private void showMessage(string message) 
        {
            MessageBox.Show(message, "STATUS");
        }

        private void guna2TextBox2_Load(object sender, EventArgs e)
        {
            string command = "SELECT class_time_start, class_time_end FROM course_class_tb";
            DataTable table = Database.executeQuery(command);
            DateTime startTime = new DateTime();
            DateTime endTime = new DateTime();
            DateTime timeNow = DateTime.Now;

            for(int i = 0; i < table.Rows.Count; i++)
            {
                startTime = DateTime.Parse(table.Rows[i]["class_time_start"].ToString());
                endTime = DateTime.Parse(table.Rows[i]["class_time_end"].ToString());

                if(timeNow >= startTime && timeNow <= endTime)
                {
                    break;
                }
            }

            command = "SELECT course_code FROM course_class_tb\r\nJOIN course_assignment_tb ON course_class_tb.course_assignment_id = course_assignment_tb.course_assignment_id\r\nJOIN course_tb ON course_assignment_tb.course_id = course_tb.course_id\r\nWHERE class_time_start BETWEEN @timeStart AND @endTime";
            table = Database.executeQuery(command, new MySqlParameter[] { new MySqlParameter("@timeStart", startTime), new MySqlParameter("@endTime", endTime)});
            txtCOURSE.Text = table.Rows[0]["course_code"].ToString();
        }
    }
}
