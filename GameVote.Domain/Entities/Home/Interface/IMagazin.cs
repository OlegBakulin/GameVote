using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities.Home.Interface
{
    public interface IMagazin
    {
        string NazvanieMagazina { get; set; }
        string UrlGameMagazin { get; set; }
    }
}
