using Microsoft.AspNetCore.Identity;
using Npgsql;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameVote.Domain.Entities.Users
{
    public class User<TKey> where TKey : IEquatable<TKey>
    {
        public User() { }
        public User(string userName) { }
        
        [PersonalData]
        public virtual TKey Id { get; set; }
        
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        
        [PersonalData]
        public virtual bool? TwoFactorEnabled { get; set; }
        
        [PersonalData]
        public virtual bool? PhoneNumberConfirmed { get; set; }
        
        [ProtectedPersonalData]
        public virtual string? PhoneNumber { get; set; }
        
        public virtual string? ConcurrencyStamp { get; set; }
        
        public virtual string? SecurityStamp { get; set; }
        
        public virtual string? PasswordHash { get; set; }
        
        [PersonalData]
        public virtual bool? EmailConfirmed { get; set; }
        
        public virtual string? NormalizedEmail { get; set; }
        
        public virtual string? NormalizedUserName { get; set; }
                
        public virtual bool? LockoutEnabled { get; set; }
        
        public virtual int? AccessFailedCount { get; set; }
        
        public override string? ToString() { return ""; }
        
        [ProtectedPersonalData]
        public virtual string? UserName { get; set; }
        
        [ProtectedPersonalData]
        public virtual string? Email { get; set; }

        public string? Role { get; set; }
        
        public string? Login { get; set; }
    }
}
