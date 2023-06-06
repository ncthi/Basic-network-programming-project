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
            this.button_Home = new System.Windows.Forms.Button();
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.textBox_VerCode = new System.Windows.Forms.TextBox();
            this.label_EnterCode = new System.Windows.Forms.Label();
            this.button_Verify = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CreateUser
            // 
            this.textBox_CreateUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_CreateUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_CreateUser.ForeColor = System.Drawing.Color.Black;
            this.textBox_CreateUser.Location = new System.Drawing.Point(472, 118);
            this.textBox_CreateUser.Name = "textBox_CreateUser";
            this.textBox_CreateUser.Size = new System.Drawing.Size(251, 23);
            this.textBox_CreateUser.TabIndex = 0;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Email.Location = new System.Drawing.Point(472, 200);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(251, 23);
            this.textBox_Email.TabIndex = 1;
            // 
            // textBox_CreatePass
            // 
            this.textBox_CreatePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_CreatePass.Location = new System.Drawing.Point(466, 287);
            this.textBox_CreatePass.Name = "textBox_CreatePass";
            this.textBox_CreatePass.Size = new System.Drawing.Size(110, 20);
            this.textBox_CreatePass.TabIndex = 2;
            this.textBox_CreatePass.UseSystemPasswordChar = true;
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(611, 286);
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(112, 20);
            this.textBox_ConfirmPass.TabIndex = 3;
            this.textBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // button_CreateAcc
            // 
            this.button_CreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.button_CreateAcc.FlatAppearance.BorderSize = 0;
            this.button_CreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.button_CreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.button_CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateAcc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CreateAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_CreateAcc.Location = new System.Drawing.Point(448, 404);
            this.button_CreateAcc.Name = "button_CreateAcc";
            this.button_CreateAcc.Size = new System.Drawing.Size(275, 46);
            this.button_CreateAcc.TabIndex = 4;
            this.button_CreateAcc.Text = "Create";
            this.button_CreateAcc.UseVisualStyleBackColor = false;
            this.button_CreateAcc.Visible = false;
            this.button_CreateAcc.Click += new System.EventHandler(this.button_CreateAcc_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackColor = System.Drawing.Color.Transparent;
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Location = new System.Drawing.Point(12, 21);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 29);
            this.button_Home.TabIndex = 5;
            this.button_Home.UseVisualStyleBackColor = false;
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPass.Location = new System.Drawing.Point(716, 288);
            this.checkBox_ShowPass.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ShowPass.TabIndex = 7;
            this.checkBox_ShowPass.UseVisualStyleBackColor = false;
            this.checkBox_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox_ShowPass_CheckedChanged);
            // 
            // textBox_VerCode
            // 
            this.textBox_VerCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_VerCode.Location = new System.Drawing.Point(435, 354);
            this.textBox_VerCode.Multiline = true;
            this.textBox_VerCode.Name = "textBox_VerCode";
            this.textBox_VerCode.Size = new System.Drawing.Size(295, 36);
            this.textBox_VerCode.TabIndex = 8;
            this.textBox_VerCode.Visible = false;
            // 
            // label_EnterCode
            // 
            this.label_EnterCode.AutoSize = true;
            this.label_EnterCode.BackColor = System.Drawing.Color.Transparent;
            this.label_EnterCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_EnterCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.label_EnterCode.Location = new System.Drawing.Point(439, 331);
            this.label_EnterCode.Name = "label_EnterCode";
            this.label_EnterCode.Size = new System.Drawing.Size(163, 20);
            this.label_EnterCode.TabIndex = 9;
            this.label_EnterCode.Text = "Enter verification code\n";
            this.label_EnterCode.Visible = false;
            // 
            // button_Verify
            // 
            this.button_Verify.BackColor = System.Drawing.Color.Transparent;
            this.button_Verify.FlatAppearance.BorderSize = 0;
            this.button_Verify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Verify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Verify.Location = new System.Drawing.Point(450, 405);
            this.button_Verify.Name = "button_Verify";
            this.button_Verify.Size = new System.Drawing.Size(267, 45);
            this.button_Verify.TabIndex = 10;
            this.button_Verify.UseVisualStyleBackColor = false;
            this.button_Verify.Click += new System.EventHandler(this.button_Verify_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(72, 20);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(26, 33);
            this.button_back.TabIndex = 11;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_CreateAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Verify);
            this.Controls.Add(this.label_EnterCode);
            this.Controls.Add(this.textBox_VerCode);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.button_Home);
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
        private Button button_Home;
        private CheckBox checkBox_ShowPass;
        private TextBox textBox_VerCode;
        private Label label_EnterCode;
        private Button button_Verify;
        private Button button_back;
    }
}