using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();


        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)numDay.Value).ToString();

        }

        private void btBathclk_Click(object sender, EventArgs e) {
            DateTime birth = dtpBath.Value;  //生まれた日付
            DateTime today = DateTime.Today; //今日の日付

            int age = today.Year - birth.Year;
            if (today < birth.AddYears(age)) {
                age--;
            }
            tbOut.Text = $"あなたは{age}歳です";


            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"生まれてから{ts.Days}日目です";
        }
        //年齢を求めるメソッド
        static int GetAge(DateTime birth, DateTime today) {
            var age = today.Year - birth.Year;
            if (today < birth.AddYears(age)) {
                age--;
            }
            return age;
        }
        private void label4_Click(object sender, EventArgs e) {

        }

        private void dtpBath_ValueChanged(object sender, EventArgs e) {

        }
    }
}
