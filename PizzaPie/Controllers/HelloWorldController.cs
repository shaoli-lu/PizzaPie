using Microsoft.AspNetCore.Mvc;
using PizzaPie.Models;

namespace PizzaPie.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            //DogViewModel dogo = new DogViewModel()
            //{
            //    Name ="Beso", Age = 2
            //};
            return View(dogs);
        }

        public string Hello()
        {
            return "Who's there?";
        }

        public IActionResult Create() 
        {
            var dogVm = new DogViewModel();
            return View(dogVm); 
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
