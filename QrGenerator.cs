using Org.BouncyCastle.Asn1.X509;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MimeKit;
using MailKit.Net.Smtp;
using System.ServiceModel.MsmqIntegration;
using ZXing.QrCode.Internal;

namespace qrTry
{
    internal class QrGenerator
    {
        private static Bitmap qrCodeImage;
        private static string studentinfo;
        public static void generateQR(string studentInfo)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(studentInfo, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qRCode = new QRCoder.QRCode(qRCodeData);
            qrCodeImage = qRCode.GetGraphic(5);
            studentinfo = studentInfo;
        }

        public static void sendQrToEmail(string email)
        {
            string qrCodeBase64 = "";
            using (MemoryStream ms = new MemoryStream())
            {
                var message = new MimeMessage();
                var builder = new BodyBuilder();

                qrCodeImage.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                qrCodeBase64 = Convert.ToBase64String(imageBytes);
                message.From.Add(new MailboxAddress("Attendance Tracker System", "ATS_finals@gmail.com"));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = "Student QR Code";


                string path = @"C:\Users\ACER\Desktop\Finals\attendance_tracker\qr_code_template.html";
                string htmlContent = File.ReadAllText(path);
                // set the HTML content with the QR code as the body of the email
                builder.HtmlBody = htmlContent.Replace("{qr_code}", Convert.ToBase64String(imageBytes));
                builder.Attachments.Add("qr_code.png", ms.ToArray());
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
