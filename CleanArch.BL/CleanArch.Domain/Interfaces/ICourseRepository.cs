using CleanArch.Info.Data.Models;
using System.Collections.Generic;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
