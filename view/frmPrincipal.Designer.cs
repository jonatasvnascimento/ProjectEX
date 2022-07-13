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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServers = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerador = new System.Windows.Forms.Button();
            this.tbnDepara = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnServers);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnGerador);
            this.panel1.Controls.Add(this.tbnDepara);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 953);
            this.panel1.TabIndex = 1;
            // 
            // btnServers
            // 
            this.btnServers.BackColor = System.Drawing.Color.Gray;
            this.btnServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServers.FlatAppearance.BorderSize = 0;
            this.btnServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServers.ForeColor = System.Drawing.Color.White;
            this.btnServers.Location = new System.Drawing.Point(0, 198);
            this.btnServers.Margin = new System.Windows.Forms.Padding(0);
            this.btnServers.Name = "btnServers";
            this.btnServers.Padding = new System.Windows.Forms.Padding(1);
            this.btnServers.Size = new System.Drawing.Size(200, 49);
            this.btnServers.TabIndex = 6;
            this.btnServers.Text = "Servidores";
            this.btnServers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServers.UseVisualStyleBackColor = false;
            this.btnServers.Click += new System.EventHandler(this.btnServers_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 904);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 49);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerador
            // 
            this.btnGerador.BackColor = System.Drawing.Color.Gray;
            this.btnGerador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerador.FlatAppearance.BorderSize = 0;
            this.btnGerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerador.ForeColor = System.Drawing.Color.White;
            this.btnGerador.Location = new System.Drawing.Point(0, 149);
            this.btnGerador.Margin = new System.Windows.Forms.Padding(0);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Padding = new System.Windows.Forms.Padding(1);
            this.btnGerador.Size = new System.Drawing.Size(200, 49);
            this.btnGerador.TabIndex = 4;
            this.btnGerador.Text = "Gerador SQL";
            this.btnGerador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerador.UseVisualStyleBackColor = false;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // tbnDepara
            // 
            this.tbnDepara.BackColor = System.Drawing.Color.Gray;
            this.tbnDepara.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbnDepara.FlatAppearance.BorderSize = 0;
            this.tbnDepara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnDepara.ForeColor = System.Drawing.Color.White;
            this.tbnDepara.Location = new System.Drawing.Point(0, 100);
            this.tbnDepara.Margin = new System.Windows.Forms.Padding(0);
            this.tbnDepara.Name = "tbnDepara";
            this.tbnDepara.Padding = new System.Windows.Forms.Padding(1);
            this.tbnDepara.Size = new System.Drawing.Size(200, 49);
            this.tbnDepara.TabIndex = 3;
            this.tbnDepara.Text = "Leitura e Depara";
            this.tbnDepara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnDepara.UseVisualStyleBackColor = false;
            this.tbnDepara.Click += new System.EventHandler(this.tbnDepara_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjectEX";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.lblVersion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 953);
            this.panel3.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1172, 918);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(524, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOME";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1447, 953);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tbnDepara;
        private System.Windows.Forms.Button btnGerador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnServers;
    }
}