using _09_LancoltLista;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Verem
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> verem = new StackArray<int>(10);
            for (int i = 0; i < 10; i++)
            {
                verem.Push(i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(verem.Pop());
            }
            Console.ReadKey();
        }
    }
}
