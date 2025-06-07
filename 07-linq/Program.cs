using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main()
        {
            // Sample data: list of products
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200, Category = "Electronics" },
                new Product { Name = "Mouse", Price = 25, Category = "Electronics" },
                new Product { Name = "Notebook", Price = 5, Category = "Stationery" },
                new Product { Name = "Pen", Price = 2, Category = "Stationery" },
                new Product { Name = "Headphones", Price = 150, Category = "Electronics" }
            };

            // LINQ: Filtering
            var expensiveItems = products.Where(p => p.Price > 100);
            Console.WriteLine("Expensive items (price > 100):");
            foreach (var item in expensiveItems)
            {
                Console.WriteLine($"- {item.Name} (${item.Price})");
            }

            Console.WriteLine();

            // LINQ: Projection with Select
            var productNames = products.Select(p => p.Name);
            Console.WriteLine("Product names:");
            foreach (var name in productNames)
            {
                Console.WriteLine($"* {name}");
            }

            Console.WriteLine();

            // LINQ: Aggregation
            var averagePrice = products.Average(p => p.Price);
            var totalProducts = products.Count();
            Console.WriteLine($"Average price: ${averagePrice:F2}");
            Console.WriteLine($"Total number of products: {totalProducts}");

            Console.WriteLine();

            // LINQ: Ordering
            var orderedByPrice = products.OrderBy(p => p.Price);
            Console.WriteLine("Products ordered by price:");
            foreach (var p in orderedByPrice)
            {
                Console.WriteLine($"{p.Name}: ${p.Price}");
            }

            Console.WriteLine();

            // LINQ: Grouping
            var groupedByCategory = products.GroupBy(p => p.Category);
            Console.WriteLine("Products grouped by category:");
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var p in group)
                {
                    Console.WriteLine($"- {p.Name} (${p.Price})");
                }
            }
        }
    }

    // Helper class for product data
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
