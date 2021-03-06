using System;
using System.Collections.Generic;
using System.Text;
using GameVote.Domain.DTO.IDTO;
using GameVote.Domain.Entities;

namespace GameVote.Domain.DTO
{
    class DTOUserVote : IDTOUserVote
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
        public Store Store { get; set; }
        public DateTime date { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
