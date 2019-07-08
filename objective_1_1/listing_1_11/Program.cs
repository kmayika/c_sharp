using System;
using System.Threading.Tasks;

//Scheduling different continuation tasks
namespace listing_1_11
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //task returns number 42
            Task<bool> task = Task.Run(() =>
            {
                return true;
            });

            if ( task.Result != true)
            {
                var cancelled = task.ContinueWith((i) =>
                {
                    System.Console.WriteLine("Cancelled");  
                }, TaskContinuationOptions.OnlyOnCanceled);
                cancelled.Wait();

            }


            task.ContinueWith((i) =>
            {
                System.Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completed =  task.ContinueWith((i) =>
            {
                System.Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completed.Wait();


        }
    }
}
