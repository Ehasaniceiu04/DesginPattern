using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Receiver:IReceiver
    {
        void IReceiver.Copy()
        {
            Console.WriteLine("Copy data");
        }

        void IReceiver.Paste()
        {
            Console.WriteLine("Paste data");
        }
    }
}
