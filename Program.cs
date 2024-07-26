using System.Diagnostics;

namespace MyTestNetAysncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string isExit = string.Empty;
            do
            {
                Stopwatch sw = Stopwatch.StartNew();
                Program obj = new Program();
                await obj.ExecuteAllTasksAsync();
                Console.WriteLine("All work completed successfully.");
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);                
                isExit = Convert.ToString(Console.ReadLine());
                isExit = !string.IsNullOrEmpty(isExit) ? isExit.ToLower() : "";
            }
            while (isExit != "exit");
        }

        private void ExecuteWork1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Work1 executed successfully");
        }

        private void ExecuteWork2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Work2 executed successfully");
        }

        private void ExecuteWork3()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work3 executed successfully");
        }

        private void ExecuteWork4()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Work4 executed successfully");
        }

        private async Task ExecuteAllTasksAsync()
        {
            List<Task> tskList = new List<Task>();
            tskList.Add(Task.Run(() => ExecuteWork1()));
            tskList.Add(Task.Run(() => ExecuteWork2()));
            tskList.Add(Task.Run(() => ExecuteWork3()));
            tskList.Add(Task.Run(() => ExecuteWork4()));
            await Task.WhenAll(tskList);
            //await Task.WhenAll();
        }

    }
}
