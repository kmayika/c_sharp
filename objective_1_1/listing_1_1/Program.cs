using System;
using System.Threading;
//Creating Thread in a thread class
namespace listing_1_1
{
    public static class Program
    {
        // public static void ThreadMethod()
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         System.Console.WriteLine(String.Format("Thread Process: {0}", i));
        //         //singnal to Windows that this thread is finished instead of waiting
        //         //immediately switches to another thread
        //         Thread.Sleep(0);                
        //     }
        // }

        //using lambda exp. 
        public static void Main()
        {
            Thread thread = new Thread (new ThreadStart(() => 
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine(String.Format("Thread Process: {0}", i));
                    //singnal to Windows that this thread is finished instead of waiting
                    //immediately switches to another thread
                    Thread.Sleep(0);  
                }
            }));
            //start the thread
            thread.Start();

            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("This is the Main Thread");
                Thread.Sleep(0);
            }
            //keep thread running until it is done with all thread processes
            thread.Join();


        }
    }
}
