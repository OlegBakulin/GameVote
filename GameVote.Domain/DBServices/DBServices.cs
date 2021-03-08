using Dapper;
using GameVote.Domain.Entities;
using GameVote.Domain.ViewModels;
using GameVote.Domain.DBServices.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVote.Domain.DBServices
{
    public class DBServices : IDBServices
    {
        private string connectionString = "Server = 127.0.0.1; Port=5432;Database=Vote;User Id = postgres; Password=123;";
        public List<GamesForTitlePage> GetGamesForTitlePage(int gameId = 0, int storeId = 0)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @"
                                    SELECT
                                      public.""gamesInStore"".id,
                                      public.""gamesInStore"".""gameId"",
                                      public.""gamesInStore"".""storeId"",
                                      public.""gamesInStore"".price,
                                      public.""gamesInStore"".discount,
                                      public.""gamesInStore"".""discountedPrice"",
                                      public.game.id,
                                      public.game.""platformId"",
                                      public.game.name,
                                      public.game.""genreId"",
                                      public.game.release,
                                      public.game.""developerId"",
                                      public.game.""publisherId"",
                                      public.game.description,
                                      public.game.""statusId"",
                                      public.game.localization,
                                      public.game.""minAge"",
                                      public.game.""modeGame"",
                                      public.game.""seriesGame"",
                                      public.game.subtitle,
                                      public.game.""typeGame"",
                                      public.game.""urlOfficialSaitGame"",
                                      public.game.""imgGame"",
                                      public.platform.id,
                                      public.platform.name,
                                      public.platform.description,
                                      public.genre.id,
                                      public.genre.name,
                                      public.genre.description,
                                      public.publisher.id,
                                      public.publisher.name,
                                      public.publisher.description,
                                      public.developer.id,
                                      public.developer.name,
                                      public.developer.description,
                                      public.store.id,
                                      public.store.name,
                                      public.store.description
                                    FROM
                                      public.""gamesInStore""
                                      INNER JOIN public.game ON(public.""gamesInStore"".""gameId"" = public.game.id)
                                      INNER JOIN public.platform ON(public.game.""platformId"" = public.platform.id)
                                      INNER JOIN public.genre ON(public.game.""genreId"" = public.genre.id)
                                      INNER JOIN public.publisher ON(public.game.""publisherId"" = public.publisher.id)
                                      INNER JOIN public.developer ON(public.game.""developerId"" = public.developer.id)
                                      INNER JOIN public.store ON(public.""gamesInStore"".""storeId"" = public.store.id)
                                    WHERE
                                      @gameId = 0 OR
                                      (public.""gamesInStore"".""gameId"" = @gameId AND
                                        public.""gamesInStore"".""storeId"" = @storeId);
                                    SELECT 
                                      public.game.id as ""GameId"",
                                      public.store.id as ""StoreId"",
                                      public.vote.price as ""Price"",
                                      Count(public.vote.price) AS ""CountVotes""
                                    FROM
                                      public.vote
                                      INNER JOIN public.game ON (public.vote.""gameId"" = public.game.id)
                                      INNER JOIN public.store ON(public.vote.""storeId"" = public.store.id)
                                    WHERE
                                      @gameId = 0 OR
                                      (public.""game"".""id"" = @gameId AND
                                        public.""store"".""id"" = @storeId)
                                    GROUP BY
                                      public.vote.price,
                                      public.game.id,
                                      public.store.id";

                    connection.Open();

                    List<GamesForTitlePage> gamesForTitlePage;
                    List<DistributionOfVotesByPrice> votes;
                    using (var result = connection.QueryMultiple(query, new
                    { gameid = gameId, storeid = storeId }))
                    {
                        gamesForTitlePage = result.Read<GamesInStore,
                        GamesForTitlePage,
                        Platform,
                        Genre,
                        Publisher,
                        Developer,
                        Store,
                    GamesForTitlePage>(
                        (gameInStore, gameForTitlePage, platform, genre, publisher, developer, store) =>
                        {
                            gameForTitlePage.Platform = platform;
                            gameForTitlePage.Genre = genre;
                            gameForTitlePage.Publisher = publisher;
                            gameForTitlePage.Developer = developer;
                            gameForTitlePage.Store = store;
                            gameForTitlePage.Discount = gameInStore.Discount;
                            gameForTitlePage.Price = gameInStore.Price;
                            gameForTitlePage.DiscountedPrice = gameInStore.DiscountedPrice;

                            return gameForTitlePage;
                        }
                            )
                            .ToList();
                        votes = result.Read<DistributionOfVotesByPrice>().ToList();
                    }
                    gamesForTitlePage.ForEach(x =>
                    {
                        x.DistributionOfVotesByPrice = votes.Where(v => v.GameId == x.Id & v.StoreId == x.Store.Id).ToList();
                    });

                    return gamesForTitlePage;
                }
            }
            catch (Exception ex)
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
                            Id = 1, //3
                            Name = "Dev1",
                            Description = "DevDes1"
                        },
                        Discount = 700,
                        Genre = new Genre
                        {
                            Id = 1, //2
                            Name = "Gen1",
                            Description = "GenDes1"
                        },
                        Name = "Game1",
                        Localization = true, //7 region = Russia
                        MinAge = 12,
                        ModeGame = "3",
                        Platform = new Platform
                        {
                            Id = 1, //2
                            Name = "PS 1",
                            Description = "PS1Des1"
                        },
                        Price = 2000,
                        Publisher = new Publisher
                        {
                            Id = 1, //3
                            Name = "Pub1",
                            Description = "PubDes1"
                        },
                        Release = new DateTime(2001, 01, 21),
                        SeriesGame = "1",
                        TypeGame = "1",
                        Store = new Store
                        {
                            Id = 1, //1
                            Name = "PlayStation1",
                            Description = "PlayDes1"
                        },
                        Subtitle = true,
                        ImgGame = "1",
                        UrlOfficialSaitGame = "1"
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
                        Localization = true, //7 region = Russia
                        MinAge = 16,
                        ModeGame = "1",
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
                        SeriesGame = "2",
                        TypeGame = "2",
                        Store = new Store
                        {
                            Id = 1,
                            Name = "PlayStation1",
                            Description = "PlayDes1"
                        },
                        Subtitle = true,
                        ImgGame = "2",
                        UrlOfficialSaitGame = "2"
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
                        Localization = true, //7 region = Russia
                        MinAge = 10,
                        ModeGame = "2",
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
                        SeriesGame = "3",
                        TypeGame = "3",
                        Store = new Store
                        {
                            Id = 2,
                            Name = "Steam2",
                            Description = "SteDes2"
                        },
                        Subtitle = true,
                        ImgGame = "3",
                        UrlOfficialSaitGame = "3"
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
                        Localization = true, //7 region = Russia
                        MinAge = 18,
                        ModeGame = "1",
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
                        SeriesGame = "1",
                        TypeGame = "2",
                        Store = new Store
                        {
                            Id = 1,
                            Name = "PlayStation1",
                            Description = "PlayDes1"
                        },
                        Subtitle = true,
                        ImgGame = "4",
                        UrlOfficialSaitGame = "4"
                    }
                };
            }
        }
    }
}
