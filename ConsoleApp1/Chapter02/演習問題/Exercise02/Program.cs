namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintinchToMeterList(1, 10);
        }
        // インチからメートルへの対応表を出力
        private static void PrintinchToMeterList(int start, int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = incConverter.ToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
    }
}
