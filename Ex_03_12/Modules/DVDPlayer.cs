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
            Console.WriteLine($"DVD: {Media}を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine($"DVD: {Media}の再生を停止しました");
        }
    }
}