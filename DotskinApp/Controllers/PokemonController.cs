using Microsoft.AspNetCore.Mvc;

namespace DotskinApp.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
