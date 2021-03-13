namespace GameVote.Domain.ViewModels
{
    public class DistributionOfVotesByPrice
    {
        public int GameId { get; set; }
        public int StoreId { get; set; }
        public decimal Price { get; set; }

        public int CountVotes { get; set; }
        public int CountVotesFullPrice { get; set; } // Не хватало для расчётов
        public int UserId { get; set; }
    }
}
