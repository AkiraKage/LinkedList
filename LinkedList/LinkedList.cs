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
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Last { get; set; }

        public LinkedList(){}

        public void AddFirst(T value)
        {
            LinkedListNode<T> element = new LinkedListNode<T>(value) { Next = Head };
            if(Head == null) Last = element;
            Head = element;
            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> element = new LinkedListNode<T>(value) { Next = null };
            Last.Next = element;
            Last = element;
            Count++;
        }

        public void AddAfter()
        {

        }
    }

    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}
