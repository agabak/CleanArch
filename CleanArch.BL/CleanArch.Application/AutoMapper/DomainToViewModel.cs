using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public  class DomainToViewModel: Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
