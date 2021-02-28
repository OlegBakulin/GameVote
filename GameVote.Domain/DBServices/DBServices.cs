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
            try
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
            catch
            {
                return new List<GamesForTitlePage>
                {
                    new GamesForTitlePage
                    {
                        Id = 1,
                        Description = "GameDes1",
                        discountedPrice = 500,
                        Developer = new Developer
                        {
                            Id = 1,
                            Name = "Dev1",
                            Description = "DevDes1"
                        },
                        Discount = 700,
                        Genre = new Genre
                        {
                            Id = 1,
                            Name = "Gen1",
                            Description = "GenDes1"
                        },
                        Name = "Game1",
                        Localization = 7, //7 region = Russia
                        MinAge = 12,
                        ModeGame = 3,
                        Platform = new Platform
                        {
                            Id = 1,
                            Name = "PS 1",
                            Description = "PS1Des1"
                        },
                        Price = 2000,
                        Publisher = new Publisher
                        {
                            Id = 1,
                            Name = "Pub1",
                            Description = "PubDes1"
                        },
                        Release = new DateTime(2001, 01, 21),
                        SeriesGame = 1,
                        TypeGame = 1,
                        Store = new Store
                        {
                            Id = 1,
                            Name = "PlayStation1",
                            Description = "PlayDes1"
                        },
                        Subtitle = 7,
                        ImgGame = 1,
                        UrlOfficialSaitGame = 1
                    },

                    new GamesForTitlePage
                    {
                        Id = 2,
                        Description = "GameDes2",
                        discountedPrice = 700,
                        Developer = new Developer
                        {
                            Id = 2,
                            Name = "Dev2",
                            Description = "DevDes2"
                        },
                        Discount = 200,
                        Genre = new Genre
                        {
                            Id = 2,
                            Name = "Gen2",
                            Description = "GenDes2"
                        },
                        Name = "Game2",
                        Localization = 7, //7 region = Russia
                        MinAge = 16,
                        ModeGame = 1,
                        Platform = new Platform
                        {
                            Id = 2,
                            Name = "PS 2",
                            Description = "PS2Des2"
                        },
                        Price = 5000,
                        Publisher = new Publisher
                        {
                            Id = 2,
                            Name = "Pub2",
                            Description = "PubDes2"
                        },
                        Release = new DateTime(2005, 03, 12),
                        SeriesGame = 2,
                        TypeGame = 2,
                        Store = new Store
                        {
                            Id = 1,
                            Name = "PlayStation1",
                            Description = "PlayDes1"
                        },
                        Subtitle = 7,
                        ImgGame = 2,
                        UrlOfficialSaitGame = 2
                    },

                    new GamesForTitlePage
                    {
                        Id = 3,
                        Description = "GameDes3",
                        discountedPrice = 1500,
                        Developer = new Developer
                        {
                            Id = 3,
                            Name = "Dev3",
                            Description = "DevDes3"
                        },
                        Discount = 100,
                        Genre = new Genre
                        {
                            Id = 1,
                            Name = "Gen1",
                            Description = "GenDes1"
                        },
                        Name = "Game3",
                        Localization = 7, //7 region = Russia
                        MinAge = 10,
                        ModeGame = 2,
                        Platform = new Platform
                        {
                            Id = 3,
                            Name = "PS 3",
                            Description = "PS3Des3"
                        },
                        Price = 7000,
                        Publisher = new Publisher
                        {
                            Id = 3,
                            Name = "Pub3",
                            Description = "PubDes3"
                        },
                        Release = new DateTime(2011, 12, 10),
                        SeriesGame = 3,
                        TypeGame = 3,
                        Store = new Store
                        {
                            Id = 2,
                            Name = "Steam2",
                            Description = "SteDes2"
                        },
                        Subtitle = 7,
                        ImgGame = 3,
                        UrlOfficialSaitGame = 3
                    },

                    new GamesForTitlePage
                    {
                        Id = 4,
                        Description = "GameDes4",
                        discountedPrice = 400,
                        Developer = new Developer
                        {
                            Id = 1,
                            Name = "Dev1",
                            Description = "DevDes1"
                        },
                        Discount = 50,
                        Genre = new Genre
                        {
                            Id = 3,
                            Name = "Gen3",
                            Description = "GenDes3"
                        },
                        Name = "Game4",
                        Localization = 7, //7 region = Russia
                        MinAge = 18,
                        ModeGame = 1,
                        Platform = new Platform
                        {
                            Id = 2,
                            Name = "PS 2",
                            Description = "PS2Des2"
                        },
                        Price = 2000,
                        Publisher = new Publisher
                        {
                            Id = 2,
                            Name = "Pub2",
                            Description = "PubDes2"
                        },
                        Release = new DateTime(2020, 12, 10),
                        SeriesGame = 1,
                        TypeGame = 2,
                        Store = new Store
                        {
                            Id = 1,
                            Name = "PlayStation1",
                            Description = "PlayDes1"
                        },
                        Subtitle = 7,
                        ImgGame = 4,
                        UrlOfficialSaitGame = 4
                    }
                };
            }
        }
    }
}
