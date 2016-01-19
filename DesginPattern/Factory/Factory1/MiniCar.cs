using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    class MiniCar:IAuto
    {
        void IAuto.TurnOn()
        {
            Console.WriteLine("Mini Car is on");
        }

        void IAuto.TurnOff()
        {
            Console.WriteLine("Mini Car is Off");
        }
    }
}
