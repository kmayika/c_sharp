using System;
using System.Threading.Tasks;
using System.Threading;

//USing Parallel.For and Parallel.Foreach
namespace listing_1_16
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task tasks = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine("Not " + i);
                }

            });

            Parallel.For(0, 10, i =>
            {
                System.Console.WriteLine("Is " + i);
                Thread.Sleep(1000);
            });

            tasks.Wait();
        }
    }
}
