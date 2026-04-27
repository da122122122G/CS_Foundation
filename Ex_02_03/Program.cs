using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("数値を入力してください->");
        var value = System.Console.ReadLine();
          
        System.Console.WriteLine($"5を加算した結果は{int.Parse(value) + 5}です");
        System.Console.WriteLine($"5を減算した結果は{int.Parse(value) - 5}です");

    }
}
