using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public class BlurayPlayer : Player
    {
        public BlurayPlayer(string Media) : base(Media) { }

        public override void Play()
        {
            Console.WriteLine($"Bluray: {Media}を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine($"Bluray:{Media}を停止しました");
        }

    }
}