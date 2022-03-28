﻿using ExcelDataReader;
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
        public object[,] ObjectRange;
        int FinalRow;

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
            //dataGridView1.DataSource = dt;
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
            FinalRow = ex.LastRowTotal(ex.ws);
            ObjectRange = ex.RangeLine(TableName);

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

            try
            {
                for (int i = 1; i < FinalRow; i++)
                {
                    if (i < FinalRow - 1)
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
                }

            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}");
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

            MessageBox.Show("Carregamento com sucesso");
            dataGridView1.DataSource = dt;



        }


        private void label3_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal  = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
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
        public void CreateNewSheet(string nameFile)
        {
            Excel ex = new Excel(path, 1);
            ex.CreateNewFile();
            newPath = $"{path}_{nameFile}.xlsx";
            ex.SaveAs(newPath);
            ex.Close();
            Utils.CloseExcelCMD();
        }

        private void btnDepara_Click(object sender, EventArgs e)
        {
            testeSave();
        }
        public void testeSave()
        {
            CreateNewSheet("Teste");
            Excel ex = new Excel(path, 1);
            tbxImportPath.Text = path;

            string newPath2 = $"{path}_Teste.xlsx";
            ex.inserColunm("I1");
            ex.deleteColunm("N");

            ex.SaveAs(newPath2);
        }
        public void Depara()
        {
            //CreateNewSheet("Importação");
            Excel ex = new Excel(newPath, 1);
            ex.path = newPath;

            tbxImportPath.Text = newPath;

            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = FinalRow;

            ex.WriteRange("INDICE", "A", 1, "A", 1);
            ex.WriteRange("NOVO PROD", "C", 1, "C", 1);
            ex.WriteRange("ITEM CTR", "D", 1, "D", 1);
            ex.WriteRange("NUM ARM", "M", 1, "M", 1);
            ex.WriteRange("NUM GAV", "N", 1, "N", 1);
            ex.WriteRange("COD SET", "P", 1, "P", 1);
            ex.WriteRange("DESC SETOR", "Q", 1, "Q", 1);
            ex.WriteRange("FILIAL", "D", 1, "D", 1);
            ex.WriteRange("NOVO CONTRATO", "S", 1, "S", 1);

            for (int i = 1; i < FinalRow; i++)
            {
                progressBar1.Value = i;
                if (i < FinalRow - 1)
                {
                    ex.WriteRange(i.ToString(), "A", i + 1, "A", i + 1);   /* Indice*/
                    ex.WriteRange(ObjectRange[i, 1].ToString(), "B", i, "B", i);   /* Barras*/
                    ex.WriteRange(ObjectRange[i, 4].ToString(), "E", i, "E", i);   /* Enxoval*/
                    ex.WriteRange(ObjectRange[i, 5].ToString(), "F", i, "F", i);   /* Descricao*/
                    ex.WriteRange(ObjectRange[i, 6].ToString(), "G", i, "G", i);   /* Cor*/
                    ex.WriteRange(ObjectRange[i, 23].ToString(), "H", i, "H", i);  /* Tamanho*/
                    ex.WriteRange(ObjectRange[i, 30].ToString(), "I", i, "I", i);  /* QtdHigienizações*/
                    ex.WriteRange(ObjectRange[i, 7].ToString(), "J", i, "J", i);   /* Cadastro*/
                    ex.WriteRange(ObjectRange[i, 2].ToString(), "K", i, "K", i);   /* Funcionário */
                    ex.WriteRange(ObjectRange[i, 3].ToString(), "L", i, "L", i);   /* Nome*/
                    ex.WriteRange(ObjectRange[i, 16].ToString(), "P", i, "P", i);  /* Localização*/
                    ex.WriteRange(ObjectRange[i, 20].ToString(), "T", i, "T", i);  /* Contrato*/
                }
            }
            progressBar1.Visible = false;

            MessageBox.Show("Importação Concluida");
            ex.Save();
            ex.Close();
            Utils.CloseExcelCMD();
        }
    }
}
