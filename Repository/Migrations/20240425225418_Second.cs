using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Clubs_ClubId",
                table: "Standings");

            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Tournaments_TournamentId",
                table: "Standings");

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Clubs_ClubId",
                table: "Standings",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Tournaments_TournamentId",
                table: "Standings",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Clubs_ClubId",
                table: "Standings");

            migrationBuilder.DropForeignKey(
                name: "FK_Standings_Tournaments_TournamentId",
                table: "Standings");

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Clubs_ClubId",
                table: "Standings",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Standings_Tournaments_TournamentId",
                table: "Standings",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
