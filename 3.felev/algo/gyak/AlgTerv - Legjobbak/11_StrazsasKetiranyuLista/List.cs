using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StrazsasKetiranyuLista
{
    class List<T>
    {
        public List()
        {
            count = 0;
            Start = new Node<T>();
            End = new Node<T>();
            Start.Next = End;
            End.Prev = Start;
        }

        private Node<T> GetNode(int index)
        {
            if (index < -1 || count < index)
                throw new IndexOutOfRangeException();
            if (index == -1)
                return Start;
            if (index == count)
                return End;
            int i = 0;
            Node<T> temp = Start;
            while (i <= index)
            {
                temp = temp.Next;
                i++;
            }
            return temp;
        }

        public void Add(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            Node<T> prev = GetNode(count - 1);
            prev.Next = node;
            node.Prev = prev;
            node.Next = End;
            End.Prev = node;
            count++;
        }

        public void Insert(T value, int index)
        {
            if (index < 0 || count < index)
                throw new IndexOutOfRangeException();
            else
            {
                Node<T> node = new Node<T>();
                node.Value = value;
                Node<T> prev = GetNode(index - 1);
                Node<T> next = prev.Next;
                prev.Next = node;
                node.Prev = prev;
                node.Next = next;
                next.Prev = node;
                count++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || count <= index)
                throw new IndexOutOfRangeException();
            else
            {
                Node<T> atIndex = GetNode(index);
                Node<T> prev = atIndex.Prev;
                Node<T> next = atIndex.Next;
                prev.Next = atIndex.Next;
                next.Prev = atIndex.Prev;
                count--;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || count <= index)
                    throw new IndexOutOfRangeException();
                return GetNode(index).Value;
            }
            set
            {
                if (index < 0 || count <= index)
                    throw new IndexOutOfRangeException();
                GetNode(index).Value = value;
            }
        }

        public int count;
        public int Count { get { return count; } }

        private Node<T> Start { get; set; }
        private Node<T> End { get; set; }
    }
}
