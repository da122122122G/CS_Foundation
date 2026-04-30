using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        ///        Warrior warrior1 = new Warrior { name = "ユータ", hp = 15, ap = 7, dp = 3 };
        Warrior warrior2 = new("ユーサク", 8) { ap = 10, dp = 2 };
        Warrior warrior3 = new("Y");
        ///warrior3.name = "Y";
        warrior3.hp = 9;
        ///    Console.WriteLine(warrior1.hp);
        Console.WriteLine(warrior3.name);
        Console.WriteLine(warrior3.hp);
    }
}



