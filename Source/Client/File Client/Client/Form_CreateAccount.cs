using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
            
            //Kiểm tra thông tin nhập vào 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] usernameBytes = Encoding.ASCII.GetBytes(username);
                        byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

                        // Gửi thông điệp Tên và Mật khẩu đến server
                        stream.Write(usernameBytes, 0, usernameBytes.Length);
                        stream.Write(passwordBytes, 0, passwordBytes.Length);

                        // Nhận kết quả từ server, đã tạo thành công hay chưa 
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string result = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        MessageBox.Show(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo tài khoản: {ex.Message}");
            }
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
