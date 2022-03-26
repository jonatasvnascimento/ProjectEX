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
        public string path { get; set; }
        public string TableName { get; set; }
        public Form1()
        {
            InitializeComponent();

        }
        private void comboBoxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = TableCollection[comboBoxSheet.SelectedItem.ToString()];
            dataGridView2.DataSource = dt;
        }
        private void dataGridViewName_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 10;    // <<this line will help you
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
                    //carrega o arquivo para leiturarrr
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
                                TableName = table.TableName;
                                reader.Close();
                            }
                            carregaLista();

                            Excel ex = new Excel(path, 1);
                            ex.wb.Close(false);

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
        private void btnRead_Click(object sender, EventArgs e)
        {
            lblSQL.Text = "Select * from TESTE";
            //Excel excel = new Excel(path, 1);
            //excel.WriteToCell(0, 4080, "99999");
            //excel.Save();
            //excel.Close();
        }

        private void carregaLista()
        {
            System.Data.DataTable dt = new();

            dt.Columns.Add("Barras", typeof(string));
            dt.Columns.Add("Enxoval", typeof(string));

            Excel ex = new Excel(path, 1);
            int FinalRow = ex.LastRowTotal(ex.ws);

            var ObjectRange = ex.RangeLine(TableName);

            string[] Barra = new string[FinalRow];
            string[] Enxoval = new string[FinalRow];


            for (int i = 1; i < FinalRow; i++)
            {
                if (i < FinalRow - 1)
                {
                    Barra[i - 1] = ObjectRange[i, 1].ToString();
                    Enxoval[i - 1] = ObjectRange[i, 4].ToString();

                }
            }

            for (int i = 1; i < FinalRow; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Barras"] = Barra[i];
                dr["Enxoval"] = Enxoval[i];
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
            


        }


        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
