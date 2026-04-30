using System.Diagnostics.Contracts;

namespace Ex_03_06;

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

        Item item1 = new(no, name, price);

        Console.Write("新しい単価を入力してください->");
        var newPrice = Console.ReadLine();

        item1.ChangePrice(newPrice);
        item1.Print();

        Console.Write("さらに新しい単価を入力してください->");
        int newPrice2 = int.Parse(Console.ReadLine());

        item1.ChangePrice(newPrice2);

        item1.Print();


    }
}
