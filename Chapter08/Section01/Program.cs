using System.ComponentModel.DataAnnotations;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficedict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string pref, prefCaptallocation;

            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");


            while (true) {
                //①都道府県の入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();

                if (pref == null) break;　//無限ループを抜ける(Ctrl  + 'Z')


                //②県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptallocation = Console.ReadLine();


                //③県庁所在地登録処理
                public IDictionary<string> GetperS
                foreach (var item in prefCaptallocation) {








                }
            }
        }
    

        //メニュー表示
        private static int menuDisp() {
            Console.WriteLine("\n**** メニュー ****");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.WriteLine(">");

        //メニュー番号を入力させて呼び出し元へ返却

            return

        }

        //一覧表示処理
        private static void allDisp() {

            //コレクション(prefOfficeDict)の中身をすべて出力
        }

        //検索処理
        private static void searcPrefCaptalLocation() {
            Console.Write("都道府県");
            String? searcPref = Console.ReadLine();

            //検索した結果を表示
        }
        }
    }


