using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieListAsp.Models;
using System.Diagnostics;

namespace MovieListAsp.Controllers
{
    public class HomeController : Controller
    {
        private MovieDbContext Context { get; set; }

        public HomeController(MovieDbContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var movies=Context.MoviesNew
                .Include(m => m.Genre)
                .OrderBy(m=>m.MovieName)
                .ToList();
            return View(movies);
        }

        
    }
}