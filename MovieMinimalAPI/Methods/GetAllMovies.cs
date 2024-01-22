using Npgsql;

namespace MovieMinimalAPI;

public class GetAllMovies
{
    public static Movie[] GetMovies()
    {
        List<Movie> movies = new();

        var connectionPgSqlString = "Host=localhost;Port=5432;Username=postgres;Password=Plasma2020@;Database=Streaming;Pooling=true;";

        using var dataSource = NpgsqlDataSource.Create(connectionPgSqlString);
        using var getMovies = dataSource.CreateCommand("SELECT * FROM smg_movie");
        using var readerMovies = getMovies.ExecuteReader();
        {
            while (readerMovies.Read())
            {
                Movie movieToAdd = new()
                {
                    Id = (int)readerMovies["smo_movieid"],
                    Title = readerMovies["smo_title"].ToString(),
                    ReleaseYear = (int)readerMovies["smo_releaseyear"],
                    CreateDate = (DateTime)readerMovies["smo_datecrea"],
                };
                movies.Add(movieToAdd);
            }
        }
        return movies.ToArray();
    }

    public static Movie GetMovieById(int id)
    {
        Movie movieToReturn = null;

        var connectionPgSqlString = "Host=localhost;Port=5432;Username=postgres;Password=Plasma2020@;Database=Streaming;Pooling=true;";

        using var dataSource = NpgsqlDataSource.Create(connectionPgSqlString);
        using var getMovieById = dataSource.CreateCommand("SELECT * FROM smg_movie WHERE smo_movieid = :id");
        getMovieById.Parameters.AddWithValue("id", id);
        using var readerMovie = getMovieById.ExecuteReader();
        {
            while (readerMovie.Read())
            {
                movieToReturn = new Movie
                {
                    Id = (int)readerMovie["smo_movieid"],
                    Title = readerMovie["smo_title"].ToString(),
                    ReleaseYear = (int)readerMovie["smo_releaseyear"],
                    CreateDate = (DateTime)readerMovie["smo_datecrea"],
                };
            }
        }
        return movieToReturn;
    }

    public static Movie UpdateMovie(int id, string title, int releaseDate)
    {
        Movie movie = GetMovieById(id);

        if (movie != null)
        {
            movie.Title = title;
            movie.ReleaseYear = releaseDate;
        }
        return movie;
    }
}
