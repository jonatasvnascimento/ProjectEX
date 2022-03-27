namespace ProjectEX
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.planilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leituraDeparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planilhaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // planilhaToolStripMenuItem
            // 
            this.planilhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leituraDeparaToolStripMenuItem,
            this.gerarSQLToolStripMenuItem});
            this.planilhaToolStripMenuItem.Name = "planilhaToolStripMenuItem";
            this.planilhaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.planilhaToolStripMenuItem.Text = "Planilha";
            // 
            // leituraDeparaToolStripMenuItem
            // 
            this.leituraDeparaToolStripMenuItem.Name = "leituraDeparaToolStripMenuItem";
            this.leituraDeparaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leituraDeparaToolStripMenuItem.Text = "Leitura Depara";
            this.leituraDeparaToolStripMenuItem.Click += new System.EventHandler(this.leituraDeparaToolStripMenuItem_Click);
            // 
            // gerarSQLToolStripMenuItem
            // 
            this.gerarSQLToolStripMenuItem.Name = "gerarSQLToolStripMenuItem";
            this.gerarSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerarSQLToolStripMenuItem.Text = "Gerar SQL";
            this.gerarSQLToolStripMenuItem.Click += new System.EventHandler(this.gerarSQLToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leituraDeparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarSQLToolStripMenuItem;
    }
}