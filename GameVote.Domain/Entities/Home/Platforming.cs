using GameVote.Domain.Entities.Home.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities.Home
{
    public class Platforming : IPlatforming
    {
        public float PriceRelise { get; set; }
        public float PriceNow  { get; set; }
        public DateTime DataRelise  { get; set; }
        public DateTime DataLostSale  { get; set; }
        public string PlatformGame  { get; set; }
    }
}
