namespace Exercise03 {
    internal class Take20Processor : ITextFileService {
        private int _count;
        public void Initialize(string fname) {
            _count = 0;
        }
        public void Execute(string line) {
            if (_count < 20) {
                Console.WriteLine(line);
                _count++;
            }
        }
        public void Terminate() {
            Console.WriteLine("20行の表示が完了");
        }
    }
}