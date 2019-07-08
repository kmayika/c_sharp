using System;
using System.Threading.Tasks;

//Starting a new task
namespace listing_1_8
{
    public static class Program
    {
        public static void Main()
        {
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine("Task Running {0}", i);
                }
            });
            //equivalent to Join() method, waits until task is done before exiting
            task.Wait();
        }
    }
}
