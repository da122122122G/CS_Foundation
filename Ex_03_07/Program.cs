using System.Net.ServerSentEvents;
using System.Runtime.CompilerServices;
using Ex_03_07.Modules;

namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
        Item item1 = new();

        Console.Write("商品番号を入力してください->");
        item1.ItemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
        item1.ItemName = Console.ReadLine();
        Console.Write("単価を入力してください->");
        item1.Price = int.Parse(Console.ReadLine());

        item1.Print();
    }
}
