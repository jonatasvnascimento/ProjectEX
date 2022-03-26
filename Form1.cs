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
using System.Diagnostics;

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
            //System.Data.DataTable dt = TableCollection[comboBoxSheet.SelectedItem.ToString()];
            //dataGridView2.DataSource = dt;
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

                    try
                    {
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
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"{ex}");
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
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("Cor", typeof(string));
            dt.Columns.Add("Tamanho", typeof(string));
            dt.Columns.Add("QtdHigienizações", typeof(string));
            dt.Columns.Add("Cadastro", typeof(string));
            dt.Columns.Add("Funcionário", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Localização", typeof(string));
            dt.Columns.Add("Contrato", typeof(string));

            Excel ex = new Excel(path, 1);
            int FinalRow = ex.LastRowTotal(ex.ws);
            var ObjectRange = ex.RangeLine(TableName);

            string[] Barra = new string[FinalRow];
            string[] Enxoval = new string[FinalRow];
            string[] Descricao = new string[FinalRow];
            string[] Cor = new string[FinalRow];
            string[] Tamanho = new string[FinalRow];
            string[] QtdHigienizações = new string[FinalRow];
            string[] Cadastro = new string[FinalRow];
            string[] Funcionario = new string[FinalRow];
            string[] Nome = new string[FinalRow];
            string[] Localização = new string[FinalRow];
            string[] Contrato = new string[FinalRow];

            Utils.CloseExcelCMD();

            for (int i = 1; i < FinalRow; i++)
            {
                if (i < FinalRow - 1)
                {
                    Barra[i - 1] = ObjectRange[i, 1].ToString();
                    Enxoval[i - 1] = ObjectRange[i, 4].ToString();
                    Descricao[i - 1] = ObjectRange[i, 4].ToString();
                    Cor[i - 1] = ObjectRange[i, 4].ToString();
                    Tamanho[i - 1] = ObjectRange[i, 4].ToString();
                    QtdHigienizações[i - 1] = ObjectRange[i, 4].ToString();
                    Cadastro[i - 1] = ObjectRange[i, 4].ToString();
                    Funcionario[i - 1] = ObjectRange[i, 4].ToString();
                    Nome[i - 1] = ObjectRange[i, 4].ToString();
                    Localização[i - 1] = ObjectRange[i, 4].ToString();
                    Contrato[i - 1] = ObjectRange[i, 4].ToString();
                }
            }

            for (int i = 1; i < FinalRow; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Barras"] = Barra[i];
                dr["Enxoval"] = Enxoval[i];
                dr["Descricao"] = Descricao[i];
                dr["Cor"] = Descricao[i];
                dr["Tamanho"] = Descricao[i];
                dr["QtdHigienizações"] = Descricao[i];
                dr["Cadastro"] = Descricao[i];
                dr["Funcionário"] = Descricao[i];
                dr["Nome"] = Descricao[i];
                dr["Localização"] = Descricao[i];
                dr["Contrato"] = Descricao[i];


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

        private void dataGridView2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.FillWeight = 10;    // <<this line will help you
        }
    }
}
