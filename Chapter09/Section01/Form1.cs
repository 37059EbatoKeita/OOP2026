using System.Diagnostics.Eventing.Reader;
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
            DateTime birth = dtpBath.Value.Date;  //生まれた日付
            DateTime today = DateTime.Today; //今日の日付

            tbOut.Text = $"あなたは{GetAge(birth, today)}歳です";

            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"生まれてから{ts.Days}日目です";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);

            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は第{NthWeek(birth)}週の" +
                $"{dayOfWeek}です。";


            //今年の誕生日を作成する
            DateTime thisYearBirthday = new DateTime(today.Year, birth.Month, birth.Day);
            //既に誕生日が過ぎたか？
            if (thisYearBirthday < today) {
                //来年の誕生日を作成する
                thisYearBirthday = thisYearBirthday.AddDays(1);
            }

            var span = thisYearBirthday - today;

            if (span.Days == 0) {
                tbOut4.Text = "誕生日は今日です。";
            } else {
                tbOut4.Text = $"誕生日まで{span.Days}日後です。";




                //年齢を求めるメソッド
                static int GetAge(DateTime birth, DateTime today) {
                    var age = today.Year - birth.Year;
                    if (today < birth.AddYears(age)) {
                        age--;
                    }
                    return age;
                }
            }
        }

        private object GetAge(DateTime birth, DateTime today) {
            throw new NotImplementedException();
        }

        //指定した日が第何週か求めるメソッド
        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }

        //次の誕生日までの日数を求めて表示する
         
      



        private void label4_Click(object sender, EventArgs e) {

        }

        private void dtpBath_ValueChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }
    }
}
