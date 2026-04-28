using System.Net.ServerSentEvents;

namespace Ex_03_01;

static class Program
{
    static void Main(string[] args)
    {
        Item goods1 = new();    ///アイテム・インスタンスの生成

        Console.Write("商品番号を入力してください->");
        goods1.itemNo = int.Parse(Console.ReadLine());

        Console.Write("商品名を入力してください->");
        goods1.itemName = Console.ReadLine();

        Console.Write("単価を入力してください->");
        goods1.price = int.Parse(Console.ReadLine());


        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {goods1.itemNo}");
        Console.WriteLine($"商品名 = {goods1.itemName}");
        Console.WriteLine($"単価 = {goods1.price}");
    }
}
