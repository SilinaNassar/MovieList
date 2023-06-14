using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieListAsp.Migrations
{
    public partial class initialNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "MoviesNew");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesNew",
                table: "MoviesNew",
                column: "MovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesNew",
                table: "MoviesNew");

            migrationBuilder.RenameTable(
                name: "MoviesNew",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieID");
        }
    }
}
