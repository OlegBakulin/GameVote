using System;

namespace GameVote.Domain.Entities
{
    public class Vote
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }
        public Store Store { get; set; }
        public DateTime date { get; set; }
        public decimal Price { get; set; }

    }
}
