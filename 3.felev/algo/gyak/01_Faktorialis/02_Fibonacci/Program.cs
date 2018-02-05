using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Fibonacci
{
    class Program
    {
        static int Fibonacci(int n, ref int num)
        {
            if (n == 1 || n == 2)
                return 1;
            else
            {
                int i = 1, f1 = 1, f2 = 1;
                num++;
                while (i < n - 2)
                {
                    num += 3;
                    f2 = f1 + f2;
                    f1 = f2 - f1;
                    i++;
                }
                num++;
                return f1 + f2;
            }
        }

        static int F(int n, ref int num, ref int fgv)
        {
            if (n == 1 || n == 2)
                return 1;
            else
            {
                num += 3;
                fgv += 2;
                return F(n - 1, ref num, ref fgv) + F(n - 2, ref num, ref fgv);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci \n");

            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0, fgv = 0;
            Console.WriteLine("\nIteratív");
            Console.WriteLine("f_{0}! = {1}.", n, Fibonacci(n, ref num));
            Console.WriteLine("Numerikus műveletek száma: {0}", num);
            
            num = 0;
            Console.WriteLine("\nRekurzív");
            Console.WriteLine("f_{0}! = {1}.", n, F(n, ref num, ref fgv));
            Console.WriteLine("Numerikus műveletek száma: {0}", num);
            Console.WriteLine("Függvényhívások száma: {0}", fgv);

            Console.ReadKey();
        }
    }
}
