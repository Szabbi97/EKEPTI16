using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteratív");
            Console.WriteLine(Pal("RACECAR"));
            Console.WriteLine("Rekurzív");
            Console.WriteLine(PalRek("RACECAR"));
            Console.ReadKey();
        }

        static bool Pal(string s)
        {
            if (s.Length <= 1)
                return true;
            else
            {
                int i = 0;
                while (s[i].Equals( s[s.Length - i - 1]))
                {
                    i++;
                    if (i >= s.Length - i - 1)
                        return true;
                }
                return false;
            }
        }

        static bool PalRek(string s)
        {
            if (s.Length <= 1) return true;
            else if (s[0] != s[s.Length - 1]) return false;
            else return PalRek(s.Substring(1, s.Length - 2));
        }
    }
}
