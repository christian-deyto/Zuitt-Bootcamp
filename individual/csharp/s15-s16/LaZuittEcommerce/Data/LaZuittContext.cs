using LaZuittEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace LaZuittEcommerce.Data
{
    public class LaZuittContext : DbContext
    {

        public LaZuittContext(DbContextOptions<LaZuittContext> options) : base(options)
        {
        }
            public DbSet<Course> Course { get; set; }
            public DbSet<Student> Student { get; set; }
            public DbSet<Enroll> Enroll { get; set; }
            public DbSet<EnrollCourses> EnrollCourses { get; set; }

            public DbSet<OrderHistory> OrderHistory { get; set; }
        
    }
}
