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

namespace attendance_tracker
{
    public partial class SystemAttendance : Form
    {
        Panel panel;
        private VideoCaptureDevice _videoCaptureDevice;
        private bool isDetected = false;

        public SystemAttendance(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        { 
            SystemAttendanceToday systemAttendanceToday = new SystemAttendanceToday(this, panel);
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
            pbScanner.Image = cameraImage;
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
                    DialogResult res = MessageBox.Show("Attendance is succesfully recorded!");

                    if (res == DialogResult.OK)
                    {
                        MessageBox.Show(result.Text);
                        isDetected = false;
                    }
                }
            }
        }
    }
}
