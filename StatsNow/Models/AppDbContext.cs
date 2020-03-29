using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatsNow.Models;

namespace StatsNow.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Team
            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 1, TeamName = "Moycullen" });
            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 2, TeamName = "Maree" });

            //seed Player
            modelBuilder.Entity<Player>().HasData(new Player { PlayerId = 1, FName = "Ger", LName = "Lyons", PlayerNumber = 7 });

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "SuperLeague" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Junior" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "u20" });

            //seed games
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 1,
                Home = "Moycullen",
                Away = "Maree",
                Venue = "Kingfisher",
                HomeScore = 58,
                AwayScore = 70,
                IsGamesOfTheSeason = false,
                CategoryId = 1,
                Win = "No",
                FG = 21,
                FGA = 64,
                FGperC = 33

            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 2,
                Home = "Killester",
                Away = "Moycullen",
                Venue = "IWA",
                HomeScore = 57,
                AwayScore = 59,
                IsGamesOfTheSeason = true,
                CategoryId = 1,
                Win = "Yes",
                FG = 18,
                FGA = 60,
                FGperC = 30
            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 3,
                Home = "Moycullen",
                Away = "DCU",
                Venue = "Kingfisher",
                HomeScore = 64,
                AwayScore = 87,
                IsGamesOfTheSeason = false,
                CategoryId = 1,
                Win = "No",
                FG = 22,
                FGA = 62,
                FGperC = 35


            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 4,
                Home = "UCD",
                Away = "Moycullen",
                Venue = "UCD",
                HomeScore = 79,
                AwayScore = 73,
                IsGamesOfTheSeason = true,
                CategoryId = 1,
                Win = "No",
                FG = 28,
                FGA = 70,
                FGperC = 40
            });
        }

        public DbSet<StatsNow.Models.Player> Player { get; set; }

        public DbSet<StatsNow.Models.Team> Team { get; set; }

    }

}