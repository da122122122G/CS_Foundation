using System.Security.Principal;
using Ex_03_08.Modules;
namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        NetAccount account = new();

        Console.Write("口座番号を入力してください->");
        account.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        account.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        account.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください->");
        account.Point = int.Parse(Console.ReadLine());

        Console.Write("口座番号：" + account.AccountNo + " ");
        Console.Write("口座名義：" + account.AccountName + " ");
        Console.Write("残高：" + account.Balance + " ");
        Console.WriteLine("ポイント：" + account.Point);
    }
}
