using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    class NullCar:IAuto
    {
        void IAuto.TurnOn()
        {
            Console.WriteLine("Null Car is on");
        }

        void IAuto.TurnOff()
        {
            Console.WriteLine("Null Car is Off");
        }
    }
}
