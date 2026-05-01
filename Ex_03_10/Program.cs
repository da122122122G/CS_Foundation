using Ex_03_10.Modules;

namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {


        Console.Write("DVDのタイトルを入力してください->");
        string name = Console.ReadLine();
        var dVDPlayer = new DVDPlayer(name);



        dVDPlayer.Play();
        dVDPlayer.Stop();


        Console.Write("Bluerayのタイトルを入力してください->");
        name = Console.ReadLine();
        var bluerayPlayer = new BlurayPlayer(name);


        bluerayPlayer.Play();
        bluerayPlayer.Stop();


    }
}
