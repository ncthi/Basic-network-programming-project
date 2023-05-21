﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Email
    {
        public static string Address = "21522648@gm.uit.edu.vn"; //Địa chỉ email của bạn
        public static string Password = "abcde"; //Mật khẩu ứng dụng
        string htmlFilePath = @"C:\LTM\email.html"; //đường dẫn tới file html 
        public void SendPasswordResetEmail(string userEmail, string htmlFilePath) 
        {
            string newPassword = GenerateRandomPassword();
            string subject = "Reset Password";
            
            string htmlBody = ReadHtmlFile(htmlFilePath);
            string body = GetPasswordResetEmailBody(htmlBody, newPassword);

            Send(userEmail, subject, body); //gửi email đến địa chỉ email của người nhận 
        }

        private string GenerateRandomPassword() //Tạo mật khẩu ngẫu nhiên dài 8 kí tự 
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            return new string(Enumerable.Repeat(validChars, 8) // Mật khẩu có độ dài 8 ký tự
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string ReadHtmlFile(string filePath)
        {
            string htmlContent = string.Empty;
            try
            {
                htmlContent = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi khi đọc file HTML: " + ex.Message);
            }
            return htmlContent;
        }

        private string GetPasswordResetEmailBody(string htmlBody,string newPassword)  //Lấy nôị dung html đã code sẵn và thay thế mật khẩu 
        {
            string body = htmlBody.Replace("{{newPassword}}", newPassword);
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
