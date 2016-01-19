using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Invoker:IInvoker
    {
        private readonly ICommand _command;
        public Invoker(ICommand command)
        {
            _command = command;
        }
        void IInvoker.Invoke()
        {
            _command.Execute();
        }
    }
}
