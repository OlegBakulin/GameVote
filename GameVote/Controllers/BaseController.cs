﻿
using System;
using System.Collections.Generic;
using System.Linq;
using GameVote.Domain.ViewModels;
using GameVote.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using GameVote.Services.DBServices.Interface;

namespace GameVote.Controllers
{
   
    public class BaseController : Controller
    {
        private readonly IDBServices _iDBServices;
        public BaseController(IDBServices dBServices) => _iDBServices = dBServices;
        /*
        private readonly List<GameViewModel> games = new List<GameViewModel>
        {
            new GameViewModel
            {
                Id = 1,
                Nazvanie = "PayDay 2",
                Opisanie = "Увлекательный шутер для четырех игроков, в котором вы с друзьями грабите банки и получаете за это оплату. За преступления действительно платят — используйте полученные деньги, чтобы открывать для своего персонажа новые навыки.",
                Genre = "Шутер",
                Localization = true,
                MinAge = 18,
                ModeGame = "DLC",
                Publisher = "OverKILL",
                Releas = new DateTime (2015, 09, 12),
                SeriesGame = "PayDay",
                Subtitle = true,
                TypeGame = "MultiPlay",
                UrlOfficialSaitGame = "https://store.playstation.com/ru-ru/product/EP4040-CUSA01761_00-PAYDAY2CRIMEWAVE",
                ImgGame = @"PayDay2/PayDay2.jpg"
            },
            new GameViewModel
            {
                Id = 2,
                Nazvanie = "Little Nightmares II",
                Opisanie = @"   Вернитесь в мир очаровательных ужасов Little Nightmares II — приключенческой игры с нагнетанием саспенса. Вы играете за мальчика Моно, попавшего в мир, деформированный Передачей от далекой башни. /n
                                Вместе с Шестой, девочкой в желтом плаще, ставшей его проводником, Моно пытается раскрыть темные тайны Маяка. В нелегком путешествии Моно и Шестая столкнутся со множеством новых угроз со стороны ужасных жителей этого мира.
                                Осмелитесь ли вы противостоять этим новым маленьким кошмарам?",
                
                //PriceRelise = 2149,
                //PriceNow = 2149,
                
                UrlOfficialSaitGame = "https://store.playstation.com/ru-ru/concept/232583",
                ImgGame = @"LittleNightmaresII/LittleNightmaresII.jpg"
            }
        };

        private readonly List<Platforming> gameplatform = new List<Platforming>
        {            
            new Platforming
            {
                PlatformGame = "PS4",
                PriceNow = 0,
                PriceRelise = 1199,
                DataRelise = new DateTime (2015, 09, 12),
                DataLostSale = new DateTime (2020, 09, 21)               
            },

             new Platforming
            {
                PlatformGame = "PS5",
                PriceNow = 2149,
                PriceRelise = 2149,
                DataRelise = new DateTime (2021, 02, 12),
                DataLostSale = new DateTime (2021, 02, 12)
            },

        };
        */
        public IActionResult Index()
        {
            var games = _iDBServices.GetGamesForTitlePage();
            _iDBServices.InsertVote(new Vote
            {
                Game = new Game { Id = 5 },
                Store = new Store { Id = 2 },
                User = new User { Id = 3 },
                Price = 200
            });
            _iDBServices.DeleteVote(new Vote
            {
                Game = new Game { Id = 5 },
                Store = new Store { Id = 2 },
                User = new User { Id = 3 },
            });
            return View(games);
        }

        [Route("{id}")]
        public IActionResult GamesById(int id)
        {
            var game = _iDBServices.GetGamesForTitlePage().ElementAt(id);
            /*
            var gameplatformnow = new GamePlatformViewModel
            {
                g = gameplatform.ElementAt(id).DataLostSale,
                DataRelise = gameplatform.ElementAt(id).DataRelise,
                PlatformGame = gameplatform.ElementAt(id).PlatformGame,
                PriceNow = gameplatform.ElementAt(id).PriceNow,
                PriceRelise = gameplatform.ElementAt(id).PriceRelise,
                Games = games.ElementAt(id)
            };
            */
            return View(game);
        }

        public IActionResult GamesByIdSlice(int id)
        {
            return View();
        }
    }
}
