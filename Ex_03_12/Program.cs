using System.Security;
using Ex_03_12.Modules;
namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {


        Console.Write("DVDのタイトルを入力してください->");
        Player player = new DVDPlayer(Console.ReadLine()!);

        player.UseMachine();


        Console.Write("Bluerayのタイトルを入力してください->");
        player = new BlurayPlayer(Console.ReadLine()!);

        player.UseMachine();


    }
}
