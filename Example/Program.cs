using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        IFight warrior = new Warrior();//より大きい概念に代入できる
        IFight magician = new Magician();//より大きい概念に代入できる

        warrior.Attack();//IFight型の変数だが実際に実行されるのは戦士のメソッド
        magician.Attack();//IFight型の変数だが実際に実行されるのは魔法使いのメソッド

        IFight[] fighters = new IFight[2];
        fighters[0] = warrior;
        fighters[1] = magician;
        foreach (IFight fighter in fighters)
        {
            fighter.Defence(10);//それぞれの実装クラスのメソッドが実行される
        }
    }
}



