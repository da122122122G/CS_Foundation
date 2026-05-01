using System.Runtime.InteropServices;

namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3);
        Console.WriteLine($"3 * 3 * 3.14 = {circle.AreaCalculation()}");
        Console.WriteLine($"3 * 3 * 3.14 = {circle.AreaCalculation(3)}");
    }
}
