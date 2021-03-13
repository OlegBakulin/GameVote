using GameVote.Domain.ViewModels;
using GameVote.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameVote.DAL
{
    public class GamesForTitlePageDBContext : DbContext
    {
        public DbSet<GamesForTitlePage> GamesForTitlePages { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}
