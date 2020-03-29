using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class GameModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FG",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FGA",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FGperC",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FG",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FGA",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FGperC",
                table: "Games");
        }
    }
}
