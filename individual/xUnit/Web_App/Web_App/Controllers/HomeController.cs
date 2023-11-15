using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_App.Models;

namespace Web_App.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            // this will fail the test
            //throw new NotImplementedException();


            // This will pass the test.
            return View("Index");

            //This will also fail because it will result to privacy page.
            //return View("Privacy");
        }

    }
}