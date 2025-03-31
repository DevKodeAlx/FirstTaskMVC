using FirstTaskMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTaskMVC.Controllers
{    
    public class MovieController : Controller
    {
        private static List<MovieViewModel> _movies = new List<MovieViewModel>();
        public IActionResult Index()
        {
            //MovieViewModel Movie = new MovieViewModel()
            //{ MovieTitle = "The Godfather", Director = "Francis Ford Coppola", Year = 1972 };
            //return View(Movie);
            return View(_movies);
        }

        public IActionResult Create()
        {
            var movieVm = new MovieViewModel();
            return View(movieVm);
        }
        public IActionResult CreateMovie(MovieViewModel movieViewModel)
        {
            _movies.Add(movieViewModel);
            return RedirectToAction(nameof(Index));
            // returns view("Index");
        
        }
    }
}
