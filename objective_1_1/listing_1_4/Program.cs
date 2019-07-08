using System;
using System.Threading;

//stopping a thread
namespace listing_1_4
{
    public static class Program
    {
        public static void Main()
        {
            bool stopped = false;
            Thread thread = new Thread (new ThreadStart(() =>
            {
                while (!stopped)
                {
                    System.Console.WriteLine("Running....");
                    Thread.Sleep(1000);
                }
            }));

            thread.Start();
            System.Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            thread.Join();
        }
    }
}
