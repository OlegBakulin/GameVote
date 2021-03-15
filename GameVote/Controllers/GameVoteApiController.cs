using Microsoft.AspNetCore.Mvc;
using GameVote.Interfaces;
//using System.Web.Http;
using System.Collections.Generic;
using GameVote.Domain.ViewModels;
using System.Net.Http;
using GameVote.Domain.Entities.Interfaces;
using System.Net;
using GameVote.Services.InMemory;
using System.Collections;

namespace GameVote.Controllers
{
    //[Route("Game")]
    [ApiController]
    public class GameVoteApiController : ControllerBase, ISliceGameServices
    {
        private readonly ISliceGameServices _sliceGameServices;
        public GameVoteApiController(ISliceGameServices gamesForTitlePage) => _sliceGameServices = gamesForTitlePage;
        
        
        private readonly List<GamesForTitlePage> _gamesForTitlePage;
        private readonly InMemorySliceGameServices memorySliceGameServices;
        
        //[Route("All")]
        [HttpGet]
        public IEnumerable<GamesForTitlePage> Get()//IActionResult Index()
        {
            var sliceGames = _sliceGameServices.Get();

            //enumerable.GetEnumerator(_gamesForTitlePage);
            //files(sliceGames);


            return sliceGames;//View(sliceGames);
        }

        // GET api/<GameVoteWebApiController>/5
        //[Route("{id}")]
        [HttpGet("{id}")]
        public GamesForTitlePage Get(int id)//IActionResult Get(int id)
        {
            var sliceGames = _sliceGameServices.Get(id);
            return sliceGames;//View(sliceGames);
        }

        // POST api/<GameVoteWebApiController>
        [HttpPost]
        public int Post(GamesForTitlePage newGame)//[FromBody] string value)
        {
            HttpResponseMessage message = new HttpResponseMessage();
            _sliceGameServices.Post(newGame);
            RedirectToAction("Game/All");
            return (int)message.StatusCode;
        }
        
        // PUT api/<GameVoteWebApiController>/5
        [HttpPut]
        public bool Update(int id, GamesForTitlePage newGame)//int id, [FromBody] string value)
        {
            return true;
        }

        // DELETE api/<GameVoteWebApiController>/5
        //[Route("{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return true;
        }
    }
}
