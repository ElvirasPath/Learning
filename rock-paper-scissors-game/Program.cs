using System.ComponentModel.Design;

namespace rpsgame;

class Program
{

    static void Main(string[] args)
    {
        do
        {
            Random random = new Random();
            int userScore = 0;
            int computerScore = 0;
            Console.WriteLine("Welcome to rock, paper or scissiors game!");

            while (computerScore != 3 && userScore != 3)
            {
                Console.WriteLine($"User score: {userScore}. Computer score: {computerScore}.");
                Console.WriteLine("Choose between rock, paper or scissiors: ");
                string? userInput = Console.ReadLine();

                string[] commands = ["rock", "paper", "scissors"];
                int computersChoice = random.Next(commands.Length);
                Console.WriteLine($"Computer's choice: {commands[computersChoice]}");

                if (commands[computersChoice] == commands[0])
                {
                    switch (userInput)
                    {
                        case "paper":
                            Console.WriteLine("You win!");
                            userScore++;
                            break;
                        case "scissors":
                            Console.WriteLine("You lost!");
                            computerScore++;
                            break;
                        default:
                            Console.WriteLine("It's a tie!");
                            break;
                    }
                }
                else if (commands[computersChoice] == commands[1])
                {
                    switch (userInput)
                    {
                        case "scissors":
                            Console.WriteLine("You win!");
                            userScore++;
                            break;
                        case "rock":
                            Console.WriteLine("You lost!");
                            computerScore++;
                            break;
                        default:
                            Console.WriteLine("It's a tie!");
                            break;
                    }
                }
                else
                {
                    switch (userInput)
                    {
                        case "paper":
                            Console.WriteLine("You win!");
                            userScore++;
                            break;
                        case "rock":
                            Console.WriteLine("You lost!");
                            computerScore++;
                            break;
                        default:
                            Console.WriteLine("It's a tie!");
                            break;
                    }
                }
            }
            if (userScore is 3) Console.WriteLine("Congrats, you won in 3 rounds!");
            else Console.WriteLine("Sorry, the computer won you in 3 rounds!");
            Console.WriteLine();
            Console.Write("Do you want to exit the game? Enter 'yes' to exit: ");

            string? exit = Console.ReadLine();
            if (exit is "yes")
            {
                break;
            }
        } while (true);
    }
}    
