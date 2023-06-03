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
            panel_Left.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = Color.Transparent;
            panel_Left.Controls.Add(button3);
            panel_Left.Controls.Add(button2);
            panel_Left.Controls.Add(button_Filemanage);
            panel_Left.Controls.Add(button_MyProfile);
            panel_Left.Location = new Point(0, -3);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(205, 533);
            panel_Left.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(31, 297);
            button3.Name = "button3";
            button3.Size = new Size(140, 37);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(26, 242);
            button2.Name = "button2";
            button2.Size = new Size(145, 37);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button_Filemanage
            // 
            button_Filemanage.FlatAppearance.BorderSize = 0;
            button_Filemanage.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Filemanage.FlatStyle = FlatStyle.Flat;
            button_Filemanage.Location = new Point(23, 176);
            button_Filemanage.Name = "button_Filemanage";
            button_Filemanage.Size = new Size(148, 37);
            button_Filemanage.TabIndex = 1;
            button_Filemanage.UseVisualStyleBackColor = true;
            button_Filemanage.Click += button1_Click;
            // 
            // button_MyProfile
            // 
            button_MyProfile.FlatAppearance.BorderSize = 0;
            button_MyProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_MyProfile.FlatStyle = FlatStyle.Flat;
            button_MyProfile.Location = new Point(29, 120);
            button_MyProfile.Name = "button_MyProfile";
            button_MyProfile.Size = new Size(137, 38);
            button_MyProfile.TabIndex = 0;
            button_MyProfile.UseVisualStyleBackColor = true;
            button_MyProfile.Click += button_MyProfile_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Transparent;
            panel_Body.Location = new Point(203, -3);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(728, 529);
            panel_Body.TabIndex = 1;
            // 
            // Form_Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(931, 526);
            Controls.Add(panel_Body);
            Controls.Add(panel_Left);
            Name = "Form_Dashboard";
            Text = "Form_Dashboard";
            panel_Left.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Left;
        private Button button3;
        private Button button2;
        private Button button_Filemanage;
        private Button button_MyProfile;
        private FlowLayoutPanel panel_Body;
    }
}