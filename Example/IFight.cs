using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// 戦う事ができるものを表すインターフェイス
    /// </summary>
    public interface IFight
    {
        /// <summary>
        /// 攻撃をする抽象メソッド
        /// </summary>
        void Attack();


        /// <summary>
        /// 防御をする抽象メソッド
        /// </summary>
        /// <param name="damage">受けたダメージ</param>
        void Defence(int damage);
    }
}