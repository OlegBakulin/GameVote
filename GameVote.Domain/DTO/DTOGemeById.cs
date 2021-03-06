using System;
using System.Collections.Generic;
using System.Text;
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
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public string PlatformDescription { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
        public Developer Developer { get; set; }
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public string DeveloperDescription { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherDescription { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
    }
}
