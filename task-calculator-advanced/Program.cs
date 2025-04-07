using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Security;

namespace advancedcalculator;
class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        while(true)
        {
            Console.Write("Choose operation (+, -, /, *) or ener 'exit' to exit the Calculator: ");
            Console.WriteLine();
            string? userOper = Console.ReadLine()?.Trim();

            if (userOper?.ToLower() == "exit")
            {
                Console.WriteLine("See you soon!");
                break;
            }

            Console.Write("Enter numbers separated by commas: ");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid input. Name cannot be empty or spaces.");
                return;
            }
            string?[] inputStrings = userInput.Split(",");
            double[] numbers = new double[inputStrings.Length];
            bool validInput = true; 
            Console.WriteLine();

            // List<double> numbers = new List<double>();
            for (int i = 0; i < inputStrings.Length; i++)
            {
                if (double.TryParse(inputStrings[i]?.Trim(), out double number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"Invalid input {inputStrings[i]}, please, try again.");
                    validInput = false;
                    return;
                }
            }

            if (!validInput)
            {
                Console.WriteLine("Please enter a list of numbers.");
                continue;
            }
            switch (userOper)
            {
                case "+":   Console.WriteLine($"Result: {calc.Add(numbers)}"); break;

                case "-":  Console.WriteLine($"Result: {calc.Substract(numbers)}"); break;

                case "/":  Console.WriteLine($"Result: {calc.Divide(numbers)}"); break;
                
                case "*":  Console.WriteLine($"Result: {calc.Multiply(numbers)}"); break;

                default: Console.WriteLine("Invalid operation"); continue;
            }
        } 
    }
}

public class Calculator
{
    public double Add(params double[] numbers)
    {
        double result = 0;
        foreach (double num in numbers)
        {
            result = result + num;
        }
        return result;
    }

    public double Substract(params double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = result - numbers[i];
        }
        return result;
    }

    public double Divide(params double[] numbers)
    {
        double result = 1;
        foreach (var num in numbers)
        {
            result = result / num;
        }
        return result;
    }

    public double Multiply(params double[] numbers)
    {
        if (numbers.Length is 0)
        {
            Console.WriteLine("Error");
            return double.NaN;
        }

        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = result * numbers[0];
        }
        return result;
    }
    
}