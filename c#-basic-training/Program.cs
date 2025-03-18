namespace primenumber;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter a number: ");
            string? userInput = Console.ReadLine();
            if (long.TryParse(userInput, out long result))
            {
                bool isPrime = IsPrime(result);
                if (isPrime == true)
                {
                    Console.WriteLine("Prime number");
                }
                else
                {
                    Console.WriteLine("Not a prime number");
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

    static bool IsPrime(long number)
    {
        if (number == 1)
        {
            return false;
        }
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
