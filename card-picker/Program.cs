namespace cardpicker;

class Program
{
    static void Main(string[] args)
    {
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int numberOfCards))
        {
            Console.WriteLine(numberOfCards);
            return;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
