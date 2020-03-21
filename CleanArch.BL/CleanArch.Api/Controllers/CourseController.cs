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

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CourseViewModel model, int id)
        {
            if (id < 0) return BadRequest("Unvalide ID");
            model.Id = id;
            _service.Edit(model);
            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] CourseViewModel model, int id)
        {
            if (id < 0) return BadRequest();
            model.Id = id;
            _service.Delete(model);
            return NoContent();
        }
    }
} 