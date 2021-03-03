using GameVote.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GameVote.Clients.FullGameClient
{
    class FullGameClient : IFullGameServices
    {
        [HttpDelete]
        public HttpStatusCode Delete(int id)
        {
            return HttpStatusCode.OK;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public Uri Post(string value)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public HttpStatusCode Update(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
