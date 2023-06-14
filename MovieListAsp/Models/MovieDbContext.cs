using Microsoft.EntityFrameworkCore;
namespace MovieListAsp.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<MovieModel> MoviesNew { get; set; } = null;
        public DbSet<GenreModel> Genres { get; set; } = null;


        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenreModel>().HasData(
                new GenreModel { GenreID = "A", GenreName = "Action" },
                new GenreModel { GenreID = "C", GenreName = "Comedy" },
                new GenreModel { GenreID = "D", GenreName = "Drama" },
                new GenreModel { GenreID = "H", GenreName = "Horror" },
                new GenreModel { GenreID = "M", GenreName = "Musical" },
                new GenreModel { GenreID = "R", GenreName = "RomCom" },
                new GenreModel { GenreID = "S", GenreName = "SciFi" }
            );
            modelBuilder.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    MovieID = 1,
                    MovieName = "Casablanca",
                    Year = 1942,
                    Rating = 5,
                    GenreID="D"

                },
                new MovieModel
                {
                    MovieID = 2,
                    MovieName = "Wonder Woman",
                    Year = 2017,
                    Rating = 3,
                    GenreID = "H"

                },
                new MovieModel
                {
                    MovieID = 3,
                    MovieName = "Moonstruck",
                    Year = 1988,
                    Rating = 4,
                    GenreID = "H"

                }
            );


        }
    }
}
