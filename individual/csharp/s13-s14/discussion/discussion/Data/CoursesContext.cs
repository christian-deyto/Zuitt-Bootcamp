using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using discussion.Models;

namespace discussion.Data
{
    public class CoursesContext : DbContext
    {
        public CoursesContext (DbContextOptions<CoursesContext> options)
            : base(options)
        {
        }

        public DbSet<discussion.Models.Course> Course { get; set; } = default!;
    }
}
