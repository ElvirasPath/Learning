namespace cardpicker;

class CardPicker
{
    string[] cards = {
        "10 of Diamonds",
        "6 of Clubs",
        "7 of Spades",
        "Ace of Diamonds",
        "Ace of Hearts"
    };

    public string[] PickSomeCards(int numberOfCards)
    {
        Random rand = new Random();
        string[] pickedCards = new string[numberOfCards];

        for (int i = 0; i < numberOfCards; i++)
        {
            int index = rand.Next(cards.Length);
            pickedCards[i] = cards[index];
        }

        return pickedCards;
    }
}