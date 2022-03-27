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
        public string newPath { get; set; }

        public string TableName { get; set; }
        string[] Barra = new string[0];
        string[] Enxoval = new string[0];
        string[] Descricao = new string[0];
        string[] Cor = new string[0];
        string[] Tamanho = new string[0];
        string[] QtdHigienizações = new string[0];
        string[] Cadastro = new string[0];
        string[] Funcionario = new string[0];
        string[] Nome = new string[0];
        string[] Localização = new string[0];
        string[] Contrato = new string[0];
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
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
            Utils.CloseExcelCMD();
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

                        MessageBox.Show($"Error:{ex.Message}");
                    }

                }
            }
        }

        public void OpenFile()
        {
            Excel excel = new Excel(path, 1);
            MessageBox.Show(excel.ReadCell(0, 0));
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

            Barra = new string[FinalRow];
            Enxoval = new string[FinalRow];
            Descricao = new string[FinalRow];
            Cor = new string[FinalRow];
            Tamanho = new string[FinalRow];
            QtdHigienizações = new string[FinalRow];
            Cadastro = new string[FinalRow];
            Funcionario = new string[FinalRow];
            Nome = new string[FinalRow];
            Localização = new string[FinalRow];
            Contrato = new string[FinalRow];

            Utils.CloseExcelCMD();

            for (int i = 1; i < FinalRow; i++)
            {
                if (i < FinalRow - 1)
                {
                    try
                    {
                        Barra[i - 1] = ObjectRange[i, 1].ToString();
                        Enxoval[i - 1] = ObjectRange[i, 4].ToString();
                        Descricao[i - 1] = ObjectRange[i, 5].ToString();
                        Cor[i - 1] = ObjectRange[i, 6].ToString();
                        Tamanho[i - 1] = ObjectRange[i, 23].ToString();
                        QtdHigienizações[i - 1] = ObjectRange[i, 30].ToString();
                        Cadastro[i - 1] = ObjectRange[i, 7].ToString();
                        Funcionario[i - 1] = ObjectRange[i, 2].ToString();
                        Nome[i - 1] = ObjectRange[i, 3].ToString();
                        Localização[i - 1] = ObjectRange[i, 16].ToString();
                        Contrato[i - 1] = ObjectRange[i, 20].ToString();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"{err}");
                    }

                }
            }

            for (int i = 1; i < FinalRow; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Barras"] = Barra[i];
                dr["Enxoval"] = Enxoval[i];
                dr["Descricao"] = Descricao[i];
                dr["Cor"] = Cor[i];
                dr["Tamanho"] = Tamanho[i];
                dr["QtdHigienizações"] = QtdHigienizações[i];
                dr["Cadastro"] = Cadastro[i];
                dr["Funcionário"] = Funcionario[i];
                dr["Nome"] = Nome[i];
                dr["Localização"] = Localização[i];
                dr["Contrato"] = Contrato[i];


                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }


        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Utils.CloseExcelCMD();
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

        private void btnSQL_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Select * from TESTE";
        }
        public void CreateNewSheet()
        {
            Excel ex = new Excel(path, 1);
            ex.CreateNewFile();
            newPath = $"{path}_Importacao.xlsx";
            ex.SaveAs(newPath);
            ex.Close();
            Utils.CloseExcelCMD();
        }

        private void btnDepara_Click(object sender, EventArgs e)
        {
            CreateNewSheet();
            Excel ex = new Excel(newPath, 1);
            ex.path = newPath;

            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Barra.Length;

            for (int i = 0; i < Barra.Length; i++)
            {
                progressBar1.Value = i;
                ex.WriteRange(Barra[i]              , "A", i + 1, "A", i + 1);
                ex.WriteRange(Enxoval[i]            , "B", i + 1, "B", i + 1);
                ex.WriteRange(Descricao[i]          , "B", i + 1, "B", i + 1);
                ex.WriteRange(Cor[i]                , "B", i + 1, "B", i + 1);
                ex.WriteRange(Tamanho[i]            , "B", i + 1, "B", i + 1);
                ex.WriteRange(QtdHigienizações[i]   , "B", i + 1, "B", i + 1);
                ex.WriteRange(Cadastro[i]           , "B", i + 1, "B", i + 1);
                ex.WriteRange(Funcionario[i]        , "B", i + 1, "B", i + 1);
                ex.WriteRange(Nome[i]               , "B", i + 1, "B", i + 1);
                ex.WriteRange(Localização[i]        , "B", i + 1, "B", i + 1);
                ex.WriteRange(Contrato[i]           , "B", i + 1, "B", i + 1);

            }
            progressBar1.Visible = false;
            MessageBox.Show("Importação Concluida");
            ex.Save();

        }
    }
}
