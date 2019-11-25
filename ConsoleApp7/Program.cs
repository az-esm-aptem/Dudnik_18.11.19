using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace ConsoleApp7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input period");
            
            Timer tm = new Timer(int.Parse(Console.ReadLine()));
            tm.Start();
            tm.Elapsed += timeMethod;
            Console.ReadKey();
        }

        public static void timeMethod(object obj, ElapsedEventArgs e)
        {
            Console.WriteLine("Sender - {0}, Time - {1}", obj, e.SignalTime);
        }
    }
}
