using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_07.Modules
{
    public class Item
    {
        public int ItemNo { get; set; }
        ///商品番号を表すプロパティ
        public string ItemName { get; set; }
        ///商品名を表すプロパティ
        public int Price { get; set; }
        ///単価を表すプロパティ
        /// 
        public void Print()
        {
            Console.WriteLine($"商品番号={ItemNo}");
            Console.WriteLine($"商品名={ItemName}");
            Console.WriteLine($"単価={Price}");
        }
    }
}