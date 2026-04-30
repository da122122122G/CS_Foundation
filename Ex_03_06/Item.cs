using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_06;
///<summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{
    public int itemNo;      ///商品番号
    public string itemName; ///商品名
    public int price;       ///単価


    public Item(int pitemNo, string pitemName, int pprice)
    {
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }

    public Item() { }

    public void ChangePrice(string pprice)
    {
        price = int.Parse(pprice);
    }

    public void ChangePrice(int pprice)
    {
        price = pprice;
    }


    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"値段={price}");
    }




}
