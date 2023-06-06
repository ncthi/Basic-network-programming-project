using Microsoft.VisualBasic;
using Org.BouncyCastle.Crypto;
using RSA;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class Form_Login : Form
    {

        private const string serverIpAddress = "192.168.137.208";
        private const int serverPort = 8080;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_CreateAcc_Click(object sender, EventArgs e)
        {
            Form_CreateAccount f1 = new Form_CreateAccount();
            f1.Show();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter full information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        string data = $"{username},{password},login";
                        byte[] dataBytes = new byte[2048];
                        dataBytes = RSAKeys.EncryptData(data);
                        // Gửi thông điệp Tên và Mật khẩu đến server
                        stream.Write(dataBytes, 0, dataBytes.Length);
                        // Nhận kết quả từ server, đã tạo thành công hay chưa 
                        byte[] buffer = new byte[2048];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        if (result == "True")
                        {
                            Form_Dashboard form_Dashboard = new Form_Dashboard(username, password);
                            //ẩn forrm
                            this.Hide();
                            form_Dashboard.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("User name or password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ForgotPass_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            if (username == "")
            {
                MessageBox.Show("Please, enter user name");
                return;
            }
            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        string data = $"{username},forget";
                        byte[] dataBytes = new byte[2048];
                        dataBytes = RSAKeys.EncryptData(data);
                        // Gửi thông điệp Tên đăng nhập đến server
                        stream.Write(dataBytes, 0, dataBytes.Length);
                        // Nhận kết quả từ server, đã tạo thành công hay chưa 
                        byte[] buffer = new byte[2048];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        if (result == "True")
                        {
                            MessageBox.Show("Check email to get your new password!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Can't get your new password. Server is not responding!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error get new password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}