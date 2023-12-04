using BussinesAccessLayer.Dto;
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

        [Route("CourseDetail")]
        public IActionResult CourseDetail(int id)
        {

            return View();



        }

    }
}
