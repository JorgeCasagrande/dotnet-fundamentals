﻿using System;

namespace VariablesAndTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to variables and basic data types in C#

            // Integer (whole number)
            int age = 30;
            Console.WriteLine($"Integer - Age: {age}");

            // Floating point number
            float height = 1.75f; // 'f' suffix is required for float literals
            Console.WriteLine($"Float - Height: {height}m");

            // Double precision floating point
            double weight = 70.5;
            Console.WriteLine($"Double - Weight: {weight}kg");

            // Decimal (used for precise financial or currency calculations)
            decimal accountBalance = 1050.75m; // 'm' suffix is required for decimal literals
            Console.WriteLine($"Decimal - Account Balance: ${accountBalance}");

            // Character
            char initial = 'J';
            Console.WriteLine($"Char - Initial: {initial}");

            // String (sequence of characters)
            string fullName = "Jorge Casagrande";
            Console.WriteLine($"String - Full Name: {fullName}");

            // Boolean (true/false)
            bool isLoggedIn = true;
            Console.WriteLine($"Boolean - Is Logged In: {isLoggedIn}");

            // Implicit typing with 'var' (type inferred by the compiler)
            var country = "Argentina";
            Console.WriteLine($"Var - Country: {country}");

            // Constant value (cannot be changed)
            const double Pi = 3.14159;
            Console.WriteLine($"Constant - Pi: {Pi}");

            // Nullable types (can hold a value or be null)
            int? nullableValue = null;
            Console.WriteLine($"Nullable Int - Value: {nullableValue?.ToString() ?? "null"}");
        }
    }
}
