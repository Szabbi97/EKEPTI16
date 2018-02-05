using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Hatvany
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, n;
            Console.WriteLine("Hatvány");
            Console.Write("Hatvány alap: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Hatvány kitevő: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Iteratív");
            Console.WriteLine("Eredmény: {0}", Hatvany(a, n));
            Console.WriteLine("Rekurzív");
            Console.WriteLine("Eredmény: {0}", H(a, n));
            Console.ReadKey();
        }

        static double Hatvany(double a, double n)
        {
            double helper = 1;
            for (double i = 1; i <= Math.Abs(n); i++)
            {
                helper = helper * a;
            }
            if (n >= 1)
            {
                return helper;
            }
            else return 1 / helper;
        }

        static double H(double a, double n)
        {
            if (n == 0) return 1;
            else if (n >= 1)
            {
                return a * H(a, n - 1);
            }
            else
            {
                return 1 / H(a, -n);
            }
        }
    }
}
