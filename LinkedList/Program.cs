using System;

class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        AddFirstP();
        AddLastP();
        void AddFirstP()
        {
           var lista = new LinkedList<int>();
           
           for(int i = 0; i < 5 ; i++)
            {
                lista.AddFirst(i);
            }
            if(lista.Count == 5)
            {
                Console.WriteLine("Nice");
            }
            else
            {
                Console.WriteLine("No nice");
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
                Console.WriteLine("Nice");
            }
            else 
            { 
                Console.WriteLine("No nice");
            }
        }

        
        Console.ReadKey();
    }
}