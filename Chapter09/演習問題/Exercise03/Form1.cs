using System.Diagnostics;

namespace Exercise03 {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
            timer1.Start();
        }
        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

       
    }
}

