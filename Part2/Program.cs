using System;
using System.Threading;



namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var primaryThread = Thread.CurrentThread;
            primaryThread.Name = "PrimaryThread"; //optional
            Console.WriteLine("Thread Name: {0}", primaryThread.Name);
            Console.WriteLine("Thread AppDomain: {0}", Thread.GetDomain().FriendlyName);
            Console.WriteLine("Thread ManagedThreadId: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread Statred: {0}", primaryThread.IsAlive);
            Console.WriteLine("Thread Priority: {0}", primaryThread.Priority);
            Console.WriteLine("Thread State: {0}", primaryThread.ThreadState);
            Console.ReadKey();
        }
    }
}