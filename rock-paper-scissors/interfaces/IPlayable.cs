using RockPaperScissors.Models;

namespace RockPaperScissors.Interfaces;

public interface IPlayable
{
    void ThrowHand();

    Hands GetHand();

    string? GetName();

    void IncreaseScore();

    int GetScore();
}
