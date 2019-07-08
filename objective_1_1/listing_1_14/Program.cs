using System;
using System.Threading.Tasks;
using System.Threading;

//using TAsk.WaitAll()
namespace listing_1_14
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //three tasks
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() => 
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task.Run(() => 
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("2");
                return 2;
            });

            tasks[2] = Task.Run(() => 
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(tasks);
        }
    }
}
