using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models;

public class ComputerPlayer : Player, IPlayable
{
    public ComputerPlayer()
    {
        Name = "Computer";
    }

    public ComputerPlayer(string name)
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
        Console.WriteLine($"{Name} is throwing a hand...");
        var random = new Random();
        var length = Enum.GetNames<Hands>().Length;
        var hand = random.Next(1, length);

        Hand = (Hands)hand;
    }
}
