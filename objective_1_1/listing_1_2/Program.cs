using System;
using System.Threading;
//Using Background and Foreground Threads
namespace listing_1_2
{
    class Program
    {
        public static void Main()
        {
            Thread thread = new Thread (new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine("Thread Process : {0}", i);
                    Thread.Sleep(1000);
                }
            }));
            //determeines whether thread is running in the background or not (foreground thread)
            thread.IsBackground = true;
            thread.Start();


        }
    }
}
