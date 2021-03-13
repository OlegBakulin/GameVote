using System.Collections.Generic;
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

        public bool Delete(int id)
        {
            return Delete($"{_ServiceAddress}/{id}").IsSuccessStatusCode;
        }

        public IEnumerable<GamesForTitlePage> Get() => Get<IEnumerable<GamesForTitlePage>>(ServiceAddress);

        public GamesForTitlePage Get(int id) => Get<GamesForTitlePage>($"{ServiceAddress}/{id}");

        public int Post(GamesForTitlePage newGame) => Post(ServiceAddress, newGame).Content.ReadAsAsync<int>().Result;

        public bool Update(int id, GamesForTitlePage newGame)
        {
            try 
            {
                bool hscd = Delete(id);
                int hscp = Post(newGame);
                return hscd;
            }
            catch
            {
                return false;
            }

        }
    }
}
