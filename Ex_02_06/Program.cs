namespace Ex_02_06;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int Number = int.Parse(Console.ReadLine());

        if (Number % 4 == 0)
        {
            Console.WriteLine("4の倍数です");
        }

        else
        {
            Console.WriteLine("4の倍数ではありません");
        }
    }
}
