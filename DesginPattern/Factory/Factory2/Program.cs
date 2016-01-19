
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = Console.ReadLine();
            AutoFactory factory = new AutoFactory();
            IAuto car = factory.CreateInstance(carName);
            car.TurnOn();
            car.TurnOff();
            Console.ReadLine();
        }
    }
}
