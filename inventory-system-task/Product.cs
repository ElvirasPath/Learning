namespace inventory;
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