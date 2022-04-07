using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectUdemi.Api.DataModels;
using ProjectUdemi.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUdemi.Api.Controllers
{

    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IstudentRepository istudentRepository;
        private readonly IMapper mapper;
        public StudentsController(IstudentRepository istudentRepository,IMapper mapper)
        {
            this.istudentRepository = istudentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentAsync()
        {
            var students = await istudentRepository.GetStudentsAsync();
           
            return Ok(mapper.Map<List<Student>>(students));
        }

    }
}

   
            


