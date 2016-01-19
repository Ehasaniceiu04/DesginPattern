using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    class AudiTTS:IAuto
    {
        void IAuto.TurnOn()
        {
            Console.WriteLine("Audi TTS Car is on");
        }

        void IAuto.TurnOff()
        {
            Console.WriteLine("Audi TTS Car is Off");
        }
    }
}
