using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameVote.Domain.DBServices.Interface;
using GameVote.Domain.DTO.IDTO;
using GameVote.Domain.Entities;

namespace GameVote.Domain.DTO
{
    public class DTOGameForTitlePage : IDTOGameForTitlePage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlOfficialSaitGame { get; set; }
        public string ImgGame { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int UserVoteQuantity { get; set; }
        public decimal UserVoteFullPrice { get; set; }
    }
}
