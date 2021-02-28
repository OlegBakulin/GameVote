using System;
using System.Collections.Generic;
using System.Net;
using GameVote.Clients.Base;
using GameVote.Interfaces;
using Microsoft.Extensions.Configuration;

namespace GameVote.Clients.SliceGame
{
    public class SliceGameClient : BaseClient, ISliceGameServices
    {
        public SliceGameClient (IConfiguration Configuration) : base(Configuration, "api/values")
        {
        }
        public HttpStatusCode Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        public Uri Post(string value)
        {
            throw new NotImplementedException();
        }

        public HttpStatusCode Update(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
