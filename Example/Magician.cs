using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{

    /// <summary>
    /// 戦えるものの概念を実装した魔法使いのクラス
    /// </summary>
    public class Magician : IFight
    {
        public void Attack()
        {
            Console.WriteLine("魔法使いは魔法攻撃した");
        }

        public void Defence(int damage)
        {
            Console.WriteLine($"魔法使いは防御して{damage}ダメージをうけた");
        }
    }

}