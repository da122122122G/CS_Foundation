using System.Globalization;

namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力して下さい→");
        int num = int.Parse(Console.ReadLine());

        void Mul3()
        {
            Console.WriteLine(num * 3);
        }

        Mul3();

    }
}
