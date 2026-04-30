using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// 人物を表すクラス
    /// </summary>
    /// <summary>
    /// 人物を表すクラス
    /// </summary>
    public class Human
    {
        public int Hp { get; protected set; } = 10;

        public virtual void Greet()
        {
            Console.WriteLine("こんにちは！");
        }
        public virtual void Defence(int damage)
        {
            Console.WriteLine($"{damage}のダメージを受けた");
            Hp -= damage;
        }
    }
}