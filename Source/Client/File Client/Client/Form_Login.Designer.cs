namespace Client
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            button_Login = new Button();
            button_ForgotPass = new Button();
            button_CreateAcc = new Button();
            checkBox_ShowPass = new CheckBox();
            SuspendLayout();
            // 
            // textBox_Username
            // 
            textBox_Username.BorderStyle = BorderStyle.None;
            textBox_Username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Username.ForeColor = Color.Black;
            textBox_Username.Location = new Point(135, 192);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(212, 23);
            textBox_Username.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Password.Location = new Point(135, 270);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(212, 23);
            textBox_Password.TabIndex = 1;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.Transparent;
            button_Login.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Login.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Location = new Point(169, 373);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(110, 29);
            button_Login.TabIndex = 2;
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // button_ForgotPass
            // 
            button_ForgotPass.BackColor = Color.Transparent;
            button_ForgotPass.FlatAppearance.BorderSize = 0;
            button_ForgotPass.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_ForgotPass.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_ForgotPass.FlatStyle = FlatStyle.Flat;
            button_ForgotPass.Location = new Point(234, 309);
            button_ForgotPass.Name = "button_ForgotPass";
            button_ForgotPass.Size = new Size(134, 20);
            button_ForgotPass.TabIndex = 3;
            button_ForgotPass.UseVisualStyleBackColor = false;
            button_ForgotPass.Click += button_ForgotPass_Click;
            // 
            // button_CreateAcc
            // 
            button_CreateAcc.BackColor = Color.Transparent;
            button_CreateAcc.FlatAppearance.BorderSize = 0;
            button_CreateAcc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_CreateAcc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_CreateAcc.FlatStyle = FlatStyle.Flat;
            button_CreateAcc.Location = new Point(159, 418);
            button_CreateAcc.Name = "button_CreateAcc";
            button_CreateAcc.Size = new Size(120, 27);
            button_CreateAcc.TabIndex = 4;
            button_CreateAcc.UseVisualStyleBackColor = false;
            button_CreateAcc.Click += button_CreateAcc_Click;
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.BackColor = Color.Transparent;
            checkBox_ShowPass.FlatStyle = FlatStyle.Flat;
            checkBox_ShowPass.Location = new Point(338, 274);
            checkBox_ShowPass.Margin = new Padding(5);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(18, 17);
            checkBox_ShowPass.TabIndex = 6;
            checkBox_ShowPass.UseVisualStyleBackColor = false;
            checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
            // 
            // Form_Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(812, 482);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(button_CreateAcc);
            Controls.Add(button_ForgotPass);
            Controls.Add(button_Login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Name = "Form_Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Button button_Login;
        private Button button_ForgotPass;
        private Button button_CreateAcc;
        private CheckBox checkBox_ShowPass;
    }
}