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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form_FileManager : Form
    {
        FTP ftpClient;
        private string filePath = "";
        private bool isFile = false;
        private string currentPath = "";
        private string currentlySelectedItemName = @"ftp://192.168.112.142/";

        public Form_FileManager()
        {
            InitializeComponent();
            loadFilesAndDirectories("");
        }

        public void loadFilesAndDirectories(string path)
        {
            listView_Dialog.Items.Clear();
            ftpClient = new FTP(@"ftp://192.168.112.142/", "caothi", "123456");
            ftpClient.connect();
            var list = ftpClient.directoryListSimple(path);
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                foreach (var file in list)
                {
                    if (file.IndexOf(".") != -1)
                    {
                        var fileExtension = file.Split('.')[1];
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView_Dialog.Items.Add(file, 6);
                                break;
                            case ".PPT":
                            case ".PPTX":
                                listView_Dialog.Items.Add(file, 3);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView_Dialog.Items.Add(file, 7);
                                break;
                            case ".PDF":
                                listView_Dialog.Items.Add(file, 2);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView_Dialog.Items.Add(file, 1);
                                break;
                            case ".XLS":
                            case ".XLSX":
                                listView_Dialog.Items.Add(file, 4);
                                break;
                            case ".ZIP":
                            case ".RAR":
                                listView_Dialog.Items.Add(file, 9);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView_Dialog.Items.Add(file, 5);
                                break;

                            default:
                                listView_Dialog.Items.Add(file, 8);
                                break;
                        }
                    }
                    else
                    {
                        listView_Dialog.Items.Add(file, 0);
                    }

                }

                textBox_Path.Text = path;
                currentPath = textBox_Path.Text;
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
            currentlySelectedItemName += e.Item.Text;
            loadFilesAndDirectories(currentlySelectedItemName);
            //if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            //{
            //    isFile = false;
            //    textBox_Path.Text = currentlySelectedItemName;
            //}
            //else
            //{
            //    isFile = true;
            //}
        }

        private void listView_Dialog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            //currentlySelectedItemName += "/" + 
            //loadFilesAndDirectories(currentlySelectedItemName);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
    }
}
