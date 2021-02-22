using System;
using System.Collections.Generic;
using System.Text;
using GameVote.Domain.Entities;
using GameVote.Domain.Entities.Home;
using GameVote.Domain.Entities.Home.Interface;

namespace GameVote.Domain.Entities.Home.Interface
{
    interface IVote
    {
        byte Vote { get; set; }
    }
}
