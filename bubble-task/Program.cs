using System.Globalization;

namespace bubble_task;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your numbers separated by spaces: ");
        string? myNumbersString = Console.ReadLine();

        if (myNumbersString is null)
        {
            Console.WriteLine("Wrong operation");
            return;
        }

        string[] arrayOfStrings = myNumbersString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[arrayOfStrings.Length];

        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            if (int.TryParse(arrayOfStrings[i], out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Wrong operation");
                return;
            }
        }

        numbers = Sort(numbers);
        Console.WriteLine();
        Console.Write("After: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
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
