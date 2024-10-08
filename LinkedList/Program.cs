using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> test = new LinkedList<int>();
            test.AddLast(3);
            test.AddFirst(4);
            Console.WriteLine(test.Count);
        }
    }
}
