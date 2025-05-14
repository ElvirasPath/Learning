using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using return_practice_c_.Model;

namespace return_practice_c_.Data;

public class CardRepository
{
    private readonly string _connectionString = "Data Source=cards.db";

    public CardRepository()
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var tableCmd = connection.CreateCommand();
        tableCmd.CommandText = @"
    CREATE TABLE IF NOT EXISTS cards (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        value TEXT NOT NULL,
        suit TEXT NOT NULL
    );
";
        tableCmd.ExecuteNonQuery();
    }

    public void SaveCard(Card card)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var insertCmd = connection.CreateCommand();
        insertCmd.CommandText = "INSERT INTO cards (value, suit) VALUES (@value, @suit)";
        insertCmd.Parameters.AddWithValue("$value", card.Value);
        insertCmd.Parameters.AddWithValue("$suit", card.Suit);
        insertCmd.ExecuteNonQuery();
    }

    public List<Card> LoadCards()
        {
            var cards = new List<Card>();
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();
            
            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT id, value, suit, cards FROM cards";
            
            using var reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                cards.Add(new Card
                {
                    Id = reader.GetInt32(0),
                    Value = reader.GetString(1),
                    Suit = reader.GetString(2),
                });
            }
            return cards;
        }
}
    