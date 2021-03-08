using GameVote.Domain.Entities;
using GameVote.Domain.Entities.Interfaces;

namespace GameVote.Domain.Entities.Interfaces
{
    public interface IGamesForTitlePage
    {
        public Store Store { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public int DiscountedPrice { get; set; }
    }
}
