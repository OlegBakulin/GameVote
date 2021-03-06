using GameVote.Domain.DBServices.Interface;
using GameVote.Domain.DTO;
using System.Linq;

namespace GameVote.Services.DTO
{
    public class DTOGameForTitlePageServices
    {
        private readonly IDBServices _iDBServices;
        public DTOGameForTitlePageServices(IDBServices dBServices) => _iDBServices = dBServices;

        public DTOGameForTitlePage Get(int id)
        {

            var games = _iDBServices.GetGamesForTitlePage();//.Where(i => i.Id == id);
            var game = games.FindLast(i => i.Id == id);
            //var userQuantityVote = _iDBServices.GetVoteForTitlePage();
            return new DTOGameForTitlePage
            {
                Id = game.Id,
                Name = game.Name,
                UrlOfficialSaitGame = game.UrlOfficialSaitGame,
                ImgGame = game.ImgGame,
                Price = game.Price,
                DiscountedPrice = game.discountedPrice,
                UserVoteQuantity = games.Count(i => i.ModeGame != null),  // userQuantityVote.Count(i=>i.ModeGame!= null),
                UserVoteFullPrice = games.Count(i => i.ModeGame != null)
            };
        }
    }
}
