using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public int Count;
        public LinkedListNode<T> Head;
        public LinkedListNode<T> Last;

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
            if(Last != null) Last.Next = element;
            else Head = element;
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
        public LinkedListNode<T> Next;

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}
