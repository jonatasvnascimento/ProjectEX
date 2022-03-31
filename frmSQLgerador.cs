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
            if (this.DataGridView1
         .GetCellCount(DataGridViewElementStates.Selected) > 0)
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

        }

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
                }
            }
        }
        private bool isValid(object value) => value != null && value.GetType() == typeof(string);
        public void getExcelValues()
        {
            Excel ex = new Excel(path, 1);

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 5000;

            string sql = @"('','CODBAR','PROUT','OLDPRO','DESPRO','TAM','QTD','DATA','CODFUN','NOMFUN','NUMARM','CODSET','DESSET','CONTR','OLDCLI','FILCTR','CODIMP','DTIMP','OBS','ITEMCT','DELETE','RECNO','NUMGAV','MSFIL','MSEMP','ARMLOCALI')";
            string teste = $"('','1231511215','','0001.0073','Calça Convencional 67/33','G','83','20191002','1','ADNILSON DE CARVALHO','000000','','','','190916_I','','','','','','','','','','Cliente')";

            if (!String.IsNullOrEmpty(path))
            {
                FinalRow = ex.LastRowTotal(ex.ws);
                ObjectRange = ex.RangeLine("HPRO");

                progressBar1.Visible = true;

                for (int i = 0; i < 1000; i++)
                {
                    progressBar1.Value = i;
                    tbxGeradorSQL.AppendText(i.ToString());
                    tbxGeradorSQL.AppendText(Environment.NewLine);
                }

                progressBar1.Visible = false;

            }



        }

        private void frmSQLgerador_Load(object sender, EventArgs e)
        {
            this.DataGridView1.ColumnCount = 5;
            this.DataGridView1.Rows.Add(new string[] { "A", "B", "C", "D", "E" });
            this.DataGridView1.Rows.Add(new string[] { "F", "G", "H", "I", "J" });
            this.DataGridView1.Rows.Add(new string[] { "K", "L", "M", "N", "O" });
            this.DataGridView1.Rows.Add(new string[] { "P", "Q", "R", "S", "T" });
            this.DataGridView1.Rows.Add(new string[] { "U", "V", "W", "X", "Y" });
            this.DataGridView1.AutoResizeColumns();
            this.DataGridView1.ClipboardCopyMode =
                DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }
    }
}
