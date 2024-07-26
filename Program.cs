using System.Diagnostics;

namespace MyTestNetAysncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Program obj = new Program();
            obj.ExecuteAllTasks();
            Console.WriteLine("All work completed successfully.");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        private void ExecuteWrok1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Work1 executed successfully");
        }

        private void ExecuteWrok2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Work2 executed successfully");
        }

        private void ExecuteWrok3()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work3 executed successfully");
        }

        private void ExecuteWrok4()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Work4 executed successfully");
        }

        private void ExecuteAllTasks()
        {
            ExecuteWrok1();
            ExecuteWrok2();
            ExecuteWrok3();
            ExecuteWrok4();
        }

    }
}
