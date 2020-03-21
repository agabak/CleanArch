using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>, IRequestHandler<EditCourseCommand, bool>, IRequestHandler<DeleteCourseCommand, bool>
    {
        private readonly ICourseRepository _repository;

        public CourseCommandHandler(ICourseRepository repository)
        {
            _repository = repository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                Name = request.Name,
                CourseDescription = request.Description,
                ImageUrl = request.ImageUrl
            };

            _repository.Add(course);
            return Task.FromResult(true);
        }

        public Task<bool> Handle(EditCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {   Id = request.Id,
                Name = request.Name,
                CourseDescription = request.Description,
                ImageUrl = request.ImageUrl
            };

            _repository.Edit(course);
            return Task.FromResult(true);
        }

        public Task<bool> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course
            {
                Id = request.Id
            };
            _repository.Delete(course);
            return Task.FromResult(true);
        }
    }
}
