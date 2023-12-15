using Microsoft.AspNetCore.Mvc;

namespace Bibliocanto.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
