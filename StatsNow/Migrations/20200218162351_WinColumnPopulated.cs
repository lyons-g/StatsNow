using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class WinColumnPopulated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Win",
                value: "No");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Win",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "Win",
                value: "No");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "Win",
                value: "No");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Win",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Win",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "Win",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "Win",
                value: null);
        }
    }
}
