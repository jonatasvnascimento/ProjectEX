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
        private string filePath = "\\\\172.16.98.40\\c$";
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
                    tempFilePath = filePath + "\\" + currentlySelectedItemName;
                    FileInfo fileInfo = new FileInfo(tempFilePath);
                    lblFileName.Text = fileInfo.Name;
                    lblFileType.Text = fileInfo.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        listView1.Items.Add(files[i].Name);
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadButtonAction()
        {
            filePath = tbxPathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "\\" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                tbxPathTextBox.Text = filePath + "\\" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }
    }
}
