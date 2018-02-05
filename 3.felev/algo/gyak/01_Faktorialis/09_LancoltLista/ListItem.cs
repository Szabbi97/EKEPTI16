using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LancoltLista
{
    class ListItem<T>
    {
        public T Content { get; set; }
        public ListItem<T> Next { get; set; }
    }
}
