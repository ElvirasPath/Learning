class Program
{
    static void Main(string[] args)
    {
        string? evenDigits = "02468";
        do
        {
            Console.WriteLine("Enter a number: ");
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out _))
            {
                char lastCharacter = userInput[userInput.Length - 1];
                if (evenDigits.Contains(lastCharacter))
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
            }
            else
            {
                Console.WriteLine("❌ Enter a valid number, please.");
                continue;
            }

            Console.WriteLine();
            Console.Write("Do you want to exit?(yes / no): ");
            string? exit = Console.ReadLine();

            if (exit == "yes")
            {
                break;
            }
        } while (true);
    }
}
