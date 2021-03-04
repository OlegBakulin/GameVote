using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using GameVote.Clients.Base;
using GameVote.Domain.ViewModels;
using Microsoft.Extensions.Configuration;
using GameVote.Interfaces;

namespace GameVote.Clients.SliceGame
{
    public class SliceGameClient : BaseClient, ISliceGameServices
    {
        protected readonly string ServiceAddress;
        protected readonly HttpClient Client;
        public SliceGameClient (IConfiguration Configuration, string ServiceAddres) : base(Configuration, "api/values")
        {
        }

        public HttpStatusCode Delete(int id) => Delete($"{_ServiceAddress}/{id}").StatusCode;
       

        public IEnumerable<GamesForTitlePage> Get() => Get<IEnumerable<GamesForTitlePage>>(ServiceAddress);

        public GamesForTitlePage Get(int id) => Get<GamesForTitlePage>($"{ServiceAddress}/{id}");

        public int Post(GamesForTitlePage newGame) => Post(ServiceAddress, newGame).Content.ReadAsAsync<int>().Result;

        public HttpStatusCode Update(int id, GamesForTitlePage newGame)
        {
            try 
            {
                HttpStatusCode hscd = Delete(id);
                int hscp = Post(newGame);
                return hscd;
            }
            catch
            {
                HttpStatusCode hsce = HttpStatusCode.Conflict;
                return hsce;
            }

        }
    }
}
