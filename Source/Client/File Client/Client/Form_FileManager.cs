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
        private string filePath = "C:\\";
        private bool isFile = false;
        private string currentlySelectedItemName = "";

        public Form_FileManager()
        {
            InitializeComponent();
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "\\" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    label_FileName.Text = fileDetails.Name;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                    string fileExtension = "";
                    listView_Dialog.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView_Dialog.Items.Add(files[i].Name, 6);
                                break;
                            case ".PPT":
                            case ".PPTX":
                                listView_Dialog.Items.Add(files[i].Name, 3);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView_Dialog.Items.Add(files[i].Name, 7);
                                break;
                            case ".PDF":
                                listView_Dialog.Items.Add(files[i].Name, 2);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView_Dialog.Items.Add(files[i].Name, 1);
                                break;
                            case ".XLS":
                            case ".XLSX":
                                listView_Dialog.Items.Add(files[i].Name, 4);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView_Dialog.Items.Add(files[i].Name, 5);
                                break;

                            default:
                                listView_Dialog.Items.Add(files[i].Name, 8);
                                break;
                        }
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView_Dialog.Items.Add(dirs[i].Name, 0);
                    }
                }
                else
                {
                    label_FileName.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = textBox_Path.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = textBox_Path.Text;
            if (path.LastIndexOf("\\") == path.Length - 1)
            {
                textBox_Path.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = textBox_Path.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                textBox_Path.Text = path;
                removeBackSlash();
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
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "\\" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                textBox_Path.Text = filePath + "\\" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView_Dialog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
    }
}
