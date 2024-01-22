using Npgsql;

namespace MovieMinimalAPI;

public class GetAllActors
{
    public static Actor[] GetActors()
    {
        List<Actor> actors = new();

        var connectionPgSqlString = "Host=localhost;Port=5432;Username=postgres;Password=Plasma2020@;Database=Streaming;Pooling=true;";

        using var dataSource = NpgsqlDataSource.Create(connectionPgSqlString);
        using var getActorsData = dataSource.CreateCommand("SELECT * FROM smg_actor");
        using var readerActors = getActorsData.ExecuteReader();
        {
            while (readerActors.Read())
            {
                Actor actorToAdd = new()
                {
                    Id = (int)readerActors["sac_actorid"],
                    FirstName = readerActors["sac_firstname"].ToString(),
                    LastName = readerActors["sac_lastname"].ToString(),
                    Age = (DateTime)readerActors["sac_birthdate"],
                };
                actors.Add(actorToAdd);
            }
        }
        return actors.ToArray();
    }

    public static Actor GetActorById(int id)
    {
        Actor actorToReturn = null;

        var connectionPgSqlString = "Host=localhost;Port=5432;Username=postgres;Password=Plasma2020@;Database=Streaming;Pooling=true;";

        using var dataSource = NpgsqlDataSource.Create(connectionPgSqlString);
        using var getActorById = dataSource.CreateCommand("SELECT * FROM smg_actor WHERE sac_actorid = :id");
        getActorById.Parameters.AddWithValue("id", id);
        using var readerActor = getActorById.ExecuteReader();
        {
            while (readerActor.Read())
            {
                actorToReturn = new Actor
                {
                    Id = (int)readerActor["sac_actorid"],
                    FirstName = readerActor["sac_firstname"].ToString(),
                    LastName = readerActor["sac_lastname"].ToString(),
                    Age = (DateTime)readerActor["sac_birthdate"],
                };
            }
        }
        return actorToReturn;
    }
}
