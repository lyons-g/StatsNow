using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatsNow.Models;
using StatsNow.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StatsNow.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
       
      public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                GamesOfTheSeason = _gameRepository.GamesOfTheSeason
            };
            return View(homeViewModel);
        }

       public IActionResult View()
        {
            return View();
        }
    }
}