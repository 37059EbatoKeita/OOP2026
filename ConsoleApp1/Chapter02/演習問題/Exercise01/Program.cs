
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new List<Song>();

            while (true) {
                //"アーティスト名："を出力
                Console.Write("曲名:");
                String? title = Console.ReadLine();

                if (title == "end") {
                    break;

                    Console.Write("アーティスト名:");
                    String? artistname = Console.ReadLine();
                   
                    Console.Write("演奏時間（秒）:");
                    int length = Console.ReadLine());

                    Song song = new Song(title, artistname, length);

                    songs.Add(song);

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
