using System;
using System.Net;
using System.Threading;

namespace Part7
{//WaitCallback represents a callback method that you want to execute on a ThreadPool thread.
    class Program
    {
        static void Main(string[] args)
        {
            //Thread th = new Thread(()=> { });
            //th.Suspend();
            //th.Resume();
            //th.Abort();

            WaitCallback callback1 = new WaitCallback((obj) =>
              {
                  Thread.Sleep(2000);
                  Console.WriteLine("Welcome To New Thread Pool");
                 // throw new Exception("");
              });


            WaitCallback callback2 = new WaitCallback((obj) =>
            {
                WebRequest request = WebRequest.Create("https://google.com");
                WebResponse response = request.GetResponse();
                Console.WriteLine("Done");
            });


            ThreadPool.QueueUserWorkItem(callback1);
            ThreadPool.QueueUserWorkItem(callback2);


            Console.ReadKey();
        }
    }
}
