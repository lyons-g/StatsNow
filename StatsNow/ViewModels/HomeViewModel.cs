
using StatsNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> GamesOfTheSeason { get; set; }
    }
}
