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
        public IActionResult Add()
        {
            return View(new Movie());
        }



        [HttpPost] 
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Add(movie);
                return RedirectToAction("Index");
            }

            return View(movie);
            
        }


        public IActionResult Edit(int? id)
        {
            var movie = id.HasValue ? MovieRepository.GetById(id.Value) : null;
            if (movie == null) return NotFound();

            return View(movie);


        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Update(movie.MovieId, movie);
                return RedirectToAction("Index");

            }

            return View(movie);

        }


        public IActionResult Delete(int id)
        {
            MovieRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
