﻿namespace Client
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
            label_FileName = new Label();
            contextMenuStrip_Function1 = new ContextMenuStrip(components);
            toolStripMenuItem_Download = new ToolStripMenuItem();
            toolStripMenuItem_Rename = new ToolStripMenuItem();
            toolStripMenuItem_Copy = new ToolStripMenuItem();
            toolStripMenuItem_Cut = new ToolStripMenuItem();
            toolStripMenuItem_Delete = new ToolStripMenuItem();
            contextMenuStrip_Function2 = new ContextMenuStrip(components);
            toolStripMenuItem_CreateFolder = new ToolStripMenuItem();
            toolStripMenuItem_UploadFolder = new ToolStripMenuItem();
            toolStripMenuItem_UploadFile = new ToolStripMenuItem();
            toolStripMenuItem_Paste = new ToolStripMenuItem();
            contextMenuStrip_Function1.SuspendLayout();
            contextMenuStrip_Function2.SuspendLayout();
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
            listView_Dialog.MouseDown += listView_Dialog_MouseDown;
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
            iconList.Images.SetKeyName(5, "Image.png");
            iconList.Images.SetKeyName(6, "Video.png");
            iconList.Images.SetKeyName(7, "Zip.png");
            iconList.Images.SetKeyName(8, "AnotherFile.png");
            iconList.Images.SetKeyName(9, "Music.png");
            iconList.Images.SetKeyName(10, "Text.png");
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
            // label_FileName
            // 
            label_FileName.AutoSize = true;
            label_FileName.Location = new Point(157, 421);
            label_FileName.Name = "label_FileName";
            label_FileName.Size = new Size(21, 20);
            label_FileName.TabIndex = 7;
            label_FileName.Text = "--";
            // 
            // contextMenuStrip_Function1
            // 
            contextMenuStrip_Function1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_Function1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_Download, toolStripMenuItem_Rename, toolStripMenuItem_Copy, toolStripMenuItem_Cut, toolStripMenuItem_Delete });
            contextMenuStrip_Function1.Name = "contextMenuStrip_Function";
            contextMenuStrip_Function1.Size = new Size(148, 124);
            // 
            // toolStripMenuItem_Download
            // 
            toolStripMenuItem_Download.Name = "toolStripMenuItem_Download";
            toolStripMenuItem_Download.Size = new Size(147, 24);
            toolStripMenuItem_Download.Text = "Download";
            toolStripMenuItem_Download.Click += toolStripMenuItem_Download_Click;
            // 
            // toolStripMenuItem_Rename
            // 
            toolStripMenuItem_Rename.Name = "toolStripMenuItem_Rename";
            toolStripMenuItem_Rename.Size = new Size(147, 24);
            toolStripMenuItem_Rename.Text = "Rename";
            toolStripMenuItem_Rename.Click += toolStripMenuItem_Rename_Click;
            // 
            // toolStripMenuItem_Copy
            // 
            toolStripMenuItem_Copy.Name = "toolStripMenuItem_Copy";
            toolStripMenuItem_Copy.Size = new Size(147, 24);
            toolStripMenuItem_Copy.Text = "Copy";
            toolStripMenuItem_Copy.Click += toolStripMenuItem_Copy_Click;
            // 
            // toolStripMenuItem_Cut
            // 
            toolStripMenuItem_Cut.Name = "toolStripMenuItem_Cut";
            toolStripMenuItem_Cut.Size = new Size(147, 24);
            toolStripMenuItem_Cut.Text = "Cut";
            toolStripMenuItem_Cut.Click += toolStripMenuItem_Cut_Click;
            // 
            // toolStripMenuItem_Delete
            // 
            toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            toolStripMenuItem_Delete.Size = new Size(147, 24);
            toolStripMenuItem_Delete.Text = "Delete";
            toolStripMenuItem_Delete.Click += toolStripMenuItem_Delete_Click;
            // 
            // contextMenuStrip_Function2
            // 
            contextMenuStrip_Function2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip_Function2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem_CreateFolder, toolStripMenuItem_UploadFolder, toolStripMenuItem_UploadFile, toolStripMenuItem_Paste });
            contextMenuStrip_Function2.Name = "contextMenuStrip_Function2";
            contextMenuStrip_Function2.Size = new Size(208, 100);
            // 
            // toolStripMenuItem_CreateFolder
            // 
            toolStripMenuItem_CreateFolder.Name = "toolStripMenuItem_CreateFolder";
            toolStripMenuItem_CreateFolder.Size = new Size(207, 24);
            toolStripMenuItem_CreateFolder.Text = "Create New Folder";
            toolStripMenuItem_CreateFolder.Click += toolStripMenuItem_CreateFolder_Click;
            // 
            // toolStripMenuItem_UploadFolder
            // 
            toolStripMenuItem_UploadFolder.Name = "toolStripMenuItem_UploadFolder";
            toolStripMenuItem_UploadFolder.Size = new Size(207, 24);
            toolStripMenuItem_UploadFolder.Text = "Upload New Folder";
            toolStripMenuItem_UploadFolder.Click += toolStripMenuItem_UploadFolder_Click;
            // 
            // toolStripMenuItem_UploadFile
            // 
            toolStripMenuItem_UploadFile.Name = "toolStripMenuItem_UploadFile";
            toolStripMenuItem_UploadFile.Size = new Size(207, 24);
            toolStripMenuItem_UploadFile.Text = "Upload New File";
            toolStripMenuItem_UploadFile.Click += toolStripMenuItem_UploadFile_Click;
            // 
            // toolStripMenuItem_Paste
            // 
            toolStripMenuItem_Paste.Name = "toolStripMenuItem_Paste";
            toolStripMenuItem_Paste.Size = new Size(207, 24);
            toolStripMenuItem_Paste.Text = "Paste";
            toolStripMenuItem_Paste.Click += toolStripMenuItem_Paste_Click;
            // 
            // Form_FileManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_FileName);
            Controls.Add(button_Go);
            Controls.Add(listView_Dialog);
            Controls.Add(textBox_Path);
            Controls.Add(label1);
            Controls.Add(button_Back);
            Name = "Form_FileManager";
            Text = "Form_FileManager";
            contextMenuStrip_Function1.ResumeLayout(false);
            contextMenuStrip_Function2.ResumeLayout(false);
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