using Microsoft.AspNetCore.Mvc;

namespace discussion.Controllers
{
    public class CoursesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCourse()
        {
            return View();
        }

    }
}
