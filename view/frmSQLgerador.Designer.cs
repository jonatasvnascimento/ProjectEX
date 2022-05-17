namespace ProjectEX
{
    partial class frmSQLgerador
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
            this.tbxGeradorSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpenEx = new System.Windows.Forms.Button();
            this.btnGerarSQL = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContRowsEx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxGeradorSQL
            // 
            this.tbxGeradorSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGeradorSQL.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGeradorSQL.Location = new System.Drawing.Point(206, 313);
            this.tbxGeradorSQL.Multiline = true;
            this.tbxGeradorSQL.Name = "tbxGeradorSQL";
            this.tbxGeradorSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxGeradorSQL.Size = new System.Drawing.Size(1048, 284);
            this.tbxGeradorSQL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerador de SQL";
            // 
            // txtFilename
            // 
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilename.Location = new System.Drawing.Point(270, 609);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(496, 22);
            this.txtFilename.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Path";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1084, 555);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(206, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.Size = new System.Drawing.Size(1048, 295);
            this.DataGridView1.TabIndex = 10;
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNomeCliente.Location = new System.Drawing.Point(270, 640);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.Size = new System.Drawing.Size(496, 23);
            this.tbxNomeCliente.TabIndex = 12;
            this.tbxNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNomeCliente_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // btnTxt
            // 
            this.btnTxt.BackColor = System.Drawing.Color.DimGray;
            this.btnTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTxt.FlatAppearance.BorderSize = 0;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTxt.ForeColor = System.Drawing.Color.White;
            this.btnTxt.Location = new System.Drawing.Point(0, 100);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(200, 49);
            this.btnTxt.TabIndex = 14;
            this.btnTxt.Text = "Import SQL";
            this.btnTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnOpenEx);
            this.panel1.Controls.Add(this.btnGerarSQL);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnTxt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 715);
            this.panel1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "Copy";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnOpenEx
            // 
            this.btnOpenEx.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenEx.FlatAppearance.BorderSize = 0;
            this.btnOpenEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenEx.ForeColor = System.Drawing.Color.White;
            this.btnOpenEx.Location = new System.Drawing.Point(0, 198);
            this.btnOpenEx.Name = "btnOpenEx";
            this.btnOpenEx.Size = new System.Drawing.Size(200, 49);
            this.btnOpenEx.TabIndex = 16;
            this.btnOpenEx.Text = "Open Excel";
            this.btnOpenEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenEx.UseVisualStyleBackColor = false;
            this.btnOpenEx.Click += new System.EventHandler(this.btnOpenEx_Click);
            // 
            // btnGerarSQL
            // 
            this.btnGerarSQL.BackColor = System.Drawing.Color.DimGray;
            this.btnGerarSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerarSQL.FlatAppearance.BorderSize = 0;
            this.btnGerarSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSQL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerarSQL.ForeColor = System.Drawing.Color.White;
            this.btnGerarSQL.Location = new System.Drawing.Point(0, 149);
            this.btnGerarSQL.Name = "btnGerarSQL";
            this.btnGerarSQL.Size = new System.Drawing.Size(200, 49);
            this.btnGerarSQL.TabIndex = 15;
            this.btnGerarSQL.Text = "Gerar SQL View";
            this.btnGerarSQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarSQL.UseVisualStyleBackColor = false;
            this.btnGerarSQL.Click += new System.EventHandler(this.btnGerarSQL_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 666);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 49);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // lblContRowsEx
            // 
            this.lblContRowsEx.AutoSize = true;
            this.lblContRowsEx.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContRowsEx.Location = new System.Drawing.Point(216, 21);
            this.lblContRowsEx.Name = "lblContRowsEx";
            this.lblContRowsEx.Size = new System.Drawing.Size(25, 22);
            this.lblContRowsEx.TabIndex = 21;
            this.lblContRowsEx.Text = "...";
            // 
            // frmSQLgerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1266, 715);
            this.Controls.Add(this.lblContRowsEx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNomeCliente);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxGeradorSQL);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSQLgerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSQLgerador";
            this.Load += new System.EventHandler(this.frmSQLgerador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxGeradorSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGerarSQL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOpenEx;
        private System.Windows.Forms.Label lblContRowsEx;
    }
}