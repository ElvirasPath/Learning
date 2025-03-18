namespace training;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your word: ");
        string? userInput = Console.ReadLine();
        string? reversed = string.Empty;

        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversed = reversed + userInput[i];
        }

        Console.WriteLine();
        Console.WriteLine($"Your reversed result: {reversed}");
    }
}
 