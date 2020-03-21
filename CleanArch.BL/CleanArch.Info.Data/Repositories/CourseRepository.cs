using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Info.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Info.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Edit(Course course)
        {
            var courseToEdit = _context.Courses.FirstOrDefault(x => x.Id == course.Id);
            if(courseToEdit != null)
            {
                courseToEdit.Name = course.Name;
                courseToEdit.CourseDescription = course.CourseDescription;
                courseToEdit.ImageUrl = course.ImageUrl;
                _context.SaveChanges();
            }    
        }

        public void Delete(Course course)
        {
            var courseToDelete = _context.Courses.FirstOrDefault(x => x.Id == course.Id);
            if(courseToDelete != null)
            {
                _context.Courses.Remove(courseToDelete);
                _context.SaveChanges();
            }
        }
    }
}
