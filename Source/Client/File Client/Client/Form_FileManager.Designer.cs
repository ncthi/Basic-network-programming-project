namespace Client
{
    partial class Form_FileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FileManager));
            this.button_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.listView_Dialog = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.button_Go = new System.Windows.Forms.Button();
            this.button_Upload = new System.Windows.Forms.Button();
            this.label_FileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(13, 9);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(68, 27);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FileName:";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(87, 9);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(627, 27);
            this.textBox_Path.TabIndex = 2;
            // 
            // listView_Dialog
            // 
            this.listView_Dialog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView_Dialog.GroupImageList = this.iconList;
            this.listView_Dialog.LargeImageList = this.iconList;
            this.listView_Dialog.Location = new System.Drawing.Point(13, 46);
            this.listView_Dialog.Name = "listView_Dialog";
            this.listView_Dialog.Size = new System.Drawing.Size(775, 366);
            this.listView_Dialog.TabIndex = 3;
            this.listView_Dialog.UseCompatibleStateImageBehavior = false;
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Folder.png");
            this.iconList.Images.SetKeyName(1, "Doc");
            this.iconList.Images.SetKeyName(2, "PDF");
            this.iconList.Images.SetKeyName(3, "PPT");
            this.iconList.Images.SetKeyName(4, "XLSX");
            this.iconList.Images.SetKeyName(5, "Image.jpg");
            this.iconList.Images.SetKeyName(6, "Video");
            this.iconList.Images.SetKeyName(7, "ZIP");
            this.iconList.Images.SetKeyName(8, "Other");
            this.iconList.Images.SetKeyName(9, "MP3");
            this.iconList.Images.SetKeyName(10, "TXT");
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(720, 9);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(68, 27);
            this.button_Go.TabIndex = 5;
            this.button_Go.Text = "Go";
            this.button_Go.UseVisualStyleBackColor = true;
            // 
            // button_Upload
            // 
            this.button_Upload.Location = new System.Drawing.Point(720, 418);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(68, 27);
            this.button_Upload.TabIndex = 6;
            this.button_Upload.Text = "Upload";
            this.button_Upload.UseVisualStyleBackColor = true;
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Location = new System.Drawing.Point(157, 421);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(21, 20);
            this.label_FileName.TabIndex = 7;
            this.label_FileName.Text = "--";
            // 
            // Form_FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.listView_Dialog);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Back);
            this.Name = "Form_FileManager";
            this.Text = "Form_FileManager";
            this.Load += new System.EventHandler(this.Form_FileManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button_Go_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button_Back;
        private Label label1;
        private TextBox textBox_Path;
        private ListView listView_Dialog;
        private ImageList iconList;
        private Button button_Go;
        private Button button_Upload;
        private Label label_FileName;
    }
}