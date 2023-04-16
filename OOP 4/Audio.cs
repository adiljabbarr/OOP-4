using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    internal interface IAudio
    {
        void Play();
    }

    class MP3 : IAudio
    {       
        public void Play()
        {
            Console.WriteLine("MP3");
        }
    }
    class WAV : IAudio
    {
        public void Play()
        {
            Console.WriteLine("WAV");
        }
    }
    class OGG : IAudio
    {
        public void Play()
        {
            Console.WriteLine("OGG");
        }
    }
}
