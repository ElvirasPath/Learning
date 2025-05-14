using System;
using return_practice_c_.Model;
using return_practice_c_.Data;

namespace return_practice_c_;
internal class Program
{
    static void Main(string[] args)
    {
        var repo = new CardRepository();
        Console.Write("How many cards to pick?");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Invalid number.");
            return;
        }
        
        Console.WriteLine("\nPicked cards:");
        for (int i = 0; i < count; i++)
        {
            var card = PickRandomCard();
            Console.WriteLine(card);
            repo.SaveCard(card);
        }

        Console.WriteLine("\nCards saved to the database.\n");

        Console.WriteLine("Previously saved cards:");
        var savedCards = repo.LoadCards();
        foreach (var card in savedCards)
        {
            Console.WriteLine(card);
        }
    }

    static Card PickRandomCard()
    {
        string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        var rand = new Random();
        return new Card
        {
            Value = values[rand.Next(values.Length)],
            Suit = suits[rand.Next(suits.Length)]
        };
    }
}
