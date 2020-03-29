using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int PlayerNumber { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public Team TeamName { get; set; }
        public Category Category { get; set; }
    }
}
