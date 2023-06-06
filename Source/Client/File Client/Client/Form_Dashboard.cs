using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Client
{
    public partial class Form_Dashboard : Form
    {
        private static string user;
        private static string pass;
        public Form_Dashboard(string userName, string password)
        {
            user = userName;
            pass = password;
            InitializeComponent();
            OpenChildForm(new Form_FileManager(user, pass));
        }

        private Form currentFormChild;

        public static string Pass { set => pass = value; }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = panel_Body.Size;
            childForm.Location = new Point(0, 0);
            panel_Body.Controls.Add(childForm);
            childForm.Show();
        }

        private void button_MyProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_UsersProfile(user, pass));

        }

        private void button_Filemanage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_FileManager(user, pass));
        }
        private void button_Logout_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            this.Hide();
            form_Login.ShowDialog();
            this.Close();
        }

        private void button_AboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_AboutUs());
        }
    }
}
