using GameVote.Domain.Entities.Home.Interface;

namespace GameVote.Domain.Entities.Home
{
    class Magazin : IMagazin
    {
        public string NazvanieMagazina { get; set; }
        public string UrlGameMagazin { get; set; }
    }
}
