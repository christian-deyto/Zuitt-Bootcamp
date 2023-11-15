/*using Microsoft.AspNetCore.Mvc;

namespace activity.Controllers
{
    public class BuyersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
*/

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using activity.Models;
using Microsoft.EntityFrameworkCore;
using activity.Data;

namespace discussion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyersController : ControllerBase
    {
        /*public IActionResult Index()
       {
           return View();
       }*/

        private readonly activityContext _context;

        public BuyersController(activityContext context)
        {
            _context = context;
        }

        // GET: api/Subject
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetBuyer()
        {
            return await _context.User.ToListAsync();
        }


        //GET: api/Subject/id
        // Url End Point Pattern: URL/[controller]/[action]/[id]
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetTest(int id)
        {
            var course = await _context.User.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;

        }

        //POST: api/Subject
        [HttpPost]
        public async Task<ActionResult<User>> PostBuyer(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuyer", new { id = user.Id }, user);
        }

        //PUT: api/Subject/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuyer(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuyerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //DELETE: api/Subject/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteBuyer(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();


            return user;

        }





        private bool BuyerExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }

    }
}
