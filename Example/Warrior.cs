using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
  /// <summary>
  /// 戦えるものの概念を実装した戦士のクラス
  /// </summary>
  public class Warrior : IFight
  {
    public void Attack()
    {
      Console.WriteLine("戦士は剣で攻撃した");
    }

    public void Defence(int damage)
    {
      Console.WriteLine($"戦士は盾で防御して{damage / 2}ダメージをうけた");
    }
  }
}