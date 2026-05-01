using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_12.Modules
{
    public abstract class Player
    {
        public string Media { get; }

        public Player(string Media)
        {
            this.Media = Media;
        }

        public abstract void Play();
        public abstract void Stop();

        public void UseMachine()
        {
            Play();
            Stop();
        }


    }
}