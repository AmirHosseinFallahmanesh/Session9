using System;
using System.Threading;

//thread List->th1,th2,mainThread

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(th1); 
            Thread thread2 = new Thread(th2); 
            thread1.Start();
            thread2.Start();



            Console.ReadKey();



        }

        static void th1()
        {

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2000);
                Console.SetCursorPosition(40, i);
                Console.WriteLine("hi");
            }

        }

        static void th2()
        {

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1500);
                Console.SetCursorPosition(20, i);
                Console.WriteLine("bye");
            }

        }
    }
}
