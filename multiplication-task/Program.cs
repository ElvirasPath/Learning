class Program
{
    static void Main(string[] args)
    {
        //string? userInput = Console.ReadLine();

        try
        {
            string? userInput = args[0];
            bool hasParsed = int.TryParse(userInput, out int result); 
            if (hasParsed)
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{result} * {i} = {result * i}");
                }
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Sorry, something went wrong: {ex.Message}");
        }
    }
}