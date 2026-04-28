using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_03;
///<summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{
    public int itemNo; ///商品番号
    public string itemName; ///商品名
    public int price;       ///単価
    public int newPrice;    ///新単価

    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"値段={price}");
    } ///itemNo、itemName、priceフィールドの値を出力する。

    public void ChangePrice(int newPrice)
    {
        price = newPrice;
    }

}
