using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NDHTHI.Models;

namespace NDHTHI.Data
{
    public class NDHTHIContext : DbContext
    {
        public NDHTHIContext (DbContextOptions<NDHTHIContext> options)
            : base(options)
        {
        }

        public DbSet<NDHTHI.Models.Student> Student { get; set; } = default!;

        public DbSet<NDHTHI.Models.Faculty> Faculty { get; set; } = default!;
    }
}
