using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    class BMWCar:IAuto
    {
        void IAuto.TurnOn()
        {
            Console.WriteLine("BMW Car is on");
        }

        void IAuto.TurnOff()
        {
            Console.WriteLine("BMW Car is Off");
        }
    }
}
