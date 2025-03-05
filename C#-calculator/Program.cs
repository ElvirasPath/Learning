// Simple Calculator 

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Choose operation (+, -, /, *): ");
            string? operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine($"Result: {firstNumber + secondNumber}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"Result: {firstNumber - secondNumber}");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"Result: {firstNumber / secondNumber}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"Result: {firstNumber * secondNumber}");
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }

            Console.WriteLine();
            Console.Write("Do you want to exit the calculator? (yes/no): ");
            string? exitCalculator = Console.ReadLine();

            if (exitCalculator == "yes")
            {
                break;
            }
        } while (true);
    }
}
