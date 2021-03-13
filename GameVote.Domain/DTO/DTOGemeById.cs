using System;
using GameVote.Domain.DTO.IDTO;
using GameVote.Domain.Entities;

namespace GameVote.Domain.DTO
{
    public class DTOGemeById : IDTOGemeById
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public string Description { get; set; }
        public bool Localization { get; set; }
        public int MinAge { get; set; }
        public string ModeGame { get; set; }
        public string SeriesGame { get; set; }
        public bool Subtitle { get; set; }
        public string TypeGame { get; set; }
        public string UrlOfficialSaitGame { get; set; }
        public string ImgGame { get; set; }
        
        public Platform Platform { get; set; }
       
        public Genre Genre { get; set; }
        
        public Developer Developer { get; set; }
        
        public Publisher Publisher { get; set; }
        
        public Status Status { get; set; }
    }
}
