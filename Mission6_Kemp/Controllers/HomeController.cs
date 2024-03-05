using Microsoft.AspNetCore.Mvc;
using Mission6_Kemp.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6_Kemp.Controllers
{
    public class HomeController : Controller
    {
        private MovieListContext _context; // putting this line inside the class makes it so it can be seen with everything else

        public HomeController(MovieListContext temp) //constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            _context.Movies.Add(response);

            return View("Confirmation", response);
        }

		public IActionResult MovieList()
		{
            // Linq
            var movies = _context.Movies;  //name of the database

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName.ToList();
                .ToList();

            return View(movies); // we are passing in a model table??

		}

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName.ToList();
				.ToList();

            return View("DatingApplication", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("ShowMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("ShowMovies");
        }


    }
}
