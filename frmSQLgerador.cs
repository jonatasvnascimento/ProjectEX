using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEX
{
    public partial class frmSQLgerador : Form
    {
        public frmSQLgerador()
        {
            InitializeComponent();
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
            tbxGeradorSQL.Text = @"('','CODBAR','PROUT','OLDPRO','DESPRO','TAM','QTD','DATA','CODFUN','NOMFUN','NUMARM','CODSET','DESSET','CONTR','OLDCLI','FILCTR','CODIMP','DTIMP','OBS','ITEMCT','DELETE','RECNO','NUMGAV','MSFIL','MSEMP','ARMLOCALI')
                                   ('','0319177095','','0001.0073','Calça Convencional 67/33','G','83','20191002','1','ADNILSON DE CARVALHO','000000','','','','190916_I','','','','','','','','','','Cliente'),";
        }
    }
}
