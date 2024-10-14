using System;

class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        AddFirstP();
        AddLastP();
        RemoveFirstP();
        RemoveLastP();
        ContainsP();
        FindP();
        FindLastP();
        AddAfterP();
        AddBeforeP();
        RemoveValueP();
        void AddFirstP()
        {
           var lista = new LinkedList<int>();
           
           for(int i = 0; i < 5 ; i++)
            {
                lista.AddFirst(i);
            }
            if(lista.Count == 5)
            {
                Console.WriteLine("AddFirst: Nice");
            }
            else
            {
                Console.WriteLine("AddFirst: No nice");
            }
        }

        void AddLastP()
        {
            var lista = new LinkedList<int>();
            for(int i = 0; i < 5 ; i++)
            { 
                lista.AddLast(i); 
            }
            if( lista.Count == 5)
            {
                Console.WriteLine("AddLast: Nice");
            }
            else 
            { 
                Console.WriteLine("AddLast: No nice");
            }
        }

        void RemoveFirstP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            lista.RemoveFirst();
            if (lista.Count == 4 && lista.Find(1) == null)
            {
                Console.WriteLine("RemoveFirst: Nice");
            }
            else
            {
                Console.WriteLine("RemoveFirst: No nice");
            }
        }

        void RemoveLastP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            lista.RemoveLast();
            if (lista.Count == 4 && lista.Find(5) == null)
            {
                Console.WriteLine("RemoveLast: Nice");
            }
            else
            {
                Console.WriteLine("RemoveLast: No nice");
            }
        }

        void ContainsP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            if (lista.Contains(3))
            {
                Console.WriteLine("Contains: Nice");
            }
            else
            {
                Console.WriteLine("Contains: No nice");
            }
        }

        void FindP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            if (lista.Find(3) != null)
            {
                Console.WriteLine("Find: Nice");
            }
            else
            {
                Console.WriteLine("Find: No nice");
            }
        }

        void FindLastP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            if (lista.FindLast(5) != null)
            {
                Console.WriteLine("FindLast: Nice");
            }
            else
            {
                Console.WriteLine("FindLast: No nice");
            }
        }

        void AddAfterP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            var node = lista.Find(3);
            lista.AddAfter(node, 10);
            if (lista.Find(10) != null && lista.Find(3).Next.Value.Equals(10))
            {
                Console.WriteLine("AddAfter: Nice");
            }
            else
            {
                Console.WriteLine("AddAfter: No nice");
            }
        }

        void AddBeforeP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            var node = lista.Find(3);
            lista.AddBefore(node, 20);
            if (lista.Find(20) != null && lista.Find(20).Next.Value.Equals(3))
            {
                Console.WriteLine("AddBefore: Nice");
            }
            else
            {
                Console.WriteLine("AddBefore: No nice");
            }
        }

        void RemoveValueP()
        {
            var lista = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                lista.AddLast(i);
            }
            lista.Remove(3);
            if (lista.Count == 4 && lista.Find(3) == null)
            {
                Console.WriteLine("RemoveValue: Nice");
            }
            else
            {
                Console.WriteLine("RemoveValue: No nice");
            }
        }
        Console.ReadKey();
    }
}