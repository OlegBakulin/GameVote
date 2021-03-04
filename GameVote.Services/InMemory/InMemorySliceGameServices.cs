using GameVote.Domain.ViewModels;
using GameVote.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using GameVote.Domain;
using GameVote.Domain.Entities.Interfaces;
using GameVote.Domain.Entities;
using GameVote.Domain.DBServices.Interface;

namespace GameVote.Services.InMemory
{
    public class InMemorySliceGameServices : IGamesForTitlePage, ISliceGameServices
    {
        public List<GamesForTitlePage> gamesForTitlePages;
        private readonly List<GamesForTitlePage> _gamesForTitlePages;

        public Store Store { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int discountedPrice { get; set; }

        public InMemorySliceGameServices(IDBServices dBServices)
        {
            _gamesForTitlePages = dBServices.GetGamesForTitlePage();
        }

        public IEnumerable<GamesForTitlePage> Get()
        {
            return _gamesForTitlePages;
        }

        public GamesForTitlePage Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Post(GamesForTitlePage newGame)
        {
            throw new NotImplementedException();
        }

        public HttpStatusCode Update(int id, GamesForTitlePage newGame)
        {
            throw new NotImplementedException();
        }

        public HttpStatusCode Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
