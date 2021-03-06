﻿using GameVote.Domain.Entities;
using GameVote.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVote.Domain.DBServices.Interface
{
    public interface IDBServices
    {
        public List<GamesForTitlePage> GetGamesForTitlePage();

    }
}
