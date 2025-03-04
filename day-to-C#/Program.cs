class Program
{
    static void Main(string[] args)
    {
        // int apples = 4;
        // double oranges = 8.25;

        // int sum = apples + (int)oranges;
        // double sum2 = apples + (int)oranges;
        // Console.WriteLine(sum);
        // Console.WriteLine(sum2);

        // int playerHealth = 100;
        // double fallDmg = 0;
        // double charWeight = 150.7;
        // double fallDistance = 18.5;

        // fallDmg = charWeight * (fallDistanse - 5);
        // int currentHealth = playerHealth - (int)fallDmg;
        // Console.WriteLine(currentHealth);

        //Methods 

        // Console.WriteLine("Guess a number between 1 and 3");

        // int numberGuessed = 0;
        // string userInput = Console.ReadLine();

        // if (int.TryParse(userInput, out numberGuessed) && numberGuessed == 2)
        // {
        //     Console.WriteLine($"Correct, you guessed {numberGuessed}");
        //     break; 
        // }
        // else
        // {
        //     Console.WriteLine("Read the instructions again!");
        // }

        //   

        //string userInput = "SpOnGeBoBmEmE";

        // if (userInput.Contains("mE"))
        // {
        //     Console.WriteLine("I'm included");
        //     else {
        //         Console.WriteLine("what? why not?");
        //     }
        // string cut = userInput.Substring(4, 8);
        // Console.WriteLine(cut);

        string userInput = "SpOnGeBoB mEmE";

        string replaced = userInput.Replace("SpOnGeBob", "Patrick").toLower();

        Console.WriteLine(replaced);

    }

}
