using List3_20Namespace.Development;
using List3_20Namespace.sales;

namespace Company;

class Program
{

    static void Main(string[] args)
    {
        Suzuki suzuki1 = new();

        //完全修飾名を使い経理部の鈴木さんを呼び出し
        List3_20Namespace.Accounting.Suzuki suzuki2 = new();

        // 山田さんが所属する経理部又は営業部は直接参照できない（コンパイルエラー）
        Yamada yamada = new();
    }
}
