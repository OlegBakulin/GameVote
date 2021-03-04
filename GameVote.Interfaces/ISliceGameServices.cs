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

        HttpStatusCode Update(int id, GamesForTitlePage newGame);

        HttpStatusCode Delete(int id);
    }
}
