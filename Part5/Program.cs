using System;
using System.Threading;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(25, i);
                    Console.WriteLine("by");
                    Thread.Sleep(200);
                }

            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.SetCursorPosition(2 * i, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hi");
                    Thread.Sleep(500);
                }

            });


            t1.Start();
            t2.Start();
            Thread.Sleep(4000);
            Console.WriteLine(t1.ThreadState);
            Console.ReadKey();


        }
    }

}
