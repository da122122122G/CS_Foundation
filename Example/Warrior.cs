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
    public int Dp { get; private set; } = 3;
    public override void Greet()
    {
      base.Greet();//親クラスの挨拶メソッドを呼び出し
      Console.WriteLine("戦士です！");
    }
    public override void Defence(int damage)
    {
      Console.WriteLine("戦士は盾で防いだ");
      base.Defence(damage - Dp);//親クラスの防御メソッドを呼び出し
    }
  }
}