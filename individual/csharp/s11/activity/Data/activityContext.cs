using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using activity.Models;

namespace activity.Data
{
    public class activityContext : DbContext
    {
        public activityContext (DbContextOptions<activityContext> options)
            : base(options)
        {
        }

        public DbSet<activity.Models.Products> Products { get; set; } = default!;
    }
}
