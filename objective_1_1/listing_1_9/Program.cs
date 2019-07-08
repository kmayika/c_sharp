using System;
using System.Threading.Tasks;

//Using Task to return value
namespace listing_1_9
{
    public static class Program
    {
        public static void Main()
        {
            Task<string> task = Task.Run(() =>
            {
                return "Task returned me";
            });

            System.Console.WriteLine(task.Result);
        }
    }
}
