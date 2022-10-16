using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part16
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(12, "nariman");
            sl.Add(90, "mahya");
            sl.Add(28, "saman");
            sl[60] = "karim";
            foreach (KeyValuePair<int, string> item in sl)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }

            Console.ReadKey();
        }
    }
}
