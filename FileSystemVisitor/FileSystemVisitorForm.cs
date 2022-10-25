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

namespace FileSystemVisitor
{
    public partial class FileSystemVisitorForm : Form
    {
        private string filePath = "";
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

            try
            {
                fileList = new DirectoryInfo(filePath);
                FileInfo[] files = fileList.GetFiles();
                DirectoryInfo[] dirs = fileList.GetDirectories();

                foundFilesListView.Items.Clear();

                for(int i = 0; i < files.Length; i++)
                {
                    foundFilesListView.Items.Add(files[i].Name);
                }

                for(int i = 0; i < dirs.Length; i++)
                {
                    foundFilesListView.Items.Add(dirs[i].Name);
                }
            }
            catch(Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
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
    }
}
