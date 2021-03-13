using System.Collections.Generic;
using System.Linq;
using GameVote.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using GameVote.Domain.DBServices.Interface;

namespace GameVote.Controllers
{

    public class BaseController : Controller
    {
        private readonly IDBServices _iDBServices;
        public BaseController(IDBServices dBServices) => _iDBServices = dBServices;
        
        public IActionResult Index()
        {
            var gamesall = _iDBServices.GetGamesForTitlePage(gameId: 0, storeId: 1);
            List<GamesForTitlePage> games = new List<GamesForTitlePage>();
            games.Add(gamesall.Find(i => i.Id == 1));
            foreach (var gama in gamesall)
            {
                if (!games.Exists(x => x.Id == gama.Id) && gama.Store.Id == 1) 
                {                    
                        games.Add(gama);
                }
                 
            }
            games.OrderBy(o => o.Id);
            return View(games);
        }

        public IActionResult GamesById(int id)
        {
            var game = _iDBServices.GetGamesForTitlePage(gameId: id, storeId: 1);
            return View(game);
        }

        public IActionResult GamesByIdSlice(int id)
        {
            return View();
        }
    }
}
