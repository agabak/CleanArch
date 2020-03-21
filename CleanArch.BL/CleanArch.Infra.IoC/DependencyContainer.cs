using CleanArch.Application.Interface;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Info.Data.Context;
using CleanArch.Info.Data.Repositories;
using CleanArch.Infra.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        
        // static because need to available all the time
        public static void RegisterService(IServiceCollection services)
        {
            // Domain InMemory Mediator
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            services.AddScoped<IRequestHandler<EditCourseCommand, bool>, CourseCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteCourseCommand, bool>, CourseCommandHandler>();

            //Application Layer 
            services.AddScoped<ICourseService, CourseService>();

            // Data Layer 
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDbContext>();

        }
    }
}
