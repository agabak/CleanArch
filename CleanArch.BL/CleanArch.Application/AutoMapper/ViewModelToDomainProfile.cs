using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class ViewModelToDomainProfile: Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateCourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));

            CreateMap<CourseCommand, Course>();

            CreateMap<EditCourseViewModel, EditCourseCommand>()
                .ConstructUsing(c => new EditCourseCommand(c.Id, c.Name, c.Description, c.ImageUrl));
            CreateMap<DeleteCourseViewModel, DeleteCourseCommand>()
                .ConstructUsing(c => new DeleteCourseCommand(c.Id));
        }
    }
}
