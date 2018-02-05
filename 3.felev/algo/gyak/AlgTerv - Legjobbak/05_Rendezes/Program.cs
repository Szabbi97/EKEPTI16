using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rendezes
{
    class Program
    {
        static void RendMaxNov(int[] A)
        {
            if (A.Length != 1)
            {
                //A = A.Where(a => a != max).ToArray();
                int max = A.Max();
                int[] tmp = new int[A.Length - 1];
                int j = 0;
                bool deleted = false;
                for (int i = 0; i < A.Length; i++)
                {
                    if (deleted || A[i] != max)
                    {
                        tmp[j] = A[i];
                        j++;
                    }
                    else deleted = true;
                }
                RendMaxNov(tmp);
                for (int i = 0; i < tmp.Length; i++)
                    A[i] = tmp[i];
                A[A.Length - 1] = max;
            }
        }
        static void RendMaxNov(List<int> A)
        {
            if (A.Count != 1)
            {
                int max = A.Max();
                A.Remove(max);
                RendMaxNov(A);
                A.Add(max);
            }
        }
       
        static void Kiir(ICollection<int> A)
        {
            foreach (var a in A)
                Console.Write(a + ", ");
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 2, 5, 7, 1, 4, 2, 9, 11, 23, 5, 2 };
            int[] tomb = new int[] { 2, 5, 23, 7, 1, 4, 9, 11, 23 };

            Console.WriteLine("Az eredeti lista:");
            Kiir(tomb);
            Console.WriteLine("Rendezett lista:");
            RendMaxNov(tomb);
            Kiir(tomb);

            Console.ReadLine();
        }
    }
}
