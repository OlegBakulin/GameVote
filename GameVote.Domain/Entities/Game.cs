using GameVote.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public Platform Platform { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public DateTime Release { get; set; }
        public Developer Developer { get; set; }
        public Publisher Publisher { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public bool Localization { get; set; }
        public int MinAge { get; set; }
        public string ModeGame { get; set; }
        public string SeriesGame { get; set; }
        public bool Subtitle { get; set; }
        public string TypeGame { get; set; }
        public string UrlOfficialSaitGame { get; set; }
        public string ImgGame { get; set; }
    }
}
