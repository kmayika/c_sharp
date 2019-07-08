using System;
using System.Threading;

//using ThreadLocal <T>
namespace listing_1_6
{
    public static class Program
    {
        public static ThreadLocal<int> field =
        new ThreadLocal<int>(() =>
        {
            //CurrentThread ask for info about thread that's 
            //currently executing
            return Thread.CurrentThread.ManagedThreadId;
        });
        public static void Main()
        {
            new Thread (() =>
            {
                for (int i = 0; i < field.Value; i++)
                {
                    System.Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread (() =>
            {
                for (int i = 0; i < field.Value; i++)
                {
                    System.Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();

        }
    }
}
