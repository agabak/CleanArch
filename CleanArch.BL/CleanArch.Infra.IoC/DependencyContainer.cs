using CleanArch.Application.Interface;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Info.Data.Repositories;
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
            //Application Layer 
            services.AddScoped<ICourseService, CourseService>();

            // Data Layer 
            services.AddScoped<ICourseRepository, CourseRepository>();


        }
    }
}
