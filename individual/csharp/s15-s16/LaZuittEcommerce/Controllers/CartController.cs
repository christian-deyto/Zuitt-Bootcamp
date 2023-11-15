using LaZuittEcommerce.Data;
using LaZuittEcommerce.Models;
using LaZuittEcommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LaZuittEcommerce.Controllers
{
    public class CartController : Controller
    {

        private readonly LaZuittContext _context;

        public CartController(LaZuittContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //Creates a new instance for our CartItem class model.
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            //Creates a new instance for our CartViewModel class model.
            CartViewModel cartVM = new()
            {
                CartItems = cart,
                TotalAmount = cart.Sum(x => x.Quantity * x.Price)
            };


            //Returns the CartViewModel as View to our Cart/Index.cshtml
            return View(cartVM);

        }

        public async Task<IActionResult> Add(int id)
        {
            //Awaits the Add to Cart click from the user.
            Course course = await _context.Course.FindAsync(id);

            //Created a new instance of List<> that acts as your session.
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            //Searches the course based on the id passed in the Add() function param.
            CartItem cartItem = cart.Where(c => c.CourseId == id).FirstOrDefault();

            //Checks if the cart item already exists in our cart.
            bool cartItemExists = cart.Any(i => i.CourseId == id);


            //Initial item input.
            if (cartItem == null)
            {
                cart.Add(new CartItem(course));
            }
            //Prevents the item duplication
            else if (cartItemExists == true)
            {
                TempData.Keep();
                return RedirectToAction("Index", "Course");
            }

            //Initialize the "Cart" session to the value of the cart variable.
            HttpContext.Session.SetJson("Cart", cart);

            //Initialize our TempData["Count"] to the number of items in the cart.
            TempData["Count"] = cart.Count();

            //To retain all the TempData values
            TempData.Keep();

            //To redirect the user back to Course/Index.cshtml.
            return RedirectToAction("Index", "Course");


        }

        public IActionResult Remove(int id)
        {
            //Created a new instance of List<> that acts as our session
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");

            //Removes a record based on the CourseId
            cart.RemoveAll(p => p.CourseId == id);

            //Removes all sessions if no item exists in our cart.
            if(cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            //Sets our session to existing cart items.
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }

            //Reassign TemoData["Count"] new count value and keep the TempData value.
            TempData["Count"] = cart.Count();
            TempData.Keep();

            //Redirect the user back to the Cart/Index.cshtml or same page.
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Checkout([Bind("Id, FirstName, LastName, Email, BillingAddress")] Student student)
        {
            if(ModelState.IsValid)
            {
                //Save student record
                _context.Add(student);
                await _context.SaveChangesAsync();

                //Creates new instance for Enroll
                Enroll e = new Enroll();
                e.EnrollDate = DateTime.Today;
                //The Id value is from the student that was recently saved in our Db.
                e.StudentId = student.Id;

                //Save Enroll record
                _context.Enroll.Add(e);
                await _context.SaveChangesAsync();

                //Retrieves our cart session data.
                List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");


                int lastEnrollId = e.Id;

                foreach(var item in cart)
                {
                    EnrollCourses ec = new EnrollCourses();
                    ec.EnrollId = lastEnrollId;
                    ec.CourseId = item.CourseId;
                    ec.Quantity = 1;

                    //Saves EnrollCourses_record
                    _context.EnrollCourses.Add(ec);
                    _context.SaveChanges();
                }

                //Clearing sessions and TempData values
                TempData.Keep();
                HttpContext.Session.Remove("Cart");
                TempData["Count"] = null;

                //For our partial view
                TempData["Message"] = "Thank you for enrolling in out courses";

                //Redirecting to Cart/Index.cshtml or same page.
                return RedirectToAction("Index");
            }

            return View(student);
        }


    }
}
