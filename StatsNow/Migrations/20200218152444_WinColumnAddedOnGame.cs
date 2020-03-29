using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class WinColumnAddedOnGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Win",
                table: "Games",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Win",
                table: "Games");
        }
    }
}
