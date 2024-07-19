using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTrackerAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movieStatus = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timesRewatched = table.Column<int>(type: "int", nullable: true),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieId);
                });

            migrationBuilder.CreateTable(
                name: "Rewatched",
                columns: table => new
                {
                    rewatchedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    timesRewatched = table.Column<int>(type: "int", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewatched", x => x.rewatchedId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "creationDate", "genre", "imageUrl", "movieName", "movieStatus", "timesRewatched", "updatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1568), null, "", "Bambi", 0, null, null },
                    { 2, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1593), null, "", "Aristogatos", 0, null, null },
                    { 3, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1596), null, "", "A Dama e o Vagabundo", 0, null, null },
                    { 4, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1598), null, "", "101 Dalmatas", 0, null, null },
                    { 5, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1600), null, "", "Mogli", 0, null, null },
                    { 6, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1602), null, "", "Papuça e Dentuça", 0, null, null },
                    { 7, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1604), null, "", "Alladin", 0, null, null },
                    { 8, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1605), null, "", "Mulan", 0, null, null },
                    { 9, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1608), null, "", "Ratatoille", 0, null, null },
                    { 10, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1609), null, "", "Tarzan", 0, null, null },
                    { 11, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1611), null, "", "Pinochio", 0, null, null },
                    { 12, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1613), null, "", "Hercules", 0, null, null },
                    { 13, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1615), null, "", "Paraiso da Barafunda", 0, null, null },
                    { 14, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1617), null, "", "O Corcunda de Nostredame", 0, null, null },
                    { 15, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1618), null, "", "GodZilla 2014", 0, null, null },
                    { 16, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1620), null, "", "King Of Monsters", 0, null, null },
                    { 17, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1622), null, "", "Kong Vs Godzilla", 0, null, null },
                    { 18, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1624), null, "", "Moana", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "creationDate", "updatedDate", "username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1732), null, "Ricardo" },
                    { 2, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1735), null, "Rafa" },
                    { 3, new DateTime(2024, 7, 19, 1, 53, 57, 454, DateTimeKind.Local).AddTicks(1736), null, "Alex" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Rewatched");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
