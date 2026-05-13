
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            //歌データを入れるリストオブジェクトを生成
            var songs = new List<Song>();

            //"**** 曲の登録 ****"を出力
            Console.WriteLine(" **** 曲の登録 ****");

            //何件入力があるかわからないので無限ループ
            while (true) {
                //曲名を出力
                Console.Write("曲名:");
                //入力された曲名を取得
                String? title = Console.ReadLine();

                //endが入力されたら登録終了()
                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                //アーティスト名を出力
                Console.Write("アーティスト名:");
                //入力されたアーティスト名を取得
                String? artistname = Console.ReadLine();

                //演奏時間（秒）：を出力
                Console.Write("演奏時間（秒）:");
                //入力された演奏時間を取得
                int length = int.Parse(Console.ReadLine());

                //Songインスタンスを生成
                Song song = new Song(title, artistname, length);

                //歌データを入れるリストオブジェクトへ登録
                songs.Add(song);

                Console.WriteLine();   //改行
            }
                PrintSongs(songs);
        }
        //Mainメソッド内のPrintSongs(songs); をクリックしてAlt + Enterを押してメソッドを生成するを選択すると、以下のメソッドが自動的に作成される
        //2.1.4
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title},{song.ArtistName},{minutes}:{seconds:00}");
            }
        }
    }
}
