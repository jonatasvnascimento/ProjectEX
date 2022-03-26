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
        public string path { get; set; } = @"C:\Users\jnascimento3\Desktop\teste\Scala_I_dados.xlsx";
        public Form1()
        {
            InitializeComponent();
            carregaLista();
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
        private void btnRead_Click(object sender, EventArgs e)
        {

            Excel excel = new Excel(path, 1);
            excel.WriteToCell(0, 4080, "99999");
            excel.Save();
            excel.Close();
        }

        private void carregaLista()
        {
            System.Data.DataTable dt = new();

            dt.Columns.Add("Barras", typeof(string));
            dt.Columns.Add("Enxoval", typeof(string));

            Excel ex = new Excel(path, 1);
            int FinalRow = ex.LastRowTotal(ex.ws);

            var ObjectRange = ex.RangeLine();

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

            //string[] Barras = new string[FinalRow];
            //for (int i = 0; i < 10; i++)
            //{
            //    Barras[i] = ex.ReadCell(i, 0);
            //}

            //for (int i = 1; i < 2000; i++)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["Barras"] = Barras[i];
            //    dt.Rows.Add(dr);
            //}

            for (int i = 1; i < FinalRow; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Barras"] = Barra[i];
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;


        }


        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
