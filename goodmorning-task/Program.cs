using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string? userName = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("Please, enter your name.");
            return;
        }
        Console.WriteLine("How many times should I greet you?");
        if (int.TryParse(Console.ReadLine(), out int times) && times > 0)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(Greeting(userName));

            }
        }
        else
        {
            Console.WriteLine("You entered invalid number, we'll great you just ones");
            Console.WriteLine(Greeting(userName));

        }
    }
    static string Greeting(string userName)
    {
        int time = DateTime.Now.Hour;
        Dictionary<string, string> greetings = new()
        {
            { "morning", $"Good morning, {userName}!"},
            { "afternoon", $"Good afternoon, {userName}!"},
            { "evening", $"Good evening, {userName}!"},
            {"night", $"Good night, {userName}!"}
        };
        if (time >= 4 && time < 12) return greetings["morning"];
        else if (time >= 12 && time < 18) return greetings["afternoon"];
        else if (time >= 18 && time < 24) return greetings["evening"];
        else return greetings["night"];
    }
} 
