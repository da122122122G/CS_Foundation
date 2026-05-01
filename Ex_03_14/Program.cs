namespace Ex_03_14;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("値1を入力してください->");
        int a = Console.Read();
        Console.WriteLine("値2を入力してください->");
        int b = Console.Read();


        Console.WriteLine($"加算: {int.Add(a, b)}");
        Console.WriteLine($"平均: {int.Average(a, b)}");
    }
}
