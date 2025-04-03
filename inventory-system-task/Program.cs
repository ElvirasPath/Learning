using System;
using System.Collections.Generic;
namespace inventorysystem;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        Console.WriteLine("Welcome to our inventory!");
        do
        {
            Console.WriteLine("Write /1 to add product, /2 to update product, /3 to show products, /4 to exit.");
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
                    string? name = Console.ReadLine();
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
                    string? updateName = Console.ReadLine();
                    Console.Write("Enter amount: ");
                    if (!int.TryParse(Console.ReadLine(), out int amount))
                    {
                        Console.WriteLine("Error, invalid input");
                        return;
                    }
                    Console.Write("Increase - (+) or decrease (-): ");
                    bool increase = Console.ReadLine() == "+";
                    inventory.UpdateProduct(updateName, amount, increase);
                    break;

                case "3":
                    inventory.ShowProducts();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Wrong operation, please, try again!");
                    break;
            }
            Console.Write("Do you want to exit? Enter 'yes' to exit: ");
            string? exit = Console.ReadLine();
            if (exit is "yes")
            {
                break;
            }
        } while (true);
    }
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

    public void DisplayProduct()
    {
        Console.WriteLine($"{Name} ${Price} pcs{Quantity}");
    }
}


public class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(string? name, decimal price, int quantity)
    {
        products.Add(new Product(name, price, quantity));
    }

    public void UpdateProduct(string? name, int amount, bool increase)
    {
        foreach (var product in products)
        {
            if (product.Name == name)
            {
                if (increase)
                    product.IncreaseQuantity(amount);
                else
                    product.DecreaseQuantity(amount);
               // Console.WriteLine("Invalid product name.");
                return;
            }
        }
    }

    public void ShowProducts()
    {
        if (products.Count is 0)
        {
            Console.WriteLine("This product is sold out.");
            return;
        }

        foreach (var product in products)
        {
            product.DisplayProduct();
        }
    }
}
