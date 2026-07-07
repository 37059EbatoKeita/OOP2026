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
            dtpDate = new DateTimePicker();
            btGet = new Button();
            tbOut = new TextBox();
            numDay = new NumericUpDown();
            label1 = new Label();
            dtpBath = new DateTimePicker();
            btBathclk = new Button();
            label2 = new Label();
            label3 = new Label();
            tbOut2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numDay).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(192, 24);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 0;
            // 
            // btGet
            // 
            btGet.Location = new Point(398, 39);
            btGet.Name = "btGet";
            btGet.Size = new Size(75, 23);
            btGet.TabIndex = 1;
            btGet.Text = "計算";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(192, 286);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(326, 39);
            tbOut.TabIndex = 2;
            // 
            // numDay
            // 
            numDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numDay.Location = new Point(192, 80);
            numDay.Name = "numDay";
            numDay.Size = new Size(200, 39);
            numDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(398, 87);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpBath
            // 
            dtpBath.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBath.Location = new Point(192, 231);
            dtpBath.Name = "dtpBath";
            dtpBath.Size = new Size(200, 39);
            dtpBath.TabIndex = 0;
            dtpBath.ValueChanged += dtpBath_ValueChanged;
            // 
            // btBathclk
            // 
            btBathclk.Location = new Point(412, 231);
            btBathclk.Name = "btBathclk";
            btBathclk.Size = new Size(75, 39);
            btBathclk.TabIndex = 5;
            btBathclk.Text = "計算";
            btBathclk.UseVisualStyleBackColor = true;
            btBathclk.Click += btBathclk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 213);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "生年月日";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 730);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "生年月日";
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(192, 340);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(326, 39);
            tbOut2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(124, 293);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 4;
            label4.Text = "年齢";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(76, 343);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 4;
            label5.Text = "経過日数";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 428);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btBathclk);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(numDay);
            Controls.Add(tbOut2);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpBath);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut;
        private NumericUpDown numDay;
        private Label label1;
        private DateTimePicker dtpBath;
        private Button btBathclk;
        private Label label2;
        private Label label3;
        private TextBox tbOut2;
        private Label label4;
        private Label label5;
    }
}
