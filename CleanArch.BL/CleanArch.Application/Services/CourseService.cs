using CleanArch.Application.Interface;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CleanArch.Domain.Models;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Commands;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }


        public void Create(CourseViewModel model)
        {
            var createCourseCommand = new CreateCourseCommand(
                 model.Name, model.Description,model.ImageUrl);

            _bus.SendCommand(createCourseCommand);
        }
    }
}