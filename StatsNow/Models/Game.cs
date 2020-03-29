using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public Team HomeTeam { get; set; }
        public string Home { get; set; }

        public Team AwayTeam { get; set; }
        public string Away { get; set; }
        public string Venue { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public bool IsGamesOfTheSeason { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Win { get; set; }

        public decimal FG { get; set; }
        public decimal FGA { get; set; }

        public decimal FGperC { get; set; }

        public decimal Two_PM { get; set; }
        public decimal Two_PA { get; set; }
        public decimal Three_PM { get; set; }

        public decimal Three_PC { get; set; }

        public int FTM { get; set; }
        public int FTA { get; set; }
        public decimal FT_PC { get; set; }
        public int O_Rb { get; set; }
        public int D_Rb { get; set; }
        public int Total_Reb { get; set; }
        public int AST { get; set; }
        public int TO { get; set; }
        public int Steal {get;set;}
        public int Block { get; set; }
        public int Points { get; set; }



    }
}
