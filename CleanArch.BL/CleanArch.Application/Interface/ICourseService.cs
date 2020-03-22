using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interface
{
    public interface ICourseService
    {
         IEnumerable<CourseViewModel> GetCourses();
        void Create(CreateCourseViewModel model);
        void Edit(EditCourseViewModel model);
        void Delete(DeleteCourseViewModel model);
    }
}
