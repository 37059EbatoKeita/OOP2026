using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgbRecords.DataSource = listCarReports;
        }
        //追加ボタンイベントハンドラ
        private void btAdReport_Click(object sender, EventArgs e) {

            tsslbMessage.Text = String.Empty; //メッセージ領域のクリア

            //記録者と車名が未入力だった場合は追加しない
            if (cbAurther.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAurther.Text,
                Maker = GetRadopButtonMaker(),
                CarName = cbCarName.Text,
                Rrport = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);

            ImputItemsAllClear();

        }
        private MakerGroup GetRadopButtonMaker() {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return MakerGroup.日産;
            if (rbHonda.Checked)
                return MakerGroup.ホンダ;
            if (rbSubaru.Checked)
                return MakerGroup.スバル;
            if (rbImport.Checked)
                return MakerGroup.輸入車;

            return MakerGroup.その他;
        }

        private void btNewimpt_Click(object sender, EventArgs e) {
            ImputItemsAllClear();
        }

        private void ImputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAurther.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }

        private void dgbRecords_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgbRecords.CurrentRow.Cells["Date"].Value;
            cbAurther.Text = (string)dgbRecords.CurrentRow.Cells["Aurther"].Value;
            cbCarName.Text = (string)dgbRecords.CurrentRow.Cells["Name"].Value;
            tbReport.Text = (string)dgbRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgbRecords.CurrentRow.Cells["Picture"].Value;
        }
    }
}
