using Microsoft.AspNetCore.Mvc;
using PizzaPie.Models;

namespace PizzaPie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dogo = new DogViewModel()
            {
                Name ="Beso", Age = 2
            };
            return View(dogo);
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
