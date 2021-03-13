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

            var games = _iDBServices.GetGamesForTitlePage(gameId: id, storeId: 1);
            var game = games.FindLast(i => i.Id == id);
            return new DTOGameForTitlePage
            {
                Id = game.Id,
                Name = game.Name,
                UrlOfficialSaitGame = game.UrlOfficialSaitGame,
                ImgGame = game.ImgGame,
                Price = game.Price,
                DiscountedPrice = game.DiscountedPrice,
                UserVoteQuantity = games.Count(i => i.ModeGame != null),
                UserVoteFullPrice = games.Count(i => i.ModeGame != null)
            };
        }
    }
}
