using ECommerceCapstone.Models;
using ECommerceCapstone.Data;
using Microsoft.AspNetCore.Mvc;
using ECommerceCapstone.Models.ViewModels;

namespace ECommerceCapstone.Controllers
{
    public class CartController : Controller
    {
        private readonly ECommerceContext _context;

        public CartController(ECommerceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>(); Cart cartVM = new()
            {
                CartItems = cart,
                TotalAmount = cart.Sum(x => x.Quantity * x.Price)
            };
            return View(cartVM);
        }

        public async Task<IActionResult> Add(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = cart.Where(c => c.ProductId == id).FirstOrDefault();

            if (cartItem == null)
            {
                cart.Add(new CartItem(product));
            }
            else
            {
                TempData.Keep();
                return RedirectToAction("Index", "Products");
            }

            HttpContext.Session.SetJson("Cart", cart);
            TempData["Count"] = cart.Count();
            TempData.Keep();
            return RedirectToAction("Index", "Products");
        }

        [HttpPost]
        public IActionResult UpdateCartItem(int productId, string changeQuantity)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = cart.FirstOrDefault(item => item.ProductId == productId);

            if (cartItem != null)
            {
                if (changeQuantity == "increment")
                {
                    cartItem.Quantity++;
                }
                else if (changeQuantity == "decrement" && cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                }

                HttpContext.Session.SetJson("Cart", cart);
                _context.SaveChangesAsync();
            }

            return RedirectToAction("Index"); 
        }

        public IActionResult Remove(int id)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            cart.RemoveAll(p => p.ProductId == id);

            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }

            TempData["Count"] = cart.Count();
            TempData.Keep();

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult RemoveAll()
        {
            try
            {
                HttpContext.Session.SetJson("Cart", new List<CartItem>());

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while removing all items from the cart: " + ex.Message);
                return RedirectToAction("Index");
            }
        }


    }
}
