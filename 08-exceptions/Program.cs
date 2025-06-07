using System;

namespace ExceptionsExample
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                int number = int.Parse(input); // May throw FormatException or OverflowException

                Console.WriteLine($"Result: 100 / {number} = {Divide(100, number)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("[ERROR] Invalid number format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("[ERROR] Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                // Throwing a built-in exception
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }

    // Custom exception example (not used in main program but can be expanded)
    class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message) { }
    }
}
