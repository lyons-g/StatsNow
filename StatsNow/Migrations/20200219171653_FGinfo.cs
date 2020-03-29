using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class FGinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 21, 64, 33 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 18, 60, 30 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 22, 62, 35 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 28, 70, 40 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 0, 0, 0 });
        }
    }
}
