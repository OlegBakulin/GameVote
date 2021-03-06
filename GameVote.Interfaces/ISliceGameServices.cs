using System;
using System.Collections.Generic;
using System.Net;
using GameVote.Domain.ViewModels;

namespace GameVote.Interfaces
{
    public interface ISliceGameServices
    {
        IEnumerable<GamesForTitlePage> Get();

        GamesForTitlePage Get(int id);

        int Post(GamesForTitlePage newGame);

        bool Update(int id, GamesForTitlePage newGame);

        bool Delete(int id);
    }
}
