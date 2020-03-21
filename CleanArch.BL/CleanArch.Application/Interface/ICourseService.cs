using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interface
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel model);
        void Edit(CourseViewModel model);
        void Delete(CourseViewModel model);
    }
}
