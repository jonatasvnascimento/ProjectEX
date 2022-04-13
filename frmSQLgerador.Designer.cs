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
            this.lblExit = new System.Windows.Forms.Label();
            this.btnGerarSQL = new System.Windows.Forms.Button();
            this.btnInsertDB = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxGeradorSQL
            // 
            this.tbxGeradorSQL.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGeradorSQL.Location = new System.Drawing.Point(341, 33);
            this.tbxGeradorSQL.Multiline = true;
            this.tbxGeradorSQL.Name = "tbxGeradorSQL";
            this.tbxGeradorSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxGeradorSQL.Size = new System.Drawing.Size(910, 401);
            this.tbxGeradorSQL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerador de SQL";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExit.Location = new System.Drawing.Point(1237, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(14, 17);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnGerarSQL
            // 
            this.btnGerarSQL.Location = new System.Drawing.Point(1014, 440);
            this.btnGerarSQL.Name = "btnGerarSQL";
            this.btnGerarSQL.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSQL.TabIndex = 3;
            this.btnGerarSQL.Text = "Gerar SQL";
            this.btnGerarSQL.UseVisualStyleBackColor = true;
            this.btnGerarSQL.Click += new System.EventHandler(this.btnGerarSQL_Click);
            // 
            // btnInsertDB
            // 
            this.btnInsertDB.Location = new System.Drawing.Point(1095, 440);
            this.btnInsertDB.Name = "btnInsertDB";
            this.btnInsertDB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertDB.TabIndex = 4;
            this.btnInsertDB.Text = "Insert DB";
            this.btnInsertDB.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(1176, 440);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilename.Location = new System.Drawing.Point(79, 443);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(496, 22);
            this.txtFilename.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Path";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.Location = new System.Drawing.Point(581, 443);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(618, 443);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 33);
            this.progressBar1.TabIndex = 9;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 33);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.Size = new System.Drawing.Size(323, 401);
            this.DataGridView1.TabIndex = 10;
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(79, 500);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSheet.TabIndex = 11;
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Location = new System.Drawing.Point(79, 471);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.Size = new System.Drawing.Size(496, 23);
            this.tbxNomeCliente.TabIndex = 12;
            this.tbxNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNomeCliente_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // frmSQLgerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNomeCliente);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnInsertDB);
            this.Controls.Add(this.btnGerarSQL);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxGeradorSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSQLgerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSQLgerador";
            this.Load += new System.EventHandler(this.frmSQLgerador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxGeradorSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnGerarSQL;
        private System.Windows.Forms.Button btnInsertDB;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.Label label3;
    }
}