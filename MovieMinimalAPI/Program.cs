using System.Data.Common;
using Microsoft.VisualBasic;
using Npgsql;

namespace MovieMinimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CORS POLICY
            var policyName = "_myAllowSpecificOrigins";
            // BUILDER 
            var builder = WebApplication.CreateBuilder(args);

            // CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: policyName,
                          builder =>
                          {
                              builder
                                .WithOrigins("http://localhost:3000")
                                .AllowAnyHeader();
                          });
            });

            // BUILDER SERVICES 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers();

            var app = builder.Build();

            // HTTP REQUEST PIPELINE
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // APP SET UP
            app.UseHttpsRedirection();
            app.UseCors(policyName);
            app.UseAuthorization();
            app.MapControllers();

            // METHOD CALLS
            app.MapGet("/movies", GetAllMovies.GetMovies);

            app.MapGet("/actors", GetAllActors.GetActors);

            app.MapGet("/movies/{id}", (int id) => GetAllMovies.GetMovieById(id));

            app.MapPut("/movies/{id}", (int id, string title, int releaseDate) => GetAllMovies.UpdateMovie(id, title, releaseDate));

            // app.MapPost("/movies/{id}", (int id, string title, int releaseDate) => GetAllMovies.AddMovie(id, title, releaseDate));

            // app.MapPost("/actors/{id}", () => GetAllActors.AddActor(id, firstname, lastname, age));

            // app.MapDelete("/actors/{id}, DeleteMovie);

            // LAUNCH APP
            app.Run();
        }
    }
}