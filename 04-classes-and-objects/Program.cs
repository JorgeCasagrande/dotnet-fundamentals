using System;

namespace DotnetFundamentals.Modules
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object (instance) of the Person class
            Person person = new Person("Alice", 30);

            // Access object properties
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");

            // Call object method
            person.Introduce();

            // Modify properties
            person.Age += 1;
            Console.WriteLine($"Happy Birthday! New Age: {person.Age}");
        }
    }

    // Class definition
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }
}
