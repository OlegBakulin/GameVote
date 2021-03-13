using GameVote.Domain.DTO.IDTO;

namespace GameVote.Domain.DTO
{
    public class DTOGameForTitlePage : IDTOGameForTitlePage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlOfficialSaitGame { get; set; }
        public string ImgGame { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int UserVoteQuantity { get; set; }
        public decimal UserVoteFullPrice { get; set; }
    }
}
