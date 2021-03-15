using Microsoft.AspNetCore.Mvc;
using GameVote.Interfaces;
using System.Collections.Generic;
using GameVote.Domain.ViewModels;
using System.Net.Http;
using GameVote.Services.InMemory;

namespace GameVote.Controllers
{
    [Route("Game")]
    [ApiController]
    public class GameVoteApiController : ControllerBase, ISliceGameServices
    {
        private readonly ISliceGameServices _sliceGameServices;
        public GameVoteApiController(ISliceGameServices gamesForTitlePage) => _sliceGameServices = gamesForTitlePage;
        
        [HttpGet]
        public IEnumerable<GamesForTitlePage> Get()
        {
            var sliceGames = _sliceGameServices.Get();
            return sliceGames;
        }

        [HttpGet("{id}")]
        public GamesForTitlePage Get(int id)
        {
            var sliceGames = _sliceGameServices.Get(id);
            return sliceGames;
        }

        [HttpPost]
        public int Post(GamesForTitlePage newGame)
        {
            HttpResponseMessage message = new HttpResponseMessage();
            _sliceGameServices.Post(newGame);
            RedirectToAction("Game/All");
            return (int)message.StatusCode;
        }
        
        [HttpPut]
        public bool Update(int id, GamesForTitlePage newGame)
        {
            return true;
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return true;
        }
    }
}
