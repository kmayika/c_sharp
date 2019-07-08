using System;
using System.Threading;
//Using ParameterizedThreadStart
namespace listing_1_3
{
    public static class Program
    {
        public static void Main()
        {
            Thread thread = new Thread (new ParameterizedThreadStart((object o) =>
            {
                for (int i = 0; i < (int)o; i++)
                {
                    System.Console.WriteLine("Thread Process : {0}", i);
                    Thread.Sleep(0);
                }
            }));
            //value 5 is passed to the ThreadMethod as an object, cast it to expected type to use 
            //in method
            thread.Start(5);
            thread.Join();
        }
    }
}
