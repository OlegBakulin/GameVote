using Dapper;
using GameVote.Domain.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameVote.Domain.DBServices.Interface
{
    public interface IDBAUTH
    {
        public User UserReg(User user);

        public User UserLog(User user);

        public User UserOut(User user);
    }
}
