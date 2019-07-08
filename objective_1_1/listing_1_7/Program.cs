using System;
using System.Threading;

//Queuing some work to the Thread Pool
namespace listing_1_7
{
    public static class Program
    {
        public static void Main()
        {
            int worker, port;
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Working from Thread Pool");
            });
            ThreadPool.GetMinThreads(out worker, out port);
            System.Console.WriteLine(worker + " " + port);

            Console.ReadLine();
        }
    }
}
