namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            cbAurther = new ComboBox();
            label4 = new Label();
            cbCarName = new ComboBox();
            dgbRecords = new DataGridView();
            tbReport = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btAdReport = new Button();
            label7 = new Label();
            btDeletePicture = new Button();
            btModhuiRecord = new Button();
            btDeleteRecord = new Button();
            btOpenPicture = new Button();
            pbPicture = new PictureBox();
            btNewimpt = new Button();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            ofdPicFileOpen = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            cdColor = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(531, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "画像";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(112, 31);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(13, 141);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(112, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 54);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbOther.Location = new Point(300, 12);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(65, 24);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbImport.Location = new Point(233, 12);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(72, 24);
            rbImport.TabIndex = 0;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbSubaru.Location = new Point(173, 12);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(62, 24);
            rbSubaru.TabIndex = 0;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbHonda.Location = new Point(118, 12);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(57, 24);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "本田";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbNissan.Location = new Point(63, 12);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(57, 24);
            rbNissan.TabIndex = 0;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(7, 12);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(58, 24);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbAurther
            // 
            cbAurther.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAurther.FormattingEnabled = true;
            cbAurther.Location = new Point(112, 85);
            cbAurther.Name = "cbAurther";
            cbAurther.Size = new Size(204, 38);
            cbAurther.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(9, 244);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 0;
            label4.Text = "レポート";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(112, 189);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(204, 38);
            cbCarName.TabIndex = 3;
            // 
            // dgbRecords
            // 
            dgbRecords.AllowUserToAddRows = false;
            dgbRecords.AllowUserToDeleteRows = false;
            dgbRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbRecords.Location = new Point(112, 392);
            dgbRecords.MultiSelect = false;
            dgbRecords.Name = "dgbRecords";
            dgbRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgbRecords.Size = new Size(743, 252);
            dgbRecords.TabIndex = 4;
            dgbRecords.SelectionChanged += dgbRecords_SelectionChanged;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(112, 244);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(374, 116);
            tbReport.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(30, 189);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 0;
            label5.Text = "車名";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(30, 375);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // btAdReport
            // 
            btAdReport.BackColor = Color.SkyBlue;
            btAdReport.FlatStyle = FlatStyle.Flat;
            btAdReport.Location = new Point(531, 292);
            btAdReport.Name = "btAdReport";
            btAdReport.Size = new Size(109, 42);
            btAdReport.TabIndex = 6;
            btAdReport.Text = "追加";
            btAdReport.UseVisualStyleBackColor = false;
            btAdReport.Click += btAdReport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(30, 36);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "日付";
            // 
            // btDeletePicture
            // 
            btDeletePicture.Location = new Point(724, 27);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(109, 42);
            btDeletePicture.TabIndex = 6;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = true;
            btDeletePicture.Click += btDeletePicture_Click;
            // 
            // btModhuiRecord
            // 
            btModhuiRecord.BackColor = Color.Khaki;
            btModhuiRecord.FlatStyle = FlatStyle.Flat;
            btModhuiRecord.Location = new Point(646, 292);
            btModhuiRecord.Name = "btModhuiRecord";
            btModhuiRecord.Size = new Size(109, 42);
            btModhuiRecord.TabIndex = 6;
            btModhuiRecord.Text = "修正";
            btModhuiRecord.UseVisualStyleBackColor = false;
            btModhuiRecord.Click += btModhuiRecord_Click;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.Salmon;
            btDeleteRecord.FlatStyle = FlatStyle.Flat;
            btDeleteRecord.Location = new Point(761, 292);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(72, 42);
            btDeleteRecord.TabIndex = 6;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            btDeleteRecord.Click += btDeleteRecord_Click;
            // 
            // btOpenPicture
            // 
            btOpenPicture.Location = new Point(599, 27);
            btOpenPicture.Name = "btOpenPicture";
            btOpenPicture.Size = new Size(109, 42);
            btOpenPicture.TabIndex = 6;
            btOpenPicture.Text = "開く";
            btOpenPicture.UseVisualStyleBackColor = true;
            btOpenPicture.Click += btOpenPicture_Click;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(531, 88);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(302, 190);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // btNewimpt
            // 
            btNewimpt.BackColor = Color.DarkSeaGreen;
            btNewimpt.FlatStyle = FlatStyle.Flat;
            btNewimpt.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNewimpt.Location = new Point(331, 28);
            btNewimpt.Name = "btNewimpt";
            btNewimpt.Size = new Size(109, 42);
            btNewimpt.TabIndex = 6;
            btNewimpt.Text = "新規入力";
            btNewimpt.UseVisualStyleBackColor = false;
            btNewimpt.Click += btNewimpt_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(954, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(180, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(180, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(180, 22);
            終了ToolStripMenuItem.Text = "終了(&X)";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(164, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            statusStrip1.Location = new Point(0, 669);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(954, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 691);
            Controls.Add(statusStrip1);
            Controls.Add(pbPicture);
            Controls.Add(btDeletePicture);
            Controls.Add(btNewimpt);
            Controls.Add(btOpenPicture);
            Controls.Add(btDeleteRecord);
            Controls.Add(btModhuiRecord);
            Controls.Add(btAdReport);
            Controls.Add(tbReport);
            Controls.Add(dgbRecords);
            Controls.Add(cbCarName);
            Controls.Add(cbAurther);
            Controls.Add(groupBox1);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgbRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private ComboBox cbAurther;
        private Label label4;
        private ComboBox cbCarName;
        private DataGridView dgbRecords;
        private TextBox tbReport;
        private Label label5;
        private Label label6;
        private Button btAdReport;
        private Label label7;
        private Button btDeletePicture;
        private Button btModhuiRecord;
        private Button btDeleteRecord;
        private Button btOpenPicture;
        private PictureBox pbPicture;
        private Button btNewimpt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslbMessage;
        private ColorDialog cdColor;
    }
}
