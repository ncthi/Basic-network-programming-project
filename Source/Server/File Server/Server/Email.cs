using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server
{
    internal class Email
    {
        public static string Address = "cloudkeeper4@gmail.com";
        public static string Password = "yzzatuxcjlxqonmy";
        private string ReadHtmlFile(string filePath)
        {
            string htmlContent = string.Empty;
            try
            {
                htmlContent = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when reading HTML file: " + ex.Message);
            }
            return htmlContent;
        }
        // Gửi mã xác thực
        public void SendAuthenticationCode(string userEmail, string code)
        {
            string subject = "Authentication Code";
            //lấy đường dẫn thư mục server
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            // Lấy đường dẫn EmailAuthentication.html
            string htmlFilePath = basePath + "\\Email\\EmailAuthentication.html";
            string body = GetAuthenticationCodeEmailBody(htmlFilePath,code);

            Send(userEmail, subject, code); //gửi email đến địa chỉ email của người nhận 

        }
        // Gửi password random
        public void SendPasswordResetEmail(string userEmail, string name, string newPassword)
        {
            string subject = "Reset Password";
            //lấy đường dẫn thư mục server
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            // Lấy đường dẫn Emil.html
            string htmlFilePath = basePath + "\\Email\\Email.html";
            string body = GetPasswordResetEmailBody(htmlFilePath, name, newPassword);

            Send(userEmail, subject, body); //gửi email đến địa chỉ email của người nhận 
        }

        // Tạo random password khi người dùng quên mật khẩu
        public static string GenerateRandomPassword() //Tạo mật khẩu ngẫu nhiên dài 8 kí tự 
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            return new string(Enumerable.Repeat(validChars, 8) // Mật khẩu có độ dài 8 ký tự
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Tạo mã xác thực khi đăng ký tài khoản
        public static string GenerateRandomNumber()
        {
            const string validNumber = "1234567890";
            Random random = new Random();
            return new string(Enumerable.Repeat(validNumber, 6) // Mật khẩu có độ dài 8 ký tự
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }     

        //Lấy nôị dung html đã code sẵn và thay thế mật khẩu/code 
        private string GetPasswordResetEmailBody(string htmlBodyPath, string name, string newPassword)
        {
            string body = File.ReadAllText(htmlBodyPath);
            body = body.Replace("{newPassword}", newPassword);
            body = body.Replace("{userName}", name);
            return body;
        }
        private string GetAuthenticationCodeEmailBody(string htmlBodyPath,string code)
        {
            string body = File.ReadAllText(htmlBodyPath);
            body = body.Replace("{authenticationCode}", code);
            return body;
        }
        private void Send(string userEmail, string subject, string body)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(Address, Password);
                using (MailMessage mail = new MailMessage(Address, userEmail))
                {
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    smtp.Send(mail);
                }
            }
        }

    }
}
