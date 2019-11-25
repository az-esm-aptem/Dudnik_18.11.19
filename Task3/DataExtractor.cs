using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DataExtractor
    {
        public event EventHandler<StringEventArg> dataRecievedEvent;
        string _data;
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                dataRecievedEvent?.Invoke(this, new StringEventArg(value));
            }
        }
        


    }
}
