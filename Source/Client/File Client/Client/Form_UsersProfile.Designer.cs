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
            checkBox_ShowPass1 = new CheckBox();
            button_signout = new Button();
            button_changePassword = new Button();
            textBox_NewPass = new TextBox();
            label_CurrentPass = new Label();
            textBox_ConfirmPass = new TextBox();
            label_NewPass = new Label();
            checkBox_ShowPass3 = new CheckBox();
            button_Save = new Button();
            textBox_CurrentPass = new TextBox();
            label_Confirm = new Label();
            SuspendLayout();
            // 
            // textBox_username
            // 
            textBox_username.BackColor = Color.FromArgb(255, 239, 239);
            textBox_username.BorderStyle = BorderStyle.None;
            textBox_username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_username.ForeColor = Color.Firebrick;
            textBox_username.Location = new Point(277, 187);
            textBox_username.Name = "textBox_username";
            textBox_username.ReadOnly = true;
            textBox_username.Size = new Size(248, 19);
            textBox_username.TabIndex = 0;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(255, 239, 239);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_email.ForeColor = Color.Firebrick;
            textBox_email.Location = new Point(298, 254);
            textBox_email.Name = "textBox_email";
            textBox_email.ReadOnly = true;
            textBox_email.Size = new Size(232, 19);
            textBox_email.TabIndex = 1;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(255, 239, 239);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.Firebrick;
            textBox_password.Location = new Point(266, 325);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.ReadOnly = true;
            textBox_password.Size = new Size(234, 19);
            textBox_password.TabIndex = 2;
            // 
            // checkBox_ShowPass1
            // 
            checkBox_ShowPass1.BackColor = Color.Transparent;
            checkBox_ShowPass1.FlatStyle = FlatStyle.Flat;
            checkBox_ShowPass1.Location = new Point(517, 327);
            checkBox_ShowPass1.Margin = new Padding(5);
            checkBox_ShowPass1.Name = "checkBox_ShowPass1";
            checkBox_ShowPass1.Size = new Size(18, 17);
            checkBox_ShowPass1.TabIndex = 8;
            checkBox_ShowPass1.UseVisualStyleBackColor = false;
            // 
            // button_signout
            // 
            button_signout.BackColor = Color.Transparent;
            button_signout.FlatAppearance.BorderSize = 0;
            button_signout.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button_signout.FlatStyle = FlatStyle.Flat;
            button_signout.Location = new Point(298, 462);
            button_signout.Name = "button_signout";
            button_signout.Size = new Size(136, 41);
            button_signout.TabIndex = 9;
            button_signout.UseVisualStyleBackColor = false;
            // 
            // button_changePassword
            // 
            button_changePassword.BackColor = Color.Transparent;
            button_changePassword.FlatAppearance.BorderSize = 0;
            button_changePassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_changePassword.FlatStyle = FlatStyle.Flat;
            button_changePassword.Location = new Point(550, 325);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(62, 21);
            button_changePassword.TabIndex = 11;
            button_changePassword.UseVisualStyleBackColor = false;
            button_changePassword.Click += button_changePassword_Click;
            // 
            // textBox_NewPass
            // 
            textBox_NewPass.BackColor = Color.FromArgb(255, 239, 239);
            textBox_NewPass.Location = new Point(152, 397);
            textBox_NewPass.Multiline = true;
            textBox_NewPass.Name = "textBox_NewPass";
            textBox_NewPass.PasswordChar = '*';
            textBox_NewPass.Size = new Size(177, 29);
            textBox_NewPass.TabIndex = 12;
            textBox_NewPass.Visible = false;
            // 
            // label_CurrentPass
            // 
            label_CurrentPass.AutoSize = true;
            label_CurrentPass.BackColor = Color.FromArgb(255, 239, 239);
            label_CurrentPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_CurrentPass.ForeColor = Color.FromArgb(254, 80, 45);
            label_CurrentPass.Location = new Point(185, 325);
            label_CurrentPass.Name = "label_CurrentPass";
            label_CurrentPass.Size = new Size(102, 15);
            label_CurrentPass.TabIndex = 13;
            label_CurrentPass.Text = "Current password:";
            label_CurrentPass.Visible = false;
            // 
            // textBox_ConfirmPass
            // 
            textBox_ConfirmPass.BackColor = Color.FromArgb(255, 239, 239);
            textBox_ConfirmPass.Location = new Point(354, 398);
            textBox_ConfirmPass.Multiline = true;
            textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            textBox_ConfirmPass.PasswordChar = '*';
            textBox_ConfirmPass.Size = new Size(158, 28);
            textBox_ConfirmPass.TabIndex = 14;
            textBox_ConfirmPass.Visible = false;
            // 
            // label_NewPass
            // 
            label_NewPass.AutoSize = true;
            label_NewPass.BackColor = Color.Transparent;
            label_NewPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_NewPass.ForeColor = Color.FromArgb(254, 80, 45);
            label_NewPass.Location = new Point(152, 369);
            label_NewPass.Name = "label_NewPass";
            label_NewPass.Size = new Size(84, 15);
            label_NewPass.TabIndex = 15;
            label_NewPass.Text = "New password";
            label_NewPass.Visible = false;
            // 
            // checkBox_ShowPass3
            // 
            checkBox_ShowPass3.AutoSize = true;
            checkBox_ShowPass3.BackColor = Color.Transparent;
            checkBox_ShowPass3.FlatStyle = FlatStyle.Flat;
            checkBox_ShowPass3.Location = new Point(518, 405);
            checkBox_ShowPass3.Name = "checkBox_ShowPass3";
            checkBox_ShowPass3.Size = new Size(12, 11);
            checkBox_ShowPass3.TabIndex = 17;
            checkBox_ShowPass3.UseVisualStyleBackColor = false;
            checkBox_ShowPass3.Visible = false;
            // 
            // button_Save
            // 
            button_Save.BackColor = Color.FromArgb(254, 80, 45);
            button_Save.FlatAppearance.BorderSize = 0;
            button_Save.FlatStyle = FlatStyle.Flat;
            button_Save.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Save.ForeColor = Color.White;
            button_Save.Location = new Point(297, 462);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(125, 41);
            button_Save.TabIndex = 18;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = false;
            button_Save.Visible = false;
            button_Save.Click += button_Save_Click;
            // 
            // textBox_CurrentPass
            // 
            textBox_CurrentPass.BackColor = Color.FromArgb(255, 239, 239);
            textBox_CurrentPass.BorderStyle = BorderStyle.None;
            textBox_CurrentPass.Location = new Point(318, 325);
            textBox_CurrentPass.Name = "textBox_CurrentPass";
            textBox_CurrentPass.PasswordChar = '*';
            textBox_CurrentPass.Size = new Size(195, 16);
            textBox_CurrentPass.TabIndex = 19;
            // 
            // label_Confirm
            // 
            label_Confirm.AutoSize = true;
            label_Confirm.BackColor = Color.Transparent;
            label_Confirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Confirm.ForeColor = Color.FromArgb(254, 80, 45);
            label_Confirm.Location = new Point(356, 372);
            label_Confirm.Name = "label_Confirm";
            label_Confirm.Size = new Size(103, 15);
            label_Confirm.TabIndex = 20;
            label_Confirm.Text = "Confirm password";
            label_Confirm.Visible = false;
            // 
            // Form_UsersProfile
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 543);
            Controls.Add(label_Confirm);
            Controls.Add(textBox_CurrentPass);
            Controls.Add(button_Save);
            Controls.Add(checkBox_ShowPass3);
            Controls.Add(label_NewPass);
            Controls.Add(textBox_ConfirmPass);
            Controls.Add(label_CurrentPass);
            Controls.Add(textBox_NewPass);
            Controls.Add(button_changePassword);
            Controls.Add(button_signout);
            Controls.Add(checkBox_ShowPass1);
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
        private CheckBox checkBox_ShowPass1;
        private Button button_signout;
        private Button button_changePassword;
        private TextBox textBox_NewPass;
        private Label label_CurrentPass;
        private TextBox textBox_ConfirmPass;
        private Label label_NewPass;
        private CheckBox checkBox_ShowPass3;
        private Button button_Save;
        private TextBox textBox_CurrentPass;
        private Label label_Confirm;
    }
}