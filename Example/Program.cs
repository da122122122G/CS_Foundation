namespace Example;

static class Program

{
    static void Main(string[] args)
    {
// 数値の演算
int a = 10;
Console.WriteLine($"a += 3 -> {a += 3}");
Console.WriteLine($"a -= 3 -> {a -= 3}");
Console.WriteLine($"a *= 3 -> {a *= 3}");
Console.WriteLine($"a /= 3 -> {a /= 3}");
Console.WriteLine($"a %= 3 -> {a %= 3}");
// 文字列の連結
string b = "ABC";
Console.WriteLine($"b += XYZ -> {b += "XYZ"}");
// 文字列と他のデータ型の結合
string c = "LMN";
Console.WriteLine($"c += 1   -> {c += 1}");
    }
}
