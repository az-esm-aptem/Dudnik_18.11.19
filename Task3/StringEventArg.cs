using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class StringEventArg: EventArgs
    {
        public string data { get; private set; }
        public StringEventArg(string arg)
        {
            data = arg;
        }
        
    }
}
