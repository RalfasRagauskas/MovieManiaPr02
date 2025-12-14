using Microsoft.AspNetCore.Mvc;
using MovieManiaPr02.Models;
using MovieManiaPr02.Persistence;


namespace MovieManiaPr02.Controllers
{
    public class DirectorsController : Controller
    {
        public IActionResult Index()
        {
            var directors = DirectorRepository.GetAll();
            return View(directors);
        }

        public IActionResult Add()
        {
            return View(new Director());
        }


        [HttpPost]
        public IActionResult Add(Director director)
        {
            if (ModelState.IsValid)
            {
                DirectorRepository.Add(director);
                return RedirectToAction("Index");
            }
                return View(new Director());
        }



        public IActionResult Edit(int? id)
        {
            var director = id.HasValue ? DirectorRepository.GetById(id.Value) : null;
            if (director == null) return NotFound();

            return View(director);
            
        }

        [HttpPost]
        public IActionResult Edit(Director director)
        {
            if (ModelState.IsValid)
            {
                DirectorRepository.Update(director.DirectorId, director);
                return RedirectToAction("Index");
            }

                return View(director);
        }


        public IActionResult Delete(int id)
        {
            DirectorRepository.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
