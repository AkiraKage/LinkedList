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

public class CLinkedList<T>
{
    private LinkedListNode<T> head;
    private LinkedListNode<T> tail;
    public int Count { get; private set; }

    public LinkedListNode<T> First => head;
    public LinkedListNode<T> Last => tail;

    public CLinkedList()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public void AddFirst(LinkedListNode<T> node)
    {
        if (head == null)
        {
            head = tail = node;
        }
        else
        {
            node.Next = head;
            head.Previous = node;
            head = node;
        }
        Count++;
    }

    public void AddFirst(T value)
    {
        AddFirst(new LinkedListNode<T>(value));
    }

    public void AddLast(LinkedListNode<T> node)
    {
        if (tail == null)
        {
            head = tail = node;
        }
        else
        {
            node.Previous = tail;
            tail.Next = node;
            tail = node;
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

        if (existingNode == tail)
        {
            tail = newNode;
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

        if (existingNode == head)
        {
            head = newNode;
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
        LinkedListNode<T> current = head;
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
        LinkedListNode<T> current = tail;
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
            head = node.Next;
        }

        if (node.Next != null)
        {
            node.Next.Previous = node.Previous;
        }
        else
        {
            tail = node.Previous;
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
        if (head == null)
        {
            Console.WriteLine("lista vuota");
        }

        Remove(head);
    }

    public void RemoveLast()
    {
        if (tail == null)
        {
            Console.WriteLine("lista vuota");
        }
        Remove(tail);
    }

    public void Clear()
    {
        head = tail = null;
        Count = 0;
    }

    public override string ToString()
    {
        LinkedListNode<T> current = head;
        string result = "";
        while (current != null)
        {
            result += current.Value + " -> ";
            current = current.Next;
        }
        return result + "null";
    }
}