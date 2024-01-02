using Microsoft.AspNetCore.Mvc;

namespace ZabanCp.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]

        public IActionResult Index()
        {
            return View();
        }
        [Route("About-us")]

        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("Contact-Us")]
        public IActionResult ContactUsPage()
        {
            return View();
        }
    }
}
