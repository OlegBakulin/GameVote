using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameVote.Interfaces;

namespace GameVote.Controllers
{
    [Route("Base")]
    [ApiController]
    public class GameVoteIndexApiController : Controller
    {
        private readonly ISliceGameServices _sliceGameServices;
        public GameVoteIndexApiController(ISliceGameServices sliceGameServices) => _sliceGameServices = sliceGameServices;
        
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var sliceGames = _sliceGameServices.Get();
            return View(sliceGames);
        }

        // GET api/<GameVoteWebApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sliceGames = _sliceGameServices.Get(id);
            return View(sliceGames);
        }

        // POST api/<GameVoteWebApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GameVoteWebApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GameVoteWebApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
