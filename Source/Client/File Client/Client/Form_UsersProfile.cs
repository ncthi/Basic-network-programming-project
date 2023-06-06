using RSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class Form_UsersProfile : Form
    {
        private const string serverIpAddress = "127.0.0.1";
        private const int serverPort = 8080;
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Form_UsersProfile(string username, string password)
        {
            InitializeComponent();
            UserName = username;
            Password = password;
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
        private void button_changePassword_Click(object sender, EventArgs e)
        {
            if (textBox_NewPass.Visible && textBox_ConfirmPass.Visible && button_Save.Visible && checkBox_ShowPass3.Visible && label_CurrentPass.Visible && label_NewPass.Visible && textBox_ConfirmPass.Visible && label_Confirm.Visible)
            {
                textBox_ConfirmPass.Visible = false;
                textBox_NewPass.Visible = false;
                button_Save.Visible = false;
                checkBox_ShowPass3.Visible = false;
                label_CurrentPass.Visible = false;
                label_NewPass.Visible = false;
                textBox_ConfirmPass.Visible = false;
                label_Confirm.Visible = false;

            }
            else
            {   // Hiển thị TextBox nếu nó đang ẩn
                textBox_ConfirmPass.Visible = true;
                textBox_NewPass.Visible = true;
                button_Save.Visible = true;
                checkBox_ShowPass3.Visible = true;
                label_CurrentPass.Visible = true;
                label_NewPass.Visible = true;
                textBox_ConfirmPass.Visible = true;
                label_Confirm.Visible = true;

            }
        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            Form_Dashboard formDashboard = (Form_Dashboard)this.ParentForm;
            formDashboard.Hide();
            form_Login.ShowDialog();
            formDashboard.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string password = textBox_CurrentPass.Text;
            string confirm = textBox_ConfirmPass.Text;
            string newPass = textBox_NewPass.Text;
            if (string.IsNullOrEmpty(newPass) || newPass.Length < 6)
            {
                MessageBox.Show("Please enter valid password. Password must contain at least 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (confirm != newPass)
                {
                    MessageBox.Show("Password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                using (TcpClient client = new TcpClient(serverIpAddress, serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        // Mã hóa mật khẩu bằng khóa công khai RSA
                        string data = $"{UserName},{Password},{newPass},changePass";
                        byte[] dataBytes = RSAKeys.EncryptData(data);

                        // Gửi thông điệp Tên và Mật khẩu đến server
                        stream.Write(dataBytes, 0, dataBytes.Length);

                        // Nhận kết quả từ server, đã đổi mật khẩu thành công hay chưa
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        if (result == "True")
                        {
                            MessageBox.Show("Successfully changed password!");
                            Form_Dashboard.Pass = newPass;
                            this.Close();
                        }
                        else MessageBox.Show("You can not change password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error change password: {ex.Message}");
            }
        }
    }
}
