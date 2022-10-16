using System;
using System.Collections.Generic;

namespace Part20
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> ls = new LinkedList<string>();
            ls.AddFirst("item1");
            ls.AddLast("item5");
            ls.AddFirst("item2");
            ls.AddFirst("item3");
            ls.AddLast("item4");
            LinkedListNode<string> node1 = ls.Find("item2");
            ls.AddAfter(node1, "item20");
            ls.AddAfter(node1, "item21");


            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
