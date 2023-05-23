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
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_ForgotPass = new System.Windows.Forms.Button();
            this.button_CreateAcc = new System.Windows.Forms.Button();
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 

            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox_Username.Location = new System.Drawing.Point(135, 192);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(212, 23);
            this.textBox_Username.TabIndex = 0;

            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.Location = new System.Drawing.Point(135, 270);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(212, 23);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Location = new System.Drawing.Point(169, 373);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(110, 29);
            this.button_Login.TabIndex = 2;
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_ForgotPass
            // 
            this.button_ForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.button_ForgotPass.FlatAppearance.BorderSize = 0;
            this.button_ForgotPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_ForgotPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_ForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ForgotPass.Location = new System.Drawing.Point(234, 309);
            this.button_ForgotPass.Name = "button_ForgotPass";
            this.button_ForgotPass.Size = new System.Drawing.Size(134, 20);
            this.button_ForgotPass.TabIndex = 3;
            this.button_ForgotPass.UseVisualStyleBackColor = false;
            // 
            // button_CreateAcc
            // 
            this.button_CreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.button_CreateAcc.FlatAppearance.BorderSize = 0;
            this.button_CreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_CreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateAcc.Location = new System.Drawing.Point(159, 418);
            this.button_CreateAcc.Name = "button_CreateAcc";
            this.button_CreateAcc.Size = new System.Drawing.Size(120, 27);
            this.button_CreateAcc.TabIndex = 4;
            this.button_CreateAcc.UseVisualStyleBackColor = false;
            this.button_CreateAcc.Click += new System.EventHandler(this.button_CreateAcc_Click);
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPass.Location = new System.Drawing.Point(338, 274);
            this.checkBox_ShowPass.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ShowPass.TabIndex = 6;
            this.checkBox_ShowPass.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(812, 482);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.button_CreateAcc);
            this.Controls.Add(this.button_ForgotPass);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Name = "Form_Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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