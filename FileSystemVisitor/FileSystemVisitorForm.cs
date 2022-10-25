using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace FileSystemVisitor
{
    public partial class FileSystemVisitorForm : Form
    {
        private string filePath = "D:";
        private bool isFile = false;
        private string currentlySelectedItem = "";


        public FileSystemVisitorForm()
        {
            InitializeComponent();
        }

        private void FileSystemVisitorForm_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttributes;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItem;
                    FileInfo fileInfo = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileInfo.Name;
                    fileTypeLabel.Text = fileInfo.Extension;
                    fileAttributes = File.GetAttributes(tempFilePath);
                }
                else
                {
                    fileAttributes = File.GetAttributes(filePath);
                }

                if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    string fileExtension = "";

                    foundFilesListView.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        foundFilesListView.Items.Add(files[i].Name);
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        foundFilesListView.Items.Add(dirs[i].Name);
                    }
                }

                else
                {
                    fileNameLabel.Text = this.currentlySelectedItem;
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void findButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void foundFilesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItem = e.Item.Text;

            FileAttributes fileAttributes = File.GetAttributes(filePath + "/" + currentlySelectedItem);

            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "/" + currentlySelectedItem;
            }
            else
            {
                isFile = true;
            }
        }

        private void foundFilesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }
    }
}
