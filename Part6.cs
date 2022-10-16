using System;
using System.Threading;
using System.Collections.Generic;
namespace Part6
{

    public static object threadLock=new object();
    private List<int>data=new List<int>)();
    class Program
    {
        static void Main(string[] args)
        {
          Thread a=new Thread(add);
          Thread b=new Thread(add);
          Thread c=new Thread(add);
          a.Name="th1";
          b.Name="th2";
          c.Name="th3";
          a.Start();
          b.Start();
          c.Start();
            Console.WriteLine(" th 1 "+a.ThreadState);
            Console.WriteLine(" th 2 " + b.ThreadState);
            Console.WriteLine(" th 3 " + c.ThreadState);
            Thread.Sleep(16000);
            Console.WriteLine(data.Count); //750
            Console.ReadKey();

        }

        static void add()
        {

        lock(threadLock){

          for(int i=0;i<250;i++)
            {
                Console.WriteLine(" Name "+Thread.CurrentThread.Name);
                data.Add(new Random().Next(1000));


            }
        }
         
        }
    }

}
