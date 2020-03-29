using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.Models
{
    public interface IGameRepository
    {
        IEnumerable<Game> AllGames { get; }
        IEnumerable<Game> GamesOfTheSeason { get; }
        Game GetGameById(int gameId);
    }
}
