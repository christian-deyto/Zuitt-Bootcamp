using course_booking_cs.Database;
using course_booking_cs.Models;

namespace course_booking_cs.Data
{
    public class CourseEnrollmentRepository
    {
        private readonly AppDbContext _dbContext;

        public CourseEnrollmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertCourseEnrollment(CourseEnrollment enrollment)
        {
            _dbContext.CourseEnrollments.Add(enrollment);
            _dbContext.SaveChanges();
        }

        public CourseEnrollment GetCourseEnrollmentByCourseIdAndUserId(int courseId, int userId)
        {
            return _dbContext.CourseEnrollments.FirstOrDefault(c => c.CourseId == courseId && c.UserId == userId);
        }
    }
}

