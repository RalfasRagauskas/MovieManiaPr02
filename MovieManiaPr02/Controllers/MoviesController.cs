using Microsoft.AspNetCore.Mvc;
using MovieManiaPr02.Models;
using MovieManiaPr02.Persistence;

namespace MovieManiaPr02.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movies = MovieRepository.GetAll();
            return View(movies);
        }
    }
}
