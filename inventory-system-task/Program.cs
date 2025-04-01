using System;
using System.Collections.Generic;
namespace inventory;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        Console.WriteLine("Welcome to our inventory!");
        Console.WriteLine("Write /n 1 to add product, /n 2 to update product, /n 3 to show products, /n 4 to exit.");
        string? userChoice = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userChoice))
        {
            Console.WriteLine("Invalid input. Name cannot be empty or spaces.");
            return;
        }
        
        switch (userChoice)
        {
            case "1":
                Console.WriteLine("Enter a new product name: ");
                string? productName = Console.ReadLine();
                Console.WriteLine("Enter a new product price: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.WriteLine("Error, invalid input");
                    return;
                }
                Console.Write("Enter quantity: ");
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Error, invalid input");
                    return;
                }
                inventory.AddProduct(name, price, quantity);
                break;

            case "2":
                Console.Write("Enter product name: ");
                string? productUpdate = Console.ReadLine();
                Console.Write("Enter amount: ");
                if (!int.TryParse(Console.ReadLine(), out int amount))
                {
                    Console.WriteLine("Error, invalid input");
                    return;
                }
                Console.Write("Increase - (y) or decrease (n): ");
                bool increase = Console.Readline().ToLower() == "y";
                inventory.UpdateProduct(updateName, amount, increase);
                break;

            case "3":
                inventory.ShowProducts();
                break;

            case "4":
                return;

            default:
                Console.WriteLine("Wrong operation, please, try again!");
        }

        // {
        //     Console.WriteLine();
        //     Console.WriteLine("Write "1" to check available products, "2" to check price of available products, "3" to check quantity of available products");
        //     string? userInput = Console.ReadLine();

            // if (userInput == "1")
            // {
            //     foreach (Product product in products)
            //     {
            //         Console.WriteLine();
            //         Console.Write($"{product.Name};");
            //     }
            // }
            // else if (userInput == "2")
            // {
            //     foreach (Product product in products)
            //     {
            //         Console.WriteLine();
            //         Console.Write($"{product.Name}: {product.Price}$;");
            //     }
            // }
            // else if (userInput == "3")
            // {
            //     foreach (Product product in products)
            //     {
            //         Console.WriteLine();
            //         Console.Write($"{product.Name}: {product.Quantity}pcs;");
            //     }
            // }
            // else Console.WriteLine("Wrong operation.");


    }
 }

