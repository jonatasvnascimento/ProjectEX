﻿using ProjectEX.view;
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
            lblVersion.Text = "1.1.0";
        }

        private void leituraDeparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepara form1 = new frmDepara();
            this.Hide();
            form1.Show();

        }

        private void gerarSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSQLgerador frmSQLgerador = new frmSQLgerador();
            this.Hide();
            frmSQLgerador.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbnDepara_Click(object sender, EventArgs e)
        {
            frmDepara form1 = new frmDepara();
            this.Hide();
            form1.Show();
        }

        private void btnGerador_Click(object sender, EventArgs e)
        {
            frmSQLgerador frmSQLgerador = new frmSQLgerador();
            this.Hide();
            frmSQLgerador.Show();
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnServers_Click(object sender, EventArgs e)
        {
            frmServidores frmServidores = new frmServidores();
            this.Hide();
            frmServidores.Show();
        }
    }
}
