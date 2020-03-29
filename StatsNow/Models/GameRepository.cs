using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.Models
{
    public class GameRepository: IGameRepository
    {
        private readonly AppDbContext _appDbContext; 
        public GameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Game> AllGames
        {
            get
            {
                return _appDbContext.Games.Include(c => c.Category);
            }
        }

        public IEnumerable<Game> GamesOfTheSeason
        {
            get
            {
                return _appDbContext.Games.Include(c => c.Category).Where(g=> g.IsGamesOfTheSeason);
            }
        }

        public Game GetGameById(int gameId)
        {
            return _appDbContext.Games.FirstOrDefault(g => g.GameId == gameId);
        }

        
    }
}
