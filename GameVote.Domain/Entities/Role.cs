using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.Entities
{
    public class Role : IdentityRole
    {
        public string[] Roles = { "UserVote", "Moder", "Admin", "GenBoss" };
    }
}
