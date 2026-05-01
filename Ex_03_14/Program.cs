namespace Ex_03_14;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        int a = int.Parse(Console.ReadLine());
        Console.Write("値2を入力してください->");
        int b = int.Parse(Console.ReadLine());
        int c = 5;


        Console.WriteLine($"加算: {a.Add(b, c)}");
        Console.WriteLine($"平均: {a.Average(b)}");
    }
}
