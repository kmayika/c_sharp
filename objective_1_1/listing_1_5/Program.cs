using System;
using System.Threading;

//using ThreadStaticAttribute
namespace listing_1_5
{
    public static class Program
    {
        [ThreadStatic]
        public static int field;
        public static void Main()
        {
            new Thread (() =>{
                for ( int i = 0; i < 10; i++)
                {
                    field++;
                    System.Console.WriteLine("Thread A: field is {0}", field);
                }
            }).Start();

            new Thread (() =>{
                for ( int i = 0; i < 10; i++)
                {
                    field++;
                    System.Console.WriteLine("Thread B: field is {0}", field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
