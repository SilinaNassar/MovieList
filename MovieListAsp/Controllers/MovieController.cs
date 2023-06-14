using Microsoft.AspNetCore.Mvc;
using MovieListAsp.Models;

namespace MovieListAsp.Controllers
{
    public class MovieController : Controller
    {
        private MovieDbContext context { get; set; }
        public MovieController(MovieDbContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Genres = context.Genres.OrderBy(g => g.GenreName).ToList();
            return View("Edit", new MovieModel());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = context.Genres.OrderBy(g => g.GenreName).ToList();
            var movie = context.MoviesNew.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieID == 0)
                    context.MoviesNew.Add(movie);
                else
                    context.MoviesNew.Update(movie);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieID == 0) ? "Add" : "Edit";
                return View(movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.MoviesNew.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieModel movie)
        {
            context.MoviesNew.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
