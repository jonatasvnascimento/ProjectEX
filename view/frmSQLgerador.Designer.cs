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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolderFinish = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpenEx = new System.Windows.Forms.Button();
            this.btnGerarSQL = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContRowsEx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxGeradorSQL
            // 
            this.tbxGeradorSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGeradorSQL.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGeradorSQL.Location = new System.Drawing.Point(206, 552);
            this.tbxGeradorSQL.Multiline = true;
            this.tbxGeradorSQL.Name = "tbxGeradorSQL";
            this.tbxGeradorSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxGeradorSQL.Size = new System.Drawing.Size(1048, 96);
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
            this.txtFilename.Location = new System.Drawing.Point(270, 654);
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
            this.label2.Location = new System.Drawing.Point(206, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Path";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1088, 612);
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
            this.DataGridView1.Size = new System.Drawing.Size(1048, 534);
            this.DataGridView1.TabIndex = 10;
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNomeCliente.Location = new System.Drawing.Point(270, 685);
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
            this.label3.Location = new System.Drawing.Point(206, 685);
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
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnOpenFolderFinish);
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
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.DimGray;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(0, 394);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(200, 49);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 345);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(200, 49);
            this.btnOpenFile.TabIndex = 19;
            this.btnOpenFile.Text = "Open File Confirm";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolderFinish
            // 
            this.btnOpenFolderFinish.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenFolderFinish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFolderFinish.FlatAppearance.BorderSize = 0;
            this.btnOpenFolderFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderFinish.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFolderFinish.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolderFinish.Location = new System.Drawing.Point(0, 296);
            this.btnOpenFolderFinish.Name = "btnOpenFolderFinish";
            this.btnOpenFolderFinish.Size = new System.Drawing.Size(200, 49);
            this.btnOpenFolderFinish.TabIndex = 18;
            this.btnOpenFolderFinish.Text = "Open Folder Finish";
            this.btnOpenFolderFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolderFinish.UseVisualStyleBackColor = false;
            this.btnOpenFolderFinish.Click += new System.EventHandler(this.btnOpenFolderFinish_Click);
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
            this.lblContRowsEx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContRowsEx.ForeColor = System.Drawing.Color.White;
            this.lblContRowsEx.Location = new System.Drawing.Point(825, 656);
            this.lblContRowsEx.Name = "lblContRowsEx";
            this.lblContRowsEx.Size = new System.Drawing.Size(17, 17);
            this.lblContRowsEx.TabIndex = 21;
            this.lblContRowsEx.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(772, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Linhas:";
            // 
            // frmSQLgerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1266, 715);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenFolderFinish;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnReload;
    }
}