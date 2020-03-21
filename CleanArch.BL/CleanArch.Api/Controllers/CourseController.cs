using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interface;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService  service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult  Post([FromBody]  CourseViewModel model)
        {
            _service.Create(model);
            return Ok(model);
        }
    }
}