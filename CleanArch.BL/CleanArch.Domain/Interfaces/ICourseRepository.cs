
using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
        void Edit(Course course);
        void Delete(Course course);
    }
}
