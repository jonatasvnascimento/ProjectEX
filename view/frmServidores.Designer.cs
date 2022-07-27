namespace ProjectEX.view
{
    partial class frmServidores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServidores));
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbxPathTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1172, 918);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(9, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(1);
            this.btnBack.Size = new System.Drawing.Size(57, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.DarkGray;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(78, 9);
            this.btnGo.Margin = new System.Windows.Forms.Padding(0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Padding = new System.Windows.Forms.Padding(1);
            this.btnGo.Size = new System.Drawing.Size(57, 31);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbxPathTextBox
            // 
            this.tbxPathTextBox.BackColor = System.Drawing.Color.White;
            this.tbxPathTextBox.Location = new System.Drawing.Point(151, 9);
            this.tbxPathTextBox.Multiline = true;
            this.tbxPathTextBox.Name = "tbxPathTextBox";
            this.tbxPathTextBox.Size = new System.Drawing.Size(1195, 31);
            this.tbxPathTextBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1360, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(1);
            this.button2.Size = new System.Drawing.Size(57, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.lblFileType);
            this.panel3.Controls.Add(this.lblFileName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.tbxPathTextBox);
            this.panel3.Controls.Add(this.btnGo);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.lblVersion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1429, 906);
            this.panel3.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(9, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1408, 787);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Audio file.ico");
            this.iconList.Images.SetKeyName(1, "Audio.ico");
            this.iconList.Images.SetKeyName(2, "Blank.ico");
            this.iconList.Images.SetKeyName(3, "Briefcase.ico");
            this.iconList.Images.SetKeyName(4, "Camera.ico");
            this.iconList.Images.SetKeyName(5, "Computer.ico");
            this.iconList.Images.SetKeyName(6, "config.ico");
            this.iconList.Images.SetKeyName(7, "Control Panel.ico");
            this.iconList.Images.SetKeyName(8, "Defrag.ico");
            this.iconList.Images.SetKeyName(9, "Desktop.ico");
            this.iconList.Images.SetKeyName(10, "Device 2.ico");
            this.iconList.Images.SetKeyName(11, "Device.ico");
            this.iconList.Images.SetKeyName(12, "dll.ico");
            this.iconList.Images.SetKeyName(13, "exe.ico");
            this.iconList.Images.SetKeyName(14, "Explorer.ico");
            this.iconList.Images.SetKeyName(15, "Folder 3D.ico");
            this.iconList.Images.SetKeyName(16, "Folder Blue.ico");
            this.iconList.Images.SetKeyName(17, "Folder check.ico");
            this.iconList.Images.SetKeyName(18, "Folder Contacts.ico");
            this.iconList.Images.SetKeyName(19, "Folder Desktop.ico");
            this.iconList.Images.SetKeyName(20, "Folder Documents.ico");
            this.iconList.Images.SetKeyName(21, "Folder Downloads.ico");
            this.iconList.Images.SetKeyName(22, "Folder Favourites.ico");
            this.iconList.Images.SetKeyName(23, "Folder Fonts.ico");
            this.iconList.Images.SetKeyName(24, "Folder Games.ico");
            this.iconList.Images.SetKeyName(25, "Folder Green.ico");
            this.iconList.Images.SetKeyName(26, "Folder Grey.ico");
            this.iconList.Images.SetKeyName(27, "Folder Links 2.ico");
            this.iconList.Images.SetKeyName(28, "Folder Links.ico");
            this.iconList.Images.SetKeyName(29, "Folder Live - Back.ico");
            this.iconList.Images.SetKeyName(30, "Folder Live - Front.ico");
            this.iconList.Images.SetKeyName(31, "Folder Music.ico");
            this.iconList.Images.SetKeyName(32, "Folder OneDrive.ico");
            this.iconList.Images.SetKeyName(33, "Folder Open.ico");
            this.iconList.Images.SetKeyName(34, "Folder Pictures.ico");
            this.iconList.Images.SetKeyName(35, "Folder Search.ico");
            this.iconList.Images.SetKeyName(36, "Folder User 2.ico");
            this.iconList.Images.SetKeyName(37, "Folder User.ico");
            this.iconList.Images.SetKeyName(38, "Folder Videos.ico");
            this.iconList.Images.SetKeyName(39, "Folder.ico");
            this.iconList.Images.SetKeyName(40, "Hardware.ico");
            this.iconList.Images.SetKeyName(41, "Help 2.ico");
            this.iconList.Images.SetKeyName(42, "Help.ico");
            this.iconList.Images.SetKeyName(43, "History.ico");
            this.iconList.Images.SetKeyName(44, "HomeGroup.ico");
            this.iconList.Images.SetKeyName(45, "Hotspot.ico");
            this.iconList.Images.SetKeyName(46, "Info.ico");
            this.iconList.Images.SetKeyName(47, "Key.ico");
            this.iconList.Images.SetKeyName(48, "Keyboard.ico");
            this.iconList.Images.SetKeyName(49, "Library Library.ico");
            this.iconList.Images.SetKeyName(50, "Library Music.ico");
            this.iconList.Images.SetKeyName(51, "Library TV.ico");
            this.iconList.Images.SetKeyName(52, "Library Videos.ico");
            this.iconList.Images.SetKeyName(53, "Library.ico");
            this.iconList.Images.SetKeyName(54, "Libray Documents.ico");
            this.iconList.Images.SetKeyName(55, "Libray Pictures.ico");
            this.iconList.Images.SetKeyName(56, "Link.ico");
            this.iconList.Images.SetKeyName(57, "Lock.ico");
            this.iconList.Images.SetKeyName(58, "Media.ico");
            this.iconList.Images.SetKeyName(59, "Multimedia file.ico");
            this.iconList.Images.SetKeyName(60, "Music file.ico");
            this.iconList.Images.SetKeyName(61, "Network.ico");
            this.iconList.Images.SetKeyName(62, "Notes.ico");
            this.iconList.Images.SetKeyName(63, "One Drive.ico");
            this.iconList.Images.SetKeyName(64, "Personalization.ico");
            this.iconList.Images.SetKeyName(65, "Phone.ico");
            this.iconList.Images.SetKeyName(66, "Photos file.ico");
            this.iconList.Images.SetKeyName(67, "Photos.ico");
            this.iconList.Images.SetKeyName(68, "Pictures file.ico");
            this.iconList.Images.SetKeyName(69, "Printer 2.ico");
            this.iconList.Images.SetKeyName(70, "Printer.ico");
            this.iconList.Images.SetKeyName(71, "Programs.ico");
            this.iconList.Images.SetKeyName(72, "Quick Access.ico");
            this.iconList.Images.SetKeyName(73, "Recent.ico");
            this.iconList.Images.SetKeyName(74, "Region.ico");
            this.iconList.Images.SetKeyName(75, "Run 1.ico");
            this.iconList.Images.SetKeyName(76, "Run.ico");
            this.iconList.Images.SetKeyName(77, "Scanner.ico");
            this.iconList.Images.SetKeyName(78, "Screensaver.ico");
            this.iconList.Images.SetKeyName(79, "Search.ico");
            this.iconList.Images.SetKeyName(80, "Security.ico");
            this.iconList.Images.SetKeyName(81, "Settings 2.ico");
            this.iconList.Images.SetKeyName(82, "Settings.ico");
            this.iconList.Images.SetKeyName(83, "SHIDI_SHIELD_INTERNAL.ico");
            this.iconList.Images.SetKeyName(84, "Shield.ico");
            this.iconList.Images.SetKeyName(85, "Stop.ico");
            this.iconList.Images.SetKeyName(86, "Tasks.ico");
            this.iconList.Images.SetKeyName(87, "Trash Empty.ico");
            this.iconList.Images.SetKeyName(88, "Trash Full.ico");
            this.iconList.Images.SetKeyName(89, "User.ico");
            this.iconList.Images.SetKeyName(90, "Users.ico");
            this.iconList.Images.SetKeyName(91, "Video device.ico");
            this.iconList.Images.SetKeyName(92, "Video file.ico");
            this.iconList.Images.SetKeyName(93, "Videos file.ico");
            this.iconList.Images.SetKeyName(94, "Warning.ico");
            this.iconList.Images.SetKeyName(95, "x.ico");
            this.iconList.Images.SetKeyName(96, "Zip.ico");
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileType.Location = new System.Drawing.Point(89, 855);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(29, 22);
            this.lblFileType.TabIndex = 12;
            this.lblFileType.Text = "---";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Location = new System.Drawing.Point(89, 877);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(29, 22);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(9, 855);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "FileType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 877);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "FileName";
            // 
            // frmServidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1429, 906);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServidores";
            this.Load += new System.EventHandler(this.frmServidores_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbxPathTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ListView listView1;
    }
}