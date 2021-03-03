using GameVote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.ViewModels
{
    public class GamesForTitlePage : Game
    {
        public Store Store { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public int discountedPrice { get; set; }
    }
}
