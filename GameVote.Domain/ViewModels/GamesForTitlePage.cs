using GameVote.Domain.Entities;
using GameVote.Domain.Entities.Interfaces;
using System.Collections.Generic;
using System.Net;

namespace GameVote.Domain.ViewModels
{
    public class GamesForTitlePage : Game, IGamesForTitlePage
    {
        public Store Store { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public int discountedPrice { get; set; }

        public HttpStatusCode Delete(int id) 
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GamesForTitlePage> Get()
        {
            throw new System.NotImplementedException();
        }

        public GamesForTitlePage Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Post(GamesForTitlePage newGame)
        {
            throw new System.NotImplementedException();
        }

        public HttpStatusCode Update(int id, GamesForTitlePage newGame)
        {
            throw new System.NotImplementedException();
        }
    }
}
