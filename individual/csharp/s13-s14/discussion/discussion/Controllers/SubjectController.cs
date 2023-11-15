using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using discussion.Models;
using Microsoft.EntityFrameworkCore;
using discussion.Data;

namespace discussion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        /*public IActionResult Index()
       {
           return View();
       }*/

        private readonly CoursesContext _context;

        public SubjectController(CoursesContext context)
        {
            _context = context;
        }

        // GET: api/Subject
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetSubject()
        {
            return await _context.Course.ToListAsync();
        }


        //GET: api/Subject/id
        // Url End Point Pattern: URL/[controller]/[action]/[id]
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetTest(int id)
        {
            var course = await _context.Course.FindAsync(id);

            if(course == null)
            {
                return NotFound();
            }

            return course;

        }

        //POST: api/Subject
        [HttpPost]
        public async Task<ActionResult<Course>> PostSubject(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubject", new { id = course.Id }, course);
        }

        //PUT: api/Subject/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubject(int id, Course course)
        {
            if(id != course.Id)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!CourseExists(id))
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
        public async Task<ActionResult<Course>> DeleteSubject(int id)
        {
            var course = await _context.Course.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            await _context.SaveChangesAsync();


            return course;

        }





        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
       
    }
}
