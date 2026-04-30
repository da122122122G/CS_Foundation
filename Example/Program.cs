using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        Human human = new();
        Warrior warrior = new();

        human.Greet();
        warrior.Greet();

        Console.WriteLine("矢が降ってきた！");
        human.Defence(5);
        Console.WriteLine("矢が降ってきた！");
        warrior.Defence(5);
    }
}



