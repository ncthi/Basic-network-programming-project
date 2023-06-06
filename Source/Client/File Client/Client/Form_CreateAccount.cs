using RSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class Form_CreateAccount : Form
    {


        private const string serverIpAddress = "192.168.137.208";
        private const int serverPort = 8080;
        private TcpClient client = new TcpClient(serverIpAddress, serverPort);
        NetworkStream stream;
        public Form_CreateAccount()
        {
            stream = client.GetStream();
            InitializeComponent();
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private async void button_CreateAcc_Click(object sender, EventArgs e)
        {
            string username = textBox_CreateUser.Text;
            string password = textBox_CreatePass.Text;
            string confirmPassword = textBox_ConfirmPass.Text;
            string email = textBox_Email.Text;
            string authenticationCode = textBox_VerCode.Text;
            try
            {
                // Mã hóa mật khẩu bằng khóa công khai RSA
                string data = $"{username},{password},{email},{authenticationCode},registry";
                // Gửi thông điệp Tên, Mật khẩu và Email (đã được mã hóa) đến server
                byte[] dataBytes = RSAKeys.EncryptData(data);
                // Gửi thông điệp Tên và Mật khẩu đến server
                stream.Write(dataBytes, 0, dataBytes.Length);

                // Nhận kết quả từ server, đã đăng nhập thành công hay chưa 
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string result = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                stream.Flush();
                if (result == "True")
                {
                    MessageBox.Show("Account successfully created!");
                    this.Close();
                }
                else if (result == "False")
                {
                    MessageBox.Show("Invalid authentication code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show(result);
                    return;
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

        //Nút hiện mật khẩu 
        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
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

        private void button_Verify_Click(object sender, EventArgs e)
        {
            string username = textBox_CreateUser.Text;
            string password = textBox_CreatePass.Text;
            string confirmPassword = textBox_ConfirmPass.Text;
            string email = textBox_Email.Text;
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
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Mã hóa mật khẩu bằng khóa công khai RSA
                string data = $"{username},{email},check";
                // Gửi thông điệp Tên, Mật khẩu và Email (đã được mã hóa) đến server
                byte[] dataBytes = RSAKeys.EncryptData(data);
                // Gửi thông điệp Tên và Mật khẩu đến server
                stream.Write(dataBytes, 0, dataBytes.Length);

                // Nhận kết quả từ server, đã đăng nhập thành công hay chưa 
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string result = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                stream.Flush();
                if (result == "True")
                {
                    if (textBox_VerCode.Visible && label_EnterCode.Visible && button_CreateAcc.Visible)
                    {
                        textBox_ConfirmPass.Visible = false;
                        label_EnterCode.Visible = false;
                        button_CreateAcc.Visible = false;
                    }
                    else
                    {
                        textBox_VerCode.Visible = true;
                        label_EnterCode.Visible = true;
                        button_CreateAcc.Visible = true;
                    }
                    MessageBox.Show("Please check your email to get authentication code!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_CreatePass.ReadOnly = true;
                    textBox_ConfirmPass.ReadOnly = true;
                    textBox_CreateUser.ReadOnly = true;
                    textBox_Email.ReadOnly = true;
                    textBox_Email.BackColor = textBox_CreatePass.BackColor = textBox_ConfirmPass.BackColor = textBox_CreateUser.BackColor = Color.White;
                    button_Verify.Visible = false;
                    button_Verify.Enabled = false;
                }
                else if (result == "False")
                {
                    MessageBox.Show("Username or Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    client = new TcpClient(serverIpAddress, serverPort);
                    stream = client.GetStream();
                    return;
                }
                else
                {
                    MessageBox.Show(result);
                    client = new TcpClient(serverIpAddress, serverPort);
                    stream = client.GetStream();
                    return;
                }
            }
            catch { }
        }

        private void Form_CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            stream.Close();
            client.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}