using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceCapstone.Data;
using ECommerceCapstone.Models;

namespace ECommerceCapstone.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly ECommerceContext _context;

        public AdminDashboardController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: /AdminDashboard
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // GET: AdminDashboard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: /AdminDashboard/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // Implement similar methods for Update, Archive, and Unarchive actions.

        // GET: /AdminDashboard/Edit/5
        public IActionResult Edit(int id)
        {
            // Retrieve and edit the product with the given ID.
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }


        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }


        // GET: AdminDashboard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: AdminDashboard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ECommerceContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: AdminDashboard/Archive/5
        public async Task<IActionResult> Archive(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: AdminDashboard/Archive/5
        [HttpPost, ActionName("Archive")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ArchiveConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ECommerceContext.Products' is null.");
            }

            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                // Archive the product by setting the 'Archived' property to true
                product.Archived = true;
                _context.Update(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

    }
}

