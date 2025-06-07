using System;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Starting async tasks...");

            // Awaiting a single task
            string result = await GetDataFromServerAsync();
            Console.WriteLine($"Single task result: {result}");

            Console.WriteLine();

            // Running multiple async tasks in parallel
            var task1 = GetDataFromServerAsync("Task 1", 2000);
            var task2 = GetDataFromServerAsync("Task 2", 1500);

            string[] results = await Task.WhenAll(task1, task2);

            Console.WriteLine("Parallel task results:");
            foreach (var res in results)
            {
                Console.WriteLine(res);
            }

            Console.WriteLine("\nDone.");
        }

        // Async method simulating a delay
        static async Task<string> GetDataFromServerAsync(string name = "Default Task", int delay = 1000)
        {
            Console.WriteLine($"{name}: starting...");
            await Task.Delay(delay); // Simulates time-consuming work
            Console.WriteLine($"{name}: completed.");
            return $"{name} result";
        }
    }
}
