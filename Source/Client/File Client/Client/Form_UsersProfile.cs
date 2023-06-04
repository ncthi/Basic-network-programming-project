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
            if (textBox_CurrentPass.Visible && textBox_NewPass.Visible && button_Save.Visible && checkBox_ShowPass2.Visible && checkBox_ShowPass3.Visible && label_CurrentPass.Visible && label_NewPass.Visible)
            {
                textBox_NewPass.Visible = false;
                textBox_CurrentPass.Visible = false;
                button_Save.Visible = false;
                checkBox_ShowPass2.Visible = false;
                checkBox_ShowPass3.Visible = false;
                label_CurrentPass.Visible = false;
                label_NewPass.Visible = false;

            }
            else
            {   // Hiển thị TextBox nếu nó đang ẩn
                textBox_NewPass.Visible = true;
                textBox_CurrentPass.Visible = true;
                button_Save.Visible = true;
                checkBox_ShowPass2.Visible = true;
                checkBox_ShowPass3.Visible = true;
                label_CurrentPass.Visible = true;
                label_NewPass.Visible = true;
            }
        }
    }
}
