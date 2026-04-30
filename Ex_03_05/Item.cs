using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_05;
///<summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{
    public int itemNo = 99999; ///商品番号
    public string itemName = "商品"; ///商品名
    public int price = 100;       ///単価
    public double salesTaxRate = 0.10;  ///消費税
    public int PriceIncludingTax;


    public Item(int pitemNo, string pitemName, int pprice)
    {
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }


    public void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"値段={price}");
        Console.WriteLine($"税込み価格={PriceIncludingTax}");
    }

    public int CalculateTaxAmount()
    {
        PriceIncludingTax = (int)(price * (1 + salesTaxRate));
        return PriceIncludingTax;
    }

    public int CalculateTaxAmount(int sreducedTaxRate)
    {
        PriceIncludingTax = (price * (100 + sreducedTaxRate) / 100);
        return PriceIncludingTax;
    }


}
