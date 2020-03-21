using CleanArch.Info.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Info.Data.Context
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
