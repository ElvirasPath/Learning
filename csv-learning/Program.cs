namespace csv_learning;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"/Users/pro/Projects/Learning/csv-learning/currency.csv"; //Set the file path to CSV file (change path if needed)

        if (File.Exists(filePath))
        {
            //Create a list to store all the Currency objects we read from the CSV
            List<Currency> currencies = new List<Currency>();
            
            //Read all lines from the file, and skip the first one (header)
            var lines = File.ReadAllLines(filePath).Skip(1);
            
            //Loop through each line og the CSV file
            foreach (var line in lines)
            {
                Console.WriteLine($"Line read: {line}"); // DEBUGGING LINE
                
                //Split tbe line by comma (CSV format)
                var parts = line.Split(",");
                
                //Check if we have at least two parts and if the second part is a valid number
                if (parts.Length >= 2 && double.TryParse(parts [1], out double rate))
                {
                    // Create a new Currency object and set its properties 
                    Currency currency = new Currency()
                    {
                        Code = parts[0], //Set the currency code (UAH, USD, etc)
                        Rate = rate // Set the rate (like 4.0)
                    };
                    
                    //Add the new Currency object to the List
                    currencies.Add(currency);
                }
            }
            
            // After reading all currencies, print them to the console
            Console.WriteLine("Currency List:");
            foreach (var currency in currencies)
            {
                //This calls the overridden ToString() method in the Currency class
                Console.WriteLine(currency);
            }
        }
        else
        {
            //Print this message if file doesn't exist
            Console.WriteLine("File does not exist");
        }
    }
}

