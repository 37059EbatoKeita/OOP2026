namespace Section01 {
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
            tbOutput = new TextBox();
            nudNum1 = new NumericUpDown();
            nudNum2 = new NumericUpDown();
            pbpk = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ofdOpen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)nudNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNum2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(166, 45);
            label1.TabIndex = 1;
            label1.Text = "Chapter09";
            label1.Click += label1_Click;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(46, 233);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(301, 23);
            tbOutput.TabIndex = 2;
            // 
            // nudNum1
            // 
            nudNum1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudNum1.Location = new Point(218, 85);
            nudNum1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudNum1.Name = "nudNum1";
            nudNum1.Size = new Size(120, 43);
            nudNum1.TabIndex = 3;
            // 
            // nudNum2
            // 
            nudNum2.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudNum2.Location = new Point(59, 85);
            nudNum2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudNum2.Name = "nudNum2";
            nudNum2.Size = new Size(120, 43);
            nudNum2.TabIndex = 3;
            // 
            // pbpk
            // 
            pbpk.Location = new Point(486, 233);
            pbpk.Name = "pbpk";
            pbpk.Size = new Size(453, 353);
            pbpk.TabIndex = 4;
            pbpk.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(279, 388);
            button1.Name = "button1";
            button1.Size = new Size(128, 58);
            button1.TabIndex = 0;
            button1.Text = "開く…";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(68, 146);
            button2.Name = "button2";
            button2.Size = new Size(128, 58);
            button2.TabIndex = 0;
            button2.Text = "ボタン";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 659);
            Controls.Add(pbpk);
            Controls.Add(nudNum2);
            Controls.Add(nudNum1);
            Controls.Add(tbOutput);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNum2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tbOutput;
        private NumericUpDown nudNum1;
        private NumericUpDown nudNum2;
        private PictureBox pbpk;
        private Button button1;
        private Button button2;
        private OpenFileDialog ofdOpen;
    }
}
