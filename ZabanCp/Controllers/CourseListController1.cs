using Microsoft.AspNetCore.Mvc;

namespace ZabanCp.Controllers
{
    public class CourseListController1 : Controller
    {
        [Route("CourseList")]

        public IActionResult CourseList()
        {
            return View();
        }
    }
}
