using System;

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
    private LinkedListNode<T> Head;
    private LinkedListNode<T> Last;
    public int Count { get; private set; }

    public LinkedList()
    {
        Head = null;
        Last = null;
        Count = 0;
    }

    public void AddFirst(LinkedListNode<T> node)
    {
        if (Head == null)
        {
            Head = Last = node;
        }
        else
        {
            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }
        Count++;
    }

    public void AddFirst(T value)
    {
        AddFirst(new LinkedListNode<T>(value));
    }

    public void AddLast(LinkedListNode<T> node)
    {
        if (Last == null)
        {
            Head = Last = node;
        }
        else
        {
            node.Previous = Last;
            Last.Next = node;
            Last = node;
        }
        Count++;
    }

    public void AddLast(T value)
    {
        AddLast(new LinkedListNode<T>(value));
    }

    public void AddAfter(LinkedListNode<T> existingNode, LinkedListNode<T> newNode)
    {
        if (existingNode == null || newNode == null)
            throw new ArgumentNullException();

        newNode.Next = existingNode.Next;
        newNode.Previous = existingNode;
        if (existingNode.Next != null)
        {
            existingNode.Next.Previous = newNode;
        }
        existingNode.Next = newNode;

        if (existingNode == Last)
        {
            Last = newNode;
        }
        Count++;
    }

    public void AddAfter(LinkedListNode<T> existingNode, T value)
    {
        AddAfter(existingNode, new LinkedListNode<T>(value));
    }

    public void AddBefore(LinkedListNode<T> existingNode, LinkedListNode<T> newNode)
    {
        if (existingNode == null || newNode == null)
            throw new ArgumentNullException();

        newNode.Previous = existingNode.Previous;
        newNode.Next = existingNode;
        if (existingNode.Previous != null)
        {
            existingNode.Previous.Next = newNode;
        }
        existingNode.Previous = newNode;

        if (existingNode == Head)
        {
            Head = newNode;
        }
        Count++;
    }

    public void AddBefore(LinkedListNode<T> existingNode, T value)
    {
        AddBefore(existingNode, new LinkedListNode<T>(value));
    }

    public bool Contains(T value)
    {
        return Find(value) != null;
    }

    public LinkedListNode<T> Find(T value)
    {
        LinkedListNode<T> current = Head;
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
        LinkedListNode<T> current = Last;
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
            throw new ArgumentNullException();

        if (node.Previous != null)
        {
            node.Previous.Next = node.Next;
        }
        else
        {
            Head = node.Next;
        }

        if (node.Next != null)
        {
            node.Next.Previous = node.Previous;
        }
        else
        {
            Last = node.Previous;
        }
        Count--;
    }

    public bool Remove(T value)
    {
        LinkedListNode<T> node = Find(value);
        if (node != null)
        {
            Remove(node);
            return true;
        }
        return false;
    }

    public void RemoveFirst()
    {
        if (Head == null)
        {
            Console.WriteLine("lista vuota");
        }

        Remove(Head);
    }

    public void RemoveLast()
    {
        if (Last == null)
        {
            Console.WriteLine("lista vuota");
        }
        Remove(Last);
    }

    public void Clear()
    {
        Head = Last = null;
        Count = 0;
    }

    public override string ToString()
    {
        LinkedListNode<T> current = Head;
        string result = "";
        while (current != null)
        {
            result += current.Value + " -> ";
            current = current.Next;
        }
        return result + "null";
    }
}