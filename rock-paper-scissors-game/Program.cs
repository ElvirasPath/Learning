using System.ComponentModel.Design;

namespace rpsgame;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Choose between rock, paper or scissiors: ");
        string? userInput = Console.ReadLine();

        string[] commands = ["rock", "paper", "scissors"];
        int computersChoice = random.Next(commands.Length);
        Console.WriteLine($"Computer's choice: {commands[computersChoice]}");


        if (userInput == commands[0] && commands[computersChoice] == commands[1]) Console.WriteLine("You lost!");
        else if (userInput == commands[1] && commands[computersChoice] == commands[0]) Console.WriteLine("You win!");
        else if (userInput == commands[1] && commands[computersChoice] == commands[2]) Console.WriteLine("You lost!");
        else if (userInput == commands[2] && commands[computersChoice] == commands[1]) Console.WriteLine("You win!");
        else if (userInput == commands[0] && commands[computersChoice] == commands[2]) Console.WriteLine("You lost!");
        else if (userInput == commands[2] && commands[computersChoice] == commands[0]) Console.WriteLine("You win!");
        else Console.WriteLine("It's a draw, nobody wins!");
    }
}    