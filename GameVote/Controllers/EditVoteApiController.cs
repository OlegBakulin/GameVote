using GameVote.Domain.DBServices.Interface;
using GameVote.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVote.Controllers
{
    [Route("VoteEdit")]
    public class EditVoteApiController : ControllerBase
    {
        private IDBServices services;
        public EditVoteApiController(IDBServices _services) => services = _services;
/*
        [HttpGet("Insert")]
        public IActionResult VoteInsert()//[FromBody]
        {
            return RedirectToRoute("Index");
        }
*/
        [HttpPost("Insert")]
        public void VoteInsert([FromBody] Vote vote)//
        {
            services.InsertVote(vote);
        }

        // PUT api/<VotesApiController>/5
        [HttpPut("Redact")]
        public void VoteDeleteInsert([FromBody] Vote vote)
        {
            services.DeleteVote(vote);
            services.InsertVote(vote);
        }

        // DELETE api/<VotesApiController>/5
        [HttpDelete("Delete")]
        public void VoteDelete([FromBody] Vote vote)
        {
            services.DeleteVote(vote);
        }
    }
}
