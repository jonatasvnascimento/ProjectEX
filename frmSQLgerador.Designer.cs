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
            this.SuspendLayout();
            // 
            // tbxGeradorSQL
            // 
            this.tbxGeradorSQL.Location = new System.Drawing.Point(12, 33);
            this.tbxGeradorSQL.Multiline = true;
            this.tbxGeradorSQL.Name = "tbxGeradorSQL";
            this.tbxGeradorSQL.Size = new System.Drawing.Size(1239, 401);
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
            this.btnGerarSQL.Location = new System.Drawing.Point(12, 440);
            this.btnGerarSQL.Name = "btnGerarSQL";
            this.btnGerarSQL.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSQL.TabIndex = 3;
            this.btnGerarSQL.Text = "Gerar SQL";
            this.btnGerarSQL.UseVisualStyleBackColor = true;
            this.btnGerarSQL.Click += new System.EventHandler(this.btnGerarSQL_Click);
            // 
            // btnInsertDB
            // 
            this.btnInsertDB.Location = new System.Drawing.Point(93, 440);
            this.btnInsertDB.Name = "btnInsertDB";
            this.btnInsertDB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertDB.TabIndex = 4;
            this.btnInsertDB.Text = "Insert DB";
            this.btnInsertDB.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(174, 440);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // frmSQLgerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 475);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnInsertDB);
            this.Controls.Add(this.btnGerarSQL);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxGeradorSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSQLgerador";
            this.Text = "frmSQLgerador";
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
    }
}