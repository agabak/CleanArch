
using CleanArch.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
        void Edit(Course course);
        void Delete(Course course);
    }
}
