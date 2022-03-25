using ExcelDataReader;
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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace ProjectEX
{
    public partial class Form1 : Form
    {
        public string path { get; set; } = @"C:\Users\jnascimento3\Desktop\teste\p1.xlsx";
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("C1", 50);
            listView1.Columns.Add("C2", 50);
            listView1.Columns.Add("C3", 50);
            listView1.Columns.Add("C4", 50);
            listView1.Columns.Add("C5", 50);
            listView1.Columns.Add("C6", 50);



        }
        private void comboBoxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = TableCollection[comboBoxSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        DataTableCollection TableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Filtro para acher as planilhas
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //mostra o nome do arquivo na txt
                    txtFilename.Text = openFileDialog.FileName;
                    path = openFileDialog.FileName;
                    //carrega o arquivo para leitura
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {

                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            //tranforma em um dataset
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true,
                                }
                            });
                            TableCollection = result.Tables;
                            comboBoxSheet.Items.Clear();
                            foreach (System.Data.DataTable table in TableCollection)
                            {
                                comboBoxSheet.Items.Add(table.TableName);
                                reader.Close();
                            }
                        }
                    }
                }
            }
        }

        public void OpenFile()
        {
            Excel excel = new Excel(path, 1);
            MessageBox.Show(excel.ReadCell(0, 0));
        }
        public void WriteData()
        {
            Excel excel = new Excel(path, 1);
            excel.WriteToCell(0, 0, "99999");
            excel.Save();
            excel.Close();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            Excel ex = new Excel(path, 1);
            string[,] read = ex.ReadRange(1,1,100000,7);
            ex.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
