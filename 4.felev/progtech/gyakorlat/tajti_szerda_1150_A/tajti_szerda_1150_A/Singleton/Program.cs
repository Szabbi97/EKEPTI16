using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TesztSingleton ts1 = TesztSingleton.GetInstance();
            TesztSingleton ts2 = TesztSingleton.GetInstance();

            ts1.Ertek = 5;
            ts2.Ertek = 6;

            //Kiderül, hogy ugyanazt a példányt változtattuk, hiába két példányként kezeltük.
            Console.WriteLine("S1: {0}, S2: {1}.",ts1.Ertek,ts2.Ertek);
            
            Console.ReadKey();
        }
    }
}
