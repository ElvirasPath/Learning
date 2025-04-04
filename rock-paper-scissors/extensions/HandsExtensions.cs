using RockPaperScissors.Models;

namespace RockPaperScissors.Extensions;

public static class HandsExtensions
{
    public static Outcomes WinsOver(this Hands hand, Hands playersHand)
    {
        if (hand == playersHand)
        {
            return Outcomes.Draw;
        }
        else if (hand is Hands.Rock && playersHand is Hands.Paper)
        {
            return Outcomes.Loss;
        }
        else if (hand is Hands.Paper && playersHand is Hands.Scissors)
        {
            return Outcomes.Loss;
        }
        else if (hand is Hands.Scissors && playersHand is Hands.Rock)
        {
            return Outcomes.Loss;
        }
        else
        {
            return Outcomes.Victory;
        }
    }

    public static string FormatWithEmojis(this Hands hand) => hand switch {
        Hands.Rock => "🪨",
        Hands.Paper => "📃",
        Hands.Scissors => "✂️",
        _ => "🤔"
    };
}
