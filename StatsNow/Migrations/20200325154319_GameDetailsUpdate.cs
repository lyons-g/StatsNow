using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class GameDetailsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AST",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Block",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "D_Rb",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FTA",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FTM",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "FT_PC",
                table: "Games",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "O_Rb",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Steal",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TO",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Three_PC",
                table: "Games",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Three_PM",
                table: "Games",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Total_Reb",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Two_PA",
                table: "Games",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Two_PM",
                table: "Games",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AST",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Block",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "D_Rb",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FTA",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FTM",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FT_PC",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "O_Rb",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Steal",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "TO",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Three_PC",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Three_PM",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Total_Reb",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Two_PA",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Two_PM",
                table: "Games");
        }
    }
}
