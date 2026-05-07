using System;
using System.Net.ServerSentEvents;
using Ex_04_01_Lib;

namespace Ex_04_01;

static class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item();

        Console.Write("商品番号を入力してください->");
        item1.ItemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
        item1.ItemName = Console.ReadLine();
        Console.Write("単価を入力してください->");
        item1.Price = int.Parse(Console.ReadLine());
        Console.WriteLine("結果");
        Console.WriteLine("商品番号 = " + item1.ItemNo);
        Console.WriteLine("商品名 = " + item1.ItemName);
        Console.WriteLine("単価 = " + item1.Price);
    }
}
