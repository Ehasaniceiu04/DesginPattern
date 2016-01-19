using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class PasteCommand:ICommand
    {
        private readonly IReceiver _receiver;
        public PasteCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }
        void ICommand.Execute()
        {
            _receiver.Paste();
        }
    }
}
