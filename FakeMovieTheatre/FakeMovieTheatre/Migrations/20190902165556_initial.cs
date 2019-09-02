using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeMovieTheatre.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "ID", "Genre", "Picture", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "This is the never ending story, one of the best movies ever! Adventure", "images/neverendingstory.jpg", 5m, new DateTime(2019, 9, 2, 9, 55, 56, 325, DateTimeKind.Local).AddTicks(2945), "The Never Ending story" },
                    { 2, "Extreemely drawn out and boring until an hour in... suspensful and action!", "images/th2.jpg", 42m, new DateTime(2019, 9, 2, 9, 55, 56, 327, DateTimeKind.Local).AddTicks(4715), "King Kong" },
                    { 3, "Comedy suspensful and action!", "images/th.jpg", 69m, new DateTime(2019, 9, 2, 9, 55, 56, 327, DateTimeKind.Local).AddTicks(4734), "This is the End" },
                    { 4, "Action", "images/untitled.png", 30m, new DateTime(2019, 9, 2, 9, 55, 56, 327, DateTimeKind.Local).AddTicks(4734), "Jurrassic park collection" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
