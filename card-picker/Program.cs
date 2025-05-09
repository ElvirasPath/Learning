using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace card_picker;


internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number of cards to pick: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int numberOfCards))
        {
            string[] cards = CardPicker.PickSomeCards(numberOfCards);
            Console.WriteLine(numberOfCards);
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }
    }
}

