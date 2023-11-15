using LaZuittEcommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace LaZuittEcommerce.Controllers
{
    public class CourseController : Controller
    {

        private readonly LaZuittContext _context;

        public CourseController(LaZuittContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Course.ToList());
        }
    }
}
