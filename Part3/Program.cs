using System;
using System.Threading;


namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadStart ThreadStart = new ThreadStart(PrintNumbers);
            Thread thread = new Thread(ThreadStart);
            thread.Name = "PrintNumbersThread";
            thread.Start();
            while (thread.IsAlive)
            {
                Console.WriteLine("Running in primary thread...");
                Thread.Sleep(4000);
            }
            Console.WriteLine("All done.");
            Console.ReadKey();


        }
        public static void PrintNumbers()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Running From Thread: {0} ", counter + 1);
                Thread.Sleep(4000);
            }
        }
    }
}