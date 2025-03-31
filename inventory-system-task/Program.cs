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
    }

    public class Product
    {
        public string? Name { get; set; } // property
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public Product(string? name, decimal price, double quantity) // parameters
        {
            Name = name;
            Price = price;
            Quantity = quantity;

        }
    }

}