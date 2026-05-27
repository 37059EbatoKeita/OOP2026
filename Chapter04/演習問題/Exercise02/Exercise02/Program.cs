namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        private static void Exercise1() {
            //if-else文を使用
            Console.Write("数値を入力してください" + ":");
            string? inputNumber = Console.ReadLine();
            if (!int.TryParse(inputNumber, out var number)) {
                Console.WriteLine("入力値に誤りがあります");
            }
            if (number < 0) {
                Console.WriteLine(number);
            } else if (number < 100) {
                Console.WriteLine(number * 2);
            } else if (number < 500) {
                Console.WriteLine(number * 3);
            } else {
                Console.WriteLine(number);
            }

        }
        

        private static void Exercise2() {
            //switch文を使用
            Console.Write("数値を入力してください" + ":");
            string? inputNumber = Console.ReadLine();
            if (!int.TryParse(inputNumber, out var number)) {
                Console.WriteLine("入力値に誤りがあります");
            }
            switch (number) {
                case < 0:
                    Console.WriteLine(number);
                    break;
                case < 100:
                    Console.WriteLine(number * 2);
                    break;
                case < 500:
                    Console.WriteLine(number * 3);
                    break;
            }


        }

        private static void Exercise3() {
            //switch式を使用


        }
    }
}
