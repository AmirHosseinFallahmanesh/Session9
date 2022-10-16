using System;
using System.Threading;
using System.Threading.Tasks;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main thread id is "+Thread.CurrentThread.ManagedThreadId);
            Task.Factory.StartNew(() =>
            {
                Task.Delay(2000);
                Console.WriteLine("this task id is "+Thread.CurrentThread.ManagedThreadId);
            });


            Task.Run(() =>
            {
                Console.WriteLine("this task id is " + Thread.CurrentThread.ManagedThreadId);
            });

            Console.ReadKey();
        }
    }
}
