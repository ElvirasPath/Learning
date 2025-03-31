using System;
using System.Collections.Generic;
namespace inventory;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product ("Pen", 5, 100),
            new Product ("Pencil", 3, 180),
            new Product ("Paper",40, 167),
            new Product ("Notebook", 20, 134),
            new Product ("Book", 50, 130)
        };

        Console.WriteLine("Welcome to our shop!");
        Console.WriteLine("Enter what you want to do: 1) check available products 2) check price of available products 3) check quantity of available products");
        string? userInput = Console.ReadLine();

        if (userInput == "check available products")
        {
            foreach (Product product in products)
            {
                Console.WriteLine();
                Console.Write($"{product.Name};");
            }
        }
        else if (userInput == "check price of available products")
        {
            foreach (Product product in products)
            {
                Console.WriteLine();
                Console.Write($"{product.Name}: {product.Price}$;");
            }
        }
        else if (userInput == "check quantity of available products")
        {
            foreach (Product product in products)
            {
                Console.WriteLine();
                Console.Write($"{product.Name}: {product.Quantity}pcs;");
            }
        }
        else Console.WriteLine("Wrong operation.");
    }

    class Product
    {
        public string? Name { get; private set; } // property
        public decimal Price { get; private set; }
        public double Quantity { get; private set; }
        public Product(string? name, decimal price, double quantity) // parameters
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name cannot be empty or whitespace.");
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");
            if (quantity < 0)
                throw new ArgumentException("Quantity cannot be negative.");

            Name = name;
            Price = price;
            Quantity = quantity;

        }
    }
    public void IncreaseQuantity(int amount)
    {
        if (amount > 0)
            Quantity += amount;
        else
            Console.WriteLine("Wrong operation, you need to enter a valid number");
    }
    public void DecreaseQuantity(int amount)
    {
        if (amount > 0 && Quantity - amount >= 0)
            Quantity -= amount;
        else
            Console.WriteLine("Wrong operation, you need to enter a valid number");
    }
}
