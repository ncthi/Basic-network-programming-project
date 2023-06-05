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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_ShowPass1 = new System.Windows.Forms.CheckBox();
            this.button_signout = new System.Windows.Forms.Button();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.label_CurrentPass = new System.Windows.Forms.Label();
            this.textBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.label_NewPass = new System.Windows.Forms.Label();
            this.checkBox_ShowPass3 = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_CurrentPass = new System.Windows.Forms.TextBox();
            this.label_Confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_username.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_username.Location = new System.Drawing.Point(277, 187);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.ReadOnly = true;
            this.textBox_username.Size = new System.Drawing.Size(248, 23);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_email.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_email.Location = new System.Drawing.Point(298, 254);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(232, 23);
            this.textBox_email.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_password.Location = new System.Drawing.Point(266, 325);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.ReadOnly = true;
            this.textBox_password.Size = new System.Drawing.Size(234, 23);
            this.textBox_password.TabIndex = 2;
            // 
            // checkBox_ShowPass1
            // 
            this.checkBox_ShowPass1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPass1.Location = new System.Drawing.Point(517, 327);
            this.checkBox_ShowPass1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_ShowPass1.Name = "checkBox_ShowPass1";
            this.checkBox_ShowPass1.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ShowPass1.TabIndex = 8;
            this.checkBox_ShowPass1.UseVisualStyleBackColor = false;
            // 
            // button_signout
            // 
            this.button_signout.BackColor = System.Drawing.Color.Transparent;
            this.button_signout.FlatAppearance.BorderSize = 0;
            this.button_signout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signout.Location = new System.Drawing.Point(298, 462);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(136, 41);
            this.button_signout.TabIndex = 9;
            this.button_signout.UseVisualStyleBackColor = false;
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.Color.Transparent;
            this.button_changePassword.FlatAppearance.BorderSize = 0;
            this.button_changePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changePassword.Location = new System.Drawing.Point(550, 325);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(62, 21);
            this.button_changePassword.TabIndex = 11;
            this.button_changePassword.UseVisualStyleBackColor = false;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_NewPass.Location = new System.Drawing.Point(152, 397);
            this.textBox_NewPass.Multiline = true;
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.PasswordChar = '*';
            this.textBox_NewPass.Size = new System.Drawing.Size(177, 29);
            this.textBox_NewPass.TabIndex = 12;
            this.textBox_NewPass.Visible = false;
            // 
            // label_CurrentPass
            // 
            this.label_CurrentPass.AutoSize = true;
            this.label_CurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label_CurrentPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.label_CurrentPass.Location = new System.Drawing.Point(185, 325);
            this.label_CurrentPass.Name = "label_CurrentPass";
            this.label_CurrentPass.Size = new System.Drawing.Size(133, 20);
            this.label_CurrentPass.TabIndex = 13;
            this.label_CurrentPass.Text = "Current password:";
            this.label_CurrentPass.Visible = false;
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(354, 398);
            this.textBox_ConfirmPass.Multiline = true;
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.PasswordChar = '*';
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(158, 28);
            this.textBox_ConfirmPass.TabIndex = 14;
            this.textBox_ConfirmPass.Visible = false;
            // 
            // label_NewPass
            // 
            this.label_NewPass.AutoSize = true;
            this.label_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.label_NewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_NewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.label_NewPass.Location = new System.Drawing.Point(152, 369);
            this.label_NewPass.Name = "label_NewPass";
            this.label_NewPass.Size = new System.Drawing.Size(108, 20);
            this.label_NewPass.TabIndex = 15;
            this.label_NewPass.Text = "New password";
            this.label_NewPass.Visible = false;
            // 
            // checkBox_ShowPass3
            // 
            this.checkBox_ShowPass3.AutoSize = true;
            this.checkBox_ShowPass3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPass3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPass3.Location = new System.Drawing.Point(518, 405);
            this.checkBox_ShowPass3.Name = "checkBox_ShowPass3";
            this.checkBox_ShowPass3.Size = new System.Drawing.Size(14, 13);
            this.checkBox_ShowPass3.TabIndex = 17;
            this.checkBox_ShowPass3.UseVisualStyleBackColor = false;
            this.checkBox_ShowPass3.Visible = false;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(297, 462);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(125, 41);
            this.button_Save.TabIndex = 18;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Visible = false;
            // 
            // textBox_CurrentPass
            // 
            this.textBox_CurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_CurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CurrentPass.Location = new System.Drawing.Point(318, 325);
            this.textBox_CurrentPass.Name = "textBox_CurrentPass";
            this.textBox_CurrentPass.PasswordChar = '*';
            this.textBox_CurrentPass.Size = new System.Drawing.Size(195, 20);
            this.textBox_CurrentPass.TabIndex = 19;
            // 
            // label_Confirm
            // 
            this.label_Confirm.AutoSize = true;
            this.label_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.label_Confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.label_Confirm.Location = new System.Drawing.Point(356, 372);
            this.label_Confirm.Name = "label_Confirm";
            this.label_Confirm.Size = new System.Drawing.Size(132, 20);
            this.label_Confirm.TabIndex = 20;
            this.label_Confirm.Text = "Confirm password";
            this.label_Confirm.Visible = false;
            // 
            // Form_UsersProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 543);
            this.Controls.Add(this.label_Confirm);
            this.Controls.Add(this.textBox_CurrentPass);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_ShowPass3);
            this.Controls.Add(this.label_NewPass);
            this.Controls.Add(this.textBox_ConfirmPass);
            this.Controls.Add(this.label_CurrentPass);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.checkBox_ShowPass1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_username);
            this.Name = "Form_UsersProfile";
            this.Text = "Form_UsersProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

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