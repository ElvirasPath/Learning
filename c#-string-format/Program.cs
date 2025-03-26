namespace stringformatting;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your message: ");
        string? userInput = Console.ReadLine();
        if (userInput is null)
        {
            Console.WriteLine("Enter something");
            return;
        }
        string greeting = Greeting();
        string? result = TryParseToDifferentTypes(userInput);
        Console.WriteLine($"{greeting} Your input {result}");
    }

    static string Greeting()
    {
        int time = DateTime.Now.Hour;
        if (time <= 12)
            return "Good morning!";
        else if (time <= 18)
            return "God afternoon!";
        else return "Good evening/night!";
    }

    static string TryParseToDifferentTypes(string userInput)
    {
        if (int.TryParse(userInput, out int number))
        {
            return $" is a number {number}";
        }
        if  (double.TryParse(userInput, out double num))
        {
            return $" is a number {num}";
        }

        string[] formats = { "dd-MM-yyyy", "MM/dd/yyyy", "yyyy/MM/dd", "dd MMM yyyy" };
        if (DateTime.TryParseExact(userInput, formats, null, System.Globalization.DateTimeStyles.None, out DateTime date))
        {
            return $"is a date {date}";
        }
        else return $"is {userInput}";
    }
}
