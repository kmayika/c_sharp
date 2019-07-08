using System;
using System.Threading.Tasks;

//Attaching Child tasks to parent
namespace listing_1_12
{
    public static class Program
    {
        public static void Main()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0, 
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, 
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, 
                    TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var res = parent.ContinueWith(parentTask => 
            {
                foreach(int i in parent.Result)
                    {
                        System.Console.WriteLine(i);
                    }
            });

            res.Wait();
        }
    }
}
