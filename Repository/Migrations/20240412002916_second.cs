using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Standingss",
                table: "Standingss");

            migrationBuilder.RenameTable(
                name: "Standingss",
                newName: "Standings");

            migrationBuilder.RenameColumn(
                name: "LocalTeamId",
                table: "Stadiums",
                newName: "LocalClubId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standings",
                table: "Standings",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClubMatches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClubMatches_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubPlayers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_LocalClubId",
                table: "Stadiums",
                column: "LocalClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ClubId",
                table: "Players",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LocalTeamId",
                table: "Matches",
                column: "LocalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_StadiumId",
                table: "Matches",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_VisitorTeamId",
                table: "Matches",
                column: "VisitorTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StandingId",
                table: "Clubs",
                column: "StandingId");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_ClubId",
                table: "Standings",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMatches_ClubId",
                table: "ClubMatches",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMatches_MatchId",
                table: "ClubMatches",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Standings_StandingId",
                table: "Clubs",
                column: "StandingId",
                principalTable: "Standings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Clubs_LocalTeamId",
                table: "Matches",
                column: "LocalTeamId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Clubs_VisitorTeamId",
                table: "Matches",
                column: "VisitorTeamId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Stadiums_StadiumId",
                table: "Matches",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Clubs_ClubId",
                table: "Players",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Clubs_LocalClubId",
                table: "Stadiums",
                column: "LocalClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Clubs_ClubId",
                table: "Standings",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Standings_StandingId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_LocalTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_VisitorTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Stadiums_StadiumId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Clubs_ClubId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Clubs_LocalClubId",
                table: "Stadiums");

            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Clubs_ClubId",
                table: "Standings");

            migrationBuilder.DropTable(
                name: "ClubMatches");

            migrationBuilder.DropTable(
                name: "ClubPlayers");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_LocalClubId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Players_ClubId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Matches_LocalTeamId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_StadiumId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_VisitorTeamId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_StandingId",
                table: "Clubs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Standings",
                table: "Standings");

            migrationBuilder.DropIndex(
                name: "IX_Standings_ClubId",
                table: "Standings");

            migrationBuilder.RenameTable(
                name: "Standings",
                newName: "Standingss");

            migrationBuilder.RenameColumn(
                name: "LocalClubId",
                table: "Stadiums",
                newName: "LocalTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standingss",
                table: "Standingss",
                column: "Id");
        }
    }
}
