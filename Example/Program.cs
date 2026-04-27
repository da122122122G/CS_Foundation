namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        // 2教科の平均点が合格ライン（60点）を超えているか？
        int mathScore = 80;
        int englishScore = 50;
        int passingGrade = 60;

        // 【優先順位のポイント】
        // 1. カッコ ( ) の中が最優先
        // 2. 次に割り算 / が行われる
        // 3. 最後に比較 > が行われる
        bool isPassed = (mathScore + englishScore) / 2 > passingGrade;

        Console.WriteLine($"数学{mathScore}点、英語{englishScore}点。");
        Console.WriteLine($"平均点は{passingGrade}点を超えているか：{isPassed}");
    }
}
