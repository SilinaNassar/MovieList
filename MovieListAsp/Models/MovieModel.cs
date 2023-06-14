using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieListAsp.Models
{
    public class MovieModel
    {
        [Key]
        

        public int MovieID { get; set; }

        [Required(ErrorMessage = "Please enter the movie name!")] 
        public String MovieName { get; set; } =String.Empty;


        [Required(ErrorMessage = "Please enter the movie year!")]
        [Range(1889,2999,ErrorMessage ="The year range is between 1889 and 2999")]
        public int? Year { get; set; }


        [Required(ErrorMessage = "Please rate the movie")]
        [Range(1, 5, ErrorMessage = "The rate is between 1 and 5")]

        public int? Rating { get; set; }


        [Required(ErrorMessage = "Please choose the genre")]
        public string GenreID { get; set; } =String.Empty;

        [ValidateNever]
        public GenreModel Genre { get; set; } = null;



    //public GenreModel Genre { get; set; }


}
}
