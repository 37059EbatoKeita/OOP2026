using TextFileProcessor;

Console.Write("カウントしたい単語：");
WordCounterProcessor.TargetWord = Console.ReadLine() ?? "";

string path =@"C:\Users\infosys\source\repos\OOP2026\Chapter14\演習問題\Exercise01_WPF\吾輩は猫である.txt";
TextProcessor.Run<WordCounterProcessor>(path);

public class WordCounterProcessor : TextProcessor {
    // 初期値を与えて警告を防ぐ
    public static string TargetWord = "";
    private int _count = 0;
    protected override void Initialize(string fname) {
        _count = 0;
    }

    protected override void Execute(string line) {
        int index = 0;
        while ((index = line.IndexOf(TargetWord, index)) != -1) {
            _count++;
            index += TargetWord.Length;
        }
    }

    protected override void Terminate() {
        Console.WriteLine($"{TargetWord}は{_count}個出現します。");
    }
}