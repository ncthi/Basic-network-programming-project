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

        private async void button_CreateAcc_Click(object sender, EventArgs e)
        {
            string username = textBox_CreateUser.Text;
            string password = textBox_CreatePass.Text;
            string confirmPassword = textBox_ConfirmPass.Text;
            string email = textBox_Email.Text;

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

                        // Mã hóa mật khẩu bằng khóa công khai RSA
                        string data = $"{username},{password},{email},registry";
                        //string dataEncrypt = RSAKeys.EncryptData(data);
                        // Gửi thông điệp Tên, Mật khẩu và Email (đã được mã hóa) đến server
                        byte[] dataBytes = RSAKeys.EncryptData(data);
                        // Gửi thông điệp Tên và Mật khẩu đến server
                        stream.Write(dataBytes, 0, dataBytes.Length);

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

        private void button_Home_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            this.Close();
            form_Login.Show();
        }
    }
}