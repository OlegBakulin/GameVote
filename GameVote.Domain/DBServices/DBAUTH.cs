using Dapper;
using GameVote.Domain.DBServices.Interface;
using GameVote.Domain.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using GameVote.Domain.ViewModels;
using System.Linq;

namespace GameVote.Domain.DBServices
{
    public class DBAUTH : IDBAUTH
    {
        private string connectionString = "Server = 127.0.0.1; Port=5432;Database=Vote;User Id = postgres; Password=123;";
        public User UserReg(User user)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @$"
                                    SELECT * 
                                    FROM public.""user""
                                    WHERE
                                    @Email = {user.Email};";

                    connection.Open();
                    List<User> users;
                    using (
                        var result = connection.QueryMultiple(query))
                    {
                        users = result.Read<User>().ToList();
                        user = users.ElementAt(0);
                        user.PasswordHash = null;
                    }
                }
            }
            catch
            {
                user = null;
            }

            if (user == null)
            {
                var newiduser = 1;
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @$"SELECT COUNT(*) FROM public.""user""";
                                    
                    connection.Open();
                    
                    using (
                        var result = connection.QueryMultiple(query,
                        new { }))
                    {
                        newiduser = newiduser + result.Read<int>().ToList().ElementAt(0);
                    }
                }
                
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @$"
                                    INSERT INTO public.""user"" SET 
                                    Id={newiduser},
                                    UserName={user.UserName}, 
                                    Email={user.Email},
                                    PhoneNumber={user.PhoneNumber},
                                    Login={user.Login},
                                    PasswordHash={user.PasswordHash},
                                    Role='UserVote'";

                    connection.Open();
                    using (var result = connection.QueryMultiple(query));
                }
                user.Id = newiduser;
                user.Role = "UserVote";
            }
            return user;
        }
        
        public User UserLog(User user)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @$"
                                    SELECT * 
                                    FROM public.""user""
                                    WHERE
                                    @Email = {user.Email} AND
                                    @PasswordHash = {user.PasswordHash};";

                    connection.Open();
                    List<User> users;
                    using (
                        var result = connection.QueryMultiple(query,
                        new { Email = user.Email, PasswordHash = user.PasswordHash }))
                    {
                        users = result.Read<User>().ToList();
                        user = users.ElementAt(0);
                        user.PasswordHash = null;
                        return user;
                    }
                }
            }
            catch
            {
                return user = null;
            }
        }

        public User UserOut(User user)
        {
            return user = null;
        }
    }
}