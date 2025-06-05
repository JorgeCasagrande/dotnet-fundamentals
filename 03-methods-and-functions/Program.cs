using System;

namespace MethodsAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method that prints a greeting
            GreetUser("Alice");

            // Call method that returns the sum of two integers
            int sum = Add(10, 20);
            Console.WriteLine($"Sum: {sum}");

            // Call method that calculates and returns the area of a rectangle
            double area = CalculateArea(5.5, 3.2);
            Console.WriteLine($"Rectangle area: {area}");

            // Call overloaded Multiply methods
            Console.WriteLine($"Multiply 2 * 4 = {Multiply(2, 4)}");
            Console.WriteLine($"Multiply 2 * 4 * 3 = {Multiply(2, 4, 3)}");

            // Call a static method used for demonstration
            StaticExample();
        }

        // A method with no return value (void) that takes one string parameter
        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // A method that takes two integers and returns their sum
        static int Add(int a, int b)
        {
            return a + b;
        }

        // A method that takes two doubles and returns the result of width * height
        static double CalculateArea(double width, double height)
        {
            return width * height;
        }

        // Method overloading: this version multiplies two integers
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method overloading: this version multiplies three integers
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        // A static helper method to show that static methods can be reused
        static void StaticExample()
        {
            Console.WriteLine("This is a static method.");
        }
    }
}
