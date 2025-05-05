public class CsvReader
{
    public List<Movie> ReadCsv(string filePath)
    {
        var movies = new List<Movie>();
        var lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var movie = new Movie
            {
                Title = values[0],
                Director = values[1],
                Year = int.Parse(values[2]),
                Genre = values[3],
                Rating = double.Parse(values[4])
            };
            movies.Add(movie);
        }
        return movies;
    }
}