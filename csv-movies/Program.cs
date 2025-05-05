namespace MovieDataset;

using System;

class Program
{
    static void Main(string[] args)
    {
        var controller = new MovieController();
        controller.DisplayMovies();
        
        Console.WriteLine("Enter director's name:");
        var directorName = Console.ReadLine();
        controller.DisplayMoviesByDirector(directorName);
    }
}