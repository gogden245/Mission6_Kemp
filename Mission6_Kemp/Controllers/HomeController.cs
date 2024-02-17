using Microsoft.AspNetCore.Mvc;
using Mission6_Kemp.Models;
using System.Diagnostics;

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
    }
}
