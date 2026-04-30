using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        Warrior warrior = new();
        warrior.Name = "戦士";

        ///Console.WriteLine(warrior.Name);
        warrior.Hp = 10;//setアクセッサがprivateなので設定不可
        warrior.Ap = 10;//読み取り専用プロパティなので設定不可
    }
}



