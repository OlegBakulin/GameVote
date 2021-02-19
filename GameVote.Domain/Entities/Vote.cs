using GameVote.Domain.Entities.Home;
using GameVote.Domain.Entities.Home.Interface;
using System;

namespace GameVote.Domain.Entities
{
    public class Vote : User, IGame
    {
        public byte UserVote { get; set; }
        ulong IGame.Id { get; set; }
        public string Nazvanie { get; set; }
        public string Opisanie { get; set; }
        public float PriceRelise { get; set; }
        public float PriceNow { get; set; }        
        public string UrlGame { get; set; }
        public string[] ImgGame { get; set; }
    }
}
