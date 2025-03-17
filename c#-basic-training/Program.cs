namespace primenumber;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Enter a number: ");
            string? userInput = Console.ReadLine();
            bool isPrime = true;

            if (int.TryParse(userInput, out int result))
            {
                for (int i = 2; i < result; i++)
                {
                    if (result % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true && result != 1)
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
}
