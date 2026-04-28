namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        int[] insert = new int[3];
        int i = 0;

        Console.Write($"数値{i+1}を入力してください->");
        insert[i++] = int.Parse(Console.ReadLine());


        Console.Write($"数値{i+1}を入力してください->");
        insert[i++] = int.Parse(Console.ReadLine());


        Console.Write($"数値{i+1}を入力してください->");
        insert[i++] = int.Parse(Console.ReadLine());


        Console.WriteLine("入力結果");
        Console.WriteLine("数値1:"+insert[0]);
        Console.WriteLine("数値2:"+insert[1]);
        Console.WriteLine("数値3:"+insert[2]);
    }
}
