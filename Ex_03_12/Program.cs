using System.Security;
using Ex_03_12.Modules;
namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {


        Console.Write("DVDのタイトルを入力してください->");
        string name = Console.ReadLine();
        Player dvd = new DVDPlayer(name);

        dvd.UseMachine();


        Console.Write("Bluerayのタイトルを入力してください->");
        name = Console.ReadLine();
        Player blu = new BlurayPlayer(name);

        blu.UseMachine();


    }
}
