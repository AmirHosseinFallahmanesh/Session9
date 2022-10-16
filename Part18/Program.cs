using System;
using System.Collections.Generic;

namespace Part18
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> str = new HashSet<int>();
            str.Add(12);
            str.Add(12);
            str.Add(12);
            str.Add(13);
            str.Add(13);
            str.Add(15);
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
