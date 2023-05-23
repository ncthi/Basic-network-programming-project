namespace Client
{
    partial class Form_CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateAccount));
            this.textBox_CreateUser = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_CreatePass = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.button_CreateAcc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_CreateUser
            // 
            this.textBox_CreateUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_CreateUser.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBox_CreateUser.Location = new System.Drawing.Point(472, 148);
            this.textBox_CreateUser.Name = "textBox_CreateUser";
            this.textBox_CreateUser.Size = new System.Drawing.Size(251, 23);
            this.textBox_CreateUser.TabIndex = 0;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Email.Location = new System.Drawing.Point(448, 233);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(275, 20);
            this.textBox_Email.TabIndex = 1;
            // 
            // textBox_CreatePass
            // 
            this.textBox_CreatePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreatePass.Location = new System.Drawing.Point(445, 326);
            this.textBox_CreatePass.Name = "textBox_CreatePass";
            this.textBox_CreatePass.Size = new System.Drawing.Size(126, 20);
            this.textBox_CreatePass.TabIndex = 2;
            this.textBox_CreatePass.UseSystemPasswordChar = true;
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(611, 326);
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(112, 20);
            this.textBox_ConfirmPass.TabIndex = 3;
            this.textBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // button_CreateAcc
            // 
            this.button_CreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.button_CreateAcc.FlatAppearance.BorderSize = 0;
            this.button_CreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_CreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateAcc.Location = new System.Drawing.Point(448, 414);
            this.button_CreateAcc.Name = "button_CreateAcc";
            this.button_CreateAcc.Size = new System.Drawing.Size(275, 29);
            this.button_CreateAcc.TabIndex = 4;
            this.button_CreateAcc.UseVisualStyleBackColor = false;
            this.button_CreateAcc.Click += new System.EventHandler(this.button_CreateAcc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 29);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPass.Location = new System.Drawing.Point(556, 327);
            this.checkBox_ShowPass.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ShowPass.TabIndex = 7;
            this.checkBox_ShowPass.UseVisualStyleBackColor = false;
            this.checkBox_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox_ShowPass_CheckedChanged);
            // 
            // Form_CreateAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_CreateAcc);
            this.Controls.Add(this.textBox_ConfirmPass);
            this.Controls.Add(this.textBox_CreatePass);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_CreateUser);
            this.Name = "Form_CreateAccount";
            this.Text = "Form_CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_CreateUser;
        private TextBox textBox_Email;
        private TextBox textBox_CreatePass;
        private TextBox textBox_ConfirmPass;
        private Button button_CreateAcc;
        private Button button1;
        private CheckBox checkBox_ShowPass;
    }
}