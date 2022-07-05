namespace ProjectEX
{
    partial class frmDepara
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepara = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbxImportPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelectEx = new System.Windows.Forms.Button();
            this.btnOpenLocal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(206, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 630);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path";
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(271, 680);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.Size = new System.Drawing.Size(462, 25);
            this.comboBoxSheet.TabIndex = 1;
            this.comboBoxSheet.Visible = false;
            this.comboBoxSheet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSheet_SelectedIndexChanged);
            // 
            // txtFilename
            // 
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilename.Location = new System.Drawing.Point(271, 648);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(462, 22);
            this.txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet";
            this.label2.Visible = false;
            // 
            // btnDepara
            // 
            this.btnDepara.BackColor = System.Drawing.Color.DimGray;
            this.btnDepara.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepara.FlatAppearance.BorderSize = 0;
            this.btnDepara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepara.ForeColor = System.Drawing.Color.White;
            this.btnDepara.Location = new System.Drawing.Point(0, 100);
            this.btnDepara.Margin = new System.Windows.Forms.Padding(0);
            this.btnDepara.Name = "btnDepara";
            this.btnDepara.Size = new System.Drawing.Size(200, 49);
            this.btnDepara.TabIndex = 3;
            this.btnDepara.Text = "Gerar Planilha Depara";
            this.btnDepara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepara.UseVisualStyleBackColor = false;
            this.btnDepara.Click += new System.EventHandler(this.btnDepara_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1129, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(106, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // tbxImportPath
            // 
            this.tbxImportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxImportPath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxImportPath.Location = new System.Drawing.Point(805, 648);
            this.tbxImportPath.Name = "tbxImportPath";
            this.tbxImportPath.ReadOnly = true;
            this.tbxImportPath.Size = new System.Drawing.Size(449, 22);
            this.tbxImportPath.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Imp Path";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnSelectEx);
            this.panel1.Controls.Add(this.btnOpenLocal);
            this.panel1.Controls.Add(this.btnDepara);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 715);
            this.panel1.TabIndex = 19;
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
            // btnSelectEx
            // 
            this.btnSelectEx.BackColor = System.Drawing.Color.DimGray;
            this.btnSelectEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectEx.FlatAppearance.BorderSize = 0;
            this.btnSelectEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEx.ForeColor = System.Drawing.Color.White;
            this.btnSelectEx.Location = new System.Drawing.Point(0, 198);
            this.btnSelectEx.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectEx.Name = "btnSelectEx";
            this.btnSelectEx.Size = new System.Drawing.Size(200, 49);
            this.btnSelectEx.TabIndex = 7;
            this.btnSelectEx.Text = "Selecione uma Planilha";
            this.btnSelectEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectEx.UseVisualStyleBackColor = false;
            this.btnSelectEx.Click += new System.EventHandler(this.btnSelectEx_Click);
            // 
            // btnOpenLocal
            // 
            this.btnOpenLocal.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenLocal.FlatAppearance.BorderSize = 0;
            this.btnOpenLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLocal.ForeColor = System.Drawing.Color.White;
            this.btnOpenLocal.Location = new System.Drawing.Point(0, 149);
            this.btnOpenLocal.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenLocal.Name = "btnOpenLocal";
            this.btnOpenLocal.Size = new System.Drawing.Size(200, 49);
            this.btnOpenLocal.TabIndex = 6;
            this.btnOpenLocal.Text = "Abrir local";
            this.btnOpenLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenLocal.UseVisualStyleBackColor = false;
            this.btnOpenLocal.Click += new System.EventHandler(this.btnOpenLocal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1266, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxImportPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepara;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbxImportPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectEx;
        private System.Windows.Forms.Button btnOpenLocal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
    }
}
