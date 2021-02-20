using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities.Home.Interface
{
    public interface IGame
    {
        ulong Id { get; set; }
        string Nazvanie { get; set; }
        string Opisanie { get; set; }
        float PriceRelise { get; set; }
        float PriceNow { get; set; }
        string UrlGame { get; set; }
        string ImgGame { get; set; }
        string[]? ScreenGame { get; set; }
    }
}
