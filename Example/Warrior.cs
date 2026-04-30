using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
  /// <summary>
  /// 戦士を表すクラス
  /// </summary>
  public class Warrior : Human
  {
    public int Ap { get; set; } = 5;
    public int Dp { get; set; }

    public void Attack()
    {
      Console.WriteLine("どうだっ！\n戦士は攻撃した！");
      Console.WriteLine($"{Ap}のダメージを与えた。");
    }
  }
}