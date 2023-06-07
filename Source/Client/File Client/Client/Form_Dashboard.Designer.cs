namespace Client
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            panel_Left = new Panel();
            button_AboutUs = new Button();
            button_Logout = new Button();
            button_Filemanage = new Button();
            button_MyProfile = new Button();
            panel_Body = new FlowLayoutPanel();
            panel_Left.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = Color.Transparent;
            panel_Left.Controls.Add(button_AboutUs);
            panel_Left.Controls.Add(button_Logout);
            panel_Left.Controls.Add(button_Filemanage);
            panel_Left.Controls.Add(button_MyProfile);
            panel_Left.Location = new Point(0, -3);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(205, 539);
            panel_Left.TabIndex = 0;
            // 
            // button_AboutUs
            // 
            button_AboutUs.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button_AboutUs.FlatAppearance.BorderSize = 0;
            button_AboutUs.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_AboutUs.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_AboutUs.FlatStyle = FlatStyle.Flat;
            button_AboutUs.Location = new Point(38, 285);
            button_AboutUs.Name = "button_AboutUs";
            button_AboutUs.Size = new Size(138, 29);
            button_AboutUs.TabIndex = 5;
            button_AboutUs.UseVisualStyleBackColor = true;
            button_AboutUs.Click += button_AboutUs_Click;
            // 
            // button_Logout
            // 
            button_Logout.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button_Logout.FlatAppearance.BorderSize = 0;
            button_Logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Logout.FlatStyle = FlatStyle.Flat;
            button_Logout.Location = new Point(31, 356);
            button_Logout.Name = "button_Logout";
            button_Logout.Size = new Size(145, 29);
            button_Logout.TabIndex = 4;
            button_Logout.UseVisualStyleBackColor = true;
            button_Logout.Click += button_Logout_Click;
            // 
            // button_Filemanage
            // 
            button_Filemanage.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button_Filemanage.FlatAppearance.BorderSize = 0;
            button_Filemanage.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Filemanage.FlatStyle = FlatStyle.Flat;
            button_Filemanage.Location = new Point(31, 207);
            button_Filemanage.Name = "button_Filemanage";
            button_Filemanage.Size = new Size(145, 37);
            button_Filemanage.TabIndex = 1;
            button_Filemanage.UseVisualStyleBackColor = true;
            button_Filemanage.Click += button_Filemanage_Click;
            // 
            // button_MyProfile
            // 
            button_MyProfile.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button_MyProfile.FlatAppearance.BorderSize = 0;
            button_MyProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_MyProfile.FlatStyle = FlatStyle.Flat;
            button_MyProfile.Location = new Point(36, 132);
            button_MyProfile.Name = "button_MyProfile";
            button_MyProfile.Size = new Size(140, 38);
            button_MyProfile.TabIndex = 0;
            button_MyProfile.UseVisualStyleBackColor = true;
            button_MyProfile.Click += button_MyProfile_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Transparent;
            panel_Body.Location = new Point(203, -3);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(728, 539);
            panel_Body.TabIndex = 1;
            // 
            // Form_Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(933, 528);
            Controls.Add(panel_Body);
            Controls.Add(panel_Left);
            Name = "Form_Dashboard";
            Text = "Form_Dashboard";
            panel_Left.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Left;
        private Button button_Filemanage;
        private Button button_MyProfile;
        private FlowLayoutPanel panel_Body;
        private Button button_Logout;
        private Button button_AboutUs;
    }
}