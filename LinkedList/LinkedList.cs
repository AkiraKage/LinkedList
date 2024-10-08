using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public int Count { get; set; }
        public int First { get; set; }
        public int Last { get; set; }

        LinkedList()
        {
            Count = 0;
            First = 0;
            Last = 0;
        }

        public void AddAfter()
        {

        }
    }
}
