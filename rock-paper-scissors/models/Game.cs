using RockPaperScissors.Extensions;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Models;

public class Game
{
    const string Singular = "game";
    const string Plural = "games";

    public List<IPlayable> Players { get; } =
    [
        new ComputerPlayer("Thanos")
    ];
    private int TotalGames { get; set; } = 1;
    private int CurrentGame { get; set; } = 0;

    public Game()
    {
        StartGame();
    }

    public Game(int totalGames)
    {
        TotalGames = totalGames;
        StartGame(totalGames);
    }

    public void AddPlayer(IPlayable player)
    {
        Console.WriteLine($"Player {player.GetName()} joined the game");
        Players.Add(player);
    }

    public void Start()
    {
        do
        {
            Console.WriteLine();
        
            CurrentGame++;

            foreach (var player in Players)
            {
                player.ThrowHand();
            }

            var winners = DecideWinner();
            if (winners is [var winner])
            {
                Console.WriteLine($"Game #{CurrentGame} winner is: {winner.GetName()}");
            }
            else
            {
                Console.WriteLine($"Game #{CurrentGame} is a tie between: {string.Join(", ", winners.Select(w => w.GetName()))}");
            }

            Console.WriteLine();
        }
        while(CurrentGame < TotalGames);

        var highestScore = Players.Max(p => p.GetScore());
        var overallWinners = Players.Where(p => p.GetScore() == highestScore).ToList();

        if (overallWinners is [var overallWinner])
        {
            Console.WriteLine($"Overall winner is: {overallWinner.GetName()}");
        }
        else
        {
            Console.WriteLine($"It's a tie between: {string.Join(", ", overallWinners.Select(w => w.GetName()))}");
        }
    }

    public void AskUserForName()
    {
        Console.Write("Please provide your name: ");
        var userName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userName))
        {
            AddPlayer(new UserPlayer());
        }
        else
        {
            AddPlayer(new UserPlayer(userName));
        }
    }

    List<IPlayable> DecideWinner()
    {
        var playersWins = new Dictionary<IPlayable, int>();
        foreach (var player in Players)
        {
            Console.WriteLine($"{player.GetName()} threw a {player.GetHand().FormatWithEmojis()}");

            playersWins.Add(player, 0);
        }

        for (int i = 0; i < Players.Count; i++)
        {
            var player = Players[i];
            var playersHand = player.GetHand();
            for (int j = i + 1; j < Players.Count; j++)
            {
                var otherPlayer = Players[j];
                var otherPlayersHand = Players[j].GetHand();

                if (playersHand.WinsOver(otherPlayersHand) is Outcomes.Victory)
                {
                    playersWins[player]++;
                }
                else if (playersHand.WinsOver(otherPlayersHand) is Outcomes.Loss)
                {
                    playersWins[otherPlayer]++;
                }
            }
        }

        var minWins = playersWins.Values.Min();
        if (minWins > 0)
        {
            return [.. playersWins.Select(p => p.Key)];
        }

        var maxWins = playersWins.Values.Max();

        var winners = playersWins
            .Where(p => p.Value == maxWins).Select(p => p.Key).ToList();

        foreach (var winner in winners)
        {
            winner.IncreaseScore();
        }

        return winners;
    }

    void StartGame()
    {
        StartGame(TotalGames);
    }

    void StartGame(int totalGames)
    {
        Console.WriteLine("Welcome to the Rock, Paper, Scissors game");
        Console.WriteLine($"You will be playing {totalGames} {(totalGames > 1 ? Plural : Singular)}");

        var playersNames = string.Join(", ", Players.Select(p => p.GetName()));
        Console.WriteLine($"You will be playing with these players today: {playersNames}");
    }
}
