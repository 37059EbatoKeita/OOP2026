namespace Sample0413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("表示回数");
            string? inputNum = Console.ReadLine(); //入力

            int count = int.Parse(inputNum);  //整数への変換

            for (int i = 0; i < count; i++)
            {
                while (i < count){
                    
                }
                {
                    Console.Write(i + 1);
                    Console.WriteLine(":" + "こんにちは"); //画面出力
                }
            }
        }
    }
}
