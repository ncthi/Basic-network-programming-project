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
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.button_signout = new System.Windows.Forms.Button();
            this.button_changeEmail = new System.Windows.Forms.Button();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_username.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_username.Location = new System.Drawing.Point(306, 236);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.ReadOnly = true;
            this.textBox_username.Size = new System.Drawing.Size(259, 23);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_email.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_email.Location = new System.Drawing.Point(326, 292);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(239, 23);
            this.textBox_email.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox_password.Location = new System.Drawing.Point(295, 349);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.ReadOnly = true;
            this.textBox_password.Size = new System.Drawing.Size(256, 23);
            this.textBox_password.TabIndex = 2;
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPass.Location = new System.Drawing.Point(557, 353);
            this.checkBox_ShowPass.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ShowPass.TabIndex = 8;
            this.checkBox_ShowPass.UseVisualStyleBackColor = false;
            // 
            // button_signout
            // 
            this.button_signout.BackColor = System.Drawing.Color.Transparent;
            this.button_signout.FlatAppearance.BorderSize = 0;
            this.button_signout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signout.Location = new System.Drawing.Point(339, 421);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(137, 41);
            this.button_signout.TabIndex = 9;
            this.button_signout.UseVisualStyleBackColor = false;
            // 
            // button_changeEmail
            // 
            this.button_changeEmail.BackColor = System.Drawing.Color.Transparent;
            this.button_changeEmail.FlatAppearance.BorderSize = 0;
            this.button_changeEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_changeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changeEmail.Location = new System.Drawing.Point(593, 293);
            this.button_changeEmail.Name = "button_changeEmail";
            this.button_changeEmail.Size = new System.Drawing.Size(62, 24);
            this.button_changeEmail.TabIndex = 10;
            this.button_changeEmail.UseVisualStyleBackColor = false;
            // 
            // button_changePassword
            // 
            this.button_changePassword.BackColor = System.Drawing.Color.Transparent;
            this.button_changePassword.FlatAppearance.BorderSize = 0;
            this.button_changePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changePassword.Location = new System.Drawing.Point(594, 352);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(62, 21);
            this.button_changePassword.TabIndex = 11;
            this.button_changePassword.UseVisualStyleBackColor = false;
            // 
            // Form_UsersProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 496);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.button_changeEmail);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.checkBox_ShowPass);
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
        private CheckBox checkBox_ShowPass;
        private Button button_signout;
        private Button button_changeEmail;
        private Button button_changePassword;
    }
}