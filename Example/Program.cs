using System.Globalization;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        var count = 1;
        while (count < 8)
        {
            count *= 2;
            Console.WriteLine($"count *= {count}");
        }
    }
}
