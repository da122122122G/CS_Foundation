namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int Number = int.Parse(Console.ReadLine());

        if (Number % 2 == 1)
        {
            Console.WriteLine("結果:" + Number);
        }

        else
        {
            Console.WriteLine($"結果:{Number * 10}");
        }
    }
}
