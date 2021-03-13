namespace GameVote.Domain.DTO.IDTO
{
    public interface IDTOGameForTitlePage
    {
        public int Id { get; set; }                     //ИД игры
        public string Name { get; set; }                //название игры
        public string UrlOfficialSaitGame { get; set; } //ссылка на сайт игры в офф магазине
        public string ImgGame { get; set; }             //ссылка на картинку
        
        public decimal Price { get; set; }              //Цена игры начальная
        public decimal DiscountedPrice { get; set; }    //Цена сейчас

        public int UserVoteQuantity { get; set; }       //количество юзеров проголосовавших за игру
        public decimal UserVoteFullPrice { get; set; }      //голос ценой за которую юзеры готовы купить игру
    }
}
 