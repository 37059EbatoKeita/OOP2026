using System.Runtime.Serialization;
using System.Xml;

namespace CarReportSystem {
    public class Settings {

        //唯一のSettingオブジェクト
        private static readonly Settings _instance = new Settings();

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
           = SystemColors.Control.ToArgb();

        //唯一のオブジェクトを取得する
        public static Settings Instance; 
            
        

        //外部からnewできないようにする
        private Settings() { }


        public void Save() {
            var data = new SettingsData {
                MainFormBackColor = MainFormBackColor
            };

            using var writer = XmlWriter.Create(FileNeName);
            var seializer = new XmlSerializer(typeof(SettingsData));
            seializer.Serialize(writer, data);
        }
    }

    //XML保存用のクラス
    public class SettingsData {
        public int MainFormBackColor { get; set; }
    }
}
