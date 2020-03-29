using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StatsNow.Models;
using StatsNow.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StatsNow.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GameController(IGameRepository gameRepository, ICategoryRepository categoryRepository)
        {
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {

            GamesListViewModel gamesListViewModel = new GamesListViewModel();
            gamesListViewModel.Games = _gameRepository.AllGames;

            gamesListViewModel.CurrentCategory = "SuperLeague";

            return View(gamesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var game = _gameRepository.GetGameById(id);
            if (game == null)
                return NotFound();
            else
            {

            }
            return View(game);

            
        }

        
        
    }


    }

