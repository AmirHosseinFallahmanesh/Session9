using System;
using System.Threading;
using System.Threading.Tasks;

namespace Part10
{
    class Program
    {
        private static CancellationTokenSource tokenSource = new CancellationTokenSource();
        private static CancellationToken token =  tokenSource.Token;
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("* " );
                    Thread.Sleep(1000);
                }
            });
            Console.WriteLine("Press Any Key To Cancel Task");
            Console.ReadKey(true);
            tokenSource.Cancel();
            Console.WriteLine("End");
        }
    }
}
