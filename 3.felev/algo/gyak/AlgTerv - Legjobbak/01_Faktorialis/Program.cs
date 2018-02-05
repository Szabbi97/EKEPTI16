using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Faktorialis
{
    class Program
    {
        static int Faktorialis(int n, ref int num)
        {
            if (n == 1) return 1;
            else
            {
                int f = 1;
                int i = 2;
                while (i <= n)
                {
                    num += 2;
                    f *= i;
                    i++;
                }
                return f;
            }
        }
        static int F(int n, ref int num, ref int fgv)
        {
            if (n == 1) return 1;
            else
            {
                num += 2;
                fgv++;
                return n * F(n - 1, ref num, ref fgv);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriális\n");

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0, fgv = 0;

            Console.WriteLine("\nIteratív:");
            Console.WriteLine("{0}! = {1}", n, Faktorialis(n, ref num));
            Console.WriteLine("Numerikus műveletek: {0} db", num);

            num = 0;

            Console.WriteLine("\nRekurzív:");
            Console.WriteLine("{0}! = {1}", n, F(n, ref num, ref fgv));
            Console.WriteLine("Numerikus műveletek: {0} db", num);
            Console.WriteLine("Függvényhívások: {0} db", fgv);

            Console.ReadLine();
        }
    }
}
