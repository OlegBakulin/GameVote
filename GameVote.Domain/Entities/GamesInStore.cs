using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities
{
    public class GamesInStore
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public Store Store { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public int DiscountedPrice { get; set; }
    }
}
