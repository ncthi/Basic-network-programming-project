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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FileManager));
            button_Back = new Button();
            label1 = new Label();
            textBox_Path = new TextBox();
            listView_Dialog = new ListView();
            iconList = new ImageList(components);
            button_Go = new Button();
            button_Upload = new Button();
            label_FileName = new Label();
            SuspendLayout();
            // 
            // button_Back
            // 
            button_Back.Location = new Point(13, 9);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(68, 27);
            button_Back.TabIndex = 0;
            button_Back.Text = "Back";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 421);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "FileName:";
            // 
            // textBox_Path
            // 
            textBox_Path.Location = new Point(87, 9);
            textBox_Path.Name = "textBox_Path";
            textBox_Path.Size = new Size(627, 27);
            textBox_Path.TabIndex = 2;
            // 
            // listView_Dialog
            // 
            listView_Dialog.GroupImageList = iconList;
            listView_Dialog.LargeImageList = iconList;
            listView_Dialog.Location = new Point(13, 46);
            listView_Dialog.Name = "listView_Dialog";
            listView_Dialog.Size = new Size(775, 366);
            listView_Dialog.TabIndex = 3;
            listView_Dialog.UseCompatibleStateImageBehavior = false;
            listView_Dialog.ItemSelectionChanged += listView_Dialog_ItemSelectionChanged;
            listView_Dialog.MouseDoubleClick += listView_Dialog_MouseDoubleClick;
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "Folder.png");
            iconList.Images.SetKeyName(1, "Doc.png");
            iconList.Images.SetKeyName(2, "PDF.png");
            iconList.Images.SetKeyName(3, "Powerpoint.png");
            iconList.Images.SetKeyName(4, "Excel.png");
            iconList.Images.SetKeyName(5, "Image.jpg");
            iconList.Images.SetKeyName(6, "Music.png");
            iconList.Images.SetKeyName(7, "Video.png");
            iconList.Images.SetKeyName(8, "AnotherFile.png");
            iconList.Images.SetKeyName(9, "Zip.png");
            // 
            // button_Go
            // 
            button_Go.Location = new Point(720, 9);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(68, 27);
            button_Go.TabIndex = 5;
            button_Go.Text = "Go";
            button_Go.UseVisualStyleBackColor = true;
            button_Go.Click += button_Go_Click;
            // 
            // button_Upload
            // 
            button_Upload.Location = new Point(720, 418);
            button_Upload.Name = "button_Upload";
            button_Upload.Size = new Size(68, 27);
            button_Upload.TabIndex = 6;
            button_Upload.Text = "Upload";
            button_Upload.UseVisualStyleBackColor = true;
            // 
            // label_FileName
            // 
            label_FileName.AutoSize = true;
            label_FileName.Location = new Point(157, 421);
            label_FileName.Name = "label_FileName";
            label_FileName.Size = new Size(21, 20);
            label_FileName.TabIndex = 7;
            label_FileName.Text = "--";
            // 
            // Form_FileManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_FileName);
            Controls.Add(button_Upload);
            Controls.Add(button_Go);
            Controls.Add(listView_Dialog);
            Controls.Add(textBox_Path);
            Controls.Add(label1);
            Controls.Add(button_Back);
            Name = "Form_FileManager";
            Text = "Form_FileManager";
            ResumeLayout(false);
            PerformLayout();
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