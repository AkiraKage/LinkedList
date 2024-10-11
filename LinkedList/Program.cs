using System;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        //addFirst (risultato: 20-10)
        list.AddFirst(10);
        LinkedListNode<int> node20 = new LinkedListNode<int>(20);
        list.AddFirst(node20);
        Console.WriteLine(list);

        //addLast 20-10-30-40
        list.AddLast(30);
        LinkedListNode<int> node40 = new LinkedListNode<int>(40);
        list.AddLast(node40);
        Console.WriteLine(list);

        //addAfter 20-50-10-30-40-0
        LinkedListNode<int> node50 = new LinkedListNode<int>(50);
        list.AddAfter(node20, node50);
        list.AddAfter(node40, 0);
        Console.WriteLine(list);

        //AddBefore 20-80-50-10-30-90-40-0
        LinkedListNode<int> node80 = new LinkedListNode<int>(80);
        list.AddBefore(node50, node80);
        list.AddBefore(node40, 90);
        Console.WriteLine(list);

        //Contains true-false
        Console.WriteLine(list.Contains(20));
        Console.WriteLine(list.Contains(250));

        //Find qualcosa-niente
        Console.WriteLine(list.Find(10));
        Console.WriteLine(list.Find(1009));

        //findLast qualcosa-niente
        Console.WriteLine(list.FindLast(10));
        Console.WriteLine(list.FindLast(1000));

        //Remove 20-50-30-90-40-0
        list.Remove(node80);
        list.Remove(10);
        Console.WriteLine(list);

        //RemoveFirst e last 50-30-90-40
        list.RemoveFirst();
        list.RemoveFirst();
        Console.WriteLine(list);

        //Clear null
        list.Clear();
        Console.WriteLine(list);

        list.AddFirst(1);
        list.AddFirst(2);

        //ToString 1-2
        list.ToString();
        Console.WriteLine(list);
        Console.ReadKey();
    }
}