using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DataReceiver2
    {

        string _data;

      
        public DataReceiver2 (DataExtractor dataExtr)
        {
            dataExtr.dataRecievedEvent += updateDataHandler;
        }

        public void updateDataHandler(object obj, StringEventArg e)
        {
            _data = e.data;
            Console.WriteLine("Reciever2 data has been changed - {0}", _data);
        }
    }
}
