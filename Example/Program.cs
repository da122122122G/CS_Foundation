using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        Warrior hero = new("ユータ", 15, 5);
        Console.WriteLine(hero.name);
        Console.WriteLine(hero.hp);
        Console.WriteLine(hero.ap);
    }
}



