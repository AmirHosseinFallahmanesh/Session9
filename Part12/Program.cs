using System;
using System.Threading;
using System.Threading.Tasks;

namespace Part12
{
    class Program
    {
        static async Task  Main(string[] args)
        {
            //time -> 3092
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var t1=StartApplication();
            // t1.Wait(); //4114
            await t1;
            var t2=LoadMap();
            var t3=InitProfile();

            await t2;
            await t3;
            watch.Stop();
            Console.WriteLine("Excution Time is " + watch.ElapsedMilliseconds);
        }


        public static async Task StartApplication()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("App Started ...");
                
            });
        }

        public static async Task LoadMap()
        {

            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Map Loaded Successfully");
            });
           
        }

        public static async Task InitProfile()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Profile Loaded Successfully");
            });
           
        }
    }
}

