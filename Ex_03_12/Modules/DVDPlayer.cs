using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_12.Modules
{
    public class DVDPlayer : Player
    {

        public DVDPlayer(string Media) : base(Media) { }

        public override void Play()
        {
            Console.Write("DVDのタイトルを入力してください->");
            Console.WriteLine($"DVD: {Console.ReadLine()}を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine("DVDを停止しました");
        }
    }
}