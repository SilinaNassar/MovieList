using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieListAsp.Migrations
{
    public partial class Genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenreID",
                table: "MoviesNew",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[,]
                {
                    { "A", "Action" },
                    { "C", "Comedy" },
                    { "D", "Drama" },
                    { "H", "Horror" },
                    { "M", "Musical" },
                    { "R", "RomCom" },
                    { "S", "SciFi" }
                });

            migrationBuilder.UpdateData(
                table: "MoviesNew",
                keyColumn: "MovieID",
                keyValue: 1,
                column: "GenreID",
                value: "D");

            migrationBuilder.UpdateData(
                table: "MoviesNew",
                keyColumn: "MovieID",
                keyValue: 2,
                column: "GenreID",
                value: "H");

            migrationBuilder.UpdateData(
                table: "MoviesNew",
                keyColumn: "MovieID",
                keyValue: 3,
                column: "GenreID",
                value: "H");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesNew_GenreID",
                table: "MoviesNew",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesNew_Genres_GenreID",
                table: "MoviesNew",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesNew_Genres_GenreID",
                table: "MoviesNew");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_MoviesNew_GenreID",
                table: "MoviesNew");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "MoviesNew");
        }
    }
}
