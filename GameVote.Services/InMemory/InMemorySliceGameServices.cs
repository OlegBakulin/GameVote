using GameVote.Domain.ViewModels;
using GameVote.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using GameVote.Domain;
using GameVote.Domain.Entities.Interfaces;
using GameVote.Domain.Entities;
using GameVote.Domain.DBServices.Interface;
using System.Linq;

namespace GameVote.Services.InMemory
{
    public class InMemorySliceGameServices : ISliceGameServices
    {
        private readonly List<GamesForTitlePage> _gamesForTitlePages;
        public List<GamesForTitlePage> gamesForTitlePages;
        

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
            return _gamesForTitlePages.FirstOrDefault(e => e.Id.Equals(id));
        }

        public int Post(GamesForTitlePage newGame)
        {
            if (newGame is null)
                throw new ArgumentNullException(nameof(newGame));

            if (_gamesForTitlePages.Contains(newGame)) return newGame.Id;

            newGame.Id = _gamesForTitlePages.Max(e => e.Id) + 1;
            _gamesForTitlePages.Add(newGame);
            return newGame.Id;
        }

        public bool Update(int id, GamesForTitlePage newGame)
        {
            try
            {
                var geme = Get(id);
                geme = newGame;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var geme = Get(id);
                if (geme is null) return false;
                _gamesForTitlePages.Remove(geme);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
