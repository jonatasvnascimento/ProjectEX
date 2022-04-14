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
        string[] Indice = new string[0];
        string[] Barra = new string[0];
        string[] NovoProduto = new string[0];
        string[] ItemCTR = new string[0];
        string[] Enxoval = new string[0];
        string[] Descricao = new string[0];
        string[] Cor = new string[0];
        string[] Tamanho = new string[0];
        string[] QtdHigienizações = new string[0];
        string[] Cadastro = new string[0];
        string[] Funcionario = new string[0];
        string[] Nome = new string[0];
        string[] NumArm = new string[0];
        string[] NumGav = new string[0];
        string[] Localização = new string[0];
        string[] CodSet = new string[0];
        string[] DescSetor = new string[0];
        string[] Filial = new string[0];
        string[] NovoContrato = new string[0];
        string[] Contrato = new string[0];
        string[] Cliente = new string[0];
        string[] SQL = new string[0];


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
            copyDataGrid();
        }

        public void copyDataGrid()
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Visible = true;

            if (this.DataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        this.DataGridView1.GetClipboardContent());

                    // Replace the text box contents with the clipboard text.
                    this.tbxGeradorSQL.Text = Clipboard.GetText();
                    progressBar1.Value = 100;
                    MessageBox.Show("Criado com sucesso");
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    this.tbxGeradorSQL.Text =
                        "The Clipboard could not be accessed. Please try again.";
                }
            }
            progressBar1.Visible = false;

        }

        DataTableCollection TableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileExcel();
        }
        public void openFileExcel()
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
        public void getExcelValues()
        {
            Excel ex = new Excel(path, 1);

           


            if (!String.IsNullOrEmpty(path))
            {
                FinalRow = ex.LastRowTotal(ex.ws);
                ObjectRange = ex.RangeLine("HPRO");

               
                progressBar1.Visible = true;

                tbxGeradorSQL.Text = "('','CODBAR','PROUT','OLDPRO','DESPRO','TAM','QTD','DATA','CODFUN','NOMFUN','NUMARM','CODSET','DESSET','CONTR','OLDCLI','FILCTR','CODIMP','DTIMP','OBS','ITEMCT','DELETE','RECNO','NUMGAV','MSFIL','MSEMP','ARMLOCALI')";
                for (int i = 1; i < 5000; i++)
                {
                    progressBar1.Value = i - 1;
                    tbxGeradorSQL.AppendText(
                        $"('', " +
                        $"'{Barra[i]}', " +
                        $"'', " +
                        $"'{Enxoval[i]}', " +
                        $"'{Descricao[i]}', " +
                        $"'{Tamanho[i]}', " +
                        $"'{QtdHigienizações[i]}', " +
                        $"'{Cadastro[i]}', " +
                        $"'{Funcionario[i]}', " +
                        $"'{Nome[i]}', " +
                        $"'000000', " +
                        $"'', " +
                        $"'', " +
                        $"'{Contrato[i]}', " +
                        $"'{Cliente[i]}', " +
                        $"'{Filial[i]}', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'{Localização[i]}')");

                    tbxGeradorSQL.AppendText(Environment.NewLine);

                }
                progressBar1.Visible = false;

            }

        }

        private void frmSQLgerador_Load(object sender, EventArgs e)
        {
            this.DataGridView1.AutoResizeColumns();
            this.DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }
        private string valueField(object text) => isValid(text) ? text.ToString() : Convert.ToString(text);
        private bool isValid(object value) => value != null && value.GetType() == typeof(string);
        private void carregaLista()
        {
            System.Data.DataTable dt = new();

           

            dt.Columns.Add("SQL", typeof(string));
            dt.Columns.Add("Barras", typeof(string));
            dt.Columns.Add("NovoProduto", typeof(string));
            dt.Columns.Add("ItemCTR", typeof(string));
            dt.Columns.Add("Enxoval", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("Cor", typeof(string));
            dt.Columns.Add("Tamanho", typeof(string));
            dt.Columns.Add("QtdHigienizações", typeof(string));
            dt.Columns.Add("Cadastro", typeof(string));
            dt.Columns.Add("Funcionário", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("NumArm", typeof(string));
            dt.Columns.Add("NumGav", typeof(string));
            dt.Columns.Add("Localização", typeof(string));
            dt.Columns.Add("CodSet", typeof(string));
            dt.Columns.Add("DescSetor", typeof(string));
            dt.Columns.Add("Filial", typeof(string));
            dt.Columns.Add("Contrato", typeof(string));
            dt.Columns.Add("NovoContrato", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));

            Excel ex = new Excel(path, 1);
            FinalRow = ex.LastRowTotal(ex.ws);
            ObjectRange = ex.RangeLine(TableName);


            Barra = new string[FinalRow];
            NovoProduto = new string[FinalRow];
            ItemCTR = new string[FinalRow];
            Enxoval = new string[FinalRow];
            Descricao = new string[FinalRow];
            Cor = new string[FinalRow];
            Tamanho = new string[FinalRow];
            QtdHigienizações = new string[FinalRow];
            Cadastro = new string[FinalRow];
            Funcionario = new string[FinalRow];
            Nome = new string[FinalRow];
            NumArm = new string[FinalRow];
            NumGav = new string[FinalRow];
            Localização = new string[FinalRow];
            CodSet = new string[FinalRow];
            DescSetor = new string[FinalRow];
            Filial = new string[FinalRow];
            Filial = new string[FinalRow];
            NovoContrato = new string[FinalRow];
            Contrato = new string[FinalRow];
            Cliente = new string[FinalRow];

            Utils.CloseExcelCMD();
            try
            {
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = FinalRow;
                progressBar1.Visible = true;

                for (int i = 1; i < FinalRow; i++)
                {
                    if (i < FinalRow - 1)
                    {
                        progressBar1.Value = i;
                        Barra[i - 1] = valueField(ObjectRange[i, 2]);
                        NovoProduto[i - 1] = valueField(ObjectRange[i, 3]);
                        ItemCTR[i - 1] = valueField(ObjectRange[i, 4]);
                        Enxoval[i - 1] = valueField(ObjectRange[i, 5]);
                        Descricao[i - 1] = valueField(ObjectRange[i, 6]);
                        Cor[i - 1] = valueField(ObjectRange[i, 7]);
                        Tamanho[i - 1] = valueField(ObjectRange[i, 8]);
                        QtdHigienizações[i - 1] = valueField(ObjectRange[i, 9]);
                        Cadastro[i - 1] = valueField(ObjectRange[i, 10]);
                        Funcionario[i - 1] = valueField(ObjectRange[i, 11]);
                        Nome[i - 1] = valueField(ObjectRange[i, 12]);
                        NumArm[i - 1] = valueField(ObjectRange[i, 13]);
                        NumGav[i - 1] = valueField(ObjectRange[i, 14]);
                        Localização[i - 1] = valueField(ObjectRange[i, 15]);
                        CodSet[i - 1] = valueField(ObjectRange[i, 16]);
                        DescSetor[i - 1] = valueField(ObjectRange[i, 17]);
                        Filial[i - 1] = valueField(ObjectRange[i, 18]);
                        NovoContrato[i - 1] = valueField(ObjectRange[i, 19]);
                        Contrato[i - 1] = valueField(ObjectRange[i, 20]);
                    }
                }
                MessageBox.Show("Importação com sucesso");
                progressBar1.Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}");
            }

            for (int i = 1; i < FinalRow; i++)
            {//codbarr = slice(-6, 6, "000000" + variavel)
                DataRow dr = dt.NewRow();
                

                validaCampo(Barra[i], 10, Barra, i, false, false);
                validaCampo(NovoProduto[i], 15, NovoProduto, i, false, false);
                validaCampo(ItemCTR[i], 2, ItemCTR, i, false, false);
                validaCampo(Enxoval[i], 15, Enxoval, i, false, false);
                validaCampo(Descricao[i], 60, Descricao, i, false, false);
                validaCampo(Cor[i], 4, Cor, i, false, false);
                validaCampo(Tamanho[i], 2, Tamanho, i, false, false);
                validaCampo(QtdHigienizações[i], 8, QtdHigienizações, i, false, false);
                validaCampo(Cadastro[i], 8, Cadastro, i, true, false);
                validaCampo(Funcionario[i], 6, Funcionario, i, false, false);
                validaCampo(Nome[i], 100, Nome, i, false, false);
                validaCampo(NumArm[i], 6, NumArm, i, false, true);
                validaCampo(NumGav[i], 6, NumGav, i, false, true);
                validaCampo(Localização[i], 20, Localização, i, false, false);
                validaCampo(CodSet[i], 6, CodSet, i, false, false);
                validaCampo(DescSetor[i], 20, DescSetor, i, false, false);
                validaCampo(Filial[i], 2, Filial, i, false, false);
                validaCampo(NovoContrato[i], 6, NovoContrato, i, false, false);
                validaCampo(Contrato[i], 50, Contrato, i, false, false);
                validaCampo(Cliente[i], 50, Cliente, i, false, false);

                dr["SQL"] =
                        $"('', " +
                        $"'{Barra[i]}', " +
                        $"'{NovoProduto[i]}', " +
                        $"'{Enxoval[i]}', " +
                        $"'{Descricao[i]}', " +
                        $"'{Tamanho[i]}', " +
                        $"'{QtdHigienizações[i]}', " +
                        $"'{Cadastro[i]}', " +
                        $"'{Funcionario[i]}', " +
                        $"'{Nome[i]}', " +
                        $"'{NumArm[i]}', " +
                        $"'', " +
                        $"'', " +
                        $"'{NovoContrato[i]}', " +
                        $"'{Contrato[i]}', " +
                        $"'{Filial[i]}', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'', " +
                        $"'{Localização[i]}'),";
                dr["Barras"] = Barra[i];
                dr["NovoProduto"] = NovoProduto[i];
                dr["ItemCTR"] = ItemCTR[i];
                dr["Enxoval"] = Enxoval[i];
                dr["Descricao"] = Descricao[i];
                dr["Cor"] = Cor[i];
                dr["Tamanho"] = Tamanho[i];
                dr["QtdHigienizações"] = QtdHigienizações[i];
                dr["Cadastro"] = Cadastro[i];
                dr["Funcionário"] = Funcionario[i];
                dr["Nome"] = Nome[i];
                dr["NumArm"] = NumArm[i];
                dr["NumGav"] = NumGav[i];
                dr["Localização"] = Localização[i];
                dr["CodSet"] = CodSet[i];
                dr["DescSetor"] = DescSetor[i];
                dr["Filial"] = Filial[i];
                dr["Contrato"] = Contrato[i];
                dr["NovoContrato"] = NovoContrato[i];
                dr["Cliente"] = tbxNomeCliente.Text;
                
                dt.Rows.Add(dr);
            }
            DataGridView1.DataSource = dt;
        }

        public void validaCampo(string campo, int tamanho, string[] array, int index, bool date, bool armario)
        {
            if (isValid(campo))
            {
                if (campo.Length > tamanho)
                {
                    array[index] = campo.Substring(campo.Length - tamanho);
                }
            }

            if (armario)
            {
                if (NumArm[index] == "")
                {
                array[index] = "000000";
                }
            }

            if (isValid(campo))
            {
                if (date)
                {
                    var newDate = $"{campo.Substring(6, 4)}{campo.Substring(3, 2)}{campo.Substring(0, 2)}";
                    //MessageBox.Show(newDate);
                    array[index] = newDate;
                }
            }
           
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
        }
        public void injectSQL()
        {
            Excel ex = new Excel(path, 1);
            string sql = "('','CODBAR','PROUT','OLDPRO','DESPRO','TAM','QTD','DATA','CODFUN','NOMFUN','NUMARM','CODSET','DESSET','CONTR','OLDCLI','FILCTR','CODIMP','DTIMP','OBS','ITEMCT','DELETE','RECNO','NUMGAV','MSFIL','MSEMP','ARMLOCALI')";
            string teste = "=SUM(V2:V10)";

            //ex.WriteRange(sql, "W", 1, "W", 1);
            //ex.WriteRange(teste, "W", 2, "W", 10);
            //ex.formulaInExcel("U2","U10", teste);

            ex.Save();
            ex.Close();
            carregaLista();
            Utils.CloseExcelCMD();
        }

        private void tbxNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carregaLista();
            }
        }
    }
}
