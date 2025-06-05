using System;

namespace ControlStructures
{
    // The main entry point for demonstrating control structures in C#
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Control Structures in C# ===\n");

            // Execute examples of different control structures
            IfElseExample(10);
            SwitchExample("admin");
            ForLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();
            ForeachLoopExample();
        }

        // If-Else Statement: Executes code conditionally based on a boolean expression.
        private static void IfElseExample(int number)
        {
            Console.WriteLine("If-Else Example:");
            
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            Console.WriteLine();
        }

        // Switch Statement: Efficiently handles multiple conditions.
        private static void SwitchExample(string role)
        {
            Console.WriteLine("Switch Example:");
            
            switch (role.ToLower())
            {
                case "admin":
                    Console.WriteLine("Role: Administrator");
                    break;
                case "user":
                    Console.WriteLine("Role: User");
                    break;
                case "guest":
                    Console.WriteLine("Role: Guest");
                    break;
                default:
                    Console.WriteLine("Unknown role");
                    break;
            }

            Console.WriteLine();
        }

        // For Loop: Iterates a fixed number of times.
        private static void ForLoopExample()
        {
            Console.WriteLine("For Loop Example:");
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            Console.WriteLine();
        }

        // While Loop: Runs while a condition remains true.
        private static void WhileLoopExample()
        {
            Console.WriteLine("While Loop Example:");
            int count = 1;
            
            while (count <= 3)
            {
                Console.WriteLine($"Count: {count}");
                count++;
            }

            Console.WriteLine();
        }

        // 🔹 Do-While Loop: Executes at least once before checking the condition.
        private static void DoWhileLoopExample()
        {
            Console.WriteLine("Do-While Loop Example:");
            int count = 1;
            
            do
            {
                Console.WriteLine($"Count: {count}");
                count++;
            } while (count <= 3);

            Console.WriteLine();
        }

        // 🔹 Foreach Loop: Iterates over a collection of items.
        private static void ForeachLoopExample()
        {
            Console.WriteLine("Foreach Loop Example:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
        }
    }
}