using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StrazsasLista
{
    class List<T>
    {
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private Node<T> Start { get; set; }
        private Node<T> End { get; set; }

        public List()
        {
            count = 0;
            Start = new Node<T>();
            End = new Node<T>();
            Start.Next = End;
            End.Prev = Start;
        }
    }
}
