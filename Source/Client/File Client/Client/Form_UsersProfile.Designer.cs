namespace Client
{
    partial class Form_UsersProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UsersProfile));
            textBox_username = new TextBox();
            textBox_email = new TextBox();
            textBox_password = new TextBox();
            checkBox_ShowPass = new CheckBox();
            button_signout = new Button();
            button_changeEmail = new Button();
            button_changePassword = new Button();
            SuspendLayout();
            // 
            // textBox_username
            // 
            textBox_username.BackColor = Color.FromArgb(255, 239, 239);
            textBox_username.BorderStyle = BorderStyle.None;
            textBox_username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_username.ForeColor = Color.Firebrick;
            textBox_username.Location = new Point(271, 244);
            textBox_username.Name = "textBox_username";
            textBox_username.ReadOnly = true;
            textBox_username.Size = new Size(259, 23);
            textBox_username.TabIndex = 0;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(255, 239, 239);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_email.ForeColor = Color.Firebrick;
            textBox_email.Location = new Point(298, 302);
            textBox_email.Name = "textBox_email";
            textBox_email.ReadOnly = true;
            textBox_email.Size = new Size(232, 23);
            textBox_email.TabIndex = 1;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(255, 239, 239);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.Firebrick;
            textBox_password.Location = new Point(269, 360);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.ReadOnly = true;
            textBox_password.Size = new Size(234, 23);
            textBox_password.TabIndex = 2;
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.BackColor = Color.Transparent;
            checkBox_ShowPass.FlatStyle = FlatStyle.Flat;
            checkBox_ShowPass.Location = new Point(502, 366);
            checkBox_ShowPass.Margin = new Padding(5);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(18, 17);
            checkBox_ShowPass.TabIndex = 8;
            checkBox_ShowPass.UseVisualStyleBackColor = false;
            // 
            // button_signout
            // 
            button_signout.BackColor = Color.Transparent;
            button_signout.FlatAppearance.BorderSize = 0;
            button_signout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button_signout.FlatStyle = FlatStyle.Flat;
            button_signout.Location = new Point(298, 434);
            button_signout.Name = "button_signout";
            button_signout.Size = new Size(137, 41);
            button_signout.TabIndex = 9;
            button_signout.UseVisualStyleBackColor = false;
            // 
            // button_changeEmail
            // 
            button_changeEmail.BackColor = Color.Transparent;
            button_changeEmail.FlatAppearance.BorderSize = 0;
            button_changeEmail.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button_changeEmail.FlatStyle = FlatStyle.Flat;
            button_changeEmail.Location = new Point(549, 303);
            button_changeEmail.Name = "button_changeEmail";
            button_changeEmail.Size = new Size(62, 24);
            button_changeEmail.TabIndex = 10;
            button_changeEmail.UseVisualStyleBackColor = false;
            // 
            // button_changePassword
            // 
            button_changePassword.BackColor = Color.Transparent;
            button_changePassword.FlatAppearance.BorderSize = 0;
            button_changePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button_changePassword.FlatStyle = FlatStyle.Flat;
            button_changePassword.Location = new Point(550, 362);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(62, 21);
            button_changePassword.TabIndex = 11;
            button_changePassword.UseVisualStyleBackColor = false;
            // 
            // Form_UsersProfile
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 543);
            Controls.Add(button_changePassword);
            Controls.Add(button_changeEmail);
            Controls.Add(button_signout);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(textBox_password);
            Controls.Add(textBox_email);
            Controls.Add(textBox_username);
            Name = "Form_UsersProfile";
            Text = "Form_UsersProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_username;
        private TextBox textBox_email;
        private TextBox textBox_password;
        private CheckBox checkBox_ShowPass;
        private Button button_signout;
        private Button button_changeEmail;
        private Button button_changePassword;
    }
}