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
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.listView_Dialog = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.button_Go = new System.Windows.Forms.Button();
            this.label_FileName = new System.Windows.Forms.Label();
            this.contextMenuStrip_Function1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Download = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Function2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_CreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_UploadFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_UploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Function1.SuspendLayout();
            this.contextMenuStrip_Function2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.Transparent;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Location = new System.Drawing.Point(33, 36);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(44, 20);
            this.button_Back.TabIndex = 0;
            this.button_Back.UseVisualStyleBackColor = false;
            button_Back.Click += button_Back_Click;
            // 
            // textBox_Path
            // 

            this.textBox_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(197)))));
            this.textBox_Path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Path.Location = new System.Drawing.Point(150, 36);
            this.textBox_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(430, 20);
            this.textBox_Path.TabIndex = 2;
            // 
            // listView_Dialog
            // 
            this.listView_Dialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.listView_Dialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Dialog.GroupImageList = this.iconList;
            this.listView_Dialog.LargeImageList = this.iconList;
            this.listView_Dialog.Location = new System.Drawing.Point(60, 95);
            this.listView_Dialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Dialog.Name = "listView_Dialog";
            this.listView_Dialog.Size = new System.Drawing.Size(667, 346);
            this.listView_Dialog.TabIndex = 3;
            this.listView_Dialog.UseCompatibleStateImageBehavior = false;
            listView_Dialog.ItemSelectionChanged += listView_Dialog_ItemSelectionChanged;
            listView_Dialog.MouseDoubleClick += listView_Dialog_MouseDoubleClick;
            listView_Dialog.MouseDown += listView_Dialog_MouseDown;

            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Folder.png");
            this.iconList.Images.SetKeyName(1, "Doc.png");
            this.iconList.Images.SetKeyName(2, "PDF.png");
            this.iconList.Images.SetKeyName(3, "ppt.png");
            this.iconList.Images.SetKeyName(4, "xlsx.png");
            this.iconList.Images.SetKeyName(5, "png.png");
            this.iconList.Images.SetKeyName(6, "mp4.png");
            this.iconList.Images.SetKeyName(7, "zip.png");
            this.iconList.Images.SetKeyName(8, "others.png");
            this.iconList.Images.SetKeyName(9, "mp3.png");
            this.iconList.Images.SetKeyName(10, "Text.png");
            // 
            // button_Go
            // 
            this.button_Go.BackColor = System.Drawing.Color.Transparent;
            this.button_Go.FlatAppearance.BorderSize = 0;
            this.button_Go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Go.Location = new System.Drawing.Point(662, 36);
            this.button_Go.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(47, 20);
            this.button_Go.TabIndex = 5;
            this.button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;

            // 
            // label_FileName
            // 

            this.label_FileName.AutoSize = true;
            this.label_FileName.BackColor = System.Drawing.Color.Transparent;
            this.label_FileName.Location = new System.Drawing.Point(255, 472);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(0, 20);
            this.label_FileName.TabIndex = 7;
            // 
            // contextMenuStrip_Function1
            // 
            contextMenuStrip_Function1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_Function1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_Download, toolStripMenuItem_Rename, toolStripMenuItem_Copy, toolStripMenuItem_Cut, toolStripMenuItem_Delete });
            contextMenuStrip_Function1.Name = "contextMenuStrip_Function";
            contextMenuStrip_Function1.Size = new Size(129, 114);
            // 
            // toolStripMenuItem_Download
            // 
            this.toolStripMenuItem_Download.Name = "toolStripMenuItem_Download";
            this.toolStripMenuItem_Download.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem_Download.Text = "Download";
            toolStripMenuItem_Download.Click += toolStripMenuItem_Download_Click;

            // 
            // toolStripMenuItem_Rename
            // 
            this.toolStripMenuItem_Rename.Name = "toolStripMenuItem_Rename";
            this.toolStripMenuItem_Rename.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem_Rename.Text = "Rename";
            toolStripMenuItem_Rename.Click += toolStripMenuItem_Rename_Click;

            // 
            // toolStripMenuItem_Copy
            // 
            this.toolStripMenuItem_Copy.Name = "toolStripMenuItem_Copy";
            this.toolStripMenuItem_Copy.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem_Copy.Text = "Copy";
            toolStripMenuItem_Copy.Click += toolStripMenuItem_Copy_Click;
            // 
            // toolStripMenuItem_Cut
            // 
            this.toolStripMenuItem_Cut.Name = "toolStripMenuItem_Cut";
            this.toolStripMenuItem_Cut.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem_Cut.Text = "Cut";
            toolStripMenuItem_Cut.Click += toolStripMenuItem_Cut_Click;
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem_Delete.Text = "Delete";
            toolStripMenuItem_Delete.Click += toolStripMenuItem_Delete_Click;
            // 
            // contextMenuStrip_Function2
            // 
            contextMenuStrip_Function2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_Function2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_CreateFolder, toolStripMenuItem_UploadFolder, toolStripMenuItem_UploadFile, toolStripMenuItem_Paste });
            contextMenuStrip_Function2.Name = "contextMenuStrip_Function2";
            contextMenuStrip_Function2.Size = new Size(176, 92);
            // 
            // toolStripMenuItem_CreateFolder
            // 
            this.toolStripMenuItem_CreateFolder.Name = "toolStripMenuItem_CreateFolder";
            this.toolStripMenuItem_CreateFolder.Size = new System.Drawing.Size(207, 24);
            this.toolStripMenuItem_CreateFolder.Text = "Create New Folder";
            toolStripMenuItem_CreateFolder.Click += toolStripMenuItem_CreateFolder_Click;
            // 
            // 
            // toolStripMenuItem_UploadFolder
            // 
            this.toolStripMenuItem_UploadFolder.Name = "toolStripMenuItem_UploadFolder";
            this.toolStripMenuItem_UploadFolder.Size = new System.Drawing.Size(207, 24);
            this.toolStripMenuItem_UploadFolder.Text = "Upload New Folder";
            toolStripMenuItem_UploadFolder.Click += toolStripMenuItem_UploadFolder_Click;
            // 
            // toolStripMenuItem_UploadFile
            // 
            toolStripMenuItem_UploadFile.Name = "toolStripMenuItem_UploadFile";
            toolStripMenuItem_UploadFile.Size = new Size(175, 22);
            toolStripMenuItem_UploadFile.Text = "Upload New File";
            toolStripMenuItem_UploadFile.Click += toolStripMenuItem_UploadFile_Click;
            // 
            // toolStripMenuItem_Paste
            // 
            this.toolStripMenuItem_Paste.Name = "toolStripMenuItem_Paste";
            this.toolStripMenuItem_Paste.Size = new System.Drawing.Size(207, 24);
            this.toolStripMenuItem_Paste.Text = "Paste";
            toolStripMenuItem_Paste.Click += toolStripMenuItem_Paste_Click;
            // 
            // Form_FileManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.listView_Dialog);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_Back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_FileManager";
            this.Text = "Form_FileManager";
            this.contextMenuStrip_Function1.ResumeLayout(false);
            this.contextMenuStrip_Function2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Back;
        private TextBox textBox_Path;
        private ListView listView_Dialog;
        private ImageList iconList;
        private Button button_Go;
        private Label label_FileName;
        private ContextMenuStrip contextMenuStrip_Function1;
        private ToolStripMenuItem toolStripMenuItem_Delete;
        private ToolStripMenuItem toolStripMenuItem_Copy;
        private ToolStripMenuItem toolStripMenuItem_Cut;
        private ToolStripMenuItem toolStripMenuItem_Rename;
        private ToolStripMenuItem toolStripMenuItem_Download;
        private ContextMenuStrip contextMenuStrip_Function2;
        private ToolStripMenuItem toolStripMenuItem_CreateFolder;
        private ToolStripMenuItem toolStripMenuItem_UploadFile;
        private ToolStripMenuItem toolStripMenuItem_Paste;
        private ToolStripMenuItem toolStripMenuItem_UploadFolder;
    }
}