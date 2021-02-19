using GameVote.Domain.Entities;
using GameVote.Domain.Entities.Home.Interface;
using System;

namespace GameVote.Domain
{
    public class Vote : User, IGame
    {
        byte UserVote { get; set; }
        public string Nazvanie { get; set; }
        public string Opisanie { get; set; }
        public float PriceRelise { get; set; }
        public float PriceNow { get; set; }
        ulong IGame.Id { get; set; }
    }
}
