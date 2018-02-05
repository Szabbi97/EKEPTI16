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
                lista.Add(i);

            lista[3] = 100;            

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            lista.Clear();
            Console.WriteLine("\nItt történt a lista ürítése\n");

            for (int i = 1; i <= 10; i++)
                lista.Add(i * 2);

            lista.Insert(0, 100);
            lista.Insert(4, 200);
            lista.Insert(lista.Count, 300);

            lista.RemoveAt(3);

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            Console.WriteLine(lista.Contains(100));
            Console.WriteLine(lista.Contains(200));
            Console.WriteLine(lista.Contains(300));
            Console.WriteLine(lista.Contains(400));
            Console.WriteLine(lista.Sum());

            Console.WriteLine("\nEz már egy tömb lesz\n");

            int[] tomb = lista.ToArray();
            for (int i = 0; i < tomb.Length; i++)
                Console.WriteLine(tomb[i]);

            Console.ReadKey();
        }
    }
}
