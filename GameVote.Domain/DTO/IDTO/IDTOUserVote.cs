using GameVote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.DTO.IDTO
{
    public interface IDTOUserVote
    {
        public int Id { get; set; }

        #region Game
        public Game Game { get; set; }

        public int GameId { get; set; }
        #endregion

        public Store Store { get; set; }
        public DateTime date { get; set; }
        public decimal Price { get; set; }
        
        public int UserId { get; set; }     
    }
}
