using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoker invoker;
            Console.WriteLine("Press c for Copy and p for Paste");
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "c")
                {
                    invoker = new Invoker(new CopyCommand(new Receiver()));
                    invoker.Invoke();
                }
                else if (command == "p")
                {
                    invoker = new Invoker(new PasteCommand(new Receiver()));
                    invoker.Invoke();
                }
               


            }
        }
    }
}
