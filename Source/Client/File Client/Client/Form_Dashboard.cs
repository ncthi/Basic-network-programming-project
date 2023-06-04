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
        string user;
        string pass;
        public Form_Dashboard(string userName, string password)
        {
            InitializeComponent();
            user = userName;
            pass = password;
        }

        private Form currentFormChild;

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
            OpenChildForm(new Form_UsersProfile());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_FileManager(user,pass));
        }

    }
}
