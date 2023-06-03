using RSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form_CreateAccount : Form
    {


        private const string serverIpAddress = "127.0.0.1";
        private const int serverPort = 8080;
        public Form_CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private async void button_CreateAcc_Click(object sender, EventArgs e)
        {
            string username = textBox_CreateUser.Text;
            string password = textBox_CreatePass.Text;
            string confirmPassword = textBox_ConfirmPass.Text;
            string email=textBox_Email.Text;

            //Kiểm tra thông tin nhập vào 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter full information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ràng buộc tên người dùng
            if (username.Contains(" ") || HasSpecialCharacters(username) || HasUppercaseLetters(username))
            {
                MessageBox.Show("Invalid username! The name cannot contain spaces, special characters and capital letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ràng buộc độ dài mật khẩu
            if (password.Length < 6)
            {
                MessageBox.Show("Password must contain at least 6 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        // Đọc khóa công khai từ file và nhập vào đối tượng RSA
                        RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
                        RSAKeys.ImportPublicKey(csp);

                        // Mã hóa mật khẩu bằng khóa công khai RSA
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                        byte[] encryptedPassword = RSAKeys.EncryptData(csp, passwordBytes);

                        // Gửi thông điệp Tên, Mật khẩu và Email (đã được mã hóa) đến server
                        string message = $"{username},{Convert.ToBase64String(encryptedPassword)},{email},registry";
                        byte[] info = Encoding.ASCII.GetBytes(message);

                        // Gửi thông điệp Tên và Mật khẩu đến server
                        stream.Write(info, 0, info.Length);

                        // Nhận kết quả từ server, đã đăng nhập thành công hay chưa 
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string result = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (result == "True")
                        {
                            MessageBox.Show("Account successfully created!");
                            this.Close();
                        }
                        else MessageBox.Show("You can not create an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}");
            }
        }

        private bool HasSpecialCharacters(string str)
        {
            string specialCharacters = @"!@#$%^&*()-=_+[]{}|;:,.<>?";
            return str.IndexOfAny(specialCharacters.ToCharArray()) != -1;
        }

        private bool HasUppercaseLetters(string str)
        {
            return str.Any(char.IsUpper);
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e) //Nút hiện mật khẩu 
        {
            if (checkBox_ShowPass.Checked)
            {
                textBox_CreatePass.UseSystemPasswordChar = false;
                textBox_ConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_CreatePass.UseSystemPasswordChar = true;
                textBox_ConfirmPass.UseSystemPasswordChar = true;
            }
        }
       
    }
}