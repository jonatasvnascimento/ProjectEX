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
    public partial class frmSQLgerador : Form
    {
        public string path { get; private set; }
        public int FinalRow { get; private set; }
        public object[,] ObjectRange { get; private set; }

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

        public frmSQLgerador()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
            Utils.CloseExcelCMD();
        }

        private void btnGerarSQL_Click(object sender, EventArgs e)
        {
            if (this.DataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        this.DataGridView1.GetClipboardContent());

                    // Replace the text box contents with the clipboard text.
                    this.tbxGeradorSQL.Text = Clipboard.GetText();
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    this.tbxGeradorSQL.Text =
                        "The Clipboard could not be accessed. Please try again.";
                }
            }
            carregaLista();
        }

        DataTableCollection TableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Filtro para acher as planilhas
            Utils.CloseExcelCMD();
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*xls" })
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
        private bool IsValid(object value) => value != null && value.GetType() == typeof(string);
        public void getExcelValues()
        {
            Excel ex = new Excel(path, 1);

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 5000;

            string Y2;

            string sql = "('','CODBAR','PROUT','OLDPRO','DESPRO','TAM','QTD','DATA','CODFUN','NOMFUN','NUMARM','CODSET','DESSET','CONTR','OLDCLI','FILCTR','CODIMP','DTIMP','OBS','ITEMCT','DELETE','RECNO','NUMGAV','MSFIL','MSEMP','ARMLOCALI')";
            string sqlGetValues = "=02";
            
            ex.WriteRange(sql, "W", 1, "W", 1);
            ex.WriteRange(sqlGetValues, "W", 1, "W", 2);


            ex.Save();
            ex.Close();
            carregaLista();
            Utils.CloseExcelCMD();

            //if (!String.IsNullOrEmpty(path))
            //{
            //    FinalRow = ex.LastRowTotal(ex.ws);
            //    ObjectRange = ex.RangeLine("HPRO");


            //    //progressBar1.Visible = true;
            //    //for (int i = 0; i < 1000; i++)
            //    //{
            //    //    progressBar1.Value = i;
            //    //    tbxGeradorSQL.AppendText(i.ToString());
            //    //    tbxGeradorSQL.AppendText(Environment.NewLine);
            //    //}
            //    //progressBar1.Visible = false;

            //}

        }

        private void frmSQLgerador_Load(object sender, EventArgs e)
        {
            //this.DataGridView1.DataSource = "";
            //this.DataGridView1.ColumnCount = 5;
            //this.DataGridView1.Rows.Add(new string[] { "A", "B", "C", "D", "E" });
            //this.DataGridView1.Rows.Add(new string[] { "F", "G", "H", "I", "J" });
            //this.DataGridView1.Rows.Add(new string[] { "K", "L", "M", "N", "O" });
            //this.DataGridView1.Rows.Add(new string[] { "P", "Q", "R", "S", "T" });
            //this.DataGridView1.Rows.Add(new string[] { "U", "V", "W", "X", "Y" });
            this.DataGridView1.AutoResizeColumns();
            this.DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }
        private string valueField(object text) => isValid(text) ? text.ToString() : "";
        private bool isValid(object value) => value != null && value.GetType() == typeof(string);
        private void carregaLista()
        {
            System.Data.DataTable dt = new();

            dt.Columns.Add("Barras", typeof(string));

            Excel ex = new Excel(path, 1);
            FinalRow = ex.LastRowTotal(ex.ws);
            ObjectRange = ex.RangeLine(TableName);
            Barra = new string[FinalRow];
            

            Utils.CloseExcelCMD();
            try
            {
                for (int i = 1; i < FinalRow; i++)
                {
                    if (i < FinalRow - 1)
                    {
                        Barra[i - 1] = valueField(ObjectRange[i, 23]);
                       
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
                
                dt.Rows.Add(dr);
            }
            DataGridView1.DataSource = dt;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
        }
    }
}
