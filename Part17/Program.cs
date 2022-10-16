using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part17
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sl = new SortedDictionary<int, string>();
            sl.Add(12, "nariman");
            sl.Add(90, "mahya");
            sl.Add(28, "karim");
            sl[45] = "test";
            

            foreach (var item in sl)
            {
                Console.WriteLine(item.Key + "    " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
