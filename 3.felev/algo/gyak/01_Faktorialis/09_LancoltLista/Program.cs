using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LancoltLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(i);
            }
            lista[4] = 100;

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            lista.Clear();

            for (int i = 1; i < 10; i++)
            {
                lista.Add(i * 2);
            }
            Console.WriteLine("\nItt történt a lista ürítés\n");

            lista.Insert(0, 100);
            lista.Insert(lista.Count, 300);
            lista.Insert(5, 9);

            lista.RemoveAt(3);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine(lista.Contains(5));

            double sum = lista.Sum();
            Console.WriteLine(sum);

            int[] tomb = lista.ToArray();

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
