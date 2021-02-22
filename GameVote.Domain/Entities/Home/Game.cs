using GameVote.Domain.Entities.Home.Interface;
using System;

namespace GameVote.Domain.Entities.Home
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string Nazvanie { get; set; }
        public string Opisanie { get; set; }
        public string UrlOfficialSaitGame { get; set; }
        public string ImgGame { get; set; }
        public bool Localization { get; set; }
        public bool Subtitle { get; set; }
        public string Genre { get; set; }
        public string TypeGame { get; set; }
        public byte MinAge { get; set; }
        public DateTime Releas { get; set; }
        public string Publisher { get; set; }
        public string SeriesGame { get; set; }
        public string ModeGame { get; set; }
    }
}
