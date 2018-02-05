using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LancoltLista
{
    public class List<T>
    {
        public List()
        {
            Head = new ListItem<T>();
            count = 0;
        }

        private ListItem<T> Head { get; set; }
        private int count;
        public int Count { get { return count; } }

        public T this[int index]
        {
            get
            {
                return GetListItem(index).Content;
            }
            set
            {
                GetListItem(index).Content = value;
            }
        }

        public void Add(T content)
        {
            if (count == 0)
                Head.Content = content;
            else
            {
                ListItem<T> newItem = new ListItem<T>();
                newItem.Content = content;

                GetListItem(count - 1).Next = newItem;
            }
            count++;
        }

        public void Clear()
        {
            Head = new ListItem<T>();
            count = 0;
        }

        public bool Contains(T content)
        {
            ListItem<T> temp = Head;
            do
            {
                if (temp.Content.Equals(content))
                    return true;
                temp = temp.Next;
            } while (temp != null);
            return false;
        }

        private ListItem<T> GetListItem(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            //if (index == 0) return Head;
            //else return GetListItem(index - 1).Next;

            int i = 0;
            ListItem<T> temp = Head;

            while (i < index)
            {
                temp = temp.Next;
                i++;
            }

            return temp;
        }

        public void Insert(int index, T content)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();

            if (index == count)
                Add(content);
            else
            {
                ListItem<T> newItem = new ListItem<T>();
                newItem.Content = content;

                if (index == 0)
                {
                    newItem.Next = Head;
                    Head = newItem;
                }
                else
                {
                    ListItem<T> previous = GetListItem(index - 1);
                    newItem.Next = previous.Next;
                    previous.Next = newItem;
                }
                count++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                if (count == 1) Clear();
                else Head.Next = Head;
            }
            else
            {
                ListItem<T> previous = GetListItem(index - 1);

                if (index == count - 1)
                    previous.Next = null;
                else
                    previous.Next = GetListItem(index + 1);
            }
            count--;
        }

        public double Sum()
        {
            double summary = 0;
            if (count > 0)
            {
                ListItem<T> temp = Head;
                do
                {
                    summary = summary + Convert.ToDouble(temp.Content);
                    temp = temp.Next;
                } while (temp != null);
            }
            return summary;
        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            ListItem<T> temp = Head;
            int i = 0;
            do
            {
                array[i] = temp.Content;
                temp = temp.Next;
                i++;
            } while (temp != null);
            return array;
        }
    }
}
