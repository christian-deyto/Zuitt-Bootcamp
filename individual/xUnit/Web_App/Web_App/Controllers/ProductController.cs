using Web_App.Controllers;
using Microsoft.AspNetCore.Mvc;
using Web_App.Models;

namespace Web_App.Controllers
{
    public class ProductController : Controller
    {

        public IList<Product> prod = new List<Product>();

        Product product = new Product(1, "Python", 40, "Python is a language");

        //Index method
        public IActionResult Index()
        {
            CreateProducts();
            return View(prod);
        }

        private void CreateProducts()
        {
            // Adds the product instantiated above
            prod.Add(product);

            // Initialized 2 new product items before adding to the Product List
            product = new Product(2, "ReactJS", 30000, "Free Product");
            prod.Add(product);
            product = new Product(3, "PHP", 20000, "PHP is PHP!");
            prod.Add(product);
        }

        public ActionResult Details(int id) 
        {
            if(id < 1)
            {
                return RedirectToAction("Index");
            }


            // Calling the create product method
            CreateProducts();
            var product = prod.Where(x => x.Id == id);
            var name = product.FirstOrDefault()?.Name;

            return View("Details", name);
        }

        public ActionResult Details_Description(int id)
        {
            if (id < 1)
            {
                return RedirectToAction("Index");
            }


            CreateProducts();
            var product = prod.Where(x => x.Id == id);
            var name = product.FirstOrDefault()?.Description;

            return View("Details", name);
        }

        public ActionResult Details_Price(int id)
        {
            if (id < 1)
            {
                return RedirectToAction("Index");
            }


            CreateProducts();
            var product = prod.Where(x => x.Id == id);
            var name = product.FirstOrDefault()?.Price;

            return View("Details", name);
        }
    }
}
