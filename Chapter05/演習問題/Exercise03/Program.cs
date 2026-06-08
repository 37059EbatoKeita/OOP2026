using Exercise01;
using System.Security.Cryptography.X509Certificates;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {

            var y1 = new YearMonth(2001, 12);
            var y2 = new YearMonth(2001, 12);
            if(y1 == y2) {
                Console.WriteLine("y1とy2は等しい");
            } else {
                Console.WriteLine("y1とy2は等しくない");
            }
        }
    }
}
