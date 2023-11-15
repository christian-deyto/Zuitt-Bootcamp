using course_booking_cs.Database;
using course_booking_cs.Models;

namespace course_booking_cs.Data
{
    public class CourseRepository
    {
        private readonly AppDbContext _dbContext;

        public CourseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Course> GetAllCourses()
        {
            return _dbContext.Courses.ToList();
        }

        public List<Course> GetActiveCourses()
        {
            return _dbContext.Courses.Where(c => c.IsActive == true).ToList();
        }

        public Course GetCourseById(int courseId)
        {
            return _dbContext.Courses.Find(courseId);
        }

        public void InsertCourse(Course course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            _dbContext.Courses.Update(course);
            _dbContext.SaveChanges();
        }

        public void ArchiveCourse(int courseId)
        {
            var course = _dbContext.Courses.Find(courseId);
            if (course != null)
            {
                course.IsActive = false;
                _dbContext.SaveChanges();
            }
        }
    }
}

