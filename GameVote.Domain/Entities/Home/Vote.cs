using GameVote.Domain.Entities.Home.Interface;

namespace GameVote.Domain.Entities
{
    public class Vote : IVote
    {
        byte IVote.Vote { get; set; }
    }
}
