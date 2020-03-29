using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.Models
{
    public class Team
    {
        
        public int TeamId {get; set;}

        public string TeamName { get; set; }
        public Category Category { get; set; }

       public List<Player> Roster { get; set; }


    }
}
