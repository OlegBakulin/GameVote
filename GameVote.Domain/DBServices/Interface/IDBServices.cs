using GameVote.Domain.Entities;
using GameVote.Domain.ViewModels;
using System.Collections.Generic;

namespace GameVote.Domain.DBServices.Interface
{
    public interface IDBServices
    {
        public List<GamesForTitlePage> GetGamesForTitlePage(int gameId, int storeId);
        public bool InsertVote(Vote vote);
        public bool DeleteVote(Vote vote);
    }
}
