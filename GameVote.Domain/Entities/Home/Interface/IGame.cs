using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities.Home.Interface
{
    public interface IGame
    {
        int Id { get; set; }
        string Nazvanie { get; set; }
        string Opisanie { get; set; }
        string UrlOfficialSaitGame { get; set; }
        string ImgGame { get; set; }
        bool Localization { get; set; }
        bool Subtitle { get; set; }
        string Genre { get; set; }
        string TypeGame { get; set; }
        byte MinAge { get; set; }
        DateTime Releas { get; set; }
        string Publisher { get; set; }
        string SeriesGame { get; set; }
        string ModeGame { get; set; }
    }
}
