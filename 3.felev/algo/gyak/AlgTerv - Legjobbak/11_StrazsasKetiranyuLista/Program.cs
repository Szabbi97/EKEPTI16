using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StrazsasKetiranyuLista
{
    class Program
    {
        static List<int> lista = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                lista.Add(i);
            lista[4] = 500;

            lista.Insert(600, 0);
            lista.Insert(6000, lista.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("\nTörlés után");
            lista.RemoveAt(0);
            lista.RemoveAt(lista.Count - 1);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }
    }
}
