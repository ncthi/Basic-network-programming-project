using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form_FileManager : Form
    {
        FTP ftpClient;
        private string filePath = "";
        private bool isFile = false;
        private string currentPath = "";

        public Form_FileManager()
        {
            InitializeComponent();
            loadFilesAndDirectories("");
        }

        public void loadFilesAndDirectories(string path)
        {
            listView_Dialog.Items.Clear();
            ftpClient = new FTP(@"ftp://172.20.123.38/", "caothi", "123456");
            ftpClient.connect();
            // List directorys and files
            List<string> listAll = ftpClient.directoryListDetailed(path);
            //List Files
            List<string> listFiles = FTP.ListFile(listAll);
            //List directorys
            List<string> listDirs = FTP.ListDirectory(listAll);
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                foreach (var file in listFiles)
                {
                    var fileExtension = file.Split('.')[1];
                    if (fileExtension.Length >= 2)
                    {
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                ListViewItem item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 6;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".PPT":
                            case ".PPTX":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 3;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 7;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".PDF":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 2;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 1;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".XLS":
                            case ".XLSX":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 4;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".ZIP":
                            case ".RAR":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 3;
                                listView_Dialog.Items.Add(item);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 5;
                                listView_Dialog.Items.Add(item);
                                break;

                            default:
                                item = new ListViewItem();
                                item.Tag = "File";
                                item.Text = file;
                                item.ImageIndex = 8;
                                listView_Dialog.Items.Add(item);
                                break;
                        }
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item.Tag = "File";
                        item.Text = file;
                        item.ImageIndex = 8;
                        listView_Dialog.Items.Add(item);
                    }
                }
                foreach (string dir in listDirs)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = "Dir";
                    item.Text = dir;
                    item.ImageIndex = 0;
                    listView_Dialog.Items.Add(item);
                }
                currentPath = path;
                textBox_Path.Text = path;
            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            filePath = textBox_Path.Text;
            loadFilesAndDirectories(filePath);
            removeBackSlash();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = textBox_Path.Text;
            if (path != null && path.Length > 0 && path.LastIndexOf("\\") == path.Length - 1)
            {
                textBox_Path.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                string path = textBox_Path.Text;
                if (path.EndsWith("/"))
                {
                    path = path.Remove(path.Length - 1);
                }
                int lastSlashIdx = path.LastIndexOf("/");
                if (lastSlashIdx != -1)
                {
                    path = path.Substring(0, lastSlashIdx);
                }
                else
                {
                    path = "/";
                }
                this.isFile = false;
                textBox_Path.Text = path;
                loadFilesAndDirectories(path);
            }
            catch (Exception e)
            {

            }
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView_Dialog_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            label_FileName.Text = e.Item.Text;
        }

        private void listView_Dialog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView_Dialog.SelectedItems.Count > 0)
            {
                // Lấy tên item đang chọn
                ListViewItem item = listView_Dialog.SelectedItems[0];
                string nameItem = item.Text;
                // mở thư mục chọn
                if (item.Tag == "Dir")
                {
                    currentPath += '/' + nameItem;
                    loadFilesAndDirectories(currentPath);
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
    }
}
