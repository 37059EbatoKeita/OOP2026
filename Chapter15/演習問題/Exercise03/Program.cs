namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var processor = new TextFileProcessor(
                new Take20Processor());
            processor.Run("枕草子.txt");
        }
    }
}