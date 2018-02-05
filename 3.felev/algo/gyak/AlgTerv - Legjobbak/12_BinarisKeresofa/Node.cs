using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_BinarisKeresofa
{
    class Node<T>
    {
        public int Id { get; set; }
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public void Display()
        {
            Console.WriteLine("{0}: {1}",Id,Data);
        }
    }
}
