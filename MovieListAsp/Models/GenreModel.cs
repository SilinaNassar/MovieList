using System.ComponentModel.DataAnnotations;
namespace MovieListAsp.Models
{
    public class GenreModel
    {
        [Key]
        public string GenreID { get; set; }
        public String GenreName { get; set; }
    }
}
