using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models;

public class UserPlayer : Player, IPlayable
{
    public UserPlayer()
    {
        Name = "User";
    }

    public UserPlayer(string name)
    {
        Name = name;
    }

    public Hands GetHand()
    {
        return Hand;
    }

    public string? GetName()
    {
        return Name;
    }

    public int GetScore()
    {
        return Score;
    }

    public void IncreaseScore()
    {
        Score++;
    }

    public void ThrowHand()
    {
        Console.Write($"Throw a hand: ");
        var userInput = Console.ReadLine();

        if (Enum.TryParse(typeof(Hands), userInput, true, out var hand))
        {
            Hand = (Hands)hand;
        }
    }
}
