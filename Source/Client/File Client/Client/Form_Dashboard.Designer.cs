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
            button1 = new Button();
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
            panel_Left.Controls.Add(button1);
            panel_Left.Controls.Add(button_MyProfile);
            panel_Left.Location = new Point(0, -3);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(194, 498);
            panel_Left.TabIndex = 0;
            panel_Left.Paint += panel_Left_Paint;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(31, 274);
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
            button2.Location = new Point(26, 215);
            button2.Name = "button2";
            button2.Size = new Size(145, 37);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(23, 155);
            button1.Name = "button1";
            button1.Size = new Size(148, 37);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_MyProfile
            // 
            button_MyProfile.FlatAppearance.BorderSize = 0;
            button_MyProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_MyProfile.FlatStyle = FlatStyle.Flat;
            button_MyProfile.Location = new Point(29, 98);
            button_MyProfile.Name = "button_MyProfile";
            button_MyProfile.Size = new Size(137, 38);
            button_MyProfile.TabIndex = 0;
            button_MyProfile.UseVisualStyleBackColor = true;
            button_MyProfile.Click += button_MyProfile_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Transparent;
            panel_Body.Location = new Point(192, 0);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(627, 495);
            panel_Body.TabIndex = 1;
            // 
            // Form_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(818, 495);
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
        private Button button1;
        private Button button_MyProfile;
        private FlowLayoutPanel panel_Body;
    }
}