using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindrom
{
    class Program
    {
        static bool PAL(string s)
        {
            if (s.Length <= 1)
                return true;
            else
            {
                int i = 0;
                while(s[i] == s[s.Length - i - 1])
                {
                    i++;
                    if (i >= s.Length - i - 1)
                        return true;
                }
                return false;
            }
        }
        static bool PALR(string s)
        {
            if (s.Length <= 1) return true;
            else if (s[0] != s[s.Length - 1]) return false;
            else return PALR(s.Substring(1, s.Length - 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PALR(""));
            Console.ReadLine();
        }
    }
}
