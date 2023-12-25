using Microsoft.AspNetCore.Mvc;

namespace AdminPannel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

            if (User.Identity.IsAuthenticated)
            {
                var exiset = true;
                if (exiset == true)
                {
                    return View();

                }
                else
                {
                    return RedirectToAction("LoginPage");

                }

            }
            else
            {
                return RedirectToAction("LoginPage");
            }

        }
        public IActionResult LoginPage()
        {
            return View();
        }
    }
}
