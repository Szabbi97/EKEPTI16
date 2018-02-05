using _09_LancoltLista;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Verem
{
    class StackArray<T>
    {
        private T[] stack;
        private int pointer;
        private int maxDepth;
        public StackArray(int maxDepth)
        {
            stack = new T[maxDepth];
            pointer = 0;
            this.maxDepth = maxDepth;
        }
        public void Push(T content)
        {
            if (pointer < maxDepth)
            {
                stack[pointer] = content;
                pointer++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public T Pop()
        {
            if (pointer < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T data = stack[pointer - 1];
                stack[pointer - 1] = default(T);
                pointer--;
                return data;
            }
        }
    }
}
