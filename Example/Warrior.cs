using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{ /// <summary>
  /// 戦士を表すクラス
  /// </summary>
    public class Warrior
    {
        public string Name { get; set; } = "ユータ"; // 名前を表すプロパティ
        public int Hp { get; private set; } = 10;   // 体力を表すプロパティ
        public int Ap { get; } = 5; // 攻撃力を表すプロパティ
        public int Dp { get; }      // 防御力を表すプロパティ
    }
}