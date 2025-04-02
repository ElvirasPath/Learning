using System;
using System.Collections.Generic;
namespace inventory;

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
                return;
            }
        }
        Console.WriteLine("Invalid product name.");
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
