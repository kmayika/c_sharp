using System;
using System.Threading.Tasks;

//Adding a continuation
namespace listing_1_10
{
    public static class Program
    {
        public static void Main()
        {
            Task<string> task = Task.Run(() =>
            {
                return "kwezi";
            }).ContinueWith((i) =>{
                return i.Result + " Mayikana";
            });

            System.Console.WriteLine(task.Result);
        }
    }
}
