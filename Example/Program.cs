using System.Formats.Asn1;
using System.Globalization;

namespace Example;

static class Program

{
    public class Warrior
    {
        public string? name;    // 名前を表すフィールド
        public int hp;    // 体力を表すフィールド
        public int ap;     // 攻撃力を表すフィールド
        public int dp;         // 防御力を表すフィールド
        /// <summary>
        /// 挨拶を行うメソッド
        /// </summary>
        public void Greet()
        {
            Console.WriteLine($"{name}:hi!");
        }
        /// <summary>
        /// 体力ゲージを返すメソッド
        /// </summary>
        /// <returns>体力ゲージの文字列</returns>
        public string GetHpMeter()
        {
            string meter = $"{name} ";
            for (int i = 0; i < hp; i++)
            {
                meter += "|";
            }
            return meter;
        }
        /// <summary>
        /// 攻撃を行うメソッド
        /// </summary>
        /// <param name="monster">攻撃対象の魔物</param>
        public void Attack(Monster monster)
        {
            Console.WriteLine($"{name}の攻撃!");
            monster.Defence(ap);//攻撃対象の魔物に防御させる
        }
        /// <summary>
        /// 防御を行うメソッド
        /// </summary>
        /// <param name="damage">受けるダメージの値</param>
        public void Defence(int damage)
        {
            var defencedDamage = damage - dp;
            hp -= defencedDamage;
            Console.WriteLine($"{name}は{defencedDamage}のダメージを受けた");
        }
    }


    /// <summary>
    /// 魔物を表すクラス
    /// </summary>
    public class Monster
    {
        public string? name;     // 魔物の名前を表すフィールド
        public int hp;     // 魔物の体力を表すフィールド
        public int ap;      // 魔物の攻撃力を表すフィールド
        public int dp;          // 魔物の防御力を表すフィールド
        /// <summary>
        /// 挨拶を行うメソッド
        /// </summary>
        public void Greet()
        {
            Console.WriteLine($"{name}:Grr...");
        }
        /// <summary>
        /// 体力ゲージを返すメソッド
        /// </summary>
        /// <returns>体力ゲージの文字列</returns>
        public string GetHpMeter()
        {
            string meter = $"{name} ";
            for (int i = 0; i < hp; i++)
            {
                meter += "|";
            }
            return meter;
        }
        /// <summary>
        /// 攻撃を行うメソッド
        /// </summary>
        /// <param name="warrior">攻撃対象の戦士</param>
        public void Attack(Warrior warrior)
        {
            Console.WriteLine($"{name}の攻撃!");
            warrior.Defence(ap);//攻撃対象の戦士に防御させる
        }
        /// <summary>
        /// 防御を行うメソッド
        /// </summary>
        /// <param name="damage">受けるダメージの値</param>
        public void Defence(int damage)
        {
            var defencedDamage = damage - dp;
            hp -= defencedDamage;
            Console.WriteLine($"{name}は{defencedDamage}のダメージを受けた");
        }


    }


    static void Main(string[] args)
    {
        // インスタンスの生成
        Warrior warrior = new();
        // フィールドに値を設定する
        warrior.name = "ユータ";
        warrior.hp = 20;
        warrior.ap = 10;
        warrior.dp = 5;
        // フィールドの値を取得する
        string name = warrior.name;
        Console.WriteLine($"{name}のHP：{warrior.hp}");
        Console.WriteLine($"{name}の攻撃力：{warrior.ap}");
        Console.WriteLine($"{name}の防御力：{warrior.dp}");
    }
}



