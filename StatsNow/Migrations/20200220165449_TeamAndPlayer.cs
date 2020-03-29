using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsNow.Migrations
{
    public partial class TeamAndPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FGperC",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "FGA",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "FG",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AwayTeamTeamId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeTeamTeamId",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerNumber = table.Column<int>(nullable: false),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    TeamNameTeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamNameTeamId",
                        column: x => x.TeamNameTeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 21m, 64m, 33m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 18m, 60m, 30m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 22m, 62m, 35m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "FG", "FGA", "FGperC" },
                values: new object[] { 28m, 70m, 40m });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "CategoryId", "FName", "LName", "PlayerNumber", "TeamNameTeamId" },
                values: new object[] { 1, null, "Ger", "Lyons", 7, null });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "CategoryId", "TeamName" },
                values: new object[,]
                {
                    { 1, null, "Moycullen" },
                    { 2, null, "Maree" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_AwayTeamTeamId",
                table: "Games",
                column: "AwayTeamTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeTeamTeamId",
                table: "Games",
                column: "HomeTeamTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CategoryId",
                table: "Player",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamNameTeamId",
                table: "Player",
                column: "TeamNameTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_CategoryId",
                table: "Team",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Team_AwayTeamTeamId",
                table: "Games",
                column: "AwayTeamTeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Team_HomeTeamTeamId",
                table: "Games",
                column: "HomeTeamTeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Team_AwayTeamTeamId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Team_HomeTeamTeamId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Games_AwayTeamTeamId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_HomeTeamTeamId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "AwayTeamTeamId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "HomeTeamTeamId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "FGperC",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "FGA",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "FG",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

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
    }
}
