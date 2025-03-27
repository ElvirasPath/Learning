using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string? userInput = Console.ReadLine();
        if (userInput is null)
        {
            Console.WriteLine("Enter sometnig");
            return;
        }

        Console.WriteLine(Greeting());
    }
    static string Greeting()
    {
        int time = DateTime.Now.Hour;
        Dictionary<string, string> greetings = new()
        {
            { "morning", "Good morning!" },
            { "afternoon", "Good afternoon!" },
            { "evening", "Good evening!" },
            {"night", "Good night"}
        };
        if (time >= 4 && time < 12) return greetings["morning"];
        else if (time >= 12 && time < 18) return greetings["afternoon"];
        else if (time >= 18 && time < 24) return greetings["evening"];
        else return greetings["night"];
    }
} 
