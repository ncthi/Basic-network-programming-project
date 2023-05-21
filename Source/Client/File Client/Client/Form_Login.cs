using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Form_Login : Form
    {

        private const string serverIpAddress = "127.0.0.1";
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

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            // Kiểm tra thông tin nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đẩy đủ tài khoản và mật khẩu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] info = Encoding.ASCII.GetBytes(username + ',' + password+",login");

                        // Gửi thông điệp Tên và Mật khẩu đến server
                        stream.Write(info, 0, info.Length);

                        // Nhận kết quả từ server, đã tạo thành công hay chưa 
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string result = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        if (result == "True")
                        {
                            MessageBox.Show("Đăng nhập thành công.");
                            Form_FileManager form_FileManager = new Form_FileManager();
                            //ẩn forrm
                            this.Hide();
                            form_FileManager.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}