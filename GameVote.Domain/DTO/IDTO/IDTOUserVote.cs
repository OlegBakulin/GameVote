using GameVote.Domain.Entities;
using System;

namespace GameVote.Domain.DTO.IDTO
{
    public interface IDTOUserVote
    {
        public int Id { get; set; }

        public Game Game { get; set; }

        public Store Store { get; set; }
        public DateTime date { get; set; }
        public decimal Price { get; set; }
        
        public int UserId { get; set; }     
    }
}
