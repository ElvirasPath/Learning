namespace training;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter a word: ");
            string? userInput = Console.ReadLine();
            string reversed = Reverse(userInput);
            Console.WriteLine();
            Console.WriteLine($"Reversed result: {reversed}");

            Console.WriteLine();
            Console.Write("Write 'end' if you want to end your session: ");
            
            string? exit = Console.ReadLine();
            if (exit == "end")
            {
                break;
            }
        } while (true);
    }

    static string Reverse(string? userInput)
    {
        if (userInput is null)
        {
            return string.Empty;
        }

        string? reversed = string.Empty;
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversed += userInput[i];
        }

        return reversed;
    }
}
