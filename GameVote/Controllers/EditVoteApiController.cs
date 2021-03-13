using GameVote.Domain.DBServices.Interface;
using GameVote.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameVote.Controllers
{
    [Route("VoteEdit")]
    public class EditVoteApiController : ControllerBase
    {
        private IDBServices services;
        public EditVoteApiController(IDBServices _services) => services = _services;

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
