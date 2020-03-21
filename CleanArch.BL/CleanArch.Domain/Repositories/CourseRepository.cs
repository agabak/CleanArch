using CleanArch.Domain.Interfaces;
using CleanArch.Info.Data.Context;
using CleanArch.Info.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CleanArch.Domain.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext  context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
