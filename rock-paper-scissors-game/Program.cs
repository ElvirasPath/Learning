using System.ComponentModel.Design;

namespace rpsgame;

class Program
{
    
    static void Main(string[] args)
    {
        int userScore = 0;
        int computerScore = 0;
        Console.WriteLine("Welcome to rock, paper or scissiors game!");

        while (userScore != 3 && computerScore != 3)
        {
            Console.WriteLine($"User score: {userScore}. Computer score: {computerScore}.");
            Console.WriteLine("Choose between rock, paper or scissiors: ");
            string? userInput = Console.ReadLine();
        }

        Random random = new Random();

        string[] commands = ["rock", "paper", "scissors"];
        int computersChoice = random.Next(commands.Length);
        Console.WriteLine($"Computer's choice: {commands[computersChoice]}");
    }

    static string Result(string result)
    {

        if (userInput == commands[0] && commands[computersChoice] == commands[1]) return ("You lost!");
        else if (userInput == commands[1] && commands[computersChoice] == commands[0]) return ("You win!");
        else if (userInput == commands[1] && commands[computersChoice] == commands[2]) return ("You lost!");
        else if (userInput == commands[2] && commands[computersChoice] == commands[1]) return ("You win!");
        else if (userInput == commands[0] && commands[computersChoice] == commands[2]) return ("You lost!");
        else if (userInput == commands[2] && commands[computersChoice] == commands[0]) return ("You win!");
        else Console.WriteLine("It's a tie, nobody wins!");
    }
}    