using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part14
{
    class Program
    {
        static void Main(string[] args)
        {
            //last in first out
            Stack<string> st = new Stack<string>();
            st.Push("item1");
            st.Push("item2");
            st.Push("item3");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            //Console.WriteLine(new string('_', 80));
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();

        }
    }
}
