namespace training;
class Program
{
    static void Main(string[] args)
    {
        do
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

            Console.WriteLine();
            Console.Write("Write 'end' if you want to end your session: ");
            string? exit = Console.ReadLine();
            if (exit == "end")
            {
                break;
            }
        } while (true);
    }
}
 