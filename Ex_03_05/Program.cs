using System.Diagnostics.Contracts;
using System.Net.ServerSentEvents;

namespace Ex_03_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("商品番号を入力してください->");
        int no = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
        string? name = Console.ReadLine();
        Console.Write("単価を入力してください->");
        int price = int.Parse(Console.ReadLine());
        Console.Write("税率を入力してください->");
        int tax = int.Parse(Console.ReadLine());

        ///インスタンス作成
        Item item1 = new(no, name, price);

        item1.CalculateTaxAmount(tax);

        ///出力
        item1.Print();
    }
}
