namespace RockPaperScissors.Models;

public abstract class Player
{
    public string? Name { get; set; }
    public int Score { get; set; }
    public Hands Hand { get; set; }
}
