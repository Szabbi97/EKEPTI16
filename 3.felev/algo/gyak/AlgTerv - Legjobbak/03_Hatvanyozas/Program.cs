using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Hatvanyozas
{
    class Program
    {
        static double Hatv(double a, double n)
        {
            //if (n == 0) return 1;
            //else if (n == 1) return a;
            //else
            //{
                double e = 1;
                for (int i = 1; i <= Math.Abs(n); i++)
                    e *= a;
                if (n >= 0) return e;
                else return 1 / e;
            //}
        }
        static double HatvR(double a, double n)
        {
            if (n == 0) return 1;
            else if (n == 1) return a;
            else if (n > 1) return HatvR(a, n - 1) * a;
            else return 1 / HatvR(a, -n);
        }

        static void Main(string[] args)
        {
            double a = 2;            

            Console.WriteLine("Iteratívan: ");
            Console.WriteLine("{0}^{1} = {2}", a, 0, Hatv(a, 0));
            Console.WriteLine("{0}^{1} = {2}", a, 1, Hatv(a, 1));
            Console.WriteLine("{0}^{1} = {2}", a, 3, Hatv(a, 3));
            Console.WriteLine("{0}^{1} = {2}", a, -3, Hatv(a, -3));

            Console.WriteLine("\nRekurzívan: ");
            Console.WriteLine("{0}^{1} = {2}", a, 0, HatvR(a, 0));
            Console.WriteLine("{0}^{1} = {2}", a, 1, HatvR(a, 1));
            Console.WriteLine("{0}^{1} = {2}", a, 3, HatvR(a, 3));
            Console.WriteLine("{0}^{1} = {2}", a, -3, HatvR(a, -3));

            Console.ReadLine();
        }
    }
}
