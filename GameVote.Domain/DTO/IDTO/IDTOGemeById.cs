using GameVote.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.DTO.IDTO
{
    public interface IDTOGemeById
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

        #region Platform
        public Platform Platform { get; set; }

        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public string PlatformDescription { get; set; }
        #endregion

        #region Genre
        public Genre Genre { get; set; }

        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
        #endregion

        #region Developer
        public Developer Developer { get; set; }

        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public string DeveloperDescription { get; set; }
        #endregion

        #region Publisher
        public Publisher Publisher { get; set; }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherDescription { get; set; }
        #endregion

        #region Status
        public Status Status { get; set; }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        #endregion
    }
}
