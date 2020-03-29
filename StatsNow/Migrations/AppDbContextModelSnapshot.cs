﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StatsNow.Models;

namespace StatsNow.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StatsNow.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "SuperLeague"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Junior"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "u20"
                        });
                });

            modelBuilder.Entity("StatsNow.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AST")
                        .HasColumnType("int");

                    b.Property<string>("Away")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AwayScore")
                        .HasColumnType("int");

                    b.Property<int?>("AwayTeamTeamId")
                        .HasColumnType("int");

                    b.Property<int>("Block")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("D_Rb")
                        .HasColumnType("int");

                    b.Property<decimal>("FG")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FGA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FGperC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FTA")
                        .HasColumnType("int");

                    b.Property<int>("FTM")
                        .HasColumnType("int");

                    b.Property<decimal>("FT_PC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Home")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeScore")
                        .HasColumnType("int");

                    b.Property<int?>("HomeTeamTeamId")
                        .HasColumnType("int");

                    b.Property<bool>("IsGamesOfTheSeason")
                        .HasColumnType("bit");

                    b.Property<int>("O_Rb")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("Steal")
                        .HasColumnType("int");

                    b.Property<int>("TO")
                        .HasColumnType("int");

                    b.Property<decimal>("Three_PC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Three_PM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Total_Reb")
                        .HasColumnType("int");

                    b.Property<decimal>("Two_PA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Two_PM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Win")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamTeamId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HomeTeamTeamId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            AST = 0,
                            Away = "Maree",
                            AwayScore = 70,
                            Block = 0,
                            CategoryId = 1,
                            D_Rb = 0,
                            FG = 21m,
                            FGA = 64m,
                            FGperC = 33m,
                            FTA = 0,
                            FTM = 0,
                            FT_PC = 0m,
                            Home = "Moycullen",
                            HomeScore = 58,
                            IsGamesOfTheSeason = false,
                            O_Rb = 0,
                            Points = 0,
                            Steal = 0,
                            TO = 0,
                            Three_PC = 0m,
                            Three_PM = 0m,
                            Total_Reb = 0,
                            Two_PA = 0m,
                            Two_PM = 0m,
                            Venue = "Kingfisher",
                            Win = "No"
                        },
                        new
                        {
                            GameId = 2,
                            AST = 0,
                            Away = "Moycullen",
                            AwayScore = 59,
                            Block = 0,
                            CategoryId = 1,
                            D_Rb = 0,
                            FG = 18m,
                            FGA = 60m,
                            FGperC = 30m,
                            FTA = 0,
                            FTM = 0,
                            FT_PC = 0m,
                            Home = "Killester",
                            HomeScore = 57,
                            IsGamesOfTheSeason = true,
                            O_Rb = 0,
                            Points = 0,
                            Steal = 0,
                            TO = 0,
                            Three_PC = 0m,
                            Three_PM = 0m,
                            Total_Reb = 0,
                            Two_PA = 0m,
                            Two_PM = 0m,
                            Venue = "IWA",
                            Win = "Yes"
                        },
                        new
                        {
                            GameId = 3,
                            AST = 0,
                            Away = "DCU",
                            AwayScore = 87,
                            Block = 0,
                            CategoryId = 1,
                            D_Rb = 0,
                            FG = 22m,
                            FGA = 62m,
                            FGperC = 35m,
                            FTA = 0,
                            FTM = 0,
                            FT_PC = 0m,
                            Home = "Moycullen",
                            HomeScore = 64,
                            IsGamesOfTheSeason = false,
                            O_Rb = 0,
                            Points = 0,
                            Steal = 0,
                            TO = 0,
                            Three_PC = 0m,
                            Three_PM = 0m,
                            Total_Reb = 0,
                            Two_PA = 0m,
                            Two_PM = 0m,
                            Venue = "Kingfisher",
                            Win = "No"
                        },
                        new
                        {
                            GameId = 4,
                            AST = 0,
                            Away = "Moycullen",
                            AwayScore = 73,
                            Block = 0,
                            CategoryId = 1,
                            D_Rb = 0,
                            FG = 28m,
                            FGA = 70m,
                            FGperC = 40m,
                            FTA = 0,
                            FTM = 0,
                            FT_PC = 0m,
                            Home = "UCD",
                            HomeScore = 79,
                            IsGamesOfTheSeason = true,
                            O_Rb = 0,
                            Points = 0,
                            Steal = 0,
                            TO = 0,
                            Three_PC = 0m,
                            Three_PM = 0m,
                            Total_Reb = 0,
                            Two_PA = 0m,
                            Two_PM = 0m,
                            Venue = "UCD",
                            Win = "No"
                        });
                });

            modelBuilder.Entity("StatsNow.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TeamNameTeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TeamNameTeamId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            FName = "Ger",
                            LName = "Lyons",
                            PlayerNumber = 7
                        });
                });

            modelBuilder.Entity("StatsNow.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            TeamName = "Moycullen"
                        },
                        new
                        {
                            TeamId = 2,
                            TeamName = "Maree"
                        });
                });

            modelBuilder.Entity("StatsNow.Models.Game", b =>
                {
                    b.HasOne("StatsNow.Models.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamTeamId");

                    b.HasOne("StatsNow.Models.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StatsNow.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamTeamId");
                });

            modelBuilder.Entity("StatsNow.Models.Player", b =>
                {
                    b.HasOne("StatsNow.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("StatsNow.Models.Team", "TeamName")
                        .WithMany("Roster")
                        .HasForeignKey("TeamNameTeamId");
                });

            modelBuilder.Entity("StatsNow.Models.Team", b =>
                {
                    b.HasOne("StatsNow.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
