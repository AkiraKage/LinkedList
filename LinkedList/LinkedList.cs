using System;

namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }

    public class LinkedList<T>
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _last;
        public int Count { get; private set; }
    
        public void AddFirst(LinkedListNode<T> node)
        {
            if (_head == null)
            {
                _head = _last = node;
            }
            else
            {
                node.Next = _head;
                _head.Previous = node;
                _head = node;
            }
            Count++;
        }

        public void AddFirst(T value) => AddFirst(new LinkedListNode<T>(value));

        public void AddLast(LinkedListNode<T> node)
        {
            if (_last == null)
            {
                _head = _last = node;
            }
            else
            {
                node.Previous = _last;
                _last.Next = node;
                _last = node;
            }
            Count++;
        }

        public void AddLast(T value) => AddLast(new LinkedListNode<T>(value));

        public void AddAfter(LinkedListNode<T> existingNode, LinkedListNode<T> newNode)
        {
            if (existingNode == null || newNode == null)
            {
                Console.WriteLine("Presenti nodi non esistenti nel comando, ricontrollare");
                return;
            }

            newNode.Next = existingNode.Next;
            newNode.Previous = existingNode;
            if (existingNode.Next != null) existingNode.Next.Previous = newNode;
            existingNode.Next = newNode;

            if (existingNode == _last) _last = newNode;
            Count++;
        }

        public void AddAfter(LinkedListNode<T> existingNode, T value) 
            => AddAfter(existingNode, new LinkedListNode<T>(value));

        public void AddBefore(LinkedListNode<T> existingNode, LinkedListNode<T> newNode)
        {
            if (existingNode == null || newNode == null)
            {
                Console.WriteLine("Presenti nodi non esistenti nel comando, ricontrollare");
                return;
            }

            newNode.Previous = existingNode.Previous;
            newNode.Next = existingNode;
            if (existingNode.Previous != null) existingNode.Previous.Next = newNode;
            existingNode.Previous = newNode;

            if (existingNode == _head) _head = newNode;
            Count++;
        }

        public void AddBefore(LinkedListNode<T> existingNode, T value) 
            => AddBefore(existingNode, new LinkedListNode<T>(value));

        public bool Contains(T value)
        {
            return Find(value) != null;
        }

        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;
                current = current.Next;
            }
            return null;
        }

        public LinkedListNode<T> FindLast(T value)
        {
            LinkedListNode<T> current = _last;
            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;
                current = current.Previous;
            }
            return null;
        }

        public void Remove(LinkedListNode<T> node)
        {
            if (node == null)
            {
                Console.WriteLine("Nodo nullo, ricontrollare");
                return;
            }

            if (node.Previous != null) node.Previous.Next = node.Next;
            else _head = node.Next;

            if (node.Next != null) node.Next.Previous = node.Previous;
            else _last = node.Previous;
            Count--;
        }

        public void Remove(T value)
        {
            LinkedListNode<T> node = Find(value);
            if (node != null)
            {
                Remove(node);
                return;
            }
            Count--;
        }

        public void RemoveFirst()
        {
            if (_head == null)
            {
                Console.WriteLine("lista vuota");
                return;
            }

            Remove(_head);
        }

        public void RemoveLast()
        {
            if (_last == null)
            {
                Console.WriteLine("lista vuota");
                return;
            }
            Remove(_last);
        }

        public void Clear()
        {
            _head = _last = null;
            Count = 0;
        }

        public override string ToString()
        {
            LinkedListNode<T> current = _head;
            string result = "";
            while (current != null)
            {
                result += current.Value + " -> ";
                current = current.Next;
            }
            return result + "null";
        }
    }
}