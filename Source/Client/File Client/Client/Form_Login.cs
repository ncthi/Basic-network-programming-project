namespace Client
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_CreateAcc_Click(object sender, EventArgs e)
        {
            Form_CreateAccount f1 = new Form_CreateAccount();
            f1.ShowDialog();
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