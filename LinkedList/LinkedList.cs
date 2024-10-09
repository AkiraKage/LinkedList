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

        public void AddFirst(LinkedListNode<T> node)
        {
            if(Head == null) Last = node;
            node.Next = Head;
            Head = node;
            Count++;
        }

        public void AddFirst(T value)
        {
            LinkedListNode<T> element = new LinkedListNode<T>(value) { Next = Head };
            AddFirst(element);
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Last == null)
            {
                AddFirst(node);
                return;
            }
            Last.Next = node;
            Last = node;
            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> element = new LinkedListNode<T>(value);
            AddLast(element);
        }


        public void AddAfter(LinkedListNode<T> targetNode, LinkedListNode<T> newNode)
        {
            newNode.Next = targetNode.Next;
            targetNode.Next = newNode;
            if (targetNode == Last) Last = newNode;
            Count++;
        }

        public void AddAfter(LinkedListNode<T> targetNode, T value)
        {
            LinkedListNode<T> element = new LinkedListNode<T>(value) { Next = targetNode.Next };
            AddAfter(targetNode, element);
        }

        public void AddBefore(LinkedListNode<T> targetNode, LinkedListNode<T> newNode)
        {
            if(Head == null || targetNode == Head)
            {
                AddFirst(newNode);
                return;
            }
            LinkedListNode<T> currentNode = Head.Next;
            while(currentNode.Next != targetNode && currentNode.Next != null) currentNode = currentNode.Next;
            if(currentNode.Next == null)
            {
                Console.WriteLine("Nodo non trovato");
                return;
            }
            AddAfter(currentNode, newNode);
        }

        public void AddBefore(LinkedListNode<T> targetNode, T value)
        {
            LinkedListNode<T> element = new LinkedListNode<T>(value);
            AddBefore(targetNode, element);
        }

        public void Clear()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        public bool Contains(T target)
        {
            LinkedListNode<T> currentNode = Head;
            while(currentNode != null)
            {
                if(currentNode.Value.Equals(target)) return true; // "==" and "!=" operators don't work with T (generic type)
                currentNode = currentNode.Next;
            }
            return false;
        }

        public LinkedListNode<T> Find(T target)
        {
            LinkedListNode<T> currentNode = Head;
            while(currentNode != null)
            {
                if (currentNode.Value.Equals(target)) return currentNode;
                currentNode = currentNode.Next;
            }
            return null;
        }

        public LinkedListNode<T> FindLast(T target)
        {
            LinkedListNode<T> currentNode = Head;
            LinkedListNode<T> foundNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(target)) foundNode = currentNode;
                currentNode = currentNode.Next;
            }

            return foundNode;
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
