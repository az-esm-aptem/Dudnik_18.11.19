using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExtractor extractor = new DataExtractor();
            DataReceiver1 reciever1 = new DataReceiver1(extractor);
            DataReceiver2 reciever2 = new DataReceiver2(extractor);

            while (extractor.Data != "")
                extractor.Data = Console.ReadLine();
            
            
        }
    }
}
