using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part8
{
    class Program
    {
        public delegate int MathOperation(int n1, int n2, int n3);
        static void Main(string[] args)
        {
            MathOperation operation = new MathOperation(Add);


            Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);
            var result = operation.BeginInvoke(2, 6, 25, null, null);
            var answer = operation.EndInvoke(result);

            Console.WriteLine("Task in Main method.");


            Console.WriteLine("2 + 6 = {0}", answer);

            Console.ReadKey();



        }

        public static int Add(int n1, int n2, int n3)
        {
            Console.WriteLine("Add thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("2+25 = " + n1 + n3);
            //Console.WriteLine(n1 + n2);
            return n1 + n2;
        }

    }
}
