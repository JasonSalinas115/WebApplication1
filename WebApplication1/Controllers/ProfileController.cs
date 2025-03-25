using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
