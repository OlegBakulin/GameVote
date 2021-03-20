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
            bool userExists = false;
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @$"
                                    SELECT * 
                                    FROM public.""user""
                                    WHERE ""email"" = @email;";

                    connection.Open();
                    var result = connection.Query<User>(query, new { email = user.Email });
                    userExists = result.ToList().Count != 0;
                }
            }
            catch (Exception ex)
            {
                //здесь должно быть предупреждение об ошибке и её логирование, создавать нового пользователя не надо
                //user = null;
            }

            if (!userExists)
            {
                int id;
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    string query = @$"INSERT INTO public.""user""(name,email,phone,login,password)
                            VALUES (@name, @email, @phone, @login, @password) RETURNING id;";

                    connection.Open();
                    id = (Int32)connection.ExecuteScalar(query,
                        new
                        {
                            name = user.UserName,
                            email = user.Email,
                            phone = user.PhoneNumber,
                            login = user.Login,
                            password = user.PasswordHash
                        }
                        );
                }
                user.Id = id;
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
                                    ""email"" = @Email AND
                                    ""passwordHash"" = @PasswordHash;";

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