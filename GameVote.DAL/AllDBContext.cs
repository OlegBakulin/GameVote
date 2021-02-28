using GameVote.Domain.Entities.Home;
using GameVote.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameVote.DAL
{
    public class AllDBContext : IdentityDbContext<User>
    {
        public AllDBContext(DbContextOptions options) : base(options){}
        public DbSet<Game> Games { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}
