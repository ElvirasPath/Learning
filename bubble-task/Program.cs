using System.Globalization;

namespace bubble_task;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your numbers: ");
        string? myNumbersString = Console.ReadLine();

        if (myNumbersString is null)
        {
            Console.WriteLine("Wrong operation");
            return;
        }

        string[] arrayOfStrings = myNumbersString.Split(' ');

        Console.WriteLine("Before: ");
        foreach (int i in myNumbers)
        {
            Console.Write($"{i} ");
        }

        myNumbers = Sort(myNumbers);
        Console.WriteLine();
        Console.WriteLine("After: ");
        foreach (int i in myNumbers)
        {
            Console.Write($"{i} ");
        }
    }

    static int[] Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] < numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        return numbers;
    }
}