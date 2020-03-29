using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsNow.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Game> Games { get; set; }
    }
}
