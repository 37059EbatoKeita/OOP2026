using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げ集計クラス
    public class SalesCounter {
        private readonly IEnumerable<Sale> _sales;

        //コンストラクタ-
        public SalesCounter(string filepath) {
            _sales = ReadSales(filepath);        
        }

       public IEnumerable<Sale> ReadSales(string filepath) {
            List<Sale> sales = new List<Sale>();   //リスト
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines) {
                string[] items = line.Split(',');  //カンマ区切りで分割
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }

        //店舗別売り上げを求める
        public IDictionary<string, int> GetperStoreSales() {
            var dict = new Dictionary<string, int>();

            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) //既に店舗名が辞書のキーに登録されているか？
                    //登録されている場合
                    dict[sale.ShopName] += sale.Amount; //売上を足しこみ
                else
                    //未登録の場合
                    dict[sale.ShopName] = sale.Amount; //新規に売上を登録

            }
            return dict;
        }
    }
}
