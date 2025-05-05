public class MovieController
{
    private CsvReader csvReader;

    public MovieController()
    {
        csvReader = new CsvReader();
    }

    public void DisplayMovies()
    {
        var movies = csvReader.ReadCsv("movies.csv");
        var highRatedMovies = movies.Where(m => m.Rating > 8).ToList();
        
        Console.WriteLine("High rated movies (Rating > 8):\n");
        foreach (var movie in highRatedMovies)
        {
            Console.WriteLine($"{movie.Title} ({movie.Year}) - {movie.Rating}");
        }
    }

    public void DisplayMoviesByDirector(string directorName)
    {
        if (string.IsNullOrEmpty(directorName))
        {
            Console.WriteLine("No director selected");
            return;
        }
        
        var movies = csvReader.ReadCsv("movies.csv");
        var directorMovies = movies
            .Where(m => m.Director != null && m.Director.Equals(directorName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        
        Console.WriteLine($"Movies by {directorName}:");
        foreach (var movie in directorMovies)
        {
            Console.WriteLine($"{movie.Title} ({movie.Year}) - {movie.Rating}");
        }
    }
}