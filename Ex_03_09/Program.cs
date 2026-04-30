namespace Ex_03_09;

using Ex_03_09.Modules;

static class Program
{
    static void Main(string[] args)
    {


        Console.Write("口座番号を入力してください->");
        string no = Console.ReadLine();
        ///netAccount.AccountNo

        Console.Write("口座名義を入力してください->");
        string name = Console.ReadLine();
        ///netAccount.AccountName

        Console.Write("残高を入力してください->");
        int balance = int.Parse(Console.ReadLine());
        ///netAccount.Balance

        Console.Write("ポイントを入力してください->");
        int point = int.Parse(Console.ReadLine());
        ///netAccount.Point

        NetAccount netAccount = new(no, name, balance, point);

        netAccount.Print();

        Console.WriteLine(netAccount.ToString());
    }
}
