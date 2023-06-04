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
            button3 = new Button();
            button2 = new Button();
            button_Filemanage = new Button();
            button_MyProfile = new Button();
            panel_Body = new FlowLayoutPanel();
            button_Logout = new Button();
            panel_Left.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = Color.Transparent;
            panel_Left.Controls.Add(button_Logout);
            panel_Left.Controls.Add(button3);
            panel_Left.Controls.Add(button2);
            panel_Left.Controls.Add(button_Filemanage);
            panel_Left.Controls.Add(button_MyProfile);
            panel_Left.Location = new Point(0, -3);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(205, 539);
            panel_Left.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(31, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 37);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(31, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 37);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Filemanage
            // 
            this.button_Filemanage.FlatAppearance.BorderSize = 0;
            this.button_Filemanage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Filemanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Filemanage.Location = new System.Drawing.Point(31, 176);
            this.button_Filemanage.Name = "button_Filemanage";
            this.button_Filemanage.Size = new System.Drawing.Size(145, 37);
            this.button_Filemanage.TabIndex = 1;
            this.button_Filemanage.UseVisualStyleBackColor = true;
            this.button_Filemanage.Click += new System.EventHandler(this.button_Filemanage_Click);
            // 
            // button_MyProfile
            // 
            this.button_MyProfile.FlatAppearance.BorderSize = 0;
            this.button_MyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_MyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyProfile.Location = new System.Drawing.Point(31, 120);
            this.button_MyProfile.Name = "button_MyProfile";
            this.button_MyProfile.Size = new System.Drawing.Size(140, 38);
            this.button_MyProfile.TabIndex = 0;
            this.button_MyProfile.UseVisualStyleBackColor = true;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Transparent;
            panel_Body.Location = new Point(203, -3);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(728, 539);
            panel_Body.TabIndex = 1;
            // 
            // button_Logout
            // 
            button_Logout.FlatAppearance.BorderSize = 0;
            button_Logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Logout.FlatStyle = FlatStyle.Flat;
            button_Logout.Location = new Point(156, 486);
            button_Logout.Name = "button_Logout";
            button_Logout.Size = new Size(41, 29);
            button_Logout.TabIndex = 4;
            button_Logout.UseVisualStyleBackColor = true;
            button_Logout.Click += button_Logout_Click;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 528);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Left);
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Left;
        private Button button3;
        private Button button2;
        private Button button_Filemanage;
        private Button button_MyProfile;
        private FlowLayoutPanel panel_Body;
        private Button button_Logout;
    }
}