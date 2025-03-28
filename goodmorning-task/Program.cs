using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string? userName = Console.ReadLine();
        if (userName is null)
        {
            Console.WriteLine("What is your name?");
            return;
        }

        Console.WriteLine(Greeting(userName));
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
