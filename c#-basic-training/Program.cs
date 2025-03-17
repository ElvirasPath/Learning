namespace primenumber;

class Program
{
    static void Main(string[] args)
    {

        do
        {
            Console.WriteLine("Enter a number: ");
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int result))
            {
                for (int i = 2; i <= result; i++)
                {
                    
                    int remainder = result % 2;
                    if (remainder == 0)
                    {
                        break;
                    }
                    if (remainder != 0)
                    {
                        Console.WriteLine("Prime number");
                    }
                    else
                    {
                        Console.WriteLine("Not a prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("❌ Enter a number, please.");
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