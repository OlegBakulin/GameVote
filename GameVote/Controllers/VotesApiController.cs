using GameVote.Domain.DBServices.Interface;
using GameVote.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GameVote.Controllers
{
    [Route("Vote")]
    public class VotesApiController : ControllerBase
    {
        private IDBServices services;
        public VotesApiController(IDBServices _services) => services = _services;

        [HttpGet]
        public IEnumerable<IEnumerable<decimal>> VotesGet()
        {
            List<decimal> voteuser = new List<decimal>();
            List<List<decimal>> allgamevote = new List<List<decimal>>();
            
            var games = services.GetGamesForTitlePage(gameId: 0, storeId: 1);
            foreach (var gama in games)
            {
                if (gama.DistributionOfVotesByPrice.Count != 0)
                {
                    voteuser.Clear();
                    foreach (var votepriceuser in gama.DistributionOfVotesByPrice)
                    {
                        voteuser.Add(votepriceuser.Price);
                    }
                    allgamevote.Add(new List<decimal>(voteuser));
                }
            }
            return allgamevote;
        }

        [HttpGet("{id}")]
        public decimal VoteGet(int id)
        {
            var voteuser = services.GetGamesForTitlePage(gameId: id, storeId: 1).FirstOrDefault(e => e.Id.Equals(id))
                .DistributionOfVotesByPrice.FirstOrDefault(u => u.UserId == 1).Price;
            return voteuser;
        }

        [HttpGet("diagramm/{id}")]
        public int[] VoteDiagrammGet(int id)
        {
            var gama = services.GetGamesForTitlePage(gameId: id, storeId: 1).FirstOrDefault(e => e.Id.Equals(id));
            int[] voteStep1000 = new int[(int)((gama.Price / 1000) + 2)];
            foreach (var vote in gama.DistributionOfVotesByPrice)
            {

                if (vote.Price >= gama.Price) 
                {
                    voteStep1000[voteStep1000.Length - 1]++;
                }
                else
                {
                    voteStep1000[(int)(vote.Price / 1000)]++;
                }
            }
            return voteStep1000;
        }

        [HttpPost("Insert")]
        public void VoteInsert([FromBody] Vote vote)
        {
            services.InsertVote(vote);
        }

        [HttpPut("Redact")]
        public void VoteDeleteInsert([FromBody] Vote vote)
        {
            services.DeleteVote(vote);
            services.InsertVote(vote);
        }

        [HttpDelete("Delete")]
        public void VoteDelete([FromBody] Vote vote)
        {
            services.DeleteVote(vote);
        }
    }
}
