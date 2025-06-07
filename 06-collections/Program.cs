using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExample
{
    class Program
    {
        static void Main()
        {
            // LIST<T> - ordered, allows duplicates
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
            fruits.Add("Apple"); // duplicate allowed
            Console.WriteLine("List contents:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            Console.WriteLine();

            // DICTIONARY<TKey, TValue> - key-value pairs
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 }
            };

            // Accessing values by key
            Console.WriteLine($"Alice's age: {ages["Alice"]}");

            // Safe lookup
            if (ages.TryGetValue("Charlie", out int age))
            {
                Console.WriteLine($"Charlie's age: {age}");
            }
            else
            {
                Console.WriteLine("Charlie is not in the dictionary.");
            }

            Console.WriteLine();

            // HASHSET<T> - unordered, no duplicates
            HashSet<string> tags = new HashSet<string> { "dotnet", "csharp", "backend" };
            tags.Add("dotnet"); // ignored (duplicate)
            Console.WriteLine("Tags:");
            foreach (var tag in tags)
            {
                Console.WriteLine($"# {tag}");
            }

            Console.WriteLine();

            // QUEUE<T> - FIFO (first in, first out)
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // First

            // STACK<T> - LIFO (last in, first out)
            Stack<string> stack = new Stack<string>();
            stack.Push("Bottom");
            stack.Push("Top");
            Console.WriteLine($"Popped: {stack.Pop()}"); // Top

            Console.WriteLine();

            // LINQ + List example
            var longFruits = fruits.Where(f => f.Length > 5);
            Console.WriteLine("Fruits with more than 5 letters:");
            foreach (var f in longFruits)
            {
                Console.WriteLine(f);
            }
        }
    }
}
