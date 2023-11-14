using Microsoft.AspNetCore.Mvc;

namespace ZabanCp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
