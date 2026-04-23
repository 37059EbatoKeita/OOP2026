
namespace DistancrConverter{
    internal class Program{
        static void Main(string[] args){

            if (args.Length == 3 && int.TryParse(args[1], out int start) && int.TryParse(args[2], out int end)){
                PrintFeetToMeterList(20, 40);
            }else if (args.Length >= 1 && args[0] == "-tof"){
                PrintMeterToFeetList(5, 15);
            }else{
                Console.WriteLine("引数エラー");
            }
        }

        //フィートからメートルへの対応表を出力
        static void PrintFeetToMeterList(int start, int stop){
            

            for (int feet = start; feet <= stop; feet++){
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
        //メートルからフィートへの対応表を出力
        static void PrintMeterToFeetList(int start, int stop){
            

            for (int meter = start; meter <= stop; meter++){
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }
    }
}


   