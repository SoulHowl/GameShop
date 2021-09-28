using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_953504_Barsukevich.Entities;
using WEB_953504_Barsukevich.Models;

namespace WEB_953504_Barsukevich.Controllers
{
    public class ProductController:Controller
    {

        List<Game> _games;
        List<GameGroup> _gameGroups;
        int _pageSize;
        public ProductController()
        {
            _pageSize = 3;
            SetupData();
        }
        public IActionResult Index(int? group, int pageNo=1)
        {
            // var items = _games.Skip((pageNo - 1) * _pageSize).Take(_pageSize).ToList();
            // return View(items);
            var gamesFiltered = _games.Where(d => !group.HasValue || d.GameGroupId == group.Value);

            ViewData["Groups"] = _gameGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            /*return View(ListViewModel<Game>.GetModel(_games, pageNo,pageSize));*/

            return View(ListViewModel<Game>.GetModel(gamesFiltered, pageNo, _pageSize));

        }
        private void SetupData()
        {
            _gameGroups = new List<GameGroup>
            {
                new GameGroup {GameGroupId=1, GroupName="Симуляторы"},
                new GameGroup {GameGroupId=2, GroupName="Ролевые"},
                new GameGroup {GameGroupId=3, GroupName="Гонки"},
                new GameGroup {GameGroupId=4, GroupName="Стратегии"},
                new GameGroup {GameGroupId=5, GroupName="Приключения"},
                new GameGroup {GameGroupId=6, GroupName="Экшн"}
            };
            _games = new List<Game>
            {
                new Game {GameId = 1, GameName="Cyberpunk",
                    Description="Багованная, недопиленная",
                    Price =200, GameGroupId= 3, Image="Cyberpunk.jpg" },
                new Game { GameId = 2, GameName="Mortal Combat 11",
                    Description="Нужно больше одежды",
                    Price =330, GameGroupId=3, Image="MK11.jpg" },
                new Game { GameId = 3, GameName="Doom Eternal",
                    Description="Симулятор маньякича",
                    Price =635, GameGroupId=4, Image="DoomE.jpg" },
                new Game { GameId = 4, GameName="Rocket League",
                    Description="Футбол вышел на новый уровень",
                    Price =524, GameGroupId=4, Image="RocketLeague.jpg" },
                new Game { GameId = 5, GameName="Компот",
                    Description="Быстро растворимый, 2 литра",
                    Price =180, GameGroupId=5, Image="Компот.jpg" }
            };
            }

    }
}
