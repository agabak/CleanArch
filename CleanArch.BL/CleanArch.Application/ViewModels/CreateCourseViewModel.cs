﻿
using CleanArch.Domain.Models;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class CreateCourseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string  ImageUrl { get; set; }
    }
}
