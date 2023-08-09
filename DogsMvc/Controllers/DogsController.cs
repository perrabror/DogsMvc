using DogsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogsMvc.Controllers
{
    public class DogsController : Controller
    {
      static DataService dataService = new DataService();

        public DogsController()
        {
        }

        [HttpGet("")]
        [HttpGet("/Index")]
        public IActionResult Index()
        {
            var dogs = dataService.GetAllDogs().ToList();
            return View(dogs);
        }


        [HttpPost]
        public IActionResult AddDog(Dog dog)
        {
            dataService.AddDog(dog);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Create")]
        public IActionResult Create()
        {
            return View("Create");
        }
    }
}

