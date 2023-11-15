using System.Linq;
using System.Threading.Tasks;
using ECommerceCapstone.Data;
using ECommerceCapstone.Models;
using Microsoft.EntityFrameworkCore;

public class ProductService
{
    private readonly ECommerceContext _context;

    public ProductService(ECommerceContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task AddProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _context.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task ArchiveProductAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            // Archive the product by setting the 'Archived' property to true
            product.Archived = true;
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
