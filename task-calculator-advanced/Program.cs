﻿using System.Diagnostics.CodeAnalysis;
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
            string? userOper = Console.ReadLine();

            if (userOper?.ToLower() == "exit")
            {
                Console.WriteLine("See you soon!");
                break;
            }

            Console.Write("Enter numbers separated by a comma: ");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid input. Name cannot be empty or spaces.");
                return;
            }
            string?[] inputNums = userInput.Split(",");
            Console.WriteLine();

            List<double> numbers = new List<double>();
            foreach (var num in inputNums)
            {
                if (double.TryParse(num?.Trim(), out double number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input, please, try again.");
                    return;
                }
            }
            double result = 0;
            switch (userOper)
            {
                case "+": result = calc.Add(numbers); break;

                case "-":
                    Console.WriteLine($"");
                    break;
                case "/":
                    Console.WriteLine($"");
                    break;
                case "*":
                    Console.WriteLine($"");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    continue;
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
        double result = 1;
        foreach (var num in numbers)
        {
            result = result * num;
        }
        return result;
    }
    
}