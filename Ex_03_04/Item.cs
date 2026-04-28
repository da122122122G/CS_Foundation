using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_04;
///<summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{
    public int itemNo; ///商品番号
    public string itemName; ///商品名
    public int price;       ///単価
    public double salesTaxRate = 0.10;  ///消費税
    public int PriceIncludingTax;

    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"値段={price}");
        Console.WriteLine($"税込み金額={PriceIncludingTax}");
    }

    public int CalculateTaxAmount()
    {
        PriceIncludingTax = (int)(price * (1 + salesTaxRate));
        return PriceIncludingTax;
    }



}
