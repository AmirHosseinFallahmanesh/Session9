using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part15
{
    class Program
    {
        static void Main(string[] args)
        {   //FIFO fist in fist in fist out
            Queue<int> ls = new Queue<int>();
            ls.Enqueue(1);
            ls.Enqueue(2);
            ls.Enqueue(3);
            
            Console.WriteLine(ls.Dequeue());
            Console.WriteLine(ls.Dequeue());
            Console.WriteLine(ls.Dequeue());
            Console.ReadKey();
        }
    }
}
