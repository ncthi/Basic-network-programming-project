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
            textBox_CreateUser = new TextBox();
            textBox_Email = new TextBox();
            textBox_CreatePass = new TextBox();
            textBox_ConfirmPass = new TextBox();
            button_CreateAcc = new Button();
            button_Home = new Button();
            checkBox_ShowPass = new CheckBox();
            textBox_VerCode = new TextBox();
            label_EnterCode = new Label();
            button_Verify = new Button();
            SuspendLayout();
            // 
            // textBox_CreateUser
            // 
            textBox_CreateUser.BorderStyle = BorderStyle.None;
            textBox_CreateUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_CreateUser.ForeColor = Color.Black;
            textBox_CreateUser.Location = new Point(472, 118);
            textBox_CreateUser.Name = "textBox_CreateUser";
            textBox_CreateUser.Size = new Size(251, 23);
            textBox_CreateUser.TabIndex = 0;
            // 
            // textBox_Email
            // 
            textBox_Email.BorderStyle = BorderStyle.None;
            textBox_Email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Email.Location = new Point(472, 200);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(251, 23);
            textBox_Email.TabIndex = 1;
            // 
            // textBox_CreatePass
            // 
            textBox_CreatePass.BorderStyle = BorderStyle.None;
            textBox_CreatePass.Location = new Point(466, 288);
            textBox_CreatePass.Name = "textBox_CreatePass";
            textBox_CreatePass.Size = new Size(110, 20);
            textBox_CreatePass.TabIndex = 2;
            textBox_CreatePass.UseSystemPasswordChar = true;
            // 
            // textBox_ConfirmPass
            // 
            textBox_ConfirmPass.BorderStyle = BorderStyle.None;
            textBox_ConfirmPass.Location = new Point(611, 288);
            textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            textBox_ConfirmPass.Size = new Size(112, 20);
            textBox_ConfirmPass.TabIndex = 3;
            textBox_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // button_CreateAcc
            // 
            button_CreateAcc.BackColor = Color.FromArgb(254, 80, 45);
            button_CreateAcc.FlatAppearance.BorderSize = 0;
            button_CreateAcc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_CreateAcc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_CreateAcc.FlatStyle = FlatStyle.Flat;
            button_CreateAcc.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_CreateAcc.ForeColor = Color.FromArgb(224, 224, 224);
            button_CreateAcc.Location = new Point(66, 75);
            button_CreateAcc.Name = "button_CreateAcc";
            button_CreateAcc.Size = new Size(275, 41);
            button_CreateAcc.TabIndex = 4;
            button_CreateAcc.Text = "Create";
            button_CreateAcc.UseVisualStyleBackColor = false;
            button_CreateAcc.Visible = false;
            button_CreateAcc.Click += button_CreateAcc_Click;
            // 
            // button_Home
            // 
            button_Home.BackColor = Color.Transparent;
            button_Home.FlatAppearance.BorderSize = 0;
            button_Home.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Home.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Home.FlatStyle = FlatStyle.Flat;
            button_Home.Location = new Point(12, 21);
            button_Home.Name = "button_Home";
            button_Home.Size = new Size(58, 29);
            button_Home.TabIndex = 5;
            button_Home.UseVisualStyleBackColor = false;
            button_Home.Click += button_Home_Click;
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.BackColor = Color.Transparent;
            checkBox_ShowPass.FlatStyle = FlatStyle.Flat;
            checkBox_ShowPass.Location = new Point(716, 288);
            checkBox_ShowPass.Margin = new Padding(5);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(18, 17);
            checkBox_ShowPass.TabIndex = 7;
            checkBox_ShowPass.UseVisualStyleBackColor = false;
            checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
            // 
            // textBox_VerCode
            // 
            textBox_VerCode.Location = new Point(439, 354);
            textBox_VerCode.Multiline = true;
            textBox_VerCode.Name = "textBox_VerCode";
            textBox_VerCode.Size = new Size(295, 38);
            textBox_VerCode.TabIndex = 8;
            textBox_VerCode.Visible = false;
            // 
            // label_EnterCode
            // 
            label_EnterCode.AutoSize = true;
            label_EnterCode.BackColor = Color.Transparent;
            label_EnterCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_EnterCode.ForeColor = Color.FromArgb(254, 80, 45);
            label_EnterCode.Location = new Point(439, 331);
            label_EnterCode.Name = "label_EnterCode";
            label_EnterCode.Size = new Size(163, 20);
            label_EnterCode.TabIndex = 9;
            label_EnterCode.Text = "Enter verification code\n";
            label_EnterCode.Visible = false;
            // 
            // button_Verify
            // 
            button_Verify.BackColor = Color.Transparent;
            button_Verify.FlatAppearance.BorderSize = 0;
            button_Verify.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Verify.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Verify.FlatStyle = FlatStyle.Flat;
            button_Verify.Location = new Point(444, 413);
            button_Verify.Name = "button_Verify";
            button_Verify.Size = new Size(267, 29);
            button_Verify.TabIndex = 10;
            button_Verify.UseVisualStyleBackColor = false;
            button_Verify.Click += button_Verify_Click;
            // 
            // Form_CreateAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 492);
            Controls.Add(button_Verify);
            Controls.Add(label_EnterCode);
            Controls.Add(textBox_VerCode);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(button_Home);
            Controls.Add(button_CreateAcc);
            Controls.Add(textBox_ConfirmPass);
            Controls.Add(textBox_CreatePass);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_CreateUser);
            Name = "Form_CreateAccount";
            Text = "Form_CreateAccount";
            ResumeLayout(false);
            PerformLayout();
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
    }
}