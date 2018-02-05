using _09_LancoltLista;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Verem
{
    class Stack<T>
    {
        private List<T> stack;
        private int pointer;
        private int maxDepth;

        public Stack()
        {
            stack = new List<T>();
            pointer = 0;
            maxDepth = -1;
        }
        public Stack(int maxDepth)
        {
            stack = new List<T>();
            pointer = 0;
            this.maxDepth = maxDepth;
        }
        public void Push(T content)
        {
            if (maxDepth == -1 || pointer < maxDepth)
            {
                stack.Add(content);
                pointer++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T data = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                pointer--;
                return data;
            }
        }
    }
}
