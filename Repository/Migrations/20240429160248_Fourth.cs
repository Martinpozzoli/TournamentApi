using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Address", "Capacity", "City", "Country", "LocalClubId", "Name" },
                values: new object[,]
                {
                    { 1, "Etihad Campus", 55000, "Manchester", "England", 1, "Etihad Stadium" },
                    { 2, "Sir Matt Busby Way", 75000, "Manchester", "England", 2, "Old Trafford" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "LocalTeamId", "ScoreTeamA", "ScoreTeamB", "StadiumId", "TournamentId", "VisitorTeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, 1, 1, 2 },
                    { 2, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1, 2, 1, 4 },
                    { 3, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 0, 0, 1, 2, 6 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches");

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Matches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id");
        }
    }
}
