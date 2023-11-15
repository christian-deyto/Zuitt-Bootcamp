using Microsoft.AspNetCore.Mvc;
using course_booking_cs.Models;
using course_booking_cs.Data;

namespace course_booking_cs.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CoursesController : ControllerBase
    {
        private readonly CourseRepository _courseRepository;

        public CoursesController(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // Get all courses
        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            try
            {
                List<Course> courses = _courseRepository.GetActiveCourses();
                return Ok(courses);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving active courses: " + ex.Message);
                return StatusCode(500, "An error occurred while retrieving active courses.");
            }
        }

        // Get course by ID
        [HttpGet("{id}")]
        public ActionResult<Course> GetCourseById(int id)
        {
            try
            {
                var course = _courseRepository.GetCourseById(id);
                return Ok(course);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving a course: " + ex.Message);
                return StatusCode(500, "An error occurred while retrieving a course.");
            }
        }

        // Add new Course
        [HttpPost]
        public ActionResult<Course> CreateCourse(Course course)
        {
            course.IsActive = true;
            _courseRepository.InsertCourse(course);

            return Ok(new { result = "added" });
        }

        // Update a Course
        [HttpPut("{id}")]
        public ActionResult<Course> UpdateCourse(int id, Course updatedCourse)
        {
            var course = _courseRepository.GetCourseById(id);
            if (course == null)
                return NotFound();

            course.Name = updatedCourse.Name;
            course.Description = updatedCourse.Description;
            course.Price = updatedCourse.Price;
            course.IsActive = updatedCourse.IsActive;
            course.DatetimeCreated = updatedCourse.DatetimeCreated;

            // Call the UpdateCourse() method to update the course in the database
            _courseRepository.UpdateCourse(course);

            return Ok(new { result = "updated", course });
        }

        // Archive a course
        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id)
        {
            var course = _courseRepository.GetCourseById(id);
            if (course == null)
                return NotFound();

            course.IsActive = false;
            _courseRepository.UpdateCourse(course);

            return Ok(new { result = "deleted" });
        }

    }

}
