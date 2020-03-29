using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "SuperLeague" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Junior" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "u20" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Away", "AwayScore", "CategoryId", "Home", "HomeScore", "IsGamesOfTheSeason", "Venue" },
                values: new object[,]
                {
                    { 1, "Maree", 70, 1, "Moycullen", 58, false, "Kingfisher" },
                    { 2, "Moycullen", 59, 1, "Killester", 57, true, "IWA" },
                    { 3, "DCU", 87, 1, "Moycullen", 64, false, "Kingfisher" },
                    { 4, "Moycullen", 73, 1, "UCD", 79, true, "UCD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
