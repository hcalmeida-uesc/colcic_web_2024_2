using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UescColcicAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static readonly List<Student> Students = new()
        {
            new Student { Name = "Douglas", Email = "douglas.cic@uesc.br" },
            new Student { Name = "Estevão", Email = "estevao.cic@uesc.br" },
            new Student { Name = "Gabriel", Email = "gabriel.cic@uesc.br" },
            new Student { Name = "Gabriela", Email = "gabriela.cic@uesc.br" }
        };

        [HttpGet(Name = "GetStudentsNames")]
        public IEnumerable<Student> Get()
        {
            return Students.ToArray();
        }
    }
