using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior();
        warrior.Ap = 10;
        warrior.Greet();//Humanクラスのメソッドの呼び出し
        warrior.Attack();//Warriorクラスのメソッドの呼び出し
    }
}



