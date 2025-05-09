namespace card_picker;

public class CardPicker
{ 
    // string[]? cards = [
    //     "10 of Diamonds",
    //     "6 of Clubs",
    //     "7 of Spades",
    //     "Ace of Diamonds",
    //     "Ace of Hearts"
    // ];

    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];

        for (int i = 0; i < numberOfCards; i++)
        {
            // int index = random.Next(cards!.Length);
            pickedCards[i] = $"{RandomValue()} of {RansomSuit()};";
        }

        return pickedCards;
    }

    private static string RansomSuit()
    {
        // Random random = new Random();
        int value = Random.Shared.Next(1, 5); // pick a random number from 1 to 4
        if (value == 1) return "Spades"; 
        if (value == 2) return "Hearts";
        if (value == 3) return "Clubs";
        return "Diamonds"; // otherwise return the string Diamonds
    }

    private static string RandomValue()
    {
        int value = Random.Shared.Next(1, 14);
        if (value == 1) return "Ace"; 
        if (value == 11) return "Jack";
        if (value == 12) return "Queen";
        if (value == 13) return "King";
        return value.ToString();
    }
}

