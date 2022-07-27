using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEX.view
{
    public partial class frmServidores : Form
    {
        private string filePath = Directory.GetDirectoryRoot("/C:");
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public frmServidores()
        {
            InitializeComponent();
        }

        private void frmServidores_Load(object sender, EventArgs e)
        {
            tbxPathTextBox.Text = filePath;
            loadFilesAndDirectories();
        }

        private void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileInfo = new FileInfo(tempFilePath);
                    lblFileName.Text = fileInfo.Name;
                    lblFileType.Text = fileInfo.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        listView1.Items.Add(files[i].Name, 13);
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 39);
                    }
                }
                else
                {
                    lblFileName.Text = this.currentlySelectedItemName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = tbxPathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = tbxPathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                tbxPathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();

                string path = tbxPathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                tbxPathTextBox.Text = path;

                removeBackSlash();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            try
            {
                FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    isFile = false;
                    tbxPathTextBox.Text = filePath + "/" + currentlySelectedItemName;
                }
                else
                {
                    isFile = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }
    }
}
