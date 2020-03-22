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
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository courseRepository, 
                             IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }


        public void Create(CreateCourseViewModel model)
        {
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(model));
        }

        public void Edit(EditCourseViewModel model)
        {
            _bus.SendCommand(_mapper.Map<EditCourseCommand>(model));
        }

        public void Delete(DeleteCourseViewModel model)
        {
            _bus.SendCommand(_mapper.Map<DeleteCourseCommand>(model));
        }
    }
}
