//using System;
namespace course_booking_cs.Models
{
    public class CourseEnrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime DatetimeEnrolled { get; set; }
    }

    public class EnrollmentDTO
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}

