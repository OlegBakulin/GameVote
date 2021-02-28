using Dapper;
using GameVote.Domain.Entities;
using GameVote.Domain.ViewModels;
using GameVote.Services.DBServices.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVote.Services.DBServices
{
    public class DBServices : IDBServices
    {
        private string connectionString = "Server = 127.0.0.1; Port=5555;Database=Vote;User Id = postgres; Password=123;";
        public List<GamesForTitlePage> GetGamesForTitlePage()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = @"SELECT game.id, platform.""name"", game.name, release,  game.description, localization, 
                    ""minAge"", ""modeGame"", ""seriesGame"", subtitle, ""typeGame"", ""urlOfficialSaitGame"", ""imgGame"",
                    platform.id, platform.""name"", platform.description,
                    genre.id, genre.""name"", genre.description,
                    developer.id, developer.""name"", developer.description,
                    publisher.id, publisher.""name"", publisher.description
                    FROM public.game as game
                    LEFT join platform on game.""platformId"" = platform.id
                    LEFT join genre on game.""genreId"" = genre.id
                    LEFT join developer on game.""developerId"" = developer.id
                    LEFT join publisher on game.""publisherId"" = publisher.id;";

                connection.Open();

                var result = connection.Query
                    <GamesForTitlePage,
                    Platform,
                    Genre,
                    Developer,
                    Publisher,
                    GamesForTitlePage>(query,
                    (game, platform, genre, developer, publisher) =>
                    {
                        game.Platform = platform;
                        game.Genre = genre;
                        game.Developer = developer;
                        game.Publisher = publisher;
                        return game;
                    }
                    )
                    .ToList();

                return result;
            }
        }
    }
}
