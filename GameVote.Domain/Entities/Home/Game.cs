using GameVote.Domain.Entities.Home.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities
{
    class Game : IGame
    {
        public ulong Id { get; set; }
        public string Nazvanie { get; set; }
        public string Opisanie { get; set; }
        public float PriceRelise { get; set; }
        public float PriceNow { get; set; }
    }
}
