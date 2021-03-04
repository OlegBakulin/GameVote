﻿using GameVote.Domain.Entities;
using GameVote.Domain.Entities.Interfaces;

namespace GameVote.Domain.ViewModels
{
    public class GamesForTitlePage : Game, IGamesForTitlePage
    {
        public Store Store { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public int discountedPrice { get; set; }
    }
}
