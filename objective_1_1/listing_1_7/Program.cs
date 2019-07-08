using System;
using System.Threading;

//Queuing some work to the Thread Pool
namespace listing_1_7
{
    public static class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                System.Console.WriteLine("Working from Thread Pool");
            });

            Console.ReadLine();
        }
    }
}
