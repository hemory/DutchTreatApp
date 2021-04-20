using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}