using System;
using System.Threading;

namespace Part11
{
    class Program
    {//async performs asynchronous tasks 
     //await making  “await” to a statement means suspending the execution of the async method 
        static void Main(string[] args)
        {
            //time -> 5036
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            StartApplication();
            LoadMap();
            InitProfile();
            watch.Stop();
            Console.WriteLine("Excution Time is "+watch.ElapsedMilliseconds);
        }


        public static void StartApplication()
        {
            Thread.Sleep(3000);
            Console.WriteLine("App Started ...");
        }

        public static void LoadMap()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Map Loaded Successfully");
        }

        public static void InitProfile()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Profile Loaded Successfully");
        }
    }
}

