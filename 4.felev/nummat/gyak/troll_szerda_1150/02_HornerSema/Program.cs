using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HornerSema
{
    class Program
    {
        static double HornerKiertkeles(double[] A, double x)
        {
            double S = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                S = S * x + A[i];
            }
            return S;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(HornerKiertkeles(new double[] { 7, 0, -2, 5 }, 2));
            Console.ReadKey();
        }
    }
}
