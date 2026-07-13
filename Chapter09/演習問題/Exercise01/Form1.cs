using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btbutton1_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            tbOut1.Text = dateTime.ToString($"{dateTime:yyyy/MM/dd HH:mm}");

        }

        private void btbutton2_Click(object sender, EventArgs e) {
            var deatTime = DateTime.Now;
            tbOut2.Text = $"{deatTime.Year}”N{deatTime.Month}ŒŽ{deatTime.Day}“ú   {deatTime.Hour}Žž{deatTime.Minute}•ª{deatTime.Second}•b";
}

        private void btbutton3_Click(object sender, EventArgs e) {
            var deatTime = DateTime.Now;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.GetDayName(deatTime.DayOfWeek); //–¾“ú

            var year = int.Parse(deatTime.ToString("yy", culture));
            var str2 = string.Format($"{culture}{year,2}”N{deatTime.Month,2}ŒŽ{deatTime.Day,2}“ú(dayOfWeek)");
            tbOut3.Text = str2;

        }
    }
}
