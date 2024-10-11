using System;

class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        addFirstP();
        void addFirstP()
        {
           var lista = new CLinkedList<int>();
           
           for(int i = 0; i < 5 ; i++)
            {
                lista.AddFirst(i);
            }
            if(lista.Count == 4)
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