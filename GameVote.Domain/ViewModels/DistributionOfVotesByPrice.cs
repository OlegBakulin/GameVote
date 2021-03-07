using GameVote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.ViewModels
{
    public class DistributionOfVotesByPrice
    {
        public int GameId { get; set; }
        public int StoreId { get; set; }
        public decimal Price { get; set; }
        public int CountVotes { get; set; }
    }
}
