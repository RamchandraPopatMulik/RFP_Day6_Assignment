using System.Diagnostics;

namespace LogicalProgramQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Ramchandra Popat Mulik");
            }

            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
    
