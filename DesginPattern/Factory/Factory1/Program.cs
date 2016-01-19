using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName=Console.ReadLine();
            IAuto car = GetCar(carName);
            car.TurnOn();
            car.TurnOff();
        }

        private static IAuto GetCar(string carName)
        {
            switch(carName)
            {
                case "bmw":
                    return new BMWCar();
                case "mini":
                    return new MiniCar();
                case "audi":
                    return new AudiTTS();
                default:
                    return new NullCar();
            }
        }
    }
}
