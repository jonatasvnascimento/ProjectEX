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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void leituraDeparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.Show();

        }

        private void gerarSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSQLgerador frmSQLgerador = new frmSQLgerador();
            this.Hide();
            frmSQLgerador.Show();
        }
    }
}
