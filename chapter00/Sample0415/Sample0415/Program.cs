using System.Diagnostics.CodeAnalysis;

namespace Sample0415
{
    internal class Program{
        static void Main(string[] args){
            int[] array = new int[10];


            //入力（配列への格納）
            for (int i = 0; i < array.Length; i++){
                Console.Write("array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            ////集計（配列の値を集計）
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            //出力（配列の値を出力）
            for (int i = 0; i < array.Length; i++){
                Console.WriteLine("array[" + i + "];");
                
                //アスタリスク出力
                astOut(array[i]);
                for (int j = 0; j < array[i]; j++){
                    Console.Write("*");
                }
                Console.WriteLine();  //改行
            }

            //合計を出力
            Console.WriteLine("合計値:" + array.Where(n => n % 2 == 0).Sum());
        }
        static void astOut(int num){
            for (int j = 0; j < num; j++){
                Console.Write("*");
            }
            Console.WriteLine();  //改行
        }
    }
}
