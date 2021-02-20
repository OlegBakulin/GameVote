using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameVote.Domain.ViewModels;


namespace GameVote.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<GameViewModel> games = new List<GameViewModel>
        {
            new GameViewModel
            {
                Id = 1,
                Nazvanie = "PayDay 2",
                Opisanie = "Увлекательный шутер для четырех игроков, в котором вы с друзьями грабите банки и получаете за это оплату. За преступления действительно платят — используйте полученные деньги, чтобы открывать для своего персонажа новые навыки.",
                PriceRelise = 1199,
                PriceNow = 0,
                UrlGame = "https://store.playstation.com/ru-ru/product/EP4040-CUSA01761_00-PAYDAY2CRIMEWAVE",
                ImgGame = @"/PayDay2/PayDay2.jpg"
            },
            new GameViewModel
            {
                Id = 2,
                Nazvanie = "Little Nightmares II",
                Opisanie = @"   Вернитесь в мир очаровательных ужасов Little Nightmares II — приключенческой игры с нагнетанием саспенса. Вы играете за мальчика Моно, попавшего в мир, деформированный Передачей от далекой башни. /n
                                Вместе с Шестой, девочкой в желтом плаще, ставшей его проводником, Моно пытается раскрыть темные тайны Маяка. В нелегком путешествии Моно и Шестая столкнутся со множеством новых угроз со стороны ужасных жителей этого мира.
                                Осмелитесь ли вы противостоять этим новым маленьким кошмарам?",
                PriceRelise = 2149,
                PriceNow = 2149,
                UrlGame = "https://store.playstation.com/ru-ru/concept/232583",
                ImgGame = "Little Nightmares II.jpg"
            }
        };

        public IActionResult Index()
        {
            return View(games);
        }
        public IActionResult Games(ulong id)
        {
            return View();
        }
    }
}
