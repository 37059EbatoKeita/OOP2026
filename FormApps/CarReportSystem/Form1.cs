using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //設定クラスのオブジェクトを生成
        Settings settings = new Settings();

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
                Date = dtpDate.Value.Date,
                Author = cbAurther.Text.Trim(),
                Maker = GetRadopButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);

            //入力履歴を登録
            SetCbAuthor(cbAurther.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgbRecords.ClearSelection(); //セルの選択を解除する



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
        private void btOpenPicture_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
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

            dgbRecords.ClearSelection(); //セルの選択を解除する
        }


        private void SetRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {

                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;

                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //記録者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(string author) {

            if (!cbAurther.Items.Contains(author)) {
                cbAurther.Items.Add(author);
            }
        }
        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName) {

            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDeleteRecord_Click(object sender, EventArgs e) {

            if ((dgbRecords.CurrentRow is null)
                || (!dgbRecords.CurrentRow.Selected)) return;

            //削除したいインデックスを指定してリストから削除
            listCarReports.RemoveAt(dgbRecords.CurrentRow.Index);



        }
        




        private void btModhuiRecord_Click(object sender, EventArgs e) {
            if (dgbRecords.SelectedRows.Count == 0) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            if (cbAurther.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }


            //カーレポート管理用リストの該当する要素のデータを書き換える
            listCarReports[dgbRecords.CurrentRow.Index].Date = dtpDate.Value.Date;
            listCarReports[dgbRecords.CurrentRow.Index].Author = cbAurther.Text.Trim();
            listCarReports[dgbRecords.CurrentRow.Index].Maker = GetRadopButtonMaker();
            listCarReports[dgbRecords.CurrentRow.Index].CarName = cbCarName.Text.Trim();
            listCarReports[dgbRecords.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgbRecords.CurrentRow.Index].Picture = pbPicture.Image;

            SetCbAuthor(cbAurther.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgbRecords.Refresh();  //データグリッドビューの更新

            tsslbMessage.Text = "レポートを修正しました。";
        }


        private void dgbRecords_SelectionChanged(object sender, EventArgs e) {

            if ((dgbRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
               || (!dgbRecords.CurrentRow.Selected)) return;

            dtpDate.Value = carReport.Date;
            cbAurther.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;


        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;

            }
        }

        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理（シリアル化）
            //P284以降を参考にする（ファイル名：setting.xml）
            using (var writer = XmlWriter.Create("setting.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }
    }
}
