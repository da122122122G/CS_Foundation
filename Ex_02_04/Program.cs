namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        int[] insert = new int[3];

        Console.Write("数値1を入力してください->");
        var a = Console.ReadLine();
        Console.Write("数値2を入力してください->");
        var b = Console.ReadLine();
        Console.Write("数値3を入力してください->");
        var c = Console.ReadLine();

        insert[0] = int.Parse(a);
        insert[1] = int.Parse(b);
        insert[2] = int.Parse(c);

        Console.WriteLine("入力結果");
        Console.WriteLine($"数値1:{insert[0]}");
        Console.WriteLine($"数値2:{insert[1]}");
        Console.WriteLine($"数値3:{insert[2]}");
    }
}
