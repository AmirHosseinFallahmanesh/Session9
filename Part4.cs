using System;
using System.Threading;
//foreground thread  mainThread Wait for finishing this thread types
//background thread  mainThread dosent Wait for finishing this thread types and Close The App

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread a=new Thread(()=>{
                Thread.Sleep(40000);
                Console.WriteLine("Hello");
            });
            a.IsBackground=true;
            a.start();
        }
    }
}