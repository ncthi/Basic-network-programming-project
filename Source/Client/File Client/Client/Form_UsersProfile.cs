using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form_UsersProfile : Form
    {
        public Form_UsersProfile()
        {
            InitializeComponent();
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

        private void checkBox_ShowPass3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass3.Checked)
            {
                textBox_NewPass.UseSystemPasswordChar = false;
                textBox_ConfirmPass.UseSystemPasswordChar = false;

            }
            else
            {
                textBox_NewPass.UseSystemPasswordChar = true;
                textBox_ConfirmPass.UseSystemPasswordChar = true;

            }
        }

        private void checkBox_ShowPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass1.Checked)
            {
                textBox_CurrentPass.UseSystemPasswordChar = false;

            }
            else
            {
                textBox_CurrentPass.UseSystemPasswordChar = true;
            }
        }
    }
}
