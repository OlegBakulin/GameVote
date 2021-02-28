using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public Platform Platform { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public DateTime Release { get; set; }
        public Developer Developer { get; set; }
        public Publisher Publisher { get; set; }
        public string Description { get; set; }
        public int Localization { get; set; }
        public int MinAge { get; set; }
        public int ModeGame  { get; set; }
        public int SeriesGame { get; set; }
        public int Subtitle { get; set; }
        public int TypeGame { get; set; }
        public int UrlOfficialSaitGame { get; set; }
        public int ImgGame { get; set; }        
    }
}
