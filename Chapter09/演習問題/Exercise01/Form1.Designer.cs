namespace Exercise01 {
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
            btbutton1 = new Button();
            tbOut1 = new TextBox();
            btbutton2 = new Button();
            tbOut2 = new TextBox();
            btbutton3 = new Button();
            tbOut3 = new TextBox();
            SuspendLayout();
            // 
            // btbutton1
            // 
            btbutton1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btbutton1.Location = new Point(40, 32);
            btbutton1.Name = "btbutton1";
            btbutton1.Size = new Size(75, 43);
            btbutton1.TabIndex = 0;
            btbutton1.Text = "①";
            btbutton1.UseVisualStyleBackColor = true;
            // 
            // tbOut1
            // 
            tbOut1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut1.Location = new Point(145, 36);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(272, 39);
            tbOut1.TabIndex = 1;
            // 
            // btbutton2
            // 
            btbutton2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btbutton2.Location = new Point(40, 97);
            btbutton2.Name = "btbutton2";
            btbutton2.Size = new Size(75, 43);
            btbutton2.TabIndex = 0;
            btbutton2.Text = "②";
            btbutton2.UseVisualStyleBackColor = true;
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(145, 97);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(272, 39);
            tbOut2.TabIndex = 1;
            // 
            // btbutton3
            // 
            btbutton3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btbutton3.Location = new Point(40, 160);
            btbutton3.Name = "btbutton3";
            btbutton3.Size = new Size(75, 43);
            btbutton3.TabIndex = 0;
            btbutton3.Text = "③";
            btbutton3.UseVisualStyleBackColor = true;
            // 
            // tbOut3
            // 
            tbOut3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut3.Location = new Point(145, 160);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(272, 39);
            tbOut3.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbOut1);
            Controls.Add(btbutton3);
            Controls.Add(btbutton2);
            Controls.Add(btbutton1);
            Name = "Form1";
            Text = "問題9.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbutton1;
        private TextBox tbOut1;
        private Button btbutton2;
        private TextBox tbOut2;
        private Button btbutton3;
        private TextBox tbOut3;
    }
}
