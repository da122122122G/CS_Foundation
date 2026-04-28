using System.Collections;
using System.Diagnostics;

namespace Ex_02_07;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int Number = int.Parse(Console.ReadLine());

        if(Number == 0)
        {
            Console.WriteLine("0です。");
        }

        else if(Number > 0)
        {
            Console.WriteLine("正の値です。");
        }

        else
        {
            Console.WriteLine("負の値です。");
        }

        
    }
}
