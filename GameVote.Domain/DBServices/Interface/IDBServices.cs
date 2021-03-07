using GameVote.Domain.Entities;
using GameVote.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVote.Services.DBServices.Interface
{
    public interface IDBServices
    {
        public List<GamesForTitlePage> GetGamesForTitlePage(int gameId = 0, int storeId = 0);

    }
}
